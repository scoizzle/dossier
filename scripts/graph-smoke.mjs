#!/usr/bin/env node
// Smoke test for src/Dossier/www/graph.js. Runs the exact script bytes in a vm context with a minimal
// DOM/canvas stub, feeds it the committed API fixture (tests/Dossier.Tests/fixtures/graph-api.json, kept
// byte-identical to the real /api/graph output by a .NET test) plus a truncated variant and an XSS payload,
// and checks rendering, focus/zoom/keyboard behaviour, merge, the truncation banner and that untrusted
// text never becomes markup, a link target or a navigation.
// GRAPH_JS may point at an alternative script (used to prove the checks fail on unsafe code).
import { readFileSync } from 'node:fs';
import { fileURLToPath } from 'node:url';
import path from 'node:path';
import vm from 'node:vm';

const here = path.dirname(fileURLToPath(import.meta.url));
const root = path.join(here, '..');
const source = readFileSync(process.env.GRAPH_JS || path.join(root, 'src', 'Dossier', 'www', 'graph.js'), 'utf8');
const fixtureText = readFileSync(process.env.GRAPH_FIXTURE || path.join(root, 'tests', 'Dossier.Tests', 'fixtures', 'graph-api.json'), 'utf8');
const fixture = JSON.parse(fixtureText);

const W = 800;
const H = 600;
const ALLOWED_TAGS = new Set(['DIV', 'SPAN', 'BUTTON', 'CANVAS', 'ASIDE', 'H2', 'H3', 'DL', 'DT', 'DD', 'P', 'PRE', 'UL', 'LI', 'A']);
const HREF_OK = /^#\/(subject|fact|graph)\/[A-Za-z0-9_%-]+$/;
const EVIL = ['<img src=x onerror=alert(1)>', 'javascript:alert(1)', '"><script>alert(1)</script>'];

let failed = 0;
function ok(cond, msg) {
  if (cond) console.log('PASS ' + msg);
  else { failed++; console.error('FAIL ' + msg); }
}

const clone = (v) => JSON.parse(JSON.stringify(v));
const brief = (list) => (list.length ? ': ' + list.length + ' e.g. ' + list.slice(0, 2).join('; ') : '');

