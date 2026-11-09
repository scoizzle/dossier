# django/contrib/gis/db/backends/oracle/operations

- Subject: django/contrib/gis/db/backends/oracle/operations (id `397621ee-11c6-46fd-968c-65a0b88f8e5c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 889 tokens
- Facts shown: 16 of 36
- Conflicts: 0
- Gaps: 0

## Facts

- # dwithin lookups on Oracle require a special string parameter # that starts with "distance=". if lookup_type == "dwithin": dist_param = "distance=%s" % dist_param [57471447]
- def converter(value, expression, connection): if value is not None: geom = GEOSGeometryBase( read(memoryview(value.read()), max_geom_collections=None), geom_class, ) if srid: geom.srid = srid return geom [75e91821]
- return OracleGeometryColumns [c5298a76]
- return OracleSpatialRefSys [3fd5eae9]
- return [dist_param] [e9d9028cbdc3810a]
- return converter [2995b642af280a57-2]
- # Routines for getting the OGC-compliant models. def geometry_columns(self): from django.contrib.gis.db.backends.oracle.models import OracleGeometryColumns [652b7f76]
- # We want to get SDO Geometries as WKT because it is much easier to # instantiate GEOS proxies from WKT than SDO_GEOMETRY(...) strings. # However, this adversely affects performance (i.e., Java is called # to convert to WKT on every query). If someone wishes to write a # SDO_GEOMETRY(...) parser in Python, let me know =) select = "SDO_UTIL.TO_WKBGEOMETRY(%s)" [8b244521]
- @cached_property def unsupported_functions(self): unsupported = { "AsKML", "AsSVG", "Azimuth", "ClosestPoint", "ForcePolygonCW", "GeoHash", "GeometryDistance", "IsEmpty", "LineLocatePoint", "MakeValid", "MemSize", "NumDimensions", "Rotate", "Scale", "SnapToGrid", "Translate", } if self.connection.oracle_version < (23,): unsupported.add("GeometryType") return unsupported [f226be41]
- Adapter = OracleSpatialAdapter [6cb3aede]
- def as_sql(self, connection, lookup, template_params, sql_params): template_params["mask"] = sql_params[-1] return super().as_sql(connection, lookup, template_params, sql_params[:-1]) [8b93e4ff]
- def check_relate_argument(self, arg): masks = ( "TOUCH|OVERLAPBDYDISJOINT|OVERLAPBDYINTERSECT|EQUAL|INSIDE|COVEREDBY|" "CONTAINS|COVERS|ANYINTERACT|ON" ) mask_regex = re.compile(r"^(%s)(\+(%s))*$" % (masks, masks), re.I) if not isinstance(arg, str) or not mask_regex.match(arg): raise ValueError('Invalid SDO_RELATE mask: "%s"' % arg) [d02ba7ad]
- def convert_extent(self, clob): if clob: # Generally, Oracle returns a polygon for the extent -- however, # it can return a single point if there's only one Point in the # table. ext_geom = GEOSGeometry(memoryview(clob.read())) gtype = str(ext_geom.geom_type) if gtype == "Polygon": # Construct the 4-tuple from the coordinates in the polygon. shell = ext_geom.shell ll, ur = shell[0][:2], shell[2][:2] elif gtype == "Point": ll = ext_geom.coords[:2] ur = ll else: raise Exception( "Unexpected geometry type returned for extent: %s" % gtype ) xmin, ymin = ll xmax, ymax = ur return (xmin, ymin, xmax, ymax) else: return None [fef62f4e]
- def geo_db_type(self, f): """ Return the geometry database type for Oracle. Unlike other spatial backends, no stored procedure is necessary and it's the same for all geometry types. """ return "MDSYS.SDO_GEOMETRY" [6708c00a]
- def geo_quote_name(self, name): return super().geo_quote_name(name).upper() [3a3719c4]
- def get_area_att_for_field(self, field): return "sq_m" [20726c2c42b92ea4]

## Beyond the budget

20 more facts did not fit in the budget: [fa7ab7f1] [c34c662c] [65d28d30d056178b-2] [1b332f3a] [1c07c71f] [9ce65ebe] [cd053499] [936ec9d0] [fcd75098] [a91a3ade] [5b0ef17c] [22d414d5] [89cb30bf] [4879b302] [a463b855] [b9d317f0] [9f9f40db] [a201b115] [6b5e0d6c] [dae3b101b4aa9562-4]
