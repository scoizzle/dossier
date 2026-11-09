# django/db/models/fields/composite

- Subject: django/db/models/fields/composite (id `419331c1-4f35-400c-8044-81a8f359942d`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1522 tokens
- Facts shown: 33 of 33
- Conflicts: 0
- Gaps: 0

## Highlights

- for attname, value in zip(attnames, values): setattr(instance, attname, value) [2a946ce0]
- for field in self.fields: value = field.value_from_object(instance) if value is None: value = field.get_pk_value_on_save(instance) values.append(value) [a10e9924]
- if not isinstance(values, (list, tuple)): raise ValueError(f"{self.field.name!r} must be a list or a tuple.") if length != len(values): raise ValueError(f"{self.field.name!r} must have {length} elements.") [a71d4aef]
- if values is None: values = (None,) * length [e14622a1]
- return ColPairs(alias, self.fields, self.fields, output_field) [f87f7025]
- return tuple(values) [71b19b51]
- self.field_names = args super().__init__(**kwargs) [da17d900]
- @cached_property def cached_col(self): return ColPairs(self.model._meta.db_table, self.fields, self.fields, self) [9f78ac56]
- @cached_property def columns(self): return tuple(field.column for field in self.fields) [341c8423]
- @cached_property def fields(self): meta = self.model._meta return tuple(meta.get_field(field_name) for field_name in self.field_names) [300ecffd]
- @property def attnames(self): return [field.attname for field in self.field.fields] [dfb4a503]
- def __get__(self, instance, cls=None): return tuple(getattr(instance, attname) for attname in self.attnames) [2ddf20dc]
- def __init__(self, *args, **kwargs): if ( not args or not all(isinstance(field, str) for field in args) or len(set(args)) != len(args) ): raise ValueError("CompositePrimaryKey args must be unique strings.") if len(args) == 1: raise ValueError("CompositePrimaryKey must include at least two fields.") if kwargs.get("default", NOT_PROVIDED) is not NOT_PROVIDED: raise ValueError("CompositePrimaryKey cannot have a default.") if kwargs.get("db_default", NOT_PROVIDED) is not NOT_PROVIDED: raise ValueError("CompositePrimaryKey cannot have a database default.") if kwargs.get("db_column", None) is not None: raise ValueError("CompositePrimaryKey cannot have a db_column.") if kwargs.setdefault("editable", False): raise ValueError("CompositePrimaryKey cannot be editable.") if not kwargs.setdefault("primary_key", True): raise ValueError("CompositePrimaryKey must be a primary key.") if not kwargs.setdefault("blank", True): raise ValueError("CompositePrimaryKey must be blank.") [af0a58af]
- def __iter__(self): return iter(self.fields) [d0b35596]
- def __len__(self): return len(self.field_names) [0f114f4c]
- def __set__(self, instance, values): attnames = self.attnames length = len(attnames) [d16bbaed]
- def _check_field_name(self): if self.name == "pk": return [] return [ checks.Error( "'CompositePrimaryKey' must be named 'pk'.", obj=self, id="fields.E013", ) ] [559e6c6c]
- def contribute_to_class(self, cls, name, private_only=False): super().contribute_to_class(cls, name, private_only=private_only) cls._meta.pk = self setattr(cls, self.attname, self.descriptor_class(self)) [fbf2f930]
- def get_attname_column(self): return self.get_attname(), None [355ddf32]
- return result [e6d2cf0b52c4ebca-4]

## All facts

- [e72660f9] def deconstruct(self): # args is always [] so it can be ignored. name, path, _, kwargs = super().deconstruct() return name, path, self.field_names, kwargs
- [c8bd73b1] def get_col(self, alias, output_field=None): if alias == self.model._meta.db_table and ( output_field is None or output_field == self ): return self.cached_col
- [2f30e3de] def get_pk_value_on_save(self, instance): values = []
- [3d825e2a] def to_python(self, value): if isinstance(value, str): # Assume we're deserializing. vals = json.loads(value) value = [ field.to_python(val) for field, val in zip(self.fields, vals, strict=True) ] return value
- [17f3d610] def value_to_string(self, obj): values = [] vals = self.value_from_object(obj) for field, value in zip(self.fields, vals): obj = AttributeSetter(field.attname, value) values.append(field.value_to_string(obj)) return json.dumps(values, ensure_ascii=False)
- [fe739e4e] for field in fields: if isinstance(field, CompositePrimaryKey): result.extend(field.fields) else: result.append(field)
- [40b51966] CompositePrimaryKey.register_lookup(TupleExact) CompositePrimaryKey.register_lookup(TupleGreaterThan) CompositePrimaryKey.register_lookup(TupleGreaterThanOrEqual) CompositePrimaryKey.register_lookup(TupleLessThan) CompositePrimaryKey.register_lookup(TupleLessThanOrEqual) CompositePrimaryKey.register_lookup(TupleIn) CompositePrimaryKey.register_lookup(TupleIsNull)
- [6c7080c85b8e0ac0-2] class AttributeSetter: def __init__(self, name, value): setattr(self, name, value)
- [6d34c9c0] class CompositeAttribute: def __init__(self, field): self.field = field
- [e938c1de] class CompositePrimaryKey(Field): descriptor_class = CompositeAttribute
- [3b5fbdc3] def unnest(fields): result = []
- [c4ef4bc9] from django.core import checks from django.db.models import NOT_PROVIDED, Field from django.db.models.expressions import ColPairs from django.db.models.fields.tuple_lookups import ( TupleExact, TupleGreaterThan, TupleGreaterThanOrEqual, TupleIn, TupleIsNull, TupleLessThan, TupleLessThanOrEqual, ) from django.utils.functional import cached_property
- [5766bf5bad9de4d2-11] import json
