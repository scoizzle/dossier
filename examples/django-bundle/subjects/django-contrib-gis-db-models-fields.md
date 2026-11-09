# django/contrib/gis/db/models/fields

- Subject: django/contrib/gis/db/models/fields (id `5d46a3ba-7565-47ee-9608-ba9e996d08bf`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 20 of 66
- Conflicts: 0
- Gaps: 0

## Facts

- # Assigning the SRID value. obj.srid = self.get_srid(obj) return obj [890ac62c]
- # Is this a geography rather than a geometry column? self.geography = geography [b0d2f147]
- # Limit on nested geometry collections, forwarded to the form field to # guard against crashes in GEOS from deeply nested input. self.max_geom_collections = max_geom_collections [8f3a61dc]
- # Oracle-specific private attributes for creating the entry in # `USER_SDO_GEOM_METADATA` self._extent = extent self._tolerance = tolerance [d6aadbfb]
- # Setting the SRID and getting the units. Unit information must be # easily available in the field instance for distance queries. self.srid = srid [e6e8e21c]
- # Setting the index flag with the value of the `spatial_index` keyword. self.spatial_index = spatial_index [5337599c]
- # Setting the verbose_name keyword argument with the positional # first parameter, so this works like normal fields. kwargs["verbose_name"] = verbose_name [8c783b6e]
- # Setup for lazy-instantiated Geometry object. setattr( cls, self.attname, SpatialProxy(self.geom_class or GEOSGeometry, self, load_func=GEOSGeometry), ) [b52cabdb]
- Unless the user opts in by wrapping values in a GDALRaster, raise DisallowedRasterLookup for values that fetch or write to disk. """ if isinstance(value, gdal.GDALRaster): return value gdal.GDALRaster.check_raster_lookup_value(value) if is_candidate: try: return gdal.GDALRaster(value) except GDALException: pass return None [0cdf7a70]
- dim: The number of dimensions for this geometry. Defaults to 2. [b89062bf]
- extent: Customize the extent, in a 4-tuple of WGS 84 coordinates, for the geometry field entry in the `USER_SDO_GEOM_METADATA` table. Defaults to (-180.0, -90.0, 180.0, 90.0). [7b151a4c]
- max_geom_collections: The maximum geometry collection nesting depth accepted before parsing is refused, forwarded to the form field. """ # Setting the dimension of the geometry field. self.dim = dim [00819720]
- spatial_index: Indicates whether to create a spatial index. Defaults to True. Set this instead of 'db_index' for geographic fields since index creation is different for geometry columns. """ [d6605d91]
- srid: The spatial reference system identifier, an OGC standard. Defaults to 4326 (WGS84). [672e5891]
- super().__init__(**kwargs) [fed80386]
- super().__init__(verbose_name=verbose_name, **kwargs) [2caf7551]
- tolerance: Define the tolerance, in meters, to use for the geometry field entry in the `USER_SDO_GEOM_METADATA` table. Defaults to 0.05. [77cf3d78]
- try: band_index = int(name) return type( "SpecificRasterBandTransform", (RasterBandTransform,), {"band_index": band_index}, ) except ValueError: pass return super().get_transform(name) [48e47f05]
- It's used as a base class for GeometryField and RasterField. Defines properties that are common to all GIS fields such as the characteristics of the spatial reference system of the field. """ [39094ad3]
- def db_type(self, connection): return connection.ops.geo_db_type(self) [9e40a02c]

## Beyond the budget

45 more facts did not fit in the budget: [04608ca3] [51dff904] [1e7c7882] [e2385cd3] [7a14eae1] [ba799ad5] [f3d74241] [deb98370] [bfa177fb] [521a2be1] [b90ef025] [63342c6d] [6b9f443b] [00a0e99c] [2d9f6ade] [ba473837] [aea3a721] [f57b7e99] [1295989e] [77380f9d] [24659508] [763714bb] [44f297f8] [0b9e945b] [0b9a5fe9] [c7b60d25] [c61dbe92] [91472603] [bbc33314] [bdc94cc5] [47801074] [77661844] [c00ed55e] [9274edc4] [f007e44b] [dd3868af] [9af39a1b] [207caf7b] [0967c18d] [cd2b5eeb] [afbea20c] [ab6050a8] [55351cb6] [5ecc9761] [ce539f13]
