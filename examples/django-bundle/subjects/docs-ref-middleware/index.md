# docs/ref/middleware

- Subject: docs/ref/middleware (id `4853d8e2-34b2-4997-b0cb-63bb5d3d5150`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 22 of 220
- Conflicts: 0
- Gaps: 0

## Facts

- Defaults to 100. Subclass ``GZipMiddleware`` and override the attribute to change the maximum number of random bytes that is included with compressed responses. [8b8eb645]
- Defaults to :class:`~django.http.HttpResponsePermanentRedirect`. Subclass ``CommonMiddleware`` and override the attribute to customize the redirects issued by the middleware. [6bb7a700]
- Defaults to :class:`~django.http.HttpResponseRedirect`. Subclass ``LocaleMiddleware`` and override the attribute to customize the redirects issued by the middleware. [35e71bc2]
- Defaults to ``"next"``. [d2319bf4]
- Returns the URL that unauthenticated requests will be redirected to. This result is either the ``login_url`` set on the :func:`~django.contrib.auth.decorators.login_required` decorator (if not ``None``), or :setting:`settings.LOGIN_URL <LOGIN_URL>`. [0d08d743]
- Returns the name of the query parameter that contains the URL the user should be redirected to after a successful login. This result is either the ``redirect_field_name`` set on the :func:`~.django.contrib.auth.decorators.login_required` decorator (if not ``None``), or :attr:`redirect_field_name`. If ``None`` is returned, a query parameter won't be added. [e87898e6]
- @login_not_required def contact_us(request): ... [12b0c58c]
- from django.contrib.auth.decorators import login_not_required [fa2b3af7]
- .. _BREACH paper (PDF): https://www.breachattack.com/resources/BREACH%20-%20SSL,%20gone%20in%2030%20seconds.pdf .. _breachattack.com: https://www.breachattack.com/ .. _Heal The Breach (HTB) paper: https://ieeexplore.ieee.org/document/9754554 [e6570f37]
- .. attribute:: LocaleMiddleware.response_redirect_class [c4638772]
- .. attribute:: max_random_bytes [88b5dbec]
- .. attribute:: redirect_field_name [e1bf3272]
- .. attribute:: response_redirect_class [0ad12e212f90e1ef-2]
- .. method:: get_login_url() [af7781eb]
- .. method:: get_redirect_field_name() [7f3b7034]
- @login_required(login_url="/books/login/", redirect_field_name="redirect_to") def book_dashboard(request): ... [a2337cff]
- @method_decorator( login_required(login_url="/books/login/", redirect_field_name="redirect_to"), name="dispatch", ) class BookMetrics(View): pass [2bb0606f]
- @no_append_slash def sensitive_fbv(request, *args, **kwargs): """View to be excluded from APPEND_SLASH.""" return HttpResponse() [dca5c8b4]
- Adds protection against Cross Site Request Forgeries by adding hidden form fields to POST forms and checking requests for the correct value. See the :doc:`Cross Site Request Forgery protection documentation </ref/csrf>`. [fe431ef0]
- Adds the ``site`` attribute representing the current site to every incoming ``HttpRequest`` object. See the :ref:`sites documentation <site-middleware>`. [9f0ff32a]
- Adds the ``user`` attribute, representing the currently-logged-in user, to every incoming ``HttpRequest`` object. See :ref:`Authentication in web requests <auth-web-requests>`. [9106c004]
- .. note:: [942ae6c11625c81c-98]

## Beyond the budget

193 more facts did not fit in the budget: [2caa4123] [b0d7fd78] [691d42ff] [5f2b007a] [b6b44dbc] [3049114b] [b2ff8d0e] [05e063a7] [1dd8b268] [5e5734f1] [4f0d59ce] [12164b41] [78e7a3f9] [169b39b9] [916ae661] [3acf5277] [3e152d4f] [e3e3323c] [5df82d00] [0ca3044a] [d18abc64] [ea5fc8ce] [f1d89d85] [bb9752ff] [456b779d820a6878] [5b4370e4] [793d5420] [64a890f830b130f4] [9577ebd5] [ce78c248] [3e5f4e16] [9115a016] [1aa20b70] [da600c3f] [3449d0e4] [899e9359] [b795d950] [a623ad01] [765611f9] [0df7570a] [37eb178977f07107] [4e334a79] [a8a3ec01] [a7b1fc0b] [cdd1a223] [b84cde97] [0ec277dd] [92dfb72e] [46883ab1] [f426ca2e] [d08df0d4] [01ddd54a] [20a79d07] [0f9d96cf] [d265d35c] [28561bdc] [bd3591c6] [a25b9143] [bb774e06] [9f84c7d9] [ce12560e] [a4bf56b4] [60131ba5] [262af2a8] [fc2338ff] [f93fb1da] [14e3dfb8] [88ea926e] [9caf9087] [934ba42d] [1d746dcc] [bff36c35] [fbc9d097] [7a801698] [6435c53c] [928ad60d] [f3067fde] [3f4d90c7] [d58f4d6e] [a6f2829c] [f55b59d2] [88ce1efb] [185044a9] [ff4fe28e] [7c5d3ca6] [b8ebaed9] [1182b12a] [b4370382] [0f0da54f] [4dbda408] [ce4488a3] [152548f7] [99697b76] [78e4e02e] [4722934e] [04e18d22] [43afb917] [97e26bd3] [31dc73dc] [61a90e54] [1b5610f2] [8ab8d301] [a3b51480] [f29b5ea8] [afcc6ec9] [6986d554] [7b08bbfa] [e75524ba] [93c28f6d] [87d6d169] [9a2bd67f] [5fbc1cf5] [5db9b77d] [f092f720] [16b86f76] [a4517d70] [ec0ab113] [695cdf9c] [942ae6c11625c81c-99] [bd38c65d] [121ca6bd] [a1eb26d754a3d60c-23] [c6217ecb] [8af7ea3f] [721995fb] [ecaf743a] [0ddaa6c0] [99fd0a37] [8a6f08da] [ebba9770] [0827dd22] [629c55c0] [b59a455c] [7ae085a2] [6fb50550] [8d74ab31] [59693e87] [186ab046] [32225487] [a60638eb] [468ec4a5] [7b1694fa] [579d0de3] [bdedf02f] [6401ffaa] [47937590] [6776f059] [e67f51be] [88bac804] [77d64747] [76bc96af] [7f763c51] [0ec31932] [3dab500e] [7ceef0ca] [66dfedde] [6f598c83] [74017f20] [86d6168e] [fcc52b8b] [bcbd9015] [b315f589] [a8d6ef85] [90fa3f3f] [f1710398] [27b97a44] [05864eca] [7e7da7d1] [c43c02cd] [7452afec] [a4b9ea77] [050ab909] [74a309dc] [b1cc5a22] [bb5b0200] [e373ade5] [cc1b02a0] [cca4a76b] [5fd73b9b] [34e520f9] [19647582] [ef943a9c] [6dd17c19] [8f5ae69f] [6fe7fcb7] [ecbaced1] [402049ec] [b5ee4364] [88b2c845] [37099dc6] [9a1dd047] [26bbab61] [1157b6a3]
