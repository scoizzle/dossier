# django/contrib/postgres/fields/ranges

- Subject: django/contrib/postgres/fields/ranges (id `f3912366-316a-410e-be21-8173e6f6a07d`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 3125 tokens
- Facts shown: 61 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- @classmethod def _choices_is_value(cls, value): return isinstance(value, (list, tuple)) or super()._choices_is_value(value) [d740b49c35160727-2]
- @model.setter def model(self, model): self.__dict__["model"] = model self.base_field.model = model [5d85b883df2cda2e-2]
- @property def model(self): try: return self.__dict__["model"] except KeyError: raise AttributeError( "'%s' object has no attribute 'model'" % self.__class__.__name__ ) [e369aa7f9e116693-2]
- @property def output_field(self): return self.lhs.output_field.base_field [aa8d02fd38786532]
- @property def output_field(self): return self.lhs.output_field.base_field [aa8d02fd38786532-2]
- def __init__(self, *args, **kwargs): if "default_bounds" in kwargs: raise TypeError( f"Cannot use 'default_bounds' with {self.__class__.__name__}." ) # Initializing base_field here ensures that its model matches the model # for self. if hasattr(self, "base_field"): self.base_field = self.base_field() super().__init__(*args, **kwargs) [a40f2d6f]
- def __init__(self, *args, default_bounds=CANONICAL_RANGE_BOUNDS, **kwargs): if default_bounds not in ("[)", "(]", "()", "[]"): raise ValueError("default_bounds must be one of '[)', '(]', '()', or '[]'.") self.default_bounds = default_bounds super().__init__(*args, **kwargs) [1ebd5ca7]
- def __init__(self, inclusive_lower=True, inclusive_upper=False): self.lower = "[" if inclusive_lower else "(" self.upper = "]" if inclusive_upper else ")" [1618b1f6]
- def as_postgresql(self, compiler, connection): sql, params = super().as_postgresql(compiler, connection) # Cast the rhs if needed. cast_sql = "" if ( isinstance(self.rhs, models.Expression) and self.rhs._output_field_or_none and # Skip cast if rhs has a matching range type. not isinstance( self.rhs._output_field_or_none, self.lhs.output_field.__class__ ) ): cast_internal_type = self.lhs.output_field.base_field.get_internal_type() cast_sql = "::{}".format(connection.data_types.get(cast_internal_type)) return "%s%s" % (sql, cast_sql), params [4111e2be]
- def as_sql(self, compiler, connection): return "'%s%s'" % (self.lower, self.upper), [] [36179e08]
- def db_type(self, connection): return "daterange" [642460e1]
- def db_type(self, connection): return "int4range" [ebcb1d8b]
- def db_type(self, connection): return "int8range" [79cb6a89]
- def db_type(self, connection): return "numrange" [4fc01ac4]
- def db_type(self, connection): return "tstzrange" [46b61f4a]
- def deconstruct(self): name, path, args, kwargs = super().deconstruct() if self.default_bounds and self.default_bounds != CANONICAL_RANGE_BOUNDS: kwargs["default_bounds"] = self.default_bounds return name, path, args, kwargs [720dfae5]
- def formfield(self, **kwargs): kwargs.setdefault("default_bounds", self.default_bounds) return super().formfield(**kwargs) [7f85348a]
- def formfield(self, **kwargs): kwargs.setdefault("form_class", self.form_field) return super().formfield(**kwargs) [821c17c1]
- def get_prep_lookup(self): return RangeField().get_prep_value(self.rhs) [9b1f08e6]
- CANONICAL_RANGE_BOUNDS = "[)" [8cfe962e]

## All facts

- [2345d4a2368c520e-2] def get_placeholder_sql(self, value, compiler, connection): db_type = self.db_type(connection) if hasattr(value, "as_sql"): sql, params = compiler.compile(value) return f"{sql}::{db_type}", params return f"%s::{db_type}", (value,)
- [3d3da6d8] def get_prep_value(self, value): if isinstance(value, (list, tuple)): return self.range_type(value[0], value[1], self.default_bounds) return super().get_prep_value(value)
- [fc9edefd] def get_prep_value(self, value): if value is None: return None elif isinstance(value, Range): return value elif isinstance(value, (list, tuple)): return self.range_type(value[0], value[1]) return value
- [683bf800] def process_lhs(self, compiler, connection): lhs, lhs_params = super().process_lhs(compiler, connection) if isinstance(self.lhs.output_field, models.FloatField): lhs = "%s::numeric" % lhs elif isinstance(self.lhs.output_field, models.SmallIntegerField): lhs = "%s::integer" % lhs return lhs, lhs_params
- [05b3bce2] def process_rhs(self, compiler, connection): # Transform rhs value for db lookup. if isinstance(self.rhs, datetime.date): value = models.Value(self.rhs) self.rhs = value.resolve_expression(compiler.query) return super().process_rhs(compiler, connection)
- [a3396ef7] def process_rhs(self, compiler, connection): rhs, rhs_params = super().process_rhs(compiler, connection) # Ignore precision for DecimalFields. db_type = self.lhs.output_field.cast_db_type(connection).split("(")[0] cast_type = self.type_mapping[db_type] return "%s::%s" % (rhs, cast_type), rhs_params
- [6f7aabf41583b6c2-2] def set_attributes_from_name(self, name): super().set_attributes_from_name(name) self.base_field.set_attributes_from_name(name)
- [8fb23b41] def to_python(self, value): if isinstance(value, str): # Assume we're deserializing vals = json.loads(value) for end in ("lower", "upper"): if end in vals: vals[end] = self.base_field.to_python(vals[end]) value = self.range_type(**vals) elif isinstance(value, (list, tuple)): value = self.range_type(value[0], value[1]) return value
- [8431dcb1] def value_to_string(self, obj): value = self.value_from_object(obj) if value is None: return None if value.isempty: return json.dumps({"empty": True}) base_field = self.base_field result = {"bounds": value._bounds} for end in ("lower", "upper"): val = getattr(value, end) if val is None: result[end] = None else: obj = AttributeSetter(base_field.attname, val) result[end] = base_field.value_to_string(obj) return json.dumps(result)
- [cd908a44] lookup_name = "contains" postgres_operator = RangeOperators.CONTAINS
- [f7da154d] @RangeField.register_lookup class AdjacentToLookup(PostgresOperatorLookup): lookup_name = "adjacent_to" postgres_operator = RangeOperators.ADJACENT_TO
- [2b1d427b] @RangeField.register_lookup class FullGreaterThan(PostgresOperatorLookup): lookup_name = "fully_gt" postgres_operator = RangeOperators.FULLY_GT
- [b534e13c] @RangeField.register_lookup class FullyLessThan(PostgresOperatorLookup): lookup_name = "fully_lt" postgres_operator = RangeOperators.FULLY_LT
- [0822cbc4] @RangeField.register_lookup class IsEmpty(models.Transform): lookup_name = "isempty" function = "isempty" output_field = models.BooleanField()
- [81a00cbd] @RangeField.register_lookup class LowerInclusive(models.Transform): lookup_name = "lower_inc" function = "LOWER_INC" output_field = models.BooleanField()
- [2bfceb83] @RangeField.register_lookup class LowerInfinite(models.Transform): lookup_name = "lower_inf" function = "LOWER_INF" output_field = models.BooleanField()
- [adf33f1a] @RangeField.register_lookup class NotGreaterThan(PostgresOperatorLookup): lookup_name = "not_gt" postgres_operator = RangeOperators.NOT_GT
- [d72925bb] @RangeField.register_lookup class NotLessThan(PostgresOperatorLookup): lookup_name = "not_lt" postgres_operator = RangeOperators.NOT_LT
- [481378a3] @RangeField.register_lookup class RangeEndsWith(models.Transform): lookup_name = "endswith" function = "upper"
- [327cae05] @RangeField.register_lookup class RangeStartsWith(models.Transform): lookup_name = "startswith" function = "lower"
- [b6e7a4a4] @RangeField.register_lookup class UpperInclusive(models.Transform): lookup_name = "upper_inc" function = "UPPER_INC" output_field = models.BooleanField()
- [0c4e5339] @RangeField.register_lookup class UpperInfinite(models.Transform): lookup_name = "upper_inf" function = "UPPER_INF" output_field = models.BooleanField()
- [411c17fa] DateRangeField.register_lookup(DateTimeRangeContains) DateTimeRangeField.register_lookup(DateTimeRangeContains)
- [2ab9012d] RangeField.register_lookup(RangeContains) RangeField.register_lookup(lookups.ContainedBy) RangeField.register_lookup(lookups.Overlap)
- [02f48dd7] __all__ = [ "RangeField", "IntegerRangeField", "BigIntegerRangeField", "DecimalRangeField", "DateTimeRangeField", "DateRangeField", "RangeBoundary", "RangeOperators", ]
- [e47ea7bb] class BigIntegerRangeField(RangeField): base_field = models.BigIntegerField range_type = NumericRange form_field = forms.IntegerRangeField
- [2e849311] class ContinuousRangeField(RangeField): """ Continuous range field. It allows specifying default bounds for list and tuple inputs. """
- [7db94bb7] class DateRangeField(RangeField): base_field = models.DateField range_type = DateRange form_field = forms.DateRangeField
- [7e569a41] class DateTimeRangeContains(PostgresOperatorLookup): """ Lookup for Date/DateTimeRange containment to cast the rhs to the correct type. """
- [3e001f6f] class DateTimeRangeField(ContinuousRangeField): base_field = models.DateTimeField range_type = DateTimeTZRange form_field = forms.DateTimeRangeField
- [ba7a2afe] class DecimalRangeField(ContinuousRangeField): base_field = models.DecimalField range_type = NumericRange form_field = forms.DecimalRangeField
- [3c43bed1] class IntegerRangeField(RangeField): base_field = models.IntegerField range_type = NumericRange form_field = forms.IntegerRangeField
- [b4433d8a] class RangeBoundary(models.Expression): """A class that represents range boundaries."""
- [e76895b8] class RangeContainedBy(PostgresOperatorLookup): lookup_name = "contained_by" type_mapping = { "smallint": "int4range", "integer": "int4range", "bigint": "int8range", "double precision": "numrange", "numeric": "numrange", "date": "daterange", "timestamp with time zone": "tstzrange", } postgres_operator = RangeOperators.CONTAINED_BY
- [6c9f88f0] class RangeContains(lookups.DataContains): def get_prep_lookup(self): if not isinstance(self.rhs, (list, tuple, Range)): return Cast(self.rhs, self.lhs.field.base_field) return super().get_prep_lookup()
- [3cdebd8f] class RangeField(CheckPostgresInstalledMixin, models.Field): empty_strings_allowed = False
- [d27a4097] class RangeOperators: # https://www.postgresql.org/docs/current/functions-range.html#RANGE-OPERATORS-TABLE EQUAL = "=" NOT_EQUAL = "<>" CONTAINS = "@>" CONTAINED_BY = "<@" OVERLAPS = "&&" FULLY_LT = "<<" FULLY_GT = ">>" NOT_LT = "&>" NOT_GT = "&<" ADJACENT_TO = "-|-"
- [fbb06f8b02770a61-2] from .utils import AttributeSetter
- [51668302] from django.contrib.postgres import forms, lookups from django.contrib.postgres.utils import CheckPostgresInstalledMixin from django.db import models from django.db.backends.postgresql.psycopg_any import ( DateRange, DateTimeTZRange, NumericRange, Range, ) from django.db.models.functions import Cast from django.db.models.lookups import PostgresOperatorLookup
- [50eb3337] import datetime import json
- [4ff8400c] models.DateField.register_lookup(RangeContainedBy) models.DateTimeField.register_lookup(RangeContainedBy) models.IntegerField.register_lookup(RangeContainedBy) models.FloatField.register_lookup(RangeContainedBy) models.DecimalField.register_lookup(RangeContainedBy)
