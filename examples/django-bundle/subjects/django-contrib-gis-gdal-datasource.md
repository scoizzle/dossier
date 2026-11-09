# django/contrib/gis/gdal/datasource

- Subject: django/contrib/gis/gdal/datasource (id `f08fe94d-ba74-4051-b66a-aeeba2473207`)
- Kind: subject
- Budget: 1200 tokens
- Used: 889 tokens
- Facts shown: 16 of 21
- Conflicts: 0
- Gaps: 0

## Facts

- # Get the type (integer) of the field, e.g. 0 => OFTInteger t = field.type [fb871e0b]
- # Returns the value the field; OFTIntegers return ints, # OFTReal returns floats, all else returns string. val = field.value """ [1c29efcf]
- # Getting the 'description' field for the feature. desc = feature['description'] [1ec08275]
- # We can also increment through all of the fields # attached to this feature. for field in feature: # Get the name of the field (e.g. 'description') nm = field.name [804a288e]
- Driver.ensure_registered() [6036b5ac]
- if ds: self.ptr = ds driver = capi.get_dataset_driver(ds) self.driver = Driver(driver) else: # Raise an exception if the returned pointer is NULL raise GDALException('Invalid data source file "%s"' % ds_input) [6a140763]
- if isinstance(ds_input, (str, Path)): try: # GDALOpenEx will auto-detect the data source type. ds = capi.open_ds( force_bytes(ds_input), self._write | capi.GDAL_OF_VECTOR, None, None, None, ) except GDALException: # Making the error message more clear rather than something # like "Invalid pointer returned from OGROpen". raise GDALException('Could not open the datasource at "%s"' % ds_input) elif isinstance(ds_input, self.ptr_type) and isinstance( ds_driver, Driver.ptr_type ): ds = ds_input else: raise GDALException("Invalid data source input type: %s" % type(ds_input)) [dae8a0eb]
- @property def layer_count(self): "Return the number of layers in the data source." return capi.get_layer_count(self._ptr) [1ee9a4bd]
- @property def name(self): "Return the name of the data source." name = capi.get_ds_name(self._ptr) return force_str(name, self.encoding, strings_only=True) [61283c02]
- def __getitem__(self, index): "Allows use of the index [] operator to get a layer at the index." if isinstance(index, str): try: layer = capi.get_layer_by_name(self.ptr, force_bytes(index)) except GDALException: raise IndexError("Invalid OGR layer name given: %s." % index) elif isinstance(index, int): if 0 <= index < self.layer_count: layer = capi.get_layer(self._ptr, index) else: raise IndexError( "Index out of range when accessing layers in a datasource: %s." % index ) else: raise TypeError("Invalid index type: %s" % type(index)) return Layer(layer, self) [417b7bb1]
- def __init__(self, ds_input, ds_driver=False, write=False, encoding="utf-8"): # The write flag. self._write = capi.GDAL_OF_UPDATE if write else capi.GDAL_OF_READONLY # See also https://gdal.org/development/rfc/rfc23_ogr_unicode.html self.encoding = encoding [4968dcc0]
- def __len__(self): "Return the number of layers within the data source." return self.layer_count [8cb08fee]
- def __str__(self): "Return OGR GetName and Driver for the Data Source." return "%s (%s)" % (self.name, self.driver) [d0335571]
- destructor = capi.destroy_ds [d0d157b8]
- """ DataSource is a wrapper for the OGR Data Source object, which provides an interface for reading vector geometry data from many different file formats (including ESRI shapefiles). [b6f012d1]
- The ds_driver keyword is used internally when a ctypes pointer is passed in directly. [68341570]

## Beyond the budget

5 more facts did not fit in the budget: [6bc0b572] [a4d742ed] [c3e7bc9b] [f6031cd8] [8d8744708e7830c8]