function makeEnv(reduce) {
  const state = { activeElement: null };
  const violations = []; // anything that could turn data into markup, links or navigation
  const created = [];

  class El {
    constructor(tag) {
      this.tagName = tag.toUpperCase();
      this.children = [];
      this.attrs = {};
      this.listeners = {};
      this.className = '';
      this.hidden = false;
      this.style = {};
      this._text = '';
      this.id = '';
      this.type = '';
      this.width = 0;
      this.height = 0;
      created.push(this);
    }
    get textContent() { return this._text + this.children.map((c) => c.textContent).join(''); }
    set textContent(v) {
      if (state.activeElement && this.contains(state.activeElement)) state.activeElement = null; // removed node loses focus
      this._text = String(v);
      this.children = [];
    }
    set innerHTML(v) { violations.push('innerHTML=' + String(v).slice(0, 60)); }
    set outerHTML(v) { violations.push('outerHTML=' + String(v).slice(0, 60)); }
    insertAdjacentHTML(_where, v) { violations.push('insertAdjacentHTML ' + String(v).slice(0, 60)); }
    set href(v) { violations.push('href property=' + String(v).slice(0, 60)); }
    set src(v) { violations.push('src property=' + String(v).slice(0, 60)); }
    contains(n) { return n === this || this.children.some((c) => c.contains(n)); }
    focus() { state.activeElement = this; }
    appendChild(c) { this.children.push(c); return c; }
    setAttribute(k, v) {
      this.attrs[k] = String(v);
      if (k === 'href' && !HREF_OK.test(String(v))) violations.push('href attribute=' + v);
      if (/^on/i.test(k) || k === 'src' || k === 'srcdoc' || k === 'style') violations.push('attribute ' + k + '=' + v);
    }
    getAttribute(k) { return k in this.attrs ? this.attrs[k] : null; }
    addEventListener(t, fn) { (this.listeners[t] ||= []).push(fn); }
    fire(t, ev = {}) { (this.listeners[t] || []).forEach((fn) => fn({ preventDefault() {}, ...ev })); }
    getBoundingClientRect() { return { left: 0, top: 0, width: W, height: H }; }
    setPointerCapture() {}
    hasPointerCapture() { return false; }
    releasePointerCapture() {}
    all(pred, out = []) {
      for (const c of this.children) { if (pred(c)) out.push(c); c.all(pred, out); }
      return out;
    }
    byClass(cls) { return this.all((c) => c.className.split(/\s+/).includes(cls)); }
    byTag(tg) { return this.all((c) => c.tagName === tg.toUpperCase()); }
  }

  // The canvas stub records the transform history and every stroked segment, with the paint state
  // (alpha, style, width) it was stroked under, so the drawing itself can be asserted on.
  const transforms = [];
  const calls = [];
  const paint = { lineWidth: 1, globalAlpha: 1, strokeStyle: '#000', fillStyle: '#000', font: '10px system-ui', textAlign: 'start', textBaseline: 'alphabetic' };
  let ops = [];
  const recorder = {
    setTransform: (...a) => transforms.push(a),
    beginPath: () => { ops = []; },
    moveTo: (x, y) => { ops.push(['moveTo', x, y]); },
    lineTo: (x, y) => { ops.push(['lineTo', x, y]); },
    stroke: () => {
      const path = ops.length >= 2 && ops[0][0] === 'moveTo' && ops[1][0] === 'lineTo'
        ? { from: [ops[0][1], ops[0][2]], to: [ops[1][1], ops[1][2]] }
        : { from: null, to: null };
      calls.push({ ...path, alpha: paint.globalAlpha, lineWidth: paint.lineWidth, style: paint.strokeStyle });
    },
  };
  const ctx = new Proxy(recorder, {
    get: (t, k) => (k in t ? t[k] : (k in paint ? paint[k] : () => {})),
    set: (t, k, v) => { paint[k] = v; return true; },
  });

  const docListeners = {};
  const document = {
    createElement: (tg) => {
      const e = new El(tg);
      if (tg === 'canvas') e.getContext = () => ctx;
      return e;
    },
    addEventListener: (t, fn) => (docListeners[t] ||= []).push(fn),
    removeEventListener: (t, fn) => { docListeners[t] = (docListeners[t] || []).filter((f) => f !== fn); },
    write: (v) => violations.push('document.write ' + v),
    get activeElement() { return state.activeElement; },
  };

  // Navigation is recorded through a proxy: any set, assign() or replace() counts.
  const navigation = [];
  const locationProxy = new Proxy({}, {
    get: (t, k) => (k === 'assign' || k === 'replace' ? (...a) => navigation.push(String(k) + ':' + a.join()) : undefined),
    set: (t, k, v) => { navigation.push('set ' + String(k) + '=' + v); return true; },
  });

  const rafQueue = [];
  const counters = { frames: 0 };
  const winListeners = {};
  const window = {
    matchMedia: () => ({ matches: reduce }),
    devicePixelRatio: 1,
    requestAnimationFrame: reduce ? (fn) => fn() : (fn) => { rafQueue.push(fn); return rafQueue.length; },
    cancelAnimationFrame() {},
    addEventListener: (t, fn) => (winListeners[t] ||= []).push(fn),
    removeEventListener: (t, fn) => { winListeners[t] = (winListeners[t] || []).filter((f) => f !== fn); },
    fetch: () => { violations.push('window.fetch called'); return Promise.reject(new Error('unexpected fetch')); },
  };
  Object.defineProperty(window, 'location', { get: () => locationProxy, set: (v) => navigation.push('window.location=' + v) });

  const sandbox = { window, document, Math, Infinity, parseInt, String, Number, Object, Array, JSON };
  vm.createContext(sandbox);
  try {
    vm.runInContext(source, sandbox, { filename: 'graph.js' });
  } catch (err) {
    console.error('FAIL graph.js threw while bootstrapping: ' + err.message);
    process.exit(1);
  }

  const runFrames = (limit) => {
    let n = 0;
    while (rafQueue.length && n < limit) { rafQueue.shift()(); n++; counters.frames++; }
    return n;
  };

  // Mounts DossierGraph on a stub host; fetchJson answers from `respond(url)`.
  async function mount(rootId, respond, options = {}) {
    const host = new El('div');
    const urls = [];
    const api = sandbox.window.DossierGraph;
    const instance = api.mount(host, rootId, {
      ...options,
      fetchJson: (url) => { urls.push(url); return Promise.resolve(clone(respond(url))); },
    });
    await instance.ready;
    return { host, instance, urls };
  }

  return { El, state, violations, created, navigation, docListeners, winListeners, transforms, calls, runFrames, counters, mount, window };
}

const ids = (list) => list.map((n) => n.id);

