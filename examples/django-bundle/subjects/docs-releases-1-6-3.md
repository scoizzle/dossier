# docs/releases/1.6.3

- Subject: docs/releases/1.6.3 (id `f2367354-6025-4f28-b67c-16ec3369d3c8`)
- Kind: subject
- Budget: 1200 tokens
- Used: 881 tokens
- Facts shown: 23 of 45
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

22 more facts did not fit in the budget: [ff5daba63c0c813e-3] [95230569] [55ef24dc517d2028-3] [242430719c89bd53-3] [93c97ed4b288d94f-3] [73572540766df636-3] [cd400e47] [2d1926c49ea81c08-3] [f4763ce29a736800-3] [3c93379893fd2596-3] [d21cf28614bdc568-3] [42e85ce7bdf784f8-3] [5a75b830aa1b5602-3] [1ea9d9a0c480b6d6-3] [6fa5317f] [2f368af6] [1801a900d754323c-3] [f74c05bdfbb3f866-3] [e1842ea5b5ce4e47-3] [5a2ca07f23bbe305-3] [a2f642b3c7e9f657-3] [bdd8fc50]
