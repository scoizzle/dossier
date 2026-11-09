# django/core/asgi

- Subject: django/core/asgi (id `5577015a-1e03-4da9-8c4e-674361caf4f8`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 121 tokens
- Facts shown: 3 facts
- Conflicts: 0
- Gaps: 0

## Facts

- Avoids making django.core.handlers.ASGIHandler a public API, in case the internal implementation changes or moves in the future. """ django.setup(set_prefix=False) return ASGIHandler() [48eae360]
- def get_asgi_application(): """ The public interface to Django's ASGI support. Return an ASGI 3 callable. [fad751b9]
- import django from django.core.handlers.asgi import ASGIHandler [b887bc3e]
