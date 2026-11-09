# django/contrib/gis/gdal/feature

- Subject: django/contrib/gis/gdal/feature (id `e24eb792-2b63-4ceb-a785-b9acad04baa6`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 16 of 17
- Conflicts: 0
- Gaps: 0

## Facts

- # #### Feature Methods #### def get(self, field): """ Return the value of the field, instead of an instance of the Field object. May take a string of the field name or a Field object as parameters. """ field_name = getattr(field, "name", field) return self[field_name].value [dac9b04c]
- # #### Feature Properties #### @property def encoding(self): return self._layer._ds.encoding [627fab18]
- @property def fid(self): "Return the feature identifier." return capi.get_fid(self.ptr) [43fc8e6f]
- @property def fields(self): "Return a list of fields in the Feature." return [ force_str( capi.get_field_name(capi.get_field_defn(self._layer._ldefn, i)), self.encoding, strings_only=True, ) for i in range(self.num_fields) ] [4a918485]
- @property def geom(self): "Return the OGR Geometry for this Feature." # Retrieving the geometry pointer for the feature. geom_ptr = capi.get_feat_geom_ref(self.ptr) return OGRGeometry(geom_api.clone_geom(geom_ptr)) [ccd8fde2]
- @property def geom_type(self): "Return the OGR Geometry Type for this Feature." return OGRGeomType(capi.get_fd_geom_type(self._layer._ldefn)) [eb002d3b]
- @property def layer_name(self): "Return the name of the layer for the feature." name = capi.get_feat_name(self._layer._ldefn) return force_str(name, self.encoding, strings_only=True) [c51931be]
- @property def num_fields(self): "Return the number of fields in the Feature." return capi.get_feat_field_count(self.ptr) [bcbbbe3a]
- def __eq__(self, other): "Do equivalence testing on the features." return bool(capi.feature_equal(self.ptr, other._ptr)) [1e52f5c7]
- def __getitem__(self, index): """ Get the Field object at the specified index, which may be either an integer or the Field's string label. Note that the Field object is not the field's _value_ -- use the `get` method instead to retrieve the value (e.g. an integer) instead of a Field instance. """ if isinstance(index, str): i = self.index(index) elif 0 <= index < self.num_fields: i = index else: raise IndexError( "Index out of range when accessing field in a feature: %s." % index ) return Field(self, i) [3422fd6b]
- def __init__(self, feat, layer): """ Initialize Feature from a pointer and its Layer object. """ if not feat: raise GDALException("Cannot create OGR Feature, invalid pointer given.") self.ptr = feat self._layer = layer [a5ccaa5c]
- def __len__(self): "Return the count of fields in this feature." return self.num_fields [ca1d6e7f]
- def __str__(self): "The string name of the feature." return "Feature FID %d in Layer<%s>" % (self.fid, self.layer_name) [54951efc]
- def index(self, field_name): "Return the index of the given field name." i = capi.get_field_index(self.ptr, force_bytes(field_name)) if i < 0: raise IndexError("Invalid OFT field name given: %s." % field_name) return i [289e3261]
- destructor = capi.destroy_feature [efd0907b]
- # For more information, see the OGR C API source code: # https://gdal.org/api/vector_c_api.html # # The OGR_F_* routines are relevant here. class Feature(GDALBase): """ This class that wraps an OGR Feature, needs to be instantiated from a Layer object. """ [0a3a0f21]

## Beyond the budget

1 more facts did not fit in the budget: [02d972f3]
