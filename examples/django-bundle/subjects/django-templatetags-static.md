# django/templatetags/static

- Subject: django/templatetags/static (id `50fc5000-b25d-4fa8-9564-cbfbaf413ecb`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 25 of 36
- Conflicts: 0
- Gaps: 0

## Facts

- return staticfiles_storage.url(path) else: return urljoin(PrefixNode.handle_simple("STATIC_URL"), quote(path)) [c17086c7]
- if len(bits) < 2: raise template.TemplateSyntaxError( "'%s' takes at least one argument (path to file)" % bits[0] ) [8b062d07]
- if len(bits) >= 2 and bits[-2] == "as": varname = bits[3] else: varname = None [4812db8c]
- path = parser.compile_filter(bits[1]) [7c26c98c]
- return cls(varname, path) [dc8bf1cb]
- {% get_media_prefix %} {% get_media_prefix as media_prefix %} """ return PrefixNode.handle_token(parser, token, "MEDIA_URL") [f78d20be]
- {% get_media_prefix [as varname] %} [1293a35c]
- {% get_static_prefix %} {% get_static_prefix as static_prefix %} """ return PrefixNode.handle_token(parser, token, "STATIC_URL") [469d06b7]
- {% get_static_prefix [as varname] %} [be583d50]
- {% static "myapp/css/base.css" %} {% static variable_with_path %} {% static "myapp/css/base.css" as admin_base_css %} {% static variable_with_path as varname %} """ return StaticNode.handle_token(parser, token) [3bb694d5]
- {% static path [as varname] %} [835566ce]
- @classmethod def handle_simple(cls, name): try: from django.conf import settings except ImportError: prefix = "" else: prefix = iri_to_uri(getattr(settings, name, "")) return prefix [83c9ea63]
- @classmethod def handle_simple(cls, path): if apps.is_installed("django.contrib.staticfiles"): from django.contrib.staticfiles.storage import staticfiles_storage [a75e02e2]
- @classmethod def handle_token(cls, parser, token): """ Class method to parse prefix node and return a Node. """ bits = token.split_contents() [583d06f8]
- @classmethod def handle_token(cls, parser, token, name): """ Class method to parse prefix node and return a Node. """ # token.split_contents() isn't useful here because tags using this # method don't accept variable as arguments. tokens = token.contents.split() if len(tokens) > 1 and tokens[1] != "as": raise template.TemplateSyntaxError( "First argument in '%s' must be 'as'" % tokens[0] ) if len(tokens) > 1: varname = tokens[2] else: varname = None return cls(varname, name) [c6fb0008]
- Examples:: [322709b3dcb3a0bb-2]
- Examples:: [322709b3dcb3a0bb-3]
- Examples:: [322709b3dcb3a0bb-4]
- Usage:: [a898892ae0cdf6fe-16]
- Usage:: [a898892ae0cdf6fe-17]
- Usage:: [a898892ae0cdf6fe-18]
- def __init__(self, varname=None, name=None): if name is None: raise template.TemplateSyntaxError( "Prefix nodes must be given a name to return." ) self.varname = varname self.name = name [9d7e796b]
- def __init__(self, varname=None, path=None): if path is None: raise template.TemplateSyntaxError( "Static template nodes must be given a path to return." ) self.path = path self.varname = varname [63280c48]
- def __repr__(self): return ( f"{self.__class__.__name__}(varname={self.varname!r}, path={self.path!r})" ) [50e95221]
- def url(self, context): path = self.path.resolve(context) return self.handle_simple(path) [c5213be6]

## Beyond the budget

10 more facts did not fit in the budget: [4b61e4e2] [3e8b0074] [0b01265a] [628c9c66] [acfdc8be] [fe8d5d14] [0f86a162] [3fc1124f] [d0cfeba2] [8e0cd5cc07f83b92-7]
