# docs/ref/views

- Subject: docs/ref/views (id `a7ee17b5-b742-4523-96fa-8dbb7fa60cf7`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2100 tokens
- Facts shown: 45 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- # ... the rest of your URLconf goes here ... [746eaecc]
- def edit(request, pk): if not request.user.is_staff: raise PermissionDenied # ... [aadf5fac]
- from django.conf import settings from django.urls import re_path from django.views.static import serve [61ea02e1]
- from django.core.exceptions import PermissionDenied [da7ef1a2]
- if settings.DEBUG: urlpatterns += [ re_path( r"^media/(?P<path>.*)$", serve, { "document_root": settings.MEDIA_ROOT, }, ), ] [7fd7f3de]
- * If :setting:`DEBUG` is set to ``True`` (in your settings module), then your 404 view will never be used, and your URLconf will be displayed instead, with some debug information. [da13f64e]
- * The 404 view is also called if Django doesn't find a match after checking every regular expression in the URLconf. [99cba6c6]
- * The 404 view is passed a :class:`~django.template.RequestContext` and will have access to variables supplied by your template context processors (e.g. ``MEDIA_URL``). [1e6dc8db]
- .. _error-views: [ef7eec01]
- .. _http_bad_request_view: [c4eded7d]
- .. _http_forbidden_view: [9d935dfc]
- .. _http_internal_server_error_view: [77f00b0c]
- .. _http_not_found_view: [b27f488d]
- .. function:: defaults.bad_request(request, exception, template_name='400.html') [8568345c]
- .. function:: defaults.page_not_found(request, exception, template_name='404.html') [2b8774da]
- .. function:: defaults.permission_denied(request, exception, template_name='403.html') [48273900]
- .. function:: defaults.server_error(request, template_name='500.html') [2f738433]
- .. function:: static.serve(request, path, document_root, show_indexes=False) [b90c854d]
- .. module:: django.views :synopsis: Django's built-in views. [7a736201]
- ============== Built-in Views ============== [d45b77cf]
- Django comes with a few views by default for handling HTTP errors. To override these with your own custom views, see :ref:`customizing-error-views`. [7211f3a8]
- Error views =========== [16d3c0bc]
- If :setting:`DEBUG` is set to ``True`` (in your settings module), then your 500 view will never be used, and the traceback will be displayed instead, with some debug information. [60ad25d6]
- In the same vein as the 404 and 500 views, Django has a view to handle 403 Forbidden errors. If a view results in a 403 exception then Django will, by default, call the view ``django.views.defaults.permission_denied``. [13cc2914]
- Note, the snippet assumes your :setting:`MEDIA_URL` has a value of ``'media/'``. This will call the :func:`~django.views.static.serve` view, passing in the path from the URLconf and the (required) ``document_root`` parameter. [578cdb76]
- Serving files in development ============================ [6624129f]
- Similarly, Django has a view to handle 400 Bad Request errors. [2b345e25]

## All facts

- [ea9b56ad] Several of Django's built-in views are documented in :doc:`/topics/http/views` as well as elsewhere in the documentation.
- [20403a74] Similarly, Django executes special-case behavior in the case of runtime errors in view code. If a view results in an exception, Django will, by default, call the view ``django.views.defaults.server_error``, which either produces a "Server Error" message or loads and renders the template ``500.html`` if you created it in your root template directory.
- [9584c0ce] Since it can become a bit cumbersome to define this URL pattern, Django ships with a small URL helper function :func:`~django.conf.urls.static.static` that takes as parameters the prefix such as :setting:`MEDIA_URL` and a dotted path to a view, such as ``'django.views.static.serve'``. Any other function parameter will be transparently passed to the view.
- [8da92b25] The 400 (bad request) view --------------------------
- [b693fb6d] The 403 (HTTP Forbidden) view -----------------------------
- [58a50e01] The 404 (page not found) view -----------------------------
- [b858ae22] The 500 (server error) view ---------------------------
- [18da7362] The default 404 view will pass two variables to the template: ``request_path``, which is the URL that resulted in the error, and ``exception``, which is a useful representation of the exception that triggered the view (e.g. containing any message passed to a specific ``Http404`` instance).
- [08390241] The default 500 view passes no variables to the ``500.html`` template and is rendered with an empty ``Context`` to lessen the chance of additional errors.
- [d7a8a332] The most likely example is user-uploaded content in :setting:`MEDIA_ROOT`. ``django.contrib.staticfiles`` is intended for static assets and has no built-in handling for user-uploaded files, but you can have Django serve your :setting:`MEDIA_ROOT` by appending something like this to your URLconf::
- [98c86272] There may be files other than your project's static assets that, for convenience, you'd like to have Django serve for you in local development. The :func:`~django.views.static.serve` view can be used to serve any directory you give it. (This view is **not** hardened for production use and should be used only as a development aid; you should serve these files in production using a real front-end web server).
- [7edb434b] This view either produces a "Bad Request" message or loads and renders the template ``400.html`` if you created it in your root template directory. It returns with status code 400 indicating that the error condition was the result of a client operation. By default, nothing related to the exception that triggered the view is passed to the template context, as the exception message might contain sensitive information like filesystem paths.
- [54f04407] This view loads and renders the template ``403.html`` in your root template directory, or if this file does not exist, instead serves the text "403 Forbidden", as per :rfc:`9110#section-15.5.4` (the HTTP 1.1 Specification). The template context contains ``exception``, which is the string representation of the exception that triggered the view.
- [fed47cda] Three things to note about 404 views:
- [2c0282b5] When you raise :exc:`~django.http.Http404` from within a view, Django loads a special view devoted to handling 404 errors. By default, it's the view :func:`django.views.defaults.page_not_found`, which either produces a "Not Found" message or loads and renders the template ``404.html`` if you created it in your root template directory.
- [eb890a98] ``bad_request`` views are also only used when :setting:`DEBUG` is ``False``.
- [5f0f9c2d] ``django.views.defaults.bad_request`` is triggered by a :exc:`~django.core.exceptions.BadRequest` exception. Also, when a :exc:`~django.core.exceptions.SuspiciousOperation` is raised in Django, it may be handled by a component of Django (for example resetting the session data). If not specifically handled, Django will consider the current request a 'bad request' instead of a server error, and handle it with ``bad_request``.
- [706771cc] ``django.views.defaults.permission_denied`` is triggered by a :exc:`~django.core.exceptions.PermissionDenied` exception. To deny access in a view you can use code like this::
