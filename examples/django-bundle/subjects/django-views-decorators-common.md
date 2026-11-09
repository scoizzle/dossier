# django/views/decorators/common

- Subject: django/views/decorators/common (id `a1bda910-9dce-4c64-884c-e2ff79f12759`)
- Kind: subject
- Budget: 1200 tokens
- Used: 256 tokens
- Facts shown: 9 of 9
- Conflicts: 0
- Gaps: 0

## Facts

- async def _view_wrapper(request, *args, **kwargs): return await view_func(request, *args, **kwargs) [1fbb64cede934edc]
- def _view_wrapper(request, *args, **kwargs): return view_func(request, *args, **kwargs) [d210a50f79cb1683]
- # view_func.should_append_slash = False would also work, but decorators are # nicer if they don't have side effects, so return a new function. [fdbb8f0f]
- _view_wrapper.should_append_slash = False [e86ab4e1]
- else: [6ad07797f4838346-22]
- if iscoroutinefunction(view_func): [010008b1ac80cb06-7]
- return wraps(view_func)(_view_wrapper) [87be1c7b56ac3a0b-7]
- def no_append_slash(view_func): """ Mark a view function as excluded from CommonMiddleware's APPEND_SLASH redirection. """ [619e3c10]
- from functools import wraps from inspect import iscoroutinefunction [7391182f29420620-3]
