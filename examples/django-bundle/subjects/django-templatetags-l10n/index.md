# django/templatetags/l10n

- Subject: django/templatetags/l10n (id `eb56be23-30b1-4346-9368-417bfff8c629`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 442 tokens
- Facts shown: 10 facts
- Conflicts: 0
- Gaps: 0

## Facts

- {% localize off %} var pi = {{ 3.1415 }}; {% endlocalize %} """ use_l10n = None bits = list(token.split_contents()) if len(bits) == 1: use_l10n = True elif len(bits) > 2 or bits[1] not in ("on", "off"): raise TemplateSyntaxError("%r argument should be 'on' or 'off'" % bits[0]) else: use_l10n = bits[1] == "on" nodelist = parser.parse(("endlocalize",)) parser.delete_first_token() return LocalizeNode(nodelist, use_l10n) [534ae4ae]
- Sample usage:: [2a5c6dd4ec548fdd-5]
- def __repr__(self): return "<%s>" % self.__class__.__name__ [791ef1e88e5bd5fd-3]
- def render(self, context): old_setting = context.use_l10n context.use_l10n = self.use_l10n output = self.nodelist.render(context) context.use_l10n = old_setting return output [0d80f84d]
- @register.filter(is_safe=False) def localize(value): """ Force a value to be rendered as a localized value. """ return str(formats.localize(value, use_l10n=True)) [24a69df9]
- @register.filter(is_safe=False) def unlocalize(value): """ Force a value to be rendered as a non-localized value. """ return str(formats.localize(value, use_l10n=False)) [3210cce8]
- @register.tag("localize") def localize_tag(parser, token): """ Force or prevents localization of values. [573fd8ad]
- class LocalizeNode(Node): def __init__(self, nodelist, use_l10n): self.nodelist = nodelist self.use_l10n = use_l10n [b0092f6b]
- from django.template import Library, Node, TemplateSyntaxError from django.utils import formats [6994c05c]
- register = Library() [c8c0ccd629deb6b1-8]
