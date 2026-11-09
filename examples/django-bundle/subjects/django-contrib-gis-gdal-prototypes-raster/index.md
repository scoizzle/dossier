# django/contrib/gis/gdal/prototypes/raster

- Subject: django/contrib/gis/gdal/prototypes/raster (id `328371ae-223e-4df8-8fb0-835b7bada0db`)
- Kind: subject
- Budget: 1200 tokens
- Used: 827 tokens
- Facts shown: 8 of 10
- Conflicts: 0
- Gaps: 0

## Facts

- """ This module houses the ctypes function prototypes for GDAL DataSource (raster) related data structures. """ [cce4d79f]
- # Create VSI gdal raster files from in-memory buffers. # https://gdal.org/api/cpl.html#cpl-vsi-h create_vsi_file_from_mem_buffer = voidptr_output( std_call("VSIFileFromMemBuffer"), [c_char_p, c_void_p, c_int, c_int] ) get_mem_buffer_from_vsi_file = voidptr_output( std_call("VSIGetMemFileBuffer"), [c_char_p, POINTER(c_int), c_bool] ) unlink_vsi_file = int_output(std_call("VSIUnlink"), [c_char_p]) [b64779fd]
- # For more detail about c function names and definitions see # https://gdal.org/api/raster_c_api.html # https://gdal.org/doxygen/gdalwarper_8h.html # https://gdal.org/api/gdal_utils.html [857f3aba]
- # Prepare partial functions that use cpl error codes void_output = partial(void_output, cpl=True) const_string_output = partial(const_string_output, cpl=True) double_output = partial(double_output, cpl=True) [b4360828]
- # Raster Band Routines band_io = void_output( std_call("GDALRasterIO"), [ c_void_p, c_int, c_int, c_int, c_int, c_int, c_void_p, c_int, c_int, c_int, c_int, c_int, ], ) get_band_xsize = int_output(std_call("GDALGetRasterBandXSize"), [c_void_p]) get_band_ysize = int_output(std_call("GDALGetRasterBandYSize"), [c_void_p]) get_band_index = int_output(std_call("GDALGetBandNumber"), [c_void_p]) get_band_description = const_string_output(std_call("GDALGetDescription"), [c_void_p]) get_band_ds = voidptr_output(std_call("GDALGetBandDataset"), [c_void_p]) get_band_datatype = int_output(std_call("GDALGetRasterDataType"), [c_void_p]) get_band_color_interp = int_output( std_call("GDALGetRasterColorInterpretation"), [c_void_p] ) get_band_nodata_value = double_output( std_call("GDALGetRasterNoDataValue"), [c_void_p, POINTER(c_int)] ) set_band_nodata_value = void_output( std_call("GDALSetRasterNoDataValue"), [c_void_p, c_double] ) delete_band_nodata_value = void_output( std_call("GDALDeleteRasterNoDataValue"), [c_void_p] ) get_band_statistics = void_output( std_call("GDALGetRasterStatistics"), [ c_void_p, c_int, c_int, POINTER(c_double), POINTER(c_double), POINTER(c_double), POINTER(c_double), c_void_p, c_void_p, ], ) compute_band_statistics = void_output( std_call("GDALComputeRasterStatistics"), [ c_void_p, c_int, POINTER(c_double), POINTER(c_double), POINTER(c_double), POINTER(c_double), c_void_p, c_void_p, ], ) [4d22028c]
- # Reprojection routine reproject_image = void_output( std_call("GDALReprojectImage"), [ c_void_p, c_char_p, c_void_p, c_char_p, c_int, c_double, c_double, c_void_p, c_void_p, c_void_p, ], ) auto_create_warped_vrt = voidptr_output( std_call("GDALAutoCreateWarpedVRT"), [c_void_p, c_char_p, c_char_p, c_int, c_double, c_void_p], ) [782179f7]
- from ctypes import POINTER, c_bool, c_char_p, c_double, c_int, c_void_p from functools import partial [45c30e6d]
- from django.contrib.gis.gdal.libgdal import std_call from django.contrib.gis.gdal.prototypes.generation import ( chararray_output, const_string_output, double_output, int_output, void_output, voidptr_output, ) [07fb1d27]

## Beyond the budget

2 more facts did not fit in the budget: [13d6fe7e] [c33a3766]
