# django/contrib/admin/formfields

- Subject: django/contrib/admin/formfields (id `dec51d0e-baca-4adb-ba23-7320108a16e7`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 325 tokens
- Facts shown: 5 facts
- Conflicts: 0
- Gaps: 0

## Facts

- def to_python(self, value): # The admin changelist search allows case-insensitivity. try: value = value.lower() except AttributeError: pass if value in (None, "none"): return None value = super().to_python(value) if value is None: # Not translated, as this is currently not user-facing. raise ValidationError("Invalid value.") return value [d38808e8]
- def to_python(self, value): # The admin changelist search allows case-insensitivity. try: value = value.lower() except AttributeError: pass value = super().to_python(value) if value is None: # Not translated, as this is currently not user-facing. raise ValidationError("Invalid value.") return value [d352b7b6]
- class StrictBooleanField(NullBooleanField): """ forms.BooleanField coerces almost any truthy input to True. Delegate to NullBooleanField's stricter parsing while still rejecting None values. """ [8b674246]
- class StrictNullBooleanField(NullBooleanField): """ forms.NullBooleanField doesn't distinguish explicit None values, so check for that before delegating. """ [85cf77de]
- from django.core.exceptions import ValidationError from django.forms import NullBooleanField [140c7702]
