# django/views/decorators/clickjacking

- Subject: django/views/decorators/clickjacking (id `9d6681c1-1d55-4343-a0ba-548f681b02e0`)
- Kind: subject
- Budget: 1200 tokens
- Used: 450 tokens
- Facts shown: 14 of 22
- Conflicts: 0
- Gaps: 0

## Facts

- async def _view_wrapper(*args, **kwargs): response = await view_func(*args, **kwargs) if response.get("X-Frame-Options") is None: response["X-Frame-Options"] = "DENY" return response [c6fcacd3]
- async def _view_wrapper(*args, **kwargs): response = await view_func(*args, **kwargs) response.xframe_options_exempt = True return response [ec6e3653]
- def _view_wrapper(*args, **kwargs): response = view_func(*args, **kwargs) if response.get("X-Frame-Options") is None: response["X-Frame-Options"] = "SAMEORIGIN" return response [085bd67d]
- @xframe_options_deny def some_view(request): ... """ [8d430031]
- @xframe_options_exempt def some_view(request): ... """ [62cd154f]
- @xframe_options_sameorigin def some_view(request): ... """ [f2fae547]
- else: [6ad07797f4838346-19]
- else: [6ad07797f4838346-20]
- else: [6ad07797f4838346-21]
- if iscoroutinefunction(view_func): [010008b1ac80cb06-4]
- return wraps(view_func)(_view_wrapper) [87be1c7b56ac3a0b-4]
- def xframe_options_deny(view_func): """ Modify a view function so its response has the X-Frame-Options HTTP header set to 'DENY' as long as the response doesn't already have that header set. Usage: [c6d36b2c]
- def xframe_options_exempt(view_func): """ Modify a view function by setting a response variable that instructs XFrameOptionsMiddleware to NOT set the X-Frame-Options HTTP header. Usage: [ff1b2c19]
- from functools import wraps from inspect import iscoroutinefunction [7391182f29420620-2]
