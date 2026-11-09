# django/contrib/gis/db/backends/postgis/models

- Subject: django/contrib/gis/db/backends/postgis/models (id `502d9b1a-38dc-481b-9b3c-b33cecb59183`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 543 tokens
- Facts shown: 12 facts
- Conflicts: 0
- Gaps: 0

## Facts

- @classmethod def geom_col_name(cls): """ Return the name of the metadata column used to store the feature geometry column. """ return "f_geometry_column" [a4be53b9f8e37250]
- @classmethod def table_name_col(cls): """ Return the name of the metadata column used to store the feature table name. """ return "f_table_name" [4c2a5d52d4e7d89e]
- @property def wkt(self): return self.srtext [bd88d4905703fa2b]
- class Meta: app_label = "gis" db_table = "geometry_columns" managed = False [542621b292a1334e]
- class Meta: app_label = "gis" db_table = "spatial_ref_sys" managed = False [cf9ca94fe8c9f45d]
- def __str__(self): return "%s.%s - %dD %s field (SRID: %d)" % ( self.f_table_name, self.f_geometry_column, self.coord_dimension, self.type, self.srid, ) [4009826b26666703]
- f_table_catalog = models.CharField(max_length=256) f_table_schema = models.CharField(max_length=256) f_table_name = models.CharField(max_length=256) f_geometry_column = models.CharField(max_length=256) coord_dimension = models.IntegerField() srid = models.IntegerField(primary_key=True) type = models.CharField(max_length=30) [abce5d0e]
- srid = models.IntegerField(primary_key=True) auth_name = models.CharField(max_length=256) auth_srid = models.IntegerField() srtext = models.CharField(max_length=2048) proj4text = models.CharField(max_length=2048) [391ae887]
- """ The GeometryColumns and SpatialRefSys models for the PostGIS backend. """ [496858a2]
- class PostGISGeometryColumns(models.Model): """ The 'geometry_columns' view from PostGIS. See the PostGIS documentation at Ch. 4.3.2. """ [9e86de58]
- class PostGISSpatialRefSys(models.Model, SpatialRefSysMixin): """ The 'spatial_ref_sys' table from PostGIS. See the PostGIS documentation at Ch. 4.2.1. """ [82b3a2e2]
- from django.contrib.gis.db.backends.base.models import SpatialRefSysMixin from django.db import models [ac39dbc5deadd822]
