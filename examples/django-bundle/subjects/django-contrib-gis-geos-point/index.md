# django/contrib/gis/geos/point

- Subject: django/contrib/gis/geos/point (id `a7274132-65ae-417d-8197-6a608fee0e42`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1256 tokens
- Facts shown: 30 of 30
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [fc9bf9fc] def _from_pickle_wkb(self, wkb): return self._create_empty() if wkb is None else super()._from_pickle_wkb(wkb)
- [b4fb1388] def _get_single_external(self, index): if index == 0: return self.x elif index == 1: return self.y elif index == 2: return self.z
- [16a7581a] def _ogr_ptr(self): return ( gdal.geometries.Point._create_empty() if self.empty else super()._ogr_ptr() )
- [30e33a9b] def _set_list(self, length, items): ptr = self._create_point(length, items) if ptr: srid = self.srid capi.destroy_geom(self.ptr) self._ptr = ptr if srid is not None: self.srid = srid self._post_init() else: # can this happen? raise GEOSException("Geometry resulting from slice deletion was invalid.")
- [c68f2efe] def _set_single(self, index, value): self._cs.setOrdinate(index, 0, value)
- [d20e02a8] def _to_pickle_wkb(self): return None if self.empty else super()._to_pickle_wkb()
- [678cc730] class Point(GEOSGeometry): _minlength = 2 _maxlength = 3 has_cs = True
- [bba9bff2] from ctypes import c_uint
- [aa7700c4] from django.contrib.gis import gdal from django.contrib.gis.geos import prototypes as capi from django.contrib.gis.geos.error import GEOSException from django.contrib.gis.geos.geometry import GEOSGeometry
