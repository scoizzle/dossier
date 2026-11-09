# django/db/backends/postgresql/introspection

- Subject: django/db/backends/postgresql/introspection (id `42d9c00c-efd6-42cd-b105-15baa512b7b5`)
- Kind: subject
- Budget: 1200 tokens
- Used: 884 tokens
- Facts shown: 7 of 13
- Conflicts: 0
- Gaps: 0

## Facts

- # PostgreSQL OIDs may vary depending on the installation, especially # for datatypes from extensions, e.g. "hstore". In such cases, the # type_display attribute (psycopg 3.2+) should be used. type_display_available = psycopg_version() >= (3, 2) return [ FieldInfo( line.name, ( line.type_display if type_display_available and line.type_display == "hstore" else line.type_code ), # display_size is always None on psycopg2. line.internal_size if line.display_size is None else line.display_size, line.internal_size, # precision and scale are always 2^16 - 1 on psycopg2 for # DecimalFields with no precision. None if line.precision == 2**16 - 1 else line.precision, None if line.scale == 2**16 - 1 else line.scale, *field_map[line.name], ) for line in cursor.description ] [1606d949]
- def get_field_type(self, data_type, description): field_type = super().get_field_type(data_type, description) if description.is_autofield or ( # Required for pre-Django 4.1 serial columns. description.default and "nextval" in description.default ): if field_type == "IntegerField": return "AutoField" elif field_type == "BigIntegerField": return "BigAutoField" elif field_type == "SmallIntegerField": return "SmallAutoField" return field_type [ba13540f]
- def get_relations(self, cursor, table_name): """ Return a dictionary of { field_name: (field_name_other_table, other_table, db_on_delete) } representing all foreign keys in the given table. """ cursor.execute( """ SELECT a1.attname, c2.relname, a2.attname, con.confdeltype FROM pg_constraint con LEFT JOIN pg_class c1 ON con.conrelid = c1.oid LEFT JOIN pg_class c2 ON con.confrelid = c2.oid LEFT JOIN pg_attribute a1 ON c1.oid = a1.attrelid AND a1.attnum = con.conkey[1] LEFT JOIN pg_attribute a2 ON c2.oid = a2.attrelid AND a2.attnum = con.confkey[1] WHERE c1.relname = %s AND con.contype = 'f' AND c1.relnamespace = c2.relnamespace AND pg_catalog.pg_table_is_visible(c1.oid) """, [table_name], ) return { row[0]: (row[2], row[1], self.on_delete_types.get(row[3])) for row in cursor.fetchall() } [d313828a]
- def get_sequences(self, cursor, table_name, table_fields=()): cursor.execute( """ SELECT s.relname AS sequence_name, a.attname AS colname FROM pg_class s JOIN pg_depend d ON d.objid = s.oid AND d.classid = 'pg_class'::regclass AND d.refclassid = 'pg_class'::regclass JOIN pg_attribute a ON d.refobjid = a.attrelid AND d.refobjsubid = a.attnum JOIN pg_class tbl ON tbl.oid = d.refobjid AND tbl.relname = %s AND pg_catalog.pg_table_is_visible(tbl.oid) WHERE s.relkind = 'S'; """, [table_name], ) return [ {"name": row[0], "table": table_name, "column": row[1]} for row in cursor.fetchall() ] [7bed72ec]
- def get_table_list(self, cursor): """Return a list of table and view names in the current database.""" cursor.execute(""" SELECT c.relname, CASE WHEN c.relispartition THEN 'p' WHEN c.relkind IN ('m', 'v') THEN 'v' ELSE 't' END, obj_description(c.oid, 'pg_class') FROM pg_catalog.pg_class c LEFT JOIN pg_catalog.pg_namespace n ON n.oid = c.relnamespace WHERE c.relkind IN ('f', 'm', 'p', 'r', 'v') AND n.nspname NOT IN ('pg_catalog', 'pg_toast') AND pg_catalog.pg_table_is_visible(c.oid) """) return [ TableInfo(*row) for row in cursor.fetchall() if row[0] not in self.ignored_tables ] [8f652ec5]
- ignored_tables = [] [3c6cc848]
- from collections import namedtuple [b946acd58351fb6c-4]

## Beyond the budget

6 more facts did not fit in the budget: [7b241022] [bfb95acc] [d2d54b0e] [ad28f8cf] [9b4f9190] [8731f65c]
