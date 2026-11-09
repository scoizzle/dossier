# django/contrib/sessions/backends/base

- Subject: django/contrib/sessions/backends/base (id `97f5d3cd-94d1-4550-9792-aff68ffcf410`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 17 of 92
- Conflicts: 0
- Gaps: 0

## Facts

- If ``value`` is ``None``, the session uses the global session expiry policy. """ if value is None: # Remove any custom expiration for this session. try: del self["_session_expiry"] except KeyError: pass return if isinstance(value, timedelta): value = timezone.now() + value if isinstance(value, datetime): value = value.isoformat() self["_session_expiry"] = value [a26308a0]
- If ``value`` is a ``datetime`` or ``timedelta`` object, the session will expire at that specific future time. [f1631642]
- If ``value`` is an integer, the session will expire after that many seconds of inactivity. If set to ``0`` then the session will expire on browser close. [96e7884a]
- If this operation isn't possible on a given backend, it should raise NotImplementedError. If it isn't necessary, because the backend has a built-in expiration mechanism, it should be a no-op. """ raise NotImplementedError("This backend does not support clear_expired().") [424eeb41]
- Optionally, this function accepts `modification` and `expiry` keyword arguments specifying the modification and expiry of the session. """ try: modification = kwargs["modification"] except KeyError: modification = timezone.now() # Make the difference between "expiry=None passed in kwargs" and # "expiry not passed in kwargs", in order to guarantee not to trigger # self.load() when expiry is provided. try: expiry = kwargs["expiry"] except KeyError: expiry = self.get("_session_expiry") [35eab2ec]
- Optionally, this function accepts `modification` and `expiry` keyword arguments specifying the modification and expiry of the session. """ try: modification = kwargs["modification"] except KeyError: modification = timezone.now() # Same comment as in get_expiry_age try: expiry = kwargs["expiry"] except KeyError: expiry = self.get("_session_expiry") [5280fbcb]
- if isinstance(expiry, datetime): return expiry elif isinstance(expiry, str): return datetime.fromisoformat(expiry) expiry = expiry or self.get_session_cookie_age() return modification + timedelta(seconds=expiry) [e3c39df46d66fb2f]
- if not expiry: # Checks both None and 0 cases return self.get_session_cookie_age() if not isinstance(expiry, (datetime, str)): return expiry if isinstance(expiry, str): expiry = datetime.fromisoformat(expiry) delta = expiry - modification return delta.days * 86400 + delta.seconds [c519ac4a276341b6]
- # Methods that child classes must implement. [c77627da]
- @classmethod async def aclear_expired(cls): return await sync_to_async(cls.clear_expired)() [63102cf4]
- @classmethod def clear_expired(cls): """ Remove expired sessions from the session store. [52cd6455]
- @property def key_salt(self): return "django.contrib.sessions." + self.__class__.__qualname__ [05cfba7e]
- TEST_COOKIE_NAME = "testcookie" TEST_COOKIE_VALUE = "worked" [0f913b04]
- __not_given = object() [0bee4b5d]
- _session = property(_get_session) [c0c35695]
- async def _aget_new_session_key(self): while True: session_key = get_random_string(32, VALID_KEY_CHARS) if not await self.aexists(session_key): return session_key [0ad82628]
- pass [7655780f0d17b825-7]

## Beyond the budget

72 more facts did not fit in the budget: [3734b65a] [abb2fa8a] [d22c2288] [f3ba925f] [1bd58cfa] [7e08cff4] [573f9405] [9c2a62e8] [41d7babe] [b57c357d] [ebaf9d5a] [2a06c53d] [1384ae19] [a3f94d55] [64da46fb] [898021f0] [f57c2cf8] [96958725] [c0b40903] [08133930] [ece72514] [47117fcb] [3f08e75e] [568f97c0] [2f0399e3] [89f1480b] [27bef12b] [2a75a192] [cc22995d] [efa33d92] [62a34bf4] [90125c5b] [2208a19a] [068eedf9] [95ad7b7e] [b9dbefe1] [f3f657be] [d893a8b2] [ba30d3ae] [3512e4fe] [6c21fa34] [0ff7a256] [791b4c17] [3852fc28] [2c10ee41] [5bc19f76] [ea0011f1] [03b263f3] [51fe2057] [fd998569] [cd767483] [bdc25a56] [3933f25d] [30338abc] [de4b4330] [20c053ff] [d06e258c] [626e4b7e] [88ba7f15] [51d7e3d6] [c4c86457] [8b642d22] [82ffc6e3] [7655780f0d17b825-8] [8a194b3d] [0906189e] [e120fffd] [49954475] [59e09243] [770890ad88958a4c-5] [2dc9630f] [f8bcf779]
