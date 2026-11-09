# django/contrib/gis/geos/coordseq

- Subject: django/contrib/gis/geos/coordseq (id `a62b5a96-ea1a-43c9-80d5-719a090fceef`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 16 of 49
- Conflicts: 0
- Gaps: 0

## Facts

- coordinate_string = " ".join(coords) return f"<coordinates>{coordinate_string}</coordinates>" [05f5ffc9]
- # ### Dimensions ### @property def size(self): "Return the size of this coordinate sequence." return capi.cs_getsize(self.ptr, byref(c_uint())) [2946b89a]
- # ### Other Methods ### def clone(self): "Clone this coordinate sequence." return GEOSCoordSeq(capi.cs_clone(self.ptr), self.hasz) [be00e55a]
- # #### Internal Routines #### def _checkindex(self, index): "Check the given index." if not (0 <= index < self.size): raise IndexError(f"Invalid GEOS Geometry index: {index}") [cfbea3b0]
- # #### Ordinate getting and setting routines #### def getOrdinate(self, dimension, index): "Return the value for the given dimension and index." self._checkindex(index) self._checkdim(dimension) return capi.cs_getordinate(self.ptr, index, dimension, byref(c_double())) [33c8ef79]
- @property def _point_getter(self): if self.dims == 3 and self._z: return self._get_point_3d elif self.dims == 3 and self.hasm: return self._get_point_3d_m elif self.dims == 4 and self._z and self.hasm: return self._get_point_4d return self._get_point_2d [8703faf5]
- @property def dims(self): "Return the dimensions of this coordinate sequence." return capi.cs_getdims(self.ptr, byref(c_uint())) [b1a83bfb]
- @property def hasm(self): """ Return whether this coordinate sequence has M dimension. """ if geos_version_tuple() >= (3, 14): return capi.cs_hasm(self._ptr) else: raise NotImplementedError( "GEOSCoordSeq with an M dimension requires GEOS 3.14+." ) [bf5c08cd]
- @property def hasz(self): """ Return whether this coordinate sequence is 3D. This property value is inherited from the parent Geometry. """ return self._z [60dbbcc8]
- @property def is_counterclockwise(self): """Return whether this coordinate sequence is counterclockwise.""" ret = c_byte() if not capi.cs_is_ccw(self.ptr, byref(ret)): raise GEOSException( 'Error encountered in GEOS C function "%s".' % capi.cs_is_ccw.func_name ) return ret.value == 1 [c1397a8e]
- @property def kml(self): "Return the KML representation for the coordinates." if self.hasz: coords = [f"{coord[0]},{coord[1]},{coord[2]}" for coord in self] else: coords = [f"{coord[0]},{coord[1]},0" for coord in self] [2e045944]
- @property def tuple(self): "Return a tuple version of this coordinate sequence." n = self.size get_point = self._point_getter if n == 1: return get_point(0) return tuple(get_point(i) for i in range(n)) [9da54e67]
- def __getitem__(self, index): "Return the coordinate sequence value at the given index." self._checkindex(index) return self._point_getter(index) [0fd87335]
- def __init__(self, ptr, z=False): "Initialize from a GEOS pointer." # TODO when dropping support for GEOS 3.13 the z argument can be # deprecated in favor of using the GEOS function GEOSCoordSeq_hasZ. if not isinstance(ptr, CS_PTR): raise TypeError("Coordinate sequence should initialize with a CS_PTR.") self._ptr = ptr self._z = z [d28ea31a]
- def __iter__(self): "Iterate over each point in the coordinate sequence." for i in range(self.size): yield self[i] [93565549]
- ptr_type = CS_PTR [60effbbb]

## Beyond the budget

33 more facts did not fit in the budget: [c658ccd9] [60bb82c8] [6e777857] [d7388fab] [1770ac0a] [52cfe00e] [98b43e36] [d09fae6a] [9ced1240] [f11ed5e3] [9500b516] [4107f8c9] [d1865f1b] [f634d2e7] [cc1c3a5a] [e4a4cf5c] [b5bd8b25] [510b0dbc] [d256aa40] [27abfe08] [956e870e] [2eaf4f26] [78b22bbf] [19cf16d5] [67e33cd9] [6c000f38] [7a1365ea] [d480cf9a] [cf45581c] [35b02c79] [dce30935] [51f4a9d2] [d202fa25]
