# docs/howto/auth-remote-user

- Subject: docs/howto/auth-remote-user (id `586d0ec2-547b-4ee4-b556-87224f636e5f`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1912 tokens
- Facts shown: 31 of 31
- Conflicts: 0
- Gaps: 0

## Highlights

- AUTHENTICATION_BACKENDS = [ "django.contrib.auth.backends.RemoteUserBackend", ] [4c587731]
- MIDDLEWARE = [ "...", "django.contrib.auth.middleware.AuthenticationMiddleware", "django.contrib.auth.middleware.RemoteUserMiddleware", "...", ] [e49462f7]
- MIDDLEWARE = [ "...", "django.contrib.auth.middleware.AuthenticationMiddleware", "mysite.middleware.CustomHeaderRemoteUserMiddleware", "...", ] [85c8037e]
- Since the HTTP headers ``X-Auth-User`` and ``X-Auth_User`` (for example) both normalize to the ``HTTP_X_AUTH_USER`` key in ``request.META``, you must also check that your web server doesn't allow a spoofed header using underscores in place of dashes. [80db17c1]
- Since the ``RemoteUserBackend`` inherits from ``ModelBackend``, you will still have all of the same permissions checking that is implemented in ``ModelBackend``. [7043c7ee]
- This warning applies under ASGI in all configurations, because there is no equivalent for a WSGI server's ability to place a trusted value in the environ. ASGI deployments *must* use a reverse proxy as described above when using this middleware. [e32234ad]
- Under WSGI, this warning doesn't apply to ``RemoteUserMiddleware`` in its default configuration with ``header = "REMOTE_USER"``, since a key that doesn't start with ``HTTP_`` in ``request.META`` can only be set by your WSGI server, not directly from an HTTP request header. [54afa2ce]
- Users with :attr:`is_active=False <django.contrib.auth.models.User.is_active>` won't be allowed to authenticate. Use :class:`~django.contrib.auth.backends.AllowAllUsersRemoteUserBackend` if you want to allow them to. [1ad6049e]
- ``RemoteUserMiddleware`` must not be deployed in configurations where a client can supply the header. You must be sure that your web server or reverse proxy always sets or strips that header based on the appropriate authentication checks, never permitting an end user to submit a fake (or "spoofed") header value. [d0e634ac]
- class CustomHeaderRemoteUserMiddleware(RemoteUserMiddleware): header = "HTTP_AUTHUSER" [2750cb63]
- from django.contrib.auth.middleware import RemoteUserMiddleware [c74f21a3]
- .. _mod_authnz_ldap: https://httpd.apache.org/docs/current/mod/mod_authnz_ldap.html .. _CAS: https://www.apereo.org/projects/cas .. _WebAuth: https://uit.stanford.edu/service/authentication .. _mod_auth_sspi: https://sourceforge.net/projects/mod-auth-sspi [7d4958f8]
- .. _persistent-remote-user-middleware-howto: [43bd0e26]
- .. code-block:: python :caption: ``mysite/middleware.py`` [e44c5b5c]
- .. note:: [942ae6c11625c81c]
- .. warning:: [c54b54cb0805732a]
- :class:`~django.contrib.auth.middleware.PersistentRemoteUserMiddleware` provides support for this use case. It will maintain the authenticated session until explicit logout by the user. The class can be used as a drop-in replacement of :class:`~django.contrib.auth.middleware.RemoteUserMiddleware` in the documentation above. [b330b2ed]
- ========================================= How to authenticate using ``REMOTE_USER`` ========================================= [3b1a6e11]

## All facts

- [f770b5dd] Be aware that this particular setup disables authentication with the default ``ModelBackend``. This means that if the ``REMOTE_USER`` value is not set then the user is unable to log in, even using Django's admin interface. Adding ``'django.contrib.auth.backends.ModelBackend'`` to the ``AUTHENTICATION_BACKENDS`` list will use ``ModelBackend`` as a fallback if ``REMOTE_USER`` is absent, which will solve these issues.
- [d310c4a5] Configuration =============
- [6bf893a8] Django's user management, such as the views in ``contrib.admin`` and the :djadmin:`createsuperuser` management command, doesn't integrate with remote users. These interfaces work with users stored in the database regardless of ``AUTHENTICATION_BACKENDS``.
- [70092e33] First, you must add the :class:`django.contrib.auth.middleware.RemoteUserMiddleware` to the :setting:`MIDDLEWARE` setting **after** the :class:`django.contrib.auth.middleware.AuthenticationMiddleware`::
- [83f8e215] If you need more control, you can create your own authentication backend that inherits from :class:`~django.contrib.auth.backends.RemoteUserBackend` and override one or more of its attributes and methods.
- [86bfd2fb] If your authentication mechanism uses a custom HTTP header and not ``REMOTE_USER``, you can subclass ``RemoteUserMiddleware`` and set the ``header`` attribute to the desired ``request.META`` key. For example:
- [8fda4168] Next, you must replace the :class:`~django.contrib.auth.backends.ModelBackend` with :class:`~django.contrib.auth.backends.RemoteUserBackend` in the :setting:`AUTHENTICATION_BACKENDS` setting::
- [c147c6d6] The ``RemoteUserMiddleware`` authentication middleware assumes that the HTTP request header ``REMOTE_USER`` is present with all authenticated requests. That might be expected and practical when Basic HTTP Auth with ``htpasswd`` or similar mechanisms are used, but with Negotiate (GSSAPI/Kerberos) or other resource intensive authentication methods, the authentication in the front-end HTTP server is usually only set up for one or a few login URLs, and after successful authentication, the application is supposed to maintain the authenticated session itself.
- [0274d6be] This custom middleware is then used in the :setting:`MIDDLEWARE` setting instead of :class:`django.contrib.auth.middleware.RemoteUserMiddleware`::
- [a200776d] This document describes how to make use of external authentication sources in your Django applications. This type of authentication solution is typically seen on intranet sites, with single sign-on solutions such as IIS and Integrated Windows Authentication or Apache and `mod_authnz_ldap`_, `CAS`_, `WebAuth`_, `mod_auth_sspi`_, etc.
- [9cf94450] Using ``REMOTE_USER`` on login pages only =========================================
- [bd743e76] When the web server takes care of authentication it typically provides the authenticated user as ``REMOTE_USER``. In Django, this value is made available in :attr:`request.META <django.http.HttpRequest.META>` (as ``REMOTE_USER`` when supplied as an environment variable, as in WSGI, or ``HTTP_REMOTE_USER`` when supplied via an HTTP header, as in ASGI). Django can be configured to make use of the ``REMOTE_USER`` value using the ``RemoteUserMiddleware`` or ``PersistentRemoteUserMiddleware``, and :class:`~django.contrib.auth.backends.RemoteUserBackend` classes found in :mod:`django.contrib.auth`.
- [85af357f] With this setup, ``RemoteUserMiddleware`` will detect the username in ``request.META['REMOTE_USER']`` (or ``request.META['HTTP_REMOTE_USER']`` under ASGI) and will authenticate and auto-login that user using the :class:`~django.contrib.auth.backends.RemoteUserBackend`.
