# django/contrib/gis/gdal/raster/band

- Subject: django/contrib/gis/gdal/raster/band (id `7e5ddca7-6a77-474b-b8f5-606780ca909b`)
- Kind: subject
- Budget: 1200 tokens
- Used: 893 tokens
- Facts shown: 18 of 41
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

23 more facts did not fit in the budget: [9e8b5b0f] [40a13f90] [ecc42ed0] [4e25e443] [238430c1] [64dd7639] [5950dec4] [85b3e08e] [57ca4271] [37d2fc35] [f1265f97] [c232f4fb] [d5402236] [12ef1f1f] [dcbc2d95] [75134d17] [62557dcb] [debe6aca] [5f8b137b] [04c8fbd6] [93c3c1d7] [b9421a4a] [df331759]
