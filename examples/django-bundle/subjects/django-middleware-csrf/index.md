# django/middleware/csrf

- Subject: django/middleware/csrf (id `f8f85ddd-3265-453c-928d-77b17f333d10`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 8 of 54
- Conflicts: 0
- Gaps: 0

## Facts

- # Assume that anything not defined as 'safe' by RFC 9110 needs # protection if request.method in ("GET", "HEAD", "OPTIONS", "TRACE"): return self._accept(request) [fb8d06db]
- # Check non-cookie token for match. request_csrf_token = "" if request.method == "POST": try: request_csrf_token = request.POST.get("csrfmiddlewaretoken", "") except UnreadablePostError: # Handle a broken connection before we've completed reading the # POST data. process_view shouldn't raise any exceptions, so # we'll ignore and serve the user a 403 (assuming they're still # listening, which they probably aren't because of the error). pass [6860d6b9]
- # Ensure that our Referer is also secure. if referer.scheme != "https": raise RejectRequest(REASON_INSECURE_REFERER) [8b7dd27d]
- # Make sure we have a valid URL for Referer. if "" in (referer.scheme, referer.netloc): raise RejectRequest(REASON_MALFORMED_REFERER) [5a375012]
- # Reject the request if the Origin header doesn't match an allowed # value. if "HTTP_ORIGIN" in request.META: if not self._origin_verified(request): return self._reject( request, REASON_BAD_ORIGIN % request.META["HTTP_ORIGIN"] ) elif request.is_secure(): # If the Origin header wasn't provided, reject HTTPS requests if # the Referer header doesn't match an allowed value. # # Suppose user visits http://example.com/ # An active network attacker (man-in-the-middle, MITM) sends a # POST form that targets https://example.com/detonate-bomb/ and # submits it via JavaScript. # # The attacker will need to provide a CSRF cookie and token, but # that's no problem for a MITM and the session-independent secret # we're using. So the MITM can circumvent the CSRF protection. This # is true for any HTTP connection, but anyone using HTTPS expects # better! For this reason, for https://example.com/ we need # additional protection that treats http://example.com/ as # completely untrusted. Under HTTPS, Barth et al. found that the # Referer header is missing for same-domain requests in only about # 0.2% of cases or less, so we can use strict Referer checking. try: self._check_referer(request) except RejectRequest as exc: return self._reject(request, exc.reason) [36d326fa]
- # Wait until request.META["CSRF_COOKIE"] has been manipulated before # bailing out, so that get_token still works if getattr(callback, "csrf_exempt", False): return None [5870f78c]
- If the CSRF_USE_SESSIONS setting is false, raises InvalidTokenFormat if the request's secret has invalid characters or an invalid length. """ if settings.CSRF_USE_SESSIONS: try: csrf_secret = request.session.get(CSRF_SESSION_KEY) except AttributeError: raise ImproperlyConfigured( "CSRF_USE_SESSIONS is enabled, but request.session is not " "set. SessionMiddleware must appear before CsrfViewMiddleware " "in MIDDLEWARE." ) else: try: csrf_secret = request.COOKIES[settings.CSRF_COOKIE_NAME] except KeyError: csrf_secret = None else: # This can raise InvalidTokenFormat. _check_token_format(csrf_secret) if csrf_secret is None: return None # Django versions before 4.0 masked the secret before storing. if len(csrf_secret) == CSRF_TOKEN_LENGTH: csrf_secret = _unmask_cipher_token(csrf_secret) return csrf_secret [9274abbd]
- if not _does_token_match(request_csrf_token, csrf_secret): reason = self._bad_token_message("incorrect", token_source) raise RejectRequest(reason) [c9244e34]

## Beyond the budget

46 more facts did not fit in the budget: [6536d295] [06256983] [5187d38c] [fdb32624] [73100864] [8034aacd88b9c7ae-6] [78219ba2] [c1f8c7b8] [ea8dc69b] [594dec14] [cf38f04d] [081b8d2d] [003b1510] [38741b95] [f836fc4a] [3e12f180] [b5636532] [3e5aaccd] [995ed70a] [a4eee769] [078589ae] [3530d999] [81bb3c10] [bb650223] [3bac5fa2] [d01c1084] [c0c49509] [52ea8ce8] [3ac5e121] [d811da78] [9825a9ea] [fdbcdc1a] [5ede4f3d] [3017946f] [6474cf60] [fb22eaf6] [1a467bb5] [43c6e736] [b9998e8a] [61a68c25] [32a45527] [ca0f830a] [5e2c7e03] [ea069522] [c9ab49f3] [aff66797]
