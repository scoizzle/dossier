# docs/howto/static-files/index

- Subject: docs/howto/static-files/index (id `1f2880af-f903-454a-8e69-49ad585936e1`)
- Kind: subject
- Budget: 1200 tokens
- Used: 889 tokens
- Facts shown: 22 of 58
- Conflicts: 0
- Gaps: 0

## Facts

- {% load static %} <img src="{% static 'my_app/example.jpg' %}" alt="My image"> [87c1e90b]
- $ python manage.py collectstatic [bfe5adef]
- STATIC_ROOT = "/var/www/example.com/static/" [da0d67fa]
- STATIC_URL = "static/" [ac4cf897]
- Also this helper function only serves the actual :setting:`STATIC_ROOT` folder; it doesn't perform static files discovery like :mod:`django.contrib.staticfiles`. [f3724659]
- During development, if you use :mod:`django.contrib.staticfiles`, this will be done automatically by :djadmin:`runserver` when :setting:`DEBUG` is set to ``True`` (see :func:`django.contrib.staticfiles.views.serve`). [95bf6eea]
- Finally, static files are served via a wrapper at the WSGI application layer. As a consequence, static files requests do not pass through the normal :doc:`middleware chain </topics/http/middleware>`. [4d300fcc]
- In addition to these configuration steps, you'll also need to actually serve the static files. [9eb553fb]
- Now we *might* be able to get away with putting our static files directly in ``my_app/static/`` (rather than creating another ``my_app`` subdirectory), but it would actually be a bad idea. Django will use the first static file it finds whose name matches, and if you had a static file with the same name in a *different* application, Django would be unable to distinguish between them. We need to be able to point Django at the right one, and the best way to ensure this is by *namespacing* them. That is, by putting those static files inside *another* directory named for the application itself. [ac6e5fe4]
- STATICFILES_DIRS = [ BASE_DIR / "static", "/var/www/static/", ] [f212042c]
- See :doc:`/howto/static-files/deployment` for proper strategies to serve static files in production environments. [fbe19613]
- This helper function works only in debug mode and only if the given prefix is local (e.g. ``media/``) and not a URL (e.g. ``http://media.example.com/``). [f7fa9a72]
- This method is **grossly inefficient** and probably **insecure**, so it is **unsuitable for production**. [777f6c0f]
- You can namespace static assets in :setting:`STATICFILES_DIRS` by specifying :ref:`prefixes <staticfiles-dirs-prefixes>`. [4e0e7eda]
- from django.conf import settings from django.conf.urls.static import static [d990b2b04dc10582]
- urlpatterns = [ # ... the rest of your URLconf goes here ... ] + static(settings.MEDIA_URL, document_root=settings.MEDIA_ROOT) [28a320b8d4af4a29]
- .. _staticfiles-in-templates: [3464bc67]
- .. code-block:: html+django [685d15dfb6eb2285-26]
- .. code-block:: shell [8aa7203c166b13be-20]
- This will copy all files from your static folders into the :setting:`STATIC_ROOT` directory. [0a426dbc]
- #. In your settings file, define :setting:`STATIC_URL`, for example:: [b3867cb8]
- #. In your templates, use the :ttag:`static` template tag to build the URL for the given relative path using the configured ``staticfiles`` :setting:`STORAGES` alias. [00ca6e5b]

## Beyond the budget

32 more facts did not fit in the budget: [10cda8f4] [b949ab48] [d6cd888c] [7241390e] [1d89ed00] [adac300a] [da89a732] [fbf9ab19] [52c72445] [08ae221c1fd71bc8] [942ae6c11625c81c-10] [942ae6c11625c81c-11] [511873e2] [c8edf5a2] [0704805a] [6b262ad8] [abc7004bdb4d6146] [2ab3d38c] [6090efdd] [0c1ba5b5] [a87c7ff0] [e4869dfb213f62a5-2] [d1edf6c3] [26ade228] [d0334a73] [2a042191630e69fa-2] [ba9e9bac] [a0f0f13aa2108a48] [2ae91668] [0752ad8a] [92d441e2] [a86c981f]
