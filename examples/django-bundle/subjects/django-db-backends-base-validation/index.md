# django/db/backends/base/validation

- Subject: django/db/backends/base/validation (id `a631686e-bbd2-4ae6-bc19-9e03c871bc1f`)
- Kind: subject
- Budget: 1200 tokens
- Used: 262 tokens
- Facts shown: 5 of 5
- Conflicts: 0
- Gaps: 0

## Facts

- def __del__(self): del self.connection [aedcdc0442006877-6]
- def __init__(self, connection): self.connection = connection [f0a7ddc935b65180-4]
- def check(self, **kwargs): return [] [29d2ea2570acf4bf]
- def check_field(self, field, **kwargs): errors = [] # Backends may implement a check_field_type() method. if ( hasattr(self, "check_field_type") and # Ignore any related fields. not getattr(field, "remote_field", None) ): # Ignore fields with unsupported features. db_supports_all_required_features = all( getattr(self.connection.features, feature, False) for feature in field.model._meta.required_db_features ) if db_supports_all_required_features: field_type = field.db_type(self.connection) # Ignore non-concrete fields. if field_type is not None: errors.extend(self.check_field_type(field, field_type)) return errors [71675ab0]
- class BaseDatabaseValidation: """Encapsulate backend-specific validation.""" [a2a48d6f]
