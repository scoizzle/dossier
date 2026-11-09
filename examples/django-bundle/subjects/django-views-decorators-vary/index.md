# django/views/decorators/vary

- Subject: django/views/decorators/vary (id `68488b8d-a8f3-4d3a-8b92-3ac1c91d8740`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 371 tokens
- Facts shown: 12 facts
- Conflicts: 0
- Gaps: 0

## Facts

- async def _view_wrapper(request, *args, **kwargs): response = await func(request, *args, **kwargs) patch_vary_headers(response, headers) return response [2626f7bc]
- def _view_wrapper(request, *args, **kwargs): response = func(request, *args, **kwargs) patch_vary_headers(response, headers) return response [217d5db1]
- else: [6ad07797f4838346-28]
- return wraps(func)(_view_wrapper) [ddabdbea]
- @vary_on_headers('Cookie', 'Accept-language') def index(request): ... [43d54ee3]
- Note that the header names are not case-sensitive. """ [7d52001b]
- def decorator(func): if iscoroutinefunction(func): [b9afc59d556f7366-2]
- return decorator [021b5df2d691cbd2-12]
- def vary_on_headers(*headers): """ A view decorator that adds the specified headers to the Vary header of the response. Usage: [e93a89fe]
- from django.utils.cache import patch_vary_headers [d577c679]
- from functools import wraps from inspect import iscoroutinefunction [7391182f29420620-6]
- vary_on_cookie = vary_on_headers("Cookie") vary_on_cookie.__doc__ = ( 'A view decorator that adds "Cookie" to the Vary header of a response. This ' "indicates that a page's contents depends on cookies." ) [9b2ea392]
