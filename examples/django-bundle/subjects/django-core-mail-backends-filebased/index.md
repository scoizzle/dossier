# django/core/mail/backends/filebased

- Subject: django/core/mail/backends/filebased (id `80d2381d-33b8-47ed-8a01-6c1bd64255fc`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 783 tokens
- Facts shown: 10 facts
- Conflicts: 0
- Gaps: 0

## Facts

- # RemovedInDjango2028Warning. if self.alias is None: # Use deprecated settings when MAILERS not enabled. if file_path is not None: self.file_path = file_path else: self.file_path = getattr(settings, "EMAIL_FILE_PATH", None) if self.file_path is None: raise ImproperlyConfigured( "The EMAIL_FILE_PATH setting must be set to use the file " "EmailBackend." ) self.file_path = os.path.abspath(self.file_path) try: os.makedirs(self.file_path, exist_ok=True) except FileExistsError: raise ImproperlyConfigured( "Path for saving email messages exists, but is not a directory: %s" % self.file_path ) except OSError as err: raise ImproperlyConfigured( "Could not create directory for saving email messages: %s (%s)" % (self.file_path, err) ) # Make sure that self.file_path is writable. if not os.access(self.file_path, os.W_OK): raise ImproperlyConfigured( "Could not write to directory: %s" % self.file_path ) return [71ef06cf]
- if file_path is None: raise InvalidMailer("OPTIONS must define 'file_path'.", alias=self.alias) self.file_path = os.path.abspath(file_path) try: os.makedirs(self.file_path, exist_ok=True) except FileExistsError: raise InvalidMailer( f"'file_path' is not a directory: {self.file_path}", alias=self.alias, ) except OSError as err: raise InvalidMailer( f"Could not create 'file_path': {self.file_path} ({err})", alias=self.alias, ) if not os.access(self.file_path, os.W_OK): raise InvalidMailer( f"'file_path' is not writable: {self.file_path}", alias=self.alias, ) [32a0cb9d]
- def _get_filename(self): """Return a unique file name.""" if self._fname is None: timestamp = datetime.datetime.now().strftime("%Y%m%d-%H%M%S") fname = "%s-%s.log" % (timestamp, abs(id(self))) self._fname = os.path.join(self.file_path, fname) return self._fname [ff441e61]
- def close(self): try: if self.stream is not None: self.stream.close() finally: self.stream = None [0ee5d071]
- def open(self): if self.stream is None: self.stream = open(self._get_filename(), "ab") return True return False [8ac34e6f]
- def write_message(self, message): self.stream.write(message.message().as_bytes() + b"\n") self.stream.write(b"-" * 79) self.stream.write(b"\n") [acd6b2b5]
- """Email backend that writes messages to a file.""" [3beed21e]
- class EmailBackend(ConsoleEmailBackend): def __init__(self, fail_silently=False, file_path=None, **kwargs): self._fname = None # Since we're using the console-based backend as a base, force the # stream to be None, so we don't default to stdout. kwargs["stream"] = None super().__init__(fail_silently=fail_silently, **kwargs) [689fc45b]
- from django.conf import settings from django.core.exceptions import ImproperlyConfigured from django.core.mail import InvalidMailer from django.core.mail.backends.console import EmailBackend as ConsoleEmailBackend [bd35a6e8]
- import datetime import os [8305ae69]
