# django/contrib/gis/db/backends/postgis/features

- Subject: django/contrib/gis/db/backends/postgis/features (id `9579dca1-d3f4-4c1d-8213-2c7ed408e561`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 128 tokens
- Facts shown: 2 facts
- Conflicts: 0
- Gaps: 0

## Facts

- class DatabaseFeatures(BaseSpatialFeatures, PsycopgDatabaseFeatures): supports_geography = True supports_3d_storage = True supports_3d_functions = True supports_raster = True supports_empty_geometries = True empty_intersection_returns_none = False [d350eea6]
- from django.contrib.gis.db.backends.base.features import BaseSpatialFeatures from django.db.backends.postgresql.features import ( DatabaseFeatures as PsycopgDatabaseFeatures, ) [6df3cdc3]
