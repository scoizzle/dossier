# django/core/mail/utils

- Subject: django/core/mail/utils (id `eecbc244-b92d-4258-9bd1-09a4c0e32ab8`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 177 tokens
- Facts shown: 6 facts
- Conflicts: 0
- Gaps: 0

## Facts

- def get_fqdn(self): if not hasattr(self, "_fqdn"): self._fqdn = punycode(socket.getfqdn()) return self._fqdn [907712f6]
- """ Email message and email sending related helper functions. """ [ec9b3e69]
- # Cache the hostname, but do it lazily: socket.getfqdn() can take a couple of # seconds, which slows down the restart of the server. class CachedDnsName: def __str__(self): return self.get_fqdn() [5e92de6c]
- DNS_NAME = CachedDnsName() [dd38d8d3]
- from django.utils.encoding import punycode [92ee1802]
- import socket [63a09fd79c1eb796]
