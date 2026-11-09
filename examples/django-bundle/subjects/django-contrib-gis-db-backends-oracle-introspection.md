# django/contrib/gis/db/backends/oracle/introspection

- Subject: django/contrib/gis/db/backends/oracle/introspection (id `477a5721-4baa-4767-a446-06f878b90352`)
- Kind: subject
- Budget: 1200 tokens
- Used: 424 tokens
- Facts shown: 6 of 6
- Conflicts: 0
- Gaps: 0

## Facts

- # Getting the field parameters. field_params = {} dim, srid = row if srid != 4326: field_params["srid"] = srid # Size of object array (SDO_DIM_ARRAY) is number of dimensions. dim = dim.size() if dim != 2: field_params["dim"] = dim return field_type, field_params [990694b1]
- # TODO: Research way to find a more specific geometry field type # for the column's contents. field_type = "GeometryField" [e360b989]
- def get_geometry_type(self, table_name, description): with self.connection.cursor() as cursor: # Querying USER_SDO_GEOM_METADATA to get the SRID and dimension # information. try: cursor.execute( 'SELECT "DIMINFO", "SRID" FROM "USER_SDO_GEOM_METADATA" ' 'WHERE "TABLE_NAME"=%s AND "COLUMN_NAME"=%s', (table_name.upper(), description.name.upper()), ) row = cursor.fetchone() except Exception as exc: raise Exception( "Could not find entry in USER_SDO_GEOM_METADATA " 'corresponding to "%s"."%s"' % (table_name, description.name) ) from exc [190bc0c8]
- class OracleIntrospection(DatabaseIntrospection): # Associating any OBJECTVAR instances with GeometryField. This won't work # right on Oracle objects that aren't MDSYS.SDO_GEOMETRY, but it is the # only object type supported within Django anyways. @cached_property def data_types_reverse(self): return { **super().data_types_reverse, oracledb.DB_TYPE_OBJECT: "GeometryField", } [91d70ce7]
- from django.db.backends.oracle.introspection import DatabaseIntrospection from django.utils.functional import cached_property [42b15479]
- import oracledb [f7636c0e9b50a9d4-2]
