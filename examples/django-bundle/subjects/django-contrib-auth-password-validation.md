# django/contrib/auth/password_validation

- Subject: django/contrib/auth/password_validation (id `bff4860d-d58a-4143-8a66-bf3c45b5189c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 11 of 41
- Conflicts: 0
- Gaps: 0

## Facts

- password = password.lower() for attribute_name in self.user_attributes: value = getattr(user, attribute_name, None) if not value or not isinstance(value, str): continue value_lower = value.lower() value_parts = [*re.split(r"\W+", value_lower), value_lower] for value_part in value_parts: if exceeds_maximum_length_ratio( password, self.max_similarity, value_part ): continue if ( SequenceMatcher(a=password, b=value_part).quick_ratio() >= self.max_similarity ): try: verbose_name = str( user._meta.get_field(attribute_name).verbose_name ) except FieldDoesNotExist: verbose_name = attribute_name raise ValidationError( self.get_error_message(), code="password_too_similar", params={"verbose_name": verbose_name}, ) [911b3ee4]
- 1 1.0 10 0.18181818181818182 100 0.019801980198019802 1000 0.001998001998001998 10000 0.00019998000199980003 100000 1.999980000199998e-05 [6c6923fb]
- @cached_property def DEFAULT_PASSWORD_LIST_PATH(self): return Path(__file__).resolve().parent / "common-passwords.txt.gz" [4e5037ff]
- DEFAULT_USER_ATTRIBUTES = ("username", "first_name", "last_name", "email") [e1af7af1]
- If no specific attributes are provided, look at a sensible list of defaults. Attributes that don't exist are ignored. Comparison is made to not only the full attribute value, but also its components, so that, for example, a password is validated against either part of an email address, as well as the full address. """ [8ae6d1ab]
- If the password is valid, return ``None``. If the password is invalid, raise ValidationError with all error messages. """ errors = [] if password_validators is None: password_validators = get_default_password_validators() for validator in password_validators: try: validator.validate(password, user) except ValidationError as error: errors.append(error) if errors: raise ValidationError(errors) [f3fa1b01]
- The following ratio calculations are based on testing SequenceMatcher like this: [c021a150]
- The password is rejected if it occurs in a provided list of passwords, which may be gzipped. The list Django ships with contains 20000 common passwords (unhexed, lowercased and deduplicated), created by Royce Williams: https://gist.github.com/roycewilliams/226886fd01572964e1431ac8afc999ce The password list must be lowercased to match the comparison in validate(). """ [6b3a8669]
- This means a length_ratio of 10 should never yield a similarity higher than 0.2, for 100 this is down to 0.02 and for 1000 it is 0.002. This can be calculated via 2 / length_ratio. As a result we avoid the potentially expensive sequence matching. """ pwd_len = len(password) length_bound_similarity = max_similarity / 2 * pwd_len value_len = len(value) return pwd_len >= 10 * value_len and value_len < length_bound_similarity [eb947467]
- def __init__(self, min_length=8): self.min_length = min_length [2cbc160d]
- def __init__(self, password_list_path=DEFAULT_PASSWORD_LIST_PATH): if password_list_path is CommonPasswordValidator.DEFAULT_PASSWORD_LIST_PATH: password_list_path = self.DEFAULT_PASSWORD_LIST_PATH try: with gzip.open(password_list_path, "rt", encoding="utf-8") as f: self.passwords = {x.strip() for x in f} except OSError: with open(password_list_path) as f: self.passwords = {x.strip() for x in f} [4a2070ca]

## Beyond the budget

30 more facts did not fit in the budget: [8806c72c] [5507be0f] [8ad78692] [0ba1a11f] [9681d3d8] [9a13f1e5] [58ea6785] [4e721cb1] [15db4538] [f420fc57] [eb537905] [b6ff22e1] [1fc8da55] [969bc2c2] [8ceb87ce] [00ba921f] [52eb4f46] [0138c0d3] [db1660ac] [8556c024] [6464d3c2] [ea7a7c7a] [03bbe96d] [b74b5488] [8f2eeaa1] [f3cd0671] [d11c45e5] [9b6a51eb] [62ed5a62] [b2d6c117]
