# django/core/wsgi

- Subject: django/core/wsgi (id `1e3c2ee2-57ca-4a64-a162-9d6625190c39`)
- Kind: subject
- Budget: 1200 tokens
- Used: 121 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- Avoids making django.core.handlers.WSGIHandler a public API, in case the internal WSGI implementation changes or moves in the future. """ django.setup(set_prefix=False) return WSGIHandler() [b746c96f]
- def get_wsgi_application(): """ The public interface to Django's WSGI support. Return a WSGI callable. [4c7bf3da]
- import django from django.core.handlers.wsgi import WSGIHandler [c00e26a9]
