# django/contrib/gis/db/backends/base/operations

- Subject: django/contrib/gis/db/backends/base/operations (id `b7262e04-9f17-4d50-a618-f73607e8b4ad`)
- Kind: subject
- Budget: 1200 tokens
- Used: 887 tokens
- Facts shown: 15 of 26
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

11 more facts did not fit in the budget: [648aaf02] [9bc9d74f] [6070610e] [cd2b232d] [c90bc85b] [5ce3a9ae] [767ea9c7] [2430aee2] [a8a8d71e] [6713eefd] [8a0e488e]
