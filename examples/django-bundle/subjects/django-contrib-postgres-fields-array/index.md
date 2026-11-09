# django/contrib/postgres/fields/array

- Subject: django/contrib/postgres/fields/array (id `ed38ed49-6723-4717-89d8-f770c3051b85`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2979 tokens
- Facts shown: 47 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- for val in vals: if val is None: values.append(None) else: obj = AttributeSetter(base_field.attname, val) values.append(base_field.value_to_string(obj)) return json.dumps(values, ensure_ascii=False) [7c7987d3]
- @classmethod def _choices_is_value(cls, value): return isinstance(value, (list, tuple)) or super()._choices_is_value(value) [d740b49c35160727]
- @model.setter def model(self, model): self.__dict__["model"] = model self.base_field.model = model [5d85b883df2cda2e]
- @property def description(self): return "Array of %s" % self.base_field.description [b08ce0db]
- @property def model(self): try: return self.__dict__["model"] except KeyError: raise AttributeError( "'%s' object has no attribute 'model'" % self.__class__.__name__ ) [e369aa7f9e116693]
- @property def output_field(self): return self.base_field [5bf8c190]
- def __call__(self, *args, **kwargs): return IndexTransform(self.index, self.base_field, *args, **kwargs) [f2e50264]
- def __call__(self, *args, **kwargs): return SliceTransform(self.start, self.end, *args, **kwargs) [ad1bc4ff]
- def __init__(self, base_field, size=None, **kwargs): self.base_field = base_field self.db_collation = getattr(self.base_field, "db_collation", None) self.size = size if self.size: self.default_validators = [ *self.default_validators, ArrayMaxLengthValidator(self.size), ] # For performance, only add a from_db_value() method if the base field # implements it. if hasattr(self.base_field, "from_db_value"): self.from_db_value = self._from_db_value super().__init__(**kwargs) [7be1e344]
- def _from_db_value(self, value, expression, connection): if value is None: return value return [ self.base_field.from_db_value(item, expression, connection) for item in value ] [1c0ec953]
- def _rhs_not_none_values(self, rhs): for x in rhs: if isinstance(x, (list, tuple)): yield from self._rhs_not_none_values(x) elif x is not None: yield True [90994b10]
- def as_sql(self, compiler, connection): lhs, params = compiler.compile(self.lhs) # Distinguish NULL and empty arrays return ( "CASE WHEN %(lhs)s IS NULL THEN NULL ELSE " "coalesce(array_length(%(lhs)s, 1), 0) END" ) % {"lhs": lhs}, params * 2 [814fea49]
- def as_sql(self, compiler, connection): lhs, params = compiler.compile(self.lhs) # self.start is set to 1 if slice start is not provided. if self.end is None: return f"({lhs})[%s:]", (*params, self.start) else: return f"({lhs})[%s:%s]", (*params, self.start, self.end) [2db59fad]
- def as_sql(self, compiler, connection): lhs, params = compiler.compile(self.lhs) if not lhs.endswith("]"): lhs = "(%s)" % lhs return "%s[%%s]" % lhs, (*params, self.index) [08c032fd]
- def cast_db_type(self, connection): size = self.size or "" return "%s[%s]" % (self.base_field.cast_db_type(connection), size) [9abb3ef0]
- def db_parameters(self, connection): db_params = super().db_parameters(connection) db_params["collation"] = self.db_collation return db_params [2b62b3d8ddb2a195]
- def db_type(self, connection): size = self.size or "" return "%s[%s]" % (self.base_field.db_type(connection), size) [27b7b4b0]
- __all__ = ["ArrayField"] [a868c4c1]

## All facts

- [906dcfa1] def check(self, **kwargs): errors = super().check(**kwargs) if self.base_field.remote_field: errors.append( checks.Error( "Base field for array cannot be a related field.", obj=self, id="postgres.E002", ) ) else: base_checks = self.base_field.check(**kwargs) if base_checks: error_messages = "\n ".join( "%s (%s)" % (base_check.msg, base_check.id) for base_check in base_checks if isinstance(base_check, checks.Error) # Prevent duplication of E005 in an E001 check. and not base_check.id == "postgres.E005" ) if error_messages: errors.append( checks.Error( "Base field for array has errors:\n %s" % error_messages, obj=self, id="postgres.E001", ) ) warning_messages = "\n ".join( "%s (%s)" % (base_check.msg, base_check.id) for base_check in base_checks if isinstance(base_check, checks.Warning) ) if warning_messages: errors.append( checks.Warning( "Base field for array has warnings:\n %s" % warning_messages, obj=self, id="postgres.W004", ) ) return errors
- [80410078] def deconstruct(self): name, path, args, kwargs = super().deconstruct() if path == "django.contrib.postgres.fields.array.ArrayField": path = "django.contrib.postgres.fields.ArrayField" kwargs["base_field"] = self.base_field.clone() if self.size is not None: kwargs["size"] = self.size return name, path, args, kwargs
- [68fddfb0] def formfield(self, **kwargs): return super().formfield( **{ "form_class": SimpleArrayField, "base_field": self.base_field.formfield(), "max_length": self.size, **kwargs, } )
- [d04ca6ba] def get_db_prep_save(self, value, connection): if isinstance(value, (list, tuple)): return [self.base_field.get_db_prep_save(i, connection) for i in value] return value
- [1e9d0710] def get_db_prep_value(self, value, connection, prepared=False): if isinstance(value, (list, tuple)): return [ self.base_field.get_db_prep_value(i, connection, prepared=False) for i in value ] return value
- [2345d4a2368c520e] def get_placeholder_sql(self, value, compiler, connection): db_type = self.db_type(connection) if hasattr(value, "as_sql"): sql, params = compiler.compile(value) return f"{sql}::{db_type}", params return f"%s::{db_type}", (value,)
- [efa5a875] def get_transform(self, name): transform = super().get_transform(name) if transform: return transform if "_" not in name: try: index = int(name) except ValueError: pass else: index += 1 # postgres uses 1-indexing return IndexTransformFactory(index, self.base_field) try: start, end = name.split("_") start = int(start) + 1 end = int(end) # don't add one here because postgres slices are weird except ValueError: pass else: return SliceTransformFactory(start, end)
- [13e9819a] def process_rhs(self, compiler, connection): rhs, rhs_params = super().process_rhs(compiler, connection) cast_type = self.lhs.output_field.cast_db_type(connection) return "%s::%s" % (rhs, cast_type), rhs_params
- [42493a16] def run_validators(self, value): super().run_validators(value) for index, part in enumerate(value): try: self.base_field.run_validators(part) except exceptions.ValidationError as error: raise prefix_validation_error( error, prefix=self.error_messages["item_invalid"], code="item_invalid", params={"nth": index + 1}, )
- [6f7aabf41583b6c2] def set_attributes_from_name(self, name): super().set_attributes_from_name(name) self.base_field.set_attributes_from_name(name)
- [6d89a908] def slice_expression(self, expression, start, length): # If length is not provided, don't specify an end to slice to the end # of the array. end = None if length is None else start + length - 1 return SliceTransform(start, end, expression)
- [fa8673a9] def to_python(self, value): if isinstance(value, str): # Assume we're deserializing vals = json.loads(value) value = [self.base_field.to_python(val) for val in vals] return value
- [6100dde2] def validate(self, value, model_instance): super().validate(value, model_instance) for index, part in enumerate(value): try: self.base_field.validate(part, model_instance) except exceptions.ValidationError as error: raise prefix_validation_error( error, prefix=self.error_messages["item_invalid"], code="item_invalid", params={"nth": index + 1}, ) if isinstance(self.base_field, ArrayField): if len({len(i) for i in value}) > 1: raise exceptions.ValidationError( self.error_messages["nested_array_mismatch"], code="nested_array_mismatch", )
- [425a2822] def value_to_string(self, obj): values = [] vals = self.value_from_object(obj) base_field = self.base_field
- [26b6219e] @ArrayField.register_lookup class ArrayContainedBy(ArrayRHSMixin, lookups.ContainedBy): pass
- [e75849bc] @ArrayField.register_lookup class ArrayContains(ArrayRHSMixin, lookups.DataContains): pass
- [3c77b7c3] @ArrayField.register_lookup class ArrayExact(ArrayRHSMixin, Exact): pass
- [56735151] @ArrayField.register_lookup class ArrayInLookup(In): def get_prep_lookup(self): values = super().get_prep_lookup() if hasattr(values, "resolve_expression"): return values # In.process_rhs() expects values to be hashable, so convert lists # to tuples. prepared_values = [] for value in values: if hasattr(value, "resolve_expression"): prepared_values.append(value) else: prepared_values.append(tuple(value)) return prepared_values
- [849a4ac5] @ArrayField.register_lookup class ArrayLenTransform(Transform): lookup_name = "len" output_field = IntegerField()
- [c054430a] @ArrayField.register_lookup class ArrayOverlap(ArrayRHSMixin, lookups.Overlap): pass
- [0b29c4fd] class ArrayField(CheckPostgresInstalledMixin, CheckFieldDefaultMixin, Field): empty_strings_allowed = False default_error_messages = { "item_invalid": _("Item %(nth)s in the array did not validate:"), "nested_array_mismatch": _("Nested arrays must have the same length."), } _default_hint = ("list", "[]")
- [0bb908ab] class ArrayRHSMixin: def __init__(self, lhs, rhs): # Don't wrap arrays that contains only None values, psycopg doesn't # allow this. if isinstance(rhs, (tuple, list)) and any(self._rhs_not_none_values(rhs)): expressions = [] for value in rhs: if not hasattr(value, "resolve_expression"): field = lhs.output_field value = Value(field.base_field.get_prep_value(value)) expressions.append(value) rhs = Func( *expressions, function="ARRAY", template="%(function)s[%(expressions)s]", ) super().__init__(lhs, rhs)
- [3535d821] class IndexTransform(Transform): def __init__(self, index, base_field, *args, **kwargs): super().__init__(*args, **kwargs) self.index = index self.base_field = base_field
- [cba88ecd] class IndexTransformFactory: def __init__(self, index, base_field): self.index = index self.base_field = base_field
- [51b41844] class SliceTransform(Transform): def __init__(self, start, end, *args, **kwargs): super().__init__(*args, **kwargs) self.start = start self.end = end
- [92716cad] class SliceTransformFactory: def __init__(self, start, end): self.start = start self.end = end
- [fbb06f8b02770a61] from .utils import AttributeSetter
- [45c9b7fd] from django.contrib.postgres import lookups from django.contrib.postgres.forms import SimpleArrayField from django.contrib.postgres.utils import ( CheckPostgresInstalledMixin, prefix_validation_error, ) from django.contrib.postgres.validators import ArrayMaxLengthValidator from django.core import checks, exceptions from django.db.models import Field, Func, IntegerField, Transform, Value from django.db.models.fields.mixins import CheckFieldDefaultMixin from django.db.models.lookups import Exact, In from django.utils.translation import gettext_lazy as _
- [5766bf5bad9de4d2-7] import json
