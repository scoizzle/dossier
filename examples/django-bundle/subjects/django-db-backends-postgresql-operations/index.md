# django/db/backends/postgresql/operations

- Subject: django/db/backends/postgresql/operations (id `481b7e4a-11b5-4ec6-9714-c9c631cb9fb3`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 14 of 59
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

43 more facts did not fit in the budget: [0ac8cda8] [c6b43924] [f5f294ce] [397fd3af] [9475863d] [1466fe300f8d56b4-2] [435b5ea5] [d3120c31] [934d54bd] [0c25c0f0] [07e2deff] [d16d8d8e] [d3530cc7] [87c4c0eb] [19cbe634] [9fdf550584590da8-2] [e5a0a490] [05608ac3] [0d5caa2a] [d6317b30] [6110e0c140984a1d-2] [f082a566] [e55834a68bf49ab9-2] [b7450f79] [6c3f5d48] [56717133c906feab] [42eb2e11] [88b1ec53] [a8ce4d75] [d6b2815e1ddcc509-3] [fe00780a] [2aac8c59021c4801-2] [c656e060] [4f41199e] [b89a601f] [6ad07797f4838346-8] [d71a6fba044908db-3] [d71a6fba044908db-4] [07807fb4] [f964afc0] [4e723ce9] [8e0f175d] [b20b6b4c]
