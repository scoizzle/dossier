# docs/releases/1.3.4

- Subject: docs/releases/1.3.4 (id `3afad8ff-7cbd-4e62-bd42-303946bc679c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 526 tokens
- Facts shown: 12 of 12
- Conflicts: 0
- Gaps: 0

## Facts

- Host: validsite.com:random@evilsite.com [734a22451cf5909c]
- *October 17, 2012* [7a7a276601f4095f]
- .. _security advisory: https://www.djangoproject.com/weblog/2012/oct/17/security/ [79e651a800ca5dba]
- .. code-block:: text [3a9340cd0d877339-32]
- ========================== Django 1.3.4 release notes ========================== [0f776444]
- Details of this issue were initially posted online as a `security advisory`_. [c21f01515684cd3c]
- Django's own built-in parsing of the Host header is, however, still vulnerable, as was reported to us recently. The Host header parsing in Django 1.3.3 and Django 1.4.1 -- specifically, ``django.http.HttpRequest.get_host()`` -- was incorrectly handling username/password information in the header. Thus, for example, the following Host header would be accepted by Django when running on ``validsite.com``: [8121af85b0ab026d]
- Host header poisoning ===================== [327c5cfb06ab025c]
- Some parts of Django -- independent of end-user-written applications -- make use of full URLs, including domain name, which are generated from the HTTP Host header. Some attacks against this are beyond Django's ability to control, and require the web server to be properly configured; Django's documentation has for some time contained notes advising users on such configuration. [1bc91affd57e5610]
- This is the fourth release in the Django 1.3 series. [dea05039]
- To remedy this, the parsing in ``HttpRequest.get_host()`` is being modified; Host headers which contain potentially dangerous content (such as username/password pairs) now raise the exception :exc:`django.core.exceptions.SuspiciousOperation`. [933eff586b1dcda5]
- Using this, an attacker can cause parts of Django -- particularly the password-reset mechanism -- to generate and display arbitrary URLs to users. [7ef55d112c04218f]
