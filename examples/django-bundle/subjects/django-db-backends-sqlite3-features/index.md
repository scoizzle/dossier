# django/db/backends/sqlite3/features

- Subject: django/db/backends/sqlite3/features (id `a3b4fbef-9a9e-4a3b-9cbf-7564b6c9cd20`)
- Kind: subject
- Budget: 1200 tokens
- Used: 874 tokens
- Facts shown: 7 of 10
- Conflicts: 0
- Gaps: 0

## Facts

- @cached_property def django_test_skips(self): skips = { "SQLite stores values rounded to 15 significant digits.": { "model_fields.test_decimalfield.DecimalFieldTests." "test_fetch_from_db_without_float_rounding", }, "SQLite naively remakes the table on field alteration.": { "schema.tests.SchemaTests.test_unique_no_unnecessary_fk_drops", "schema.tests.SchemaTests.test_unique_and_reverse_m2m", "schema.tests.SchemaTests." "test_alter_field_default_doesnt_perform_queries", "schema.tests.SchemaTests." "test_rename_column_renames_deferred_sql_references", }, "SQLite doesn't support negative precision for ROUND().": { "db_functions.math.test_round.RoundTests." "test_null_with_negative_precision", "db_functions.math.test_round.RoundTests." "test_decimal_with_negative_precision", "db_functions.math.test_round.RoundTests." "test_float_with_negative_precision", "db_functions.math.test_round.RoundTests." "test_integer_with_negative_precision", }, "The actual query cannot be determined on SQLite": { "backends.base.test_base.ExecuteWrapperTests.test_wrapper_debug", }, } if self.connection.is_in_memory_db(): skips.update( { "the sqlite backend's close() method is a no-op when using an " "in-memory database": { "servers.test_liveserverthread.LiveServerThreadTest." "test_closes_connections", "servers.tests.LiveServerTestCloseConnectionTest." "test_closes_connections", }, "For SQLite in-memory tests, closing the connection destroys " "the database.": { "test_utils.tests.AssertNumQueriesUponConnectionTests." "test_ignores_connection_configuration_queries", }, } ) else: skips.update( { "Only connections to in-memory SQLite databases are passed to the " "server thread.": { "servers.tests.LiveServerInMemoryDatabaseLockTest." "test_in_memory_database_lock", }, "multiprocessing's start method is checked only for in-memory " "SQLite databases": { "backends.sqlite.test_creation.TestDbSignatureTests." "test_get_test_db_clone_settings_not_supported", }, } ) if Database.sqlite_version_info < (3, 47): skips.update( { "SQLite does not parse escaped double quotes in the JSON path " "notation": { "model_fields.test_jsonfield.TestQuerying." "test_lookups_special_chars_double_quotes", }, } ) return skips [912c9705]
- @cached_property def introspected_field_types(self): return { **super().introspected_field_types, "BigAutoField": "AutoField", "DurationField": "BigIntegerField", "GenericIPAddressField": "CharField", "SmallAutoField": "AutoField", } [d38fbb2e]
- @cached_property def supports_json_field(self): with self.connection.cursor() as cursor: try: with transaction.atomic(self.connection.alias): cursor.execute('SELECT JSON(\'{"a": "b"}\')') except OperationalError: return False return True [635b112e]
- @cached_property def supports_uuid7_function(self): return PY314 [4e698fac]
- @property def max_query_params(self): """ SQLite has a variable limit per query. The limit can be changed using the SQLITE_MAX_VARIABLE_NUMBER compile-time option (which defaults to 32766) or lowered per connection at run-time with setlimit(SQLITE_LIMIT_VARIABLE_NUMBER, N). """ self.connection.ensure_connection() return self.connection.connection.getlimit(sqlite3.SQLITE_LIMIT_VARIABLE_NUMBER) [059bba50]
- from .base import Database [26c8dfb3c93f7ac3-2]
- import operator import sqlite3 [b5f84597]

## Beyond the budget

3 more facts did not fit in the budget: [9df6712e] [9b1c17c7] [99859b44]
