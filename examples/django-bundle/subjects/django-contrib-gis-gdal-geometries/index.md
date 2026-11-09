# django/contrib/gis/gdal/geometries

- Subject: django/contrib/gis/gdal/geometries (id `d68a82af-63d3-431e-bc11-52f11b3e96e4`)
- Kind: subject
- Budget: 1200 tokens
- Used: 895 tokens
- Facts shown: 13 of 131
- Conflicts: 0
- Gaps: 0

## Facts

- raise GEOSException(f"GEOS does not support {self.__class__.__qualname__}.") [9ad9f494]
- return GEOSGeometry(self._geos_ptr(), self.srid) else: from django.contrib.gis.geos import GEOSException [08b42980]
- # Assigning the SpatialReference object to the geometry, if valid. if srs: self.srs = srs [4081280d]
- # Constructing the geometry, if str_instance: wkt_m = wkt_regex.match(geom_input) json_m = json_regex.match(geom_input) if wkt_m: if wkt_m["srid"]: # If there's EWKT, set the SRS w/value of the SRID. srs = int(wkt_m["srid"]) if wkt_m["type"].upper() == "LINEARRING": # OGR_G_CreateFromWkt doesn't work with LINEARRING WKT. # See https://trac.osgeo.org/gdal/ticket/1992. g = capi.create_geom(OGRGeomType(wkt_m["type"]).num) capi.import_wkt(g, byref(c_char_p(wkt_m["wkt"].encode()))) else: g = capi.from_wkt( byref(c_char_p(wkt_m["wkt"].encode())), None, byref(c_void_p()) ) elif json_m: ExternalCRSBlocker.check(geom_input) g = self._from_json(geom_input.encode()) else: # Seeing if the input is a valid short-hand string # (e.g., 'Point', 'POLYGON'). OGRGeomType(geom_input) g = capi.create_geom(OGRGeomType(geom_input).num) elif isinstance(geom_input, memoryview): # WKB was passed in g = self._from_wkb(geom_input) elif isinstance(geom_input, OGRGeomType): # OGRGeomType was passed in, an empty geometry will be created. g = capi.create_geom(geom_input.num) elif isinstance(geom_input, self.ptr_type): # OGR pointer (c_void_p) was the input. g = geom_input else: raise GDALException( "Invalid input type for OGR Geometry construction: %s" % type(geom_input) ) [aa7d5d5a]
- # Depending on the input type, use the appropriate OGR routine # to perform the transformation. if isinstance(coord_trans, CoordTransform): capi.geom_transform(self.ptr, coord_trans.ptr) elif isinstance(coord_trans, SpatialReference): capi.geom_transform_to(self.ptr, coord_trans.ptr) elif isinstance(coord_trans, (int, str)): sr = SpatialReference(coord_trans) capi.geom_transform_to(self.ptr, sr.ptr) else: raise TypeError( "Transform only accepts CoordTransform, " "SpatialReference, string, and integer objects." ) [26aeed9e]
- # If HEX, unpack input to a binary buffer. if str_instance and hex_regex.match(geom_input): geom_input = memoryview(bytes.fromhex(geom_input)) str_instance = False [799f0cf1]
- # Now checking the Geometry pointer before finishing initialization # by setting the pointer for the object. if not g: raise GDALException( "Cannot create OGR Geometry from input: %s" % geom_input ) self.ptr = g [70d5a891]
- # Returning the output of the given function with the other geometry's # pointer. return func(self.ptr, other.ptr) [c6fc9acb]
- # Setting the class depending upon the OGR Geometry Type if (geo_class := GEO_CLASSES.get(self.geom_type.num)) is None: raise TypeError(f"Unsupported geometry type: {self.geom_type}") self.__class__ = geo_class [444c0afb]
- return GEOSGeometry._from_wkb(self.wkb) [adba36ee]
- return geos.Point._create_empty() if self.empty else super()._geos_ptr() [9eddf1ef]
- # ### Geometry set-like operations ### # g = g1 | g2 def __or__(self, other): "Return the union of the two geometries." return self.union(other) [77ffe140]
- coords = tuple [7cf2067ea4ba94b9]

## Beyond the budget

113 more facts did not fit in the budget: [5e20080e] [ec6a4cb3] [b6f809ae] [d0e4dc6f] [0d7f8e0b] [0c384041] [3b82c4ab] [6b061859] [ff9d6e64] [d21a5e5d] [4dc7cd28d7a4c211] [d7b7b05329b3f842] [d189103cb5203371] [55888a49] [53646d2b] [fda79ce6] [2ba30a73] [c42ded23] [16d64327] [401da02a] [4197ba46] [bd4daaa8] [09b6f234] [33fb653f] [bb3c897a] [095eed05] [213a325c] [fa80dfbe] [d80dfd12] [88b40628] [da009fa3] [8d9bec09] [e76e30e2] [46d9335b] [6979a0eb] [fde84338] [72a04e2d] [969307f5] [e5d444ae] [023f99f8] [c4b2833b] [418a40b3] [6f9ac626] [3f7776e0] [8dc49a2b] [b6a640e8] [dcdd77f8] [91c56df1] [1daffa0a] [093ce40e] [a5dd01f8] [63a30b6c] [1d0a26aa] [a9d397fe] [2642009d] [0b13ea13] [ce4c986d] [89f0686b] [079cee78] [7cf2067ea4ba94b9-2] [7cf2067ea4ba94b9-3] [7cf2067ea4ba94b9-4] [c344ebca] [f372e61d] [c365f1de] [17f3770c] [64c27b46] [2d3f521e] [53f141ab] [e8c8c34a] [10ee2147] [079a5800] [a9706768] [1fa2ce8f] [a806d16e] [c560406a] [50ec4487] [7e1d19d4] [928889ae] [7f7755fd] [88b843db] [1d846f59] [7a8fce0b] [1b3dfa0b] [e7202c9f] [8977ec75] [a1e51d6b] [b0fc5c20] [0543f419] [bb57a036f17ae469] [ac9e11c0] [ada563ff] [5d844635] [f751f4e3] [226ea547] [f6abe666] [c36c46b3] [b3753c2e] [fa646070] [853fbc76] [f12c2ba0] [8478227f] [d9f2e930] [057c5848] [8c545e97] [d0bf9b2b] [c4f0e048] [bdbdc983] [b857b59e] [26e6f1ce] [e47dacb8] [d19a4d70] [4d6d71b6]
