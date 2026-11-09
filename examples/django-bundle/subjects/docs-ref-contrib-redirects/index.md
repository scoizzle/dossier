# docs/ref/contrib/redirects

- Subject: docs/ref/contrib/redirects (id `b6441acf-6ee2-4015-a2fe-465e77813cef`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1383 tokens
- Facts shown: 30 of 30
- Conflicts: 0
- Gaps: 0

## Highlights

- >>> from django.conf import settings >>> from django.contrib.redirects.models import Redirect >>> # Add a new redirect. >>> redirect = Redirect.objects.create( ... site_id=1, ... old_path="/contact-us/", ... new_path="/contact/", ... ) >>> # Change a redirect. >>> redirect.new_path = "/contact-details/" >>> redirect.save() >>> redirect <Redirect: /contact-us/ ---> /contact-details/> >>> # Delete a redirect. >>> Redirect.objects.filter(site_id=1, old_path="/contact-us/").delete() (1, {'redirects.Redirect': 1}) [9b8b1b6c]
- Defaults to :class:`~django.http.HttpResponseGone`. [462277eb]
- Defaults to :class:`~django.http.HttpResponsePermanentRedirect`. [18e98da1]
- The :class:`~django.http.HttpResponse` class that handles the redirect. [655d4b97]
- The :class:`~django.http.HttpResponse` class used when a :class:`~django.contrib.redirects.models.Redirect` is not found for the requested path or has a blank ``new_path`` value. [b87f25d0]
- .. attribute:: response_gone_class [36efa793]
- .. attribute:: response_redirect_class [0ad12e212f90e1ef]
- .. code-block:: pycon [eaf050be34acb41d-265]
- Redirects are represented by a standard :doc:`Django model </topics/db/models>`, which lives in :source:`django/contrib/redirects/models.py`. You can access redirect objects via the :doc:`Django database API </topics/db/queries>`. For example: [0e5206ca]
- You can change the :class:`~django.http.HttpResponse` classes used by the middleware by creating a subclass of :class:`~django.contrib.redirects.middleware.RedirectFallbackMiddleware` and overriding ``response_gone_class`` and/or ``response_redirect_class``. [ddd4636f]
- #. Ensure that the ``django.contrib.sites`` framework :ref:`is installed <enabling-the-sites-framework>`. #. Add ``'django.contrib.redirects'`` to your :setting:`INSTALLED_APPS` setting. #. Add ``'django.contrib.redirects.middleware.RedirectFallbackMiddleware'`` to your :setting:`MIDDLEWARE` setting. #. Run the command :djadmin:`manage.py migrate <migrate>`. [043a4460]
- * If it finds a match, and ``new_path`` is not empty, it redirects to ``new_path`` using a 301 ("Moved Permanently") redirect. You can subclass :class:`~django.contrib.redirects.middleware.RedirectFallbackMiddleware` and set :attr:`~django.contrib.redirects.middleware.RedirectFallbackMiddleware.response_redirect_class` to :class:`django.http.HttpResponseRedirect` to use a ``302 Moved Temporarily`` redirect instead. * If it finds a match, and ``new_path`` is empty, it sends a 410 ("Gone") HTTP header and empty (content-less) response. * If it doesn't find a match, the request continues to be processed as usual. [d92aace1]
- .. class:: middleware.RedirectFallbackMiddleware [42825632]
- .. class:: models.Redirect [99f604b6]
- .. module:: django.contrib.redirects :synopsis: A framework for managing redirects. [7b608a26]
- ================= The redirects app ================= [21467f86]
- For more on middleware, read the :doc:`middleware docs </topics/http/middleware>`. [8ab77384ea4cc532-2]
- How it works ============ [0cef2b7e7679766a-2]

## All facts

- [545d6e1e] Django comes with an optional redirects application. It lets you store redirects in a database and handles the redirecting for you. It uses the HTTP response status code ``301 Moved Permanently`` by default.
- [bd67740e] How to add, change and delete redirects =======================================
- [3b0fd2d0] If you've activated the automatic Django admin interface, you should see a "Redirects" section on the admin index page. Edit redirects as you edit any other object in the system.
- [8db4d8757db9fb63-4] Installation ============
- [17e39a7d] Middleware ==========
- [65465b93] Note that the order of :setting:`MIDDLEWARE` matters. Generally, you can put :class:`~django.contrib.redirects.middleware.RedirectFallbackMiddleware` at the end of the list, because it's a last resort.
- [e053ebce] The :class:`~django.contrib.redirects.middleware.RedirectFallbackMiddleware` does all of the work. Each time any Django application raises a 404 error, this middleware checks the redirects database for the requested URL as a last resort. Specifically, it checks for a redirect with the given ``old_path`` with a site ID that corresponds to the :setting:`SITE_ID` setting.
- [b8d0e7548b192bff-2] The middleware only gets activated for 404s -- not for 500s or responses of any other status code.
- [d3a10efe] To install the redirects app, follow these steps:
- [4d9c577be104c776-2] Via the Python API ------------------
- [2d26d25ee8ee8de6-2] Via the admin interface -----------------------
- [edf4ab72] ``manage.py migrate`` creates a ``django_redirect`` table in your database. This is a lookup table with ``site_id``, ``old_path`` and ``new_path`` fields.
