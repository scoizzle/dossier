# django/db/models/functions/math

- Subject: django/db/models/functions/math (id `bf89c979-7f56-44bf-878d-7fdc81f4e6f4`)
- Kind: subject
- Budget: 1200 tokens
- Used: 889 tokens
- Facts shown: 15 of 39
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

22 more facts did not fit in the budget: [96ff2667] [d9bfd32c] [5e6f41ba] [bb98eec0] [85603439] [f043b48a] [ca0de923] [41abbba8] [2b2b8c0b] [96156613] [9c55ad7a] [acf2daa7] [3126d37e] [358f4b7f] [8ab194ce] [5e3530f4] [808203db] [803783e7] [653816af] [7d468dd6] [f8d43b2b] [b2f41a46]
