# django/db/backends/mysql/introspection

- Subject: django/db/backends/mysql/introspection (id `63e4ce22-00c1-4632-97ad-407aacc025e7`)
- Kind: subject
- Budget: 1200 tokens
- Used: 855 tokens
- Facts shown: 9 of 16
- Conflicts: 0
- Gaps: 0

## Facts

- cursor.execute( "SELECT * FROM %s LIMIT 1" % self.connection.ops.quote_name(table_name) ) [fdf282dd]
- def to_int(i): return int(i) if i is not None else i [786129bb]
- fields = [] for line in cursor.description: info = field_info[line[0]] fields.append( FieldInfo( *line[:2], to_int(info.max_len) or line[2], to_int(info.max_len) or line[3], to_int(info.num_prec) or line[4], to_int(info.num_scale) or line[5], line[6], info.column_default, info.collation, info.extra, info.is_unsigned, line[0] in json_constraints, info.comment, info.data_type, ) ) return fields [ac8a020b]
- def _parse_constraint_columns(self, check_clause, columns): check_columns = OrderedSet() statement = sqlparse.parse(check_clause)[0] tokens = (token for token in statement.flatten() if not token.is_whitespace) for token in tokens: if ( token.ttype == sqlparse.tokens.Name and self.connection.ops.quote_name(token.value) == token.value and token.value[1:-1] in columns ): check_columns.add(token.value[1:-1]) return check_columns [06fdb94b]
- def get_field_type(self, data_type, description): field_type = super().get_field_type(data_type, description) if "auto_increment" in description.extra: if field_type == "IntegerField": return "AutoField" elif field_type == "BigIntegerField": return "BigAutoField" elif field_type == "SmallIntegerField": return "SmallAutoField" if description.is_unsigned: if field_type == "BigIntegerField": return "PositiveBigIntegerField" elif field_type == "IntegerField": return "PositiveIntegerField" elif field_type == "SmallIntegerField": return "PositiveSmallIntegerField" if description.data_type.upper() == "UUID": return "UUIDField" # JSON data type is an alias for LONGTEXT in MariaDB, use check # constraints clauses to introspect JSONField. if description.has_json_constraint: return "JSONField" return field_type [2a9183d3]
- def get_relations(self, cursor, table_name): """ Return a dictionary of { field_name: (field_name_other_table, other_table, db_on_delete) } representing all foreign keys in the given table. """ cursor.execute( """ SELECT kcu.column_name, kcu.referenced_column_name, kcu.referenced_table_name, rc.delete_rule FROM information_schema.key_column_usage kcu JOIN information_schema.referential_constraints rc ON rc.constraint_name = kcu.constraint_name AND rc.constraint_schema = kcu.constraint_schema WHERE kcu.table_name = %s AND kcu.table_schema = DATABASE() AND kcu.referenced_table_schema = DATABASE() AND kcu.referenced_table_name IS NOT NULL AND kcu.referenced_column_name IS NOT NULL """, [table_name], ) return { field_name: (other_field, other_table, self.on_delete_types.get(on_delete)) for field_name, other_field, other_table, on_delete in cursor.fetchall() } [96d57d62]
- def get_sequences(self, cursor, table_name, table_fields=()): for field_info in self.get_table_description(cursor, table_name): if "auto_increment" in field_info.extra: # MySQL allows only one auto-increment column per table. return [{"table": table_name, "column": field_info.name}] return [] [b376acce]
- from collections import namedtuple [b946acd58351fb6c-2]
- import sqlparse from MySQLdb.constants import FIELD_TYPE [80a8fa9b]

## Beyond the budget

7 more facts did not fit in the budget: [1a936b02] [c1bcc64f] [0b222300] [9d6183df] [eac3c8cb] [2a49288f] [a24af6d9]
