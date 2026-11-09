# django/contrib/gis/db/backends/postgis/operations

- Subject: django/contrib/gis/db/backends/postgis/operations (id `d5b48089-b6c7-4213-9be5-23d053d3e649`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 15 of 56
- Conflicts: 0
- Gaps: 0

## Facts

- return "geography(%s,%d)" % (geom_type, f.srid) else: return "geometry(%s,%d)" % (geom_type, f.srid) [dbb8bad9]
- try: vtup = self.postgis_version_tuple() except ProgrammingError: raise ImproperlyConfigured( 'Cannot determine PostGIS version for database "%s" ' 'using command "SELECT postgis_lib_version()". ' "GeoDjango requires at least PostGIS version 3.2. " "Was the database created from a spatial database " "template?" % self.connection.settings_dict["NAME"] ) version = vtup[1:] return version [f4cf208d]
- # Adding Transform() to the SQL placeholder if the value srid # is not equal to the field srid. if self._must_transform_value(value, f): return f"{transform_func}(%s, %s)", (value, f.srid) return "%s", (value,) [0baca781]
- # Check which input is a raster. lhs_is_raster = lookup.lhs.field.geom_type == "RASTER" rhs_is_raster = isinstance(lookup.rhs, GDALRaster) [3b98d65c]
- # Convert rasters to polygons if necessary. if not self.raster or spheroid: # Operators without raster support. if lhs_is_raster: template_params["lhs"] = "ST_Polygon(%s)" % template_params["lhs"] if rhs_is_raster: template_params["rhs"] = "ST_Polygon(%s)" % template_params["rhs"] elif self.raster == BILATERAL: # Operators with raster support but don't support mixed (rast-geom) # lookups. if lhs_is_raster and not rhs_is_raster: template_params["lhs"] = "ST_Polygon(%s)" % template_params["lhs"] elif rhs_is_raster and not lhs_is_raster: template_params["rhs"] = "ST_Polygon(%s)" % template_params["rhs"] [7a6b3330]
- # Look for band indices and inject them if provided. if lookup.band_lhs is not None and lhs_is_raster: if not isinstance(lookup.band_lhs, int): name = lookup.band_lhs.__class__.__name__ raise TypeError(f"Band index must be an integer, but got {name!r}.") if not self.func: raise ValueError( "Band indices are not allowed for this operator, it works on bbox " "only." ) template_params["lhs"] = "%s, %s" % ( template_params["lhs"], lookup.band_lhs, ) [30b6d901]
- # Shorthand boolean flags. geodetic = f.geodetic(self.connection) geography = f.geography [be4faf1e]
- # Type-based geometries. # TODO: Support 'M' extension. if f.dim == 3: geom_type = f.geom_type + "Z" else: geom_type = f.geom_type if f.geography: if f.srid != 4326: raise NotSupportedError( "PostGIS only supports geography columns with an SRID of 4326." ) [1013ed3f]
- This is the most complex implementation of the spatial backends due to what is supported on geodetic geometry columns vs. what's available on projected geometry columns. In addition, it has to take into account the geography column type. """ # Getting the distance parameter value = dist_val[0] [9c366cf5]
- def converter(value, expression, connection): if value is not None: if isinstance(value, str): # Coming from hex strings. value = value.encode("ascii") return GEOSGeometryBase( read(value, max_geom_collections=None), geom_class ) [370ee352]
- return [dist_param] [e9d9028cbdc3810a-2]
- return converter [2995b642af280a57-3]
- return template_params [9c38decb]
- # Routines for getting the OGC-compliant models. def geometry_columns(self): return PostGISGeometryColumns [eb1d863b]
- Adapter = PostGISAdapter [b0e677a8]

## Beyond the budget

38 more facts did not fit in the budget: [0bc3247e] [18b71fb1] [436bb4c2] [3b955447] [f78e68ab] [8074b7a2] [e08ffc70] [94892b02] [6a79a582] [d7c1db85] [d71af4c2] [efd465f9] [1c17be56] [0e33aa46] [6c5444f0] [20726c2c42b92ea4-2] [238ec787] [dbbdc19d] [565d49c1] [a3557b86] [e34f47dd] [e928a83d] [3b75c719] [88fd8caf] [04a3b7cf] [b01ba265] [e486e9c1] [6bbae539] [6c63e036] [3d4db0af] [09c66272] [0d637c67] [f1f4f1d1] [feb38845] [2ba8c80c] [fd513bc8] [5780403d] [dae3b101b4aa9562-5]
