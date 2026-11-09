# django/db/backends/mysql/schema

- Subject: django/db/backends/mysql/schema (id `e2702a7d-2a29-408f-b387-eb81aa08f544`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 11 of 34
- Conflicts: 0
- Gaps: 0

## Facts

- # Simulate the effect of a one-off default. # field.default may be unhashable, so a set isn't used for "in" check. if self.skip_default(field) and field.default not in (None, NOT_PROVIDED): effective_default = self.effective_default(field) self.execute( "UPDATE %(table)s SET %(column)s = %%s" % { "table": self.quote_name(model._meta.db_table), "column": self.quote_name(field.column), }, [effective_default], ) [0161564a]
- Manually create an implicit FK index to make it possible to remove the composed index. """ first_field_name = None if fields: first_field_name = fields[0] elif ( expressions and self.connection.features.supports_expression_indexes and isinstance(expressions[0], F) and LOOKUP_SEP not in expressions[0].name ): first_field_name = expressions[0].name [f4897980]
- first_field = model._meta.get_field(first_field_name) if first_field.get_internal_type() == "ForeignKey": column = self.connection.introspection.identifier_converter( first_field.column ) with self.connection.cursor() as cursor: constraint_names = [ name for name, infodict in self.connection.introspection.get_constraints( cursor, model._meta.db_table ).items() if infodict["index"] and infodict["columns"][0] == column ] # There are no other indexes that starts with the FK field, only # the index that is expected to be deleted. if len(constraint_names) == 1: self.execute( self._create_index_sql(model, fields=[first_field], suffix="") ) [4f530be4]
- if not first_field_name: return [c96f080d]
- new_db_params = new_field.db_parameters(connection=self.connection) type_sql = self._set_field_new_type(new_field, new_db_params["type"]) return ( "MODIFY %(column)s %(type)s" % { "column": self.quote_name(new_field.column), "type": type_sql, }, [], ) [d5a28051]
- storage = self.connection.introspection.get_storage_engine( self.connection.cursor(), model._meta.db_table ) # No need to create an index for ForeignKey fields except if # db_constraint=False because the index from that constraint won't be # created. if ( storage == "InnoDB" and field.get_internal_type() == "ForeignKey" and field.db_constraint ): return False return not self._is_limited_data_type(field) [e5a8fdde]
- @property def sql_delete_check(self): if self.connection.mysql_is_mariadb: # The name of the column check constraint is the same as the field # name on MariaDB. Adding IF EXISTS clause prevents migrations # crash. Constraint is removed during a "MODIFY" column statement. return "ALTER TABLE %(table)s DROP CONSTRAINT IF EXISTS %(name)s" return "ALTER TABLE %(table)s DROP CHECK %(name)s" [5bd7051f]
- def _alter_column_comment_sql(self, model, new_field, new_type, new_db_comment): # Comment is alter when altering the column type. return "", [] [2fc5d658]
- def _alter_column_null_sql(self, model, old_field, new_field): if not new_field.has_db_default(): return super()._alter_column_null_sql(model, old_field, new_field) [babd1465]
- def _alter_column_type_sql( self, model, old_field, new_field, new_type, old_collation, new_collation ): new_type = self._set_field_new_type(old_field, new_type) return super()._alter_column_type_sql( model, old_field, new_field, new_type, old_collation, new_collation ) [1ef00a70]
- def add_field(self, model, field): super().add_field(model, field) [33a18311]

## Beyond the budget

23 more facts did not fit in the budget: [78c96078] [942b37df] [a227e448] [98b56b87] [2bbfe444] [8bed8558] [397f65e2] [38be6119] [a5e1d98e] [798b5c34] [513d204d] [498a5b41] [4b2f9d27] [e62c245f] [21203c99] [0f36d7d0] [b40ef03e] [b6da9c9c] [67b2253a] [ac53dde2] [0e432c1a] [992b074e] [08b49d02]
