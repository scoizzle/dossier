# docs/releases/1.4.11

- Subject: docs/releases/1.4.11 (id `d476ce03-c5cc-447c-aebc-59c3e6ec11d9`)
- Kind: subject
- Budget: 1200 tokens
- Used: 886 tokens
- Facts shown: 16 of 26
- Conflicts: 0
- Gaps: 0

## Facts

- * :class:`~django.db.models.FilePathField` * :class:`~django.db.models.GenericIPAddressField` * ``IPAddressField`` [428ecd0f450d2530]
- *April 21, 2014* [22172556c2fbf3e4]
- 1. If the incoming request did not submit any cookies, and [2ff252688ac07b04]
- 1. One or more views are present which construct a URL based on user input (commonly, a "next" parameter in a querystring indicating where to redirect upon successful completion of an action). [e6bd97c4b7148e19]
- 2. If the response did send one or more cookies, and [0497d8c0109362e8]
- 2. One or more modules are known to an attacker to exist on the server's Python import path, which perform code execution with side effects on importing. [40fe12bcf57a3482]
- 3. If the ``Vary: Cookie`` header is set on the response, then the response will not be cached. [cfc9e00b26ab24b5]
- =========================== Django 1.4.11 release notes =========================== [b46c93cb]
- Additionally, developers of custom model fields are now warned via documentation to ensure their custom field classes will perform appropriate type conversions, and users of the :meth:`raw() <django.db.models.query.QuerySet.raw>` and :meth:`extra() <django.db.models.query.QuerySet.extra>` query methods -- which allow the developer to supply raw SQL or SQL fragments -- will be advised to ensure they perform appropriate manual type conversions prior to executing queries. [ff5daba63c0c813e]
- Caching of anonymous pages could reveal CSRF token ================================================== [74df8d3aaa26840d]
- Django 1.4.11 fixes three security issues in 1.4.10. Additionally, Django's vendored version of six, ``django.utils.six``, has been upgraded to the latest release (1.6.1). [a26ad42c]
- Django also provides a convenience function -- ``reverse()`` -- which performs this process in the opposite direction. The ``reverse()`` function takes information about a view and returns a URL which would invoke that view. Use of ``reverse()`` is encouraged for application developers, as the output of ``reverse()`` is always based on the current URL patterns, meaning developers do not need to change other code when making changes to URLs. [55ef24dc517d2028]
- Django includes both a :doc:`caching framework </topics/cache>` and a system for :doc:`preventing cross-site request forgery (CSRF) attacks </ref/csrf/>`. The CSRF-protection system is based on a random nonce sent to the client in a cookie which must be sent by the client on future requests and, in forms, a hidden value which must be submitted back with the form. [242430719c89bd53]
- Django's URL handling is based on a mapping of regex patterns (representing the URLs) to callable views, and Django's own processing consists of matching a requested URL against those patterns to determine the appropriate view to invoke. [93c97ed4b288d94f]
- Django's model field classes are aware of their own types and most such classes perform explicit conversion of query arguments to the correct database-level type before querying. However, three model field classes did not correctly convert their arguments: [73572540766df636]
- MySQL typecasting ================= [f4763ce29a736800]

## Beyond the budget

10 more facts did not fit in the budget: [2d1926c49ea81c08] [3c93379893fd2596] [42e85ce7bdf784f8] [5a75b830aa1b5602] [1ea9d9a0c480b6d6] [1801a900d754323c] [f74c05bdfbb3f866] [e1842ea5b5ce4e47] [5a2ca07f23bbe305] [a2f642b3c7e9f657]
