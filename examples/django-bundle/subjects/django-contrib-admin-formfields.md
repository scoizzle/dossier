# django/contrib/admin/formfields

- Subject: django/contrib/admin/formfields (id `0ef42e12-9be9-405e-9116-e07d7b300503`)
- Kind: subject
- Budget: 1200 tokens
- Used: 239 tokens
- Facts shown: 4 of 5
- Conflicts: 0
- Gaps: 0

## Facts

- def to_python(self, value): # The admin changelist search allows case-insensitivity. try: value = value.lower() except AttributeError: pass if value in (None, "none"): return None value = super().to_python(value) if value is None: # Not translated, as this is currently not user-facing. raise ValidationError("Invalid value.") return value [d38808e8]
- class StrictBooleanField(NullBooleanField): """ forms.BooleanField coerces almost any truthy input to True. Delegate to NullBooleanField's stricter parsing while still rejecting None values. """ [8b674246]
- class StrictNullBooleanField(NullBooleanField): """ forms.NullBooleanField doesn't distinguish explicit None values, so check for that before delegating. """ [85cf77de]
- from django.core.exceptions import ValidationError from django.forms import NullBooleanField [140c7702]
