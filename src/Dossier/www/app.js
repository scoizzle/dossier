"use strict";
const main = document.getElementById("main");
const box = document.getElementById("q");

// Fact text is untrusted: every value is inserted with textContent, never as HTML.
function el(tag, props, ...kids) {
  const node = document.createElement(tag);
  if (props) for (const k in props) {
    if (k === "text") node.textContent = props[k]; else node.setAttribute(k, props[k]);
  }
  for (const kid of kids) node.append(kid);
  return node;
}
function link(label, hash, cls) { return el("a", { href: hash, text: label, class: cls || "" }); }
async function api(path) {
  const r = await fetch(path);
  const body = await r.json();
  if (!r.ok) throw new Error(body.error ? body.error.message : r.statusText);
  return body;
}
function clear(...kids) { main.replaceChildren(...kids); }
function factRow(f) {
  return el("li", null,
    link(f.id, "#/fact/" + encodeURIComponent(f.id), "id"),
    el("span", { class: "status", text: f.status || "" }),
    el("span", { text: " " + (f.text || "") }));
}

async function home() {
  const subjects = await api("/api/subjects");
  const list = el("ul");
  for (const s of subjects) {
    list.append(el("li", null,
      link(s.name, "#/subject/" + encodeURIComponent(s.id)),
      el("span", { class: "note", text: " " + s.kind + ", " + s.facts + " facts " }),
      link("graph", "#/graph/" + encodeURIComponent(s.id))));
  }
  clear(el("h2", { text: "Subjects" }), el("p", null, link("Graph (subject tree)", "#/graph/")), list);
}

async function search(q) {
  const res = await api("/api/search?q=" + encodeURIComponent(q));
  const list = el("ul");
  for (const f of res.hits) list.append(factRow(f));
  clear(el("h2", { text: "Results for \"" + q + "\" (" + res.total + ")" }), list);
}

async function subject(id) {
  const d = await api("/api/compile?subject=" + encodeURIComponent(id));
  const nodes = [el("h2", { text: "Dossier: " + (d.subject ? d.subject.name : id) }),
    el("p", null, link("Graph", "#/graph/" + encodeURIComponent(id)))];
  const list = el("ul");
  for (const f of d.facts || []) list.append(factRow(f));
  nodes.push(list);
  if (d.gaps && d.gaps.length) nodes.push(el("p", { class: "note", text: "gaps: " + JSON.stringify(d.gaps) }));
  nodes.push(el("h2", { text: "Raw" }), el("pre", { text: JSON.stringify(d, null, 2) }));
  clear(...nodes);
}

async function fact(id) {
  const s = await api("/api/fact?id=" + encodeURIComponent(id));
  const refs = el("ul");
  for (const r of s.refs) {
    refs.append(el("li", null,
      el("span", { text: r.rel + " (" + r.kind + ", " + r.basis + ") " }),
      r.kind === "fact" ? link(r.target, "#/fact/" + encodeURIComponent(r.target), "id") : el("span", { class: "id", text: r.target })));
  }
  const inbound = el("ul");
  for (const f of s.inbound) inbound.append(factRow(f));
  clear(
    el("h2", { text: "Fact " + s.fact.id }),
    el("p", null, el("span", { class: "status", text: s.fact.status }), el("span", { text: " " + s.fact.kind })),
    el("p", { text: s.fact.text || "" }),
    link("subject " + s.fact.subject_id, "#/subject/" + encodeURIComponent(s.fact.subject_id)),
    el("h2", { text: "Refs (" + s.refs.length + ")" }), refs,
    el("h2", { text: "Inbound (" + s.inbound.length + ")" }), inbound);
}

let graph = null;
function graphView(id) {
  const host = el("div");
  clear(el("h2", { text: id ? "Graph" : "Subject tree" }), host);
  graph = window.DossierGraph.mount(host, id);
  return graph.ready;
}

async function route() {
  if (graph) { graph.destroy(); graph = null; }
  const parts = location.hash.replace(/^#\/?/, "").split("/");
  const arg = parts[1] ? decodeURIComponent(parts.slice(1).join("/")) : "";
  try {
    if (parts[0] === "subject" && arg) await subject(arg);
    else if (parts[0] === "fact" && arg) await fact(arg);
    else if (parts[0] === "graph") await graphView(arg);
    else if (parts[0] === "search" && arg) await search(arg);
    else await home();
  } catch (e) {
    clear(el("p", { text: "error: " + e.message }));
  }
}
box.addEventListener("keydown", (e) => {
  if (e.key === "Enter" && box.value.trim()) location.hash = "#/search/" + encodeURIComponent(box.value.trim());
});
window.addEventListener("hashchange", route);
route();
