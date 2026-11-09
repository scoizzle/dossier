# django/core/signing

- Subject: django/core/signing (id `f1cdf6d2-6b89-4aca-9905-ab9ab036cb86`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 18 of 48
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

29 more facts did not fit in the budget: [ee3b05d7] [6ee36dcc] [46f3d578] [14631711] [84abd5ed] [f2b97d47] [fa737c05] [fc838985] [5233be50] [d4e4a351] [371b8f4f] [ef837754] [e337d1cb] [adadd0c4] [b826aa74] [bdafdd76] [5fecce13] [34994457] [265ba8cf] [38bf7151] [05e9b956] [f7d15732] [1972813e] [aa34cf80] [13c555b8] [3888dbac] [2ea61141] [4ab24c39] [657b470c]
