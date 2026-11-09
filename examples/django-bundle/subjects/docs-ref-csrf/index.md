# docs/ref/csrf

- Subject: docs/ref/csrf (id `88e1ab62-41b5-438e-b568-42162feaa04c`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 3116 tokens
- Facts shown: 61 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- @csrf_exempt def my_view(request): return HttpResponse("Hello world") [abcd16bd]
- @csrf_protect def my_view(request): c = {} # ... return render(request, "a_template.html", c) [3cb049c6]
- @requires_csrf_token def my_view(request): c = {} # ... return render(request, "a_template.html", c) [5c86b68a]
- from django.http import HttpResponse from django.views.decorators.csrf import csrf_exempt [699a19ad]
- from django.shortcuts import render from django.views.decorators.csrf import csrf_protect [ad704950]
- from django.shortcuts import render from django.views.decorators.csrf import requires_csrf_token [60ae9ea5]
- Decorator that provides the protection of :class:`~django.middleware.csrf.CsrfViewMiddleware` to a view. [20a515ef]
- Example:: [acfcf117f82fd4c9-39]
- Normally the :ttag:`csrf_token` template tag will not work if ``CsrfViewMiddleware.process_view`` or an equivalent like ``csrf_protect`` has not run. The view decorator ``requires_csrf_token`` can be used to ensure the template tag does work. This decorator works similarly to ``csrf_protect``, but never rejects an incoming request. [83c9a686]
- This decorator forces a view to send the CSRF cookie. [98d21306]
- This decorator marks a view as being exempt from the protection ensured by the middleware. Example:: [0da8e0e0]
- To avoid disclosing the referrer URL to third-party sites, you might want to `disable the referer`_ on your site's ``<a>`` tags. For example, you might use the ``<meta name="referrer" content="no-referrer">`` tag or include the ``Referrer-Policy: no-referrer`` header. Due to the CSRF protection's strict referer checking on HTTPS requests, those techniques cause a CSRF failure on requests with 'unsafe' methods. Instead, use alternatives like ``<a rel="noreferrer" ...>"`` for links to third-party sites. [86cb0023]
- Usage:: [4b552018]
- Expanding the accepted referers beyond the current host or cookie domain can be done with the :setting:`CSRF_TRUSTED_ORIGINS` setting. [75aaf596]
- If the :setting:`CSRF_COOKIE_DOMAIN` setting is set, the referer is compared against it. You can allow cross-subdomain requests by including a leading dot. For example, ``CSRF_COOKIE_DOMAIN = '.example.com'`` will allow POST requests from ``www.example.com`` and ``api.example.com``. If the setting is not set, then the referer must match the HTTP ``Host`` header. [2db8d882]
- In order to protect against `BREACH`_ attacks, the value of this field is not simply the secret. It is scrambled differently with each response using a mask. The mask is generated randomly on every call to ``get_token()``, so the form field value is different each time. [7fdaa16f]
- This also addresses a man-in-the-middle attack that's possible under HTTPS when using a session independent secret, due to the fact that HTTP ``Set-Cookie`` headers are (unfortunately) accepted by clients even when they are talking to a site under HTTPS. (Referer checking is not done for HTTP requests because the presence of the ``Referer`` header isn't reliable enough under HTTP.) [217a0681]
- .. _csrf-limitations: [0040ce5d]

## All facts

