# django/utils/safestring

- Subject: django/utils/safestring (id `db719edd-7d3f-4af6-ba56-a2417a34abfc`)
- Kind: subject
- Budget: 1200 tokens
- Used: 648 tokens
- Facts shown: 17 of 17
- Conflicts: 0
- Gaps: 0

## Facts

- # Give the rhs object a chance to handle the addition, for example if # the rhs object's class implements `__radd__`. More details: # https://docs.python.org/3/reference/datamodel.html#object.__radd__ return NotImplemented [d3342108]
- This allows other template engines to understand Django's SafeData. """ return self [bb98b46f]
- Can be called multiple times on a single string. """ if hasattr(s, "__html__"): return s if callable(s): return _safety_decorator(mark_safe, s) return SafeString(s) [26103738]
- If used on a method as a decorator, mark the returned data as safe. [736b541d]
- __slots__ = () [f6d76e8d3390a9c2-2]
- def __add__(self, rhs): """ Concatenating a safe string with another safe bytestring or safe string is safe. Otherwise, the result is no longer safe. """ if isinstance(rhs, str): t = super().__add__(rhs) if isinstance(rhs, SafeData): t = SafeString(t) return t [c7893817]
- def __html__(self): """ Return the html representation of a string for interoperability. [13a5f3a4]
- def __str__(self): return self [b14c5799]
- return wrapper [656124d6f08b58d6-7]
- """ Functions for working with "safe strings": strings that can be displayed safely without further escaping in HTML. Marking something as a "safe string" means that the producer of the string has already turned characters that should not be interpreted by the HTML engine (e.g. '<') into the appropriate entities. """ [fb5ddd99]
- @keep_lazy(SafeString) def mark_safe(s): """ Explicitly mark a string as safe for (HTML) output purposes. The returned object can be used everywhere a string is appropriate. [8a5c0821]
- SafeText = SafeString # For backwards compatibility since Django 2.0. [06e8980e]
- class SafeData: __slots__ = () [7cb3addf]
- class SafeString(str, SafeData): """ A str subclass that has been specifically marked as "safe" for HTML output purposes. """ [d5f0e45f]
- def _safety_decorator(safety_marker, func): @wraps(func) def wrapper(*args, **kwargs): return safety_marker(func(*args, **kwargs)) [a35fc743]
- from django.utils.functional import keep_lazy [5953725c]
- from functools import wraps [15e8418d]
