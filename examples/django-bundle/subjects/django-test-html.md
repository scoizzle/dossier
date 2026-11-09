# django/test/html

- Subject: django/test/html (id `867b14fd-6566-4ef0-b334-905eb63b932d`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 13 of 31
- Conflicts: 0
- Gaps: 0

## Facts

- rstrip_last_element(self.children) for i, child in enumerate(self.children): if isinstance(child, str): self.children[i] = child.strip() elif hasattr(child, "finalize"): child.finalize() [92dfa723]
- @property def current(self): if self.open_tags: return self.open_tags[-1] else: return self.root [f1208049]
- def __contains__(self, element): return self._count(element, count=False) > 0 [ebcee76a]
- def __eq__(self, element): if not hasattr(element, "name") or self.name != element.name: return False if self.attributes != element.attributes: return False return self.children == element.children [c0ff7c83]
- def __getitem__(self, key): return self.children[key] [d2c9cd23]
- def __hash__(self): return hash((self.name, *self.attributes)) [02aaaff8]
- def __repr__(self): return str(self) [67be5f30107b5926-2]
- def __str__(self): output = "<%s" % self.name for key, value in self.attributes: if value is not None: output += ' %s="%s"' % (key, value) else: output += " %s" % key if self.children: output += ">\n" output += "".join( [ html.escape(c) if isinstance(c, str) else str(c) for c in self.children ] ) output += "\n</%s>" % self.name else: output += ">" return output [be1d7ea7]
- def __str__(self): return "".join( [html.escape(c) if isinstance(c, str) else str(c) for c in self.children] ) [ffc9f8ee]
- def _count(self, element, count=True): if not isinstance(element, str) and self == element: return 1 if isinstance(element, RootElement) and self.children == element.children: return 1 i = 0 elem_child_idx = 0 for child in self.children: # child is text content and element is also text content, then # make a simple "text" in "text" if isinstance(child, str): if isinstance(element, str): if count: i += child.count(element) elif element in child: return 1 else: # Look for element wholly within this child. i += child._count(element, count=count) if not count and i: return i # Also look for a sequence of element's children among self's # children. self.children == element.children is tested above, # but will fail if self has additional children. Ex: '<a/><b/>' # is contained in '<a/><b/><c/>'. if isinstance(element, RootElement) and element.children: elem_child = element.children[elem_child_idx] # Start or continue match, advance index. if elem_child == child: elem_child_idx += 1 # Match found, reset index. if elem_child_idx == len(element.children): i += 1 elem_child_idx = 0 # No match, reset index. else: elem_child_idx = 0 return i [36b602b2]
- def append(self, element): if isinstance(element, str): element = normalize_whitespace(element) if self.children and isinstance(self.children[-1], str): self.children[-1] += element self.children[-1] = normalize_whitespace(self.children[-1]) return elif self.children: # removing last children if it is only whitespace # this can result in incorrect dom representations since # whitespace between inline tags like <span> is significant if isinstance(self.children[-1], str) and self.children[-1].isspace(): self.children.pop() if element: self.children.append(element) [51d3a104]
- def count(self, element): return self._count(element, count=True) [35cff9f5]
- def error(self, msg): raise HTMLParseError(msg, self.getpos()) [d6bf1a42]

## Beyond the budget

18 more facts did not fit in the budget: [e3ee872b] [207a8084] [93554c1e] [d6761194] [d01dd8cb] [4e8139b8] [aded0701] [c7a41005] [842131e0] [d696858a] [d2df2575] [3562f3e6] [101be2fc] [f9f4d6d3] [4dddfb57] [70c36eaf] [f5d68c82] [3811423b]
