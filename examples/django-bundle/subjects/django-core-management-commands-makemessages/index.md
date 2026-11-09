# django/core/management/commands/makemessages

- Subject: django/core/management/commands/makemessages (id `df8701c8-a0cc-4d42-927e-ce78366c394c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 887 tokens
- Facts shown: 10 of 67
- Conflicts: 0
- Gaps: 0

## Facts

- # Recheck if the proposed locale is valid if is_valid_locale(proposed_locale): self.stdout.write( "invalid locale %s, did you mean %s?" % ( locale, proposed_locale, ), ) else: self.stdout.write("invalid locale %s" % locale) [6e5ae4a6]
- # Search for characters followed by a non character (i.e. # separator) match = re.match( r"^(?P<language>[a-zA-Z]+)" r"(?P<separator>[^a-zA-Z])" r"(?P<territory>.+)$", locale, ) if match: locale_parts = match.groupdict() language = locale_parts["language"].lower() territory = ( locale_parts["territory"][:2].upper() + locale_parts["territory"][2:] ) proposed_locale = f"{language}_{territory}" else: # It could be a language in uppercase proposed_locale = locale.lower() [dbd428f4]
- continue if self.verbosity > 0: self.stdout.write("processing locale %s" % locale) for potfile in potfiles: self.write_po_file(potfile, locale) finally: if not self.keep_pot: self.remove_potfiles() [b943b1bc]
- # Build po files for each selected locale for locale in locales: if not is_valid_locale(locale): # Try to guess what valid locale it could be # Valid examples are: en_GB, shi_Latn_MA and # nl_NL-x-informal [959d89e6]
- # Account for excluded locales if process_all: locales = all_locales else: locales = locale or all_locales locales = set(locales).difference(exclude) [2e7a40e6]
- # Avoid messing with mutable class variables if options["no_wrap"]: self.msgmerge_options = self.msgmerge_options[:] + ["--no-wrap"] self.msguniq_options = self.msguniq_options[:] + ["--no-wrap"] self.msgattrib_options = self.msgattrib_options[:] + ["--no-wrap"] self.xgettext_options = self.xgettext_options[:] + ["--no-wrap"] if options["no_location"]: self.msgmerge_options = self.msgmerge_options[:] + ["--no-location"] self.msguniq_options = self.msguniq_options[:] + ["--no-location"] self.msgattrib_options = self.msgattrib_options[:] + ["--no-location"] self.xgettext_options = self.xgettext_options[:] + ["--no-location"] if options["add_location"]: arg_add_location = "--add-location=%s" % options["add_location"] self.msgmerge_options = self.msgmerge_options[:] + [arg_add_location] self.msguniq_options = self.msguniq_options[:] + [arg_add_location] self.msgattrib_options = self.msgattrib_options[:] + [arg_add_location] self.xgettext_options = self.xgettext_options[:] + [arg_add_location] [8320cfd7]
- # Build locale list looks_like_locale = re.compile(r"[a-z]{2}") locale_dirs = filter( os.path.isdir, glob.glob("%s/*" % self.default_locale_path) ) all_locales = [ lang_code for lang_code in map(os.path.basename, locale_dirs) if looks_like_locale.match(lang_code) ] [835f5d19]
- # Remove '.py' suffix if os.name == "nt": # Preserve '.\' prefix on Windows to respect gettext behavior old_path = self.work_path new_path = self.path else: old_path = self.work_path[2:] new_path = self.path[2:] [62499c9c]
- Transform paths as if these messages were generated from original translatable files rather than from preprocessed versions. """ if not self.is_templatized: return msgs [1563dc78]
- Use msgmerge and msgattrib GNU gettext utilities. """ basedir = os.path.join(os.path.dirname(potfile), locale, "LC_MESSAGES") os.makedirs(basedir, exist_ok=True) pofile = os.path.join(basedir, "%s.po" % self.domain) [a3ec4674]

## Beyond the budget

57 more facts did not fit in the budget: [8c9cd83a] [08896998] [bae975d0] [2c8761dc] [2cd6d544] [3c5336fe] [a145eaf0] [64f74fd1] [477fd32f] [338c4800] [f0f8a1ce] [3073edce] [79b70d6f] [81b0787c] [dba6842e] [4f948042] [2fd509c9] [92e4fc2c] [27bbe725] [64a6503e] [cd2809dc] [ebd6e58e] [ed5ca408] [bf0c1070] [4f106ec8] [afe38d82] [57ce5d85] [f4d936fb] [6e7a0494] [4f318ab8] [36de32d5] [f7b91a6e] [0203632b] [5aa5e1a7] [3a511cd1] [9f35f72d] [21377c6a] [dadd25bd] [0f8dd1fa] [b05f029b] [58cb813c] [85c40a11] [9b11b3f7] [decd20be] [623a5be3] [72e6d136f77918ef-7] [e7276c77] [ddadb7a7] [3c1aea39] [2663d32e] [30a94c90] [d0b0ac60] [20a623c3] [c150ccbf] [f4bdd1e1] [25eac0e5] [5c9cf752]
