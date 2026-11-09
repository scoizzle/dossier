# django/urls/resolvers

- Subject: django/urls/resolvers (id `d09bb39b-e2b5-4e48-b87b-3e4447fb46ed`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 9 of 74
- Conflicts: 0
- Gaps: 0

## Facts

- callback = getattr(urls, "handler%s" % view_type) return get_callable(callback) [55eaad0e]
- # If a URLRegexResolver doesn't have a namespace or app_name, it passes # in an empty value. self.app_names = [x for x in app_names if x] if app_names else [] self.app_name = ":".join(self.app_names) self.namespaces = [x for x in namespaces if x] if namespaces else [] self.namespace = ":".join(self.namespaces) [b8d677bf]
- for possibility, pattern, defaults, converters in possibilities: for result, params in possibility: if args: if len(args) != len(params): continue candidate_subs = dict(zip(params, args)) else: if set(kwargs).symmetric_difference(params).difference(defaults): continue matches = True for k, v in defaults.items(): if k in params: continue if kwargs.get(k, v) != v: matches = False break if not matches: continue candidate_subs = kwargs # Convert the candidate subs to text using Converter.to_url(). text_candidate_subs = {} match = True for k, v in candidate_subs.items(): if k in converters: try: text_candidate_subs[k] = converters[k].to_url(v) except ValueError: match = False break else: text_candidate_subs[k] = str(v) if not match: continue # WSGI provides decoded URLs, without %xx escapes, and the URL # resolver operates on such URLs. First substitute arguments # without quoting to build a decoded URL and look for a match. # Then, if we have a match, redo the substitution with quoted # arguments in order to return a properly encoded URL. candidate_pat = _prefix.replace("%", "%%") + result if re.search( "^%s%s" % (re.escape(_prefix), pattern), candidate_pat % text_candidate_subs, ): # safe characters from `pchar` definition of RFC 3986 url = quote( candidate_pat % text_candidate_subs, safe=RFC3986_SUBDELIMS + "/~:@", ) # Don't allow construction of scheme relative urls. return escape_leading_slashes(url) # lookup_view can be URL name or callable, but callables are not # friendly in error messages. m = getattr(lookup_view, "__module__", None) n = getattr(lookup_view, "__name__", None) if m is not None and n is not None: lookup_view_s = "%s.%s" % (m, n) else: lookup_view_s = lookup_view [4c8e6c1f]
- if hasattr(func, "view_class"): func = func.view_class if not hasattr(func, "__name__"): # A class-based view self._func_path = func.__class__.__module__ + "." + func.__class__.__name__ else: # A function-based view self._func_path = func.__module__ + "." + func.__name__ [f06b9ff4]
- if not self._populated: self._populate() [a0715244]
- patterns = [pattern for (_, pattern, _, _) in possibilities] if patterns: if args: arg_msg = "arguments '%s'" % (args,) elif kwargs: arg_msg = "keyword arguments '%s'" % kwargs else: arg_msg = "no arguments" msg = "Reverse for '%s' with %s not found. %d pattern(s) tried: %s" % ( lookup_view_s, arg_msg, len(patterns), patterns, ) else: msg = ( "Reverse for '%(view)s' not found. '%(view)s' is not " "a valid view function or pattern name." % {"view": lookup_view_s} ) raise NoReverseMatch(msg) [d6d56830]
- possibilities = self.reverse_dict.getlist(lookup_view) [4628f97d]
- start, end = match_.span() parts.append(re.escape(route[previous_end:start])) previous_end = end parts.append(f"(?P<{parameter}>{converter.regex})") [61178205]
- view_path = url_name or self._func_path self.view_name = ":".join([*self.namespaces, view_path]) [57ad4245]

## Beyond the budget

63 more facts did not fit in the budget: [ddb36272] [eeb56e31] [3396ebb4] [ee46e56c] [6dd4d777] [87d2c184] [405a0508] [91e27be7] [9e1a448a] [fe182379] [2417493a] [71262b3c] [bbc2b777] [12efd919] [4b14176b] [22118b30] [21172b30] [fadecfda] [0b7c8ae4] [7af15799] [817d70f1] [5fbb1115] [2ea613fd] [ed606b83] [df20bce7] [8eb99509] [88f9e13b] [c3fe6afc] [95b9794e] [163a801e] [7734d830] [5f652215] [4cb4721b] [a594af0b] [3f25597f] [244f318c] [c09c0559] [616f2990] [ff308c74] [3ea2b0a5] [e7544383] [a20efa72] [8dca5444] [70e21e9e] [979ba2f5] [527ce11f] [32d0c89b] [dcdfcc65] [d30a2490] [7f6adff2] [75614d62] [ffc10395] [12f9aa78] [d74a3443] [ddd0d383] [8677ab00] [ac93be3e] [061a4450] [50c2f021] [6beab4e4549a99b7-4] [633d07d5] [06c398b2] [52ef55b1]
