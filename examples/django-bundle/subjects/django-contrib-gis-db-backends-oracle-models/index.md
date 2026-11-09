# django/contrib/gis/db/backends/oracle/models

- Subject: django/contrib/gis/db/backends/oracle/models (id `0471f37a-718f-49f6-bbe0-12f470cc7183`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 596 tokens
- Facts shown: 13 of 13
- Conflicts: 0
- Gaps: 0

## Facts

- @classmethod def geom_col_name(cls): """ Return the name of the metadata column used to store the feature geometry column. """ return "column_name" [158f0c2b]
- @classmethod def table_name_col(cls): """ Return the name of the metadata column used to store the feature table name. """ return "table_name" [8f5c851f]
- @property def wkt(self): return self.wktext [b90f3cf1]
- class Meta: app_label = "gis" db_table = "CS_SRS" managed = False [e09a3490]
- class Meta: app_label = "gis" db_table = "USER_SDO_GEOM_METADATA" managed = False [7c1346c0]
- cs_name = models.CharField(max_length=68) srid = models.IntegerField(primary_key=True) auth_srid = models.IntegerField() auth_name = models.CharField(max_length=256) wktext = models.CharField(max_length=2046) # Optional geometry representing the bounds of this coordinate # system. By default, all are NULL in the table. cs_bounds = models.PolygonField(null=True) [a8643233]
- def __str__(self): return "%s - %s (SRID: %s)" % (self.table_name, self.column_name, self.srid) [5eda3a9b]
- table_name = models.CharField(max_length=32) column_name = models.CharField(max_length=1024) srid = models.IntegerField(primary_key=True) # TODO: Add support for `diminfo` column (type MDSYS.SDO_DIM_ARRAY). [bce56b80]
- """ The GeometryColumns and SpatialRefSys models for the Oracle spatial backend. [0181cc74]
- It should be noted that Oracle Spatial does not have database tables named according to the OGC standard, so the closest analogs are used. For example, the `USER_SDO_GEOM_METADATA` is used for the GeometryColumns model and the `SDO_COORD_REF_SYS` is used for the SpatialRefSys model. """ [88477076]
- class OracleGeometryColumns(models.Model): "Maps to the Oracle USER_SDO_GEOM_METADATA table." [0f3fefe1]
- class OracleSpatialRefSys(models.Model, SpatialRefSysMixin): "Maps to the Oracle MDSYS.CS_SRS table." [10a2177d]
- from django.contrib.gis.db import models from django.contrib.gis.db.backends.base.models import SpatialRefSysMixin [7d71ee46]
