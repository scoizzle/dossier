# django/urls/converters

- Subject: django/urls/converters (id `7cc7140a-1cd7-4bd3-9c36-8c3bb9e701ed`)
- Kind: subject
- Budget: 1200 tokens
- Used: 425 tokens
- Facts shown: 15 of 18
- Conflicts: 0
- Gaps: 0

## Facts

- _route_to_regex.cache_clear() [a318c3b9]
- def to_python(self, value): return int(value) [fed5d990]
- def to_python(self, value): return uuid.UUID(value) [bb9c7e6b]
- def to_url(self, value): return str(value) [a030254e048c5261]
- from django.urls.resolvers import _route_to_regex [379412f2]
- @functools.cache def get_converters(): return {**DEFAULT_CONVERTERS, **REGISTERED_CONVERTERS} [a42b94b0]
- DEFAULT_CONVERTERS = { "int": IntConverter(), "path": PathConverter(), "slug": SlugConverter(), "str": StringConverter(), "uuid": UUIDConverter(), } [3a06c475]
- REGISTERED_CONVERTERS = {} [cc4112b2]
- class IntConverter: regex = "[0-9]+" [4da4efb7]
- class PathConverter(StringConverter): regex = ".+" [84d55a5d]
- class SlugConverter(StringConverter): regex = "[-a-zA-Z0-9_]+" [70635857]
- class StringConverter: regex = "[^/]+" [a8b7aa68]
- class UUIDConverter: regex = "[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}" [c9084cd8]
- def register_converter(converter, type_name): if type_name in REGISTERED_CONVERTERS or type_name in DEFAULT_CONVERTERS: raise ValueError(f"Converter {type_name!r} is already registered.") REGISTERED_CONVERTERS[type_name] = converter() get_converters.cache_clear() [e9988a93]
- import functools import uuid [27bdb795]
