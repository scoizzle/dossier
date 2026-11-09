# django/contrib/gis/db/backends/oracle/operations

- Subject: django/contrib/gis/db/backends/oracle/operations (id `5411833a-fe2c-4690-bc83-ed9ab91a1dc6`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2243 tokens
- Facts shown: 36 facts
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [fa7ab7f1] def get_distance(self, f, value, lookup_type): """ Return the distance parameters given the value and the lookup type. On Oracle, geometry columns with a geodetic coordinate system behave implicitly like a geography column, and thus meters will be used as the distance parameter on them. """ if not value: return [] value = value[0] if isinstance(value, Distance): if f.geodetic(self.connection): dist_param = value.m else: dist_param = getattr( value, Distance.unit_attname(f.units_name(self.connection)) ) else: dist_param = value
- [c34c662c] def get_geom_placeholder_sql(self, f, value, compiler): if value is None: return "NULL", () return super().get_geom_placeholder_sql(f, value, compiler)
- [65d28d30d056178b-2] def get_geometry_converter(self, expression): read = wkb_r().read srid = expression.output_field.srid if srid == -1: srid = None geom_class = expression.output_field.geom_class
- [1b332f3a] def modify_insert_params(self, placeholder, params): """Drop out insert parameters for NULL placeholder. Needed for Oracle Spatial backend due to #10888. """ if placeholder == "NULL": return [] return super().modify_insert_params(placeholder, params)
- [1c07c71f] def spatial_aggregate_name(self, agg_name): """ Return the spatial aggregate SQL name. """ agg_name = "unionagg" if agg_name.lower() == "union" else agg_name.lower() return getattr(self, agg_name)
- [9ce65ebe] def spatial_ref_sys(self): from django.contrib.gis.db.backends.oracle.models import OracleSpatialRefSys
- [cd053499] extent = "SDO_AGGR_MBR" unionagg = "SDO_AGGR_UNION"
- [936ec9d0] from_text = "SDO_GEOMETRY"
- [fcd75098] function_names = { "Area": "SDO_GEOM.SDO_AREA", "AsGeoJSON": "SDO_UTIL.TO_GEOJSON", "AsWKB": "SDO_UTIL.TO_WKBGEOMETRY", "AsWKT": "SDO_UTIL.TO_WKTGEOMETRY", "BoundingCircle": "SDO_GEOM.SDO_MBC", "Centroid": "SDO_GEOM.SDO_CENTROID", "Difference": "SDO_GEOM.SDO_DIFFERENCE", "Distance": "SDO_GEOM.SDO_DISTANCE", "Envelope": "SDO_GEOM_MBR", "FromWKB": "SDO_UTIL.FROM_WKBGEOMETRY", "FromWKT": "SDO_UTIL.FROM_WKTGEOMETRY", "Intersection": "SDO_GEOM.SDO_INTERSECTION", "IsValid": "SDO_GEOM.VALIDATE_GEOMETRY_WITH_CONTEXT", "Length": "SDO_GEOM.SDO_LENGTH", "NumGeometries": "SDO_UTIL.GETNUMELEM", "NumPoints": "SDO_UTIL.GETNUMVERTICES", "Perimeter": "SDO_GEOM.SDO_LENGTH", "PointOnSurface": "SDO_GEOM.SDO_POINTONSURFACE", "Reverse": "SDO_UTIL.REVERSE_LINESTRING", "SymDifference": "SDO_GEOM.SDO_XOR", "Transform": "SDO_CS.TRANSFORM", "Union": "SDO_GEOM.SDO_UNION", }
- [a91a3ade] gis_operators = { "contains": SDOOperator(func="SDO_CONTAINS"), "coveredby": SDOOperator(func="SDO_COVEREDBY"), "covers": SDOOperator(func="SDO_COVERS"), "disjoint": SDODisjoint(), "intersects": SDOOperator( func="SDO_OVERLAPBDYINTERSECT" ), # TODO: Is this really the same as ST_Intersects()? "equals": SDOOperator(func="SDO_EQUAL"), "exact": SDOOperator(func="SDO_EQUAL"), "overlaps": SDOOperator(func="SDO_OVERLAPS"), "same_as": SDOOperator(func="SDO_EQUAL"), # Oracle uses a different syntax, e.g., 'mask=inside+touch' "relate": SDORelate(), "touches": SDOOperator(func="SDO_TOUCH"), "within": SDOOperator(func="SDO_INSIDE"), "dwithin": SDODWithin(), }
- [5b0ef17c] """ This module contains the spatial lookup types, and the `get_geo_where_clause` routine for Oracle Spatial.
- [22d414d5] DEFAULT_TOLERANCE = "0.05"
- [89cb30bf] Please note that WKT support is broken on the XE version, and thus this backend will not work on such platforms. Specifically, XE lacks support for an internal JVM, and Java libraries are required to use the WKT constructors. """
- [4879b302] class OracleOperations(BaseSpatialOperations, DatabaseOperations): name = "oracle" oracle = True disallowed_aggregates = (models.Collect, models.Extent3D, models.MakeLine)
- [a463b855] class SDODWithin(SpatialOperator): sql_template = "SDO_WITHIN_DISTANCE(%(lhs)s, %(rhs)s, %%s) = 'TRUE'"
- [b9d317f0] class SDODisjoint(SpatialOperator): sql_template = ( "SDO_GEOM.RELATE(%%(lhs)s, 'DISJOINT', %%(rhs)s, %s) = 'DISJOINT'" % DEFAULT_TOLERANCE )
- [9f9f40db] class SDOOperator(SpatialOperator): sql_template = "%(func)s(%(lhs)s, %(rhs)s) = 'TRUE'"
- [a201b115] class SDORelate(SpatialOperator): sql_template = "SDO_RELATE(%(lhs)s, %(rhs)s, 'mask=%(mask)s') = 'TRUE'"
- [6b5e0d6c] from django.contrib.gis.db import models from django.contrib.gis.db.backends.base.operations import BaseSpatialOperations from django.contrib.gis.db.backends.oracle.adapter import OracleSpatialAdapter from django.contrib.gis.db.backends.utils import SpatialOperator from django.contrib.gis.geos.geometry import GEOSGeometry, GEOSGeometryBase from django.contrib.gis.geos.prototypes.io import wkb_r from django.contrib.gis.measure import Distance from django.db.backends.oracle.operations import DatabaseOperations from django.utils.functional import cached_property
- [dae3b101b4aa9562-4] import re
