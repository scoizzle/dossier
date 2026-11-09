# django/contrib/gis/geos/polygon

- Subject: django/contrib/gis/geos/polygon (id `b23305f2-0b3f-4a9b-a8e1-19045869c13d`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1658 tokens
- Facts shown: 30 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- # Getting the ext_ring and init_holes parameters from the argument list ext_ring, *init_holes = args n_holes = len(init_holes) [ca2fbbe7]
- # If initialized as Polygon(shell, (LinearRing, LinearRing)) # [for backward-compatibility] if n_holes == 1 and isinstance(init_holes[0], (tuple, list)): if not init_holes[0]: init_holes = () n_holes = 0 elif isinstance(init_holes[0][0], LinearRing): init_holes = init_holes[0] n_holes = len(init_holes) [1ed363ad]
- >>> # Example where a tuple parameters are used: >>> poly = Polygon(((0, 0), (0, 10), (10, 10), (10, 0), (0, 0)), ... ((4, 4), (4, 6), (6, 6), (6, 4), (4, 4))) """ if not args: super().__init__(self._create_polygon(0, None), **kwargs) return [d613e88f]
- CAREFUL: Internal/External are not the same as Interior/Exterior! Return a pointer from the existing geometries for use internally by the object's methods. _get_single_external() returns a clone of the same geometry for use by external code. """ if index == 0: return capi.get_extring(self.ptr) else: # Getting the interior ring, have to subtract 1 from the index. return capi.get_intring(self.ptr, index - 1) [80129e85]
- Examples of initialization, where shell, hole1, and hole2 are valid LinearRing geometries: >>> from django.contrib.gis.geos import LinearRing, Polygon >>> shell = hole1 = hole2 = LinearRing() >>> poly = Polygon(shell, hole1, hole2) >>> poly = Polygon(shell, (hole1, hole2)) [ef65ebac]
- n_holes = length - 1 if n_holes: holes_param = (GEOM_PTR * n_holes)(*[self._clone(r) for r in rings]) else: holes_param = None [7dfc77f7]
- polygon = self._create_polygon(n_holes + 1, [ext_ring, *init_holes]) super().__init__(polygon, **kwargs) [3ac15eae]
- return capi.create_polygon(shell, holes_param, n_holes) [7f2713b8]
- rings = [] for r in items: if isinstance(r, GEOM_PTR): rings.append(r) else: rings.append(self._construct_ring(r)) [7455d208]
- shell = self._clone(rings.pop(0)) [540742f4]
- # ### These routines are needed for list-like operation w/ListMixin ### def _create_polygon(self, length, items): # Instantiate LinearRing objects if necessary, but don't clone them yet # _construct_ring will throw a TypeError if a parameter isn't a valid # ring If we cloned the pointers here, we wouldn't be able to clean up # in case of error. if not length: return capi.create_empty_polygon() [8bc29724]
- # #### Polygon Properties #### @property def num_interior_rings(self): "Return the number of interior rings." # Getting the number of rings return capi.get_nrings(self.ptr) [21c87707]
- # Properties for the exterior ring/shell. exterior_ring = property(_get_ext_ring, _set_ext_ring) shell = exterior_ring [9395eef5]
- @classmethod def from_bbox(cls, bbox): "Construct a Polygon from a bounding box (4-tuple)." x0, y0, x1, y1 = bbox for z in bbox: if not isinstance(z, (float, int)): return GEOSGeometry( "POLYGON((%s %s, %s %s, %s %s, %s %s, %s %s))" % (x0, y0, x0, y1, x1, y1, x1, y0, x0, y0) ) return Polygon(((x0, y0), (x0, y1), (x1, y1), (x1, y0), (x0, y0))) [ef8cd14a]
- @property def tuple(self): "Get the tuple for each ring in this Polygon." return tuple(self[i].tuple for i in range(len(self))) [ad49c311]

## All facts

- [02dafaf5] @property def kml(self): "Return the KML representation of this Polygon." inner_kml = "".join( "<innerBoundaryIs>%s</innerBoundaryIs>" % self[i + 1].kml for i in range(self.num_interior_rings) ) return "<Polygon><outerBoundaryIs>%s</outerBoundaryIs>%s</Polygon>" % ( self[0].kml, inner_kml, )
- [9271859696c6c292-2] _set_single = GEOSGeometry._set_single_rebuild _assign_extended_slice = GEOSGeometry._assign_extended_slice_rebuild
- [7cf2067ea4ba94b9-7] coords = tuple
- [87d15d40] def __init__(self, *args, **kwargs): """ Initialize on an exterior ring and a sequence of holes (both instances may be either LinearRing instances, or a tuple/list that may be constructed into a LinearRing).
- [d469180c] def __iter__(self): "Iterate over each ring in the polygon." for i in range(len(self)): yield self[i]
- [f42f024e] def __len__(self): "Return the number of rings in this Polygon." return self.num_interior_rings + 1
- [95152d18] def _clone(self, g): if isinstance(g, GEOM_PTR): return capi.geom_clone(g) else: return capi.geom_clone(g.ptr)
- [c4da6de4] def _construct_ring( self, param, msg=( "Parameter must be a sequence of LinearRings or objects that can " "initialize to LinearRings." ), ): "Try to construct a ring from the given parameter." if isinstance(param, LinearRing): return param try: return LinearRing(param) except TypeError: raise TypeError(msg)
- [c10f84d6] def _get_ext_ring(self): "Get the exterior ring of the Polygon." return self[0]
- [75b2c5ad] def _get_single_external(self, index): return GEOSGeometry( capi.geom_clone(self._get_single_internal(index)), srid=self.srid )
- [6fde385c] def _get_single_internal(self, index): """ Return the ring at the specified index. The first index, 0, will always return the exterior ring. Indices > 0 will return the interior ring at the given index (e.g., poly[1] and poly[2] would return the first and second interior ring, respectively).
- [ddc78c62] def _set_ext_ring(self, ring): "Set the exterior ring of the Polygon." self[0] = ring
- [687a3715] def _set_list(self, length, items): # Getting the current pointer, replacing with the newly constructed # geometry, and destroying the old geometry. prev_ptr = self.ptr srid = self.srid self.ptr = self._create_polygon(length, items) if srid: self.srid = srid capi.destroy_geom(prev_ptr)
- [5bcfa5b8] class Polygon(GEOSGeometry): _minlength = 1
- [7144a5a7] from django.contrib.gis.geos import prototypes as capi from django.contrib.gis.geos.geometry import GEOSGeometry from django.contrib.gis.geos.libgeos import GEOM_PTR from django.contrib.gis.geos.linestring import LinearRing
