# django/test/html

- Subject: django/test/html (id `2d985932-8e03-473f-a39b-4bd000455dc4`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2001 tokens
- Facts shown: 31 of 31
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [e3ee872b] def finalize(self): def rstrip_last_element(children): if children and isinstance(children[-1], str): children[-1] = children[-1].rstrip() if not children[-1]: children.pop() children = rstrip_last_element(children) return children
- [207a8084] def format_position(self, position=None, element=None): if not position and element: position = self.element_positions[element] if position is None: position = self.getpos() if hasattr(position, "lineno"): position = position.lineno, position.offset return "Line %d, Column %d" % position
- [93554c1e] def handle_data(self, data): self.current.append(data)
- [d6761194] def handle_endtag(self, tag): if not self.open_tags: self.error("Unexpected end tag `%s` (%s)" % (tag, self.format_position())) element = self.open_tags.pop() while element.name != tag: if not self.open_tags: self.error( "Unexpected end tag `%s` (%s)" % (tag, self.format_position()) ) element = self.open_tags.pop()
- [d01dd8cb] def handle_startendtag(self, tag, attrs): self.handle_starttag(tag, attrs) if tag not in VOID_ELEMENTS: self.handle_endtag(tag)
- [4e8139b8] def handle_starttag(self, tag, attrs): attrs = normalize_attributes(attrs) element = Element(tag, attrs) self.current.append(element) if tag not in VOID_ELEMENTS: self.open_tags.append(element) self.element_positions[element] = self.getpos()
- [aded0701] """Compare two HTML documents."""
- [c7a41005] # ASCII whitespace is U+0009 TAB, U+000A LF, U+000C FF, U+000D CR, or U+0020 # SPACE. # https://infra.spec.whatwg.org/#ascii-whitespace ASCII_WHITESPACE = _lazy_re_compile(r"[\t\n\f\r ]+")
- [842131e0] # https://html.spec.whatwg.org/#attributes-3 BOOLEAN_ATTRIBUTES = { "allowfullscreen", "async", "autofocus", "autoplay", "checked", "controls", "default", "defer ", "disabled", "formnovalidate", "hidden", "ismap", "itemscope", "loop", "multiple", "muted", "nomodule", "novalidate", "open", "playsinline", "readonly", "required", "reversed", "selected", # Attributes for deprecated tags. "truespeed", }
- [d696858a] class Element: def __init__(self, name, attributes): self.name = name self.attributes = sorted(attributes) self.children = []
- [d2df2575] class HTMLParseError(Exception): pass
- [3562f3e6] class Parser(HTMLParser): def __init__(self): super().__init__() self.root = RootElement() self.open_tags = [] self.element_positions = {}
- [101be2fc] class RootElement(Element): def __init__(self): super().__init__(None, ())
- [f9f4d6d3] def normalize_attributes(attributes): normalized = [] for name, value in attributes: if name == "class" and value: # Special case handling of 'class' attribute, so that comparisons # of DOM instances are not sensitive to ordering of classes. value = " ".join( sorted(value for value in ASCII_WHITESPACE.split(value) if value) ) # Boolean attributes without a value is same as attribute with value # that equals the attributes name. For example: # <input checked> == <input checked="checked"> if name in BOOLEAN_ATTRIBUTES: if not value or value == name: value = None elif value is None: value = "" normalized.append((name, value)) return normalized
- [4dddfb57] def normalize_whitespace(string): return ASCII_WHITESPACE.sub(" ", string)
- [70c36eaf] def parse_html(html): """ Take a string that contains HTML and turn it into a Python object structure that can be easily compared against other HTML on semantic equivalence. Syntactical differences like which quotation is used on arguments will be ignored. """ parser = Parser() parser.feed(html) parser.close() document = parser.root document.finalize() # Removing ROOT element if it's not necessary if len(document.children) == 1 and not isinstance(document.children[0], str): document = document.children[0] return document
- [f5d68c82] from django.utils.html import VOID_ELEMENTS from django.utils.regex_helper import _lazy_re_compile
- [3811423b] import html from html.parser import HTMLParser
