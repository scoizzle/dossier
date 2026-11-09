# django/utils/text

- Subject: django/utils/text (id `d4fb524f-db41-40be-9f36-cc1bde22a9a5`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 18 of 57
- Conflicts: 0
- Gaps: 0

## Facts

- # Return the original string since no truncation was necessary return text [eeb7e80f]
- >>> unescape_string_literal('"abc"') 'abc' >>> unescape_string_literal("'abc'") 'abc' >>> unescape_string_literal('"a \"bc\""') 'a "bc"' >>> unescape_string_literal("'\'ab\' c'") "'ab' c" """ if not s or s[0] not in "\"'" or s[-1] != s[0]: raise ValueError("Not a string literal: %r" % s) quote = s[0] return s[1:-1].replace(r"\%s" % quote, quote).replace(r"\\", "\\") [d3f41c7e]
- Strip newlines in the string. """ words = self._wrapped.split() if len(words) > length: words = words[:length] return add_truncation_text(" ".join(words), truncate) return " ".join(words) [597dd938]
- `truncate` specifies what should be used to notify that the string has been truncated, defaulting to a translatable string of an ellipsis. """ self._setup() length = int(num) if length <= 0: return "" text = unicodedata.normalize("NFC", self._wrapped) [f28751d2]
- if html: parser = TruncateCharsHTMLParser(length=length, replacement=truncate) parser.feed(text) parser.close() return "".join(parser.output) return self._text_chars(length, truncate, text) [271ca095]
- return VOID_ELEMENTS [83c2e327]
- >>> list(smart_split(r'This is "a person\'s" test.')) ['This', 'is', '"a person\\\'s"', 'test.'] >>> list(smart_split(r"Another 'person\'s' test.")) ['Another', "'person\\'s'", 'test.'] >>> list(smart_split(r'A "\"funky\" style" test.')) ['A', '"\\"funky\\" style"', 'test.'] """ for bit in smart_split_re.finditer(str(text)): yield bit[0] [44e4c827]
- @cached_property def void_elements(self): from django.utils.html import VOID_ELEMENTS [80faffe5]
- Don't wrap long words, thus the output text may have lines longer than ``width``. """ [9c6593db]
- Non-string values are returned unchanged and suffix is the empty string. """ suffix = "" if isinstance(value, str) and (value_len := len(value)) > limit: value, suffix = ( value[:limit], f"… <trimmed {value_len - limit} chars out of {value_len}>", ) return value, suffix [dfa76a72]
- Preserve all white space except added line breaks consume the space on which they break the line. [7549e72b]
- Return the trimmed value and suffix noting how many chars were trimmed (empty when no trimming was done). [3a59bf42]
- compressed_view = memoryview(compressed_data) header = bytearray(compressed_view[:10]) header[3] = gzip.FNAME [1de564c0]
- def __init__(self, *, length, replacement, convert_charrefs=True): super().__init__(convert_charrefs=convert_charrefs) self.tags = deque() self.output = [] self.remaining = length self.replacement = replacement [08d9ad6e]
- def __init__(self, text): super().__init__(lambda: str(text)) [228dff78]
- def _text_words(self, length, truncate): """ Truncate a string after a certain number of words. [a065e037]
- def chars(self, num, truncate=None, html=False): """ Return the text truncated to be no longer than the specified number of characters. [f4162e17]
- def handle_startendtag(self, tag, attrs): self.handle_starttag(tag, attrs) if tag not in self.void_elements: self.handle_endtag(tag) [e4a5bfac]

## Beyond the budget

39 more facts did not fit in the budget: [cd8f6154] [107d1d03] [3f1deded] [acc8b6a6] [a07d04bb] [d3282c20] [c4ebe091] [05d7d45e] [02db282e] [57a4408f] [db78cd00] [ff82e15d] [0db4e665] [cc22a98d] [bb3c00ee] [ef1950f6] [22af47c7] [98d5b0d4] [0eea6d8d] [3ca9602d] [217621f3] [1417267e] [af7db084] [05fa6abc] [752d90fd] [35551eb8] [6898cfc2] [a42e6e8d] [a7d0fbeb] [9b53783a] [b6a6e7ef] [34b3c0fa] [8da0f541] [9899dd32] [c45e6d13] [634c6314] [a5f3a23c] [c3c44b1d] [e3d5c87d]
