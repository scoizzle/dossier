# django/contrib/gis/db/backends/spatialite/features

- Subject: django/contrib/gis/db/backends/spatialite/features (id `8b7a789b-8abe-4cc0-88b5-b4d4230835e0`)
- Kind: subject
- Budget: 1200 tokens
- Used: 224 tokens
- Facts shown: 4 of 4
- Conflicts: 0
- Gaps: 0

## Facts

- @cached_property def django_test_skips(self): skips = super().django_test_skips skips.update( { "SpatiaLite doesn't support distance lookups with Distance objects.": { "gis_tests.geogapp.tests.GeographyTest.test02_distance_lookup", }, } ) return skips [14f11465]
- @cached_property def supports_area_geodetic(self): return bool(self.connection.ops.geom_lib_version()) [ed3567bd]
- class DatabaseFeatures(BaseSpatialFeatures, SQLiteDatabaseFeatures): can_alter_geometry_field = False # Not implemented supports_3d_storage = True [68037f50]
- from django.contrib.gis.db.backends.base.features import BaseSpatialFeatures from django.db.backends.sqlite3.features import ( DatabaseFeatures as SQLiteDatabaseFeatures, ) from django.utils.functional import cached_property [047c399e]
