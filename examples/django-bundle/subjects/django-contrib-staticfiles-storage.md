# django/contrib/staticfiles/storage

- Subject: django/contrib/staticfiles/storage (id `2fb2d5e4-5294-4ae0-a32b-b2c8842627c8`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 15 of 72
- Conflicts: 0
- Gaps: 0

## Facts

- if self.exists(hashed_name): self.delete(hashed_name) [c4312fc3]
- saved_name = self._save(hashed_name, content_file) hashed_name = self.clean_name(saved_name) # If the file hash stayed the same, this file didn't change if old_hashed_name == hashed_name: substitutions = False processed = True [8c54a1c4]
- # ..to apply each replacement pattern to the content if name in adjustable_paths: old_hashed_name = hashed_name try: content = original_file.read().decode("utf-8") except UnicodeDecodeError as exc: yield name, None, exc, False for extension, patterns in self._patterns.items(): if matches_patterns(path, (extension,)): if not any(p.search(content) for p, _, _ in patterns): continue for pattern, template, ignored_re in patterns: converter = self.url_converter( name, hashed_files, template, self.get_ignored_blocks( content, ignored_re, ), ) try: content = pattern.sub(converter, content) except ValueError as exc: yield name, None, exc, False if hashed_file_exists: self.delete(hashed_name) # then save the processed result content_file = ContentFile(content.encode()) if self.keep_intermediate_files: # Save intermediate file for reference self._save(hashed_name, content_file) hashed_name = self.hashed_name(name, content_file) [12a4332e]
- # and then set the cache accordingly hashed_files[hash_key] = hashed_name [45065813]
- # generate the hash with the original content, even for # adjustable files. if hash_key not in hashed_files: hashed_name = self.hashed_name(name, original_file) else: hashed_name = hashed_files[hash_key] [66955ce3]
- # then get the original's file content.. if hasattr(original_file, "seek"): original_file.seek(0) [92c10ad2]
- hashed_file_exists = self.exists(hashed_name) processed = False [8f580ea0]
- if not processed: # or handle the case in which neither processing nor # a change to the original file happened if not hashed_file_exists: processed = True saved_name = self._save(hashed_name, original_file) hashed_name = self.clean_name(saved_name) [fcda2e57]
- yield name, hashed_name, processed, substitutions [d2d8a822]
- # Determine the hashed name of the target file with the storage # backend. try: hashed_url = self._url( self._stored_name, unquote(target_name), force=True, hashed_files=hashed_files, ) except ValueError as exc: line = _line_at_position(matchobj.string, matchobj.start()) note = f"{name!r} contains this reference {matched!r} on line {line}" exc.add_note(note) raise exc [5733e83a]
- # Ignore URLs in comments and string literals. if ignored_blocks and self.is_in_ignored_block( matchobj.start(), ignored_blocks ): return matched [f40dc364]
- # Ignore URLs without a path if not url_path: return matched [bf07064c]
- # Ignore absolute URLs that don't point to a static file (dynamic # CSS / JS?). Note that STATIC_URL cannot be empty. if url.startswith("/") and not url.startswith(settings.STATIC_URL): return matched [dc297eae]
- # Ignore absolute/protocol-relative and data-uri URLs. if re.match(r"^[a-z]+:", url) or url.startswith("//"): return matched [24dca84b]
- # Strip off the fragment so a path-like fragment won't interfere. url_path, fragment = urldefrag(url) [6efcc3fb]

## Beyond the budget

57 more facts did not fit in the budget: [84e2a5b9] [5d7ef712] [89bf7452] [81f2c97f] [7f512bae] [4a0b0296] [a5e92e5f] [9eb5af40] [dbc1c543] [8e67f8df] [3bbede38] [4381efb8] [6c1b809a] [169c1891] [f8cbe315] [1433343f] [30c8adc5] [fecf863e] [bf3a04e7] [8f952a3e] [5ca7797b] [318fd4ef] [2995b642af280a57-5] [96054fcb] [3b63da9c] [0963e093] [4211db0b] [d5d95c22] [5a590e91] [cd06129e] [a83ba712] [035c188e] [2200d894] [bea2cd6f] [6d091a4c] [8b10d5c6] [b35b2f46] [f4b0f5ab] [350d63ab] [37513ead] [5d3572d6] [07cdc7bd] [ea664a16] [fc267923] [5cffd2ca] [afb93506] [80a99192] [7655780f0d17b825-12] [68c4ca55] [0fc74067] [ae89148e] [62fc1e29] [f89b260e] [b46f969e] [9111be0e] [32c3e25f] [a50b3978]
