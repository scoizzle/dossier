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
    list.setAttribute('role', 'log'); // a log region, deliberately without aria-live: it must not interrupt
    var empty = el('div', 'no changes yet', host, 'f-empty');

    function el(tag, value, parent, cls) {
      var node = doc.createElement(tag);
      if (value !== undefined && value !== null) node.textContent = value;
      if (cls) node.className = cls;
      if (parent) parent.appendChild(node);
      return node;
    }

    // The list is rebuilt from the model on every change (bounded to 80 rows, so this is cheap) and the
    // click handler is a closure over that row: nothing a batch carries becomes markup or a URL.
    function render() {
      if (destroyed) return;
      list.textContent = '';
      var at = now();
      for (var k = 0; k < rows.length; k++) {
        var entry = rows[k];
        var li = el('li', null, list, entry.fresh && !reduced ? 'f-row f-new' : 'f-row');
        entry.fresh = false;
        var line = el('button', entry.text, li, 'f-line');
        line.type = 'button';
        if (entry.row && onSelect) {
          (function (row) {
            line.addEventListener('click', function () { onSelect(row); });
          })(entry.row);
        }
        el('span', ago(at, entry.at), li, 'f-time');
      }
      empty.hidden = rows.length > 0;
      list.hidden = collapsed;
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
        var entry = { seq: accepted[k].seq, row: item, text: lineFor(item), at: item.at, fresh: true, refs: 0 };
        lines.push(entry);
        if (item.tbl === 'facts' && text(item.fact_id)) byFact[text(item.fact_id)] = entry;
      }

      // Refs of this batch fold into the fact line they name; refs whose fact is not in the batch are
      // one aggregate line so a wide ref update cannot flood the strip.
      var loose = 0;
      var looseWhere = '';
      for (k = 0; k < accepted.length; k++) {
        var ref = accepted[k].row;
        if (ref.tbl !== 'refs' && ref.tbl !== 'slots') continue;
        var target = byFact[text(ref.fact_id)];
        if (target) target.refs++;
        else { loose++; if (!looseWhere) looseWhere = place(ref); }
      }
      for (k = 0; k < lines.length; k++) {
        if (lines[k].refs) lines[k].text += ' +' + lines[k].refs + ' refs';
      }
      if (loose) {
        lines.push({ seq: lastSeen, row: null, text: '+' + loose + ' refs in ' + (looseWhere || 'the graph'), at: undefined, fresh: true, refs: 0 });
      }

      // Ascending seq, pushed to the front: the newest row ends up first.
      for (k = 0; k < lines.length; k++) rows.unshift(lines[k]);
      while (rows.length > MAX_ROWS) rows.pop();
      render();
    }

    function reset() {
      if (destroyed) return;
      rows = [];
      lastSeen = -1;
      render();
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

    render();
    // The times go stale in place: re-render on a slow tick, and only where the host has a timer.
    if (typeof win.setInterval === 'function') timer = win.setInterval(render, TICK_MS);

    return { ingest: ingest, reset: reset, destroy: destroy };
  }

  window.DossierFeed = { mount: mount };
})();
