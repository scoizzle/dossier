# django/contrib/gis/geos/point

- Subject: django/contrib/gis/geos/point (id `22637824-1f31-408f-bb36-d826af84cd0b`)
- Kind: subject
- Budget: 1200 tokens
- Used: 885 tokens
- Facts shown: 21 of 30
- Conflicts: 0
- Gaps: 0

## Facts

- # Initializing using the address returned from the GEOS # createPoint factory. super().__init__(point, srid=srid) [75761794]
- For example: >>> p = Point((5, 23)) # 2D point, passed in as a tuple >>> p = Point(5, 23, 8) # 3D point, passed as individual parameters """ if x is None: coords = [] elif isinstance(x, (tuple, list)): # Here a tuple or list was passed in under the `x` parameter. coords = x elif isinstance(x, (float, int)) and isinstance(y, (float, int)): # Here X, Y, and (optionally) Z were passed in individually, as # parameters. if isinstance(z, (float, int)): coords = [x, y, z] else: coords = [x, y] else: raise TypeError("Invalid parameters given for Point initialization.") [0914d617]
- cs = capi.create_cs(c_uint(1), c_uint(ndim)) i = iter(coords) capi.cs_setx(cs, 0, next(i)) capi.cs_sety(cs, 0, next(i)) if ndim == 3: capi.cs_setz(cs, 0, next(i)) [444ea17f]
- if ndim < 2 or ndim > 3: raise TypeError("Invalid point dimension: %s" % ndim) [236b63ac]
- point = self._create_point(len(coords), coords) [42443a80]
- return capi.create_point(cs) [2699bc53]
- # ### Tuple setting and retrieval routines. ### @property def tuple(self): "Return a tuple of the point." return self._cs.tuple [b2d98228]
- # The tuple and coords properties coords = tuple [54e635da]
- @classmethod def _create_empty(cls): return cls._create_point(None, None) [39593cab]
- @classmethod def _create_point(cls, ndim, coords): """ Create a coordinate sequence, set X, Y, [Z], and create point """ if not ndim: return capi.create_point(None) [0ceed16c]
- @property def x(self): "Return the X component of the Point." return self._cs.getOrdinate(0, 0) [96095df9]
- @property def y(self): "Return the Y component of the Point." return self._cs.getOrdinate(1, 0) [1b6edde9]
- @property def z(self): "Return the Z component of the Point." return self._cs.getOrdinate(2, 0) if self.hasz else None [0daf9e9f]
- @tuple.setter def tuple(self, tup): "Set the coordinates of the point with the given tuple." self._cs[0] = tup [40604044]
- @x.setter def x(self, value): "Set the X component of the Point." self._cs.setOrdinate(0, 0, value) [222a400e]
- @y.setter def y(self, value): "Set the Y component of the Point." self._cs.setOrdinate(1, 0, value) [1e3c23de]
- @z.setter def z(self, value): "Set the Z component of the Point." if not self.hasz: raise GEOSException("Cannot set Z on 2D Point.") self._cs.setOrdinate(2, 0, value) [8aea5762]
- _get_single_internal = _get_single_external [c9a27e0a939be8ad-2]
- def __init__(self, x=None, y=None, z=None, srid=None): """ The Point object may be initialized with either a tuple, or individual parameters. [b0361111]
- def __iter__(self): "Iterate over coordinates of this Point." for i in range(len(self)): yield self[i] [6f2e0e73]
- def __len__(self): "Return the number of dimensions for this Point (either 0, 2 or 3)." if self.empty: return 0 if self.hasz: return 3 else: return 2 [9f23575f]

## Beyond the budget

9 more facts did not fit in the budget: [fc9bf9fc] [b4fb1388] [16a7581a] [30e33a9b] [c68f2efe] [d20e02a8] [678cc730] [bba9bff2] [aa7700c4]
