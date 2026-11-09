# django/contrib/gis/geos/linestring

- Subject: django/contrib/gis/geos/linestring (id `3d3386f1-5440-4647-9b68-99e31ef51bd1`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 16 of 31
- Conflicts: 0
- Gaps: 0

## Facts

- if ndim is None: ndim = len(coord) self._checkdim(ndim) elif len(coord) != ndim: raise TypeError("Dimension mismatch.") [838ae612]
- # Calling the base geometry initialization with the returned pointer # from the function. super().__init__(self._init_func(cs.ptr), srid=srid) [3d9263c6]
- # Creating a coordinate sequence object because it is easier to # set the points using its methods. cs = GEOSCoordSeq(capi.create_cs(ncoords, ndim), z=bool(ndim == 3)) point_setter = cs._set_point_3d if ndim == 3 else cs._set_point_2d [b57e20db]
- # If SRID was passed in with the keyword arguments srid = kwargs.get("srid") [0ad3e4d1]
- # create a new coordinate sequence and populate accordingly cs = GEOSCoordSeq(capi.create_cs(length, ndim), z=hasz) for i, c in enumerate(items): cs[i] = c [8c04b3cc]
- Examples: ls = LineString((1, 1), (2, 2)) ls = LineString([(1, 1), (2, 2)]) ls = LineString(array([(1, 1), (2, 2)])) ls = LineString(Point(1, 1), Point(2, 2)) """ # If only one argument provided, set the coords array appropriately if len(args) == 1: coords = args[0] else: coords = args [1abd78e2]
- for i in range(ncoords): if numpy_coords: point_coords = coords[i, :] elif isinstance(coords[i], Point): point_coords = coords[i].tuple else: point_coords = coords[i] point_setter(i, point_coords) [ee31b558]
- if ncoords < self._minlength: raise ValueError( "%s requires at least %d points, got %s." % ( self.__class__.__name__, self._minlength, ncoords, ) ) [2d092f64]
- if not ( isinstance(coords, (tuple, list)) or numpy and isinstance(coords, numpy.ndarray) ): raise TypeError("Invalid initialization input for LineStrings.") [8cc2b51f]
- ncoords = len(coords) if not ncoords: super().__init__(self._init_func(None), srid=srid) return [0b31d54c]
- numpy_coords = not isinstance(coords, (tuple, list)) if numpy_coords: shape = coords.shape # Using numpy's shape. if len(shape) != 2: raise TypeError("Too many dimensions.") self._checkdim(shape[1]) ndim = shape[1] else: # Getting the number of coords and the number of dimensions, which # must stay the same, e.g., no LineString((1, 2), (1, 2, 3)). ndim = None # Incrementing through each of the coordinates and verifying for coord in coords: if not isinstance(coord, (tuple, list, Point)): raise TypeError( "Each coordinate should be a sequence (list or tuple)" ) [b9ec0c15]
- ptr = self._init_func(cs.ptr) if ptr: capi.destroy_geom(self.ptr) self.ptr = ptr if srid is not None: self.srid = srid self._post_init() else: # can this happen? raise GEOSException("Geometry resulting from slice deletion was invalid.") [e4defc66]
- # #### Sequence Properties #### @property def tuple(self): "Return a tuple version of the geometry from the coordinate sequence." return self._cs.tuple [1d8f82c5]
- @property def array(self): "Return a numpy array for the LineString." return self._listarr(self._cs.__getitem__) [d59f2d1c]
- @property def is_counterclockwise(self): if self.empty: raise ValueError("Orientation of an empty LinearRing cannot be determined.") return self._cs.is_counterclockwise [193a1523]
- _get_single_internal = _get_single_external [c9a27e0a939be8ad]

## Beyond the budget

15 more facts did not fit in the budget: [6bf62d51] [7a5eb684] [99ae2687] [7cf2067ea4ba94b9-6] [0eecd972] [942a435e] [8dbe1b19] [62cdb4c1] [21cad63e] [44f81664] [728aa950] [82490534] [c4421f5d] [3c8bb1de] [d455b0ee]
