# django/core/validators

- Subject: django/core/validators (id `97ae35b8-e258-4437-a51e-a5d4a7362200`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 12 of 81
- Conflicts: 0
- Gaps: 0

## Facts

- # The maximum length of a full host name is 253 characters per RFC 1034 # section 3.1. It's defined to be 255 bytes or less, but this includes # one byte for the length of the name and one byte for the trailing dot # that's used to indicate absolute names in DNS. if splitted_url.hostname is None or len(splitted_url.hostname) > 253: raise ValidationError(self.message, code=self.code, params={"value": value}) [4e1682a5]
- # Then check full URL try: splitted_url = urlsplit(value) except ValueError: raise ValidationError(self.message, code=self.code, params={"value": value}) super().__call__(value) # Now verify IPv6 in the netloc part host_match = re.search(r"^\[(.+)\](?::[0-9]{1,5})?$", splitted_url.netloc) if host_match: potential_ip = host_match[1] try: validate_ipv6_address(potential_ip) except ValidationError: raise ValidationError( self.message, code=self.code, params={"value": value} ) [cdf8f9e1]
- if domain_part not in self.domain_allowlist and not self.validate_domain_part( domain_part ): raise ValidationError(self.message, code=self.code, params={"value": value}) [b56a402d]
- if not self.user_regex.match(user_part): raise ValidationError(self.message, code=self.code, params={"value": value}) [b3fc2d21]
- if self.max_digits is not None and digits > self.max_digits: raise ValidationError( self.messages["max_digits"], code="max_digits", params={"max": self.max_digits, "value": value}, ) if self.decimal_places is not None and decimals > self.decimal_places: raise ValidationError( self.messages["max_decimal_places"], code="max_decimal_places", params={"max": self.decimal_places, "value": value}, ) if ( self.max_digits is not None and self.decimal_places is not None and whole_digits > (self.max_digits - self.decimal_places) ): raise ValidationError( self.messages["max_whole_digits"], code="max_whole_digits", params={"max": (self.max_digits - self.decimal_places), "value": value}, ) [907f52b0]
- literal_match = self.literal_regex.match(domain_part) if literal_match: ip_address = literal_match[1] try: validate_ipv46_address(ip_address) return True except ValidationError: pass return False [765d020e]
- regex_parts = [ "^", *( (self.hostname_re, self.domain_re, self.tld_re) if self.accept_idna else ( self.ascii_only_hostname_re, self.ascii_only_domain_re, self.ascii_only_tld_re, ) ), r"\Z", ] self.regex = _lazy_re_compile("".join(regex_parts), re.IGNORECASE) super().__init__(**kwargs) [5a466928]
- self.regex = _lazy_re_compile(self.regex, self.flags) [d1b473eb]
- user_part, domain_part = value.rsplit("@", 1) [c9460bff]
- def __call__(self, value): """ Validate that the input contains (or does *not* contain, if inverse_match is True) a match for the regular expression. """ regex_matches = self.regex.search(str(value)) invalid_input = regex_matches if self.inverse_match else not regex_matches if invalid_input: raise ValidationError(self.message, code=self.code, params={"value": value}) [9a1a004d]
- def __call__(self, value): # The maximum length of an email is 320 characters per RFC 3696 # section 3. if not value or "@" not in value or len(value) > 320: raise ValidationError(self.message, code=self.code, params={"value": value}) [194fb811]
- def clean(self, x): return len(x) [6b441737c68e0743]

## Beyond the budget

65 more facts did not fit in the budget: [2a73399b] [915f0149] [83051d94] [1146c861] [e4bb329a] [0bbcc3c2] [fb79e368] [dfe33ea6] [dc052e03] [3c813dd7] [4d7ee822] [afcb6141] [781dd510] [07e6fac0] [eb730818] [aa6b1ace] [0ff70478] [19d2a026] [21ce1691] [cdac3552] [43c07482] [e9dd55c8] [e1a2a310] [55fcb990] [724cb3b220e935ff] [dd866b22] [9a50c45e] [857d66da] [8c14432f] [9349b376] [192bcdfb] [6bacc892] [918694fb] [1cb3f0dc] [71e6017f] [50cd02f3] [6dcb7c70] [7c959022] [d5f1bb0a] [719c51aa] [261646ed] [ccf0aa5a] [5388f999] [8088cc7b] [abe047e7] [f60de750] [34a37b8e] [58fa9dea] [cb7d981d] [ee8e9d34] [5e120233] [67cf8d9f] [f29f824c] [ffe6106f] [44715617] [519ae8d6] [16f6e5e0] [4173cab5] [3a39961a] [8a00552f] [934d60e8] [e93bc80b] [060568c6] [9fb95a8c] [4e23d2a2]
