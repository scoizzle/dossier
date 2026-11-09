# django/contrib/gis/utils/layermapping

- Subject: django/contrib/gis/utils/layermapping (id `0aea482f-b1a0-40e6-804d-ac132d31c200`)
- Kind: subject
- Budget: 1200 tokens
- Used: 895 tokens
- Facts shown: 10 of 81
- Conflicts: 0
- Gaps: 0

## Facts

- # Getting the geometry (in OGR form), creating # one from the kwargs WKT, adding in additional # geometries, and update the attribute with the # just-updated geometry WKT. geom_value = getattr(m, self.geom_field) if geom_value is None: geom = OGRGeometry(kwargs[self.geom_field]) else: geom = geom_value.ogr new = OGRGeometry(kwargs[self.geom_field]) for g in new: geom.add(g) setattr(m, self.geom_field, geom.wkt) except ObjectDoesNotExist: # No unique model exists yet, create. m = self.model(**kwargs) else: m = self.model(**kwargs) [6a07bf29]
- try: # Attempting to save. m.save(using=self.using) num_saved += 1 if verbose: stream.write( "%s: %s\n" % ("Updated" if is_update else "Saved", m) ) except Exception as msg: if strict: # Bailing out if the `strict` keyword is set. if not silent: stream.write( "Failed to save the feature (id: %s) into the " "model with the keyword arguments:\n" % feat.fid ) stream.write("%s\n" % kwargs) raise elif not silent: stream.write( "Failed to save %s:\n %s\nContinuing\n" % (kwargs, msg) ) [1270f5a0]
- # Can the OGR field type be mapped to the Django field type? if not issubclass(ogr_field, self.FIELD_TYPES[model_field.__class__]): raise LayerMapError( 'OGR field "%s" (of type %s) cannot be mapped to Django %s.' % (ogr_field, ogr_field.__name__, fld_name) ) fields_val = model_field [44cb8feb]
- # Getting the coordinate dimension of the geometry field. coord_dim = model_field.dim [e3942281]
- # Is the OGR field in the Layer? idx = check_ogr_fld(ogr_name) ogr_field = ogr_field_types[idx] [710da3b9]
- # Making sure that the OGR Layer's Geometry is compatible. ltype = self.layer.geom_type if not ( ltype.name.startswith(gtype.name) or self.make_multi(ltype, model_field) ): raise LayerMapError( "Invalid mapping geometry; model has %s%s, " "layer geometry type is %s." % (fld_name, "(dim=3)" if coord_dim == 3 else "", ltype) ) [1b3f2c86]
- # Printing progress information, if requested. if progress and num_feat % progress_interval == 0: stream.write( "Processed %d features, saved %d ...\n" % (num_feat, num_saved) ) [433a5672]
- # Setting the `geom_field` attribute w/the name of the model # field that is a Geometry. Also setting the coordinate # dimension attribute. self.geom_field = field_name self.coord_dim = coord_dim fields_val = model_field elif isinstance(model_field, models.ForeignKey): if isinstance(ogr_name, dict): # Is every given related model mapping field in the Layer? rel_model = model_field.remote_field.model for rel_name, ogr_field in ogr_name.items(): idx = check_ogr_fld(ogr_field) try: rel_model._meta.get_field(rel_name) except FieldDoesNotExist: raise LayerMapError( 'ForeignKey mapping field "%s" not in %s fields.' % (rel_name, rel_model.__class__.__name__) ) fields_val = rel_model else: raise TypeError("ForeignKey mapping must be of dictionary type.") else: # Is the model field type supported by LayerMapping? if model_field.__class__ not in self.FIELD_TYPES: raise LayerMapError( 'Django field type "%s" has no OGR mapping (yet).' % fld_name ) [0e7dd771]
- try: if coord_dim == 3: gtype = OGRGeomType(ogr_name + "25D") else: gtype = OGRGeomType(ogr_name) except GDALException: raise LayerMapError( 'Invalid mapping for GeometryField "%s".' % field_name ) [9d178cc8]
- return kwargs [ed4d2b47]

## Beyond the budget

71 more facts did not fit in the budget: [10dc1cd1] [0f999aa3] [aa195d5e] [fceb023e] [72eec1e2] [49cf8ec8] [b3a8ee7a] [eb1da7eb] [3705f51b] [29ee33f4] [1af596e7] [1c77cc7a] [cdade57b] [c8aaffe6] [a650bc97] [dd69db0c] [0c056ab1] [2da8ffd2] [1ae0ab45] [fe465150] [017a5c49] [f15f0840] [f61acaec] [1a2a38c3] [9dc4f4ca] [9452d80f] [68a5ffd0] [6d3680bd] [3b21bfd5] [ee3901b2] [7a18086a] [a580e699] [c0cf9996] [72367d1f] [44e66b3e] [339e4471] [5c1d5168] [3857c344] [c89dff2b] [a7ccfbc1] [2a426b97] [939c6335] [4f9fc309] [78f97665] [9de140d3] [4290c6c2] [aa945355] [38e4449d] [968d6865] [a73b0182] [f8fc8270] [a19cd225] [1bf05205] [dbcf5d42] [f8e0abe1] [40308b9e] [054a61cc] [a7b005df] [d479b603] [af5c78a8] [934a135c] [7e6b34e3] [f0941358] [826de8c9] [44555a73] [38ab763e] [5793ed90] [0a623553] [436a99ac] [1c46c99f] [c00615b5]
