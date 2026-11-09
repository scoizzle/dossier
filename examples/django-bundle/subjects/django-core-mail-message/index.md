# django/core/mail/message

- Subject: django/core/mail/message (id `a0acbddd-fe60-4aaa-b669-6cfca1d745be`)
- Kind: subject
- Budget: 1200 tokens
- Used: 886 tokens
- Facts shown: 9 of 63
- Conflicts: 0
- Gaps: 0

## Facts

- if basetype == "text": if isinstance(content, bytes): try: content = content.decode() except UnicodeDecodeError: # If mimetype suggests the file is text but it's # actually binary, read() raises a UnicodeDecodeError. mimetype = DEFAULT_ATTACHMENT_MIME_TYPE [7ade5bee]
- self.attachments.append(EmailAttachment(filename, content, mimetype)) [bc69ebb7]
- # Email header names are case-insensitive (RFC 2045), so we have to # accommodate that when doing comparisons. header_names = [key.lower() for key in self.extra_headers] if "date" not in header_names: if settings.EMAIL_USE_LOCALTIME: tz = get_current_timezone() else: tz = timezone.utc msg["Date"] = datetime.now(tz) if "message-id" not in header_names: # Use cached DNS_NAME for performance msg["Message-ID"] = make_msgid(domain=DNS_NAME) for name, value in self.extra_headers.items(): header = name.lower() if header == "bcc": raise ValueError( 'Bcc is not a valid email header. Use the "bcc" ' "argument to specify blind carbon copy recipients." ) # Avoid headers handled above. if header not in {"from", "to", "cc", "reply-to"}: msg[name] = force_str(value, strings_only=True) self._idna_encode_address_header_domains(msg) return msg [33a39813]
- # RemovedInDjango2028Warning: replace the remainder of this method # with: # from django.core.mail import mailers # mailer = mailers.default if using is None else mailers[using] # return mailer.send_messages([self]) [451acf66]
- # See email.contentmanager.set_content() docs for the cases here. if maintype == "text": # For text/*, content must be str, and maintype cannot be provided. msg.add_attachment( content, subtype=subtype, filename=filename, charset=encoding ) elif maintype == "message": # For message/*, content must be email.message.EmailMessage (or # legacy email.message.Message), and maintype cannot be provided. if isinstance(content, EmailMessage): # Django EmailMessage. content = content.message(policy=msg.policy) elif not isinstance( content, (email.message.EmailMessage, email.message.Message) ): content = email.message_from_bytes( force_bytes(content), policy=msg.policy ) msg.add_attachment(content, subtype=subtype, filename=filename) else: # For all other types, content must be bytes-like, and both # maintype and subtype must be provided. if not isinstance(content, (bytes, bytearray, memoryview)): content = force_bytes(content) msg.add_attachment( content, maintype=maintype, subtype=subtype, filename=filename, ) [18c928a0]
- For a text/* mimetype (guessed or specified), decode the file's content as UTF-8. If that fails, set the mimetype to DEFAULT_ATTACHMENT_MIME_TYPE and don't decode the content. """ path = Path(path) with path.open("rb") as file: content = file.read() self.attach(path.name, content, mimetype) [f13b6c63]
- If the first parameter is a MIMEBase subclass, insert it directly into the resulting message attachments. [26251afb]
- Set the mimetype to DEFAULT_ATTACHMENT_MIME_TYPE if it isn't specified and cannot be guessed. [ae985583]
- This overrides the default as_bytes() implementation to not mangle lines that begin with 'From '. See bug #13433 for details. """ fp = BytesIO() g = generator.BytesGenerator(fp, mangle_from_=False) g.flatten(self, unixfrom=unixfrom, linesep=linesep) return fp.getvalue() [a9517983]

## Beyond the budget

53 more facts did not fit in the budget: [d86a97f4] [de5f9501] [df7e01dc] [422b01bc] [bfb5f504] [99883b92] [494f1d9c] [9aad3717] [a57e3274] [ee9824e1] [746af2fe] [62da7f3f] [1732c072] [a0cd7acd] [f594bbef] [8b8962aa] [11b3fef4] [27796208] [811e7ddd] [6782c73e] [12284be4] [46717e74] [4f04c38b] [32bee1d4] [ea752d5f] [1ba2f331] [b06f7d09] [202307c8] [5f696d70] [0ab662bc] [cb79f38e] [59f9a119] [32701755] [7e990723] [8e57c5fa] [cd933559] [7e07d457] [668604ca] [e9ab89c2] [a86147b0] [dc47972f] [ed12f47c] [6e959199] [827a7a01] [eae97f21] [3214a1d5] [e5929181] [61fe35f9] [7cb9907b] [26224508] [695ddab6] [f7e73e88] [f7b8c315]
