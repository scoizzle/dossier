# django/utils/html

- Subject: django/utils/html (id `88d686de-2968-4d5c-a93e-0e40fa3c99c0`)
- Kind: subject
- Budget: 1200 tokens
- Used: 888 tokens
- Facts shown: 12 of 63
- Conflicts: 0
- Gaps: 0

## Facts

- amp = middle.rfind("&") if amp == -1: rstripped = middle.rstrip(self.trailing_punctuation_chars) else: rstripped = middle.rstrip(self.trailing_punctuation_chars_no_semicolon) if rstripped != middle: trail.appendleft(middle[len(rstripped) :]) middle = rstripped trimmed_something = True [69131420]
- if self.trailing_punctuation_chars_has_semicolon and middle.endswith(";"): # Only strip if not part of an HTML entity. potential_entity = middle[amp:] escaped = html.unescape(potential_entity) if escaped == potential_entity or escaped.endswith(";"): rstripped = middle.rstrip(self.trailing_punctuation_chars) trail_start = len(rstripped) amount_trailing_semicolons = len(middle) - len(middle.rstrip(";")) if amp > -1 and amount_trailing_semicolons > 1: # Leave up to most recent semicolon as might be an # entity. recent_semicolon = middle[trail_start:].index(";") middle_semicolon_index = recent_semicolon + trail_start + 1 trail.appendleft(middle[middle_semicolon_index:]) middle = rstripped + middle[trail_start:middle_semicolon_index] else: trail.appendleft(middle[trail_start:]) middle = rstripped trimmed_something = True [f2e9a52d]
- # Continue trimming until middle remains unchanged. trimmed_something = True counts = CountsDict(word=middle) while trimmed_something and middle: trimmed_something = False # Trim wrapping punctuation. for opening, closing in self.wrapping_punctuation: if counts[opening] < counts[closing]: rstripped = middle.rstrip(closing) if rstripped != middle: strip = counts[closing] - counts[opening] trail.appendleft(middle[-strip:]) middle = middle[:-strip] trimmed_something = True counts[closing] -= strip [60eb8d02]
- If autoescape is True, autoescape the link text and URLs. """ safe_input = isinstance(text, SafeData) [33975510]
- If nofollow is True, give the links a rel="nofollow" attribute. [641b9645]
- trail = "".join(trail) return lead, middle, trail [18509922]
- words = self.word_split_re.split(str(text)) local_cache = {} urlized_words = [] for word in words: if (urlized_word := local_cache.get(word)) is None: urlized_word = self.handle_word( word, safe_input=safe_input, trim_url_limit=trim_url_limit, nofollow=nofollow, autoescape=autoescape, ) local_cache[word] = urlized_word urlized_words.append(urlized_word) return "".join(urlized_words) [3bc54da6]
- format_html_join('\n', "<li>{} {}</li>", ((u.first_name, u.last_name) for u in users)) """ return mark_safe( conditional_escape(sep).join( ( format_html(format_string, **args) if isinstance(args, Mapping) else format_html(format_string, *args) ) for args in args_generator ) ) [d6747205]
- # Handle IDN as percent-encoded UTF-8 octets, per WHATWG URL Specification # section 3.5 and RFC 3986 section 3.2.2. Defer any IDNA to the user agent. # See #36013. netloc = unquote_quote(netloc) [c5514b20]
- 'args_generator' should be an iterator that returns the sequence of 'args' that will be passed to format_html. [0afdb03b]
- @cached_property def trailing_punctuation_chars_has_semicolon(self): return ";" in self.trailing_punctuation_chars [1f6c030b]
- @cached_property def trailing_punctuation_chars_no_semicolon(self): return self.trailing_punctuation_chars.replace(";", "") [f5be364e]

## Beyond the budget

51 more facts did not fit in the budget: [237ceb6c] [65a5b264] [acc8ecae] [5694b9ba] [4c22ee01] [a525edd5] [aebfb852] [d63c10cb] [f9ac9105] [edfd772b] [c87c047d] [a5cac616] [fbaf3f2e] [e9ba61bb] [12bd7d48] [c109eb41] [8303b304] [7340cac7] [df1166e7] [46e10a74] [a2a01cbc] [f05efce8] [f45a2d2d] [efb4d959] [2691401f] [354f7054] [794cbb06] [0a656b5c] [a2181477] [bde5cb5e] [a623553d] [d41920d6] [3dc82aa4] [656cc6f1] [0768b000] [9bda34b4] [0e3a9c04] [692500aa] [9a3b4ef8] [2048d368] [7b210fdd] [7e6e867c] [61bd435b] [282f845c] [934c43f9] [c045a7e5] [1a5159fb] [2fef455a] [516dbe2d] [392ea25a] [3680f0f5]
