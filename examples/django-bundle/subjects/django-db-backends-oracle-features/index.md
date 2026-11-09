# django/db/backends/oracle/features

- Subject: django/db/backends/oracle/features (id `00364002-12e5-4aef-9905-0cfe731e8250`)
- Kind: subject
- Budget: 1200 tokens
- Used: 894 tokens
- Facts shown: 6 of 18
- Conflicts: 0
- Gaps: 0

## Facts

- @cached_property def bare_select_suffix(self): return "" if self.connection.oracle_version >= (23,) else " FROM DUAL" [1fd77733]
- @cached_property def django_test_skips(self): skips = { "Oracle doesn't support SHA224.": { "db_functions.text.test_sha224.SHA224Tests.test_basic", "db_functions.text.test_sha224.SHA224Tests.test_transform", }, "Oracle doesn't correctly calculate ISO 8601 week numbering before " "1583 (the Gregorian calendar was introduced in 1582).": { "db_functions.datetime.test_extract_trunc.DateFunctionTests." "test_trunc_week_before_1000", "db_functions.datetime.test_extract_trunc." "DateFunctionWithTimeZoneTests.test_trunc_week_before_1000", }, "Oracle doesn't support bitwise XOR.": { "expressions.tests.ExpressionOperatorTests.test_lefthand_bitwise_xor", "expressions.tests.ExpressionOperatorTests." "test_lefthand_bitwise_xor_null", "expressions.tests.ExpressionOperatorTests." "test_lefthand_bitwise_xor_right_null", }, "Oracle requires ORDER BY in row_number, ANSI:SQL doesn't.": { "expressions_window.tests.WindowFunctionTests." "test_row_number_no_ordering", "prefetch_related.tests.PrefetchLimitTests.test_empty_order", }, "Oracle doesn't support changing collations on indexed columns (#33671).": { "migrations.test_operations.OperationTests." "test_alter_field_pk_fk_db_collation", }, "Oracle doesn't support comparing NCLOB to NUMBER.": { "generic_relations_regress.tests.GenericRelationTests." "test_textlink_filter", }, "Oracle doesn't support casting filters to NUMBER.": { "lookup.tests.LookupQueryingTests.test_aggregate_combined_lookup", }, "Oracle doesn't support some data types (e.g. BOOLEAN, BLOB) in " "GeneratedField expressions (ORA-54003).": { "schema.tests.SchemaTests.test_add_generated_field_contains", "schema.tests.SchemaTests.test_add_generated_field_with_kt_model", }, } if self.connection.oracle_version < (23,): skips.update( { "Raises ORA-00600 on Oracle < 23c: internal error code.": { "model_fields.test_jsonfield.TestQuerying." "test_usage_in_subquery", }, } ) if self.connection.is_pool: skips.update( { "Pooling does not support persistent connections": { "backends.base.test_base.ConnectionHealthChecksTests." "test_health_checks_enabled", "backends.base.test_base.ConnectionHealthChecksTests." "test_health_checks_enabled_errors_occurred", "backends.base.test_base.ConnectionHealthChecksTests." "test_health_checks_disabled", "backends.base.test_base.ConnectionHealthChecksTests." "test_set_autocommit_health_checks_enabled", "servers.tests.LiveServerTestCloseConnectionTest." "test_closes_connections", "backends.oracle.tests.TransactionalTests." "test_password_with_at_sign", }, } ) return skips [a2d1b639]
- @cached_property def introspected_field_types(self): return { **super().introspected_field_types, "GenericIPAddressField": "CharField", "PositiveBigIntegerField": "BigIntegerField", "PositiveIntegerField": "IntegerField", "PositiveSmallIntegerField": "IntegerField", "SmallIntegerField": "IntegerField", "TimeField": "DateTimeField", } [ab088ef3]
- @cached_property def supports_aggregation_over_interval_types(self): return self.connection.oracle_version >= (23,) [bd2a3131]
- @cached_property def supports_bit_aggregations(self): return self.connection.oracle_version >= (21,) [338c8b2e]
- @cached_property def supports_boolean_expr_in_select_clause(self): return self.connection.oracle_version >= (23,) [29388499]

## Beyond the budget

12 more facts did not fit in the budget: [2f46ffc0] [7744962e] [7c7b5846] [85ab2c92] [5accc980] [38d0af10] [498775b0] [a20cff08] [c7fce4d6] [9763478c] [35256279] [e18fb27c]
