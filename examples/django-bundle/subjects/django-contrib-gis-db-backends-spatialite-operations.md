# django/contrib/gis/db/backends/spatialite/operations

- Subject: django/contrib/gis/db/backends/spatialite/operations (id `29a7c007-96ce-4dd1-9301-ced1a05c2c60`)
- Kind: subject
- Budget: 1200 tokens
- Used: 887 tokens
- Facts shown: 15 of 32
- Conflicts: 0
- Gaps: 0

## Facts

- def converter(value, expression, connection): if value is not None: return GEOSGeometryBase( read(value, max_geom_collections=None), geom_class ) [65534eec]
- return SpatialiteGeometryColumns [6be235db]
- return SpatialiteSpatialRefSys [0e394afd]
- return converter [2995b642af280a57-4]
- # Routines for getting the OGC-compliant models. def geometry_columns(self): from django.contrib.gis.db.backends.spatialite.models import ( SpatialiteGeometryColumns, ) [ed985d33]
- @cached_property def spatial_version(self): """Determine the version of the SpatiaLite library.""" try: version = self.spatialite_version_tuple()[1:] except Exception as exc: raise ImproperlyConfigured( 'Cannot determine the SpatiaLite version for the "%s" database. ' "Was the SpatiaLite initialization SQL loaded on this database?" % (self.connection.settings_dict["NAME"],) ) from exc if version < (4, 3, 0): raise ImproperlyConfigured("GeoDjango supports SpatiaLite 4.3.0 and above.") return version [0cf74f50]
- @cached_property def unsupported_functions(self): unsupported = {"GeometryDistance", "MemSize", "Rotate"} if not self.geom_lib_version(): unsupported |= {"Azimuth", "GeoHash", "MakeValid"} if self.spatial_version < (5, 1): unsupported |= {"BoundingCircle"} return unsupported [b90a4d2c]
- Adapter = SpatiaLiteAdapter [c0661b2e]
- collect = "Collect" extent = "Extent" makeline = "MakeLine" unionagg = "GUnion" [9f4ab2ab]
- def _get_spatialite_func(self, func): """ Helper routine for calling SpatiaLite functions and returning their result. Any error occurring in this method should be handled by the caller. """ cursor = self.connection._cursor() try: cursor.execute("SELECT %s" % func) row = cursor.fetchone() finally: cursor.close() return row[0] [93390f9b]
- def convert_extent(self, box): """ Convert the polygon data received from SpatiaLite to min/max values. """ if box is None: return None shell = GEOSGeometry(box).shell xmin, ymin = shell[0][:2] xmax, ymax = shell[2][:2] return (xmin, ymin, xmax, ymax) [202fcd4d]
- def geo_db_type(self, f): """ Return None because geometry columns are added via the `AddGeometryColumn` stored procedure on SpatiaLite. """ return None [8773cd41]
- def geom_lib_version(self): """ Return the version of the version-dependent geom library used by SpatiaLite. """ if self.spatial_version >= (5,): return self.rttopo_version() else: return self.lwgeom_version() [2fa6a91a]
- def geos_version(self): "Return the version of GEOS used by SpatiaLite as a string." return self._get_spatialite_func("geos_version()") [b059423d]
- def get_distance(self, f, value, lookup_type): """ Return the distance parameters for the given geometry field, lookup value, and lookup type. """ if not value: return [] value = value[0] if isinstance(value, Distance): if f.geodetic(self.connection): if lookup_type == "dwithin": raise ValueError( "Only numeric values of degree units are allowed on " "geographic DWithin queries." ) dist_param = value.m else: dist_param = getattr( value, Distance.unit_attname(f.units_name(self.connection)) ) else: dist_param = value return [dist_param] [15f7f17b]

## Beyond the budget

16 more facts did not fit in the budget: [3e092ab9] [9842a32c] [054c8555] [c9be3c67] [56c74106] [d016ff22] [9fb04e05] [2fc097e2] [94561c64] [94d6c75d] [4b915308] [8c9a1e98] [cac84513] [e7c71b15] [bcbeac10] [1e7debdc]
