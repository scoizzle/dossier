# django/utils/asyncio

- Subject: django/utils/asyncio (id `f70b8b9f-8a6d-4ce4-b171-5d45d7c5b18d`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 282 tokens
- Facts shown: 6 facts
- Conflicts: 0
- Gaps: 0

## Facts

- return inner [b9689d746b8236ce-5]
- # If the message is actually a function, then be a no-arguments decorator. if callable(message): func = message message = ( "You cannot call this from an async context - use a thread or " "sync_to_async." ) return decorator(func) else: return decorator [df24c0ce]
- def decorator(func): @wraps(func) def inner(*args, **kwargs): # Detect a running event loop in this thread. try: get_running_loop() except RuntimeError: pass else: if not os.environ.get("DJANGO_ALLOW_ASYNC_UNSAFE"): raise SynchronousOnlyOperation(message) # Pass onward. return func(*args, **kwargs) [b432a2fb]
- def async_unsafe(message): """ Decorator to mark functions as async-unsafe. Someone trying to access the function while in an async context will get an error message. """ [c1951788]
- from django.core.exceptions import SynchronousOnlyOperation [0b27ff48]
- import os from asyncio import get_running_loop from functools import wraps [6126adb2]