// ---- scenario: the committed API fixture, interaction as in the original page ------------
async function interactionScenario(name, reduce) {
  const tag = '[' + name + '] ';
  const check = (cond, msg) => ok(cond, tag + msg);
  const env = makeEnv(reduce);
  const { host, instance } = await env.mount(fixture.root, () => fixture);
  const panel = host.byTag('aside')[0];
  const canvas = host.byTag('canvas')[0];
  const counts = host.byClass('g-counts')[0];
  const banner = host.byClass('g-banner')[0];
  const last = () => env.transforms[env.transforms.length - 1];

  const expectedRefs = fixture.edges.length;
  check(counts.textContent === fixture.subjects.length + ' subjects, ' + fixture.facts.length + ' facts, ' + expectedRefs + ' refs',
    'bootstrap: counts = "' + counts.textContent + '"');
  const hiddenSum = fixture.truncated.subjects + fixture.truncated.facts + fixture.truncated.edges;
  check(banner.hidden === (hiddenSum === 0), 'banner visibility matches the fixture truncation (hidden=' + hiddenSum + ')');
  if (!reduce) env.runFrames(3);

  const headingEl = () => panel.byTag('h2')[0] || null;
  const heading = () => (headingEl() ? headingEl().textContent : null);
  const click = (x, y) => {
    canvas.fire('pointerdown', { clientX: x, clientY: y, pointerId: 1 });
    canvas.fire('pointerup', { clientX: x, clientY: y, pointerId: 1 });
  };
  const key = (k) => (env.docListeners.keydown || []).forEach((fn) => fn({ key: k }));
  function openWhere(pred) {
    for (let y = 10; y < H; y += 6) {
      for (let x = 10; x < W; x += 6) {
        click(x, y);
        if (!panel.hidden && pred()) return true;
        if (!panel.hidden) key('Escape');
      }
    }
    return false;
  }

  check(openWhere(() => true), 'canvas click on a node opens the panel (heading "' + heading() + '")');
  check(headingEl() && env.state.activeElement === headingEl() && headingEl().getAttribute('tabindex') === '-1',
    'node click moves focus to the panel heading (tabindex=-1)');
  key('Escape');
  check(panel.hidden === true, 'Escape closes the panel');

  const found = openWhere(() => panel.byClass('ref').length > 0);
  check(found, 'panel shows a .ref button for a resolved ref');
  if (!found) return;

  const btn = panel.byClass('ref')[0];
  const target = btn.getAttribute('data-target');
  check(btn.tagName === 'BUTTON' && btn.type === 'button', 'ref control is a <button type="button">');
  const targetNode = instance.nodes.find((n) => n.id === target);
  check(!!targetNode, 'ref button targets an existing node "' + target + '"');
  check(btn.getAttribute('aria-label') === 'Open ' + targetNode.type + ' ' + target, 'ref button aria-label = "' + btn.getAttribute('aria-label') + '"');
  check(panel.byTag('a').every((a) => HREF_OK.test(a.getAttribute('href'))), 'panel anchors are only #/subject|fact|graph/<id> links');

  canvas.fire('wheel', { deltaY: -400, clientX: 100, clientY: 100 });
  if (!reduce) env.runFrames(1);
  const before = heading();
  const beforeT = last();
  btn.fire('click');
  const afterT = last();
  check(beforeT[0] !== 1 && beforeT[0] === afterT[0], 'ref click preserves the zoom (scale ' + beforeT[0] + ' -> ' + afterT[0] + ')');
  check(before !== heading(), 'clicking the ref switches the panel heading ("' + before + '" -> "' + heading() + '")');
  check(beforeT.slice(4).join() !== afterT.slice(4).join(), 'clicking the ref recentres the view');
  check(headingEl() && env.state.activeElement === headingEl(), 'ref click moves focus to the new panel heading (not <body>)');

  if (!reduce) {
    const again = panel.byClass('ref')[0];
    const scaleBefore = last()[0];
    if (again) again.fire('click');
    const t0 = last();
    const ran = env.runFrames(400);
    const t1 = last();
    check(ran >= 30, 'drove ' + ran + ' rAF frames after the ref click (>= 30)');
    check(t1[0] === t0[0] && t1[4] === t0[4] && t1[5] === t0[5], 'transform stable after frames (late fit() did not override)');
    check(t0[0] === scaleBefore, 'zoom preserved across the second ref click');
  }

  // Keyboard: 'f' fits the whole graph back into view, then the fact with an external ref shows it as text.
  key('Escape');
  key('f');
  if (!reduce) env.runFrames(400);
  check(openWhere(() => heading() === 'Fact f-root-1'), 'opened the fact with an external ref');
  const external = panel.byTag('li').filter((li) => li.textContent.includes('(external)'));
  check(external.length === 1 && external[0].byTag('button').length === 0 && external[0].textContent.includes('django.db.models.QuerySet.filter@e4f3fb2d2d11'),
    'external (symbol) ref is plain text, never a node or button');
  const ambiguous = panel.byTag('li').filter((li) => li.textContent.includes('ambiguous name'));
  check(ambiguous.length === 2, 'both ambiguous subject edges are labelled (' + ambiguous.length + ')');
  check(panel.byTag('a').some((a) => a.getAttribute('href') === '#/fact/f-root-1'), 'fact panel links to #/fact/<id>');

  key('Escape');
  check(openWhere(() => heading() === 'Acme'), 'opened the root subject');
  check(panel.byTag('a').map((a) => a.getAttribute('href')).join() === '#/subject/s-root,#/graph/s-root', 'subject panel links to #/subject/<id> and #/graph/<id>');

  check(env.navigation.length === 0, 'navigation proxy clean' + brief(env.navigation));
  check(env.violations.length === 0, 'no markup/href/fetch violations' + brief(env.violations));
  if (!reduce) check(env.counters.frames >= 30, 'animated scenario really ran frame() (' + env.counters.frames + ' frames)');

  instance.destroy();
  check((env.docListeners.keydown || []).length === 0 && (env.winListeners.resize || []).length === 0, 'destroy() removes document/window listeners');
}

