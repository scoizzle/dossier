# docs/ref/views

- Subject: docs/ref/views (id `f4692145-c70b-4468-9051-a03ad1e0701a`)
- Kind: subject
- Budget: 1200 tokens
- Used: 894 tokens
- Facts shown: 27 of 45
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

18 more facts did not fit in the budget: [ea9b56ad] [20403a74] [9584c0ce] [8da92b25] [b693fb6d] [58a50e01] [b858ae22] [18da7362] [08390241] [d7a8a332] [98c86272] [7edb434b] [54f04407] [fed47cda] [2c0282b5] [eb890a98] [5f0f9c2d] [706771cc]
