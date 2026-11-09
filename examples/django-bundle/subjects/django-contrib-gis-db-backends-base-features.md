# django/contrib/gis/db/backends/base/features

- Subject: django/contrib/gis/db/backends/base/features (id `d076efa1-cb52-4e99-b6fb-b755246f398e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 895 tokens
- Facts shown: 20 of 23
- Conflicts: 0
- Gaps: 0

## Facts

- # Can SchemaEditor alter geometry fields? can_alter_geometry_field = True [92b65a48]
- # Do the database functions/aggregates support the tolerance parameter? supports_tolerance_parameter = False [01f86394]
- # Does Intersection() return None (rather than an empty GeometryCollection) # for empty results? empty_intersection_returns_none = True [b8749048]
- # Does the backend support expressions for specifying distance in the # dwithin lookup? supports_dwithin_distance_expr = True [3132f712]
- # Does the backend support the django.contrib.gis.utils.add_srs_entry() # utility? supports_add_srs_entry = True # Does the backend introspect GeometryField to its subtypes? supports_geometry_field_introspection = True [f7038766]
- # Does the database contain a SpatialRefSys model to store SRID # information? has_spatialrefsys_table = True [109d17aa]
- # Does the database have a geography type? supports_geography = False # Does the backend support storing 3D geometries? supports_3d_storage = False # Reference implementation of 3D functions is: # https://postgis.net/docs/PostGIS_Special_Functions_Index.html#PostGIS_3D_Functions supports_3d_functions = False # Does the database support SRID transform operations? supports_transform = True # Can geometry fields be null? supports_null_geometries = True # Are empty geometries supported? supports_empty_geometries = False # Can the function be applied on geodetic coordinate systems? supports_distance_geodetic = True supports_length_geodetic = True supports_perimeter_geodetic = False supports_area_geodetic = True # Is the database able to count vertices on polygons (with `num_points`)? supports_num_points_poly = True [3f00dc8e]
- # Does the database have raster support? supports_raster = False [18dc5fd2]
- # Does the database support a unique index on geometry fields? supports_geometry_field_unique_index = True [ade92e42]
- # Is the aggregate supported by the database? @property def supports_collect_aggr(self): return models.Collect not in self.connection.ops.disallowed_aggregates [9c5af3f6]
- # Set of options that AsGeoJSON() doesn't support. unsupported_geojson_options = {} [fdd8b8df]
- @property def supports_crosses_lookup(self): return "crosses" in self.connection.ops.gis_operators [a985cfd2]
- @property def supports_distances_lookups(self): return self.has_Distance_function [8fbf513b]
- @property def supports_extent_aggr(self): return models.Extent not in self.connection.ops.disallowed_aggregates [632b2293]
- @property def supports_isvalid_lookup(self): return self.has_IsValid_function [bf37150b]
- @property def supports_make_line_aggr(self): return models.MakeLine not in self.connection.ops.disallowed_aggregates [9b864c3d]
- @property def supports_relate_lookup(self): return "relate" in self.connection.ops.gis_operators [13dcf351]
- class BaseSpatialFeatures: gis_enabled = True [545fbbea]
- from .operations import BaseSpatialOperations [5a3da30f]
- from django.contrib.gis.db import models [bf251de1]

## Beyond the budget

2 more facts did not fit in the budget: [18ae6101] [dae3b101b4aa9562-3]
