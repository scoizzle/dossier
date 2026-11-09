# docs/releases/1.11.2

- Subject: docs/releases/1.11.2 (id `8773f3b4-a87e-49d7-9481-d0cd2b0213f4`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 819 tokens
- Facts shown: 21 of 21
- Conflicts: 0
- Gaps: 0

## Facts

- * Added detection for GDAL 2.1 and 2.0, and removed detection for unsupported versions 1.7 and 1.8 (:ticket:`28181`). [ec0c5b51]
- * Allowed ``DjangoJSONEncoder`` to serialize ``django.utils.deprecation.CallableBool`` (:ticket:`28230`). [2abad275]
- * Changed ``contrib.gis`` to raise ``ImproperlyConfigured`` rather than ``GDALException`` if ``gdal`` isn't installed, to allow third-party apps to catch that exception (:ticket:`28178`). [c11597d9]
- * Corrected detection of GDAL 2.1 on Windows (:ticket:`28181`). [29cda197]
- * Fixed ``MultipleObjectMixin.paginate_queryset()`` crash on Python 2 if the ``InvalidPage`` message contains non-ASCII (:ticket:`28204`). [4b4d9c88]
- * Fixed ``django.contrib.auth.authenticate()`` when multiple authentication backends don't accept a positional ``request`` argument (:ticket:`28207`). [c015b241]
- * Fixed ``django.utils.http.is_safe_url()`` crash on invalid IPv6 URLs (:ticket:`28142`). [42558d0e]
- * Fixed a regression where ``Model._state.adding`` wasn't set correctly on multi-table inheritance parent models after saving a child model (:ticket:`28210`). [78dd1e14]
- * Fixed a regression where ``file_move_safe()`` crashed when moving files to a CIFS mount (:ticket:`28170`). [9aabc81f]
- * Fixed introspection of index field ordering on PostgreSQL (:ticket:`28197`). [5b368e03]
- * Fixed regression causing pickling of model fields to crash (:ticket:`28188`). [fbc01fa9]
- * Made date-based generic views return a 404 rather than crash when given an out of range date (:ticket:`28209`). [72ddc800]
- * Moved the ``ImageField`` file extension validation added in Django 1.11 from the model field to the form field to reallow the use case of storing images without an extension (:ticket:`28242`). [2362a6d8]
- * Prevented ``Subquery`` from adding an unnecessary ``CAST`` which resulted in invalid SQL (:ticket:`28199`). [78de15f8]
- * Relaxed the validation added in Django 1.11 of the fields in the ``defaults`` argument of ``QuerySet.get_or_create()`` and ``update_or_create()`` to reallow settable model properties (:ticket:`28222`). [e1ca2f54]
- *June 1, 2017* [226c156c]
- =========================== Django 1.11.2 release notes =========================== [c680131b]
- Bugfixes ======== [6c84539cac9c976c-15]
- Django 1.11.2 adds a minor feature and fixes several bugs in 1.11.1. Also, the latest string translations from Transifex are incorporated. [435fd679]
- Minor feature ============= [8c1b2107]
- The new ``LiveServerTestCase.port`` attribute reallows the use case of binding to a specific port following the :ref:`bind to port zero <liveservertestcase-port-zero-change>` change in Django 1.11. [3d28f896]
