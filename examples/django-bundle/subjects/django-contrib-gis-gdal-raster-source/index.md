# django/contrib/gis/gdal/raster/source

- Subject: django/contrib/gis/gdal/raster/source (id `e42f68a3-1e2c-4a25-b777-4fb2232b2815`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 17 of 72
- Conflicts: 0
- Gaps: 0

## Facts

- # Check if srid was specified if "srid" not in ds_input: raise GDALException("Specify srid for JSON or dict input.") [e26fc91c]
- # Check if width and height where specified if "width" not in ds_input or "height" not in ds_input: raise GDALException( "Specify width and height attributes for JSON or dict input." ) [11ac2c41]
- # Convert papszlist to ctypes array. papsz_options = (c_char_p * len(papsz_options))(*papsz_options) [215bf610]
- # Create GDAL Raster self._ptr = capi.create_ds( driver._ptr, force_bytes(ds_input.get("name", "")), ds_input["width"], ds_input["height"], ds_input.get("nr_of_bands", len(ds_input.get("bands", []))), ds_input.get("datatype", 6), byref(papsz_options), ) [082fdfa1]
- # Create driver (in memory by default) driver = Driver(ds_input.get("driver", "MEM")) [84c51475]
- # Create null terminated gdal options array. papsz_options = [] for key, val in ds_input.get("papsz_options", {}).items(): option = "{}={}".format(key, val) papsz_options.append(option.upper().encode()) papsz_options.append(None) [5c27d759]
- # For out of memory drivers, check filename argument if driver.name != "MEM" and "name" not in ds_input: raise GDALException( 'Specify name for creation of raster with driver "{}".'.format( driver.name ) ) [cb8d34a3]
- # Set SRID self.srs = ds_input.get("srid") [4815c597]
- # Set additional properties if provided if "origin" in ds_input: self.origin.x, self.origin.y = ds_input["origin"] [6bfd9f77]
- # Set band data if provided for i, band_input in enumerate(ds_input.get("bands", [])): band = self.bands[i] if "nodata_value" in band_input: band.nodata_value = band_input["nodata_value"] # Instantiate band filled with nodata values if only # partial input data has been provided. if band.nodata_value is not None and ( "data" not in band_input or "size" in band_input or "shape" in band_input ): band.data(data=(band.nodata_value,), shape=(1, 1)) # Set band data values from input. band.data( data=band_input.get("data"), size=band_input.get("size"), shape=band_input.get("shape"), offset=band_input.get("offset"), ) [fc621a95]
- if "scale" in ds_input: self.scale.x, self.scale.y = ds_input["scale"] [fa9da91d]
- if "skew" in ds_input: self.skew.x, self.skew.y = ds_input["skew"] elif isinstance(ds_input, c_void_p): # Instantiate the object using an existing pointer to a gdal # raster. self._ptr = ds_input else: raise GDALException( 'Invalid data source input type: "{}".'.format(type(ds_input)) ) [09851cd7]
- # Construct the target warp dictionary from the virtual raster data = { "srid": target_srs.srid, "width": target.width, "height": target.height, "origin": [target.origin.x, target.origin.y], "scale": [target.scale.x, target.scale.y], "skew": [target.skew.x, target.skew.y], } [ed0ea8e9]
- # Create target raster target = GDALRaster(ds_input, write=True) [6953901e]
- # Instantiate raster bands filled with nodata values. ds_input["bands"] = [{"nodata_value": bnd.nodata_value} for bnd in self.bands] [920d76e4]
- # Make sure all data is written to file target._flush() [34f1d35e]
- if name: data["name"] = name [50850a83]

## Beyond the budget

55 more facts did not fit in the budget: [fdba076e] [2f032fa4] [bc8f166c] [1de4eef8] [bc926009] [b499156a] [f6b90486] [906168dc] [57d6ebd8] [da204551] [1594ee05] [b85b4c1b] [2d23fb8f] [f1c248fc] [e3fe78a8] [ff84f674] [8864fef5] [8d1a80a5] [1eeb7091] [6a4ee244] [420274bb] [65815939] [7fe4b97b] [2b014e6b] [d705cf15] [d4c09cfe] [09dc8ae3] [4553dd59] [6229916e] [a5307b57] [4cbe6d55] [a75cc041] [fb5b3bbc] [81840410] [ffb9de3d] [d000b5f0] [2a7394c1] [a7c675dc] [b89a582b] [8ebb62b9] [d04ef159] [129190a5] [9e849e3d] [21e30619] [5e7b3fdc80e0535c-3] [33e4bb64] [df2f541b] [b3fd4b41] [ac797beb] [1809ed23] [f0ecab0d] [341a7e2c] [0949a706] [8de2d4f8] [41e82814]
