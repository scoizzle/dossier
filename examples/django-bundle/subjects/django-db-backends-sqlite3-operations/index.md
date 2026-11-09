# django/db/backends/sqlite3/operations

- Subject: django/db/backends/sqlite3/operations (id `f962e7c0-10f5-467f-90ff-2a140f53b8fa`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 18 of 53
- Conflicts: 0
- Gaps: 0

## Facts

- def converter(value, expression, connection): if value is not None: return self._create_decimal(value) [146b89ca]
- def converter(value, expression, connection): if value is not None: return self._create_decimal(value).quantize( quantize_value, context=expression.output_field.context ) [a7222365]
- # SQLite doesn't support tz-aware datetimes if timezone.is_aware(value): if settings.USE_TZ: value = timezone.make_naive(value, self.connection.timezone) else: raise ValueError( "SQLite backend does not support timezone-aware datetimes when " "USE_TZ is False." ) [ef95a73e]
- # SQLite doesn't support tz-aware datetimes if timezone.is_aware(value): raise ValueError("SQLite backend does not support timezone-aware times.") [fb524c30]
- else: [6ad07797f4838346-9]
- if len(params) > batch_size: results = () for index in range(0, len(params), batch_size): chunk = params[index : index + batch_size] results += self._quote_params_for_last_executed_query(chunk) return results [125acf7a]
- return converter [2995b642af280a57-6]
- return str(value) [45fffebe3606e85f]
- return str(value) [45fffebe3606e85f-2]
- sql = "SELECT " + ", ".join(["QUOTE(?)"] * len(params)) # Bypass Django's wrappers and use the underlying sqlite3 connection # to avoid logging this query - it would trigger infinite recursion. cursor = self.connection.connection.cursor() # Native sqlite3 cursors cannot be used as context managers. try: return cursor.execute(sql, params).fetchone() finally: cursor.close() [fe86e3eb]
- @cached_property def _references_graph(self): # 512 is large enough to fit the ~330 tables (as of this writing) in # Django's test suite. return lru_cache(maxsize=512)(self.__references_graph) [787db045]
- @staticmethod def _create_decimal(value): if isinstance(value, (int, str)): return decimal.Decimal(value) return decimal.Context(prec=15).create_decimal_from_float(value) [f48f2b82]
- def __references_graph(self, table_name): query = """ WITH tables AS ( SELECT %s name UNION SELECT sqlite_master.name FROM sqlite_master JOIN tables ON (sql REGEXP %s || tables.name || %s) ) SELECT name FROM tables; """ params = ( table_name, r'(?i)\s+references\s+("|\')?', r'("|\')?\s*\(', ) with self.connection.cursor() as cursor: results = cursor.execute(query, params) return [row[0] for row in results.fetchall()] [9410f8ec]
- def _convert_tznames_to_sql(self, tzname): if tzname and settings.USE_TZ: return tzname, self.connection.timezone_name return None, None [418e2702]
- def _quote_params_for_last_executed_query(self, params): """ Only for last_executed_query! Don't use this to execute SQL queries! """ connection = self.connection.connection variable_limit = self.connection.features.max_query_params column_limit = connection.getlimit(sqlite3.SQLITE_LIMIT_COLUMN) batch_size = min(variable_limit, column_limit) [d20c9624]
- def adapt_datetimefield_value(self, value): if value is None: return None [e492a81a53966237-2]
- def adapt_timefield_value(self, value): if value is None: return None [36c6da6fa0266bb9-3]
- def force_group_by(self): return ["GROUP BY TRUE"] if Database.sqlite_version_info < (3, 39) else [] [7a08e1cb]

## Beyond the budget

32 more facts did not fit in the budget: [b13d925a] [4eaa55bf] [51dcee62] [d57529dc] [f99ea6c6] [975116ae] [d15ada11] [e6ed82d78972eefd-3] [221d7c9c] [6661aec9] [9c369371] [5c71d778] [4c7620fb] [6129f0e0] [d1afbd3d] [f9086fdf] [0d531e4d] [1308d35f] [5f4d2bec] [ee296ecc] [c2d353c3] [16b23464df2517ba-3] [56717133c906feab-2] [2caefbdc] [b95418e0] [06464a81] [c7afeb11] [788ab083] [b0e3a0b6] [26c8dfb3c93f7ac3-3] [de977ceb] [ba978c39]
