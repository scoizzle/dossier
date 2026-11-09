# django/contrib/gis/geos/prepared

- Subject: django/contrib/gis/geos/prepared (id `b0a0bb6d-d2a5-41c8-a119-b5851a64bb94`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 454 tokens
- Facts shown: 13 of 14
- Conflicts: 0
- Gaps: 0

## Facts

- if not isinstance(geom, GEOSGeometry): raise TypeError self.ptr = capi.geos_prepare(geom.ptr) [f29c71c4]
- def __init__(self, geom): # Keeping a reference to the original geometry object to prevent it # from being garbage collected which could then crash the prepared one # See #21662 self._base_geom = geom from .geometry import GEOSGeometry [7f67ad56]
- def contains(self, other): return capi.prepared_contains(self.ptr, other.ptr) [3b4cffa2]
- def covers(self, other): return capi.prepared_covers(self.ptr, other.ptr) [6d09cd81]
- def crosses(self, other): return capi.prepared_crosses(self.ptr, other.ptr) [873d8807]
- def disjoint(self, other): return capi.prepared_disjoint(self.ptr, other.ptr) [84a8262a]
- def intersects(self, other): return capi.prepared_intersects(self.ptr, other.ptr) [bfff69af]
- def overlaps(self, other): return capi.prepared_overlaps(self.ptr, other.ptr) [b827d232]
- def touches(self, other): return capi.prepared_touches(self.ptr, other.ptr) [2308d688]
- def within(self, other): return capi.prepared_within(self.ptr, other.ptr) [37a9daf2]
- ptr_type = capi.PREPGEOM_PTR destructor = capi.prepared_destroy [d9e5766a]
- class PreparedGeometry(GEOSBase): """ A geometry that is prepared for performing certain operations. At the moment this includes the contains covers, and intersects operations. """ [875089ff]
- from .base import GEOSBase from .prototypes import prepared as capi [8b4cffe0]
