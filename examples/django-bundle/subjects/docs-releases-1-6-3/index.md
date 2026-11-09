# docs/releases/1.6.3

- Subject: docs/releases/1.6.3 (id `601f77e9-f37b-4812-bcea-ef7d40be3817`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2370 tokens
- Facts shown: 45 of 45
- Conflicts: 0
- Gaps: 0

## Highlights

- * :class:`~django.db.models.FilePathField` * :class:`~django.db.models.GenericIPAddressField` * ``IPAddressField`` [428ecd0f450d2530-3]
- * Avoided shadowing deadlock exceptions on MySQL (:ticket:`22291`). [2fee3c0b]
- * Content retrieved from the GeoIP library is now properly decoded from its default ``iso-8859-1`` encoding (:ticket:`21996`). [a0352fdf]
- * Fixed :attr:`ModelAdmin.preserve_filters <django.contrib.admin.ModelAdmin.preserve_filters>` when running a site with a URL prefix (:ticket:`21795`). [c1de9c12]
- * Fixed :djadmin:`changepassword` on Windows (:ticket:`22364`). [6f177f48]
- * Fixed ``AttributeError`` when using :meth:`~django.db.models.query.QuerySet.bulk_create` with ``ForeignObject`` (:ticket:`21566`). [0cb90a5e]
- * Fixed a crash in the ``find_command`` management utility when the ``PATH`` environment variable wasn't set (:ticket:`22256`). [b7e09c40]
- * Fixed a regression in the :mod:`django.contrib.gis` SQL compiler for non-concrete fields (:ticket:`22250`). [f60f332b]
- * Fixed atomicity when closing a database connection or when the database server disconnects (:ticket:`21239` and :ticket:`21202`) [d75bff04]
- * Fixed crash of ``QuerySet``\s that use ``F() + timedelta()`` when their query was compiled more once (:ticket:`21643`). [cdad572c]
- * Fixed regression in ``prefetch_related`` that caused the related objects query to include an unnecessary join (:ticket:`21760`). [c1be3632]
- * Improved :func:`~django.utils.html.strip_tags` accuracy (but it still cannot guarantee an HTML-safe result, as stated in the documentation). [c47c8169]
- * Prevented custom ``widget`` class attribute of :class:`~django.forms.IntegerField` subclasses from being overwritten by the code in their ``__init__`` method (:ticket:`22245`). [6a056133]
- * Wrapped database exceptions in ``_set_autocommit`` (:ticket:`22321`). [7a50167f]
- *April 21, 2014* [22172556c2fbf3e4-3]
- 1. If the incoming request did not submit any cookies, and [2ff252688ac07b04-3]
- 1. One or more views are present which construct a URL based on user input (commonly, a "next" parameter in a querystring indicating where to redirect upon successful completion of an action). [e6bd97c4b7148e19-3]
- 2. If the response did send one or more cookies, and [0497d8c0109362e8-3]
- 2. One or more modules are known to an attacker to exist on the server's Python import path, which perform code execution with side effects on importing. [40fe12bcf57a3482-3]
- 3. If the ``Vary: Cookie`` header is set on the response, then the response will not be cached. [cfc9e00b26ab24b5-3]
- ========================== Django 1.6.3 release notes ========================== [29f551d1]
- Additionally, Django's vendored version of six, ``django.utils.six`` has been upgraded to the latest release (1.6.1). [e12fe67c]
- Caching of anonymous pages could reveal CSRF token ================================================== [74df8d3aaa26840d-3]

## All facts

- [ff5daba63c0c813e-3] Additionally, developers of custom model fields are now warned via documentation to ensure their custom field classes will perform appropriate type conversions, and users of the :meth:`raw() <django.db.models.query.QuerySet.raw>` and :meth:`extra() <django.db.models.query.QuerySet.extra>` query methods -- which allow the developer to supply raw SQL or SQL fragments -- will be advised to ensure they perform appropriate manual type conversions prior to executing queries.
- [95230569] Django 1.6.3 fixes several bugs in 1.6.2, including three security issues, and makes one backwards-incompatible change:
- [55ef24dc517d2028-3] Django also provides a convenience function -- ``reverse()`` -- which performs this process in the opposite direction. The ``reverse()`` function takes information about a view and returns a URL which would invoke that view. Use of ``reverse()`` is encouraged for application developers, as the output of ``reverse()`` is always based on the current URL patterns, meaning developers do not need to change other code when making changes to URLs.
- [242430719c89bd53-3] Django includes both a :doc:`caching framework </topics/cache>` and a system for :doc:`preventing cross-site request forgery (CSRF) attacks </ref/csrf/>`. The CSRF-protection system is based on a random nonce sent to the client in a cookie which must be sent by the client on future requests and, in forms, a hidden value which must be submitted back with the form.
- [93c97ed4b288d94f-3] Django's URL handling is based on a mapping of regex patterns (representing the URLs) to callable views, and Django's own processing consists of matching a requested URL against those patterns to determine the appropriate view to invoke.
- [73572540766df636-3] Django's model field classes are aware of their own types and most such classes perform explicit conversion of query arguments to the correct database-level type before querying. However, three model field classes did not correctly convert their arguments:
- [cd400e47] Historically, queries that use :meth:`~django.db.models.query.QuerySet.select_for_update` could be executed in autocommit mode, outside of a transaction. Before Django 1.6, Django's automatic transactions mode allowed this to be used to lock records until the next write operation. Django 1.6 introduced database-level autocommit; since then, execution in such a context voids the effect of ``select_for_update()``. It is, therefore, assumed now to be an error and raises an exception.
- [2d1926c49ea81c08-3] If a query is performed without first converting values to the appropriate type, this can produce unexpected results, similar to what would occur if the query itself had been manipulated.
- [f4763ce29a736800-3] MySQL typecasting =================
- [3c93379893fd2596-3] One argument signature for ``reverse()`` is to pass a dotted Python path to the desired view. In this situation, Django will import the module indicated by that dotted path as part of generating the resulting URL. If such a module has import-time side effects, those side effects will occur.
- [d21cf28614bdc568-3] Other bugfixes and changes ==========================
- [42e85ce7bdf784f8-3] The MySQL database is known to "typecast" on certain queries; for example, when querying a table which contains string values, but using a query which filters based on an integer value, MySQL will first silently coerce the strings to integers and return a result based on that.
- [5a75b830aa1b5602-3] The caching framework includes an option to cache responses to anonymous (i.e., unauthenticated) clients.
- [1ea9d9a0c480b6d6-3] These three fields have been updated to convert their arguments to the correct types before querying.
- [6fa5317f] This change may cause test failures if you use ``select_for_update()`` in a test class which is a subclass of :class:`~django.test.TransactionTestCase` rather than :class:`~django.test.TestCase`.
- [2f368af6] This change was made because such errors can be caused by including an app which expects global transactions (e.g. :setting:`ATOMIC_REQUESTS <DATABASE-ATOMIC_REQUESTS>` set to ``True``), or Django's old autocommit behavior, in a project which runs without them; and further, such errors may manifest as data-corruption bugs.
- [1801a900d754323c-3] Thus it is possible for an attacker to cause unexpected code execution, given the following conditions:
- [f74c05bdfbb3f866-3] To remedy this, ``reverse()`` will now only accept and import dotted paths based on the view-containing modules listed in the project's :doc:`URL pattern configuration </topics/http/urls>`, so as to ensure that only modules the developer intended to be imported in this fashion can or will be imported.
- [e1842ea5b5ce4e47-3] To remedy this, the caching framework will no longer cache such responses. The heuristic for this will be:
- [5a2ca07f23bbe305-3] Unexpected code execution using ``reverse()`` =============================================
- [a2f642b3c7e9f657-3] When the first anonymous request to a given page is by a client which did not have a CSRF cookie, the cache framework will also cache the CSRF cookie and serve the same nonce to other anonymous clients who do not have a CSRF cookie. This can allow an attacker to obtain a valid CSRF cookie value and perform attacks which bypass the check for the cookie.
- [bdd8fc50] ``select_for_update()`` requires a transaction ==============================================
