# django/utils/text

- Subject: django/utils/text (id `1703bc41-7c1c-483b-b6fe-3d0070411f87`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 3831 tokens
- Facts shown: 57 of 57
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [cd8f6154] def _text_chars(self, length, truncate, text): """Truncate a string after a certain number of chars.""" truncate_len = calculate_truncate_chars_length(length, truncate) s_len = 0 end_index = None for i, char in enumerate(text): if unicodedata.combining(char): # Don't consider combining characters # as adding to the string length continue s_len += 1 if end_index is None and s_len > truncate_len: end_index = i if s_len > length: # Return the truncated string return add_truncation_text(text[: end_index or 0], truncate)
- [107d1d03] def feed(self, data): try: super().feed(data) except self.TruncationCompleted: self.output.extend([f"</{tag}>" for tag in self.tags]) self.tags.clear() self.reset() else: # No data was handled. self.reset()
- [3f1deded] def handle_data(self, data): data, output = self.process(data) data_len = len(data) if self.remaining < data_len: self.remaining = 0 self.output.append(add_truncation_text(output, self.replacement)) raise self.TruncationCompleted self.remaining -= data_len self.output.append(output)
- [acc8b6a6] def handle_endtag(self, tag): if tag not in self.void_elements: self.output.append(f"</{tag}>") # Remove from the stack only if the tag matches the most recently # opened tag (LIFO). This avoids O(n) linear scans for unmatched # end tags if `deque.remove()` would be called. if self.tags and self.tags[0] == tag: self.tags.popleft()
- [a07d04bb] def handle_starttag(self, tag, attrs): self.output.append(self.get_starttag_text()) if tag not in self.void_elements: self.tags.appendleft(tag)
- [d3282c20] def process(self, data): self.processed_chars += len(data) if (self.processed_chars == self.length) and ( sum(len(p) for p in self.output) + len(data) == len(self.rawdata) ): self.output.append(data) raise self.TruncationCompleted output = escape("".join(data[: self.remaining])) return data, output
- [c4ebe091] def words(self, num, truncate=None, html=False): """ Truncate a string after a certain number of words. `truncate` specifies what should be used to notify that the string has been truncated, defaulting to ellipsis. """ self._setup() length = int(num) if length <= 0: return "" if html: parser = TruncateWordsHTMLParser(length=length, replacement=truncate) parser.feed(self._wrapped) parser.close() return "".join(parser.output) return self._text_words(length, truncate)
- [05d7d45e] filename = _get_random_filename(max_random_bytes) + b"\x00"
- [02db282e] if not max_random_bytes: return compressed_data
- [57a4408f] return bytes(header) + filename + compressed_view[10:]
- [db78cd00] wrapper = textwrap.TextWrapper( width=width, break_long_words=False, break_on_hyphens=False, replace_whitespace=False, ) result = [] for line in text.splitlines(): wrapped = wrapper.wrap(line) if not wrapped: # If `line` contains only whitespaces that are dropped, restore it. result.append(line) else: result.extend(wrapped) if text.endswith("\n"): # If `text` ends with a newline, preserve it. result.append("") return "\n".join(result)
- [ff82e15d] # Expression to match some_token and some_token="with spaces" (and similarly # for single-quoted strings). smart_split_re = _lazy_re_compile( r""" ((?: [^\s'"]* (?: (?:"(?:[^"\\]|\\.)*" | '(?:[^'\\]|\\.)*') [^\s'"]* )+ ) | \S+) """, re.VERBOSE, )
- [0db4e665] # Like compress_string, but for iterators of strings. def compress_sequence(sequence, *, max_random_bytes=None): buf = StreamingBuffer() filename = _get_random_filename(max_random_bytes) if max_random_bytes else None with GzipFile( filename=filename, mode="wb", compresslevel=6, fileobj=buf, mtime=0 ) as zfile: # Output headers... yield buf.read() for item in sequence: zfile.write(item) zfile.flush() data = buf.read() if data: yield data yield buf.read()
- [cc22a98d] # Set up regular expressions re_newlines = _lazy_re_compile(r"\r\n|\r") # Used in normalize_newlines re_camel_case = _lazy_re_compile(r"(((?<=[a-z])[A-Z])|([A-Z](?![A-Z]|$)))")
- [bb3c00ee] @keep_lazy_text def capfirst(x): """Capitalize the first letter of a string.""" if not x: return x if not isinstance(x, str): x = str(x) return x[0].upper() + x[1:]
- [ef1950f6] @keep_lazy_text def get_text_list(list_, last_word=gettext_lazy("or")): """ >>> get_text_list(['a', 'b', 'c', 'd']) 'a, b, c or d' >>> get_text_list(['a', 'b', 'c'], 'and') 'a, b and c' >>> get_text_list(['a', 'b'], 'and') 'a and b' >>> get_text_list(['a']) 'a' >>> get_text_list([]) '' """ if not list_: return "" if len(list_) == 1: return str(list_[0]) return "%s %s %s" % ( # Translators: This string is used as a separator between list elements _(", ").join(str(i) for i in list_[:-1]), str(last_word), str(list_[-1]), )
- [22af47c7] @keep_lazy_text def get_valid_filename(name): """ Return the given string converted to a string that can be used for a clean filename. Remove leading and trailing spaces; convert other spaces to underscores; and remove anything that is not an alphanumeric, dash, underscore, or dot. >>> get_valid_filename("john's portrait in 2004.jpg") 'johns_portrait_in_2004.jpg' """ s = str(name).strip().replace(" ", "_") s = re.sub(r"(?u)[^-\w.]", "", s) if s in {"", ".", ".."}: raise SuspiciousFileOperation("Could not derive file name from '%s'" % name) return s
- [98d5b0d4] @keep_lazy_text def normalize_newlines(text): """Normalize CRLF and CR newlines to just LF.""" return re_newlines.sub("\n", str(text))
- [0eea6d8d] @keep_lazy_text def phone2numeric(phone): """Convert a phone number with letters into its numeric equivalent.""" char2number = { "a": "2", "b": "2", "c": "2", "d": "3", "e": "3", "f": "3", "g": "4", "h": "4", "i": "4", "j": "5", "k": "5", "l": "5", "m": "6", "n": "6", "o": "6", "p": "7", "q": "7", "r": "7", "s": "7", "t": "8", "u": "8", "v": "8", "w": "9", "x": "9", "y": "9", "z": "9", } return "".join(char2number.get(c, c) for c in phone.lower())
- [3ca9602d] @keep_lazy_text def slugify(value, allow_unicode=False): """ Convert to ASCII if 'allow_unicode' is False. Convert spaces or repeated dashes to single dashes. Remove characters that aren't alphanumerics, underscores, or hyphens. Convert to lowercase. Also strip leading and trailing whitespace, dashes, and underscores. """ value = str(value) if allow_unicode: value = unicodedata.normalize("NFKC", value) else: value = ( unicodedata.normalize("NFKD", value) .encode("ascii", "ignore") .decode("ascii") ) value = re.sub(r"[^\w\s-]", "", value.lower()) return re.sub(r"[-\s]+", "-", value).strip("-_")
- [217621f3] @keep_lazy_text def unescape_string_literal(s): r""" Convert quoted string literals to unquoted strings with escaped quotes and backslashes unquoted::
- [1417267e] @keep_lazy_text def wrap(text, width): """ A word-wrap function that preserves existing line breaks. Expects that existing line breaks are posix newlines.
- [af7db084] async def acompress_sequence(sequence, *, max_random_bytes=None): buf = StreamingBuffer() filename = _get_random_filename(max_random_bytes) if max_random_bytes else None with GzipFile( filename=filename, mode="wb", compresslevel=6, fileobj=buf, mtime=0 ) as zfile: # Output headers... yield buf.read() async for item in sequence: zfile.write(item) zfile.flush() data = buf.read() if data: yield data yield buf.read()
- [05fa6abc] class StreamingBuffer(BytesIO): def read(self): ret = self.getvalue() self.seek(0) self.truncate() return ret
- [752d90fd] class TruncateCharsHTMLParser(TruncateHTMLParser): def __init__(self, *, length, replacement, convert_charrefs=True): self.length = length self.processed_chars = 0 super().__init__( length=calculate_truncate_chars_length(length, replacement), replacement=replacement, convert_charrefs=convert_charrefs, )
- [35551eb8] class TruncateHTMLParser(HTMLParser): class TruncationCompleted(Exception): pass
- [6898cfc2] class TruncateWordsHTMLParser(TruncateHTMLParser): def process(self, data): data = re.split(r"(?<=\S)\s+(?=\S)", data) output = escape(" ".join(data[: self.remaining])) return data, output
- [a42e6e8d] class Truncator(SimpleLazyObject): """ An object used to truncate text, either by characters or words. """
- [a7d0fbeb] def _format_lazy(format_string, *args, **kwargs): """ Apply str.format() on 'format_string' where format_string, args, and/or kwargs might be lazy. """ return format_string.format(*args, **kwargs)
- [9b53783a] def _get_random_filename(max_random_bytes): return b"a" * secrets.randbelow(max_random_bytes)
- [b6a6e7ef] def add_truncation_text(text, truncate=None): if truncate is None: truncate = pgettext( "String to return when truncating text", "%(truncated_text)s…" ) if "%(truncated_text)s" in truncate: return truncate % {"truncated_text": text} # The truncation text didn't contain the %(truncated_text)s string # replacement argument so just append it to the text. if text.endswith(truncate): # But don't append the truncation text if the current text already ends # in this. return text return f"{text}{truncate}"
- [34b3c0fa] def calculate_truncate_chars_length(length, replacement): truncate_len = length for char in add_truncation_text("", replacement): if not unicodedata.combining(char): truncate_len -= 1 if truncate_len == 0: break return truncate_len
- [8da0f541] def camel_case_to_spaces(value): """ Split CamelCase and convert to lowercase. Strip surrounding whitespace. """ return re_camel_case.sub(r" \1", value).strip().lower()
- [9899dd32] def compress_string(s, *, max_random_bytes=None): compressed_data = gzip_compress(s, compresslevel=6, mtime=0)
- [c45e6d13] def smart_split(text): r""" Generator that splits a string by spaces, leaving quoted phrases together. Supports both single and double quotes, and supports escaping quotes with backslashes. In the output, strings will keep their initial and trailing quote marks and escaped quotes will remain escaped (the results can then be further processed with unescape_string_literal()).
- [634c6314] def trim_value(value, limit=4096): """Trim string `value` to `limit` characters.
- [a5f3a23c] format_lazy = lazy(_format_lazy, str)
- [c3c44b1d] from django.core.exceptions import SuspiciousFileOperation from django.utils.functional import ( SimpleLazyObject, cached_property, keep_lazy_text, lazy, ) from django.utils.regex_helper import _lazy_re_compile from django.utils.translation import gettext as _ from django.utils.translation import gettext_lazy, pgettext
- [e3d5c87d] import gzip import re import secrets import textwrap import unicodedata from collections import deque from gzip import GzipFile from gzip import compress as gzip_compress from html import escape from html.parser import HTMLParser from io import BytesIO
