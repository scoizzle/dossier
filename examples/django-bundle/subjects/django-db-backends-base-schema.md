# django/db/backends/base/schema

- Subject: django/db/backends/base/schema (id `19fdb706-0c95-4e31-a713-4d49bf5a6f12`)
- Kind: subject
- Budget: 1200 tokens
- Used: 892 tokens
- Facts shown: 12 of 130
- Conflicts: 0
- Gaps: 0

## Facts

- def create_unique_name(*args, **kwargs): return self.quote_name(self._create_index_name(*args, **kwargs)) [c2a24299]
- # Check if the constraint is still in deferred_sql. This happens when # CreateModel with unique_together is followed by AlterUniqueTogether # in the same migration. index_together is not affected because its # indexes are created immediately in CreateModel.database_forwards. is_unique_constraint = constraint_kwargs.get("unique") is True table = model._meta.db_table if is_unique_constraint: for deferred in list(self.deferred_sql): if ( isinstance(deferred, Statement) and deferred.references_table(table) and all( deferred.references_column(table, column) for column in columns ) and deferred.parts["columns"].columns == columns ): self.deferred_sql.remove(deferred) return [cd1d500a]
- # Delete the table self.execute( self.sql_delete_table % { "table": self.quote_name(model._meta.db_table), } ) # Remove all deferred statements referencing the deleted table. for sql in list(self.deferred_sql): if isinstance(sql, Statement) and sql.references_table( model._meta.db_table ): self.deferred_sql.remove(sql) [8f519501]
- # Make M2M tables for field in model._meta.local_many_to_many: if field.remote_field.through._meta.auto_created: self.create_model(field.remote_field.through) [6a810728]
- # Remove all deferred statements referencing the deleted index. table_name = statement.parts["table"].table index_name = statement.parts["name"] for sql in list(self.deferred_sql): if isinstance(sql, Statement) and sql.references_index( table_name, index_name ): self.deferred_sql.remove(sql) [44ad0608]
- Return a (sql, params) fragment to add or drop (depending on the drop argument) a default to new_field's column. """ if drop: sql = self.sql_alter_column_no_default default_sql = "" params = [] else: sql = self.sql_alter_column_default default_sql, params = self.db_default_sql(new_field) [23274c8e]
- Return a (sql, params) fragment to add or drop (depending on the drop argument) a default to new_field's column. """ new_default = self.effective_default(new_field) default = self._column_default_sql(new_field) params = [new_default] [9cdfeb32]
- Return a (sql, params) fragment to set a column to null or non-null as required by new_field, or None if no changes are required. """ if ( self.connection.features.interprets_empty_strings_as_nulls and new_field.empty_strings_allowed ): # The field is nullable in the database anyway, leave it alone. return else: new_db_params = new_field.db_parameters(connection=self.connection) sql = ( self.sql_alter_column_null if new_field.null else self.sql_alter_column_not_null ) return ( sql % { "column": self.quote_name(new_field.column), "type": new_db_params["type"], }, [], ) [ffec7cce]
- def create_index_name(*args, **kwargs): nonlocal name if name is None: name = self._create_index_name(*args, **kwargs) return self.quote_name(name) [e1f5e14f]
- else: create_unique_name = self._create_index_name [207f5dcd]
- for index in model._meta.indexes: if ( not index.contains_expressions or self.connection.features.supports_expression_indexes ): output.append(index.create_sql(model, self)) return output [8592cdaf]
- return statement [3d13f848]

## Beyond the budget

115 more facts did not fit in the budget: [398991e9] [b47c2f21] [845050db] [340a109d] [5ad1650c] [5b71573a] [3a858241] [d9c498b0] [a7166e24] [0ccbd5aa] [b3b7b1a8] [b6d651ba] [d002e9c0] [c0e19a7d] [6000fcb9] [6816df78] [952305e7] [bc4a6161] [9bb68a6b] [a6afcbf7] [852fb632] [0c830c95] [b761fc2e] [a6b86e5b] [2adb5786] [cd9ad523] [381aa306] [6dd143c5] [48f70d02] [54428e22] [6a2bb784] [0674bec8] [9dbc00ba] [44d8e06e] [1558ea15] [771d4f72] [93bdb1bd] [0ef83573] [dbd969af] [41f7097a] [28730649] [8aadd219] [2a245cc6] [a16710b7] [5254dff8] [d0bd8171] [a2aa7575] [07a192ae] [2907aa80] [a4cc74d1] [b7364460] [4aa82cd3] [61acc5ae] [f04a53c9] [1b7dc8db] [4d15452a] [6c54e322] [8185bdc0] [b52625b5] [dd807b16] [ec30f6b1] [6de4d3fd] [cbf0f7ad] [d8b4645c] [1f912233] [55291836] [07e50d1f] [6b65d76c] [6fb49e3e] [67cb0782] [bbabc15b] [5ff30922] [4014b191] [9092ce21] [b93790eb] [6d6bfff8] [65bbfde4] [9310f237] [d67060e1] [ae810042] [df7061b5] [c75a78be] [2888b44c] [4da88508] [545cb95b] [7cbd339b] [10420645] [d6c50246] [d3b0ed4d] [fd1d3486] [dd573cc4] [960e51ab] [7cd04d1c] [57d177cb] [475b8526] [bfb543a7] [af27ab3a] [d2d6ce34] [cdd31ce0] [b2e389d0] [b4f65bc9] [abcdf4f9] [77a3be70] [4405d659] [b2d65a08] [387ef191] [1a9daa63] [15781568] [1aaadfb4] [b30c954c] [58db48d3] [ec5012e0] [36c65556] [d14883f6] [44a6184f]
