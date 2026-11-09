# django/urls/__init__

- Subject: django/urls/__init__ (id `5f67e9f6-6503-4865-817f-1412bf31fdd9`)
- Kind: subject
- Budget: 1200 tokens
- Used: 249 tokens
- Facts shown: 2 of 2
- Conflicts: 0
- Gaps: 0

## Facts

- __all__ = [ "LocalePrefixPattern", "NoReverseMatch", "URLPattern", "URLResolver", "Resolver404", "ResolverMatch", "clear_script_prefix", "clear_url_caches", "get_callable", "get_mod_func", "get_ns_resolver", "get_resolver", "get_script_prefix", "get_urlconf", "include", "is_valid_path", "path", "re_path", "register_converter", "resolve", "reverse", "reverse_lazy", "set_script_prefix", "set_urlconf", "translate_url", ] [894019a9]
- from .base import ( clear_script_prefix, clear_url_caches, get_script_prefix, get_urlconf, is_valid_path, resolve, reverse, reverse_lazy, set_script_prefix, set_urlconf, translate_url, ) from .conf import include, path, re_path from .converters import register_converter from .exceptions import NoReverseMatch, Resolver404 from .resolvers import ( LocalePrefixPattern, ResolverMatch, URLPattern, URLResolver, get_ns_resolver, get_resolver, ) from .utils import get_callable, get_mod_func [5f4b7e2d]
