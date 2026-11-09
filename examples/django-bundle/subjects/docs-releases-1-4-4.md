# docs/releases/1.4.4

- Subject: docs/releases/1.4.4 (id `fd5bae6b-0075-43d0-9b40-50f66b0d10de`)
- Kind: subject
- Budget: 1200 tokens
- Used: 895 tokens
- Facts shown: 16 of 21
- Conflicts: 0
- Gaps: 0

## Facts

- * Prevented transaction state from leaking from one request to the next (#19707). * Changed an SQL command syntax to be MySQL 4 compatible (#19702). * Added backwards-compatibility with old unsalted MD5 passwords (#18144). * Numerous documentation improvements and fixes. [4a4dacb3]
- *February 19, 2013* [2dc7ca58ee5f13d5-2]
- .. _from the Python security team: https://blog.python.org/2013/02/announcing-defusedxml-fixes-for-xml.html [9fbeea7844186435-2]
- ========================== Django 1.4.4 release notes ========================== [79bc360a]
- Admin history view information leakage ====================================== [7286e68e6b5b8cd8-2]
- Django 1.4.4 fixes four security issues present in previous Django releases in the 1.4 series, as well as several other bugs and numerous documentation improvements. [37e70ffb]
- Django's XML serializer does not create documents with a DTD, so this should not cause any issues with the typical round-trip from ``dumpdata`` to ``loaddata``, but if you feed your own XML documents to the ``loaddata`` management command, you will need to ensure they do not contain a DTD. [8a964fd27a1e711e-2]
- For this reason, Django 1.4.4 adds a new setting, ``ALLOWED_HOSTS``, containing an explicit list of valid host/domain names for this site. A request with a Host header not matching an entry in this list will raise ``SuspiciousOperation`` if ``request.get_host()`` is called. For full details see the documentation for the :setting:`ALLOWED_HOSTS` setting. [d77f3ee7]
- Formset memory exhaustion ========================= [0046549b1d252c17-2]
- Host header poisoning ===================== [327c5cfb06ab025c-6]
- In Django 1.4.4, all formsets have a strictly-enforced maximum number of forms (1000 by default, though it can be set higher via the ``max_num`` formset factory argument). [77fbf419]
- In previous versions of Django, an admin user without change permission on a model could still view the Unicode representation of instances via their admin history log. Django 1.4.4 now limits the admin history log view for an object to users with change permission for that model. [a401b679]
- Other bugfixes and changes ========================== [d21cf28614bdc568-2]
- Previous versions of Django did not validate or limit the form-count data provided by the client in a formset's management form, making it possible to exhaust a server's available memory by forcing it to create very large numbers of forms. [b3d3e50c54416605-2]
- Some parts of Django -- independent of end-user-written applications -- make use of full URLs, including domain name, which are generated from the HTTP Host header. Django's documentation has for some time contained notes advising users on how to configure web servers to ensure that only valid Host headers can reach the Django application. However, it has been reported to us that even with the recommended web server configurations there are still techniques available for tricking many common web servers into supplying the application with an incorrect and possibly malicious Host header. [41e5a65748f8e85b-2]
- This host validation is disabled when ``DEBUG`` is ``True`` or when running tests. [d0878cb6f504b7d6-2]

## Beyond the budget

5 more facts did not fit in the budget: [82c9e1ae] [55428e64] [996b6fe372a466bc-2] [685b0659] [30a1cc760b9a67c3-2]
