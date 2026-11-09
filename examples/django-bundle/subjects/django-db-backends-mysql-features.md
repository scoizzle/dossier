# django/db/backends/mysql/features

- Subject: django/db/backends/mysql/features (id `dbc11e42-dc3c-410f-b896-65bc715ed8cd`)
- Kind: subject
- Budget: 1200 tokens
- Used: 889 tokens
- Facts shown: 13 of 33
- Conflicts: 0
- Gaps: 0

## Facts

- @cached_property def _mysql_storage_engine(self): """ Internal method used in Django tests. Don't rely on this from your code """ return self.connection.mysql_server_data["default_storage_engine"] [8c5d7633]
- @cached_property def allows_auto_pk_0(self): """ Autoincrement primary key can be set to 0 if it doesn't generate new autoincrement values. """ return "NO_AUTO_VALUE_ON_ZERO" in self.connection.sql_mode [f83d3240]
- @cached_property def allows_group_by_selected_pks(self): if self.connection.mysql_is_mariadb: return "ONLY_FULL_GROUP_BY" not in self.connection.sql_mode return True [acaedddd]
- @cached_property def can_introspect_foreign_keys(self): "Confirm support for introspected foreign keys" return self._mysql_storage_engine != "MyISAM" [eeaff3ca]
- @cached_property def can_introspect_json_field(self): if self.connection.mysql_is_mariadb: return self.can_introspect_check_constraints return True [dd7a8df4]
- @cached_property def can_return_columns_from_insert(self): return self.connection.mysql_is_mariadb [3bb2c14f]
- @cached_property def django_test_skips(self): skips = { "This doesn't work on MySQL.": { "db_functions.comparison.test_greatest.GreatestTests." "test_coalesce_workaround", "db_functions.comparison.test_least.LeastTests." "test_coalesce_workaround", }, "MySQL doesn't support functional indexes on a function that " "returns JSON": { "schema.tests.SchemaTests.test_func_index_json_key_transform", }, "MySQL supports multiplying and dividing DurationFields by a " "scalar value but it's not implemented (#25287).": { "expressions.tests.FTimeDeltaTests.test_durationfield_multiply_divide", }, "UPDATE ... ORDER BY syntax on MySQL/MariaDB does not support ordering by" "related fields.": { "update.tests.AdvancedTests." "test_update_ordered_by_inline_m2m_annotation", "update.tests.AdvancedTests.test_update_ordered_by_m2m_annotation", "update.tests.AdvancedTests.test_update_ordered_by_m2m_annotation_desc", }, } if not self.connection.mysql_is_mariadb: skips.update( { "MySQL doesn't allow renaming columns referenced by generated " "columns": { "migrations.test_operations.OperationTests." "test_invalid_generated_field_changes_on_rename_stored", "migrations.test_operations.OperationTests." "test_invalid_generated_field_changes_on_rename_virtual", }, } ) return skips [9e9ce8e5]
- @cached_property def has_native_uuid_field(self): return self.connection.mysql_is_mariadb [5d8ee32e]
- @cached_property def has_select_for_update_of(self): return not self.connection.mysql_is_mariadb [9331ac3f]
- @cached_property def has_zoneinfo_database(self): return self.connection.mysql_server_data["has_zoneinfo_database"] [dff5bf56]
- @cached_property def ignores_table_name_case(self): return self.connection.mysql_server_data["lower_case_table_names"] [74aacfe9]
- @cached_property def introspected_field_types(self): return { **super().introspected_field_types, "BinaryField": "TextField", "BooleanField": "IntegerField", "DurationField": "BigIntegerField", "GenericIPAddressField": "CharField", } [c7a97761]
- @cached_property def is_sql_auto_is_null_enabled(self): return self.connection.mysql_server_data["sql_auto_is_null"] [54e90c4e]

## Beyond the budget

19 more facts did not fit in the budget: [0a2d7abf] [a52150fa] [431cb1fb] [0b18d3db] [e9d30903] [fb35db97] [f3ce925a] [7cae6242] [fb3b9985] [f51c14a9] [62ad7748] [f3041cfc] [90541967] [520b9a8c] [9166ad7e] [007506b8] [2c17b784] [5ed40cd5] [375f25d0b2ee635c-2]
