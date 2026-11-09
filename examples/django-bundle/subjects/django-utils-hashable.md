# django/utils/hashable

- Subject: django/utils/hashable (id `68ef6aab-ea48-4f96-abfd-4b7bcaa024cc`)
- Kind: subject
- Budget: 1200 tokens
- Used: 176 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- The returned value should generate the same hash for equal values. """ if isinstance(value, dict): return tuple( [ (key, make_hashable(nested_value)) for key, nested_value in sorted(value.items()) ] ) # Try hash to avoid converting a hashable iterable (e.g. string, frozenset) # to a tuple. try: hash(value) except TypeError: if isinstance(value, Iterable): return tuple(map(make_hashable, value)) # Non-hashable, non-iterable. raise return value [196d5a1e]
- def make_hashable(value): """ Attempt to make value hashable or raise a TypeError if it fails. [923baa6d]
- from collections.abc import Iterable [0957225fa9318a60-2]
