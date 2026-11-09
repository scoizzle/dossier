# docs/releases/1.4.21

- Subject: docs/releases/1.4.21 (id `7e4341d1-d373-413f-926e-0d8d688e28c8`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 797 tokens
- Facts shown: 11 facts
- Conflicts: 0
- Gaps: 0

## Facts

- *July 8, 2015* [d7f7bc7f]
- :func:`~django.core.validators.validate_ipv4_address`, :func:`~django.core.validators.validate_slug`, and :class:`~django.core.validators.URLValidator` and their usage in the corresponding form fields ``GenericIPAddresseField``, ``IPAddressField``, ``SlugField``, and ``URLField`` are also affected. [f6311fdf]
- =========================== Django 1.4.21 release notes =========================== [ef24a7b5]
- As each built-in session backend was fixed separately (rather than a fix in the core sessions framework), maintainers of third-party session backends should check whether the same vulnerability is present in their backend and correct it if so. [2a6fb642]
- Denial-of-service possibility by filling session store ====================================================== [7516e750]
- Django 1.4.21 fixes several security issues in 1.4.20. [10fde333]
- Header injection possibility since validators accept newlines in input ====================================================================== [4ff040b2]
- In previous versions of Django, the session backends created a new empty record in the session storage anytime ``request.session`` was accessed and there was a session key provided in the request cookies that didn't already have a session record. This could allow an attacker to easily create many new session records simply by sending repeated requests with unknown session keys, potentially filling up the session store or causing other users' session records to be evicted. [7c51e4e3]
- Some of Django's built-in validators (:class:`~django.core.validators.EmailValidator`, most seriously) didn't prohibit newline characters (due to the usage of ``$`` instead of ``\Z`` in the regular expressions). If you use values with newlines in HTTP response or email headers, you can suffer from header injection attacks. Django itself isn't vulnerable because :class:`~django.http.HttpResponse` and the mail sending utilities in :mod:`django.core.mail` prohibit newlines in HTTP and SMTP headers, respectively. While the validators have been fixed in Django, if you're creating HTTP responses or email messages in other ways, it's a good idea to ensure that those methods prohibit newlines as well. You might also want to validate that any existing data in your application doesn't contain unexpected newlines. [e6293241]
- The built-in session backends now create a session record only if the session is actually modified; empty session records are not created. Thus this potential DoS is now only possible if the site chooses to expose a session-modifying view to anonymous users. [647f889c]
- The undocumented, internally unused ``validate_integer()`` function is now stricter as it validates using a regular expression instead of simply casting the value using ``int()`` and checking if an exception was raised. [3aed6700]
