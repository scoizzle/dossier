# django/contrib/gis/gdal/prototypes/generation

- Subject: django/contrib/gis/gdal/prototypes/generation (id `bacd21e1-2697-434a-8dfb-88a62c895484`)
- Kind: subject
- Budget: 1200 tokens
- Used: 894 tokens
- Facts shown: 20 of 25
- Conflicts: 0
- Gaps: 0

## Facts

- def geomerrcheck(result, func, cargs): return check_geom_offset(result, func, cargs, offset) [4b26886b]
- func.errcheck = geomerrcheck [2f247ec1]
- # Dynamically defining our error-checking function with the # given offset. def _check_str(result, func, cargs): res = check_string(result, func, cargs, offset=offset, str_result=str_result) if res and decoding: res = res.decode(decoding) return res [e4cfdd68]
- def _check_const(result, func, cargs): res = check_const_string(result, func, cargs, offset=offset, cpl=cpl) if res and decoding: res = res.decode(decoding) return res [fb01cab3]
- func.errcheck = _check_const [7f2ebf18]
- func.errcheck = _check_str return func [6dd5bf7f]
- if not offset: # When a geometry pointer is directly returned. func.restype = c_void_p func.errcheck = check_geom else: # Error code returned, geometry is returned by-reference. func.restype = c_int [396b2eeb]
- return func [0928017c9ba5e0ca]
- return func [0928017c9ba5e0ca-2]
- return func [0928017c9ba5e0ca-3]
- """ This module contains functions that generate ctypes prototypes for the GDAL routines. """ [f5ad6ef8]
- class gdal_char_p(c_char_p): pass [042aca60]
- def bool_output(func, argtypes, errcheck=None): """Generate a ctypes function that returns a boolean value.""" func.argtypes = argtypes func.restype = c_bool if errcheck: func.errcheck = errcheck return func [d62dce37]
- def chararray_output(func, argtypes, errcheck=True): """For functions that return a c_char_p array.""" func.argtypes = argtypes func.restype = POINTER(c_char_p) if errcheck: func.errcheck = check_pointer return func [2a4b70fc]
- def const_string_output(func, argtypes, offset=None, decoding=None, cpl=False): func.argtypes = argtypes if offset: func.restype = c_int else: func.restype = c_char_p [edd980ae]
- def double_output(func, argtypes, errcheck=False, strarg=False, cpl=False): "Generate a ctypes function that returns a double value." func.argtypes = argtypes func.restype = c_double if errcheck: func.errcheck = partial(check_arg_errcode, cpl=cpl) if strarg: func.errcheck = check_str_arg return func [cf2ae572]
- def geom_output(func, argtypes, offset=None): """ Generate a function that returns a Geometry either by reference or directly (if the return_geom keyword is set to True). """ # Setting the argument types func.argtypes = argtypes [69acd627]
- def int64_output(func, argtypes): "Generate a ctypes function that returns a 64-bit integer value." func.argtypes = argtypes func.restype = c_int64 return func [95ce9516]
- def int_output(func, argtypes, errcheck=None): "Generate a ctypes function that returns an integer value." func.argtypes = argtypes func.restype = c_int if errcheck: func.errcheck = errcheck return func [4041f4b0]
- def srs_output(func, argtypes): """ Generate a ctypes prototype for the given function with the given C arguments that returns a pointer to an OGR Spatial Reference System. """ func.argtypes = argtypes func.restype = c_void_p func.errcheck = check_srs return func [592c0058]

## Beyond the budget

5 more facts did not fit in the budget: [6205b66a] [7ce9e37e] [d831ebb9] [b4fcda0b] [83554635]
