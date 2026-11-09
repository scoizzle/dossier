# django/views/decorators/gzip

- Subject: django/views/decorators/gzip (id `3a63c6c5-2789-44c1-bf9d-704f75baf55c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 85 tokens
- Facts shown: 2 of 2
- Conflicts: 0
- Gaps: 0

## Facts

- from django.middleware.gzip import GZipMiddleware from django.utils.decorators import decorator_from_middleware [68e5b829]
- gzip_page = decorator_from_middleware(GZipMiddleware) gzip_page.__doc__ = "Decorator for views that gzips pages if the client supports it." [2d64af1c]
