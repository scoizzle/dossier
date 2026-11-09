# django/core/mail/backends/smtp

- Subject: django/core/mail/backends/smtp (id `120af8b5-94d2-4035-ac44-99e524c016ab`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 9 of 24
- Conflicts: 0
- Gaps: 0

## Facts

- # Don't set connection until it's fully configured. self.connection = self._partial_connection self._partial_connection = None [f05fca14]
- # TLS/SSL are mutually exclusive, so only attempt TLS over # non-secure connections. if not self.use_ssl and self.use_tls: self._partial_connection.starttls(context=self.ssl_context) if self.username and self.password: self._partial_connection.login(self.username, self.password) [4b093cd7]
- return True except OSError: if not self.fail_silently: raise [f1c76b75]
- # If a connection was partially opened before, close it. if self._partial_connection is not None: self._close_connection(self._partial_connection) self._partial_connection = None [c65bd45b]
- # If local_hostname is not specified, socket.getfqdn() gets used. # For performance, we use the cached FQDN for local_hostname. connection_params = {"local_hostname": DNS_NAME.get_fqdn()} if self.timeout is not None: connection_params["timeout"] = self.timeout if self.use_ssl: connection_params["context"] = self.ssl_context try: self._partial_connection = self.connection_class( self.host, self.port, **connection_params ) [25c67a2d]
- # RemovedInDjango2028Warning. if self.alias is None: # Use deprecated settings when MAILERS not enabled. self.host = host or settings.EMAIL_HOST self.port = port or settings.EMAIL_PORT self.username = settings.EMAIL_HOST_USER if username is None else username self.password = ( settings.EMAIL_HOST_PASSWORD if password is None else password ) self.use_tls = settings.EMAIL_USE_TLS if use_tls is None else use_tls self.use_ssl = settings.EMAIL_USE_SSL if use_ssl is None else use_ssl self.timeout = settings.EMAIL_TIMEOUT if timeout is None else timeout self.ssl_keyfile = ( settings.EMAIL_SSL_KEYFILE if ssl_keyfile is None else ssl_keyfile ) self.ssl_certfile = ( settings.EMAIL_SSL_CERTFILE if ssl_certfile is None else ssl_certfile ) if self.use_ssl and self.use_tls: raise ValueError( "EMAIL_USE_TLS/EMAIL_USE_SSL are mutually exclusive, so " "only set one of those settings to True." ) return [5474996c]
- If force_ascii is True, apply IDNA encoding to non-ASCII domains, and raise ValueError for non-ASCII local-parts (which can't be encoded). Otherwise, leave Unicode characters unencoded (e.g., for sending with SMTPUTF8). """ address = force_str(address) parsed = AddressHeader.value_parser(address) defects = set(str(defect) for defect in parsed.all_defects) # Django allows local mailboxes like "From: webmaster" (#15042). defects.discard("addr-spec local part with no domain") if not force_ascii: # PY315: Non-ASCII local-part is valid with SMTPUTF8. This check # can be removed once the minimum supported Python version is 3.15 # (so the fix for https://github.com/python/cpython/issues/81074 # is in all supported versions). defects.discard("local-part contains non-ASCII characters)") if defects: raise ValueError(f"Invalid address {address!r}: {'; '.join(defects)}") [9e161f4f]
- mailbox = mailboxes[0] if force_ascii and mailbox.domain and not mailbox.domain.isascii(): # Re-compose an addr-spec with the IDNA encoded domain. domain = punycode(mailbox.domain) return str(Address(username=mailbox.local_part, domain=domain)) else: return mailbox.addr_spec [8d3c352c]
- @property def connection_class(self): return smtplib.SMTP_SSL if self.use_ssl else smtplib.SMTP [dba81be0]

## Beyond the budget

15 more facts did not fit in the budget: [6543d7e7] [04113604] [babcc13d] [4a57748b] [6ccb3926] [8b324f96] [512aa2fc] [c05def09] [b4be8f0a] [9f99b205] [0577243a] [e67ad5c5] [4509b9f1] [1a820206] [2144e37b]
