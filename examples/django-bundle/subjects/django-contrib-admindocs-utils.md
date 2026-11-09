# django/contrib/admindocs/utils

- Subject: django/contrib/admindocs/utils (id `9b58ee39-3f1e-4387-9a10-89ce2990d2e0`)
- Kind: subject
- Budget: 1200 tokens
- Used: 883 tokens
- Facts shown: 12 of 26
- Conflicts: 0
- Gaps: 0

## Facts

- From sphinx.util.nodes.split_explicit_title. See: https://github.com/sphinx-doc/sphinx/blob/230ccf2/sphinx/util/nodes.py#L389 """ match = explicit_title_re.match(text) if match: return True, match.group(1), match.group(2) return False, text, text [dd2b53bf]
- def _role(name, rawtext, text, lineno, inliner, options=None, content=None): if options is None: options = {} _, title, target = split_explicit_title(text) node = docutils.nodes.reference( rawtext, title, refuri=( urlbase % ( inliner.document.settings.link_base, target if is_case_sensitive else target.lower(), ) ), **options, ) return [node], [] [0af39734]
- docutils.parsers.rst.roles.register_canonical_role(rolename, _role) [6d11423b]
- for name, urlbase in ROLES.items(): create_reference_role(name, urlbase) [127041fc]
- "Misc. utility functions/classes for admin documentation generator." [8c3c7d2e]
- # # reST roles # ROLES = { "model": "%s/models/%s/", "view": "%s/views/%s/", "template": "%s/templates/%s/", "filter": "%s/filters/#%s", "tag": "%s/tags/#%s", } [a5b8efdd]
- # Match the beginning of a named, unnamed, or non-capturing groups. named_group_matcher = _lazy_re_compile(r"\(\?P(<\w+>)") unnamed_group_matcher = _lazy_re_compile(r"\(") non_capturing_group_matcher = _lazy_re_compile(r"\(\?\:") [432d05df]
- .. default-role:: """ # In docutils < 0.22, the `writer` param must be an instance. Passing a # string writer name like "html" is only supported in 0.22+. writer_instance = docutils.writers.get_writer_class("html")() parts = docutils.core.publish_parts( source % text, source_path=thing_being_parsed, destination_path=None, writer=writer_instance, settings_overrides=overrides, ) return mark_safe(parts["fragment"]) [0af261a9]
- def _find_groups(pattern, group_matcher): prev_end = None for match in group_matcher.finditer(pattern): if indices := _get_group_start_end(match.start(0), match.end(0), pattern): start, end = indices if prev_end and start > prev_end or not prev_end: yield start, end, match prev_end = end [1a5a7940]
- def _get_group_start_end(start, end, pattern): # Handle nested parentheses, e.g. '^(?P<a>(x|y))/b' or '^b/((x|y)\w+)$'. unmatched_open_brackets, prev_char = 1, None for idx, val in enumerate(pattern[end:]): # Check for unescaped `(` and `)`. They mark the start and end of a # nested group. if val == "(" and prev_char != "\\": unmatched_open_brackets += 1 elif val == ")" and prev_char != "\\": unmatched_open_brackets -= 1 prev_char = val # If brackets are balanced, the end of the string for the current named # capture group pattern has been reached. if unmatched_open_brackets == 0: return start, end + idx + 1 [061ab7c1]
- def create_reference_role(rolename, urlbase): # Views and template names are case-sensitive. is_case_sensitive = rolename in ["template", "view"] [2b64e2cb]
- def default_reference_role( name, rawtext, text, lineno, inliner, options=None, content=None ): if options is None: options = {} context = inliner.document.settings.default_reference_context node = docutils.nodes.reference( rawtext, text, refuri=( ROLES[context] % ( inliner.document.settings.link_base, text.lower(), ) ), **options, ) return [node], [] [c0ac4240]

## Beyond the budget

14 more facts did not fit in the budget: [a4f61d87] [396f0212] [e955ecbc] [a3e1fa7f] [67bc8526] [acdf15bd] [32cd1781] [ff730bc0] [47c61b77] [d6824fce] [79aaf57d] [fcf210a3] [1e17b7ed] [b5a836bd]
