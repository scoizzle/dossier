# django/contrib/gis/gdal/layer

- Subject: django/contrib/gis/gdal/layer (id `d3639200-15df-4672-8e15-6813bafbf775`)
- Kind: subject
- Budget: 1200 tokens
- Used: 893 tokens
- Facts shown: 13 of 26
- Conflicts: 0
- Gaps: 0

## Facts

- return [GEOSGeometry(feat.geom.wkb) for feat in self] else: return [feat.geom for feat in self] [1ff86c31]
- # #### Layer Methods #### def get_fields(self, field_name): """ Return a list containing the given field name for every Feature in the Layer. """ if field_name not in self.fields: raise GDALException("invalid field name: %s" % field_name) return [feat.get(field_name) for feat in self] [b2d427bd]
- # #### Layer properties #### @property def extent(self): "Return the extent (an Envelope) of this layer." env = OGREnvelope() capi.get_extent(self.ptr, byref(env), 1) return Envelope(env) [903aef84]
- @property def field_precisions(self): "Return the field precisions for the features." return [ capi.get_field_precision(capi.get_field_defn(self._ldefn, i)) for i in range(self.num_fields) ] [de952c13]
- @property def field_types(self): """ Return a list of the types of fields in this Layer. For example, return the list [OFTInteger, OFTReal, OFTString] for an OGR layer that has an integer, a floating-point, and string fields. """ return [ OGRFieldTypes[capi.get_field_type(capi.get_field_defn(self._ldefn, i))] for i in range(self.num_fields) ] [d4a8e294]
- @property def field_widths(self): "Return a list of the maximum field widths for the features." return [ capi.get_field_width(capi.get_field_defn(self._ldefn, i)) for i in range(self.num_fields) ] [7f01b208]
- @property def fields(self): """ Return a list of string names corresponding to each of the Fields available in this Layer. """ return [ force_str( capi.get_field_name(capi.get_field_defn(self._ldefn, i)), self._ds.encoding, strings_only=True, ) for i in range(self.num_fields) ] [54dc17d9]
- @property def geom_type(self): "Return the geometry type (OGRGeomType) of the Layer." return OGRGeomType(capi.get_fd_geom_type(self._ldefn)) [87d9b474]
- @property def name(self): "Return the name of this layer in the Data Source." name = capi.get_fd_name(self._ldefn) return force_str(name, self._ds.encoding, strings_only=True) [9bf2e200]
- @property def num_feat(self, force=1): "Return the number of features in the Layer." return capi.get_feature_count(self.ptr, force) [4180770a]
- @property def num_fields(self): "Return the number of fields in the Layer." return capi.get_field_count(self._ldefn) [35b788d0]
- @property def srs(self): "Return the Spatial Reference used in this Layer." try: ptr = capi.get_layer_srs(self.ptr) return SpatialReference(srs_api.clone_srs(ptr)) except SRSException: return None [8df4bd35]
- def __getitem__(self, index): "Get the Feature at the specified index." if isinstance(index, int): # An integer index was given -- we cannot do a check based on the # number of features because the beginning and ending feature IDs # are not guaranteed to be 0 and len(layer)-1, respectively. if index < 0: raise IndexError("Negative indices are not allowed on OGR Layers.") return self._make_feature(index) elif isinstance(index, slice): # A slice was given start, stop, stride = index.indices(self.num_feat) return [self._make_feature(fid) for fid in range(start, stop, stride)] else: raise TypeError( "Integers and slices may only be used when indexing OGR Layers." ) [f342ac06]

## Beyond the budget

13 more facts did not fit in the budget: [457d289f] [016bff26] [b30efc31] [33768dc5] [dee88d4f] [13f2d0d3] [5fd4afcf] [0b1db48d] [60de95f6] [969f684c] [899e7b6f] [0a8698c8] [a3f25ce6]
