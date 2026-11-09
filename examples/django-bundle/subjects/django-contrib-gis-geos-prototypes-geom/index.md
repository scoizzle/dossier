# django/contrib/gis/geos/prototypes/geom

- Subject: django/contrib/gis/geos/prototypes/geom (id `5716955f-d525-4d28-baae-7c2c7fe57783`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1027 tokens
- Facts shown: 19 of 19
- Conflicts: 0
- Gaps: 0

## Highlights

- argtypes = [GEOM_PTR] restype = c_int errcheck = staticmethod(check_minus_one) [2141f6a8]
- argtypes = [GEOM_PTR] restype = geos_char_p errcheck = staticmethod(check_string) [00998840]
- restype = GEOM_PTR errcheck = staticmethod(check_geom) [f2e672c7]
- # ### ctypes factory classes ### class GeomOutput(GEOSFuncFactory): "For GEOS routines that return a geometry." [375c7026]
- # ### ctypes prototypes ### [343628900675080d]
- # Cloning geom_clone = GEOSFuncFactory("GEOSGeom_clone", argtypes=[GEOM_PTR], restype=GEOM_PTR) [c6991b61]
- # Collection Routines get_geomn = GeomOutput("GEOSGetGeometryN", argtypes=[GEOM_PTR, c_int]) [66c882ee]
- # Destruction routine. destroy_geom = GEOSFuncFactory("GEOSGeom_destroy", argtypes=[GEOM_PTR]) [003a9dae]
- # Geometry creation factories create_point = GeomOutput("GEOSGeom_createPoint", argtypes=[CS_PTR]) create_linestring = GeomOutput("GEOSGeom_createLineString", argtypes=[CS_PTR]) create_linearring = GeomOutput("GEOSGeom_createLinearRing", argtypes=[CS_PTR]) [80fa7251]
- # Polygon and collection creation routines need argument types defined # for compatibility with some platforms, e.g. macOS ARM64. With argtypes # defined, arrays are automatically cast and byref() calls are not needed. create_polygon = GeomOutput( "GEOSGeom_createPolygon", argtypes=[GEOM_PTR, POINTER(GEOM_PTR), c_uint], ) create_empty_polygon = GeomOutput("GEOSGeom_createEmptyPolygon", argtypes=[]) create_collection = GeomOutput( "GEOSGeom_createCollection", argtypes=[c_int, POINTER(GEOM_PTR), c_uint], ) [1a86085c]
- # Ring routines get_extring = GeomOutput("GEOSGetExteriorRing", argtypes=[GEOM_PTR]) get_intring = GeomOutput("GEOSGetInteriorRingN", argtypes=[GEOM_PTR, c_int]) get_nrings = IntFromGeom("GEOSGetNumInteriorRings") [6d9bb807]
- # SRID routines geos_get_srid = GEOSFuncFactory("GEOSGetSRID", argtypes=[GEOM_PTR], restype=c_int) geos_set_srid = GEOSFuncFactory("GEOSSetSRID", argtypes=[GEOM_PTR, c_int]) [dfefda61]
- # The GEOS geometry type, typeid, num_coordinates and number of geometries geos_makevalid = GeomOutput("GEOSMakeValid", argtypes=[GEOM_PTR]) geos_normalize = IntFromGeom("GEOSNormalize") geos_type = StringFromGeom("GEOSGeomType") geos_typeid = IntFromGeom("GEOSGeomTypeId") get_dims = GEOSFuncFactory("GEOSGeom_getDimensions", argtypes=[GEOM_PTR], restype=c_int) get_num_coords = IntFromGeom("GEOSGetNumCoordinates") get_num_geoms = IntFromGeom("GEOSGetNumGeometries") [4d40ecef]
- # This is the return type used by binary output (WKB, HEX) routines. c_uchar_p = POINTER(c_ubyte) [673cc3b0]
- # We create a simple subclass of c_char_p here because when the response # type is set to c_char_p, you get a _Python_ string and there's no way # to access the string's address inside the error checking function. # In other words, you can't free the memory allocated inside GEOS. Previously, # the return type would just be omitted and the integer address would be # used -- but this allows us to be specific in the function definition and # keeps the reference so it may be free'd. class geos_char_p(c_char_p): pass [4a9535c6]

## All facts

- [8711e53e] class IntFromGeom(GEOSFuncFactory): "Argument is a geometry, return type is an integer."
- [9057b6c7] class StringFromGeom(GEOSFuncFactory): "Argument is a Geometry, return type is a string."
- [ffa7e0a7] from ctypes import POINTER, c_char_p, c_int, c_ubyte, c_uint
- [b99232aa] from django.contrib.gis.geos.libgeos import CS_PTR, GEOM_PTR, GEOSFuncFactory from django.contrib.gis.geos.prototypes.errcheck import ( check_geom, check_minus_one, check_string, )
