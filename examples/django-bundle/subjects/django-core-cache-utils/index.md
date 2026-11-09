# django/core/cache/utils

- Subject: django/core/cache/utils (id `91c09e95-45d7-473b-a409-d6f796ba284d`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 138 tokens
- Facts shown: 3 facts
- Conflicts: 0
- Gaps: 0

## Facts

- TEMPLATE_FRAGMENT_KEY_TEMPLATE = "template.cache.%s.%s" [806fca4a]
- def make_template_fragment_key(fragment_name, vary_on=None): hasher = md5(usedforsecurity=False) if vary_on is not None: for arg in vary_on: data = str(arg).encode() # Use the netstring delimiter (with trailing comma). hasher.update(b"%d:%s," % (len(data), data)) return TEMPLATE_FRAGMENT_KEY_TEMPLATE % (fragment_name, hasher.hexdigest()) [fdac6e7d]
- from hashlib import md5 [5f515a75]
