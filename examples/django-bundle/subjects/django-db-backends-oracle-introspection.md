# django/db/backends/oracle/introspection

- Subject: django/db/backends/oracle/introspection (id `964315a2-842d-4829-bf0f-5a54f2286dc8`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 9 of 16
- Conflicts: 0
- Gaps: 0

## Facts

- return super().get_field_type(data_type, description) [8094ca57]
- return { self.identifier_converter(field_name): ( self.identifier_converter(rel_field_name), self.identifier_converter(rel_table_name), self.on_delete_types.get(on_delete), ) for ( field_name, rel_table_name, rel_field_name, on_delete, ) in cursor.fetchall() } [f8e40452]
- # Maps type objects to Django Field types. data_types_reverse = { oracledb.DB_TYPE_DATE: "DateField", oracledb.DB_TYPE_BINARY_DOUBLE: "FloatField", oracledb.DB_TYPE_BLOB: "BinaryField", oracledb.DB_TYPE_CHAR: "CharField", oracledb.DB_TYPE_CLOB: "TextField", oracledb.DB_TYPE_INTERVAL_DS: "DurationField", oracledb.DB_TYPE_NCHAR: "CharField", oracledb.DB_TYPE_NCLOB: "TextField", oracledb.DB_TYPE_NVARCHAR: "CharField", oracledb.DB_TYPE_NUMBER: "DecimalField", oracledb.DB_TYPE_TIMESTAMP: "DateTimeField", oracledb.DB_TYPE_VARCHAR: "CharField", } [231b8405]
- def get_field_type(self, data_type, description): if data_type == oracledb.NUMBER: precision, scale = description[4:6] if scale == 0: if precision > 11: return ( "BigAutoField" if description.is_autofield else "BigIntegerField" ) elif 1 < precision < 6 and description.is_autofield: return "SmallAutoField" elif precision == 1: return "BooleanField" elif description.is_autofield: return "AutoField" else: return "IntegerField" elif scale == -127: return "FloatField" elif data_type == oracledb.NCLOB and description.is_json: return "JSONField" [f8d8a549]
- def get_primary_key_columns(self, cursor, table_name): cursor.execute( """ SELECT cols.column_name FROM user_constraints, user_cons_columns cols WHERE user_constraints.constraint_name = cols.constraint_name AND user_constraints.constraint_type = 'P' AND user_constraints.table_name = UPPER(%s) ORDER BY cols.position """, [table_name], ) return [self.identifier_converter(row[0]) for row in cursor.fetchall()] [589af554]
- def get_relations(self, cursor, table_name): """ Return a dictionary of { field_name: (field_name_other_table, other_table, db_on_delete) } representing all foreign keys in the given table. """ table_name = table_name.upper() cursor.execute( """ SELECT ca.column_name, cb.table_name, cb.column_name, user_constraints.delete_rule FROM user_constraints, USER_CONS_COLUMNS ca, USER_CONS_COLUMNS cb WHERE user_constraints.table_name = %s AND user_constraints.constraint_name = ca.constraint_name AND user_constraints.r_constraint_name = cb.constraint_name AND ca.position = cb.position""", [table_name], ) [6e286236]
- def get_table_list(self, cursor): """Return a list of table and view names in the current database.""" cursor.execute(""" SELECT user_tables.table_name, 't', user_tab_comments.comments FROM user_tables LEFT OUTER JOIN user_tab_comments ON user_tab_comments.table_name = user_tables.table_name WHERE NOT EXISTS ( SELECT 1 FROM user_mviews WHERE user_mviews.mview_name = user_tables.table_name ) UNION ALL SELECT view_name, 'v', NULL FROM user_views UNION ALL SELECT mview_name, 'v', NULL FROM user_mviews """) return [ TableInfo(self.identifier_converter(row[0]), row[1], row[2]) for row in cursor.fetchall() ] [c1f3426b]
- def identifier_converter(self, name): """Identifier comparison is case insensitive under Oracle.""" return name.lower() [c7179a3b]
- from collections import namedtuple [b946acd58351fb6c-3]

## Beyond the budget

7 more facts did not fit in the budget: [9e5ec0b0] [e7ced962] [2d58e490] [f45e3331] [87cd3017] [031502b9] [f7636c0e9b50a9d4-3]
