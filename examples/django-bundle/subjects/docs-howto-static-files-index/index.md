# docs/howto/static-files/index

- Subject: docs/howto/static-files/index (id `5d4f0ef8-67f1-4355-b7b9-27f641c50053`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2438 tokens
- Facts shown: 58 facts
- Conflicts: 0
- Gaps: 0

## Highlights

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
- This helper function works only in debug mode and only if the given prefix is local (e.g. ``static/``) and not a URL (e.g. ``http://static.example.com/``). [62d111b1]
- This method is **grossly inefficient** and probably **insecure**, so it is **unsuitable for production**. [777f6c0f]
- You can namespace static assets in :setting:`STATICFILES_DIRS` by specifying :ref:`prefixes <staticfiles-dirs-prefixes>`. [4e0e7eda]
- from django.conf import settings from django.conf.urls.static import static [d990b2b04dc10582]
- from django.conf import settings from django.conf.urls.static import static [d990b2b04dc10582-2]
- urlpatterns = [ # ... the rest of your URLconf goes here ... ] + static(settings.MEDIA_URL, document_root=settings.MEDIA_ROOT) [28a320b8d4af4a29]
- urlpatterns = [ # ... the rest of your URLconf goes here ... ] + static(settings.STATIC_URL, document_root=settings.STATIC_ROOT) [563ae384]
- .. _staticfiles-in-templates: [3464bc67]
- .. code-block:: html+django [685d15dfb6eb2285-26]
- .. code-block:: shell [8aa7203c166b13be-20]

## All facts

- [0a426dbc] This will copy all files from your static folders into the :setting:`STATIC_ROOT` directory.
- [b3867cb8] #. In your settings file, define :setting:`STATIC_URL`, for example::
- [00ca6e5b] #. In your templates, use the :ttag:`static` template tag to build the URL for the given relative path using the configured ``staticfiles`` :setting:`STORAGES` alias.
- [10cda8f4] #. Make sure that ``django.contrib.staticfiles`` is included in your :setting:`INSTALLED_APPS`.
- [b949ab48] #. Run the :djadmin:`collectstatic` management command:
- [d6cd888c] #. Set the :setting:`STATIC_ROOT` setting to the directory from which you'd like to serve these files, for example::
- [7241390e] #. Store your static files in a folder called ``static`` in your app. For example ``my_app/static/my_app/example.jpg``.
- [1d89ed00] #. Use a web server of your choice to serve the files. :doc:`/howto/static-files/deployment` covers some common deployment strategies for static files.
- [adac300a] .. _serving-static-files-in-development:
- [da89a732] .. _serving-uploaded-files-in-development:
- [fbf9ab19] .. _staticfiles-testing-support:
- [52c72445] .. admonition:: Serving the files
- [08ae221c1fd71bc8] .. admonition:: Static file namespacing
- [942ae6c11625c81c-10] .. note::
- [942ae6c11625c81c-11] .. note::
- [511873e2] :mod:`django.contrib.staticfiles` provides a convenience management command for gathering static files in a single directory so you can serve them easily.
- [c8edf5a2] ========================================================= How to manage static files (e.g. images, JavaScript, CSS) =========================================================
- [0704805a] Because of this, ``staticfiles`` ships its own :class:`django.contrib.staticfiles.testing.StaticLiveServerTestCase`, a subclass of the built-in one that has the ability to transparently serve all the assets during execution of these tests in a way very similar to what we get at development time with ``DEBUG = True``, i.e. without having to collect them using :djadmin:`collectstatic` first.
- [6b262ad8] Configuring static files ========================
- [abc7004bdb4d6146] Deployment ==========
- [2ab3d38c] During development, you can serve user-uploaded media files from :setting:`MEDIA_ROOT` using the :func:`django.views.static.serve` view.
- [6090efdd] For example, if your :setting:`MEDIA_URL` is defined as ``media/``, you can do this by adding the following snippet to your :setting:`ROOT_URLCONF`::
- [0c1ba5b5] For example, if your :setting:`STATIC_URL` is defined as ``static/``, you can do this by adding the following snippet to your ``urls.py``::
- [a87c7ff0] If you use :mod:`django.contrib.staticfiles` as explained above, :djadmin:`runserver` will do this automatically when :setting:`DEBUG` is set to ``True``. If you don't have ``django.contrib.staticfiles`` in :setting:`INSTALLED_APPS`, you can still manually serve static files using the :func:`django.views.static.serve` view.
- [e4869dfb213f62a5-2] Learn more ==========
- [d1edf6c3] See the documentation for the :setting:`STATICFILES_FINDERS` setting for details on how ``staticfiles`` finds your files.
- [26ade228] Serving files uploaded by a user during development ===================================================
- [d0334a73] Serving static files during development =======================================
- [2a042191630e69fa-2] Testing =======
- [ba9e9bac] This document has covered the basics and some common usage patterns. For complete details on all the settings, commands, template tags, and other pieces included in :mod:`django.contrib.staticfiles`, see :doc:`the staticfiles reference </ref/contrib/staticfiles>`.
- [a0f0f13aa2108a48] This is not suitable for production use! For some common deployment strategies, see :doc:`/howto/static-files/deployment`.
- [a0f0f13aa2108a48-2] This is not suitable for production use! For some common deployment strategies, see :doc:`/howto/static-files/deployment`.
- [2ae91668] This page describes how you can serve these static files.
- [0752ad8a] Websites generally need to serve additional files such as images, JavaScript, or CSS. In Django, we refer to these files as "static files". Django provides :mod:`django.contrib.staticfiles` to help you manage them.
- [92d441e2] When running tests that use actual HTTP requests instead of the built-in testing client (i.e. when using the built-in :class:`LiveServerTestCase <django.test.LiveServerTestCase>`) the static assets need to be served along the rest of the content so the test environment reproduces the real one as faithfully as possible, but ``LiveServerTestCase`` has only very basic static file-serving functionality: It doesn't know about the finders feature of the ``staticfiles`` application and assumes the static content has already been collected under :setting:`STATIC_ROOT`.
- [a86c981f] Your project will probably also have static assets that aren't tied to a particular app. In addition to using a ``static/`` directory inside your apps, you can define a list of directories (:setting:`STATICFILES_DIRS`) in your settings file where Django will also look for static files. For example::
