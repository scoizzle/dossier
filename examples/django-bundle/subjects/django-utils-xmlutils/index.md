# django/utils/xmlutils

- Subject: django/utils/xmlutils (id `7496b65b-d0af-4572-b69d-63d25714638c`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 397 tokens
- Facts shown: 8 of 8
- Conflicts: 0
- Gaps: 0

## Facts

- def characters(self, content): if content and _xml_control_chars_re.search(content): # Fail loudly when content has control chars (unsupported in XML # 1.0) See https://www.w3.org/International/questions/qa-controls raise UnserializableContentError XMLGenerator.characters(self, content) [d9dfc0ad]
- def startElement(self, name, attrs): for value in attrs.values(): if isinstance(value, str) and _xml_control_chars_re.search(value): raise UnserializableContentError # Sort attrs for a deterministic output. sorted_attrs = dict(sorted(attrs.items())) if attrs else attrs super().startElement(name, sorted_attrs) [287a1daa]
- """ Utilities for XML generation/parsing. """ [aa687678]
- _xml_control_chars_re = _lazy_re_compile(r"[\x00-\x08\x0B-\x0C\x0E-\x1F]") [e88970c5]
- class SimplerXMLGenerator(XMLGenerator): def addQuickElement(self, name, contents=None, attrs=None): "Convenience method for adding an element with no children" if attrs is None: attrs = {} self.startElement(name, attrs) if contents is not None: self.characters(contents) self.endElement(name) [06f60ff4]
- class UnserializableContentError(ValueError): def __init__(self, msg="Control characters are not supported in XML 1.0"): super().__init__(msg) [ebd254c9]
- from django.utils.regex_helper import _lazy_re_compile [e384d60811aaeff5-3]
- from xml.sax.saxutils import XMLGenerator [a3e32bb2]
