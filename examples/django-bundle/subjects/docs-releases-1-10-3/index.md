# docs/releases/1.10.3

- Subject: docs/releases/1.10.3 (id `a82efe72-20fe-4469-ba1d-28a32821fbf4`)
- Kind: subject
- Budget: 1200 tokens
- Used: 875 tokens
- Facts shown: 18 of 19
- Conflicts: 0
- Gaps: 0

## Facts

- * Added ``model_name`` to the ``allow_migrate()`` calls in ``makemigrations`` (:ticket:`27200`). [8ae382b0]
- * Allowed ``User.is_authenticated`` and ``User.is_anonymous`` properties to be tested for ``set`` membership (:ticket:`27309`). [7836877f]
- * Fixed ``QuerySet.bulk_create()`` on PostgreSQL when the number of objects is a multiple plus one of ``batch_size`` (:ticket:`27385`). [4d03e101]
- * Fixed a performance regression when running ``migrate`` in projects with ``RenameModel`` operations (:ticket:`27279`). [a14a5aa3]
- * Made the ``JavaScriptCatalog`` view respect the ``packages`` argument; previously it was ignored (:ticket:`27374`). [6080e4f4]
- * Prevented ``i18n_patterns()`` from using too much of the URL as the language to fix a use case for ``prefix_default_language=False`` (:ticket:`27063`). [1f89e9c4]
- * Replaced a possibly incorrect redirect from ``SessionMiddleware`` when a session is destroyed in a concurrent request with a ``SuspiciousOperation`` to indicate that the request can't be completed (:ticket:`27363`). [e9b5b370]
- *November 1, 2016* [532b2d77]
- =========================== Django 1.10.3 release notes =========================== [b7aa9949]
- A randomly generated password is now used for each test run. [8ad498be]
- Bugfixes ======== [6c84539cac9c976c-3]
- DNS rebinding vulnerability when ``DEBUG=True`` =============================================== [cc5324b5]
- Django 1.10.3 fixes two security issues and several bugs in 1.10.2. [37622d89]
- Older versions of Django don't validate the ``Host`` header against ``settings.ALLOWED_HOSTS`` when ``settings.DEBUG=True``. This makes them vulnerable to a `DNS rebinding attack <https://benmmurphy.github.io/blog/2016/07/11/rails-webconsole-dns-rebinding/>`__. [302d7009]
- This user is usually dropped after the test suite completes, but not when using the ``manage.py test --keepdb`` option or if the user has an active session (such as an attacker's connection). [199d4a9b]
- User with hardcoded password created when running tests on Oracle ================================================================= [f3e695cb]
- When running tests with an Oracle database, Django creates a temporary database user. In older versions, if a password isn't manually specified in the database settings ``TEST`` dictionary, a hardcoded password is used. This could allow an attacker with network access to the database server to connect. [4c677fd6]
- While Django doesn't ship a module that allows remote code execution, this is at least a cross-site scripting vector, which could be quite serious if developers load a copy of the production database in development or connect to some production services for which there's no development instance, for example. If a project uses a package like the ``django-debug-toolbar``, then the attacker could execute arbitrary SQL, which could be especially bad if the developers connect to the database with a superuser account. [ee14f7e9]

## Beyond the budget

1 more facts did not fit in the budget: [b9b9c5cd]
