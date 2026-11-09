# django/contrib/auth/hashers

- Subject: django/contrib/auth/hashers (id `9d2d6851-6487-40cb-b3f3-a68c3c3a3596`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 13 of 97
- Conflicts: 0
- Gaps: 0

## Facts

- Taking PBKDF2 as an example, if `encoded` contains 20000 iterations and `self.iterations` is 30000, this method should run password through another 10000 iterations of PBKDF2. Similar approaches should exist for any hasher that has a work factor. If not, this method should be defined as a no-op to silence the warning. """ warnings.warn( "subclasses of BasePasswordHasher should provide a harden_runtime() method" ) [8817b5fe]
- The result is a dictionary and should contain `algorithm`, `hash`, and `salt`. Extra keys can be algorithm specific like `iterations` or `work_factor`. """ raise NotImplementedError( "subclasses of BasePasswordHasher must provide a decode() method." ) [21662dad]
- The result is a dictionary and will be used where the password field must be displayed to construct a safe representation of the password. """ raise NotImplementedError( "subclasses of BasePasswordHasher must provide a safe_summary() method" ) [e1b82773]
- The result is normally formatted as "algorithm$salt$hash" and must be fewer than 128 characters. """ raise NotImplementedError( "subclasses of BasePasswordHasher must provide an encode() method" ) [b4599799]
- data = bcrypt.hashpw(password, salt) return "%s$%s" % (self.algorithm, data.decode("ascii")) [a364be6a]
- # If the hasher didn't change (we don't protect against enumeration if it # does) and the password should get updated, try to close the timing gap # between the work factor of the current encoded password and the default # work factor. if not is_correct and not hasher_changed and must_update: hasher.harden_runtime(password, encoded) [76bf162d]
- Configured to use PBKDF2 + HMAC + SHA256. The result is a 64 byte binary string. Iterations may be changed safely but you must rename the algorithm if you change SHA256. """ [6b532eda]
- Identify hasher algorithm by examining encoded hash, and call get_hasher() to return hasher. Raise ValueError if algorithm cannot be identified, or if hasher is not loaded. """ # Ancient versions of Django created plain MD5 passwords and accepted # MD5 passwords with an empty salt. if (len(encoded) == 32 and "$" not in encoded) or ( len(encoded) == 37 and encoded.startswith("md5$$") ): algorithm = "unsalted_md5" # Ancient versions of Django accepted SHA1 passwords with an empty salt. elif len(encoded) == 46 and encoded.startswith("sha1$$"): algorithm = "unsalted_sha1" else: algorithm = encoded.split("$", 1)[0] return get_hasher(algorithm) [162986f0]
- If algorithm is 'default', return the default hasher. Lazily import hashers specified in the project's settings file if needed. """ if hasattr(algorithm, "algorithm"): return algorithm [955616b9]
- If setter is specified, it'll be called when you need to regenerate the password. """ is_correct, must_update = verify_password(password, encoded, preferred=preferred) if setter and is_correct and must_update: setter(password) return is_correct [77848dbb]
- PasswordHasher objects are immutable. """ [61eaf4ff]
- This hasher does not first hash the password which means it is subject to bcrypt's 72 bytes password truncation. Most use cases should prefer the BCryptSHA256PasswordHasher. """ [c0900aba]
- algorithm = "bcrypt" digest = None [a626d912]

## Beyond the budget

81 more facts did not fit in the budget: [0b92d468] [c3f1613a] [370df8d3] [956ef050] [af36f246] [27eb72ba] [6140150a] [ba0183a3] [58f3879e] [9e2d7f44] [4c28100e] [07bdc886] [e50c63ea] [e86c523f] [06ee5e89] [7c37ff41] [d502ba43] [15ac0d7b] [4f9b1a29] [2ea7d08d] [26c82c0e] [89a5861f] [690e590c] [f9b83661] [b405e5ac] [01151c76] [501fae13] [823fc936] [0a0875c9] [69d8c6b0] [cac18803] [485ccf84] [609d2a8c] [6a611a54] [b08e6ee6] [b2d2826b] [b7a377d2] [dc0799d3] [410dc74f] [7b69fa5d] [92a0c60c] [9c4a6176] [82f9565a] [9cb44678] [3b7f8b4b] [a63916f3] [fc62b3a1] [62acb7be] [8e0737fe] [938d1a3b] [19852325] [23a6b90a] [e369c85e] [7c5e508b] [6fda8f53] [c583d6f2] [e4820d9a] [315b3d5c] [0ea70081] [360dfc8c] [7a362c4f] [07bc6c2b] [20988745] [516d9373] [cb72db95] [a7db5c83] [3c1c0ea8] [9f4061e3] [e8936018] [6f05b16b] [5cda5da8] [46bc6c14] [83213139] [2a01fb3d] [18be9f1a] [b4db7792] [8773218f] [ae8cf660] [770890ad88958a4c-3] [eb47c1ba] [d6b90987]
