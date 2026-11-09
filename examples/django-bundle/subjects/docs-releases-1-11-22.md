# docs/releases/1.11.22

- Subject: docs/releases/1.11.22 (id `673dcb15-2423-41de-896f-ae99e3b3223b`)
- Kind: subject
- Budget: 1200 tokens
- Used: 371 tokens
- Facts shown: 7 of 7
- Conflicts: 0
- Gaps: 0

## Facts

- *July 1, 2019* [de1774db]
- ============================ Django 1.11.22 release notes ============================ [8197bcd2]
- CVE-2019-12781: Incorrect HTTP detection with reverse-proxy connecting via HTTPS -------------------------------------------------------------------------------- [4c7742b0]
- Django 1.11.22 fixes a security issue in 1.11.21. [31f3a6bb]
- If you deploy Django behind a reverse-proxy that forwards HTTP requests, and that connects to Django via HTTPS, be sure to verify that your application correctly handles code paths relying on ``scheme``, ``is_secure()``, ``build_absolute_uri()``, and ``SECURE_SSL_REDIRECT``. [c2429585]
- When deployed behind a reverse-proxy connecting to Django via HTTPS, :attr:`django.http.HttpRequest.scheme` would incorrectly detect client requests made via HTTP as using HTTPS. This entails incorrect results for :meth:`~django.http.HttpRequest.is_secure`, and :meth:`~django.http.HttpRequest.build_absolute_uri`, and that HTTP requests would not be redirected to HTTPS in accordance with :setting:`SECURE_SSL_REDIRECT`. [fb1eb09a]
- ``HttpRequest.scheme`` now respects :setting:`SECURE_PROXY_SSL_HEADER`, if it is configured, and the appropriate header is set on the request, for both HTTP and HTTPS requests. [adc8bdc6]
