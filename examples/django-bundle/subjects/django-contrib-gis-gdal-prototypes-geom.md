# django/contrib/gis/gdal/prototypes/geom

- Subject: django/contrib/gis/gdal/prototypes/geom (id `94af4074-b6fc-4d79-a191-a1ff08670210`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 9 of 18
- Conflicts: 0
- Gaps: 0

## Facts

- # ### Generation routines specific to this module ### def env_func(f, argtypes): "For getting OGREnvelopes." f.argtypes = argtypes f.restype = None f.errcheck = check_envelope return f [99af82ff]
- # ### OGR_G ctypes function prototypes ### [5551d05a]
- # Destroys a geometry destroy_geom = void_output(lgdal.OGR_G_DestroyGeometry, [c_void_p], errcheck=False) [2039ae87]
- # For retrieving the envelope of the geometry. get_envelope = env_func(lgdal.OGR_G_GetEnvelope, [c_void_p, POINTER(OGREnvelope)]) [4f910183]
- # GeoJSON routines. from_json = geom_output(lgdal.OGR_G_CreateGeometryFromJson, [c_char_p]) to_json = string_output( lgdal.OGR_G_ExportToJson, [c_void_p], str_result=True, decoding="ascii" ) to_kml = string_output( lgdal.OGR_G_ExportToKML, [c_void_p, c_char_p], str_result=True, decoding="ascii" ) [1b98b50d]
- # Geometry creation routines. from_wkb = geom_output( lgdal.OGR_G_CreateFromWkbEx, [c_char_p, c_void_p, POINTER(c_void_p), c_int], offset=-2, ) from_wkt = geom_output( lgdal.OGR_G_CreateFromWkt, [POINTER(c_char_p), c_void_p, POINTER(c_void_p)], offset=-1, ) from_gml = geom_output(lgdal.OGR_G_CreateFromGML, [c_char_p]) create_geom = geom_output(lgdal.OGR_G_CreateGeometry, [c_int]) clone_geom = geom_output(lgdal.OGR_G_Clone, [c_void_p]) get_geom_ref = geom_output(lgdal.OGR_G_GetGeometryRef, [c_void_p, c_int]) get_boundary = geom_output(lgdal.OGR_G_GetBoundary, [c_void_p]) geom_convex_hull = geom_output(lgdal.OGR_G_ConvexHull, [c_void_p]) geom_diff = geom_output(lgdal.OGR_G_Difference, [c_void_p, c_void_p]) geom_intersection = geom_output(lgdal.OGR_G_Intersection, [c_void_p, c_void_p]) geom_sym_diff = geom_output(lgdal.OGR_G_SymmetricDifference, [c_void_p, c_void_p]) geom_union = geom_output(lgdal.OGR_G_Union, [c_void_p, c_void_p]) is_3d = bool_output(lgdal.OGR_G_Is3D, [c_void_p]) set_3d = void_output(lgdal.OGR_G_Set3D, [c_void_p, c_int], errcheck=False) is_measured = bool_output(lgdal.OGR_G_IsMeasured, [c_void_p]) set_measured = void_output(lgdal.OGR_G_SetMeasured, [c_void_p, c_int], errcheck=False) has_curve_geom = bool_output(lgdal.OGR_G_HasCurveGeometry, [c_void_p, c_int]) get_linear_geom = geom_output( lgdal.OGR_G_GetLinearGeometry, [c_void_p, c_double, POINTER(c_char_p)] ) get_curve_geom = geom_output( lgdal.OGR_G_GetCurveGeometry, [c_void_p, POINTER(c_char_p)] ) [3813b9e7]
- # Geometry export routines. to_wkb = void_output( lgdal.OGR_G_ExportToWkb, None, errcheck=True ) # special handling for WKB. to_iso_wkb = void_output(lgdal.OGR_G_ExportToIsoWkb, None, errcheck=True) to_wkt = string_output( lgdal.OGR_G_ExportToWkt, [c_void_p, POINTER(c_char_p)], decoding="ascii" ) to_iso_wkt = string_output( lgdal.OGR_G_ExportToIsoWkt, [c_void_p, POINTER(c_char_p)], decoding="ascii" ) to_gml = string_output( lgdal.OGR_G_ExportToGML, [c_void_p], str_result=True, decoding="ascii" ) get_wkbsize = int_output(lgdal.OGR_G_WkbSizeEx, [c_void_p]) [ec1d14b1]
- # Geometry modification routines. add_geom = void_output(lgdal.OGR_G_AddGeometry, [c_void_p, c_void_p]) import_wkt = void_output(lgdal.OGR_G_ImportFromWkt, [c_void_p, POINTER(c_char_p)]) [1e063a50]
- # Geometry spatial-reference related routines. assign_srs = void_output( lgdal.OGR_G_AssignSpatialReference, [c_void_p, c_void_p], errcheck=False ) get_geom_srs = srs_output(lgdal.OGR_G_GetSpatialReference, [c_void_p]) [61e139c2]

## Beyond the budget

9 more facts did not fit in the budget: [2122ba1c] [62631d2a] [8bd1bc9b] [525555f8] [42fa70bf] [2d6495c7] [91fcca29] [abe8d3bd] [d296613f]
