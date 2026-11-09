# django/contrib/gis/db/backends/base/operations

- Subject: django/contrib/gis/db/backends/base/operations (id `dfb9d38c-5e09-4935-aeab-13852e688442`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1713 tokens
- Facts shown: 26 of 26
- Conflicts: 0
- Gaps: 0

## Highlights

- # Aggregates disallowed_aggregates = () [653eb2cb]
- # Constructors from_text = False [25030410]
- # Default conversion functions for aggregates; will be overridden if # implemented for the spatial backend. def convert_extent(self, box, srid): raise NotImplementedError( "Aggregate extent not implemented for this spatial backend." ) [0edd65c6]
- # For quoting column values, rather than columns. def geo_quote_name(self, name): return "'%s'" % name [10208221]
- # GeometryField operations def geo_db_type(self, f): """ Return the database column type for the geometry field on the spatial backend. """ raise NotImplementedError( "subclasses of BaseSpatialOperations must provide a geo_db_type() method" ) [9808ca59]
- # How the geometry column should be selected. select = "%s" [4d9db367]
- # Mapping between Django function names and backend names, when names do # not match; used in spatial_function_name(). function_names = {} [85cfa3b2]
- # Routines for getting the OGC-compliant models. def geometry_columns(self): raise NotImplementedError( "Subclasses of BaseSpatialOperations must provide a geometry_columns() " "method." ) [06d5c59d]
- # Set of known unsupported functions of the backend unsupported_functions = { "Area", "AsGeoJSON", "AsGML", "AsKML", "AsSVG", "AsWKB", "AsWKT", "Azimuth", "BoundingCircle", "Centroid", "ClosestPoint", "Difference", "Distance", "DistanceSpheroid", "Envelope", "ForcePolygonCW", "FromWKB", "FromWKT", "GeoHash", "GeometryDistance", "GeometryType", "Intersection", "IsEmpty", "IsValid", "Length", "LineLocatePoint", "MakeValid", "MemSize", "NumDimensions", "NumGeometries", "NumPoints", "Perimeter", "PointOnSurface", "Reverse", "Rotate", "Scale", "SnapToGrid", "SymDifference", "Transform", "Translate", "Union", } [5a0919d8]
- @cached_property def select_extent(self): return self.select [3bdf479d]
- @staticmethod def _must_transform_value(value, field): if value is None: return False if value.srid == field.srid: return False if field.srid is None: raise ValueError("Cannot transform a spatial value to an undefined SRID.") return True [20923160]
- def check_expression_support(self, expression): if isinstance(expression, self.disallowed_aggregates): raise NotSupportedError( "%s spatial aggregation is not supported by this database backend." % expression.name ) super().check_expression_support(expression) [1d60db17]
- def convert_extent3d(self, box, srid): raise NotImplementedError( "Aggregate 3D extent not implemented for this spatial backend." ) [8f9d1559]
- def get_area_att_for_field(self, field): if field.geodetic(self.connection): if self.connection.features.supports_area_geodetic: return "sq_m" raise NotImplementedError( "Area on geodetic coordinate systems not supported." ) else: units_name = field.units_name(self.connection) if units_name: return AreaMeasure.unit_attname(units_name) [8a3fb6ef]
- def get_db_converters(self, expression): converters = super().get_db_converters(expression) if isinstance(expression.output_field, GeometryField): converters.append(self.get_geometry_converter(expression)) return converters [d904b325]

## All facts

- [648aaf02] def get_distance(self, f, value, lookup_type): """ Return the distance parameters for the given geometry field, lookup value, and lookup type. """ raise NotImplementedError( "Distance operations not available on this spatial backend." )
- [9bc9d74f] def get_distance_att_for_field(self, field): dist_att = None if field.geodetic(self.connection): if self.connection.features.supports_distance_geodetic: dist_att = "m" else: units = field.units_name(self.connection) if units: dist_att = DistanceMeasure.unit_attname(units) return dist_att
- [6070610e] def get_geom_placeholder_sql(self, f, value, compiler): """ Return the placeholder for the given geometry field with the given value. Depending on the spatial backend, the placeholder may contain a stored procedure call to the transformation function of the spatial backend. """ if hasattr(value, "as_sql"): sql, params = compiler.compile(value) if self._must_transform_value(value.output_field, f): transform_func = self.spatial_function_name("Transform") sql = f"{transform_func}({sql}, %s)" params = (*params, f.srid) return sql, params elif self._must_transform_value(value, f): transform_func = self.spatial_function_name("Transform") sql = f"{transform_func}({self.from_text}(%s, %s), %s)" params = (value, value.srid, f.srid) return sql, params elif self.connection.features.has_spatialrefsys_table: return f"{self.from_text}(%s, %s)", (value, f.srid) else: # For backwards compatibility on MySQL (#27464). return f"{self.from_text}(%s)", (value,)
- [cd2b232d] def get_geometry_converter(self, expression): raise NotImplementedError( "Subclasses of BaseSpatialOperations must provide a " "get_geometry_converter() method." )
- [c90bc85b] def spatial_aggregate_name(self, agg_name): raise NotImplementedError( "Aggregate support not implemented for this spatial backend." )
- [5ce3a9ae] def spatial_function_name(self, func_name): if func_name in self.unsupported_functions: raise NotSupportedError( "This backend doesn't support the %s function." % func_name ) return self.function_names.get(func_name, self.geom_func_prefix + func_name)
- [767ea9c7] def spatial_ref_sys(self): raise NotImplementedError( "subclasses of BaseSpatialOperations must a provide spatial_ref_sys() " "method" )
- [2430aee2] distance_expr_for_lookup = staticmethod(Distance)
- [a8a8d71e] geom_func_prefix = ""
- [6713eefd] class BaseSpatialOperations: # Quick booleans for the type of this spatial backend, and # an attribute for the spatial database version tuple (if applicable) postgis = False spatialite = False mariadb = False mysql = False oracle = False spatial_version = None
- [8a0e488e] from django.contrib.gis.db.models import GeometryField from django.contrib.gis.db.models.functions import Distance from django.contrib.gis.measure import Area as AreaMeasure from django.contrib.gis.measure import Distance as DistanceMeasure from django.db import NotSupportedError from django.utils.functional import cached_property
