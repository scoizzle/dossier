# django/contrib/gis/geos/prototypes/coordseq

- Subject: django/contrib/gis/geos/prototypes/coordseq (id `6fa4d6a8-16ae-4b36-9773-b7686f825531`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1007 tokens
- Facts shown: 22 of 22
- Conflicts: 0
- Gaps: 0

## Highlights

- if ordinate: # Get/Set ordinate routines have an extra uint parameter. argtypes = [CS_PTR, c_uint, c_uint, dbl_param] else: argtypes = [CS_PTR, c_uint, dbl_param] [220706d7]
- super().__init__( *args, **{**kwargs, "errcheck": errcheck, "argtypes": argtypes} ) [90c2dfdf]
- @staticmethod def errcheck(result, func, cargs): if not result: raise GEOSException( "Error encountered checking Coordinate Sequence returned from GEOS " 'C function "%s".' % func.__name__ ) return result [acfce445]
- argtypes = [CS_PTR, POINTER(c_uint)] restype = c_int errcheck = staticmethod(check_cs_get) [bf12b0f2]
- def __init__(self, *args, ordinate=False, get=False, **kwargs): if get: # Get routines have double parameter passed-in by reference. errcheck = check_cs_get dbl_param = POINTER(c_double) else: errcheck = check_cs_op dbl_param = c_double [68b6a30f]
- restype = c_int [af0dfe00]
- # ## Coordinate Sequence ctypes prototypes ## [f6daee9c]
- # ## Coordinate sequence prototype factory classes. ## class CsInt(GEOSFuncFactory): "For coordinate sequence routines that return an integer." [bf4b7271]
- # ## Error-checking routines specific to coordinate sequences. ## def check_cs_op(result, func, cargs): "Check the status code of a coordinate sequence operation." if result == 0: raise GEOSException("Could not set value on coordinate sequence") else: return result [44707afb]
- # Coordinate Sequence constructors & cloning. cs_clone = CsOutput("GEOSCoordSeq_clone", argtypes=[CS_PTR]) create_cs = CsOutput("GEOSCoordSeq_create", argtypes=[c_uint, c_uint]) get_cs = CsOutput("GEOSGeom_getCoordSeq", argtypes=[GEOM_PTR]) [3cc90a32]
- # For getting, x, y, z, m cs_getx = CsOperation("GEOSCoordSeq_getX", get=True) cs_gety = CsOperation("GEOSCoordSeq_getY", get=True) cs_getz = CsOperation("GEOSCoordSeq_getZ", get=True) cs_getm = CsOperation("GEOSCoordSeq_getM", get=True) [6a2c2eca]
- # For setting, x, y, z, m cs_setx = CsOperation("GEOSCoordSeq_setX") cs_sety = CsOperation("GEOSCoordSeq_setY") cs_setz = CsOperation("GEOSCoordSeq_setZ") cs_setm = CsOperation("GEOSCoordSeq_setM") [9f4aa41e]
- # Getting, setting ordinate cs_getordinate = CsOperation("GEOSCoordSeq_getOrdinate", ordinate=True, get=True) cs_setordinate = CsOperation("GEOSCoordSeq_setOrdinate", ordinate=True) [d72663f5]
- # These routines return size & dimensions. cs_getsize = CsInt("GEOSCoordSeq_getSize") cs_getdims = CsInt("GEOSCoordSeq_getDimensions") [d0796b01]
- # Unary Predicates cs_hasm = CsUnaryPredicate("GEOSCoordSeq_hasM") [7546c72e]
- class CsOperation(GEOSFuncFactory): "For coordinate sequence operations." [cb8b7a7b]
- class CsOutput(GEOSFuncFactory): restype = CS_PTR [eebc4c76]
- class CsUnaryPredicate(GEOSFuncFactory): argtypes = [CS_PTR] restype = c_byte errcheck = staticmethod(check_predicate) [bbec0d1f]
- cs_is_ccw = GEOSFuncFactory( "GEOSCoordSeq_isCCW", restype=c_int, argtypes=[CS_PTR, POINTER(c_byte)] ) [81b4d809]
- from ctypes import POINTER, c_byte, c_double, c_int, c_uint [71b080e9]

## All facts

- [350eebd7] def check_cs_get(result, func, cargs): "Check the coordinate sequence retrieval." check_cs_op(result, func, cargs) # Object in by reference, return its value. return last_arg_byref(cargs)
- [cd241c84] from django.contrib.gis.geos.libgeos import ( CS_PTR, GEOM_PTR, GEOSFuncFactory, ) from django.contrib.gis.geos.prototypes.errcheck import ( GEOSException, check_predicate, last_arg_byref, )