// ---- scenario: merge keeps positions, expansion fetches a neighbourhood -----------------
async function mergeScenario() {
  const tag = '[merge] ';
  const check = (cond, msg) => ok(cond, tag + msg);

  const extension = {
    format: 1, seed: 'cafe0001', root: 's-lib',
    subjects: [
      { id: 's-lib', name: 'Lib', kind: 'module', parent: 's-core', facts: 1 },
      { id: 's-new1', name: 'New one', kind: 'module', parent: 's-lib', facts: 0 },
      { id: 's-new2', name: 'New two', kind: 'module', parent: 's-lib', facts: 0 },
    ],
    facts: [{ id: 'f-lib-1', subject: 's-lib', kind: 'note', status: 'live', confidence: 0.9, tags: [], text: 'lib fact', unresolved: [] }],
    edges: [
      { from_kind: 'subject', from: 's-lib', to_kind: 'subject', to: 's-new1', rel: 'contains', basis: 'structure', kind: 'contains' },
      { from_kind: 'subject', from: 's-lib', to_kind: 'subject', to: 's-new2', rel: 'contains', basis: 'structure', kind: 'contains' },
    ],
    unresolved: [], truncated: { subjects: 5, facts: 2, edges: 1 }, limits: { max_nodes: 500, depth: 1 },
  };

  async function run() {
    const env = makeEnv(true);
    const respond = (url) => (url.includes('subject=s-lib') ? extension : fixture);
    const m = await env.mount(fixture.root, respond);
    return { env, ...m };
  }

  const a = await run();
  const snapshot = new Map(a.instance.nodes.map((n) => [n.key, [n.x, n.y]]));
  const nodeCount = a.instance.nodes.length;
  const added = a.instance.merge(extension, 'subject:s-lib');
  check(added.length === 2 && ids(added).join() === 's-new1,s-new2', 'merge adds only the new nodes (' + ids(added).join() + ')');
  check(a.instance.nodes.length === nodeCount + 2, 'node count grows by the new nodes only');
  check([...snapshot].every(([k, xy]) => { const n = a.instance.nodes.find((x) => x.key === k); return n.x === xy[0] && n.y === xy[1]; }),
    'merge keeps every existing node position');
  check(added.every((n) => Number.isFinite(n.x) && Number.isFinite(n.y)), 'new nodes are placed at finite positions');
  const before = a.instance.edges.length;
  a.instance.merge(extension, 'subject:s-lib');
  check(a.instance.edges.length === before && a.instance.nodes.length === nodeCount + 2, 'merging the same payload twice adds nothing (edges de-duplicated)');
  const banner = a.host.byClass('g-banner')[0];
  check(banner.hidden === false && banner.textContent.startsWith('8 hidden'), 'truncation banner shows "n hidden": "' + banner.textContent + '"');

  // Deterministic seeding: an independent run places the new nodes identically.
  const b = await run();
  b.instance.merge(extension, 'subject:s-lib');
  const pos = (inst) => inst.nodes.map((n) => n.key + '@' + n.x + ',' + n.y).join('|');
  check(pos(a.instance) === pos(b.instance), 'new nodes are seeded deterministically (identical positions across runs)');

  // Double-click expands: fetches that subject's neighbourhood and merges it.
  const c = await run();
  const lib = c.instance.nodes.find((n) => n.key === 'subject:s-lib');
  const stable = c.instance.nodes.map((n) => [n.key, n.x, n.y]);
  const canvas = c.host.byTag('canvas')[0];
  const v = c.instance.view;
  canvas.fire('dblclick', { clientX: lib.x * v.scale + v.tx, clientY: lib.y * v.scale + v.ty });
  await new Promise((resolve) => setTimeout(resolve, 0));
  const hasNew = c.instance.nodes.some((n) => n.id === 's-new1');
  check(c.urls.length === 2 && c.urls[1] === '/api/graph?subject=s-lib&depth=1&facts=true&max_nodes=500', 'double-click fetches ' + c.urls[1]);
  check(hasNew, 'double-click expansion merges the fetched neighbourhood');
  check(stable.every(([k, x, y]) => { const n = c.instance.nodes.find((q) => q.key === k); return n.x === x && n.y === y; }),
    'expansion leaves existing positions untouched');
  check(c.env.violations.length === 0 && c.env.navigation.length === 0, 'expansion produced no violations or navigation');
  a.instance.destroy(); b.instance.destroy(); c.instance.destroy();
}

