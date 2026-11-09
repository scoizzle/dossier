# django/core/mail/exceptions

- Subject: django/core/mail/exceptions (id `17017a4c-4335-4c59-b3ed-8b08911ac9af`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 187 tokens
- Facts shown: 5 facts
- Conflicts: 0
- Gaps: 0

## Facts

- def __init__(self, *, alias): # This is the only permitted use for this exception. super().__init__(f"The mailer '{alias}' is not configured.") [06e32d4b]
- def __init__(self, msg, *, alias=None): if alias is not None: msg = f"MAILERS[{alias!r}]: {msg}" super().__init__(msg) [9de32530]
- class InvalidMailer(ImproperlyConfigured): """A settings.MAILERS entry has a configuration error.""" [30a842d0]
- class MailerDoesNotExist(InvalidMailer, KeyError): """The requested alias is not defined in settings.MAILERS.""" [31610f21]
- from django.core.exceptions import ImproperlyConfigured [cb27d71dfadbe105]
