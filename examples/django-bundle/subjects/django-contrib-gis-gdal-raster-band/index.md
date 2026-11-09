# django/contrib/gis/gdal/raster/band

- Subject: django/contrib/gis/gdal/raster/band (id `b8465f53-60e4-43d3-a343-5cb366382758`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2035 tokens
- Facts shown: 41 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- # Instantiate ctypes array holding the input data if isinstance(data, (bytes, memoryview)) or ( numpy and isinstance(data, numpy.ndarray) ): data_array = ctypes_array.from_buffer_copy(data) else: data_array = ctypes_array(*data) [a4469d89]
- # Access band capi.band_io( self._ptr, access_flag, offset[0], offset[1], size[0], size[1], byref(data_array), shape[0], shape[1], self.datatype(), 0, 0, ) [201df1a2]
- # Computation of statistics fails for empty bands. try: func(*stats_args) result = smin.value, smax.value, smean.value, sstd.value except GDALException: result = (None, None, None, None) [d06bb1b0]
- # Create ctypes type array generator ctypes_array = GDAL_TO_CTYPES[self.datatype()] * (shape[0] * shape[1]) [706e1069]
- # Return data as numpy array if possible, otherwise as list if data is None: if as_memoryview: return memoryview(data_array) elif numpy: # reshape() needs a reshape parameter with the height first. return numpy.frombuffer( data_array, dtype=numpy.dtype(data_array) ).reshape(tuple(reversed(size))) else: return list(data_array) else: self._flush() [d1b1c869]
- Allowed input data types are bytes, memoryview, list, tuple, and array. """ offset = offset or (0, 0) size = size or (self.width - offset[0], self.height - offset[1]) shape = shape or size if any(x <= 0 for x in size): raise ValueError("Offset too big for this raster.") [6eaa9b4e]
- For empty bands (where all pixel values are nodata), all statistics values are returned as None. [1ca6ef85]
- For raster formats using Persistent Auxiliary Metadata (PAM) services, the statistics might be cached in an auxiliary file. """ # Prepare array with arguments for capi function smin, smax, smean, sstd = c_double(), c_double(), c_double(), c_double() stats_args = [ self._ptr, c_int(approximate), byref(smin), byref(smax), byref(smean), byref(sstd), c_void_p(), c_void_p(), ] [595fa8e2]
- If approximate=True, the statistics may be computed based on overviews or a subset of image tiles. [90e584b7]
- If refresh=True, the statistics will be computed from the data directly, and the cache will be updated where applicable. [5487c505]
- The return value is a tuple with the following structure: (minimum, maximum, mean, standard deviation). [cdfcbc48]
- if data is None: # Set read mode access_flag = 0 # Prepare empty ctypes array data_array = ctypes_array() else: # Set write mode access_flag = 1 [0a2a9d62]
- if refresh or self._stats_refresh: func = capi.compute_band_statistics else: # Add additional argument to force computation if there is no # existing PAM file to take the values from. force = True stats_args.insert(2, c_int(force)) func = capi.get_band_statistics [df8703c4]
- if size[0] > self.width or size[1] > self.height: raise ValueError("Size is larger than raster.") [abe2f27e]
- return result [e6d2cf0b52c4ebca-2]
- self._stats_refresh = False [43dcc28e]
- @property def description(self): """ Return the description string of the band. """ return force_str(capi.get_band_description(self._ptr)) [5b940c12]
- _stats_refresh = False [87ab0a1d]

## All facts

- [9e8b5b0f] @nodata_value.setter def nodata_value(self, value): """ Set the nodata value for this band. """ if value is None: capi.delete_band_nodata_value(self._ptr) elif not isinstance(value, (int, float)): raise ValueError("Nodata value must be numeric or None.") else: capi.set_band_nodata_value(self._ptr, value) self._flush()
- [40a13f90] @property def height(self): """ Height (Y axis) in pixels of the band. """ return capi.get_band_ysize(self._ptr)
- [ecc42ed0] @property def max(self): """ Return the maximum pixel value for this band. """ return self.statistics()[1]
- [4e25e443] @property def mean(self): """ Return the mean of all pixel values of this band. """ return self.statistics()[2]
- [238430c1] @property def min(self): """ Return the minimum pixel value for this band. """ return self.statistics()[0]
- [64dd7639] @property def nodata_value(self): """ Return the nodata value for this band, or None if it isn't set. """ # Get value and nodata exists flag nodata_exists = c_int() value = capi.get_band_nodata_value(self._ptr, nodata_exists) if not nodata_exists: value = None # If the pixeltype is an integer, convert to int elif self.datatype() in GDAL_INTEGER_TYPES: value = int(value) return value
- [5950dec4] @property def pixel_count(self): """ Return the total number of pixels in this band. """ return self.width * self.height
- [85b3e08e] @property def std(self): """ Return the standard deviation of all pixel values of this band. """ return self.statistics()[3]
- [57ca4271] @property def width(self): """ Width (X axis) in pixels of the band. """ return capi.get_band_xsize(self._ptr)
- [37d2fc35] def __getitem__(self, index): try: return GDALBand(self.source, index + 1) except GDALException: raise GDALException("Unable to get band index %d" % index)
- [f1265f97] def __init__(self, source, index): self.source = source self._ptr = capi.get_ds_raster_band(source._ptr, index)
- [c232f4fb] def __iter__(self): for idx in range(1, len(self) + 1): yield GDALBand(self.source, idx)
- [d5402236] def __len__(self): return capi.get_ds_raster_count(self.source._ptr)
- [12ef1f1f] def _flush(self): """ Call the flush method on the Band's parent raster and force a refresh of the statistics attribute when requested the next time. """ self.source._flush() self._stats_refresh = True
- [dcbc2d95] def color_interp(self, as_string=False): """Return the GDAL color interpretation for this band.""" color = capi.get_band_color_interp(self._ptr) if as_string: color = GDAL_COLOR_TYPES[color] return color
- [75134d17] def data(self, data=None, offset=None, size=None, shape=None, as_memoryview=False): """ Read or writes pixel values for this band. Blocks of data can be accessed by specifying the width, height and offset of the desired block. The same specification can be used to update parts of a raster by providing an array of values.
- [62557dcb] def datatype(self, as_string=False): """ Return the GDAL Pixel Datatype for this band. """ dtype = capi.get_band_datatype(self._ptr) if as_string: dtype = GDAL_PIXEL_TYPES[dtype] return dtype
- [debe6aca] def statistics(self, refresh=False, approximate=False): """ Compute statistics on the pixel values of this band.
- [5f8b137b] class BandList(list): def __init__(self, source): self.source = source super().__init__()
- [04c8fbd6] class GDALBand(GDALRasterBase): """ Wrap a GDAL raster band, needs to be obtained from a GDALRaster object. """
- [93c3c1d7] from .const import ( GDAL_COLOR_TYPES, GDAL_INTEGER_TYPES, GDAL_PIXEL_TYPES, GDAL_TO_CTYPES, )
- [b9421a4a] from ctypes import byref, c_double, c_int, c_void_p
- [df331759] from django.contrib.gis.gdal.error import GDALException from django.contrib.gis.gdal.prototypes import raster as capi from django.contrib.gis.gdal.raster.base import GDALRasterBase from django.contrib.gis.shortcuts import numpy from django.utils.encoding import force_str
