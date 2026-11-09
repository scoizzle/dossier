# django/contrib/postgres/forms/hstore

- Subject: django/contrib/postgres/forms/hstore (id `4ad236cf-27e3-414f-ad90-d9c77aa0144f`)
- Kind: subject
- Budget: 1200 tokens
- Used: 446 tokens
- Facts shown: 10 of 10
- Conflicts: 0
- Gaps: 0

## Facts

- # Cast everything to strings for ease. for key, val in value.items(): if val is not None: val = str(val) value[key] = val return value [c4d6883e]
- if not isinstance(value, dict): raise ValidationError( self.error_messages["invalid_format"], code="invalid_format", ) [bf625c03]
- def has_changed(self, initial, data): """ Return True if data differs from initial. """ # For purposes of seeing whether something has changed, None is # the same as an empty dict, if the data or initial value we get # is None, replace it w/ {}. initial_value = self.to_python(initial) return super().has_changed(initial_value, data) [bb22ded3]
- def prepare_value(self, value): if isinstance(value, dict): return json.dumps(value, ensure_ascii=False) return value [a41843a3]
- def to_python(self, value): if not value: return {} if not isinstance(value, dict): try: value = json.loads(value) except json.JSONDecodeError: raise ValidationError( self.error_messages["invalid_json"], code="invalid_json", ) [887b2bf5]
- widget = forms.Textarea default_error_messages = { "invalid_json": _("Could not load JSON data."), "invalid_format": _("Input must be a JSON dictionary."), } [19ddbb70]
- __all__ = ["HStoreField"] [ac369350f5f49b5f-2]
- class HStoreField(forms.CharField): """ A field for HStore data which accepts dictionary JSON input. """ [0c57c42a]
- from django import forms from django.core.exceptions import ValidationError from django.utils.translation import gettext_lazy as _ [b7c84f0b]
- import json [5766bf5bad9de4d2-9]
