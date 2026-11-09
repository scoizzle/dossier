# django/contrib/gis/db/backends/mysql/schema

- Subject: django/contrib/gis/db/backends/mysql/schema (id `e4b8df93-25d3-4faf-9cf5-606620552436`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 809 tokens
- Facts shown: 13 facts
- Conflicts: 0
- Gaps: 0

## Facts

- old_field_spatial_index = ( isinstance(old_field, GeometryField) and old_field.spatial_index and not old_field.null ) new_field_spatial_index = ( isinstance(new_field, GeometryField) and new_field.spatial_index and not new_field.null ) if not old_field_spatial_index and new_field_spatial_index: self.execute(self._create_spatial_index_sql(model, new_field)) elif old_field_spatial_index and not new_field_spatial_index: self.execute(self._delete_spatial_index_sql(model, old_field)) [03f95e29]
- super().remove_field(model, field) [4cd9383b]
- def _alter_field( self, model, old_field, new_field, old_type, new_type, old_db_params, new_db_params, strict=False, ): super()._alter_field( model, old_field, new_field, old_type, new_type, old_db_params, new_db_params, strict=strict, ) [9da03683feff56c8]
- def _create_spatial_index_name(self, model, field): return "%s_%s_id" % (model._meta.db_table, field.column) [4556dbd8]
- def _create_spatial_index_sql(self, model, field): index_name = self._create_spatial_index_name(model, field) qn = self.connection.ops.quote_name return self.sql_add_spatial_index % { "index": qn(index_name), "table": qn(model._meta.db_table), "column": qn(field.column), } [af2d8a0f]
- def _delete_spatial_index_sql(self, model, field): index_name = self._create_spatial_index_name(model, field) return self._delete_index_sql(model, index_name) [8e630324c6c67db3]
- def _field_indexes_sql(self, model, field): if isinstance(field, GeometryField) and field.spatial_index and not field.null: with self.connection.cursor() as cursor: supports_spatial_index = ( self.connection.introspection.supports_spatial_index( cursor, model._meta.db_table ) ) sql = self._create_spatial_index_sql(model, field) if supports_spatial_index: return [sql] else: logger.error( f"Cannot create SPATIAL INDEX {sql}. Only MyISAM, Aria, and InnoDB " f"support them.", ) return [] return super()._field_indexes_sql(model, field) [63f717f9]
- def quote_value(self, value): if isinstance(value, self.connection.ops.Adapter): return super().quote_value(str(value)) return super().quote_value(value) [8fbcaa3b12036b9f]
- def remove_field(self, model, field): if isinstance(field, GeometryField) and field.spatial_index and not field.null: sql = self._delete_spatial_index_sql(model, field) try: self.execute(sql) except OperationalError: logger.error( "Couldn't remove spatial index: %s (may be expected " "if your storage engine doesn't support them).", sql, ) [8649edd8]
- class MySQLGISSchemaEditor(DatabaseSchemaEditor): sql_add_spatial_index = "CREATE SPATIAL INDEX %(index)s ON %(table)s(%(column)s)" [be7eb67e]
- from django.contrib.gis.db.models import GeometryField from django.db import OperationalError from django.db.backends.mysql.schema import DatabaseSchemaEditor [4698f304]
- import logging [47bc951ed6a0e3cc]
- logger = logging.getLogger("django.contrib.gis") [e92fc94cc00bbb3c]
