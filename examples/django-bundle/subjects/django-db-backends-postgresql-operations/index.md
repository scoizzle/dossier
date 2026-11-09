# django/db/backends/postgresql/operations

- Subject: django/db/backends/postgresql/operations (id `479ab3b7-9ef1-4da3-a6d4-8d4095032b48`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 3505 tokens
- Facts shown: 57 of 59
- Conflicts: 0
- Gaps: 0

## Highlights

- for f in model._meta.local_fields: if isinstance(f, models.AutoField): output.append( "%s setval(pg_get_serial_sequence('%s','%s'), " "coalesce(max(%s), 1), max(%s) %s null) %s %s;" % ( style.SQL_KEYWORD("SELECT"), style.SQL_TABLE(qn(model._meta.db_table)), style.SQL_FIELD(f.column), style.SQL_FIELD(qn(f.column)), style.SQL_FIELD(qn(f.column)), style.SQL_KEYWORD("IS NOT"), style.SQL_KEYWORD("FROM"), style.SQL_TABLE(qn(model._meta.db_table)), ) ) # Only one AutoField is allowed per model, so don't bother # continuing. break return output [02276b3d]
- # Perform a single SQL 'TRUNCATE x, y, z...;' statement. It allows us # to truncate tables referenced by a foreign key in any other table. sql_parts = [ style.SQL_KEYWORD("TRUNCATE"), ", ".join(style.SQL_FIELD(self.quote_name(table)) for table in tables), ] if reset_sequences: sql_parts.append(style.SQL_KEYWORD("RESTART IDENTITY")) if allow_cascade: sql_parts.append(style.SQL_KEYWORD("CASCADE")) return ["%s;" % " ".join(sql_parts)] [c0fe4063]
- # Use UPPER(x) for case-insensitive lookups; it's faster. if lookup_type in ("iexact", "icontains", "istartswith", "iendswith"): lookup = "UPPER(%s)" % lookup [e0831027]
- The maximum length of an identifier is 63 by default, but can be changed by recompiling PostgreSQL after editing the NAMEDATALEN macro in src/include/pg_config_manual.h. [24e6516e]
- This implementation returns 63, but can be overridden by a custom database backend that inherits most of its behavior from this one. """ return 63 [4ccf41e2]
- def adapt_integerfield_value(self, value, internal_type): if value is None or hasattr(value, "resolve_expression"): return value return self.integerfield_type_map[internal_type](value) [8b74e535]
- def last_executed_query(self, cursor, sql, params): # https://www.psycopg.org/docs/cursor.html#cursor.query # The query attribute is a Psycopg extension to the DB API 2.0. if cursor.query is not None: return cursor.query.decode() return super().last_executed_query(cursor, sql, params) [a7798647]
- def last_executed_query(self, cursor, sql, params): if self.connection.features.uses_server_side_binding: try: return self.compose_sql(sql, params) except errors.DataError: return super().last_executed_query(cursor, sql, params) else: if cursor._query and cursor._query.query is not None: return cursor._query.query.decode() return super().last_executed_query(cursor, sql, params) [fea11286]
- if lhs_field.db_type(self.connection) != rhs_field.db_type(self.connection): rhs_expr = Cast(rhs_expr, lhs_field) [add747f0]
- integerfield_type_map = { "SmallIntegerField": numeric.Int2, "IntegerField": numeric.Int4, "BigIntegerField": numeric.Int8, "PositiveSmallIntegerField": numeric.Int2, "PositiveIntegerField": numeric.Int4, "PositiveBigIntegerField": numeric.Int8, } [7e4bf0d6]
- lookup_type = lookup_type.upper() if not self._extract_format_re.fullmatch(lookup_type): raise ValueError(f"Invalid lookup type: {lookup_type!r}") return f"EXTRACT({lookup_type} FROM {sql})", params [4cb9d9ed]
- return lhs_expr, rhs_expr [1849b7cfcb9ddfbd-2]
- return lookup [4d73864c6d42a08b]
- # EXTRACT format cannot be passed in parameters. _extract_format_re = _lazy_re_compile(r"[A-Z_]+") [d51ce70b9c1630cd-3]

## All facts

- [0ac8cda8] output = [] qn = self.quote_name for model in model_list: # Use `coalesce` to set the sequence for each model to the max pk # value if there are records, or 1 if there are none. Set the # `is_called` property (the third argument to `setval`) to true if # there are records (as the max pk value is already in use), # otherwise set it to false. Use pg_get_serial_sequence to get the # underlying sequence name from the table name and column name.
- [c6b43924] def _convert_sql_to_tz(self, sql, params, tzname): if tzname and settings.USE_TZ: tzname_param = self._prepare_tzname_delta(tzname) return f"{sql} AT TIME ZONE %s", (*params, tzname_param) return sql, params
- [f5f294ce] def _prepare_tzname_delta(self, tzname): tzname, sign, offset = split_tzname_delta(tzname) if offset: sign = "-" if sign == "+" else "+" return f"{tzname}{sign}{offset}" return tzname
- [397fd3af] def adapt_datefield_value(self, value): return value
- [9475863d] def adapt_datetimefield_value(self, value): return value
- [1466fe300f8d56b4-2] def adapt_durationfield_value(self, value): return value
- [435b5ea5] def adapt_ipaddressfield_value(self, value): if value: return Inet(value) return None
- [d3120c31] def adapt_json_value(self, value, encoder): return Jsonb(value, dumps=get_json_dumps(encoder))
- [934d54bd] def adapt_timefield_value(self, value): return value
- [0c25c0f0] def bulk_insert_sql(self, fields, placeholder_rows): if isinstance(placeholder_rows, InsertUnnest): return f"SELECT * FROM {placeholder_rows}" return super().bulk_insert_sql(fields, placeholder_rows)
- [07e2deff] def compose_sql(self, sql, params): return mogrify(sql, params, self.connection)
- [d16d8d8e] def date_extract_sql(self, lookup_type, sql, params): # https://www.postgresql.org/docs/current/functions-datetime.html#FUNCTIONS-DATETIME-EXTRACT if lookup_type == "week_day": # For consistency across backends, we return Sunday=1, Saturday=7. return f"EXTRACT(DOW FROM {sql}) + 1", params elif lookup_type == "iso_week_day": return f"EXTRACT(ISODOW FROM {sql})", params elif lookup_type == "iso_year": return f"EXTRACT(ISOYEAR FROM {sql})", params
- [d3530cc7] def date_trunc_sql(self, lookup_type, sql, params, tzname=None): sql, params = self._convert_sql_to_tz(sql, params, tzname) # https://www.postgresql.org/docs/current/functions-datetime.html#FUNCTIONS-DATETIME-TRUNC return f"DATE_TRUNC(%s, {sql})", (lookup_type, *params)
- [87c4c0eb] def datetime_cast_date_sql(self, sql, params, tzname): sql, params = self._convert_sql_to_tz(sql, params, tzname) return f"({sql})::date", params
- [19cbe634] def datetime_extract_sql(self, lookup_type, sql, params, tzname): sql, params = self._convert_sql_to_tz(sql, params, tzname) if lookup_type == "second": # Truncate fractional seconds. return f"EXTRACT(SECOND FROM DATE_TRUNC(%s, {sql}))", ("second", *params) return self.date_extract_sql(lookup_type, sql, params)
- [9fdf550584590da8-2] def deferrable_sql(self): return " DEFERRABLE INITIALLY DEFERRED"
- [e5a0a490] def distinct_sql(self, fields, params): if fields: params = [param for param_list in params for param in param_list] return (["DISTINCT ON (%s)" % ", ".join(fields)], params) else: return ["DISTINCT"], []
- [05608ac3] def explain_query_prefix(self, format=None, **options): extra = {} if serialize := options.pop("serialize", None): if serialize.upper() in {"TEXT", "BINARY"}: extra["SERIALIZE"] = serialize.upper() # Normalize options. if options: options = { name.upper(): "true" if value else "false" for name, value in options.items() } for valid_option in self.explain_options: value = options.pop(valid_option, None) if value is not None: extra[valid_option] = value prefix = super().explain_query_prefix(format, **options) if format: extra["FORMAT"] = format if extra: prefix += " (%s)" % ", ".join("%s %s" % i for i in extra.items()) return prefix
- [0d5caa2a] def lookup_cast(self, lookup_type, internal_type=None): lookup = "%s" # Cast text lookups to text to allow things like filter(x__contains=4) if lookup_type in ( "iexact", "contains", "icontains", "startswith", "istartswith", "endswith", "iendswith", "regex", "iregex", ): if internal_type in ("IPAddressField", "GenericIPAddressField"): lookup = "HOST(%s)" else: lookup = "%s::text"
- [d6317b30] def max_name_length(self): """ Return the maximum length of an identifier.
- [6110e0c140984a1d-2] def no_limit_value(self): return None
- [f082a566] def on_conflict_suffix_sql(self, fields, on_conflict, update_fields, unique_fields): if on_conflict == OnConflict.IGNORE: return "ON CONFLICT DO NOTHING" if on_conflict == OnConflict.UPDATE: return "ON CONFLICT(%s) DO UPDATE SET %s" % ( ", ".join(map(self.quote_name, unique_fields)), ", ".join( [ f"{field} = EXCLUDED.{field}" for field in map(self.quote_name, update_fields) ] ), ) return super().on_conflict_suffix_sql( fields, on_conflict, update_fields, unique_fields, )
- [e55834a68bf49ab9-2] def prep_for_iexact_query(self, x): return x
- [b7450f79] def prepare_join_on_clause(self, lhs_table, lhs_field, rhs_table, rhs_field): lhs_expr, rhs_expr = super().prepare_join_on_clause( lhs_table, lhs_field, rhs_table, rhs_field )
- [6c3f5d48] def prepare_sql_script(self, sql): return [sql]
- [56717133c906feab] def quote_name(self, name): if name.startswith('"') and name.endswith('"'): return name # Quoting once is enough. return '"%s"' % name
- [42eb2e11] def sequence_reset_by_name_sql(self, style, sequences): # 'ALTER SEQUENCE sequence_name RESTART WITH 1;'... style SQL # statements to reset sequence indices sql = [] for sequence_info in sequences: table_name = sequence_info["table"] # 'id' will be the case if it's an m2m using an autogenerated # intermediate table (see BaseDatabaseIntrospection.sequence_list). column_name = sequence_info["column"] or "id" sql.append( "%s setval(pg_get_serial_sequence('%s','%s'), 1, false);" % ( style.SQL_KEYWORD("SELECT"), style.SQL_TABLE(self.quote_name(table_name)), style.SQL_FIELD(column_name), ) ) return sql
- [88b1ec53] def sequence_reset_sql(self, style, model_list): from django.db import models
- [a8ce4d75] def set_time_zone_sql(self): return "SELECT set_config('TimeZone', %s, false)"
- [d6b2815e1ddcc509-3] def sql_flush(self, style, tables, *, reset_sequences=False, allow_cascade=False): if not tables: return []
- [fe00780a] def subtract_temporals(self, internal_type, lhs, rhs): if internal_type == "DateField": lhs_sql, lhs_params = lhs rhs_sql, rhs_params = rhs params = (*lhs_params, *rhs_params) return "(interval '1 day' * (%s - %s))" % (lhs_sql, rhs_sql), params return super().subtract_temporals(internal_type, lhs, rhs)
- [2aac8c59021c4801-2] def tablespace_sql(self, tablespace, inline=False): if inline: return "USING INDEX TABLESPACE %s" % self.quote_name(tablespace) else: return "TABLESPACE %s" % self.quote_name(tablespace)
- [c656e060] def time_extract_sql(self, lookup_type, sql, params): if lookup_type == "second": # Truncate fractional seconds. return f"EXTRACT(SECOND FROM DATE_TRUNC(%s, {sql}))", ("second", *params) return self.date_extract_sql(lookup_type, sql, params)
- [4f41199e] def time_trunc_sql(self, lookup_type, sql, params, tzname=None): sql, params = self._convert_sql_to_tz(sql, params, tzname) return f"DATE_TRUNC(%s, {sql})::time", (lookup_type, *params)
- [b89a601f] def unification_cast_sql(self, output_field): internal_type = output_field.get_internal_type() if internal_type in ( "GenericIPAddressField", "IPAddressField", "TimeField", "UUIDField", ): # PostgreSQL will resolve a union as type 'text' if input types are # 'unknown'. # https://www.postgresql.org/docs/current/typeconv-union-case.html # These fields cannot be implicitly cast back in the default # PostgreSQL configuration so we need to explicitly cast them. # We must also remove components of the type within brackets: # varchar(255) -> varchar. return ( "CAST(%%s AS %s)" % output_field.db_type(self.connection).split("(")[0] ) return "%s"
- [6ad07797f4838346-8] else:
- [d71a6fba044908db-3] if is_psycopg3:
- [d71a6fba044908db-4] if is_psycopg3:
- [07807fb4] if is_psycopg3: from psycopg.types import numeric
- [f964afc0] @lru_cache def get_json_dumps(encoder): if encoder is None: return json.dumps return partial(json.dumps, cls=encoder)
- [4e723ce9] class DatabaseOperations(BaseDatabaseOperations): compiler_module = "django.db.backends.postgresql.compiler" cast_char_field_without_max_length = "varchar" explain_prefix = "EXPLAIN" explain_options = frozenset( [ "ANALYZE", "BUFFERS", "COSTS", "GENERIC_PLAN", "MEMORY", "SETTINGS", "SERIALIZE", "SUMMARY", "TIMING", "VERBOSE", "WAL", ] ) cast_data_types = { "AutoField": "integer", "BigAutoField": "bigint", "SmallAutoField": "smallint", }
- [8e0f175d] from django.conf import settings from django.db.backends.base.operations import BaseDatabaseOperations from django.db.backends.postgresql.compiler import InsertUnnest from django.db.backends.postgresql.psycopg_any import ( Inet, Jsonb, errors, is_psycopg3, mogrify, ) from django.db.backends.utils import split_tzname_delta from django.db.models.constants import OnConflict from django.db.models.functions import Cast from django.utils.regex_helper import _lazy_re_compile
- [b20b6b4c] import json from functools import lru_cache, partial