// ---- scenario: truncated variant ------------------------------------------------------------
async function truncationScenario() {
  const truncated = clone(fixture);
  truncated.truncated = { subjects: 3, facts: 4, edges: 2 };
  const env = makeEnv(true);
  const { host, instance } = await env.mount(truncated.root, () => truncated);
  const banner = host.byClass('g-banner')[0];
  ok(banner.hidden === false && banner.textContent.startsWith('9 hidden (3 subjects, 4 facts, 2 refs)'), '[truncated] banner reads "' + banner.textContent + '"');
  const clean = clone(fixture);
  clean.truncated = { subjects: 0, facts: 0, edges: 0 };
  const env2 = makeEnv(true);
  const m2 = await env2.mount(clean.root, () => clean);
  ok(m2.host.byClass('g-banner')[0].hidden === true, '[truncated] banner hidden when nothing is truncated');
  instance.destroy(); m2.instance.destroy();
}

// ---- scenario: untrusted data never becomes markup, a link or a navigation ------------------
async function xssScenario(reduce) {
  const tag = '[xss ' + (reduce ? 'reduced' : 'animated') + '] ';
  const check = (cond, msg) => ok(cond, tag + msg);
  const [img, js, script] = EVIL;
  const payload = {
    format: 1, seed: '00000042', root: 's-evil',
    subjects: [
      { id: 's-evil', name: img, kind: js, parent: null, facts: 2 },
      { id: js, name: script, kind: img, parent: 's-evil', facts: 0 },
      { id: 's-ok', name: 'ok ' + js, kind: 'module', parent: 's-evil', facts: 0, boundary: true },
    ],
    facts: [
      { id: 'f-evil-1', subject: 's-evil', kind: script, key: img, text: img + '\n' + js + '\n' + script, status: js, confidence: 0.5, tags: [img, js, script],
        unresolved: [{ rel: img, basis: js, kind: script, target: js }] },
      { id: script, subject: 's-evil', kind: 'note', text: script, status: 'live', confidence: 1, tags: [], unresolved: [] },
    ],
    edges: [
      { from_kind: 'fact', from: 'f-evil-1', to_kind: 'fact', to: script, rel: img, basis: js, kind: 'slot', slot: script, ambiguous: true },
      { from_kind: 'fact', from: 'f-evil-1', to_kind: 'subject', to: js, rel: script, basis: img, kind: js, slot: img },
      { from_kind: 'subject', from: 's-evil', to_kind: 'subject', to: 's-ok', rel: 'contains', basis: 'structure', kind: 'contains' },
      { from_kind: 'fact', from: 'f-evil-1', to_kind: 'subject', to: 's-ok', rel: 'about', basis: 'observed', kind: 'inbound' },
    ],
    unresolved: [{ from: 'f-evil-1', rel: img, kind: js, target: script, reason: img }],
    truncated: { subjects: 1, facts: 0, edges: 0 }, limits: { max_nodes: 500, depth: 1 },
  };
  const env = makeEnv(reduce);
  const { host, instance } = await env.mount('s-evil', () => payload);
  if (!reduce) env.runFrames(50);
  const panel = host.byTag('aside')[0];

  for (const n of instance.nodes) {
    instance.select(n.key);
    for (const a of panel.byTag('a')) {
      const href = a.getAttribute('href');
      check(HREF_OK.test(href), 'link "' + href + '" is a fixed-prefix id link');
    }
  }
  // The same payload through an expansion is merged and displayed identically.
  instance.merge(payload, 'subject:s-evil');

  instance.select('subject:s-evil');
  check(panel.textContent.includes(img), 'subject name is shown literally as text');
  instance.select('fact:f-evil-1');
  check(panel.textContent.includes(img) && panel.textContent.includes(js) && panel.textContent.includes(script), 'fact text, rel and slot key are shown literally as text');

  instance.select('subject:' + js);
  check(panel.byTag('a').length === 0, 'a subject whose id fails the id check gets no links at all');
  instance.select('fact:' + script);
  check(panel.byTag('a').length === 0, 'a fact whose id fails the id check gets no links at all');

  const unexpected = env.created.filter((e) => !ALLOWED_TAGS.has(e.tagName)).map((e) => e.tagName);
  check(unexpected.length === 0, 'no unexpected element nodes created' + (unexpected.length ? ': ' + unexpected.join() : ''));
  check(!env.created.some((e) => /^(IMG|SCRIPT|IFRAME)$/.test(e.tagName)), 'no img/script/iframe element exists');
  check(env.violations.length === 0, 'no innerHTML/href/src/on* assignment or fetch from data' + brief(env.violations));
  check(env.navigation.length === 0, 'no location/navigation from data' + brief(env.navigation));
  instance.merge({ format: 1, seed: '1', root: null, subjects: [{ id: 's-long', name: 'y'.repeat(5000), kind: 'k', parent: null, facts: 0 }], facts: [], edges: [], truncated: { subjects: 0, facts: 0, edges: 0 } }, null);
  instance.select('subject:s-long');
  check(panel.byTag('h2')[0].textContent.length <= 120, 'long names are length-capped in the panel');
  instance.destroy();
}

