# django/contrib/gis/db/backends/mysql/operations

- Subject: django/contrib/gis/db/backends/mysql/operations (id `bbad4816-dd05-439c-bb75-cf856389e500`)
- Kind: subject
- Budget: 1200 tokens
- Used: 886 tokens
- Facts shown: 13 of 18
- Conflicts: 0
- Gaps: 0

## Facts

- def converter(value, expression, connection): if value is not None: geom = GEOSGeometryBase( read(memoryview(value), max_geom_collections=None), geom_class ) if srid: geom.srid = srid return geom [1af64a28]
- return converter [2995b642af280a57]
- @cached_property def collect(self): if self.connection.features.supports_collect_aggr: return self.geom_func_prefix + "Collect" [944b38e8]
- @cached_property def disallowed_aggregates(self): disallowed_aggregates = [ models.Extent, models.Extent3D, models.MakeLine, models.Union, ] is_mariadb = self.connection.mysql_is_mariadb if is_mariadb: if self.connection.mysql_version < (12, 0, 1): disallowed_aggregates.insert(0, models.Collect) return tuple(disallowed_aggregates) [50211536]
- @cached_property def from_text(self): return self.geom_func_prefix + "GeomFromText" [29b2589f]
- @cached_property def gis_operators(self): operators = { "bbcontains": SpatialOperator( func="MBRContains" ), # For consistency w/PostGIS API "bboverlaps": SpatialOperator(func="MBROverlaps"), # ... "contained": SpatialOperator(func="MBRWithin"), # ... "contains": SpatialOperator(func="ST_Contains"), "coveredby": SpatialOperator(func="MBRCoveredBy"), "crosses": SpatialOperator(func="ST_Crosses"), "disjoint": SpatialOperator(func="ST_Disjoint"), "equals": SpatialOperator(func="ST_Equals"), "exact": SpatialOperator(func="ST_Equals"), "intersects": SpatialOperator(func="ST_Intersects"), "overlaps": SpatialOperator(func="ST_Overlaps"), "same_as": SpatialOperator(func="ST_Equals"), "touches": SpatialOperator(func="ST_Touches"), "within": SpatialOperator(func="ST_Within"), } if self.connection.mysql_is_mariadb: operators["relate"] = SpatialOperator(func="ST_Relate") if self.connection.mysql_version < (12, 0, 1): del operators["coveredby"] else: operators["covers"] = SpatialOperator(func="MBRCovers") return operators [e4b915e1]
- @cached_property def mariadb(self): return self.connection.mysql_is_mariadb [110bb96b]
- @cached_property def select(self): return self.geom_func_prefix + "AsBinary(%s)" [a36196bb]
- @cached_property def unsupported_functions(self): unsupported = { "AsGML", "AsKML", "AsSVG", "Azimuth", "BoundingCircle", "ClosestPoint", "ForcePolygonCW", "GeometryDistance", "IsEmpty", "LineLocatePoint", "MakeValid", "MemSize", "NumDimensions", "Perimeter", "PointOnSurface", "Reverse", "Rotate", "Scale", "SnapToGrid", "Transform", "Translate", } if self.connection.mysql_is_mariadb: unsupported.remove("PointOnSurface") if self.connection.mysql_version < (12, 0, 1): unsupported.update({"GeoHash", "IsValid"}) return unsupported [a6006700]
- Adapter = WKTAdapter [3667f111]
- def geo_db_type(self, f): return f.geom_type [d4b0058b]
- def get_distance(self, f, value, lookup_type): value = value[0] if isinstance(value, Distance): if f.geodetic(self.connection): raise ValueError( "Only numeric values of degree units are allowed on " "geodetic distance queries." ) dist_param = getattr( value, Distance.unit_attname(f.units_name(self.connection)) ) else: dist_param = value return [dist_param] [2a9fec00]
- def spatial_aggregate_name(self, agg_name): return getattr(self, agg_name.lower()) [93c8d9f0]

## Beyond the budget

4 more facts did not fit in the budget: [65d28d30d056178b] [4541b879] [347dcdc6] [5e487577]
