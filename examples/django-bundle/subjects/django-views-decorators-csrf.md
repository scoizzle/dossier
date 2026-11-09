# django/views/decorators/csrf

- Subject: django/views/decorators/csrf (id `44411ec0-75b7-4ec1-9257-4c9852be6f7d`)
- Kind: subject
- Budget: 1200 tokens
- Used: 712 tokens
- Facts shown: 16 of 16
- Conflicts: 0
- Gaps: 0

## Facts

- async def _view_wrapper(request, *args, **kwargs): return await view_func(request, *args, **kwargs) [1fbb64cede934edc-2]
- def _view_wrapper(request, *args, **kwargs): return view_func(request, *args, **kwargs) [d210a50f79cb1683-2]
- # view_func.csrf_exempt = True would also work, but decorators are nicer # if they don't have side effects, so return a new function. [35f1affa]
- _view_wrapper.csrf_exempt = True [a39cdcf7]
- def process_view(self, request, callback, callback_args, callback_kwargs): retval = super().process_view(request, callback, callback_args, callback_kwargs) # Force process_response to send the cookie get_token(request) return retval [3a37fcb3]
- else: [6ad07797f4838346-23]
- if iscoroutinefunction(view_func): [010008b1ac80cb06-8]
- return wraps(view_func)(_view_wrapper) [87be1c7b56ac3a0b-8]
- class _EnsureCsrfCookie(CsrfViewMiddleware): def _reject(self, request, reason): return None [31a9a7de]
- class _EnsureCsrfToken(CsrfViewMiddleware): # Behave like CsrfViewMiddleware but don't reject requests or log warnings. def _reject(self, request, reason): return None [b57594b9]
- csrf_protect = decorator_from_middleware(CsrfViewMiddleware) csrf_protect.__name__ = "csrf_protect" csrf_protect.__doc__ = """ This decorator adds CSRF protection in exactly the same way as CsrfViewMiddleware, but it can be used on a per view basis. Using both, or using the decorator multiple times, is harmless and efficient. """ [b17f7a8d]
- def csrf_exempt(view_func): """Mark a view function as being exempt from the CSRF view protection.""" [9e3af72c]
- ensure_csrf_cookie = decorator_from_middleware(_EnsureCsrfCookie) ensure_csrf_cookie.__name__ = "ensure_csrf_cookie" ensure_csrf_cookie.__doc__ = """ Use this decorator to ensure that a view sets a CSRF cookie, whether or not it uses the csrf_token template tag, or the CsrfViewMiddleware is used. """ [a1066fdb]
- from django.middleware.csrf import CsrfViewMiddleware, get_token from django.utils.decorators import decorator_from_middleware [67bbfd73]
- from functools import wraps from inspect import iscoroutinefunction [7391182f29420620-5]
- requires_csrf_token = decorator_from_middleware(_EnsureCsrfToken) requires_csrf_token.__name__ = "requires_csrf_token" requires_csrf_token.__doc__ = """ Use this decorator on views that need a correct csrf_token available to RequestContext, but without the CSRF protection that csrf_protect enforces. """ [3f73b015]