// ---- scenario: the truncation banner accumulates across merges (R1) ---------------------------
async function bannerAccumulationScenario() {
  const check = (cond, msg) => ok(cond, '[banner] ' + msg);
  const truncated = clone(fixture);
  truncated.truncated = { subjects: 3, facts: 4, edges: 2 };
  const env = makeEnv(true);
  const { host, instance } = await env.mount(truncated.root, () => truncated);
  const banner = host.byClass('g-banner')[0];
  check(banner.textContent.startsWith('9 hidden (3 subjects, 4 facts, 2 refs)'), 'initial banner "' + banner.textContent + '"');

  const extension = clone(fixture);
  extension.truncated = { subjects: 5, facts: 2, edges: 1 };
  instance.merge(extension, 'subject:' + fixture.root);
  check(banner.hidden === false && banner.textContent.startsWith('11 hidden (5 subjects, 4 facts, 2 refs)'), 'merge takes the larger count per category: "' + banner.textContent + '"');

  const clean = clone(fixture);
  clean.truncated = { subjects: 0, facts: 0, edges: 0 };
  instance.merge(clean, 'subject:' + fixture.root);
  check(banner.hidden === false && banner.textContent.startsWith('11 hidden (5 subjects, 4 facts, 2 refs)'), 'a clean merge does not hide earlier truncation: "' + banner.textContent + '"');

  // Navigating to a new root is a fresh mount: nothing is carried over.
  const env2 = makeEnv(true);
  const next = await env2.mount(fixture.root, () => clean);
  check(next.host.byClass('g-banner')[0].hidden === true, 'a fresh mount (new root) starts with no truncation');
  instance.destroy(); next.instance.destroy();
}

