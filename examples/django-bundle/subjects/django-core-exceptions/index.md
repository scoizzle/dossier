# django/core/exceptions

- Subject: django/core/exceptions (id `aa234d8a-86ef-487f-93a4-73d05f13e9bb`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2020 tokens
- Facts shown: 64 of 65
- Conflicts: 0
- Gaps: 0

## Highlights

- elif isinstance(message, list): self.error_list = [] for message in message: # Normalize plain strings to instances of ValidationError. if not isinstance(message, ValidationError): message = ValidationError(message) if hasattr(message, "error_dict"): self.error_list.extend(sum(message.error_dict.values(), [])) else: self.error_list.extend(message.error_list) [87b9ebc8]
- else: self.message = message self.code = code self.params = params self.error_list = [self] [2af34621]
- if isinstance(message, ValidationError): if hasattr(message, "error_dict"): message = message.error_dict elif not hasattr(message, "message"): message = message.error_list else: message, code, params = message.message, message.code, message.params [1e584949]
- if isinstance(message, dict): self.error_dict = {} for field, messages in message.items(): if not isinstance(messages, ValidationError): messages = ValidationError(messages) self.error_dict[field] = messages.error_list [2a2bac62]
- return dict(self) [b1b733c7]
- @property def message_dict(self): # Trigger an AttributeError if this ValidationError # doesn't have an error_dict. getattr(self, "error_dict") [609f9acf]
- @property def messages(self): if hasattr(self, "error_dict"): return sum(dict(self).values(), []) return list(self) [1fe46a88]
- def __eq__(self, other): if not isinstance(other, ValidationError): return NotImplemented return hash(self) == hash(other) [52fe66e7]
- def __hash__(self): if hasattr(self, "message"): return hash( ( self.message, self.code, make_hashable(self.params), ) ) if hasattr(self, "error_dict"): return hash(make_hashable(self.error_dict)) return hash(tuple(sorted(self.error_list, key=operator.attrgetter("message")))) [4f4c28aa]
- def __init__(self, message, code=None, params=None): """ The `message` argument can be a single error, a list of errors, or a dictionary that maps field names to lists of errors. What we define as an "error" can be either a simple string or an instance of ValidationError with its message attribute set, and what we define as list or dictionary can be an actual `list` or `dict` or an instance of ValidationError with its `error_list` or `error_dict` attribute set. """ super().__init__(message, code, params) [1a1cc782]
- def __iter__(self): if hasattr(self, "error_dict"): for field, errors in self.error_dict.items(): yield field, list(ValidationError(errors)) else: for error in self.error_list: message = error.message if error.params: message %= error.params yield str(message) [8760f7cc]
- def __repr__(self): return "ValidationError(%s)" % self [fdd65d44]
- def __str__(self): if hasattr(self, "error_dict"): return repr(dict(self)) return repr(list(self)) [5e98c306]
- def update_error_dict(self, error_dict): if hasattr(self, "error_dict"): for field, error_list in self.error_dict.items(): error_dict.setdefault(field, []).extend(error_list) else: error_dict.setdefault(NON_FIELD_ERRORS, []).extend(self.error_list) return error_dict [85e4d68e]
- pass [7655780f0d17b825-13]
- pass [7655780f0d17b825-14]
- pass [7655780f0d17b825-15]
- pass [7655780f0d17b825-16]

## All facts

- [7655780f0d17b825-17] pass
- [7655780f0d17b825-18] pass
- [7655780f0d17b825-19] pass
- [7655780f0d17b825-20] pass
- [7655780f0d17b825-21] pass
- [7655780f0d17b825-22] pass
- [7655780f0d17b825-23] pass
- [7655780f0d17b825-24] pass
- [7655780f0d17b825-25] pass
- [7655780f0d17b825-26] pass
- [7655780f0d17b825-27] pass
- [7655780f0d17b825-28] pass
- [7655780f0d17b825-29] pass
- [7655780f0d17b825-30] pass
- [7655780f0d17b825-31] pass
- [7655780f0d17b825-32] pass
- [7655780f0d17b825-33] pass
- [8b4936c0] silent_variable_failure = True
- [eb15b3b9] """ Global Django exception classes. """
- [c4a54f36] NON_FIELD_ERRORS = "__all__"
- [5506f086] class AppRegistryNotReady(Exception): """The django.apps registry is not populated yet"""
- [4b5b1647] class BadRequest(Exception): """The request is malformed and cannot be processed."""
- [dfb620cf] class DisallowedHost(SuspiciousOperation): """HTTP_HOST header contains invalid value"""
- [e6daee66] class DisallowedRedirect(SuspiciousOperation): """Redirect was too long or scheme was not in allowed list."""
- [b0a0551f] class EmptyResultSet(Exception): """A database query predicate is impossible."""
- [ca72cb2a] class FieldDoesNotExist(Exception): """The requested model field does not exist"""
- [768b2f0d] class FieldError(Exception): """Some kind of problem with a model field."""
- [110c4989] class FieldFetchBlocked(FieldError): """On-demand fetching of a model field blocked."""
- [0271b22d] class FullResultSet(Exception): """A database query predicate that matches everything."""
- [39f6ccc0] class ImproperlyConfigured(Exception): """Django is somehow improperly configured"""
- [066e478a] class MiddlewareNotUsed(Exception): """This middleware is not used in this server configuration"""
- [beae1dd1] class MultipleObjectsReturned(Exception): """The query returned multiple objects when only one was expected."""
- [424f2732] class ObjectDoesNotExist(Exception): """The requested object does not exist"""
- [e7274cf0] class ObjectNotUpdated(Exception): """The updated object no longer exists."""
- [943e8f5b] class PermissionDenied(Exception): """The user did not have permission to do that"""
- [b243d2d6] class RequestAborted(Exception): """The request was closed before it was completed, or timed out."""
- [8d68b19c] class RequestDataTooBig(SuspiciousOperation): """ The size of the request (excluding any file uploads) exceeded settings.DATA_UPLOAD_MAX_MEMORY_SIZE. """
- [3609bf68] class SuspiciousFileOperation(SuspiciousOperation): """A Suspicious filesystem operation was attempted"""
- [e320117d] class SuspiciousMultipartForm(SuspiciousOperation): """Suspect MIME request in multipart form data"""
- [718e47bf] class SuspiciousOperation(Exception): """The user did something suspicious"""
- [8877a324] class SynchronousOnlyOperation(Exception): """The user tried to call a sync-only function from an async context."""
- [16900f64] class TooManyFieldsSent(SuspiciousOperation): """ The number of fields in a GET or POST request exceeded settings.DATA_UPLOAD_MAX_NUMBER_FIELDS. """
- [0de287c6] class ValidationError(Exception): """An error while validating data."""
- [348102ad] class ViewDoesNotExist(Exception): """The requested view does not exist"""
- [7c27c9fd099764a6] from django.utils.hashable import make_hashable
- [375f25d0b2ee635c] import operator
