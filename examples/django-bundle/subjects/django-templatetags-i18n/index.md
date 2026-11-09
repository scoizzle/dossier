# django/templatetags/i18n

- Subject: django/templatetags/i18n (id `598de091-e205-4169-ac8a-c76d2817b2a5`)
- Kind: subject
- Budget: 1200 tokens
- Used: 890 tokens
- Facts shown: 17 of 86
- Conflicts: 0
- Gaps: 0

## Facts

- data = {v: render_value(v) for v in vars} context.pop() try: result %= data except (KeyError, ValueError): if nested: # Either string is malformed, or it's a bug raise TemplateSyntaxError( "%r is unable to format string returned by gettext: %r " "using %r" % (self.tag_name, result, data) ) with translation.override(None): result = self.render(context, nested=True) if self.asvar: context[self.asvar] = SafeString(result) return "" else: return result [6c9de412]
- def render_value(key): if key in context: val = context[key] else: val = default_value % key if "%s" in default_value else default_value return render_value_in_context(val, context) [7d842188]
- {% blocktranslate count count=var|length %} There is {{ count }} object. {% plural %} There are {{ count }} objects. {% endblocktranslate %} [692b5f7d]
- {% blocktranslate with bar=foo|filter boo=baz|filter %} This is {{ bar }} and {{ boo }}. {% endblocktranslate %} [84489e2f]
- {% blocktranslate with bar=foo|filter boo=baz|filter asvar var %} This is {{ bar }} and {{ boo }}. {% endblocktranslate %} {{ var }} [0c5766e8]
- {% blocktranslate with bar=foo|filter context "greeting" %} This is {{ bar }}. {% endblocktranslate %} [592fcf6a]
- {% blocktranslate with foo|filter as bar and baz|filter as boo %} {% blocktranslate count var|length as count %} [78b19224]
- {% get_available_languages as languages %} {% for language in languages %} ... {% endfor %} [5f2e8828]
- {% get_current_language as language %} [a5ff4af9]
- {% get_current_language_bidi as bidi %} [5d017eee]
- {% get_language_info for LANGUAGE_CODE as l %} {{ l.code }} {{ l.name }} {{ l.name_translated }} {{ l.name_local }} {{ l.bidi|yesno:"bi-directional,uni-directional" }} """ args = token.split_contents() if len(args) != 5 or args[1] != "for" or args[3] != "as": raise TemplateSyntaxError( "'%s' requires 'for string as variable' (got %r)" % (args[0], args[1:]) ) return GetLanguageInfoNode(parser.compile_filter(args[2]), args[4]) [a7c46eb3]
- {% get_language_info_list for LANGUAGES as langs %} {% for l in langs %} {{ l.code }} {{ l.name }} {{ l.name_translated }} {{ l.name_local }} {{ l.bidi|yesno:"bi-directional,uni-directional" }} {% endfor %} """ args = token.split_contents() if len(args) != 5 or args[1] != "for" or args[3] != "as": raise TemplateSyntaxError( "'%s' requires 'for sequence as variable' (got %r)" % (args[0], args[1:]) ) return GetLanguageInfoListNode(parser.compile_filter(args[2]), args[4]) [b8cf05e4]
- {% language "de" %} This is {{ bar }} and {{ boo }}. {% endlanguage %} """ bits = token.split_contents() if len(bits) != 2: raise TemplateSyntaxError("'%s' takes one argument (language)" % bits[0]) language = parser.compile_filter(bits[1]) nodelist = parser.parse(("endlanguage",)) parser.delete_first_token() return LanguageNode(nodelist, language) [ab84a45c]
- {% translate "this is a test" %} [96d5e65c]
- {% translate "this is a test" as var %} {{ var }} [5d2c4c91]
- {% translate "this is a test" context "greeting" %} [3ed8ce7b]
- {% translate "this is a test" noop %} [91f1babe]

## Beyond the budget

66 more facts did not fit in the budget: [7768528b] [f4fd13b4] [a2addd50] [5c8e194a] [62f3c42d] [b994f1a1] [ad8ccb20] [437ef609] [2fb3ed09] [88a294ee] [e416e981] [ade312ef] [d5ba7956] [e93177f2] [2f4cc351] [d72b3c5e] [728f3f44] [a898892ae0cdf6fe-8] [a898892ae0cdf6fe-9] [a898892ae0cdf6fe-10] [a898892ae0cdf6fe-11] [a898892ae0cdf6fe-12] [a898892ae0cdf6fe-13] [a898892ae0cdf6fe-14] [a898892ae0cdf6fe-15] [9d229cd3] [f91a3950] [8dd75e43] [283ed16f] [e672faa8] [564235a4] [960e5d74] [085b37b2] [54a21044] [0d41b662] [9a9190b5] [f74bbffd] [2106d9d4] [7b3b9927] [d8f8b76f] [4f484c42] [a5647178] [88d0d5b6] [294031a0] [615aed67] [e9de8a03] [557ef01a] [8e94d165] [ddcaac8b] [4dbc4a01] [99d6e11a] [52fe19b0] [2d4b6fd7] [b8933983] [6d8d88a4] [20ecadbc] [9f58bff0] [9df62408] [0aa0323f] [3e845b60] [fb9ca2ea] [2e66b561] [9000cc67] [2f76b6f177b243e2-3] [4de3bfd8] [c8c0ccd629deb6b1-7]
