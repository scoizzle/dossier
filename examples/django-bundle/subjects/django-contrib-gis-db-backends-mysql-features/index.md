# django/contrib/gis/db/backends/mysql/features

- Subject: django/contrib/gis/db/backends/mysql/features (id `4e7ce466-0a10-4a4f-b763-78531fef661d`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 361 tokens
- Facts shown: 5 facts
- Conflicts: 0
- Gaps: 0

## Facts

- @cached_property def django_test_skips(self): skips = super().django_test_skips if self.connection.mysql_is_mariadb: skips.update( { "MariaDB doesn't support nested geometry collections.": { "gis_tests.geoapp.tests.SaveLoadTests." "test_geometrycollectionfield_default_max_ignored_on_read", }, } ) return skips [cca12493]
- @cached_property def supports_geometry_field_unique_index(self): # Not supported in MySQL since # https://dev.mysql.com/worklog/task/?id=11808 return self.connection.mysql_is_mariadb [49c47f13]
- @cached_property def unsupported_geojson_options(self): if self.connection.mysql_is_mariadb or self.connection.mysql_version < (9, 5): return {"crs"} return set() [ffab22a8]
- class DatabaseFeatures(BaseSpatialFeatures, MySQLDatabaseFeatures): empty_intersection_returns_none = False has_spatialrefsys_table = False supports_add_srs_entry = False supports_distance_geodetic = False supports_length_geodetic = False supports_area_geodetic = False supports_transform = False supports_null_geometries = False supports_num_points_poly = False [115c617a]
- from django.contrib.gis.db.backends.base.features import BaseSpatialFeatures from django.db.backends.mysql.features import DatabaseFeatures as MySQLDatabaseFeatures from django.utils.functional import cached_property [dee7ef29]
