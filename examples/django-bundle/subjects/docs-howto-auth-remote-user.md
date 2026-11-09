# docs/howto/auth-remote-user

- Subject: docs/howto/auth-remote-user (id `cb7cc34a-325c-467e-98db-c392644a019e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 18 of 31
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

13 more facts did not fit in the budget: [f770b5dd] [d310c4a5] [6bf893a8] [70092e33] [83f8e215] [86bfd2fb] [8fda4168] [c147c6d6] [0274d6be] [a200776d] [9cf94450] [bd743e76] [85af357f]
