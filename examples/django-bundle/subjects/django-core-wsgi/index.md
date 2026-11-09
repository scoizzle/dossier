# django/core/wsgi

- Subject: django/core/wsgi (id `4afde3dc-82ea-4222-ac54-13eeb00d972a`)
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
