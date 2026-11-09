# django/db/backends/postgresql/features

- Subject: django/db/backends/postgresql/features (id `1bae7dde-f611-4745-82e4-151bfd845642`)
- Kind: subject
- Budget: 1200 tokens
- Used: 849 tokens
- Facts shown: 12 of 15
- Conflicts: 0
- Gaps: 0

## Facts

- @cached_property def django_test_expected_failures(self): expected_failures = set() if self.uses_server_side_binding: expected_failures.update( { # Parameters passed to expressions in SELECT and GROUP BY # clauses are not recognized as the same values when using # server-side binding cursors (#34255). "aggregation.tests.AggregateTestCase." "test_group_by_nested_expression_with_params", } ) if not is_psycopg3: expected_failures.update( { # operator does not exist: bigint[] = integer[] "postgres_tests.test_array.TestQuerying.test_gt", "postgres_tests.test_array.TestQuerying.test_in", "postgres_tests.test_array.TestQuerying.test_lt", } ) return expected_failures [0a08d8d2]
- @cached_property def django_test_skips(self): skips = { "opclasses are PostgreSQL only.": { "indexes.tests.SchemaIndexesNotPostgreSQLTests." "test_create_index_ignores_opclasses", }, "PostgreSQL requires casting to text.": { "lookup.tests.LookupTests.test_textfield_exact_null", }, } if self.connection.settings_dict["OPTIONS"].get("pool"): skips.update( { "Pool does implicit health checks": { "backends.base.test_base.ConnectionHealthChecksTests." "test_health_checks_enabled", "backends.base.test_base.ConnectionHealthChecksTests." "test_set_autocommit_health_checks_enabled", }, } ) if self.uses_server_side_binding: skips.update( { "The actual query cannot be determined for server side bindings": { "backends.base.test_base.ExecuteWrapperTests." "test_wrapper_debug", } }, ) return skips [63a1aedf]
- @cached_property def introspected_field_types(self): return { **super().introspected_field_types, "PositiveBigIntegerField": "BigIntegerField", "PositiveIntegerField": "IntegerField", "PositiveSmallIntegerField": "SmallIntegerField", } [747270d1]
- @cached_property def is_postgresql_16(self): return self.connection.pg_version >= 160000 [21de3fcc]
- @cached_property def is_postgresql_17(self): return self.connection.pg_version >= 170000 [fcb529e8]
- @cached_property def is_postgresql_18(self): return self.connection.pg_version >= 180000 [003d6877]
- @cached_property def max_query_params(self): if self.uses_server_side_binding: return 2**16 - 1 return None [9e837703]
- @cached_property def prohibits_null_characters_in_text_exception(self): if is_psycopg3: return DataError, "PostgreSQL text fields cannot contain NUL (0x00) bytes" else: return ValueError, "A string literal cannot contain NUL (0x00) characters." [823bb2fc]
- @cached_property def supports_uuid7_function(self): return self.is_postgresql_18 [cbc8dd58]
- @cached_property def uses_server_side_binding(self): options = self.connection.settings_dict["OPTIONS"] return is_psycopg3 and options.get("server_side_binding") is True [2926e72a]
- supports_unlimited_charfield = True supports_any_value = property(operator.attrgetter("is_postgresql_16")) supports_virtual_generated_columns = property( operator.attrgetter("is_postgresql_18") ) supports_uuid4_function_in_default = property( operator.attrgetter("supports_uuid4_function") ) [4f79a220]
- import operator [375f25d0b2ee635c-3]

## Beyond the budget

2 more facts did not fit in the budget: [ec13bec2] [f52b3c1b]
