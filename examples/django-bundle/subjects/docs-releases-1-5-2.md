# docs/releases/1.5.2

- Subject: docs/releases/1.5.2 (id `3e127c57-1af8-4adf-8aa2-8d60cfce0979`)
- Kind: subject
- Budget: 1200 tokens
- Used: 865 tokens
- Facts shown: 9 of 9
- Conflicts: 0
- Gaps: 0

## Facts

- * Fixed a crash with :meth:`~django.db.models.query.QuerySet.prefetch_related` (#19607) as well as some ``pickle`` regressions with ``prefetch_related`` (#20157 and #20257). * Fixed a regression in :mod:`django.contrib.gis` in the Google Map output on Python 3 (#20773). * Made ``DjangoTestSuiteRunner.setup_databases`` properly handle aliases for the default database (#19940) and prevented ``teardown_databases`` from attempting to tear down aliases (#20681). * Fixed the ``django.core.cache.backends.memcached.MemcachedCache`` backend's ``get_many()`` method on Python 3 (#20722). * Fixed :mod:`django.contrib.humanize` translation syntax errors. Affected languages: Mexican Spanish, Mongolian, Romanian, Turkish (#20695). * Added support for wheel packages (#19252). * The CSRF token now rotates when a user logs in. * Some Python 3 compatibility fixes including #20212 and #20025. * Fixed some rare cases where :meth:`~django.db.models.query.QuerySet.get` exceptions recursed infinitely (#20278). * :djadmin:`makemessages` no longer crashes with ``UnicodeDecodeError`` (#20354). * Fixed ``geojson`` detection with SpatiaLite. * :meth:`~django.test.SimpleTestCase.assertContains` once again works with binary content (#20237). * Fixed :class:`~django.db.models.ManyToManyField` if it has a Unicode ``name`` parameter (#20207). * Ensured that the WSGI request's path is correctly based on the ``SCRIPT_NAME`` environment variable or the :setting:`FORCE_SCRIPT_NAME` setting, regardless of whether or not either has a trailing slash (#20169). * Fixed an obscure bug with the :func:`~django.test.override_settings` decorator. If you hit an ``AttributeError: 'Settings' object has no attribute '_original_allowed_hosts'`` exception, it's probably fixed (#20636). [b301de2d]
- *August 13, 2013* [bd26aac53d00c628-2]
- ========================== Django 1.5.2 release notes ========================== [9998e5d6]
- Bugfixes ======== [6c84539cac9c976c-39]
- Django relies on user input in some cases (e.g. ``django.contrib.auth.views.login()``, ``django.contrib.comments``, and :doc:`i18n </topics/i18n/index>`) to redirect the user to an "on success" URL. The security checks for these redirects (namely ``django.utils.http.is_safe_url()``) didn't check if the scheme is ``http(s)`` and as such allowed ``javascript:...`` URLs to be entered. If a developer relied on ``is_safe_url()`` to provide safe redirect targets and put such a URL into a link, they could suffer from a XSS attack. This bug doesn't affect Django currently, since we only put this URL into the ``Location`` response header and browsers seem to ignore JavaScript there. [4425261a0f33ad28-2]
- If a :class:`~django.db.models.URLField` is used in Django 1.5, it displays the current value of the field and a link to the target on the admin change page. The display routine of this widget was flawed and allowed for XSS. [bbd53cb4]
- Mitigated possible XSS attack via user-supplied redirect URLs ============================================================= [7d730b5e3df549c3-4]
- This is Django 1.5.2, a bugfix and security release for Django 1.5. [763c9c5f]
- XSS vulnerability in :mod:`django.contrib.admin` ================================================ [3827f399]
