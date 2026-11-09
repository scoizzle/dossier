# django/utils/encoding

- Subject: django/utils/encoding (id `1b025b0e-52b1-4cf1-aad4-c3d9befe4f99`)
- Kind: subject
- Budget: 1200 tokens
- Used: 895 tokens
- Facts shown: 7 of 28
- Conflicts: 0
- Gaps: 0

## Facts

- Encode certain chars that would normally be recognized as special chars for URIs. Do not encode the ' character, as it is a valid character within URIs. See the encodeURIComponent() JavaScript function for details. """ if path is None: return path # I know about `os.sep` and `os.altsep` but I want to leave # some flexibility for hardcoding separators. return quote(str(path).replace("\\", "/"), safe="/~!*()'") [54ef856f]
- If strings_only is True, don't convert (some) non-string-like objects. """ # Handle the common case first for performance reasons. if isinstance(s, bytes): if encoding == "utf-8": return s else: return s.decode("utf-8", errors).encode(encoding, errors) if strings_only and is_protected_type(s): return s if isinstance(s, memoryview): return bytes(s) return str(s).encode(encoding, errors) [8345ee38]
- If strings_only is True, don't convert (some) non-string-like objects. """ # Handle the common case first for performance reasons. if issubclass(type(s), str): return s if strings_only and is_protected_type(s): return s try: if isinstance(s, bytes): s = str(s, encoding, errors) else: s = str(s) except UnicodeDecodeError as e: raise DjangoUnicodeDecodeError(*e.args) from None return s [b7d7a6dc]
- If strings_only is True, don't convert (some) non-string-like objects. """ if isinstance(s, Promise): # The input is the result of a gettext_lazy() call. return s return force_bytes(s, encoding, strings_only, errors) [7cd832f9]
- Objects of protected types are preserved as-is when passed to force_str(strings_only=True). """ return isinstance(obj, _PROTECTED_TYPES) [55b9520f]
- Take an IRI (string or UTF-8 bytes, e.g. '/I ♥ Django/' or b'/I \xe2\x99\xa5 Django/') and return a string containing the encoded result with ASCII chars only (e.g. '/I%20%E2%99%A5%20Django/'). """ # The list of safe characters here is constructed from the "reserved" and # "unreserved" characters specified in RFC 3986 Sections 2.2 and 2.3: # reserved = gen-delims / sub-delims # gen-delims = ":" / "/" / "?" / "#" / "[" / "]" / "@" # sub-delims = "!" / "$" / "&" / "'" / "(" / ")" # / "*" / "+" / "," / ";" / "=" # unreserved = ALPHA / DIGIT / "-" / "." / "_" / "~" # Of the unreserved characters, urllib.parse.quote() already considers all # but the ~ safe. # The % character is also added to the list of safe characters here, as the # end of RFC 3987 Section 3.1 specifically mentions that % must not be # converted. if iri is None: return iri elif isinstance(iri, Promise): iri = str(iri) return quote(iri, safe="/#%[]=:;$&()+,!?*@'~") [8210ca40]
- Take an URI in ASCII bytes (e.g. '/I%20%E2%99%A5%20Django/') and return a string containing the encoded result (e.g. '/I%20♥%20Django/'). """ if uri is None: return uri uri = force_bytes(uri) # Fast selective unquote: First, split on '%' and then starting with the # second block, decode the first 2 bytes if they represent a hex code to # decode. The rest of the block is the part after '%AB', not containing # any '%'. Add that to the output without further processing. bits = uri.split(b"%") if len(bits) == 1: iri = uri else: parts = [bits[0]] append = parts.append hextobyte = _hextobyte for item in bits[1:]: hex = item[:2] if hex in hextobyte: append(hextobyte[item[:2]]) append(item[2:]) else: append(b"%") append(item) iri = b"".join(parts) return repercent_broken_unicode(iri).decode() [274c3573]

## Beyond the budget

19 more facts did not fit in the budget: [5673cc60] [62d8caf2] [439e823b] [1ce5b373] [2bec0660] [d34c6336] [640df788] [6b89b171] [a01b177c] [2fd3e774] [477a3a6f] [a335136b] [5158942b] [8ad69876] [d254bc8b] [76657ed9] [28d5b483] [5c7dba87c48e193e-3] [719e053b]
