# django/core/signing

- Subject: django/core/signing (id `0a970554-4055-48cf-b2f3-b5067e5ea7c0`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2667 tokens
- Facts shown: 47 of 48
- Conflicts: 0
- Gaps: 0

## Highlights

- If compress is True (not the default), check if compressing using zlib can save some space. Prepend a '.' to signify compression. This is included in the signature, to protect against zip bombs. [b140da4b7e62362a]
- The serializer is expected to return a bytestring. """ data = serializer().dumps(obj) # Flag for if it's been compressed or not. is_compressed = False [e902ddcd]
- if compress: # Avoid zlib dependency unless compress is being used. compressed = zlib.compress(data) if len(compressed) < (len(data) - 1): data = compressed is_compressed = True base64d = b64_encode(data).decode() if is_compressed: base64d = "." + base64d return self.sign(base64d) [55acf0f7]
- Salt can be used to namespace the hash, so that a signed string is only valid for a given namespace. Leaving this at the default value or re-using a salt value across different parts of your application without good cause is a security risk. [62e67c7c]
- The serializer is expected to accept a bytestring. """ return TimestampSigner( key=key, salt=salt, fallback_keys=fallback_keys ).unsign_object( s, serializer=serializer, max_age=max_age, ) [113c9635]
- The serializer is expected to return a bytestring. """ return TimestampSigner(key=key, salt=salt).sign_object( obj, serializer=serializer, compress=compress ) [6b8013e1]
- def dumps(self, obj): return json.dumps(obj, separators=(",", ":")).encode("latin-1") [8a6d969b]
- def loads(self, data): return json.loads(data.decode("latin-1")) [fe6f6632]
- def sign(self, value): return "%s%s%s" % (value, self.sep, self.signature(value)) [a35e96ee]
- def sign(self, value): value = "%s%s%s" % (value, self.sep, self.timestamp()) return super().sign(value) [2be70a1c]
- def sign_object(self, obj, serializer=JSONSerializer, compress=False): """ Return URL-safe, hmac signed base64 compressed JSON string. [28861541]
- def signature(self, value, key=None): key = key or self.key return base64_hmac(self.salt + "signer", value, key, algorithm=self.algorithm) [e8d26436]
- def unsign(self, signed_value): if self.sep not in signed_value: raise BadSignature('No "%s" found in value' % self.sep) value, sig = signed_value.rsplit(self.sep, 1) for key in [self.key, *self.fallback_keys]: if constant_time_compare(sig, self.signature(value, key)): return value raise BadSignature('Signature "%s" does not match' % sig) [38fccc9d]
- def unsign(self, value, max_age=None): """ Retrieve original value and check it wasn't signed more than max_age seconds ago. """ result = super().unsign(value) value, timestamp = result.rsplit(self.sep, 1) timestamp = b62_decode(timestamp) if max_age is not None: if isinstance(max_age, datetime.timedelta): max_age = max_age.total_seconds() # Check timestamp is not older than max_age age = time.time() - timestamp if age > max_age: raise SignatureExpired("Signature age %s > %s seconds" % (age, max_age)) return value [0ce16cab]
- pass [7655780f0d17b825-40]
- pass [7655780f0d17b825-41]
- """ Functions for creating and restoring url-safe signed JSON objects. [a3de5ce6]
- The format used looks like this: [44e07273]

## All facts

- [ee3b05d7] def unsign_object(self, signed_obj, serializer=JSONSerializer, **kwargs): # Signer.unsign() returns str but base64 and zlib compression operate # on bytes. base64d = self.unsign(signed_obj, **kwargs).encode() decompress = base64d[:1] == b"." if decompress: # It's compressed; uncompress it first. base64d = base64d[1:] data = b64_decode(base64d) if decompress: data = zlib.decompress(data) return serializer().loads(data)
- [6ee36dcc] # RemovedInDjango2028Warning: When the deprecation ends, remove. def _cookie_signer_legacy_salt(cookie_name, salt=""): return cookie_name + salt
- [46f3d578] # RemovedInDjango2028Warning: algorithm="sha256" def base64_hmac(salt, value, key, algorithm=None): if algorithm is None: warnings.warn( "The default argument for algorithm in base64_hmac() will change " "from 'sha1' to 'sha256' in Django 2028. Pass an explicit " "algorithm to silence this warning.", category=RemovedInDjango2028Warning, skip_file_prefixes=django_file_prefixes(), ) algorithm = "sha1" return b64_encode( salted_hmac(salt, value, key, algorithm=algorithm).digest() ).decode()
- [14631711] >>> signing.dumps("hello") 'ImhlbGxvIg:1QaUZC:YIye-ze3TTx7gtSv422nZA4sgmk'
- [84abd5ed] >>> signing.dumps(list(range(1, 20)), compress=True) '.eJwFwcERACAIwLCF-rCiILN47r-GyZVJsNgkxaFxoDgxcOHGxMKD_T7vhAml:1QaUaL:BA0thEZrp4FQVXIXuOvYJtLJSrQ'
- [f2b97d47] >>> signing.loads("ImhlbGxvIg:1QaUZC:YIye-ze3TTx7gtSv422nZA4sgmk") 'hello' >>> signing.loads("ImhlbGxvIg:1QaUZC:YIye-ze3TTx7gtSv42-modified") ... BadSignature: Signature "ImhlbGxvIg:1QaUZC:YIye-ze3TTx7gtSv42-modified" does not match
- [fa737c05] The fact that the string is compressed is signalled by the prefixed '.' at the start of the base64 JSON.
- [fc838985] There are 65 url-safe characters: the 64 used by url-safe base64 and the ':'. These functions make use of all of them. """
- [5233be50] There are two components here, separated by a ':'. The first component is a URLsafe base64 encoded JSON of the object passed to dumps(). The second component is a base64 encoded hmac/SHA-256 hash of "$first_component:$secret"
- [d4e4a351] You can optionally compress the JSON prior to base64 encoding it to save space, using the compress=True argument. This checks if compression actually helps and only applies compression if the result is a shorter string:
- [371b8f4f] _SEP_UNSAFE = _lazy_re_compile(r"^[A-z0-9-_=]*$") BASE62_ALPHABET = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
- [ef837754] class BadSignature(Exception): """Signature does not match."""
- [e337d1cb] class JSONSerializer: """ Simple wrapper around json to be used in signing.dumps and signing.loads. """
- [adadd0c4] class SignatureExpired(BadSignature): """Signature timestamp is older than required max_age."""
- [b826aa74] class Signer: def __init__( self, *, key=None, sep=":", salt=None, algorithm=None, fallback_keys=None ): self.key = key or settings.SECRET_KEY self.fallback_keys = ( fallback_keys if fallback_keys is not None else settings.SECRET_KEY_FALLBACKS ) self.sep = sep self.salt = salt or "%s.%s" % ( self.__class__.__module__, self.__class__.__name__, ) self.algorithm = algorithm or "sha256" if _SEP_UNSAFE.match(self.sep): raise ValueError( "Unsafe Signer separator: %r (cannot be empty or consist of " "only A-z0-9-_=)" % sep, )
- [bdafdd76] class TimestampSigner(Signer): def timestamp(self): return b62_encode(int(time.time()))
- [5fecce13] def _cookie_signer_key(key): # SECRET_KEYS items may be str or bytes. return b"django.http.cookies" + force_bytes(key)
- [34994457] def _cookie_signer_salt(cookie_name, salt=""): # Prefix the salt length so (cookie_name, salt) pairs can't collide. return f"django.http.cookies.v2:{len(salt)}:{salt}{cookie_name}"
- [265ba8cf] def _unsign_cookie(signed_value, *, cookie_name, salt="", max_age=None): try: # RemovedInDjango2028Warning: When the deprecation ends, replace the # whole function body with this single return statement. return get_cookie_signer(salt=_cookie_signer_salt(cookie_name, salt)).unsign( signed_value, max_age=max_age ) except BadSignature as exc: if settings.SIGNED_COOKIE_LEGACY_SALT_FALLBACK and not isinstance( exc, SignatureExpired ): return get_cookie_signer( salt=_cookie_signer_legacy_salt(cookie_name, salt) ).unsign(signed_value, max_age=max_age) raise
- [38bf7151] def b62_decode(s): if s == "0": return 0 sign = 1 if s[0] == "-": s = s[1:] sign = -1 decoded = 0 for digit in s: decoded = decoded * 62 + BASE62_ALPHABET.index(digit) return sign * decoded
- [05e9b956] def b62_encode(s): if s == 0: return "0" sign = "-" if s < 0 else "" s = abs(s) encoded = "" while s > 0: s, remainder = divmod(s, 62) encoded = BASE62_ALPHABET[remainder] + encoded return sign + encoded
- [f7d15732] def b64_decode(s): pad = b"=" * (-len(s) % 4) return base64.urlsafe_b64decode(s + pad)
- [1972813e] def b64_encode(s): return base64.urlsafe_b64encode(s).strip(b"=")
- [aa34cf80] def dumps( obj, key=None, salt="django.core.signing", serializer=JSONSerializer, compress=False ): """ Return URL-safe, hmac signed base64 compressed JSON string. If key is None, use settings.SECRET_KEY instead. The hmac algorithm is the default Signer algorithm.
- [13c555b8] def get_cookie_signer(salt="django.core.signing.get_cookie_signer"): Signer = import_string(settings.SIGNING_BACKEND) return Signer( key=_cookie_signer_key(settings.SECRET_KEY), fallback_keys=map(_cookie_signer_key, settings.SECRET_KEY_FALLBACKS), salt=salt, )
- [3888dbac] def loads( s, key=None, salt="django.core.signing", serializer=JSONSerializer, max_age=None, fallback_keys=None, ): """ Reverse of dumps(), raise BadSignature if signature fails.
- [2ea61141] from django.conf import settings from django.utils.crypto import constant_time_compare, salted_hmac from django.utils.deprecation import RemovedInDjango2028Warning, django_file_prefixes from django.utils.encoding import force_bytes from django.utils.module_loading import import_string from django.utils.regex_helper import _lazy_re_compile
- [4ab24c39] import base64 import datetime import json import time import warnings import zlib
- [657b470c] signing.loads(s) checks the signature and returns the deserialized object. If the signature fails, a BadSignature exception is raised.
