# django/db/backends/oracle/schema

- Subject: django/db/backends/oracle/schema (id `10efdb80-4923-46c6-a319-4bee6c7a3a3c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 4 of 19
- Conflicts: 0
- Gaps: 0

## Facts

- def _alter_column_type_sql( self, model, old_field, new_field, new_type, old_collation, new_collation ): auto_field_types = {"AutoField", "BigAutoField", "SmallAutoField"} # Drop the identity if migrating away from AutoField. if ( old_field.get_internal_type() in auto_field_types and new_field.get_internal_type() not in auto_field_types and self._is_identity_column(model._meta.db_table, new_field.column) ): self._drop_identity(model._meta.db_table, new_field.column) return super()._alter_column_type_sql( model, old_field, new_field, new_type, old_collation, new_collation ) [e79bab4c]
- def _alter_field_type_workaround(self, model, old_field, new_field): """ Oracle refuses to change from some type to other type. What we need to do instead is: - Add a nullable version of the desired field with a temporary name. If the new column is an auto field, then the temporary column can't be nullable. - Update the table to transfer values from old to new - Drop old column - Rename the new column and possibly drop the nullable property """ # Make a new field that's like the new one but with a temporary # column name. new_temp_field = copy.deepcopy(new_field) new_temp_field.null = new_field.get_internal_type() not in ( "AutoField", "BigAutoField", "SmallAutoField", ) new_temp_field.column = self._generate_temp_name(new_field.column) # Add it self.add_field(model, new_temp_field) # Explicit data type conversion # https://docs.oracle.com/en/database/oracle/oracle-database/21/sqlrf # /Data-Type-Comparison-Rules.html#GUID-D0C5A47E-6F93-4C2D-9E49-4F2B86B359DD new_value = self.quote_name(old_field.column) old_type = old_field.db_type(self.connection) if re.match("^N?CLOB", old_type): new_value = "TO_CHAR(%s)" % new_value old_type = "VARCHAR2" if re.match("^N?VARCHAR2", old_type): new_internal_type = new_field.get_internal_type() if new_internal_type == "DateField": new_value = "TO_DATE(%s, 'YYYY-MM-DD')" % new_value elif new_internal_type == "DateTimeField": new_value = "TO_TIMESTAMP(%s, 'YYYY-MM-DD HH24:MI:SS.FF')" % new_value elif new_internal_type == "TimeField": # TimeField are stored as TIMESTAMP with a 1900-01-01 date # part. new_value = "CONCAT('1900-01-01 ', %s)" % new_value new_value = "TO_TIMESTAMP(%s, 'YYYY-MM-DD HH24:MI:SS.FF')" % new_value # Transfer values across self.execute( "UPDATE %s set %s=%s" % ( self.quote_name(model._meta.db_table), self.quote_name(new_temp_field.column), new_value, ) ) # Drop the old field self.remove_field(model, old_field) # Rename and possibly make the new field NOT NULL super().alter_field(model, new_temp_field, new_field) # Recreate foreign key (if necessary) because the old field is not # passed to the alter_field() and data types of new_temp_field and # new_field always match. new_type = new_field.db_type(self.connection) if ( (old_field.primary_key and new_field.primary_key) or (old_field.unique and new_field.unique) ) and old_type != new_type: for _, rel in _related_non_m2m_objects(new_temp_field, new_field): if rel.field.db_constraint: self.execute( self._create_fk_sql(rel.related_model, rel.field, "_fk") ) [719fac7b]
- def _collate_sql(self, collation, old_collation=None, table_name=None): if collation is None and old_collation is not None: collation = self._get_default_collation(table_name) return super()._collate_sql(collation, old_collation, table_name) [97c1e794]
- def _column_generated_persistency_sql(self, field): return "MATERIALIZED" if field.db_persist else "VIRTUAL" [0bbf8f6d]

## Beyond the budget

15 more facts did not fit in the budget: [226f9739] [4a4ecb08] [f1fa49a0] [8b03f345] [0ff7a637] [5a853432] [6821d899] [a38cc9c5] [512d1078ba2dee30] [dddc1824] [067dd55e] [94f4978c] [f89873f9] [c05c9c49] [8e479e82]
