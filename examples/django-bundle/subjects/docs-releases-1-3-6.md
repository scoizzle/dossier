# docs/releases/1.3.6

- Subject: docs/releases/1.3.6 (id `4442a594-86b3-47ec-94f7-b496f5bd0874`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 15 of 19
- Conflicts: 0
- Gaps: 0

## Facts

- *February 19, 2013* [2dc7ca58ee5f13d5]
- .. _from the Python security team: https://blog.python.org/2013/02/announcing-defusedxml-fixes-for-xml.html [9fbeea7844186435]
- ========================== Django 1.3.6 release notes ========================== [b795da92]
- Admin history view information leakage ====================================== [7286e68e6b5b8cd8]
- Django 1.3.6 fixes four security issues present in previous Django releases in the 1.3 series. [9b91fdc1]
- Django's XML serializer does not create documents with a DTD, so this should not cause any issues with the typical round-trip from ``dumpdata`` to ``loaddata``, but if you feed your own XML documents to the ``loaddata`` management command, you will need to ensure they do not contain a DTD. [8a964fd27a1e711e]
- For this reason, Django 1.3.6 adds a new setting, ``ALLOWED_HOSTS``, which should contain an explicit list of valid host/domain names for this site. A request with a Host header not matching an entry in this list will raise ``SuspiciousOperation`` if ``request.get_host()`` is called. For full details see the documentation for the :setting:`ALLOWED_HOSTS` setting. [b3a6355e]
- Formset memory exhaustion ========================= [0046549b1d252c17]
- Host header poisoning ===================== [327c5cfb06ab025c-3]
- In Django 1.3.6, all formsets have a strictly-enforced maximum number of forms (1000 by default, though it can be set higher via the ``max_num`` formset factory argument). [9e14f607]
- In previous versions of Django, an admin user without change permission on a model could still view the Unicode representation of instances via their admin history log. Django 1.3.6 now limits the admin history log view for an object to users with change permission for that model. [99356447]
- Previous versions of Django did not validate or limit the form-count data provided by the client in a formset's management form, making it possible to exhaust a server's available memory by forcing it to create very large numbers of forms. [b3d3e50c54416605]
- Some parts of Django -- independent of end-user-written applications -- make use of full URLs, including domain name, which are generated from the HTTP Host header. Django's documentation has for some time contained notes advising users on how to configure web servers to ensure that only valid Host headers can reach the Django application. However, it has been reported to us that even with the recommended web server configurations there are still techniques available for tricking many common web servers into supplying the application with an incorrect and possibly malicious Host header. [41e5a65748f8e85b]
- The XML parser in the Python standard library is vulnerable to a number of attacks via external entities and entity expansion. Django uses this parser for deserializing XML-formatted database fixtures. The fixture deserializer is not intended for use with untrusted data, but in order to err on the side of safety in Django 1.3.6 the XML deserializer refuses to parse an XML document with a DTD (DOCTYPE definition), which closes off these attack avenues. [fb262052]
- This is the sixth bugfix/security release in the Django 1.3 series. [e79be6d5]

## Beyond the budget

4 more facts did not fit in the budget: [27e3521d] [996b6fe372a466bc] [d0878cb6f504b7d6] [30a1cc760b9a67c3]
