# django/contrib/postgres/fields/hstore

- Subject: django/contrib/postgres/fields/hstore (id `ed33d2f3-3a62-4bb7-819c-2fdc7c3eed7c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 821 tokens
- Facts shown: 21 of 22
- Conflicts: 0
- Gaps: 0

## Facts

- if isinstance(value, dict): prep_value = {} for key, val in value.items(): key = str(key) if val is not None: val = str(val) prep_value[key] = val value = prep_value [a5ac71ee]
- if isinstance(value, list): value = [str(item) for item in value] [f54c6aee]
- return value [cc0bb0b4bce83f7f]
- def __call__(self, *args, **kwargs): return KeyTransform(self.key_name, *args, **kwargs) [9370409e6227d4c7]
- def __init__(self, key_name, *args, **kwargs): super().__init__(*args, **kwargs) self.key_name = key_name [edc67dee]
- def as_sql(self, compiler, connection): lhs, params = compiler.compile(self.lhs) return "(%s -> %%s)" % lhs, (*params, self.key_name) [55c67b3e]
- def db_type(self, connection): return "hstore" [77182539]
- def formfield(self, **kwargs): return super().formfield( **{ "form_class": forms.HStoreField, **kwargs, } ) [5ae9bdda]
- def get_prep_value(self, value): value = super().get_prep_value(value) [fd426630]
- def get_transform(self, name): transform = super().get_transform(name) if transform: return transform return KeyTransformFactory(name) [e9a990fae654588b]
- def to_python(self, value): if isinstance(value, str): value = json.loads(value) return value [8f3c0a23]
- def validate(self, value, model_instance): super().validate(value, model_instance) for key, val in value.items(): if not isinstance(val, str) and val is not None: raise exceptions.ValidationError( self.error_messages["not_a_string"], code="not_a_string", params={"key": key}, ) [9e2cd7c7]
- def value_to_string(self, obj): return json.dumps(self.value_from_object(obj), ensure_ascii=False) [2a6e7c5a]
- @HStoreField.register_lookup class KeysTransform(Transform): lookup_name = "keys" function = "akeys" output_field = ArrayField(TextField()) [36d8dedd]
- @HStoreField.register_lookup class ValuesTransform(Transform): lookup_name = "values" function = "avals" output_field = ArrayField(TextField()) [aadf7eb8]
- HStoreField.register_lookup(lookups.DataContains) HStoreField.register_lookup(lookups.ContainedBy) HStoreField.register_lookup(lookups.HasKey) HStoreField.register_lookup(lookups.HasKeys) HStoreField.register_lookup(lookups.HasAnyKeys) [43310a9e]
- __all__ = ["HStoreField"] [ac369350f5f49b5f]
- class HStoreField(CheckPostgresInstalledMixin, CheckFieldDefaultMixin, Field): empty_strings_allowed = False description = _("Map of strings to strings/nulls") default_error_messages = { "not_a_string": _("The value of “%(key)s” is not a string or null."), } _default_hint = ("dict", "{}") [b94d1b00]
- class KeyTransform(Transform): output_field = TextField() [bc77fde6]
- class KeyTransformFactory: def __init__(self, key_name): self.key_name = key_name [f81964eaee3a6789]
- import json [5766bf5bad9de4d2-8]

## Beyond the budget

1 more facts did not fit in the budget: [f112f388]
