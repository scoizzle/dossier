# django/core/mail/backends/base

- Subject: django/core/mail/backends/base (id `de7c7a45-868f-4f69-97ae-6c88b55dd7ea`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1074 tokens
- Facts shown: 23 of 23
- Conflicts: 0
- Gaps: 0

## Highlights

- # RemovedInDjango2028Warning. if alias is None: # Not being initialized from mail.mailers. Unknown kwargs are # ignored -- with a deprecation warning if they originated from # outside Django (either direct construction of a built-in # backend or a super.__init__() call from a custom subclass). # Use something more precise than self.__class__.__name__, # which is often just "EmailBackend". class_name = f"{type(self).__module__}.{type(self).__qualname__}" warn_about_external_use( f"{class_name}.__init__() does not support {kwarg_names}. " "In Django 2028, BaseEmailBackend will raise a TypeError " "for unknown keyword arguments.", RemovedInDjango2028Warning, skip_name_prefixes="django.core.mail.backends", ) return [53c4e09d]
- raise InvalidMailer(f"Unknown options {kwarg_names}.", alias=alias) [6270fce6]
- # RemovedInDjango2028Warning. if fail_silently is _NOT_PROVIDED: self._fail_silently = False else: self._fail_silently = fail_silently # Force deprecation warning unless in _ignore_unknown_kwargs. kwargs["fail_silently"] = fail_silently if _ignore_unknown_kwargs: for ignored in _ignore_unknown_kwargs: kwargs.pop(ignored, None) [d3c08011]
- It's up to the backend implementation to track the status of a network connection if it's needed by the backend. [fb4dc68e]
- The default implementation does nothing. """ pass [e26c7322]
- This method can be called by applications to force a single network connection to be used when sending mails. See the send_messages() method of the SMTP backend for a reference implementation. [790afce7]
- This method can be overwritten by backend implementations to open a network connection. [9f941bcc]
- if kwargs: kwarg_names = ", ".join(repr(key) for key in kwargs.keys()) [8fefa478]
- with backend as connection: # do something with connection pass """ [a7566adb]
- # RemovedInDjango2028Warning. def __getattr__(self, name): if name == "fail_silently": msg = ( "BaseEmailBackend.fail_silently is deprecated. A subclass " "that supports fail_silently must set its own attribute." ) warn_about_external_use(msg, RemovedInDjango2028Warning) return self._fail_silently raise AttributeError( f"{type(self).__name__!r} object has no attribute {name!r}" ) [a8f0d0b3]
- # RemovedInDjango2028Warning: fail_silently, _ignore_unknown_kwargs. def __init__( self, fail_silently=_NOT_PROVIDED, *, alias=None, _ignore_unknown_kwargs=None, **kwargs, ): self.alias = alias [fae1bc8c]
- Subclass __init__() should pass alias and unknown **kwargs to super().__init__() for proper error reporting. [cc3567c9]
- Subclasses must implement at least send_messages(). [7089fb2d]
- def __enter__(self): try: self.open() except Exception: self.close() raise return self [0fb93354]
- def __exit__(self, exc_type, exc_value, traceback): self.close() [13fbb7dd43764b1a]
- def close(self): """Close a network connection.""" pass [ade188ae]
- def open(self): """ Open a network connection. [cbc74a03]
- open() and close() can be called indirectly by using a backend object as a context manager: [dea57c03]

## All facts

- [8b416640] def send_messages(self, email_messages): """ Send one or more EmailMessage objects and return the number of email messages sent. """ raise NotImplementedError( "subclasses of BaseEmailBackend must override send_messages() method" )
- [4ef2aa9f] """Base email backend class."""
- [b5c3e1d6] # RemovedInDjango2028Warning. _NOT_PROVIDED = object()
- [db9c0911] class BaseEmailBackend: """ Base class for email backend implementations.
- [2709de08] from django.core.mail import InvalidMailer from django.utils.deprecation import RemovedInDjango2028Warning, warn_about_external_use
