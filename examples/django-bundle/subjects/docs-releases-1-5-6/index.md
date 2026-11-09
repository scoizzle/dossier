# docs/releases/1.5.6

- Subject: docs/releases/1.5.6 (id `764b6f52-4f33-4342-a15d-c9377ff0687f`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 18 of 29
- Conflicts: 0
- Gaps: 0

## Facts

- * :class:`~django.db.models.FilePathField` * :class:`~django.db.models.GenericIPAddressField` * ``IPAddressField`` [428ecd0f450d2530-2]
- * Fixed :class:`~django.contrib.auth.backends.ModelBackend` raising ``UnboundLocalError`` if :func:`~django.contrib.auth.get_user_model` raised an error (#21439). [09cda7e4]
- *April 21, 2014* [22172556c2fbf3e4-2]
- 1. If the incoming request did not submit any cookies, and [2ff252688ac07b04-2]
- 1. One or more views are present which construct a URL based on user input (commonly, a "next" parameter in a querystring indicating where to redirect upon successful completion of an action). [e6bd97c4b7148e19-2]
- 2. If the response did send one or more cookies, and [0497d8c0109362e8-2]
- 2. One or more modules are known to an attacker to exist on the server's Python import path, which perform code execution with side effects on importing. [40fe12bcf57a3482-2]
- 3. If the ``Vary: Cookie`` header is set on the response, then the response will not be cached. [cfc9e00b26ab24b5-2]
- ========================== Django 1.5.6 release notes ========================== [924611dd]
- Additionally, Django's vendored version of six, ``django.utils.six``, has been upgraded to the latest release (1.6.1). [8fd596a0]
- Additionally, developers of custom model fields are now warned via documentation to ensure their custom field classes will perform appropriate type conversions, and users of the :meth:`raw() <django.db.models.query.QuerySet.raw>` and :meth:`extra() <django.db.models.query.QuerySet.extra>` query methods -- which allow the developer to supply raw SQL or SQL fragments -- will be advised to ensure they perform appropriate manual type conversions prior to executing queries. [ff5daba63c0c813e-2]
- Bugfixes ======== [6c84539cac9c976c-42]
- Caching of anonymous pages could reveal CSRF token ================================================== [74df8d3aaa26840d-2]
- Django 1.5.6 fixes several bugs in 1.5.5, including three security issues. [dd5b63a1]
- Django also provides a convenience function -- ``reverse()`` -- which performs this process in the opposite direction. The ``reverse()`` function takes information about a view and returns a URL which would invoke that view. Use of ``reverse()`` is encouraged for application developers, as the output of ``reverse()`` is always based on the current URL patterns, meaning developers do not need to change other code when making changes to URLs. [55ef24dc517d2028-2]
- Django includes both a :doc:`caching framework </topics/cache>` and a system for :doc:`preventing cross-site request forgery (CSRF) attacks </ref/csrf/>`. The CSRF-protection system is based on a random nonce sent to the client in a cookie which must be sent by the client on future requests and, in forms, a hidden value which must be submitted back with the form. [242430719c89bd53-2]
- Django's URL handling is based on a mapping of regex patterns (representing the URLs) to callable views, and Django's own processing consists of matching a requested URL against those patterns to determine the appropriate view to invoke. [93c97ed4b288d94f-2]
- MySQL typecasting ================= [f4763ce29a736800-2]

## Beyond the budget

11 more facts did not fit in the budget: [73572540766df636-2] [2d1926c49ea81c08-2] [3c93379893fd2596-2] [42e85ce7bdf784f8-2] [5a75b830aa1b5602-2] [1ea9d9a0c480b6d6-2] [1801a900d754323c-2] [f74c05bdfbb3f866-2] [e1842ea5b5ce4e47-2] [5a2ca07f23bbe305-2] [a2f642b3c7e9f657-2]
