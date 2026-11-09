# django/db/models/functions/json

- Subject: django/db/models/functions/json (id `dfd39456-8103-4b04-9081-6e22a38cc9cc`)
- Kind: subject
- Budget: 1200 tokens
- Used: 874 tokens
- Facts shown: 13 of 18
- Conflicts: 0
- Gaps: 0

## Facts

- if connection.features.is_postgresql_16: return casted_obj.as_native( compiler, connection, returning="JSONB", **extra_context ) [38e0df72]
- if connection.features.is_postgresql_16: return copy.as_native( compiler, connection, returning="JSONB", **extra_context ) [f8ba0b9d]
- return casted_obj.as_sql( compiler, connection, function="JSONB_BUILD_ARRAY", **extra_context, ) [b7efadc2]
- return self.as_sql( compiler, connection, template=( f"%(function)s(%(expressions)s {null_on_null} RETURNING {returning})" ), **extra_context, ) [69130d37]
- return super(JSONObject, copy).as_sql( compiler, connection, function="JSONB_BUILD_OBJECT", **extra_context, ) [677b0576]
- def __init__(self, **fields): expressions = [] for key, value in fields.items(): expressions.extend((Value(key), value)) super().__init__(*expressions) [a8b19ff8]
- def as_native(self, compiler, connection, *, returning, **extra_context): # PostgreSQL 16+ and Oracle remove SQL NULL values from the array by # default. Adds the NULL ON NULL clause to keep NULL values in the # array, mapping them to JSON null values, which matches the behavior # of SQLite. null_on_null = "NULL ON NULL" if len(self.get_source_expressions()) > 0 else "" [e9b43738]
- def as_native(self, compiler, connection, *, returning, **extra_context): return self.as_sql( compiler, connection, arg_joiner=self, template=f"%(function)s(%(expressions)s RETURNING {returning})", **extra_context, ) [29f88813]
- def as_oracle(self, compiler, connection, **extra_context): return self.as_native(compiler, connection, returning="CLOB", **extra_context) [1f352e3f4d87fe5d]
- def as_postgresql(self, compiler, connection, **extra_context): # Casting keys to text is only required when using JSONB_BUILD_OBJECT # or when using JSON_OBJECT on PostgreSQL 16+ with server-side # bindings. This is done in all cases for consistency. copy = self.copy() copy.set_source_expressions( [ Cast(expression, TextField()) if index % 2 == 0 else expression for index, expression in enumerate(copy.get_source_expressions()) ] ) [58682c58]
- def as_postgresql(self, compiler, connection, **extra_context): # Casting source expressions is only required using JSONB_BUILD_ARRAY # or when using JSON_ARRAY on PostgreSQL 16+ with server-side bindings. # This is done in all cases for consistency. casted_obj = self.copy() casted_obj.set_source_expressions( [ ( # Conditional Cast to avoid unnecessary wrapping. expression if isinstance(expression, Cast) else Cast(expression, expression.output_field) ) for expression in casted_obj.get_source_expressions() ] ) [2808012d]
- def as_sql(self, compiler, connection, **extra_context): if not connection.features.has_json_object_function: raise NotSupportedError( "JSONObject() is not supported on this database backend." ) return super().as_sql(compiler, connection, **extra_context) [0df22af8]
- def as_sql(self, compiler, connection, **extra_context): if not connection.features.supports_json_field: raise NotSupportedError( "JSONFields are not supported on this database backend." ) return super().as_sql(compiler, connection, **extra_context) [d365bd3a]

## Beyond the budget

4 more facts did not fit in the budget: [2b29c57b] [b9170ae1] [3a7683d4] [aded3981]
