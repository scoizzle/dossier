# django/views/decorators/gzip

- Subject: django/views/decorators/gzip (id `0952270c-afbc-4f46-a5df-0b1a07a6349e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 85 tokens
- Facts shown: 2 of 2
- Conflicts: 0
- Gaps: 0

## Facts

- from django.middleware.gzip import GZipMiddleware from django.utils.decorators import decorator_from_middleware [68e5b829]
- gzip_page = decorator_from_middleware(GZipMiddleware) gzip_page.__doc__ = "Decorator for views that gzips pages if the client supports it." [2d64af1c]
