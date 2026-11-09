# docs/releases/1.4.11

- Subject: docs/releases/1.4.11 (id `2536c044-c047-4550-876f-592b89c0f8e1`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1474 tokens
- Facts shown: 26 facts
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [2d1926c49ea81c08] If a query is performed without first converting values to the appropriate type, this can produce unexpected results, similar to what would occur if the query itself had been manipulated.
- [3c93379893fd2596] One argument signature for ``reverse()`` is to pass a dotted Python path to the desired view. In this situation, Django will import the module indicated by that dotted path as part of generating the resulting URL. If such a module has import-time side effects, those side effects will occur.
- [42e85ce7bdf784f8] The MySQL database is known to "typecast" on certain queries; for example, when querying a table which contains string values, but using a query which filters based on an integer value, MySQL will first silently coerce the strings to integers and return a result based on that.
- [5a75b830aa1b5602] The caching framework includes an option to cache responses to anonymous (i.e., unauthenticated) clients.
- [1ea9d9a0c480b6d6] These three fields have been updated to convert their arguments to the correct types before querying.
- [1801a900d754323c] Thus it is possible for an attacker to cause unexpected code execution, given the following conditions:
- [f74c05bdfbb3f866] To remedy this, ``reverse()`` will now only accept and import dotted paths based on the view-containing modules listed in the project's :doc:`URL pattern configuration </topics/http/urls>`, so as to ensure that only modules the developer intended to be imported in this fashion can or will be imported.
- [e1842ea5b5ce4e47] To remedy this, the caching framework will no longer cache such responses. The heuristic for this will be:
- [5a2ca07f23bbe305] Unexpected code execution using ``reverse()`` =============================================
- [a2f642b3c7e9f657] When the first anonymous request to a given page is by a client which did not have a CSRF cookie, the cache framework will also cache the CSRF cookie and serve the same nonce to other anonymous clients who do not have a CSRF cookie. This can allow an attacker to obtain a valid CSRF cookie value and perform attacks which bypass the check for the cookie.
