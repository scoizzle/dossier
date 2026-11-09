# django/contrib/gis/db/backends/spatialite/schema

- Subject: django/contrib/gis/db/backends/spatialite/schema (id `85bc89b6-89ab-46e8-ab5a-5388a51b4772`)
- Kind: subject
- Budget: 1200 tokens
- Used: 878 tokens
- Facts shown: 8 of 19
- Conflicts: 0
- Gaps: 0

## Facts

- # Drop spatial metadata (dropping the table does not automatically # remove them) for field in model._meta.local_fields: if isinstance(field, GeometryField): self.remove_geometry_metadata(model, field) # Make sure all geom stuff is gone for geom_table in self.geometry_tables: try: self.execute( self.sql_discard_geometry_columns % { "geom_table": geom_table, "table": self.quote_name(model._meta.db_table), } ) except DatabaseError: pass super().delete_model(model, **kwargs) [9a401eab]
- # Geometry columns are created by the `AddGeometryColumn` function self.geometry_sql.append( self.sql_add_geometry_column % { "table": self.geo_quote_name(model._meta.db_table), "column": self.geo_quote_name(field.column), "srid": field.srid, "geom_type": self.geo_quote_name(field.geom_type), "dim": field.dim, "null": int(not field.null), } ) [aadfee65]
- # NOTE: If the field is a geometry field, the table is just recreated, # the parent's remove_field can't be used cause it will skip the # recreation if the field does not have a database type. Geometry # fields do not have a db type cause they are added and removed via # stored procedures. if isinstance(field, GeometryField): self._remake_table(model, delete_field=field) else: super().remove_field(model, field) [ddf7aaab]
- if field.spatial_index: self.geometry_sql.append( self.sql_add_spatial_index % { "table": self.quote_name(model._meta.db_table), "column": self.quote_name(field.column), } ) return None, None [ccaa193f]
- if isinstance(field, GeometryField): # Populate self.geometry_sql self.column_sql(model, field) for sql in self.geometry_sql: self.execute(sql) self.geometry_sql = [] else: super().add_field(model, field) [f067a48f]
- if not isinstance(field, GeometryField): return super().column_sql(model, field, include_default) [e188517f]
- if old_db_table == new_db_table or ( self.connection.features.ignores_table_name_case and old_db_table.lower() == new_db_table.lower() ): return # Remove geometry-ness from temp table for field in model._meta.local_fields: if isinstance(field, GeometryField): self.execute( self.sql_remove_geometry_metadata % { "table": self.quote_name(old_db_table), "column": self.quote_name(field.column), } ) # Alter table super().alter_db_table(model, old_db_table, new_db_table) # Repoint any straggler names for geom_table in self.geometry_tables: try: self.execute( self.sql_update_geometry_columns % { "geom_table": geom_table, "old_table": self.quote_name(old_db_table), "new_table": self.quote_name(new_db_table), } ) except DatabaseError: pass # Re-add geometry-ness and rename spatial index tables for field in model._meta.local_fields: if isinstance(field, GeometryField): self.execute( self.sql_recover_geometry_metadata % { "table": self.geo_quote_name(new_db_table), "column": self.geo_quote_name(field.column), "srid": field.srid, "geom_type": self.geo_quote_name(field.geom_type), "dim": field.dim, } ) if getattr(field, "spatial_index", False): self.execute( self.sql_rename_table % { "old_table": self.quote_name( "idx_%s_%s" % (old_db_table, field.column) ), "new_table": self.quote_name( "idx_%s_%s" % (new_db_table, field.column) ), } ) [bfd57fca]
- def __init__(self, *args, **kwargs): super().__init__(*args, **kwargs) self.geometry_sql = [] [b31812f819c2e248-2]

## Beyond the budget

10 more facts did not fit in the budget: [b8f0ffe0] [5aa444bf] [f2e2b3f6] [25a6f82c] [5cda69df] [97ded5e0e226ebb7-3] [70afff0d] [5413d18a] [51266fd7] [54cf97af]
