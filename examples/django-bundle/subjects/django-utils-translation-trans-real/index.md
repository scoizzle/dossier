# django/utils/translation/trans_real

- Subject: django/utils/translation/trans_real (id `9499c9d8-aa99-44ef-be87-2f2fe3dd3ac0`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 14 of 90
- Conflicts: 0
- Gaps: 0

## Facts

- A convenience wrapper. By default gettext uses 'fallback=False'. Using param `use_null_fallback` to avoid confusion with any other references to 'fallback'. """ return gettext_module.translation( domain=self.domain, localedir=localedir, languages=[self.__locale], fallback=use_null_fallback, ) [abae22c8]
- if localedirs: for localedir in localedirs: translation = self._new_gnu_trans(localedir) self.merge(translation) else: self._add_installed_apps_translations() [d7d713de]
- if not language_code_re.search(accept_lang): continue [92d40450]
- if self.domain == "django": if localedirs is not None: # A module-level cache is used for caching 'django' # translations warnings.warn( "localedirs is ignored when domain is 'django'.", RuntimeWarning ) localedirs = None self._init_translation_catalog() [1a8ca9d8]
- result = translation_object.gettext(eol_message) else: # Return an empty value of the corresponding type if an empty message # is given, instead of metadata, which is the default gettext behavior. result = type(message)("") [aa9c4db6]
- self.__language = language self.__to_language = to_language(language) self.__locale = to_locale(language) self._catalog = None # If a language doesn't have a catalog, use the Germanic default for # pluralization: anything except one is pluralized. self.plural = lambda n: int(n != 1) [901724a0]
- self._add_local_translations() if ( self.__language == settings.LANGUAGE_CODE and self.domain == "django" and self._catalog is None ): # default lang should have at least one translation file available. raise OSError( "No translation files found for default language %s." % settings.LANGUAGE_CODE ) self._add_fallback(localedirs) if self._catalog is None: # No catalogs found for this language, set an empty catalog. self._catalog = TranslationCatalog() [21d11994]
- try: return get_supported_language_variant(accept_lang) except LookupError: continue [ff03b176]
- # Don't attempt to parse if there is only one language-range value which is # longer than the maximum allowed length and so truncated. return () [6fadb263]
- # If there is at least one comma in the value, parse up to the last comma # before the max length, skipping any truncated parts at the end of the # header value. if (index := lang_string.rfind(",", 0, LANGUAGE_CODE_MAX_LENGTH)) > 0: return _parse_accept_lang_header(lang_string[:index]) [e8d8a06c]
- * False = left-to-right layout * True = right-to-left layout """ lang = get_language() if lang is None: return False else: base_lang = get_language().split("-")[0] return base_lang in settings.LANGUAGES_BIDI [8a0c0c8a]
- If `strict` is False (the default), look for a country-specific variant when neither the language code nor its generic variant is found. [78e8bc49]
- If `strict` is False (the default), look for a country-specific variant when neither the language code nor its generic variant is found. """ regex_match = language_code_prefix_re.match(path) if not regex_match: return None lang_code = regex_match[1] try: return get_supported_language_variant(lang_code, strict=strict) except LookupError: return None [05423487]
- def __setitem__(self, key, value): self._catalogs[0][key] = value [b51e579b]

## Beyond the budget

76 more facts did not fit in the budget: [fdd2d861] [d6122115] [ed93ba13] [ec396ffb] [953fb1c1] [749b8e43] [b2a5c805] [3940808c] [5dcfe9a8] [664efd91] [cc48a987] [33d57e25] [4d4b67ed] [9864494e] [f0c68b6b] [9a2bdfaa] [20f2b63e] [6d3ad6b4] [0d038be0] [24e1b820] [c7f6ccd1] [b108caba] [002e1587] [c772fa13] [1695d1ca] [30e916dd] [be9fec59] [981c24f8] [7c83f3e7] [aaefed8a] [85151dea] [1756b541] [8cb25dc4] [e6d2cf0b52c4ebca-6] [f2871928] [2376c2b7] [d13b94b8] [c78861cd] [b4d47e47] [adbb2995] [54dbf2d0] [0e49c72d] [69f6eace] [d717671a] [dd03c2df] [7f20dc99] [8d4f5789] [6001c63f] [fd42a486] [83c98d50] [e6bf146b] [e87583ff] [d2086516] [0fda929f] [9a45441c] [fcf06e21] [ab210b82] [3e07db64] [c8dd8f0a] [e8c5b723] [53c63a6f] [a946438f] [a5cdd649] [aaf966a2] [f3c5e411] [bb757c7d] [0f79b564] [b3ee5426] [ae934fa6] [aa91a912] [c58f26ee] [6beab4e4549a99b7-8] [528583d7] [311a0ddb] [0da837e2] [af0af919]
