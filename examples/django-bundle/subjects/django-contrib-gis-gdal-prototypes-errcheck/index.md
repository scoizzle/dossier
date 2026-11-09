# django/contrib/gis/gdal/prototypes/errcheck

- Subject: django/contrib/gis/gdal/prototypes/errcheck (id `dcfec2dd-9c87-4933-b05d-4ea5020df84c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 874 tokens
- Facts shown: 15 of 16
- Conflicts: 0
- Gaps: 0

## Facts

- """ This module houses the error-checking routines used by the GDAL ctypes prototypes. """ [bfe4727c]
- # ### DataSource, Layer error-checking ### [497ed6b4]
- # ### Envelope checking ### def check_envelope(result, func, cargs, offset=-1): "Check a function that returns an OGR Envelope by reference." return ptr_byref(cargs, offset) [87df4172]
- # ### Geometry error-checking routines ### def check_geom(result, func, cargs): "Check a function that returns a geometry." # OGR_G_Clone may return an integer, even though the # restype is set to c_void_p if isinstance(result, int): result = c_void_p(result) if not result: raise GDALException( 'Invalid geometry pointer returned from "%s".' % func.__name__ ) return result [d2408330]
- # ### Other error-checking routines ### def check_arg_errcode(result, func, cargs, cpl=False): """ The error code is returned in the last argument, by reference. Check its value with `check_err` before returning the result. """ check_err(arg_byref(cargs), cpl=cpl) return result [cc6768e7]
- # ### Spatial Reference error-checking routines ### def check_srs(result, func, cargs): if isinstance(result, int): result = c_void_p(result) if not result: raise SRSException( 'Invalid spatial reference pointer returned from "%s".' % func.__name__ ) return result [dda29e94]
- # ### String checking Routines ### def check_const_string(result, func, cargs, offset=None, cpl=False): """ Similar functionality to `check_string`, but does not free the pointer. """ if offset: check_err(result, cpl=cpl) ptr = ptr_byref(cargs, offset) return ptr.value else: return result [634fc504]
- # Helper routines for retrieving pointers and/or values from # arguments passed in by reference. def arg_byref(args, offset=-1): "Return the pointer argument's by-reference value." return args[offset]._obj.value [7802edeb]
- def check_errcode(result, func, cargs, cpl=False): """ Check the error code returned (c_int). """ check_err(result, cpl=cpl) [2abec586]
- def check_geom_offset(result, func, cargs, offset=-1): "Check the geometry at the given offset in the C parameter list." check_err(result) geom = ptr_byref(cargs, offset=offset) return check_geom(geom, func, cargs) [69c9b1a7]
- def check_pointer(result, func, cargs): "Make sure the result pointer is valid." if isinstance(result, int): result = c_void_p(result) if result: return result else: raise GDALException('Invalid pointer returned from "%s"' % func.__name__) [d722610e]
- def check_str_arg(result, func, cargs): """ This is for the OSRGet[Angular|Linear]Units functions, which require that the returned string pointer not be freed. This returns both the double and string values. """ dbl = result ptr = cargs[-1]._obj return dbl, ptr.value.decode() [8fbb883e]
- def ptr_byref(args, offset=-1): "Return the pointer argument passed in by-reference." return args[offset]._obj [441cf97c]
- from ctypes import c_void_p, string_at [40e1cf854b4083dd]
- from django.contrib.gis.gdal.error import GDALException, SRSException, check_err from django.contrib.gis.gdal.libgdal import lgdal [9c10b272]

## Beyond the budget

1 more facts did not fit in the budget: [8228e8f6]