- [c14e4e3d] This check is done by ``CsrfViewMiddleware``.
- [2162bd5d] This part is done by the :ttag:`csrf_token` template tag.
- [80dc045e] When validating the 'csrfmiddlewaretoken' field value, only the secret, not the full token, is compared with the secret in the cookie value. This allows the use of ever-changing tokens. While each request may use its own token, the secret remains common to all.
- [e5e7e1d1] ``CsrfViewMiddleware`` sends this cookie with the response whenever ``django.middleware.csrf.get_token()`` is called. It can also send it in other cases. For security reasons, the value of the secret is changed each time a user logs in.
- [5b240949] #. A CSRF cookie that is a random secret value, which other sites will not have access to.
- [f04d60a4] #. A hidden form field with the name 'csrfmiddlewaretoken', present in all outgoing POST forms.
- [038d6eca] #. For all incoming requests that are not using HTTP GET, HEAD, OPTIONS or TRACE, a CSRF cookie must be present, and the 'csrfmiddlewaretoken' field must be present and correct. If it isn't, the user will get a 403 error.
- [ac0d12bf] #. In addition, for HTTPS requests, if the ``Origin`` header isn't provided, ``CsrfViewMiddleware`` performs strict referer checking. This means that even if a subdomain can set or modify cookies on your domain, it can't force a user to post to your application since that request won't come from your own exact domain.
- [5182f7df] #. ``CsrfViewMiddleware`` verifies the `Origin header`_, if provided by the browser, against the current host and the :setting:`CSRF_TRUSTED_ORIGINS` setting. This provides protection against cross-subdomain attacks.
- [e83a2bb4] * :setting:`CSRF_COOKIE_AGE` * :setting:`CSRF_COOKIE_DOMAIN` * :setting:`CSRF_COOKIE_HTTPONLY` * :setting:`CSRF_COOKIE_NAME` * :setting:`CSRF_COOKIE_PATH` * :setting:`CSRF_COOKIE_SAMESITE` * :setting:`CSRF_COOKIE_SECURE` * :setting:`CSRF_FAILURE_VIEW` * :setting:`CSRF_HEADER_NAME` * :setting:`CSRF_TRUSTED_ORIGINS` * :setting:`CSRF_USE_SESSIONS`
- [1e47c00d] .. _BREACH: https://www.breachattack.com/ .. _Origin header: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Origin .. _disable the referer: https://www.w3.org/TR/referrer-policy/#referrer-policy-delivery
- [e76ddcf6] .. _Cross Site Request Forgeries: https://owasp.org/www-community/attacks/csrf#overview
- [1f25506e] .. _how-csrf-works:
- [ed728020] .. admonition:: Removing the ``Referer`` header
- [d8235ccf] .. function:: csrf_exempt(view)
- [cb54395a] .. function:: csrf_protect(view)
- [20a938c2] .. function:: ensure_csrf_cookie(view)
- [bacd9210] .. function:: requires_csrf_token(view)
- [e19a2613] .. module:: django.middleware.csrf :synopsis: Protects against Cross Site Request Forgeries
- [007207e3] .. module:: django.views.decorators.csrf
- [90db2cd0] ===================================== Cross Site Request Forgery protection =====================================
- [52ac67a2] A number of settings can be used to control Django's CSRF behavior:
- [e08d32c7] For security reasons, CSRF tokens are rotated each time a user logs in. Any page with a form generated before a login will have an old, invalid CSRF token and need to be reloaded. This might happen if a user uses the back button after a login or if they log in a different browser tab.
- [b9f44c79] Frequently Asked Questions ==========================
- [0cef2b7e7679766a-3] How it works ============
- [861e1ef1] If you wish to store the CSRF token in the user's session, use the :setting:`CSRF_USE_SESSIONS` setting.
- [499777fb] Is it a problem that Django's CSRF protection isn't linked to a session by default? -----------------------------------------------------------------------------------
- [df00d78e] Is posting an arbitrary CSRF token pair (cookie and POST data) a vulnerability? -------------------------------------------------------------------------------
- [dc9e63b4] It deliberately ignores GET requests (and other requests that are defined as 'safe' by :rfc:`9110#section-9.2.1`). These requests ought never to have any potentially dangerous side effects, and so a CSRF attack with a GET request ought to be harmless. :rfc:`9110#section-9.2.1` defines POST, PUT, and DELETE as 'unsafe', and all other methods are also assumed to be unsafe, for maximum protection.
- [2d2b8d6e6fcd3452-2] Limitations ===========
- [f17b266a] No, this is by design. Not linking CSRF protection to a session allows using the protection on sites such as a *pastebin* that allow submissions from anonymous users which don't have a session.
- [f8a186af] No, this is by design. Without a man-in-the-middle attack, there is no way for an attacker to send a CSRF token cookie to a victim's browser, so a successful attack would need to obtain the victim's browser's cookie via XSS or similar, in which case an attacker usually doesn't need CSRF attacks.
- [94005583b32250b8-7] Settings ========
- [0558e3ee] Some security audit tools flag this as a problem but as mentioned before, an attacker cannot steal a user's browser's CSRF cookie. "Stealing" or modifying *your own* token using Firebug, Chrome dev tools, etc. isn't a vulnerability.
- [e0ff0b38] Subdomains within a site will be able to set cookies on the client for the whole domain. By setting the cookie and using a corresponding token, subdomains will be able to circumvent the CSRF protection. The only way to avoid this is to ensure that subdomains are controlled by trusted users (or, are at least unable to set cookies). Note that even without CSRF, there are other vulnerabilities, such as session fixation, that make giving subdomains to untrusted parties a bad idea, and these vulnerabilities cannot easily be fixed with current browsers.
- [1ab46161] The CSRF middleware and template tag provides easy-to-use protection against `Cross Site Request Forgeries`_. This type of attack occurs when a malicious website contains a link, a form button or some JavaScript that is intended to perform some action on your website, using the credentials of a logged-in user who visits the malicious site in their browser. A related type of attack, 'login CSRF', where an attacking site tricks a user's browser into logging into a site with someone else's credentials, is also covered.
- [2dc69c7a] The CSRF protection cannot protect against man-in-the-middle attacks, so use :ref:`HTTPS <security-recommendation-ssl>` with :ref:`http-strict-transport-security`. It also assumes :ref:`validation of the HOST header <host-headers-virtual-hosting>` and that there aren't any :ref:`cross-site scripting vulnerabilities <cross-site-scripting>` on your site (because XSS vulnerabilities already let an attacker do anything a CSRF vulnerability allows and much worse).
- [ed7f6126] The CSRF protection is based on the following things:
- [c35898d5] The examples below assume you are using function-based views. If you are working with class-based views, you can refer to :ref:`Decorating class-based views<decorating-class-based-views>`.
- [f1849dc6] The first defense against CSRF attacks is to ensure that GET requests (and other 'safe' methods, as defined by :rfc:`9110#section-9.2.1`) are side effect free. Requests via 'unsafe' methods, such as POST, PUT, and DELETE, can then be protected by the steps outlined in :ref:`using-csrf`.
- [eff6587f] This ensures that only forms that have originated from trusted domains can be used to POST data back.
- [1a5f4831] Utilities =========
- [e73a147b] Why might a user encounter a CSRF validation failure after logging in? ----------------------------------------------------------------------
