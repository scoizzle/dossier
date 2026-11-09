# django/contrib/auth/tokens

- Subject: django/contrib/auth/tokens (id `8ff60130-f6cf-4ed0-a894-ac9f7f60eeea`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1111 tokens
- Facts shown: 23 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- # Check that the timestamp/uid has not been tampered with for secret in [self.secret, *self.secret_fallbacks]: if constant_time_compare( self._make_token_with_timestamp(user, ts, secret), token, ): break else: return False [936b1c77]
- # Check the timestamp is within limit. if (self._num_seconds(self._now()) - ts) > settings.PASSWORD_RESET_TIMEOUT: return False [31a1f269]
- Running this data through salted_hmac() prevents password cracking attempts using the reset token, provided the secret isn't compromised. """ # Truncate microseconds so that tokens are consistent even if the # database doesn't support microseconds. login_timestamp = ( "" if user.last_login is None else user.last_login.replace(microsecond=0, tzinfo=None) ) email_field = user.get_email_field_name() email = getattr(user, email_field, "") or "" return f"{user.pk}{user.password}{login_timestamp}{timestamp}{email}" [12298dd9]
- return True [710da0373775b09e]
- try: ts = base36_to_int(ts_b36) except ValueError: return False [6cdacf83]
- def __init__(self): self.algorithm = self.algorithm or "sha256" [85fbb1e2]
- def _get_fallbacks(self): if self._secret_fallbacks is None: return settings.SECRET_KEY_FALLBACKS return self._secret_fallbacks [b56c518b]
- def _get_secret(self): return self._secret or settings.SECRET_KEY [ffb8fb99]
- def _make_hash_value(self, user, timestamp): """ Hash the user's primary key, email (if available), and some user state that's sure to change after a password reset to produce a token that is invalidated when it's used: 1. The password field will change upon a password reset (even if the same password is chosen, due to password salting). 2. The last_login field will usually be updated very shortly after a password reset. Failing those things, settings.PASSWORD_RESET_TIMEOUT eventually invalidates the token. [457d3c9b]
- def _make_token_with_timestamp(self, user, timestamp, secret): # timestamp is number of seconds since 2001-1-1. Converted to base 36, # this gives us a 6 digit string until about 2069. ts_b36 = int_to_base36(timestamp) hash_string = salted_hmac( self.key_salt, self._make_hash_value(user, timestamp), secret=secret, algorithm=self.algorithm, ).hexdigest()[ ::2 ] # Limit to shorten the URL. return "%s-%s" % (ts_b36, hash_string) [081c920e]
- def _now(self): # Used for mocking in tests return datetime.now() [dfc61b08]
- def _num_seconds(self, dt): return int((dt - datetime(2001, 1, 1)).total_seconds()) [d8a97a99]
- def _set_fallbacks(self, fallbacks): self._secret_fallbacks = fallbacks [a56312f2]
- def _set_secret(self, secret): self._secret = secret [1fd75aa2]
- def check_token(self, user, token): """ Check that a password reset token is correct for a given user. """ if not (user and token): return False # Parse the token try: ts_b36, _ = token.split("-") except ValueError: return False [e2ac5866]
- def make_token(self, user): """ Return a token that can be used once to do a password reset for the given user. """ return self._make_token_with_timestamp( user, self._num_seconds(self._now()), self.secret, ) [32443b0d]

## All facts

- [ae05b802] key_salt = "django.contrib.auth.tokens.PasswordResetTokenGenerator" algorithm = None _secret = None _secret_fallbacks = None
- [58ce58bc] secret = property(_get_secret, _set_secret)
- [28f19fdd] secret_fallbacks = property(_get_fallbacks, _set_fallbacks)
- [c8aed348] class PasswordResetTokenGenerator: """ Strategy object used to generate and check tokens for the password reset mechanism. """
- [459f47f4] default_token_generator = PasswordResetTokenGenerator()
- [28da148d] from datetime import datetime
- [e5e9624c] from django.conf import settings from django.utils.crypto import constant_time_compare, salted_hmac from django.utils.http import base36_to_int, int_to_base36
