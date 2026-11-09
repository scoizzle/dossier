# django/contrib/gis/db/backends/spatialite/models

- Subject: django/contrib/gis/db/backends/spatialite/models (id `e2e61805-b1cd-40b2-8e3f-9bd5a3d2d7ef`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 527 tokens
- Facts shown: 12 of 12
- Conflicts: 0
- Gaps: 0

## Facts

- @classmethod def geom_col_name(cls): """ Return the name of the metadata column used to store the feature geometry column. """ return "f_geometry_column" [a4be53b9f8e37250-2]
- @classmethod def table_name_col(cls): """ Return the name of the metadata column used to store the feature table name. """ return "f_table_name" [4c2a5d52d4e7d89e-2]
- @property def wkt(self): return self.srtext [bd88d4905703fa2b-2]
- class Meta: app_label = "gis" db_table = "geometry_columns" managed = False [542621b292a1334e-2]
- class Meta: app_label = "gis" db_table = "spatial_ref_sys" managed = False [cf9ca94fe8c9f45d-2]
- def __str__(self): return "%s.%s - %dD %s field (SRID: %d)" % ( self.f_table_name, self.f_geometry_column, self.coord_dimension, self.type, self.srid, ) [4009826b26666703-2]
- f_table_name = models.CharField(max_length=256) f_geometry_column = models.CharField(max_length=256) coord_dimension = models.IntegerField() srid = models.IntegerField(primary_key=True) spatial_index_enabled = models.IntegerField() type = models.IntegerField(db_column="geometry_type") [9da3bb39]
- srid = models.IntegerField(primary_key=True) auth_name = models.CharField(max_length=256) auth_srid = models.IntegerField() ref_sys_name = models.CharField(max_length=256) proj4text = models.CharField(max_length=2048) srtext = models.CharField(max_length=2048) [caa475a6]
- """ The GeometryColumns and SpatialRefSys models for the SpatiaLite backend. """ [17e2b841]
- class SpatialiteGeometryColumns(models.Model): """ The 'geometry_columns' table from SpatiaLite. """ [4ef44077]
- class SpatialiteSpatialRefSys(models.Model, SpatialRefSysMixin): """ The 'spatial_ref_sys' table from SpatiaLite. """ [a7e0b229]
- from django.contrib.gis.db.backends.base.models import SpatialRefSysMixin from django.db import models [ac39dbc5deadd822-2]
