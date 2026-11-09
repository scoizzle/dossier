# django/views/i18n

- Subject: django/views/i18n (id `2e0d5512-e82e-45cc-93ee-37af4f7db131`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 10 of 27
- Conflicts: 0
- Gaps: 0

## Facts

- num_plurals = self._num_plurals for k, v in pdict.items(): catalog[k] = [v.get(i, "") for i in range(num_plurals)] return catalog [469b21e9]
- return HttpResponse( template.render(Context(context)), 'text/javascript; charset="utf-8"' ) [142a3922]
- with builtin_template_path("i18n_catalog.js").open(encoding="utf-8") as fh: template = Engine().from_string(fh.read()) context["catalog_str"] = ( indent(json.dumps(context["catalog"], sort_keys=True, indent=2)) if context["catalog"] else None ) context["formats_str"] = indent( json.dumps(context["formats"], sort_keys=True, indent=2) ) [de62f096]
- { "catalog": { # Translations catalog }, "formats": { # Language formats for date, time, etc. }, "plural": '...' # Expression for plural forms, or null. } """ [95965383]
- @property def _num_plurals(self): """ Return the number of plurals for this catalog language, or 2 if no plural string is available. """ match = re.search(r"nplurals=\s*(\d+)", self._plural_string or "") if match: return int(match[1]) return 2 [a2d6b66a]
- @property def _plural_string(self): """ Return the plural string (including nplurals) for this catalog language, or None if no plural string is available. """ if "" in self.translation._catalog: for line in self.translation._catalog[""].split("\n"): if line.startswith("Plural-Forms:"): return line.split(":", 1)[1].strip() return None [6847e9e8]
- Avoid calling this function at the module level or in a class-definition because __file__ may not exist, e.g. in frozen environments. """ return Path(__file__).parent / "templates" / name [846c39e6e200e068-3]
- Receive the list of packages to check for translations in the `packages` kwarg either from the extra dictionary passed to the path() function or as a plus-sign delimited string from the request. Default is 'django.conf'. [80a5ebcd]
- Receive the same parameters as JavaScriptCatalog and return a response with a JSON object of the following format: [08335c17]
- Since this view changes how the user will see the rest of the site, it must only be accessed as a POST request. If called as a GET request, it will redirect to the page in the request (the 'next' parameter) without changing any state. """ next_url = request.POST.get("next", request.GET.get("next")) if ( next_url or request.accepts("text/html") ) and not url_has_allowed_host_and_scheme( url=next_url, allowed_hosts={request.get_host()}, require_https=request.is_secure(), ): next_url = request.META.get("HTTP_REFERER") if not url_has_allowed_host_and_scheme( url=next_url, allowed_hosts={request.get_host()}, require_https=request.is_secure(), ): next_url = "/" response = HttpResponseRedirect(next_url) if next_url else HttpResponse(status=204) if request.method == "POST": lang_code = request.POST.get(LANGUAGE_QUERY_PARAMETER) if lang_code and check_for_language(lang_code): if next_url: next_trans = translate_url(next_url, lang_code) if next_trans != next_url: response = HttpResponseRedirect(next_trans) response.set_cookie( settings.LANGUAGE_COOKIE_NAME, lang_code, max_age=settings.LANGUAGE_COOKIE_AGE, path=settings.LANGUAGE_COOKIE_PATH, domain=settings.LANGUAGE_COOKIE_DOMAIN, secure=settings.LANGUAGE_COOKIE_SECURE, httponly=settings.LANGUAGE_COOKIE_HTTPONLY, samesite=settings.LANGUAGE_COOKIE_SAMESITE, ) return response [ecf58a23]

## Beyond the budget

17 more facts did not fit in the budget: [1ff78c60] [cbd2ad49] [d4596a5f] [b5fd00d5] [56c44517] [b4c8456a] [5cb49aac] [7c12c63f] [ee1a4c46] [7d09acd8] [c309d593] [92500b90] [84194fcb37f4a638-3] [209d62f9] [7a50d7ad] [0ed38741] [a44f79ed]
