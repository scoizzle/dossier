# django/utils/copy

- Subject: django/utils/copy (id `f0f638da-1fea-406c-ae5c-846e972ae0a6`)
- Kind: subject
- Budget: 1200 tokens
- Used: 155 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- This is especially useful for immutable objects, like named tuples or frozen dataclasses. """ cls = obj.__class__ func = getattr(cls, "__replace__", None) if func is None: raise TypeError(f"replace() does not support {cls.__name__} objects") return func(obj, **changes) [4a3cec7d]
- from django.utils.version import PY313 [634f54da]
- if PY313: from copy import replace else: # Backport of copy.replace() from Python 3.13. def replace(obj, /, **changes): """Return a new object replacing specified fields with new values. [1880f385]
