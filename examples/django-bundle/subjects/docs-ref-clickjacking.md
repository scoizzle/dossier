# docs/ref/clickjacking

- Subject: docs/ref/clickjacking (id `0ec4fa4e-723a-49d0-ab96-4dd61bbed808`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 24 of 35
- Conflicts: 0
- Gaps: 0

## Facts

- @xframe_options_deny def view_one(request): return HttpResponse("I won't display in any frame!") [27604c72]
- @xframe_options_exempt def ok_to_load_in_a_frame(request): return HttpResponse("This page is safe to load in a frame on any site.") [6f66c2b3]
- @xframe_options_sameorigin def view_two(request): return HttpResponse("Display in a frame if it's from the same origin as me.") [72b9ca96]
- If you want to submit a form or access a session cookie within a frame or iframe, you may need to modify the :setting:`CSRF_COOKIE_SAMESITE` or :setting:`SESSION_COOKIE_SAMESITE` settings. [19744dfd]
- MIDDLEWARE = [ ..., "django.middleware.clickjacking.XFrameOptionsMiddleware", ..., ] [78972d7c]
- X_FRAME_OPTIONS = "SAMEORIGIN" [a9e82e1e]
- from django.http import HttpResponse from django.views.decorators.clickjacking import xframe_options_deny from django.views.decorators.clickjacking import xframe_options_sameorigin [64895657]
- from django.http import HttpResponse from django.views.decorators.clickjacking import xframe_options_exempt [d83040b1]
- #. A middleware that sets the header in all responses. [37acbda9]
- #. A set of view decorators that can be used to override the middleware or to only set the header for certain views. [49361774]
- .. _X-Frame-Options: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-Frame-Options [0358a822]
- .. _clickjacking-prevention: [419b2163]
- .. _clickjacking: https://en.wikipedia.org/wiki/Clickjacking [ae29a7db]
- .. _modern browsers: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-Frame-Options#browser_compatibility [e0c92a4f]
- .. module:: django.middleware.clickjacking :synopsis: Protects against Clickjacking [21ae4f3f]
- .. note:: [942ae6c11625c81c-30]
- ======================== Clickjacking Protection ======================== [cd65810d]
- An example of clickjacking ========================== [e904bf67]
- By default, the middleware will set the ``X-Frame-Options`` header to ``DENY`` for every outgoing ``HttpResponse``. If you want any other value for this header instead, set the :setting:`X_FRAME_OPTIONS` setting:: [9f799701]
- Django provides a few ways to include this header in responses from your site: [24caf01d]
- How to use it ============= [81af3941]
- Limitations =========== [2d2b8d6e6fcd3452]
- Modern browsers honor the `X-Frame-Options`_ HTTP header that indicates whether or not a resource is allowed to load within a frame or iframe. If the response contains the header with a value of ``SAMEORIGIN`` then the browser will only load the resource in a frame if the request originated from the same site. If the header is set to ``DENY`` then the browser will block the resource from loading in a frame no matter which site made the request. [f5c5b014]
- Note that you can use the decorators in conjunction with the middleware. Use of a decorator overrides the middleware. [32fd0de3]

## Beyond the budget

11 more facts did not fit in the budget: [eeb8f4e4] [689e1f3a] [3fbf2efb] [a3aec0ee] [47f9d03e] [ddf17557] [d1b4f25d] [5e0787a7] [f45876f4] [0cbc135b] [2a73e1c6]
