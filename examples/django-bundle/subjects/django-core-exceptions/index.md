# django/core/exceptions

- Subject: django/core/exceptions (id `aae8a5a2-bc23-4e43-9617-da12f06f18bb`)
- Kind: subject
- Budget: 1200 tokens
- Used: 895 tokens
- Facts shown: 18 of 65
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

46 more facts did not fit in the budget: [7655780f0d17b825-17] [7655780f0d17b825-18] [7655780f0d17b825-19] [7655780f0d17b825-20] [7655780f0d17b825-21] [7655780f0d17b825-22] [7655780f0d17b825-23] [7655780f0d17b825-24] [7655780f0d17b825-25] [7655780f0d17b825-26] [7655780f0d17b825-27] [7655780f0d17b825-28] [7655780f0d17b825-29] [7655780f0d17b825-30] [7655780f0d17b825-31] [7655780f0d17b825-32] [7655780f0d17b825-33] [8b4936c0] [eb15b3b9] [c4a54f36] [5506f086] [4b5b1647] [dfb620cf] [e6daee66] [b0a0551f] [ca72cb2a] [768b2f0d] [110c4989] [0271b22d] [39f6ccc0] [066e478a] [beae1dd1] [424f2732] [e7274cf0] [943e8f5b] [b243d2d6] [8d68b19c] [3609bf68] [e320117d] [718e47bf] [8877a324] [16900f64] [0de287c6] [348102ad] [7c27c9fd099764a6] [375f25d0b2ee635c]
