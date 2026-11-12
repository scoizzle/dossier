// Interactive, bounded graph view for `dossier serve`. Loaded as a classic script by index.html;
// app.js calls DossierGraph.mount(). Everything from /api/graph is untrusted data: it only ever
// reaches the DOM through textContent, and the only links built are '#/subject/<id>' and
// '#/fact/<id>' (fixed prefix + an id that passed ID_RE and was URL-encoded). Never href, location
// or innerHTML from data.
(function () {
  'use strict';

  var ID_RE = /^[A-Za-z0-9_-]{1,64}$/;
  var LABEL_MAX = 40;
  var BASIS = { observed: '#4cc38a', derived: '#5aa9ff', inferred: '#f2b24c', structure: '#4b5563' };
  var STATUS = { live: '#cfd8dc', contested: '#ff6b6b', stale: '#ffa94d', retracted: '#6b7280' };

  // ---- deterministic PRNG ---------------------------------------------------------------
  function mulberry32(a) {
    return function () {
      a |= 0; a = (a + 0x6D2B79F5) | 0;
      var t = Math.imul(a ^ (a >>> 15), 1 | a);
      t = (t + Math.imul(t ^ (t >>> 7), 61 | t)) ^ t;
      return ((t ^ (t >>> 14)) >>> 0) / 4294967296;
    };
  }

  function cap(text, max) {
    var s = String(text === undefined || text === null ? '' : text);
    return s.length > max ? s.slice(0, max - 1) + '…' : s;
  }

  function nodeKey(type, id) { return type + ':' + id; }

  function hashLink(type, id) {
    if (typeof id !== 'string' || !ID_RE.test(id)) return null;
    return '#/' + type + '/' + encodeURIComponent(id);
  }

  function mount(host, rootId, options) {
    options = options || {};
    var doc = document;
    var win = window;
    var fetchJson = options.fetchJson || function (url) {
      return win.fetch(url).then(function (r) {
        return r.json().then(function (body) {
          if (!r.ok) throw new Error(body && body.error ? String(body.error.message) : r.statusText);
          return body;
        });
      });
    };
    var maxNodes = options.maxNodes || 500;
    // The view's own parameters; an expansion asks for the same depth and facts setting.
    var viewDepth = Number.isInteger(options.depth) && options.depth >= 0 && options.depth <= 3 ? options.depth : 1;
    var viewFacts = options.facts === false || options.facts === 'false' ? 'false' : 'true';
    var reduced = !!(win.matchMedia && win.matchMedia('(prefers-reduced-motion: reduce)').matches);
    var dpr = win.devicePixelRatio || 1;

    // ---- DOM (text only) ----------------------------------------------------------------
    function el(tag, text, parent, cls) {
      var node = doc.createElement(tag);
      if (text !== undefined && text !== null) node.textContent = text;
      if (cls) node.className = cls;
      if (parent) parent.appendChild(node);
      return node;
    }

    host.textContent = '';
    var bar = el('div', null, host, 'g-bar');
    var counts = el('span', '', bar, 'g-counts');
    var fitButton = el('button', 'Fit', bar);
    fitButton.type = 'button';
    var banner = el('div', '', host, 'g-banner');
    banner.hidden = true;
    var status = el('div', '', host, 'g-status');
    var body = el('div', null, host, 'g-body');
    var stage = el('div', null, body, 'g-stage');
    var canvas = el('canvas', null, stage);
    canvas.setAttribute('tabindex', '0');
    canvas.setAttribute('aria-label', 'Graph of subjects and facts');
    var panel = el('aside', null, body, 'g-panel');
    panel.hidden = true;
    var ctx = canvas.getContext('2d');

    // ---- model ----------------------------------------------------------------------------
    var nodes = [];
    var nodeByKey = {};
    var edges = [];
    var edgeKeys = {};
    var hueCount = 0;
    var rootKey = null;
    // Hidden counts seen so far: the largest per category across the initial load and every merge, so a
    // later clean expansion never hides truncation that still applies. A new mount (new root) starts at 0.
    var truncatedSeen = { subjects: 0, facts: 0, edges: 0 };
    var destroyed = false;
    // Subjects the user expanded. A refresh re-fetches the root and each of them, so the view keeps
    // following the store without a new mount.
    var expandedList = [];
    var selectedChanged = false;

    // Radius follows the subject's fact count; a refresh recomputes it whenever it adopts new data.
    function subjectRadius(s) { return 8 + 2.5 * Math.sqrt(Math.max(0, Number(s.facts) || 0)); }

    function place(n, rand, anchor, disc) {
      var a = rand() * Math.PI * 2;
      var d = Math.sqrt(rand()) * disc;
      n.x = (anchor ? anchor.x : 0) + Math.cos(a) * d;
      n.y = (anchor ? anchor.y : 0) + Math.sin(a) * d;
      n.vx = 0;
      n.vy = 0;
      n.pinned = false;
      n.hold = false;
      nodes.push(n);
    }

    // Adopts a record a refresh re-delivered. Every fetched node comes back on every refresh, so the
    // open panel must follow a record that really moved on, not the mere presence of one.
    function adopt(nd, data) {
      if (nd === selected && JSON.stringify(nd.data) !== JSON.stringify(data)) selectedChanged = true;
      nd.data = data;
    }

    function edgeKey(e) {
      return [e.from_kind, e.from, e.to_kind, e.to, e.rel, e.basis, e.kind, e.slot || ''].join('\u001f');
    }

    // Adds what is new, keeps every existing node (and its position), refreshes degrees. Incoming data is
    // adopted in place. A retracted fact is never held: a held one is dropped, a new one is refused, so a
    // later refresh, expansion or reset that still carries it cannot bring it back. Superseded facts stay.
    // A boundary subject is a stub, so it never replaces the fuller record already held for that subject.
    function merge(payload, anchorKey, nearParent) {
      var rand = mulberry32(parseInt(payload.seed, 16) || 1);
      var anchor = anchorKey ? nodeByKey[anchorKey] || null : null;
      var added = [];
      var disc = anchor ? 70 : 60 * Math.sqrt((payload.subjects || []).length + (payload.facts || []).length + 1);
      var i;
      var subs = payload.subjects || [];
      var facts = payload.facts || [];
      for (i = 0; i < subs.length; i++) {
        var s = subs[i];
        var sk = nodeKey('subject', s.id);
        var held = nodeByKey[sk];
        if (held) {
          if (!s.boundary) {
            adopt(held, s);
            held.r = subjectRadius(s);
          }
          continue;
        }
        var sn = { type: 'subject', id: s.id, key: sk, data: s, hue: (hueCount++ * 47) % 360, deg: 0, anchor: null, r: subjectRadius(s) };
        nodeByKey[sk] = sn;
        // A refreshed root anchors a new subject next to its parent, so the layout grows where it belongs.
        var near = nearParent && s.parent ? nodeByKey[nodeKey('subject', s.parent)] || null : null;
        var at = near || anchor;
        place(sn, rand, at, at ? 70 : disc);
        added.push(sn);
      }
      for (i = 0; i < facts.length; i++) {
        var f = facts[i];
        if (!f || !f.id) continue;
        if (f.status === 'retracted') { drop(nodeKey('fact', f.id)); continue; }
        var fk = nodeKey('fact', f.id);
        var known = nodeByKey[fk];
        if (known) {
          adopt(known, f);
          continue;
        }
        var owner = nodeByKey[nodeKey('subject', f.subject)];
        var fn = { type: 'fact', id: f.id, key: fk, data: f, hue: owner ? owner.hue : 0, deg: 0, anchor: owner || null, r: 4 };
        nodeByKey[fk] = fn;
        place(fn, rand, owner || anchor, owner ? 40 : disc);
        added.push(fn);
      }
      var es = payload.edges || [];
      for (i = 0; i < es.length; i++) {
        var e = es[i];
        var ek = edgeKey(e);
        if (edgeKeys[ek]) continue;
        var from = nodeByKey[nodeKey(e.from_kind, e.from)];
        var to = nodeByKey[nodeKey(e.to_kind, e.to)];
        if (!from || !to) continue;
        edgeKeys[ek] = true;
        edges.push({ a: from, b: to, e: e });
        // A new reference changes what the open panel lists, so that alone is a rebuild.
        if (from === selected || to === selected) selectedChanged = true;
      }
      for (i = 0; i < nodes.length; i++) nodes[i].deg = 0;
      for (i = 0; i < edges.length; i++) { edges[i].a.deg++; edges[i].b.deg++; }
      for (i = 0; i < nodes.length; i++) {
        if (nodes[i].type === 'fact') nodes[i].r = 3.5 + 1.2 * Math.sqrt(nodes[i].deg);
      }
      var t = payload.truncated || {};
      truncatedSeen = {
        subjects: Math.max(truncatedSeen.subjects, Number(t.subjects) || 0),
        facts: Math.max(truncatedSeen.facts, Number(t.facts) || 0),
        edges: Math.max(truncatedSeen.edges, Number(t.edges) || 0),
      };
      if (!rootKey && payload.root) rootKey = nodeKey('subject', payload.root);
      // The open panel is rebuilt only when its node's data moved on, and quietly: no focus grab, no resize.
      if (selectedChanged) {
        selectedChanged = false;
        if (selected) renderPanel(selected, true);
      }
      return added;
    }

    function refreshHeader() {
      var subjectCount = 0;
      var factCount = 0;
      for (var i = 0; i < nodes.length; i++) { if (nodes[i].type === 'subject') subjectCount++; else factCount++; }
      counts.textContent = subjectCount + ' subjects, ' + factCount + ' facts, ' + edges.length + ' refs';
      var hidden = truncatedSeen.subjects + truncatedSeen.facts + truncatedSeen.edges;
      if (hidden > 0) {
        banner.hidden = false;
        banner.textContent = hidden + ' hidden (' + truncatedSeen.subjects + ' subjects, ' +
          truncatedSeen.facts + ' facts, ' + truncatedSeen.edges + ' refs). Double-click a node to expand it.';
      } else {
        banner.hidden = true;
        banner.textContent = '';
      }
    }

    // Removes one node and everything that only existed because of it: its edges (and their keys), its
    // place in the expansion set, the open panel and an in-progress drag. A dropped subject takes its
    // anchored facts with it. Every delta removal goes through here, and only here.
    function drop(key) {
      var nd = nodeByKey[key];
      if (!nd) return false;
      var i;
      if (nd.type === 'subject') {
        var orphans = [];
        for (i = 0; i < nodes.length; i++) {
          if (nodes[i].type === 'fact' && nodes[i].anchor === nd) orphans.push(nodes[i].key);
        }
        for (i = 0; i < orphans.length; i++) dropNode(orphans[i]);
        if (nodeByKey[key] !== nd) return true; // already gone with the subject
      }
      return dropNode(key);
    }

    function dropNode(key) {
      var nd = nodeByKey[key];
      if (!nd) return false;
      var i;
      for (i = nodes.length - 1; i >= 0; i--) if (nodes[i] === nd) nodes.splice(i, 1);
      delete nodeByKey[key];
      for (i = edges.length - 1; i >= 0; i--) {
        if (edges[i].a === nd || edges[i].b === nd) {
          delete edgeKeys[edgeKey(edges[i].e)];
          edges.splice(i, 1);
        }
      }
      if (nd.type === 'subject') {
        var at = expandedList.indexOf(nd.id);
        if (at >= 0) expandedList.splice(at, 1);
      }
      if (selected === nd) closePanel();
      if (drag && drag.node === nd) {
        if (drag.id !== undefined && canvas.hasPointerCapture(drag.id)) canvas.releasePointerCapture(drag.id);
        drag = null;
        canvas.style.cursor = 'grab';
      }
      if (nd.key === rootKey) {
        // Nothing can be refreshed against a root the store no longer has: say so and go quiet.
        rootKey = null;
        status.textContent = 'the graph root was removed; live updates stopped';
        stopLive();
      }
      for (i = 0; i < nodes.length; i++) nodes[i].deg = 0;
      for (i = 0; i < edges.length; i++) { edges[i].a.deg++; edges[i].b.deg++; }
      for (i = 0; i < nodes.length; i++) {
        if (nodes[i].type === 'fact') nodes[i].r = 3.5 + 1.2 * Math.sqrt(nodes[i].deg);
      }
      refreshHeader();
      schedule();
      return true;
    }

    // ---- layout ---------------------------------------------------------------------------
    var CELL = 48;
    var alpha = 1;
    var ticks = 0;
    var maxTicks = 300;
    // True while a restart() is settling: that settle releases the holds it was started with, so a
    // nothing-added merge must leave them alone instead of clearing them early.
    var layoutPending = false;

    function tick() {
      var n = nodes.length;
      var grid = {};
      var k;
      var a;
      var b;
      for (k = 0; k < n; k++) {
        a = nodes[k];
        a.fx = 0;
        a.fy = 0;
        a.cx = Math.floor(a.x / CELL);
        a.cy = Math.floor(a.y / CELL);
        var key = a.cx + ',' + a.cy;
        (grid[key] || (grid[key] = [])).push(a);
      }
      for (k = 0; k < n; k++) {
        a = nodes[k];
        for (var dx = -1; dx <= 1; dx++) {
          for (var dy = -1; dy <= 1; dy++) {
            var cell = grid[(a.cx + dx) + ',' + (a.cy + dy)];
            if (!cell) continue;
            for (var m = 0; m < cell.length; m++) {
              b = cell[m];
              if (b === a) continue;
              var rx = a.x - b.x;
              var ry = a.y - b.y;
              var d2 = rx * rx + ry * ry;
              if (d2 === 0) { rx = (k % 2 ? 1 : -1) * 0.01; ry = 0.01; d2 = rx * rx + ry * ry; }
              var d = Math.sqrt(d2);
              var push = 900 / (d2 + 25);
              a.fx += (rx / d) * push;
              a.fy += (ry / d) * push;
            }
          }
        }
      }
      for (k = 0; k < edges.length; k++) {
        var ed = edges[k];
        var sx = ed.b.x - ed.a.x;
        var sy = ed.b.y - ed.a.y;
        var sd = Math.sqrt(sx * sx + sy * sy) || 0.01;
        var rest = ed.e.kind === 'contains' ? 90 : (ed.b.type === 'subject' ? 110 : 80);
        var pull = 0.04 * (sd - rest);
        ed.a.fx += (sx / sd) * pull;
        ed.a.fy += (sy / sd) * pull;
        ed.b.fx -= (sx / sd) * pull;
        ed.b.fy -= (sy / sd) * pull;
      }
      for (k = 0; k < n; k++) {
        a = nodes[k];
        if (a.anchor) {
          a.fx += (a.anchor.x - a.x) * 0.02;
          a.fy += (a.anchor.y - a.y) * 0.02;
        }
        a.fx -= a.x * 0.003;
        a.fy -= a.y * 0.003;
      }
      for (k = 0; k < n; k++) {
        a = nodes[k];
        if (a.pinned || a.hold) { a.vx = 0; a.vy = 0; continue; }
        a.vx = (a.vx + a.fx * alpha) * 0.82;
        a.vy = (a.vy + a.fy * alpha) * 0.82;
        var speed = Math.sqrt(a.vx * a.vx + a.vy * a.vy);
        if (speed > 40) { a.vx *= 40 / speed; a.vy *= 40 / speed; }
        a.x += a.vx;
        a.y += a.vy;
      }
      alpha *= 0.985;
      ticks++;
      if (ticks >= maxTicks || alpha < 0.01) { layoutPending = false; releaseHolds(); }
    }

    function releaseHolds() {
      for (var k = 0; k < nodes.length; k++) nodes[k].hold = false;
    }

    function settling() { return ticks < maxTicks && alpha >= 0.01; }

    // ---- view -----------------------------------------------------------------------------
    var view = { scale: 1, tx: 0, ty: 0 };
    var width = 0;
    var height = 0;
    var selected = null;

    function resize() {
      var r = stage.getBoundingClientRect();
      width = Math.max(1, r.width);
      height = Math.max(1, r.height);
      dpr = win.devicePixelRatio || 1;
      canvas.width = Math.round(width * dpr);
      canvas.height = Math.round(height * dpr);
    }

    function fit() {
      if (nodes.length === 0) return;
      var minX = Infinity; var minY = Infinity; var maxX = -Infinity; var maxY = -Infinity;
      for (var k = 0; k < nodes.length; k++) {
        var nd = nodes[k];
        if (nd.x - nd.r < minX) minX = nd.x - nd.r;
        if (nd.y - nd.r < minY) minY = nd.y - nd.r;
        if (nd.x + nd.r > maxX) maxX = nd.x + nd.r;
        if (nd.y + nd.r > maxY) maxY = nd.y + nd.r;
      }
      var bw = Math.max(maxX - minX, 1);
      var bh = Math.max(maxY - minY, 1);
      var sc = Math.min(width / bw, height / bh) * 0.9;
      view.scale = Math.min(4, Math.max(0.02, sc));
      view.tx = width / 2 - ((minX + maxX) / 2) * view.scale;
      view.ty = height / 2 - ((minY + maxY) / 2) * view.scale;
    }

    function hsl(hue, sat, light, al) { return 'hsla(' + hue + ',' + sat + '%,' + light + '%,' + al + ')'; }

    function draw() {
      ctx.setTransform(1, 0, 0, 1, 0, 0);
      ctx.fillStyle = '#0e1116';
      ctx.fillRect(0, 0, canvas.width, canvas.height);
      ctx.setTransform(dpr * view.scale, 0, 0, dpr * view.scale, dpr * view.tx, dpr * view.ty);
      var inv = 1 / view.scale;
      var k;
      ctx.lineWidth = inv;
      // Implicit owner links: a fact is drawn faintly to the subject that owns it, so a fact with no refs of
      // its own is still visibly attached. These live only in the paint pass: not in edges[], so the header
      // counts, edgeKeys, degrees and hit-testing are untouched. A fact whose subject is not in the graph has
      // anchor null and draws nothing.
      for (k = 0; k < nodes.length; k++) {
        var owned = nodes[k];
        if (owned.type !== 'fact' || !owned.anchor) continue;
        ctx.strokeStyle = hsl(owned.hue, 35, 60, 1);
        ctx.globalAlpha = 0.25;
        ctx.beginPath();
        ctx.moveTo(owned.x, owned.y);
        ctx.lineTo(owned.anchor.x, owned.anchor.y);
        ctx.stroke();
      }
      ctx.globalAlpha = 1;
      for (k = 0; k < edges.length; k++) {
        var ed = edges[k];
        ctx.strokeStyle = BASIS[ed.e.basis] || '#9aa0a6';
        ctx.globalAlpha = ed.e.kind === 'contains' ? 0.5 : 0.75;
        ctx.beginPath();
        ctx.moveTo(ed.a.x, ed.a.y);
        ctx.lineTo(ed.b.x, ed.b.y);
        ctx.stroke();
      }
      ctx.globalAlpha = 1;
      for (k = 0; k < nodes.length; k++) {
        var nd = nodes[k];
        var isSub = nd.type === 'subject';
        ctx.beginPath();
        ctx.arc(nd.x, nd.y, nd.r, 0, Math.PI * 2);
        ctx.fillStyle = isSub ? hsl(nd.hue, 65, 58, nd.data.boundary ? 0.45 : 1) : hsl(nd.hue, 55, 62, 0.55);
        ctx.fill();
        var st = isSub ? null : nd.data.status;
        if (st) {
          ctx.lineWidth = 1.5 * inv;
          ctx.strokeStyle = STATUS[st] || '#868e96';
          ctx.stroke();
        }
        if (nd.key === rootKey) {
          ctx.beginPath();
          ctx.arc(nd.x, nd.y, nd.r + 2 * inv, 0, Math.PI * 2);
          ctx.lineWidth = 1.5 * inv;
          ctx.strokeStyle = '#f2b24c';
          ctx.stroke();
        }
        if (nd === selected) {
          ctx.beginPath();
          ctx.arc(nd.x, nd.y, nd.r + 3 * inv, 0, Math.PI * 2);
          ctx.lineWidth = 2 * inv;
          ctx.strokeStyle = '#ffffff';
          ctx.stroke();
        }
        // A node a delta flush added: one ring expanding and fading out. Canvas only, never a DOM node.
        if (nd.glow > 0) {
          var gp = (GLOW_FRAMES - nd.glow) / GLOW_FRAMES;
          ctx.beginPath();
          ctx.arc(nd.x, nd.y, nd.r + (4 + 12 * gp) * inv, 0, Math.PI * 2);
          ctx.globalAlpha = 0.85 * (1 - gp);
          ctx.lineWidth = 2 * inv;
          ctx.strokeStyle = '#ffd479';
          ctx.stroke();
          ctx.globalAlpha = 1;
        }
      }
      ctx.fillStyle = '#e6edf5';
      ctx.textAlign = 'center';
      ctx.textBaseline = 'top';
      ctx.font = (12 * inv) + 'px system-ui, sans-serif';
      for (k = 0; k < nodes.length; k++) {
        var lab = nodes[k];
        if (lab.type === 'subject') {
          ctx.fillText(cap(lab.data.name, LABEL_MAX), lab.x, lab.y + lab.r + 3 * inv);
        } else if (lab === selected) {
          ctx.fillText(cap(lab.data.key || lab.data.id, LABEL_MAX), lab.x, lab.y + lab.r + 4 * inv);
        }
      }
    }

    var pending = false;
    var touched = false;
    var rafHandle = 0;
    function schedule() {
      if (destroyed) return;
      if (reduced) { draw(); return; }
      if (pending) return;
      pending = true;
      rafHandle = win.requestAnimationFrame(frame);
    }

    // Highlight decay: one glow counter per newly added node, spent one frame at a time.
    function decayGlow() {
      var left = false;
      for (var k = 0; k < nodes.length; k++) {
        if (nodes[k].glow > 0) {
          nodes[k].glow--;
          if (nodes[k].glow > 0) left = true;
        }
      }
      return left;
    }

    function frame() {
      pending = false;
      if (destroyed) return;
      if (settling()) {
        for (var s = 0; s < 3 && settling(); s++) tick();
      }
      if (!settling() && !touched) { touched = true; fit(); }
      draw();
      var glowing = decayGlow();
      if (settling() || glowing) schedule();
    }

    function restart(ticksToRun) {
      alpha = Math.max(alpha, 0.6);
      ticks = 0;
      layoutPending = true;
      if (reduced) {
        while (settling()) tick();
        draw();
      } else {
        for (var i = 0; i < ticksToRun; i++) tick();
        schedule();
      }
    }

    // ---- panel (DOM text only) ------------------------------------------------------------
    function row(dl, name, value) {
      el('dt', name, dl);
      el('dd', value, dl);
    }

    function centre(nd) {
      view.tx = width / 2 - nd.x * view.scale;
      view.ty = height / 2 - nd.y * view.scale;
      touched = true;
      draw();
    }

    function focusNode(nd) {
      showPanel(nd);
      centre(nd);
    }

    // A node reference is a focus button; the id is shown as text.
    function describeRef(li, edge, target, label) {
      var verb = edge.rel + ' [' + edge.basis + '/' + edge.kind + '] ';
      el('span', verb, li);
      if (target) {
        var b = el('button', cap(target.id, LABEL_MAX), li, 'ref');
        b.type = 'button';
        b.setAttribute('data-target', target.id);
        b.setAttribute('aria-label', 'Open ' + target.type + ' ' + target.id);
        b.addEventListener('click', function () { focusNode(target); });
      } else {
        el('span', cap(label, 80), li);
      }
      if (edge.slot) el('span', ' #' + cap(edge.slot, 60), li);
      if (edge.ambiguous) el('span', ' (ambiguous name)', li);
    }

    function appendLink(parent, label, hash) {
      if (hash) {
        var a = el('a', label, parent);
        a.setAttribute('href', hash);
      } else {
        el('span', label, parent);
      }
    }

    function refList(nd, outgoing) {
      var list = el('ul', null, panel);
      for (var k = 0; k < edges.length; k++) {
        if ((outgoing ? edges[k].a : edges[k].b) !== nd) continue;
        var li = el('li', null, list);
        describeRef(li, edges[k].e, outgoing ? edges[k].b : edges[k].a);
      }
      return list;
    }

    // The control a quiet rebuild has to put focus back on: same tag and same target, so a reader who
    // was on a link keeps their place instead of being moved to the heading.
    function focusKey(node) {
      if (!node || !node.tagName || typeof node.getAttribute !== 'function') return null;
      var target = node.getAttribute('data-target');
      if (target) return node.tagName + '|' + target;
      var href = node.getAttribute('href');
      if (href) return node.tagName + '|' + href;
      return null;
    }

    function findByKey(node, key) {
      var kids = node.children || [];
      for (var k = 0; k < kids.length; k++) {
        if (focusKey(kids[k]) === key) return kids[k];
        var deep = findByKey(kids[k], key);
        if (deep) return deep;
      }
      return null;
    }

    // Builds the panel for `nd`. `quiet` is the refresh path: the node's data moved on underneath the
    // reader, so the text is replaced without moving focus out of the panel, without a resize and without
    // touching the view.
    function renderPanel(nd, quiet) {
      var from = quiet && doc.activeElement && panel.contains(doc.activeElement) ? doc.activeElement : null;
      var key = from ? focusKey(from) : null;
      panel.textContent = '';
      panel.hidden = false;
      var close = el('button', 'Close', panel);
      close.id = 'g-close';
      close.type = 'button';
      close.addEventListener('click', closePanel);
      var heading;
      var dl;
      var list;
      var k;
      if (nd.type === 'subject') {
        var sd = nd.data;
        heading = el('h2', cap(sd.name, 120), panel);
        dl = el('dl', null, panel);
        row(dl, 'id', cap(sd.id, 64));
        row(dl, 'kind', cap(sd.kind, 60));
        row(dl, 'facts', String(Number(sd.facts) || 0));
        if (sd.boundary) row(dl, 'boundary', 'a fact of this subject refers into the graph');
        var actions = el('p', null, panel);
        appendLink(actions, 'Open subject', hashLink('subject', sd.id));
        el('span', ' | ', actions);
        appendLink(actions, 'Graph from here', hashLink('graph', sd.id));
        el('h3', 'Referenced by', panel);
        list = refList(nd, false);
        if (!list.firstChild) el('li', 'none', list);
      } else {
        var fd = nd.data;
        heading = el('h2', 'Fact ' + cap(fd.id, 64), panel);
        dl = el('dl', null, panel);
        row(dl, 'subject', cap(fd.subject, 64));
        row(dl, 'kind', cap(fd.kind, 60));
        row(dl, 'status', cap(fd.status, 40));
        row(dl, 'confidence', String(Number(fd.confidence)));
        row(dl, 'tags', fd.tags && fd.tags.length ? fd.tags.map(function (t) { return cap(t, 40); }).join(', ') : 'none');
        var links = el('p', null, panel);
        appendLink(links, 'Open fact', hashLink('fact', fd.id));
        el('h3', 'Text', panel);
        el('pre', cap(fd.text, 2000), panel);
        el('h3', 'Refs out', panel);
        list = refList(nd, true);
        var external = fd.unresolved || [];
        for (k = 0; k < external.length; k++) {
          var u = external[k];
          var li = el('li', null, list);
          describeRef(li, { rel: u.rel, basis: u.basis, kind: u.kind, slot: null }, null, u.target);
          el('span', ' (external)', li);
        }
        if (!list.firstChild) el('li', 'none', list);
        el('h3', 'Referenced by', panel);
        list = refList(nd, false);
        if (!list.firstChild) el('li', 'none', list);
      }
      // The rebuild above dropped focus; put it back where the reader had it.
      heading.setAttribute('tabindex', '-1');
      if (quiet) {
        // Only a reader who was already in the panel stays there: a refresh never steals focus, and it
        // moves the reader onto the equivalent control (the rebuilt one) when there is one.
        if (from) ((key && findByKey(panel, key)) || heading).focus();
        return;
      }
      heading.focus();
      resize();
      schedule();
    }

    function showPanel(nd) {
      selected = nd;
      renderPanel(nd, false);
    }

    function closePanel() {
      selected = null;
      panel.hidden = true;
      panel.textContent = '';
      resize();
      schedule();
    }

    // ---- interaction ----------------------------------------------------------------------
    function toWorld(px, py) { return [(px - view.tx) / view.scale, (py - view.ty) / view.scale]; }

    function hit(px, py) {
      var w = toWorld(px, py);
      for (var k = nodes.length - 1; k >= 0; k--) {
        var nd = nodes[k];
        var dx = w[0] - nd.x;
        var dy = w[1] - nd.y;
        var rr = nd.r + 3 / view.scale;
        if (dx * dx + dy * dy <= rr * rr) return nd;
      }
      return null;
    }

    function local(ev) {
      var r = canvas.getBoundingClientRect();
      return [ev.clientX - r.left, ev.clientY - r.top];
    }

    var drag = null;
    canvas.addEventListener('pointerdown', function (ev) {
      var p = local(ev);
      touched = true;
      var nd = hit(p[0], p[1]);
      drag = { node: nd, x: p[0], y: p[1], moved: 0, id: ev.pointerId };
      canvas.setPointerCapture(ev.pointerId);
      canvas.style.cursor = 'grabbing';
    });
    canvas.addEventListener('pointermove', function (ev) {
      if (!drag) return;
      var p = local(ev);
      var dx = p[0] - drag.x;
      var dy = p[1] - drag.y;
      drag.moved += Math.abs(dx) + Math.abs(dy);
      drag.x = p[0];
      drag.y = p[1];
      if (drag.node) {
        drag.node.x += dx / view.scale;
        drag.node.y += dy / view.scale;
        if (drag.moved > 4) {
          drag.node.pinned = true;
          if (!reduced) { alpha = Math.max(alpha, 0.3); ticks = Math.min(ticks, maxTicks - 100); }
        }
      } else {
        view.tx += dx;
        view.ty += dy;
      }
      schedule();
    });
    function endDrag(ev) {
      if (!drag) return;
      var done = drag;
      drag = null;
      canvas.style.cursor = 'grab';
      if (done.node && done.moved <= 4) showPanel(done.node);
      if (ev && ev.pointerId !== undefined && canvas.hasPointerCapture(ev.pointerId)) canvas.releasePointerCapture(ev.pointerId);
    }
    canvas.addEventListener('pointerup', endDrag);
    canvas.addEventListener('pointercancel', endDrag);
    canvas.addEventListener('wheel', function (ev) {
      ev.preventDefault();
      touched = true;
      var p = local(ev);
      var factor = Math.exp(-ev.deltaY * 0.0015);
      var next = Math.min(8, Math.max(0.02, view.scale * factor));
      var real = next / view.scale;
      view.tx = p[0] - (p[0] - view.tx) * real;
      view.ty = p[1] - (p[1] - view.ty) * real;
      view.scale = next;
      schedule();
    }, { passive: false });
    canvas.addEventListener('dblclick', function (ev) {
      var p = local(ev);
      var nd = hit(p[0], p[1]);
      if (nd) expand(nd);
    });

    fitButton.addEventListener('click', function () { fit(); schedule(); });
    // Keys typed into a control belong to that control: no shortcut fires from an input, a select, a button
    // or a link, nor from editable content. Escape still closes the panel from a button or link.
    function onKey(ev) {
      if (ev.ctrlKey || ev.metaKey || ev.altKey) return;
      var t = ev.target || doc.activeElement;
      var tag = t && t.tagName ? String(t.tagName).toUpperCase() : '';
      var editable = tag === 'INPUT' || tag === 'TEXTAREA' || tag === 'SELECT' || !!(t && t.isContentEditable);
      if (editable) return;
      if ((tag === 'BUTTON' || tag === 'A') && ev.key !== 'Escape') return;
      if (ev.key === 'Escape') closePanel();
      else if (ev.key === 'f' || ev.key === 'F') { fit(); schedule(); }
      else if ((ev.key === 'Enter' || ev.key === 'e' || ev.key === 'E') && selected) expand(selected);
    }
    function onResize() { resize(); schedule(); }
    doc.addEventListener('keydown', onKey);
    win.addEventListener('resize', onResize);

    // ---- fetching -------------------------------------------------------------------------
    function url(subject) {
      return '/api/graph?subject=' + encodeURIComponent(subject) + '&depth=' + viewDepth + '&facts=' + viewFacts + '&max_nodes=' + maxNodes;
    }

    function expand(nd) {
      var subject = nd.type === 'subject' ? nd.id : nd.data.subject;
      if (typeof subject !== 'string' || !ID_RE.test(subject)) return Promise.resolve();
      status.textContent = 'loading…';
      return fetchJson(url(subject)).then(function (payload) {
        if (destroyed) return;
        for (var k = 0; k < nodes.length; k++) nodes[k].hold = true; // existing nodes stay where they are
        var added = merge(payload, nd.key);
        remember(subject);
        status.textContent = '';
        refreshHeader();
        if (added.length) restart(20);
        else {
          if (!layoutPending) releaseHolds();
          schedule();
        }
      }).catch(function (err) {
        status.textContent = 'error: ' + cap(err && err.message, 200);
      });
    }

    // ---- refresh: the loaded graph follows the store (S4/S5) ------------------------------
    var refreshing = false;
    var dirty = false;
    var pendingRows = []; // delta rows waiting for the debounced flush
    var pendingFull = false;

    function expandedIds() {
      var out = [];
      for (var k = 0; k < expandedList.length; k++) out.push(expandedList[k]);
      return out;
    }

    function remember(subject) {
      if (typeof subject !== 'string' || !ID_RE.test(subject)) return;
      if (expandedList.indexOf(subject) < 0) expandedList.push(subject);
    }

    // The one gate every refresh and every delta flush goes through. A request that arrives while one is
    // in flight only marks it dirty; the stale response is then followed by one more pass that applies
    // whatever the flush learned, so a stale refresh can never leave a dropped node behind.
    function pump() {
      if (destroyed || liveStopped) return Promise.resolve();
      if (refreshing) { dirty = true; return Promise.resolve(); }
      if (!pendingFull && !pendingRows.length) return Promise.resolve();
      refreshing = true;
      var full = pendingFull;
      var rows = pendingRows; // kept even on a full refresh: merge() cannot remove, so deletes must still run
      var fromDelta = rows.length > 0;
      pendingFull = false;
      pendingRows = [];
      var added = [];
      var hadNodes = nodes.length > 0;
      var rootOk = false;
      var wanted = [];
      var wantRoot = false;
      var handled = [];
      var k;

      // Removals first, then classification: a delete (or a fact that arrives retracted) is applied even
      // when another row in the same batch asks for a full refresh.
      for (k = 0; k < rows.length; k++) handled[k] = applyRemoval(rows[k]);
      for (k = 0; k < rows.length && !liveStopped && !full; k++) {
        if (handled[k]) continue;
        var cls = classify(rows[k]);
        if (!cls) continue;
        if (cls.full) { full = true; break; }
        if (cls.subject === rootId) wantRoot = true;
        else if (wanted.indexOf(cls.subject) < 0) wanted.push(cls.subject);
      }
      if (full) { wanted = expandedIds(); wantRoot = true; }
      for (k = 0; k < nodes.length; k++) nodes[k].hold = true; // as expand does

      // One failing subject (a 404 after a retraction, say) must not abort the rest of the refresh.
      function chain(i) {
        if (destroyed || liveStopped || i >= wanted.length) return Promise.resolve();
        var subject = wanted[i];
        return fetchJson(url(subject)).then(function (payload) {
          if (!destroyed && !liveStopped) added = added.concat(merge(payload, nodeKey('subject', subject), true));
        }).catch(function () { /* that subject is gone: keep the nodes we have and go on */ })
          .then(function () { return chain(i + 1); });
      }

      // The finally: `refreshing` is cleared and the holds released on every path, success or failure.
      function finish() {
        refreshing = false;
        if (destroyed) return Promise.resolve();
        if (liveStopped) {
          releaseHolds();
          pendingRows = [];
          pendingFull = false;
          dirty = false;
          return Promise.resolve();
        }
        // A refresh that recovered from a failed initial load replaces that error line with the graph:
        // nothing was ever laid out, so size the stage and fit what arrived.
        if (rootOk && !hadNodes && nodes.length) {
          status.textContent = '';
          resize();
          fit();
        }
        if (fromDelta && added.length && !reduced) {
          for (var a = 0; a < added.length; a++) added[a].glow = GLOW_FRAMES;
        }
        refreshHeader();
        if (added.length) restart(20);
        else {
          // An expansion may be mid-settle; its last tick releases every hold, so do not clear them here.
          if (!layoutPending) releaseHolds();
          schedule();
        }
        if (dirty || pendingFull || pendingRows.length) { dirty = false; return pump(); }
        return Promise.resolve();
      }

      var work = Promise.resolve();
      if (wantRoot) {
        work = fetchJson(url(rootId)).then(function (payload) {
          if (destroyed || liveStopped) return;
          rootOk = true;
          added = added.concat(merge(payload, null, true));
        }).catch(function () { /* a transient refresh error is not a status line: the channel retries */ });
      }
      return work.then(chain.bind(null, 0)).then(finish, finish);
    }

    // Re-fetch the root and every expanded neighbourhood and merge them in place. Existing nodes are held
    // so positions, selection and zoom survive; only newly seen nodes are placed.
    function refresh() {
      if (destroyed || liveStopped) return Promise.resolve();
      pendingFull = true;
      return pump();
    }

    // The removal rule of the contract, applied before classification. A delete row, or a fact row that
    // arrives retracted, removes the node it names when the view holds it.
    function applyRemoval(row) {
      if (!row || typeof row !== 'object') return false;
      if (row.tbl === 'facts' && typeof row.fact_id === 'string' &&
        (row.op === 'delete' || row.fact_status === 'retracted')) {
        return drop(nodeKey('fact', row.fact_id));
      }
      if (row.tbl === 'subjects' && row.op === 'delete' && typeof row.subject_id === 'string') {
        return drop(nodeKey('subject', row.subject_id));
      }
      return false;
    }

    // What one changed row is worth. A row that names no subject, or touches the subject table, can move
    // the graph's shape, so only a full refresh is safe. A row owned by a subject this view fetches is
    // refetched alone; one owned by a visible neighbour (a depth-1 stub, say) is not fetched by itself, so
    // the whole view refreshes. A refs row owned by a subject that is not on screen may add an inbound
    // edge to the root, so the root is refetched.
    function classify(row) {
      if (!row || typeof row !== 'object') return null;
      if (row.tbl === 'subjects' || row.subject_id === null || row.subject_id === undefined) return { full: true };
      var sid = row.subject_id;
      if (typeof sid !== 'string' || !ID_RE.test(sid)) return { full: true };
      if (sid === rootId || expandedList.indexOf(sid) >= 0) return { subject: sid };
      if (nodeByKey[nodeKey('subject', sid)]) return { full: true };
      if (row.tbl === 'refs') return { subject: rootId };
      return null;
    }

    // ---- live channel: SSE deltas on /api/events, /api/changes polling as the fallback (S5) ------
    // `revision` frames carry no delta, so they are ignored: every change arrives in a `changes` frame
    // and every discontinuity in a `reset` frame. `lastSeen` is the seq watermark: rows at or below it
    // were already applied.
    var lastSeen = -1;
    var stream = null;
    var pollTimer = 0;
    var flushTimer = 0;
    var liveStopped = false;
    var DEBOUNCE_MS = 250;
    var POLL_MS = 1000;
    var GLOW_FRAMES = 18;

    function stopStream() {
      var s = stream;
      if (!s) return;
      stream = null;
      s.onerror = null;
      if (typeof s.close === 'function') s.close();
    }

    // The root is gone: nothing can be refreshed against it, so the view stops following the store.
    function stopLive() {
      liveStopped = true;
      stopStream();
      if (flushTimer && typeof win.clearTimeout === 'function') win.clearTimeout(flushTimer);
      flushTimer = 0;
      if (pollTimer && typeof win.clearInterval === 'function') win.clearInterval(pollTimer);
      pollTimer = 0;
      pendingRows = [];
      pendingFull = false;
      dirty = false;
    }

    // Trailing debounce: a burst of rows costs one flush, and that flush goes through pump().
    function scheduleFlush() {
      if (destroyed || liveStopped) return;
      if (typeof win.setTimeout !== 'function') { pump(); return; }
      if (flushTimer && typeof win.clearTimeout === 'function') win.clearTimeout(flushTimer);
      flushTimer = win.setTimeout(function () {
        flushTimer = 0;
        if (!destroyed) pump();
      }, DEBOUNCE_MS);
    }

    // One batch: rows at or below the watermark are a redelivery and are dropped here, then the
    // watermark moves to the batch's last seq.
    function applyFrame(frame) {
      if (!frame || typeof frame !== 'object') return;
      var rows = Array.isArray(frame.changes) ? frame.changes : [];
      var to = Number(frame.to);
      for (var k = 0; k < rows.length; k++) {
        var seq = Number(rows[k] && rows[k].seq);
        if (!Number.isFinite(seq) || seq <= lastSeen) continue;
        lastSeen = seq;
        pendingRows.push(rows[k]);
      }
      if (Number.isFinite(to)) { if (to > lastSeen) lastSeen = to; }
      else {
        var nx = Number(frame.next);
        if (Number.isFinite(nx) && nx > lastSeen) lastSeen = nx;
      }
    }

    function onReset(n) {
      if (destroyed || liveStopped) return;
      if (Number.isFinite(n)) lastSeen = n;
      pendingRows = [];
      refresh(); // a reset is a full refresh through the same gate
    }

    function onChanges(ev) {
      if (destroyed || liveStopped) return;
      var frame;
      try {
        frame = typeof (ev && ev.data) === 'string' ? JSON.parse(ev.data) : (ev && ev.data);
      } catch (err) { return; }
      if (!frame || typeof frame !== 'object') return;
      if (frame.reset) { onReset(Number(frame.next)); return; }
      applyFrame(frame);
      scheduleFlush();
    }

    function onResetEvent(ev) {
      var n = parseInt(ev && ev.data, 10);
      onReset(Number.isFinite(n) ? n : lastSeen);
    }

    function pollChanges() {
      if (destroyed || liveStopped) return;
      var target = lastSeen >= 0
        ? '/api/changes?since=' + lastSeen + '&limit=200'
        : '/api/changes?last=200';
      fetchJson(target).then(function (body) {
        if (destroyed || liveStopped || !body || typeof body !== 'object') return;
        if (body.reset) {
          var nx = Number(body.next);
          if (Number.isFinite(nx)) lastSeen = nx;
          pendingRows = [];
          refresh();
          return;
        }
        applyFrame(body);
        scheduleFlush();
      }).catch(function () { /* the next tick retries */ });
    }

    function startPolling() {
      if (destroyed || liveStopped || pollTimer) return;
      stopStream();
      if (typeof win.setInterval !== 'function') return;
      pollTimer = win.setInterval(pollChanges, POLL_MS);
    }

    function listen() {
      if (destroyed || liveStopped) return;
      if (typeof win.EventSource !== 'function') { startPolling(); return; }
      var es;
      try {
        es = new win.EventSource('/api/events' + (lastSeen >= 0 ? '?since=' + lastSeen : ''));
      } catch (err) {
        startPolling(); // no stream available: the changes poll still keeps the view current
        return;
      }
      stream = es;
      es.addEventListener('changes', onChanges);
      es.addEventListener('reset', onResetEvent);
      es.onerror = function () {
        if (destroyed) return;
        if (es.readyState === 2) startPolling(); // CLOSED (e.g. 503 busy): fall back to polling
      };
    }

    function initialLoad() {
      return fetchJson(url(rootId)).then(function (payload) {
        if (destroyed) return;
        merge(payload, null);
        refreshHeader();
        resize();
        if (reduced) {
          while (settling()) tick();
          fit();
          draw();
        } else {
          for (var i = 0; i < 60; i++) tick();
          fit();
          schedule();
        }
      }).catch(function (err) {
        status.textContent = 'error: ' + cap(err && err.message, 200);
      });
    }

    // The baseline costs one request before the graph. Without EventSource and without a timer there is
    // nothing to listen with, so such a host keeps its single request.
    var ready;
    if (typeof win.EventSource === 'function' || typeof win.setInterval === 'function') {
      ready = fetchJson('/api/revision').then(function (body) {
        lastSeen = Number.isFinite(body && body.revision) ? body.revision : -1;
      }).catch(function () { lastSeen = -1; })
        .then(initialLoad)
        .then(function () { listen(); }); // listen even if the first load failed: refresh must still work
    } else {
      ready = initialLoad();
    }

    function destroy() {
      destroyed = true;
      stopStream();
      if (flushTimer && typeof win.clearTimeout === 'function') win.clearTimeout(flushTimer);
      flushTimer = 0;
      if (pollTimer && typeof win.clearInterval === 'function') win.clearInterval(pollTimer);
      pollTimer = 0;
      doc.removeEventListener('keydown', onKey);
      win.removeEventListener('resize', onResize);
      if (rafHandle && win.cancelAnimationFrame) win.cancelAnimationFrame(rafHandle);
    }

    return {
      ready: ready,
      destroy: destroy,
      merge: function (payload, anchorKey) { var added = merge(payload, anchorKey || null); refreshHeader(); return added; },
      expand: expand,
      refresh: refresh,
      // The seq watermark the next poll asks from (read-only; tests and diagnostics use it).
      get lastSeen() { return lastSeen; },
      select: function (key) { var nd = nodeByKey[key]; if (nd) focusNode(nd); },
      nodes: nodes,
      edges: edges,
      view: view,
    };
  }

  window.DossierGraph = { mount: mount, ID_RE: ID_RE };
})();
