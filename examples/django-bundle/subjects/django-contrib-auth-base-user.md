# django/contrib/auth/base_user

- Subject: django/contrib/auth/base_user (id `d3b62a62-e306-4a14-aa31-a3ef77a3e71e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 23 of 32
- Conflicts: 0
- Gaps: 0

## Facts

- async def setter(raw_password): self.set_password(raw_password) # Password hash upgrades shouldn't be considered password changes. self._password = None await self.asave(update_fields=["password"]) [8ec889fd]
- def setter(raw_password): self.set_password(raw_password) # Password hash upgrades shouldn't be considered password changes. self._password = None self.save(update_fields=["password"]) [7b2e53c5]
- return await acheck_password(raw_password, self.password, setter) [832ec327]
- return check_password(raw_password, self.password, setter) [fcbcf851]
- # Stores the raw password if set_password() is called so that it can # be passed to password_changed() after the model is saved. _password = None [e87de4e6]
- @classmethod def get_email_field_name(cls): try: return cls.EMAIL_FIELD except AttributeError: return "email" [77daf746]
- @classmethod def normalize_username(cls, username): return ( unicodedata.normalize("NFKC", username) if isinstance(username, str) else username ) [f4a8200d]
- @property def is_anonymous(self): """ Always return False. This is a way of comparing User objects to anonymous users. """ return False [37fc4a64]
- @property def is_authenticated(self): """ Always return True. This is a way to tell if the user has been authenticated in templates. """ return True [5fcf397d]
- REQUIRED_FIELDS = [] [ac92c94a]
- async def acheck_password(self, raw_password): """See check_password().""" [3a5d0625]
- async def aget_by_natural_key(self, username): return await self.aget(**{self.model.USERNAME_FIELD: username}) [74594cdd]
- class Meta: abstract = True [62379663e021eaaf]
- def __str__(self): return self.get_username() [27654ee7]
- def _get_session_auth_hash(self, secret=None): key_salt = "django.contrib.auth.models.AbstractBaseUser.get_session_auth_hash" return salted_hmac( key_salt, self.password, secret=secret, algorithm="sha256", ).hexdigest() [65b6935b]
- def check_password(self, raw_password): """ Return a boolean of whether the raw_password was correct. Handles hashing formats behind the scenes. """ [02d01d2f]
- def clean(self): setattr(self, self.USERNAME_FIELD, self.normalize_username(self.get_username())) [c693d95c]
- def get_by_natural_key(self, username): return self.get(**{self.model.USERNAME_FIELD: username}) [50603c94]
- def get_session_auth_fallback_hash(self): for fallback_secret in settings.SECRET_KEY_FALLBACKS: yield self._get_session_auth_hash(secret=fallback_secret) [1ddc7cfd]
- def get_session_auth_hash(self): """ Return an HMAC of the password field. """ return self._get_session_auth_hash() [334e5cbe]
- def get_username(self): """Return the username for this User.""" return getattr(self, self.USERNAME_FIELD) [504a7efd]
- def has_usable_password(self): """ Return False if set_unusable_password() has been called for this user. """ return is_password_usable(self.password) [3fe8768c]
- def natural_key(self): return (self.get_username(),) [7b155530]

## Beyond the budget

9 more facts did not fit in the budget: [4821da86] [75edf484] [69b08d4a] [0f463c4c] [fc75cc24] [1f02633c] [c41b1ba8] [d9abb209] [b4033712]