// ---- scenario: keys typed in controls are not shortcuts (R2) ----------------------------------
async function keyFocusScenario() {
  const check = (cond, msg) => ok(cond, '[keys] ' + msg);
  const env = makeEnv(true);
  const { host, instance, urls } = await env.mount(fixture.root, () => fixture);
  const settle = () => new Promise((resolve) => setTimeout(resolve, 0));
  const press = (k, target) => (env.docListeners.keydown || []).forEach((fn) => fn(target ? { key: k, target } : { key: k }));
  const view = () => [instance.view.scale, instance.view.tx, instance.view.ty].join();
  const canvas = host.byTag('canvas')[0];

  instance.select('subject:s-core'); // a node is selected, so Enter / e would expand it
  const base = urls.length;
  canvas.fire('wheel', { deltaY: -400, clientX: 100, clientY: 100 });
  const zoomed = view();

  for (const tag of ['INPUT', 'TEXTAREA', 'SELECT', 'BUTTON', 'A']) {
    const target = new env.El(tag);
    press('e', target); press('E', target); press('Enter', target); press('f', target); press('F', target);
    await settle();
    check(urls.length === base && view() === zoomed, tag + ' target: e / Enter / f do nothing (fetches ' + (urls.length - base) + ')');
  }
  const editable = new env.El('div');
  editable.isContentEditable = true;
  press('e', editable); press('f', editable);
  await settle();
  check(urls.length === base && view() === zoomed, 'contentEditable target: e / f do nothing');

  // Focus-based detection, for events that carry no target.
  const input = new env.El('input');
  env.state.activeElement = input;
  press('e'); press('f');
  await settle();
  check(urls.length === base && view() === zoomed, 'focus in an <input> (no event target): e / f do nothing');
  env.state.activeElement = null;

  press('f', canvas);
  check(view() !== zoomed, 'f on the canvas still fits the view');
  press('e', canvas);
  await settle();
  check(urls.length === base + 1, "e on the canvas still expands the selected node (" + (urls.length - base) + " fetch)");
  press('Enter', canvas);
  await settle();
  check(urls.length === base + 2, 'Enter on the canvas still expands the selected node');
  press('Escape', canvas);
  check(host.byTag('aside')[0].hidden === true, 'Escape on the canvas still closes the panel');
  instance.destroy();
}

// ---- scenario: expansion carries the view's depth and facts (R4) ------------------------------
async function expandParamsScenario() {
  const check = (cond, msg) => ok(cond, '[params] ' + msg);
  const settle = () => new Promise((resolve) => setTimeout(resolve, 0));
  const env = makeEnv(true);
  const { instance, urls } = await env.mount(fixture.root, () => fixture, { depth: 2, facts: false });
  check(urls[0] === '/api/graph?subject=s-root&depth=2&facts=false&max_nodes=500', 'initial request carries the view params: ' + urls[0]);
  await instance.expand(instance.nodes.find((n) => n.key === 'subject:s-core'));
  await settle();
  check(urls[1] === '/api/graph?subject=s-core&depth=2&facts=false&max_nodes=500', 'expansion carries depth=2&facts=false: ' + urls[1]);
  instance.destroy();

  const env2 = makeEnv(true);
  const plain = await env2.mount(fixture.root, () => fixture);
  await plain.instance.expand(plain.instance.nodes.find((n) => n.key === 'subject:s-core'));
  check(plain.urls[1] === '/api/graph?subject=s-core&depth=1&facts=true&max_nodes=500', 'defaults stay depth=1&facts=true: ' + plain.urls[1]);
  plain.instance.destroy();
}

// ---- scenario: the committed fixture carries hostile strings through real API output ----------
async function fixtureXssScenario(reduce) {
  const tag = '[fixture-xss ' + (reduce ? 'reduced' : 'animated') + '] ';
  const check = (cond, msg) => ok(cond, tag + msg);
  const strings = [];
  (function walk(v) { if (typeof v === 'string') strings.push(v); else if (v && typeof v === 'object') Object.values(v).forEach(walk); })(fixture);
  check(EVIL.every((e) => strings.some((t) => t.includes(e))), 'the fixture really contains all three hostile strings');
  const env = makeEnv(reduce);
  const { host, instance } = await env.mount(fixture.root, () => fixture);
  if (!reduce) env.runFrames(50);
  const panel = host.byTag('aside')[0];
  let shown = '';
  for (const n of instance.nodes) {
    instance.select(n.key);
    shown += panel.textContent + '\n';
    for (const a of panel.byTag('a')) check(HREF_OK.test(a.getAttribute('href')), 'link "' + a.getAttribute('href') + '" is a fixed-prefix id link');
  }
  check(EVIL.every((e) => shown.includes(e)), 'every hostile string is shown literally as panel text');
  const unexpected = env.created.filter((e) => !ALLOWED_TAGS.has(e.tagName)).map((e) => e.tagName);
  check(unexpected.length === 0, 'no unexpected element nodes created' + (unexpected.length ? ': ' + unexpected.join() : ''));
  check(env.violations.length === 0, 'no markup/href/src/on* assignment or fetch from fixture data' + brief(env.violations));
  check(env.navigation.length === 0, 'no navigation from fixture data' + brief(env.navigation));
  instance.destroy();
}

