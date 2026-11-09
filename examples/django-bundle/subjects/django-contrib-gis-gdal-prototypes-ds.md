# django/contrib/gis/gdal/prototypes/ds

- Subject: django/contrib/gis/gdal/prototypes/ds (id `15105072-34bc-4191-934e-5976c1d7aee6`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 8 of 12
- Conflicts: 0
- Gaps: 0

## Facts

- """ This module houses the ctypes function prototypes for OGR DataSource related data structures. OGR_Dr_*, OGR_DS_*, OGR_L_*, OGR_F_*, OGR_Fld_* routines are relevant here. """ [fc9437ef]
- # DataSource open_ds = voidptr_output( lgdal.GDALOpenEx, [c_char_p, c_uint, POINTER(c_char_p), POINTER(c_char_p), POINTER(c_char_p)], ) destroy_ds = void_output(lgdal.GDALClose, [c_void_p], errcheck=False) get_ds_name = const_string_output(lgdal.GDALGetDescription, [c_void_p]) get_dataset_driver = voidptr_output(lgdal.GDALGetDatasetDriver, [c_void_p]) get_layer = voidptr_output(lgdal.GDALDatasetGetLayer, [c_void_p, c_int]) get_layer_by_name = voidptr_output( lgdal.GDALDatasetGetLayerByName, [c_void_p, c_char_p] ) get_layer_count = int_output(lgdal.GDALDatasetGetLayerCount, [c_void_p]) [100d090a]
- # Driver Routines register_all = void_output(lgdal.GDALAllRegister, [], errcheck=False) cleanup_all = void_output(lgdal.GDALDestroyDriverManager, [], errcheck=False) get_driver = voidptr_output(lgdal.GDALGetDriver, [c_int]) get_driver_by_name = voidptr_output( lgdal.GDALGetDriverByName, [c_char_p], errcheck=False ) get_driver_count = int_output(lgdal.GDALGetDriverCount, []) get_driver_description = const_string_output(lgdal.GDALGetDescription, [c_void_p]) [dc34d1af]
- # Feature Definition Routines get_fd_geom_type = int_output(lgdal.OGR_FD_GetGeomType, [c_void_p]) get_fd_name = const_string_output(lgdal.OGR_FD_GetName, [c_void_p]) get_feat_name = const_string_output(lgdal.OGR_FD_GetName, [c_void_p]) get_field_count = int_output(lgdal.OGR_FD_GetFieldCount, [c_void_p]) get_field_defn = voidptr_output(lgdal.OGR_FD_GetFieldDefn, [c_void_p, c_int]) [13dd745f]
- # Feature Routines clone_feature = voidptr_output(lgdal.OGR_F_Clone, [c_void_p]) destroy_feature = void_output(lgdal.OGR_F_Destroy, [c_void_p], errcheck=False) feature_equal = int_output(lgdal.OGR_F_Equal, [c_void_p, c_void_p]) get_feat_geom_ref = geom_output(lgdal.OGR_F_GetGeometryRef, [c_void_p]) get_feat_field_count = int_output(lgdal.OGR_F_GetFieldCount, [c_void_p]) get_feat_field_defn = voidptr_output(lgdal.OGR_F_GetFieldDefnRef, [c_void_p, c_int]) get_fid = int_output(lgdal.OGR_F_GetFID, [c_void_p]) get_field_as_datetime = int_output( lgdal.OGR_F_GetFieldAsDateTime, [c_void_p, c_int, c_int_p, c_int_p, c_int_p, c_int_p, c_int_p, c_int_p], ) get_field_as_double = double_output(lgdal.OGR_F_GetFieldAsDouble, [c_void_p, c_int]) get_field_as_integer = int_output(lgdal.OGR_F_GetFieldAsInteger, [c_void_p, c_int]) get_field_as_integer64 = int64_output( lgdal.OGR_F_GetFieldAsInteger64, [c_void_p, c_int] ) is_field_set = bool_output(lgdal.OGR_F_IsFieldSetAndNotNull, [c_void_p, c_int]) get_field_as_string = const_string_output( lgdal.OGR_F_GetFieldAsString, [c_void_p, c_int] ) get_field_index = int_output(lgdal.OGR_F_GetFieldIndex, [c_void_p, c_char_p]) [0f8faa89]
- # Field Routines get_field_name = const_string_output(lgdal.OGR_Fld_GetNameRef, [c_void_p]) get_field_precision = int_output(lgdal.OGR_Fld_GetPrecision, [c_void_p]) get_field_type = int_output(lgdal.OGR_Fld_GetType, [c_void_p]) get_field_type_name = const_string_output(lgdal.OGR_GetFieldTypeName, [c_int]) get_field_width = int_output(lgdal.OGR_Fld_GetWidth, [c_void_p]) [72d7449e]
- GDAL_OF_ALL = 0x00 GDAL_OF_RASTER = 0x02 GDAL_OF_VECTOR = 0x04 [99c667d0]
- GDAL_OF_READONLY = 0x00 GDAL_OF_UPDATE = 0x01 [8c200a85]

## Beyond the budget

4 more facts did not fit in the budget: [4c59a246] [45e3a6b4] [6ae24ea0] [64973612]
