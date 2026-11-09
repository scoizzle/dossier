# docs/ref/csrf

- Subject: docs/ref/csrf (id `1a4969f0-dac1-4e46-b62d-aa97da6d0b9f`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 18 of 61
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

43 more facts did not fit in the budget: [c14e4e3d] [2162bd5d] [80dc045e] [e5e7e1d1] [5b240949] [f04d60a4] [038d6eca] [ac0d12bf] [5182f7df] [e83a2bb4] [1e47c00d] [e76ddcf6] [1f25506e] [ed728020] [d8235ccf] [cb54395a] [20a938c2] [bacd9210] [e19a2613] [007207e3] [90db2cd0] [52ac67a2] [e08d32c7] [b9f44c79] [0cef2b7e7679766a-3] [861e1ef1] [499777fb] [df00d78e] [dc9e63b4] [2d2b8d6e6fcd3452-2] [f17b266a] [f8a186af] [94005583b32250b8-7] [0558e3ee] [e0ff0b38] [1ab46161] [2dc69c7a] [ed7f6126] [c35898d5] [f1849dc6] [eff6587f] [1a5f4831] [e73a147b]
