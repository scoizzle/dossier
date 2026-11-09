# django/core/asgi

- Subject: django/core/asgi (id `82c41fee-cb9d-45b0-8eb4-2afde00fe65e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 121 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- Avoids making django.core.handlers.ASGIHandler a public API, in case the internal implementation changes or moves in the future. """ django.setup(set_prefix=False) return ASGIHandler() [48eae360]
- def get_asgi_application(): """ The public interface to Django's ASGI support. Return an ASGI 3 callable. [fad751b9]
- import django from django.core.handlers.asgi import ASGIHandler [b887bc3e]
