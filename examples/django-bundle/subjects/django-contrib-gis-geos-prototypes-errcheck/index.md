# django/contrib/gis/geos/prototypes/errcheck

- Subject: django/contrib/gis/geos/prototypes/errcheck (id `1373329e-47fb-4196-ba0d-9417c969b5da`)
- Kind: subject
- Budget: 1200 tokens
- Used: 711 tokens
- Facts shown: 12 of 13
- Conflicts: 0
- Gaps: 0

## Facts

- This frees the memory allocated by GEOS at the result pointer. """ if not result: raise GEOSException( 'Error encountered checking string return value in GEOS C function "%s".' % func.__name__ ) # Getting the string value at the pointer address. s = string_at(result) # Freeing the memory allocated within GEOS free(result) return s [c84af224]
- This frees the memory allocated by GEOS at the result pointer. """ if not result: raise GEOSException( 'Invalid string pointer returned by GEOS C function "%s"' % func.__name__ ) # A c_size_t object is passed in by reference for the second # argument on these routines, and its needed to determine the # correct size. s = string_at(result, last_arg_byref(cargs)) # Freeing the memory allocated within GEOS free(result) return s [de766394]
- """ Error checking functions for GEOS ctypes prototype functions. """ [1612121e]
- # Getting the `free` routine used to free the memory allocated for # string pointers returned by GEOS. free = GEOSFuncFactory("GEOSFree") free.argtypes = [c_void_p] [d76ccdc9]
- def check_dbl(result, func, cargs): """ Check the status code and returns the double value passed in by reference. """ # Checking the status code if result != 1: return None # Double passed in by reference, return its value. return last_arg_byref(cargs) [1799af7f]
- def check_geom(result, func, cargs): "Error checking on routines that return Geometries." if not result: raise GEOSException( 'Error encountered checking Geometry returned from GEOS C function "%s".' % func.__name__ ) return result [7e539663]
- def check_minus_one(result, func, cargs): "Error checking on routines that should not return -1." if result == -1: raise GEOSException( 'Error encountered in GEOS C function "%s".' % func.__name__ ) else: return result [dd05613a]
- def check_predicate(result, func, cargs): "Error checking for unary/binary predicate functions." if result == 1: return True elif result == 0: return False else: raise GEOSException( 'Error encountered on GEOS C predicate function "%s".' % func.__name__ ) [1e9cf0fa]
- def check_sized_string(result, func, cargs): """ Error checking for routines that return explicitly sized strings. [51ee29a6]
- def last_arg_byref(args): "Return the last C argument's value by reference." return args[-1]._obj.value [d953004e]
- from ctypes import c_void_p, string_at [40e1cf854b4083dd-2]
- from django.contrib.gis.geos.error import GEOSException from django.contrib.gis.geos.libgeos import GEOSFuncFactory [949dc5ce]
