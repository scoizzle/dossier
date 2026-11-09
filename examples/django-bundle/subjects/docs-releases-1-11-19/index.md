# docs/releases/1.11.19

- Subject: docs/releases/1.11.19 (id `3742f29d-0535-4b63-85e1-8aff867e9d75`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 242 tokens
- Facts shown: 6 facts
- Conflicts: 0
- Gaps: 0

## Facts

- *February 11, 2019* [b4186c8a05b1c7d1]
- ============================ Django 1.11.19 release notes ============================ [e9cc2db4]
- CVE-2019-6975: Memory exhaustion in ``django.utils.numberformat.format()`` -------------------------------------------------------------------------- [4d121585]
- Django 1.11.19 fixes a security issue in 1.11.18. [c023857c]
- If ``django.utils.numberformat.format()`` -- used by ``contrib.admin`` as well as the ``floatformat``, ``filesizeformat``, and ``intcomma`` templates filters -- received a ``Decimal`` with a large number of digits or a large exponent, it could lead to significant memory usage due to a call to ``'{:f}'.format()``. [4d30394a]
- To avoid this, decimals with more than 200 digits are now formatted using scientific notation. [6ab1179c]
