# django/contrib/gis/geos/linestring

- Subject: django/contrib/gis/geos/linestring (id `e23cacee-5f6e-47c8-b0c0-2ebde8a9cef7`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1549 tokens
- Facts shown: 31 of 31
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [6bf62d51] @property def x(self): "Return a list or numpy array of the X variable." return self._listarr(self._cs.getX)
- [7a5eb684] @property def y(self): "Return a list or numpy array of the Y variable." return self._listarr(self._cs.getY)
- [99ae2687] @property def z(self): "Return a list or numpy array of the Z variable." if not self.hasz: return None else: return self._listarr(self._cs.getZ)
- [7cf2067ea4ba94b9-6] coords = tuple
- [0eecd972] def __init__(self, *args, **kwargs): """ Initialize on the given sequence: may take lists, tuples, NumPy arrays of X,Y pairs, or Point objects. If Point objects are used, ownership is _not_ transferred to the LineString object.
- [942a435e] def __iter__(self): "Allow iteration over this LineString." for i in range(len(self)): yield self[i]
- [8dbe1b19] def __len__(self): "Return the number of points in this LineString." return len(self._cs)
- [62cdb4c1] def _checkdim(self, dim): if dim not in (2, 3): raise TypeError("Dimension mismatch.")
- [21cad63e] def _get_single_external(self, index): return self._cs[index]
- [44f81664] def _listarr(self, func): """ Return a sequence (list) corresponding with the given function. Return a numpy array if possible. """ lst = [func(i) for i in range(len(self))] if numpy: return numpy.array(lst) # ARRRR! else: return lst
- [728aa950] def _set_list(self, length, items): ndim = self._cs.dims hasz = self._cs.hasz # I don't understand why these are different srid = self.srid
- [82490534] def _set_single(self, index, value): self._cs[index] = value
- [c4421f5d] # LinearRings are LineStrings used within Polygons. class LinearRing(LineString): _minlength = 4 _init_func = capi.create_linearring
- [3c8bb1de] class LineString(LinearGeometryMixin, GEOSGeometry): _init_func = capi.create_linestring _minlength = 2 has_cs = True
- [d455b0ee] from django.contrib.gis.geos import prototypes as capi from django.contrib.gis.geos.coordseq import GEOSCoordSeq from django.contrib.gis.geos.error import GEOSException from django.contrib.gis.geos.geometry import GEOSGeometry, LinearGeometryMixin from django.contrib.gis.geos.point import Point from django.contrib.gis.shortcuts import numpy