// ---- scenario: each fact is drawn attached to its owning subject ------------------------------
async function ownerLinkScenario() {
  const tag = '[owner-links] ';
  const check = (cond, msg) => ok(cond, tag + msg);
  const near = (a, b) => Math.abs(a[0] - b[0]) < 1e-9 && Math.abs(a[1] - b[1]) < 1e-9;
  const segKey = (a, b) => a[0] + ',' + a[1] + '>' + b[0] + ',' + b[1];
  const segmentsOf = (calls) => calls.filter((c) => c.from && c.to);

  const env = makeEnv(true);
  const { host, instance } = await env.mount(fixture.root, () => fixture);
  const counts = host.byClass('g-counts')[0];

  // The owner link is drawn, never merged: counts, the edge list and the degrees stay as they were.
  check(counts.textContent === fixture.subjects.length + ' subjects, ' + fixture.facts.length + ' facts, ' + fixture.edges.length + ' refs',
    'header refs count is still the payload edge count ("' + counts.textContent + '")');
  check(instance.edges.length === fixture.edges.length, 'owner links are not pushed into edges[] (' + instance.edges.length + ' edges)');
  check(instance.nodes.every((n) => n.type !== 'fact' || n.r === 3.5 + 1.2 * Math.sqrt(n.deg)),
    'fact radius still comes from the ref count alone (an owner link adds no degree)');

  const subjectIdOf = (n) => { const f = fixture.facts.find((x) => 'fact:' + x.id === n.key); return f ? f.subject : null; };
  const subjectIds = new Set(fixture.subjects.map((s) => s.id));
  const owned = instance.nodes.filter((n) => n.type === 'fact' && subjectIds.has(subjectIdOf(n)));
  const anchored = instance.nodes.filter((n) => n.type === 'fact' && n.anchor);
  check(owned.length > 0 && anchored.length === owned.length,
    'every fact whose subject is in the graph resolves its owner (' + anchored.length + '/' + owned.length + ')');

  const segments = segmentsOf(env.calls);
  const edgePairs = new Set();
  for (const ed of instance.edges) edgePairs.add(segKey([ed.a.x, ed.a.y], [ed.b.x, ed.b.y]));
  const edgeSegments = segments.filter((s) => edgePairs.has(segKey(s.from, s.to)));
  check(edgeSegments.length >= instance.edges.length, 'every payload edge is stroked (' + edgeSegments.length + '/' + instance.edges.length + ')');
  const faintest = edgeSegments.length ? Math.min(...edgeSegments.map((s) => s.alpha)) : 1;
  const faint = (s) => s.alpha < faintest;

  const unmatched = anchored.filter((n) => !segments.some((s) => near(s.from, [n.x, n.y]) && near(s.to, [n.anchor.x, n.anchor.y]) && faint(s)));
  check(unmatched.length === 0, 'every fact strokes a faint segment to its owner, ending at the subject' + brief(unmatched.map((n) => n.id)));
  const misplaced = anchored.filter((n) => segments.some((s) => near(s.from, [n.x, n.y]) && faint(s) && !near(s.to, [n.anchor.x, n.anchor.y])));
  check(misplaced.length === 0, 'no fact strokes an owner segment to anywhere but its subject' + brief(misplaced.map((n) => n.id)));

  // A fact whose subject is not in the graph has no owner, so it gets no line at all.
  env.calls.length = 0;
  instance.merge({
    format: 1, seed: '0badf00d', root: fixture.root, subjects: [],
    facts: [{ id: 'f-orphan', subject: 's-absent', kind: 'note', status: 'live', confidence: 0.5, tags: [], text: 'orphan', unresolved: [] }],
    edges: [], truncated: { subjects: 0, facts: 0, edges: 0 },
  }, null);
  const orphan = instance.nodes.find((n) => n.key === 'fact:f-orphan');
  check(!!orphan && orphan.anchor === null, 'a fact whose subject is not in the graph has no anchor');
  instance.select('subject:' + fixture.root);
  check(!segmentsOf(env.calls).some((s) => near(s.from, [orphan.x, orphan.y])), 'a fact with no owner draws no owner link');
  instance.destroy();
}

await interactionScenario('reduced-motion', true);
await interactionScenario('animated', false);
await ownerLinkScenario();
await mergeScenario();
await truncationScenario();
await bannerAccumulationScenario();
await keyFocusScenario();
await expandParamsScenario();
await fixtureXssScenario(true);
await fixtureXssScenario(false);
await xssScenario(true);
await xssScenario(false);

if (failed) { console.error(failed + ' check(s) failed'); process.exit(1); }
console.log('graph smoke: all checks passed');
