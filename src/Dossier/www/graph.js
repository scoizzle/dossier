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

    // Adds what is new, keeps every existing node (and its position), refreshes degrees.
    function merge(payload, anchorKey) {
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
        if (nodeByKey[sk]) {
          if (!s.boundary && nodeByKey[sk].data.boundary) nodeByKey[sk].data = s;
          continue;
        }
        var sn = { type: 'subject', id: s.id, key: sk, data: s, hue: (hueCount++ * 47) % 360, deg: 0, anchor: null, r: 8 + 2.5 * Math.sqrt(Math.max(0, Number(s.facts) || 0)) };
        nodeByKey[sk] = sn;
        place(sn, rand, anchor, disc);
        added.push(sn);
      }
      for (i = 0; i < facts.length; i++) {
        var f = facts[i];
        var fk = nodeKey('fact', f.id);
        if (nodeByKey[fk]) continue;
        var owner = nodeByKey[nodeKey('subject', f.subject)];
        var fn = { type: 'fact', id: f.id, key: fk, data: f, hue: owner ? owner.hue : 0, deg: 0, anchor: owner || null, r: 4 };
        nodeByKey[fk] = fn;
        place(fn, rand, owner || anchor, owner ? 40 : disc);
        added.push(fn);
      }
      var es = payload.edges || [];
      for (i = 0; i < es.length; i++) {
        var e = es[i];
        var ek = [e.from_kind, e.from, e.to_kind, e.to, e.rel, e.basis, e.kind, e.slot || ''].join('\u001f');
        if (edgeKeys[ek]) continue;
        var from = nodeByKey[nodeKey(e.from_kind, e.from)];
        var to = nodeByKey[nodeKey(e.to_kind, e.to)];
        if (!from || !to) continue;
        edgeKeys[ek] = true;
        edges.push({ a: from, b: to, e: e });
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

    // ---- layout ---------------------------------------------------------------------------
    var CELL = 48;
    var alpha = 1;
    var ticks = 0;
    var maxTicks = 300;

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
      if (ticks >= maxTicks || alpha < 0.01) releaseHolds();
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

    function frame() {
      pending = false;
      if (destroyed) return;
      if (settling()) {
        for (var s = 0; s < 3 && settling(); s++) tick();
      }
      if (!settling() && !touched) { touched = true; fit(); }
      draw();
      if (settling()) schedule();
    }

    function restart(ticksToRun) {
      alpha = Math.max(alpha, 0.6);
      ticks = 0;
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

    function showPanel(nd) {
      selected = nd;
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
      // The rebuild above dropped focus; park it on the heading so keyboard users keep their place.
      heading.setAttribute('tabindex', '-1');
      heading.focus();
      resize();
      schedule();
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
      drag = { node: nd, x: p[0], y: p[1], moved: 0 };
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
        status.textContent = '';
        refreshHeader();
        if (added.length) restart(20);
        else { releaseHolds(); schedule(); }
      }).catch(function (err) {
        status.textContent = 'error: ' + cap(err && err.message, 200);
      });
    }

    var ready = fetchJson(url(rootId)).then(function (payload) {
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

    function destroy() {
      destroyed = true;
      doc.removeEventListener('keydown', onKey);
      win.removeEventListener('resize', onResize);
      if (rafHandle && win.cancelAnimationFrame) win.cancelAnimationFrame(rafHandle);
    }

    return {
      ready: ready,
      destroy: destroy,
      merge: function (payload, anchorKey) { var added = merge(payload, anchorKey || null); refreshHeader(); return added; },
      expand: expand,
      select: function (key) { var nd = nodeByKey[key]; if (nd) focusNode(nd); },
      nodes: nodes,
      edges: edges,
      view: view,
    };
  }

  window.DossierGraph = { mount: mount, ID_RE: ID_RE };
})();
