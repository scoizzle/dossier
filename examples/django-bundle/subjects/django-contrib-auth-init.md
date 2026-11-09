# django/contrib/auth/__init__

- Subject: django/contrib/auth/__init__ (id `4f6d5fc7-b3f0-4831-aff7-ae574ce54367`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 16 of 48
- Conflicts: 0
- Gaps: 0

## Facts

- async def auser(): return user [0a5160ef]
- request.auser = auser [9551ef64]
- # The credentials supplied are invalid to all backends, fire signal user_login_failed.send( sender=__name__, credentials=_clean_credentials(credentials), request=request ) [8de2244a]
- Not comprehensive - intended for user_login_failed signal """ SENSITIVE_CREDENTIALS = re.compile("api|token|key|secret|password|signature", re.I) CLEANSED_SUBSTITUTE = "********************" for key in credentials: if SENSITIVE_CREDENTIALS.search(key): credentials[key] = CLEANSED_SUBSTITUTE return credentials [60e7402b]
- Take the current request and the updated user object from which the new session hash will be derived and update the session hash appropriately to prevent a password change from logging out the session from which the password was changed. """ request.session.cycle_key() if hasattr(user, "get_session_auth_hash") and request.user == user: request.session[HASH_SESSION_KEY] = user.get_session_auth_hash() [fa4d57f3]
- _set_auth_user(request) [e53c551d1d4d5c6c]
- await request.session.aset(SESSION_KEY, user._meta.pk.value_to_string(user)) await request.session.aset(BACKEND_SESSION_KEY, backend) await request.session.aset(HASH_SESSION_KEY, session_auth_hash) _set_auth_user(request, user) rotate_token(request) await user_logged_in.asend(sender=user.__class__, request=request, user=user) [08e7f5fe]
- backend = _get_backend_from_user(user=user, backend=backend) [322274953f89d623]
- if SESSION_KEY in request.session: if _get_user_session_key(request) != user.pk or ( session_auth_hash and not constant_time_compare( request.session.get(HASH_SESSION_KEY, ""), session_auth_hash ) ): # To avoid reusing another user's session, create a new, empty # session if the existing session corresponds to a different # authenticated user. request.session.flush() else: request.session.cycle_key() [b3199419]
- if await request.session.ahas_key(SESSION_KEY): if await _aget_user_session_key(request) != user.pk or ( session_auth_hash and not constant_time_compare( await request.session.aget(HASH_SESSION_KEY, ""), session_auth_hash, ) ): # To avoid reusing another user's session, create a new, empty # session if the existing session corresponds to a different # authenticated user. await request.session.aflush() else: await request.session.acycle_key() [83fb7d12]
- if hasattr(request, "user"): request.user = user if hasattr(request, "auser"): [cdee1e83]
- if user is None: user = AnonymousUser() [2c52488a]
- request.session[SESSION_KEY] = user._meta.pk.value_to_string(user) request.session[BACKEND_SESSION_KEY] = backend request.session[HASH_SESSION_KEY] = session_auth_hash _set_auth_user(request, user) rotate_token(request) user_logged_in.send(sender=user.__class__, request=request, user=user) [330656f3]
- return user or AnonymousUser() [58ab581662dc428e]
- @sensitive_variables("credentials") def _clean_credentials(credentials): """ Clean a dictionary of credentials of potentially sensitive info before sending to less secure functions. [c5588162]
- async def aget_user(request): """See get_user().""" from .models import AnonymousUser [abd565c5]

## Beyond the budget

27 more facts did not fit in the budget: [a8124339] [0a8f01a5] [1dbafea6] [4cf66660] [25619374] [428c91b0] [71f887a0] [d94c451c] [68dcd1eb] [8883ee1b] [01e2af20] [927d16c4] [f59a49b4] [e28d66ba] [40a0b389] [8fece91f] [b408c974] [9e91677a] [14057937] [f4a1041b] [8a0cdbba] [7f75efc9] [b597bb78] [731242df] [770890ad88958a4c] [1ed5f138] [dae3b101b4aa9562]
