# django/utils/crypto

- Subject: django/utils/crypto (id `af2ad525-fb04-4c39-ae0e-c312effdafad`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 14 of 15
- Conflicts: 0
- Gaps: 0

## Facts

- A different key_salt should be passed in for every application of HMAC. """ if algorithm is None: warnings.warn( "The default argument for algorithm in salted_hmac() will change " "from 'sha1' to 'sha256' in Django 2028. Pass an explicit " "algorithm to silence this warning.", category=RemovedInDjango2028Warning, skip_file_prefixes=django_file_prefixes(), ) algorithm = "sha1" if secret is None: secret = settings.SECRET_KEY [4cfefb5b]
- For example, with default `allowed_chars` (26+26+10), this gives: * length: 12, bit length =~ 71 bits * length: 22, bit length =~ 131 bits """ return "".join(secrets.choice(allowed_chars) for i in range(length)) [4e0f81a5]
- RemovedInDjango2028Warning: The default algorithm will change to SHA256 in Django 2028, so provide an explicit algorithm to silence the warning. [91899a9d]
- The bit length of the returned value can be calculated with the formula: log_2(len(allowed_chars)^length) [cdd4f4a2]
- key_salt = force_bytes(key_salt) secret = force_bytes(secret) try: hasher = getattr(hashlib, algorithm) except AttributeError as e: raise InvalidAlgorithm( "%r is not an algorithm accepted by the hashlib module." % algorithm ) from e # We need to generate a derived key from our base key. We can do this by # passing the key_salt and our base key through a pseudo-random function. key = hasher(key_salt + secret).digest() # If len(key_salt + secret) > block size of the hash algorithm, the above # line is redundant and could be replaced by key = key_salt + secret, since # the hmac module does the same thing for keys longer than the block size. # However, we need to ensure that we *always* do this. return hmac.new(key, msg=force_bytes(value), digestmod=hasher) [a6497b3e]
- pass [7655780f0d17b825-54]
- """ Django's standard crypto functions and utilities. """ [97791e65]
- # RemovedInDjango2028Warning: algorithm="sha256" def salted_hmac(key_salt, value, secret=None, *, algorithm=None): """ Return the HMAC of 'value', using a key generated from key_salt and a secret (which defaults to settings.SECRET_KEY). Default algorithm is SHA1, but any algorithm name supported by hashlib can be passed. [e78c86bd]
- RANDOM_STRING_CHARS = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789" [4168326c]
- class InvalidAlgorithm(ValueError): """Algorithm is not supported by hashlib.""" [79313106]
- def constant_time_compare(val1, val2): """Return True if the two strings are equal, False otherwise.""" return secrets.compare_digest(force_bytes(val1), force_bytes(val2)) [f7dc3a7f]
- def get_random_string(length, allowed_chars=RANDOM_STRING_CHARS): """ Return a securely generated random string. [895da275]
- def pbkdf2(password, salt, iterations, dklen=0, digest=None): """Return the hash of password using pbkdf2.""" if digest is None: digest = hashlib.sha256 dklen = dklen or None password = force_bytes(password) salt = force_bytes(salt) return hashlib.pbkdf2_hmac(digest().name, password, salt, iterations, dklen) [86fc0924]
- from django.conf import settings from django.utils.deprecation import RemovedInDjango2028Warning, django_file_prefixes from django.utils.encoding import force_bytes [632cc514]

## Beyond the budget

1 more facts did not fit in the budget: [4522aeff]
