# django/contrib/auth/middleware

- Subject: django/contrib/auth/middleware (id `255bcea7-fa67-4a26-80d4-b2c3b8e7b69e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 893 tokens
- Facts shown: 16 of 36
- Conflicts: 0
- Gaps: 0

## Facts

- # We are seeing this user for the first time in this session, attempt # to authenticate the user. user = auth.authenticate(request, remote_user=username) if user: # User is valid. Persist the user in the session by logging the # user in. auth.login(request, user) [3c764504]
- if request.user.is_authenticated: return None [91dbf975]
- return redirect_to_login( path, resolved_login_url, self.get_redirect_field_name(view_func), ) [d560f225]
- return self.handle_no_permission(request, view_func) [d1adf993]
- # Name of request.META key to grab username from. Note that for # request headers, normalization to all uppercase and the addition # of a "HTTP_" prefix apply. header = "REMOTE_USER" force_logout_if_no_header = True [51b1f644]
- If authentication is successful, the user is automatically logged in to persist the user in the session. [c485a2bd]
- If request.user is not authenticated, then this middleware attempts to authenticate the username from the ``REMOTE_USER`` key in ``request.META``, an environment variable commonly set by the webserver. [aaa0ef7b]
- Like RemoteUserMiddleware but keeps the user authenticated even if the ``request.META`` key is not found in the request. Useful for setups when the external authentication is only expected to happen on some "logon" URL and the rest of the application wants to use Django's authentication mechanism. """ [8458c499]
- The ``request.META`` key is configurable and defaults to ``REMOTE_USER``. Subclass this class and change the ``header`` attribute if you need to use a different key from ``request.META``, for example a HTTP request header. """ [005350bc]
- Views using the login_not_required decorator will not be redirected. """ [892f3411]
- async def __acall__(self, request): await self.aprocess_request(request) return await self.get_response(request) [d4671ac2]
- async def _aremove_invalid_user(self, request): """ Remove the current authenticated user in the request which is invalid but only if the user is authenticated via the RemoteUserBackend. """ try: stored_backend = load_backend( await request.session.aget(auth.BACKEND_SESSION_KEY, "") ) except ImportError: # Backend failed to load. await auth.alogout(request) else: if isinstance(stored_backend, RemoteUserBackend): await auth.alogout(request) [c6440438]
- async def aclean_username(self, username, request): """See clean_username.""" backend_str = await request.session.aget(auth.BACKEND_SESSION_KEY) backend = auth.load_backend(backend_str) try: username = backend.clean_username(username) except AttributeError: # Backend has no clean_username method. pass return username [2162fdf7]
- def __call__(self, request): if self.is_async: return self.__acall__(request) self.process_request(request) return self.get_response(request) [0b9182d1]
- def __init__(self, get_response): if get_response is None: raise ValueError("get_response must be provided.") self.get_response = get_response self.is_async = iscoroutinefunction(get_response) if self.is_async: markcoroutinefunction(self) super().__init__() [fb20a004]
- force_logout_if_no_header = False [c5066ba7]

## Beyond the budget

18 more facts did not fit in the budget: [37d2db09] [c942b47c] [92d0fec4] [567039b4] [e67f4ec7] [7b3921c4] [89a759c5] [a1a8d1a8] [12350b11] [586136fa] [1235e4ca] [e112dcc7] [18ee6aa8] [4fd606a0] [705176c1] [a81b6007] [759134fa] [4f45ae79]
