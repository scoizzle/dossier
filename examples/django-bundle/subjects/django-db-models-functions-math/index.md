# django/db/models/functions/math

- Subject: django/db/models/functions/math (id `65b5b94a-68c0-4a17-947f-460b7ced314e`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1618 tokens
- Facts shown: 37 of 39
- Conflicts: 0
- Gaps: 0

## Highlights

- def __init__(self, expression, precision=0, **extra): super().__init__(expression, precision, **extra) [bfd1a48a]
- def _resolve_output_field(self): source = self.get_source_expressions()[0] return source.output_field [66e3a0ac]
- def as_mysql(self, compiler, connection, **extra_context): return super().as_sql(compiler, connection, function="RAND", **extra_context) [c279e452]
- def as_oracle(self, compiler, connection, **extra_context): return super().as_sql( compiler, connection, template="((%%(expressions)s) * %s / 180)" % math.pi, **extra_context, ) [2700b4f9]
- def as_oracle(self, compiler, connection, **extra_context): return super().as_sql( compiler, connection, function="DBMS_RANDOM.VALUE", **extra_context ) [c3fe369b]
- def as_oracle(self, compiler, connection, **extra_context): return super().as_sql( compiler, connection, template="(1 / TAN(%(expressions)s))", **extra_context ) [b9ff098d]
- def as_oracle(self, compiler, connection, **extra_context): return super().as_sql( compiler, connection, template=str(math.pi), **extra_context ) [362ba4b1]
- def as_oracle(self, compiler, connection, **extra_context): return super().as_sql(compiler, connection, function="CEIL", **extra_context) [722237da]
- def as_sqlite(self, compiler, connection, **extra_context): if not getattr( connection.ops, "spatialite", False ) or connection.ops.spatial_version >= (5, 0, 0): return self.as_sql(compiler, connection) # This function is usually ATan2(y, x), returning the inverse tangent # of y / x, but it's ATan2(x, y) on SpatiaLite < 5.0.0. # Cast integers to float to avoid inconsistent/buggy behavior if the # arguments are mixed between integer and float or decimal. # https://www.gaia-gis.it/fossil/libspatialite/tktview?name=0f72cca3a2 clone = self.copy() clone.set_source_expressions( [ ( Cast(expression, FloatField()) if isinstance(expression.output_field, IntegerField) else expression ) for expression in self.get_source_expressions()[::-1] ] ) return clone.as_sql(compiler, connection, **extra_context) [c164a0cc]
- def as_sqlite(self, compiler, connection, **extra_context): if not getattr(connection.ops, "spatialite", False): return self.as_sql(compiler, connection) # This function is usually Log(b, x) returning the logarithm of x to # the base b, but on SpatiaLite it's Log(x, b). clone = self.copy() clone.set_source_expressions(self.get_source_expressions()[::-1]) return clone.as_sql(compiler, connection, **extra_context) [e37e17aa]
- def as_sqlite(self, compiler, connection, **extra_context): precision = self.get_source_expressions()[1] if isinstance(precision, Value) and precision.value < 0: raise ValueError("SQLite does not support negative precision.") return super().as_sqlite(compiler, connection, **extra_context) [6629e41c]
- def get_group_by_cols(self): return [] [bcca889fb4987223-5]
- class ACos(NumericOutputFieldMixin, Transform): function = "ACOS" lookup_name = "acos" [a0409450]
- class ASin(NumericOutputFieldMixin, Transform): function = "ASIN" lookup_name = "asin" [302170c3]
- class ATan(NumericOutputFieldMixin, Transform): function = "ATAN" lookup_name = "atan" [4795fe26]

## All facts

- [96ff2667] class ATan2(NumericOutputFieldMixin, Func): function = "ATAN2" arity = 2
- [d9bfd32c] class Abs(Transform): function = "ABS" lookup_name = "abs"
- [5e6f41ba] class Ceil(Transform): function = "CEILING" lookup_name = "ceil"
- [bb98eec0] class Cos(NumericOutputFieldMixin, Transform): function = "COS" lookup_name = "cos"
- [85603439] class Cot(NumericOutputFieldMixin, Transform): function = "COT" lookup_name = "cot"
- [f043b48a] class Degrees(NumericOutputFieldMixin, Transform): function = "DEGREES" lookup_name = "degrees"
- [ca0de923] class Exp(NumericOutputFieldMixin, Transform): function = "EXP" lookup_name = "exp"
- [41abbba8] class Floor(Transform): function = "FLOOR" lookup_name = "floor"
- [2b2b8c0b] class Ln(NumericOutputFieldMixin, Transform): function = "LN" lookup_name = "ln"
- [96156613] class Log(FixDecimalInputMixin, NumericOutputFieldMixin, Func): function = "LOG" arity = 2
- [9c55ad7a] class Mod(FixDecimalInputMixin, NumericOutputFieldMixin, Func): function = "MOD" arity = 2
- [acf2daa7] class Pi(NumericOutputFieldMixin, Func): function = "PI" arity = 0
- [3126d37e] class Power(NumericOutputFieldMixin, Func): function = "POWER" arity = 2
- [358f4b7f] class Radians(NumericOutputFieldMixin, Transform): function = "RADIANS" lookup_name = "radians"
- [8ab194ce] class Random(NumericOutputFieldMixin, Func): function = "RANDOM" arity = 0
- [5e3530f4] class Round(FixDecimalInputMixin, Transform): function = "ROUND" lookup_name = "round" arity = None # Override Transform's arity=1 to enable passing precision.
- [808203db] class Sign(Transform): function = "SIGN" lookup_name = "sign"
- [803783e7] class Sin(NumericOutputFieldMixin, Transform): function = "SIN" lookup_name = "sin"
- [653816af] class Sqrt(NumericOutputFieldMixin, Transform): function = "SQRT" lookup_name = "sqrt"
- [7d468dd6] class Tan(NumericOutputFieldMixin, Transform): function = "TAN" lookup_name = "tan"
- [f8d43b2b] from django.db.models.expressions import Func, Value from django.db.models.fields import FloatField, IntegerField from django.db.models.functions import Cast from django.db.models.functions.mixins import ( FixDecimalInputMixin, NumericOutputFieldMixin, ) from django.db.models.lookups import Transform
- [b2f41a46] import math
