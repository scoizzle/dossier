// Live activity feed for the graph view. Loaded as a classic script before graph.js; graph.js mounts it
// on the strip under its bar and forwards every change batch from /api/events (or the polling
// fallback). The feed makes no request of its own. Every journal value is untrusted text: it only ever
// reaches the DOM through textContent, so a hostile subject name or fact snippet stays text.
(function () {
  'use strict';

  var MAX_ROWS = 80;
  var SNIPPET_MAX = 90;
  var TICK_MS = 10000;

  function text(value) {
    return value === undefined || value === null ? '' : String(value);
  }

  // One line of a fact: whitespace collapsed, length capped, so a long snippet cannot swamp the strip.
  function snippet(value) {
    var s = text(value).replace(/\s+/g, ' ').trim();
    if (s.length > SNIPPET_MAX) s = s.slice(0, SNIPPET_MAX - 1) + '…';
    return s || '(empty)';
  }

  function place(row) {
    var name = text(row && row.subject_name);
    if (name) return name;
    var id = text(row && row.subject_id);
    return id || 'the graph';
  }

  // The wording of one row. The actor is shown only when the server sent one (a fact insert), so a
  // retraction or a delete reads neutrally instead of "null".
  function lineFor(row) {
    var who = text(row.actor);
    var what = snippet(row.text);
    var where = place(row);
    if (row.tbl === 'subjects') {
      var name = text(row.subject_name) || text(row.subject_id) || '(unnamed subject)';
      if (row.op === 'insert') return 'new subject ' + name;
      return 'subject ' + name + (row.op === 'delete' ? ' removed' : ' updated');
    }
    if (row.tbl === 'facts') {
      if (row.op === 'insert') {
        return who ? who + ' added ' + what + ' to ' + where : 'new fact ' + what + ' in ' + where;
      }
      if (row.op === 'delete') return what + ' deleted in ' + where;
      return what + ' ' + (text(row.fact_status) || 'updated') + ' in ' + where;
    }
    return (text(row.tbl) || 'change') + ' ' + (text(row.op) || 'changed') + ' in ' + where;
  }

  function ago(now, at) {
    var then = Date.parse(text(at));
    if (!isFinite(then)) return '';
    var secs = Math.round((now - then) / 1000);
    if (secs < 5) return 'just now';
    if (secs < 60) return secs + 's ago';
    var mins = Math.round(secs / 60);
    if (mins < 60) return mins + 'm ago';
    var hours = Math.round(mins / 60);
    if (hours < 48) return hours + 'h ago';
    return Math.round(hours / 24) + 'd ago';
  }

  function mount(host, options) {
    options = options || {};
    var doc = document;
    var win = window;
    var now = typeof options.now === 'function' ? options.now : function () { return Date.now(); };
    var onSelect = typeof options.onSelect === 'function' ? options.onSelect : null;
    var reduced = !!(win.matchMedia && win.matchMedia('(prefers-reduced-motion: reduce)').matches);

    var rows = []; // newest first
    var factIndex = {}; // fact_id -> the newest rendered row that names it
    var lastSeen = -1;
    var collapsed = false;
    var destroyed = false;
    var timer = 0;

    host.textContent = '';
    var head = el('div', null, host, 'g-feed-head');
    var toggle = el('button', 'Activity', head, 'g-feed-toggle');
    toggle.type = 'button';
    toggle.setAttribute('aria-expanded', 'true');
    var list = el('ul', null, host, 'g-feed-list');
    list.setAttribute('role', 'log'); // a log region
    list.setAttribute('aria-live', 'off'); // ...but role="log" is implicitly polite, so say off explicitly: a batch must not interrupt
    var empty = el('div', 'no changes yet', host, 'f-empty');

    function el(tag, value, parent, cls) {
      var node = doc.createElement(tag);
      if (value !== undefined && value !== null) node.textContent = value;
      if (cls) node.className = cls;
      if (parent) parent.appendChild(node);
      return node;
    }

    // The wording of a row is its base plus the refs folded into it, so a later ref batch can update the
    // same element in place instead of adding a row.
    function lineText(entry) {
      return entry.base + (entry.refs ? ' +' + entry.refs + ' refs' : '');
    }

    function setLine(entry) {
      entry.text = lineText(entry);
      if (entry.line) entry.line.textContent = entry.text;
    }

    function attach(entry, at) {
      setLine(entry);
      var li = el('li', null, null, entry.fresh && !reduced ? 'f-row f-new' : 'f-row');
      entry.fresh = false;
      var line = el('button', entry.text, li, 'f-line');
      line.type = 'button';
      if (entry.row && onSelect) {
        (function (row) {
          line.addEventListener('click', function () { onSelect(row); });
        })(entry.row);
      }
      entry.time = el('span', ago(at, entry.at), li, 'f-time');
      entry.li = li;
      entry.line = line;
      rows.unshift(entry);
      list.insertBefore(li, list.firstChild);
      if (entry.factId) factIndex[entry.factId] = entry;
      return entry;
    }

    // Oldest rows fall off the tail, so a focused row inside the 80 survives every change.
    function trim() {
      while (rows.length > MAX_ROWS) {
        var old = rows.pop();
        if (old.li && old.li.parentNode === list) list.removeChild(old.li);
        old.li = null; old.line = null; old.time = null;
        if (old.factId && factIndex[old.factId] === old) delete factIndex[old.factId];
      }
    }

    function paint() {
      empty.hidden = rows.length > 0;
      list.hidden = collapsed;
    }

    // Full build from the model: only mount and reset use it. Every change after that is incremental, so a
    // focused row button is never destroyed by an ingest.
    function renderAll() {
      if (destroyed) return;
      list.textContent = '';
      factIndex = {};
      var at = now();
      for (var k = 0; k < rows.length; k++) {
        var entry = rows[k];
        entry.li = null; entry.line = null; entry.time = null;
        setLine(entry);
        var li = el('li', null, list, 'f-row'); // the f-new class belongs to the batch that added it
        var line = el('button', entry.text, li, 'f-line');
        line.type = 'button';
        if (entry.row && onSelect) {
          (function (row) {
            line.addEventListener('click', function () { onSelect(row); });
          })(entry.row);
        }
        entry.time = el('span', ago(at, entry.at), li, 'f-time');
        entry.li = li;
        entry.line = line;
        if (entry.factId) factIndex[entry.factId] = entry;
      }
      paint();
    }

    // The tick touches only the relative times: nothing is rebuilt, so focus, a click in flight and the
    // element identity of every row survive it.
    function tick() {
      if (destroyed) return;
      var at = now();
      for (var k = 0; k < rows.length; k++) {
        var entry = rows[k];
        if (entry.time) entry.time.textContent = ago(at, entry.at);
      }
      paint();
    }

    function entryForFact(id) {
      var entry = factIndex[id];
      if (entry && rows.indexOf(entry) < 0) { delete factIndex[id]; entry = null; }
      return entry || null;
    }

    // One batch: rows at or below the watermark are a redelivery. Refs and slots of the batch belong to
    // their fact's line, and a supersede status update disappears into the insert it names.
    function ingest(changes) {
      if (destroyed) return;
      var batch = Array.isArray(changes) ? changes : [];
      var accepted = [];
      var k;
      for (k = 0; k < batch.length; k++) {
        var row = batch[k];
        if (!row || typeof row !== 'object') continue;
        var seq = Number(row.seq);
        if (!isFinite(seq) || seq <= lastSeen) continue;
        accepted.push({ seq: seq, row: row });
      }
      if (!accepted.length) return;
      accepted.sort(function (a, b) { return a.seq - b.seq; });
      lastSeen = accepted[accepted.length - 1].seq;

      var inserts = {};
      for (k = 0; k < accepted.length; k++) {
        var first = accepted[k].row;
        if (first.tbl === 'facts' && first.op === 'insert' && text(first.fact_id)) inserts[text(first.fact_id)] = true;
      }

      var lines = [];
      var byFact = {};
      for (k = 0; k < accepted.length; k++) {
        var item = accepted[k].row;
        if (item.tbl === 'refs' || item.tbl === 'slots') continue;
        if (item.tbl === 'facts' && item.op === 'update' && text(item.fact_status) === 'superseded' && inserts[text(item.fact_id)]) continue;
        var entry = {
          seq: accepted[k].seq, row: item, base: lineFor(item), refs: 0, text: '', at: item.at, fresh: true,
          factId: item.tbl === 'facts' ? text(item.fact_id) : '', li: null, line: null, time: null,
        };
        setLine(entry);
        lines.push(entry);
        if (entry.factId) byFact[entry.factId] = entry;
      }

      // Refs of this batch fold into the fact line they name — the batch's own line, or one already on
      // screen, updated in place. Refs whose fact is nowhere are one aggregate line, so a wide ref update
      // cannot flood the strip.
      var loose = 0;
      var looseWhere = '';
      var touched = [];
      for (k = 0; k < accepted.length; k++) {
        var ref = accepted[k].row;
        if (ref.tbl !== 'refs' && ref.tbl !== 'slots') continue;
        var fid = text(ref.fact_id);
        var target = (fid && byFact[fid]) || (fid ? entryForFact(fid) : null);
        if (target) {
          target.refs++;
          if (touched.indexOf(target) < 0) touched.push(target);
        } else { loose++; if (!looseWhere) looseWhere = place(ref); }
      }
      for (k = 0; k < touched.length; k++) setLine(touched[k]); // in place when the row is already rendered
      if (loose) {
        lines.push({
          seq: lastSeen, row: null, base: '+' + loose + ' refs in ' + (looseWhere || 'the graph'), refs: 0, text: '',
          at: undefined, fresh: true, factId: '', li: null, line: null, time: null,
        });
      }

      // Ascending seq, each prepended: the newest row ends up first. Existing rows keep their elements.
      var at = now();
      for (k = 0; k < lines.length; k++) attach(lines[k], at);
      trim();
      paint();
    }

    function reset() {
      if (destroyed) return;
      rows = [];
      factIndex = {};
      lastSeen = -1;
      renderAll();
    }

    function destroy() {
      destroyed = true;
      if (timer && typeof win.clearInterval === 'function') win.clearInterval(timer);
      timer = 0;
    }

    toggle.addEventListener('click', function () {
      collapsed = !collapsed;
      toggle.setAttribute('aria-expanded', collapsed ? 'false' : 'true');
      list.hidden = collapsed;
    });

    renderAll();
    // The times go stale in place: re-render on a slow tick, and only where the host has a timer.
    if (typeof win.setInterval === 'function') timer = win.setInterval(tick, TICK_MS);

    return { ingest: ingest, reset: reset, destroy: destroy };
  }

  window.DossierFeed = { mount: mount };
})();
