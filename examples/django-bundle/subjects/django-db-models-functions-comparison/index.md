# django/db/models/functions/comparison

- Subject: django/db/models/functions/comparison (id `523134d7-ce64-441a-b942-aaeb8b7dccca`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1535 tokens
- Facts shown: 26 of 30
- Conflicts: 0
- Gaps: 0

## Highlights

- @property def empty_result_set_value(self): for expression in self.get_source_expressions(): result = expression.empty_result_set_value if result is NotImplemented or result is not None: return result return None [dc6af824]
- If any expression is null the return value is database-specific: On PostgreSQL, return the minimum not-null expression. On MySQL, Oracle, and SQLite, if any expression is null, return null. """ [2af06497]
- def __init__(self, *expressions, **extra): if len(expressions) < 2: raise ValueError("Coalesce must take at least two expressions") super().__init__(*expressions, **extra) [75fed8e8]
- def __init__(self, expression, collation): if not (collation and self.collation_re.match(collation)): raise ValueError("Invalid collation name: %r." % collation) self.collation = collation super().__init__(expression) [08596f1b]
- def __init__(self, expression, output_field): super().__init__(expression, output_field=output_field) [df6df578]
- def as_mysql(self, compiler, connection, **extra_context): template = None output_type = self.output_field.get_internal_type() # MySQL doesn't support explicit cast to float. if output_type == "FloatField": template = "(%(expressions)s + 0.0)" # MariaDB doesn't support explicit cast to JSON. elif output_type == "JSONField" and connection.mysql_is_mariadb: template = "JSON_EXTRACT(%(expressions)s, '$')" return self.as_sql(compiler, connection, template=template, **extra_context) [21e668dd]
- def as_oracle(self, compiler, connection, **extra_context): # Oracle prohibits mixing TextField, JSONField (NCLOB) and CharField # (NVARCHAR2), so convert all fields to NCLOB when that type is # expected. if self.output_field.get_internal_type() in ("TextField", "JSONField"): clone = self.copy() clone.set_source_expressions( [ Func(expression, function="TO_NCLOB") for expression in self.get_source_expressions() ] ) return super(Coalesce, clone).as_sql(compiler, connection, **extra_context) return self.as_sql(compiler, connection, **extra_context) [183d8c71]
- def as_oracle(self, compiler, connection, **extra_context): expression1 = self.get_source_expressions()[0] if isinstance(expression1, Value) and expression1.value is None: raise ValueError("Oracle does not allow Value(None) for expression1.") return super().as_sql(compiler, connection, **extra_context) [1f6e74df]
- def as_oracle(self, compiler, connection, **extra_context): if self.output_field.get_internal_type() == "JSONField": # Oracle doesn't support explicit cast to JSON. template = "JSON_QUERY(%(expressions)s, '$')" return super().as_sql( compiler, connection, template=template, **extra_context ) return self.as_sql(compiler, connection, **extra_context) [5d43cf41]
- def as_postgresql(self, compiler, connection, **extra_context): # CAST would be valid too, but the :: shortcut syntax is more readable. # 'expressions' is wrapped in parentheses in case it's a complex # expression. return self.as_sql( compiler, connection, template="(%(expressions)s)::%(db_type)s", **extra_context, ) [b9731695]
- def as_sql(self, compiler, connection, **extra_context): extra_context.setdefault("collation", connection.ops.quote_name(self.collation)) return super().as_sql(compiler, connection, **extra_context) [74000075]

## All facts

- [9d4ea474] def as_sql(self, compiler, connection, **extra_context): extra_context["db_type"] = self.output_field.cast_db_type(connection) return super().as_sql(compiler, connection, **extra_context)
- [9005c537] def as_sqlite(self, compiler, connection, **extra_context): """Use the MAX function on SQLite.""" return super().as_sqlite(compiler, connection, function="MAX", **extra_context)
- [3f07f3bc] def as_sqlite(self, compiler, connection, **extra_context): db_type = self.output_field.db_type(connection) if db_type in {"datetime", "time"}: # Use strftime as datetime/time don't keep fractional seconds. template = "strftime(%%s, %(expressions)s)" sql, params = super().as_sql( compiler, connection, template=template, **extra_context ) format_string = "%H:%M:%f" if db_type == "time" else "%Y-%m-%d %H:%M:%f" params = (format_string, *params) return sql, params elif db_type == "date": template = "date(%(expressions)s)" return super().as_sql( compiler, connection, template=template, **extra_context ) return self.as_sql(compiler, connection, **extra_context)
- [0129fae9] function = "CAST" template = "%(function)s(%(expressions)s AS %(db_type)s)"
- [c7514cc4] function = "COALESCE"
- [6f371052] function = "GREATEST"
- [5140f26e] function = "LEAST"
- [f5caa2cc] """Database functions that do comparisons or type conversions."""
- [9e2466d1] class Cast(Func): """Coerce an expression to a new field type."""
- [b1943029] class Coalesce(Func): """Return, from left to right, the first non-null expression."""
- [d35ce249] class Collate(Func): function = "COLLATE" template = "%(expressions)s %(function)s %(collation)s" allowed_default = False # Inspired from # https://www.postgresql.org/docs/current/sql-syntax-lexical.html#SQL-SYNTAX-IDENTIFIERS collation_re = _lazy_re_compile(r"^[\w-]+$")
- [3e461fea] class Greatest(Func): """ Return the maximum expression.
- [46da16c0] class Least(Func): """ Return the minimum expression.
- [f135a0b7] class NullIf(Func): function = "NULLIF" arity = 2
- [3f7a1917] from django.db.models.expressions import Func, Value from django.utils.regex_helper import _lazy_re_compile
