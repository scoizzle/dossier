# django/contrib/gis/geos/prototypes/prepared

- Subject: django/contrib/gis/geos/prototypes/prepared (id `68ccde75-5887-4fa6-972e-05657804e3b6`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 342 tokens
- Facts shown: 5 of 5
- Conflicts: 0
- Gaps: 0

## Facts

- # Prepared geometry binary predicate support. class PreparedPredicate(GEOSFuncFactory): argtypes = [PREPGEOM_PTR, GEOM_PTR] restype = c_byte errcheck = staticmethod(check_predicate) [6179d2c3]
- # Prepared geometry constructor and destructors. geos_prepare = GEOSFuncFactory("GEOSPrepare", argtypes=[GEOM_PTR], restype=PREPGEOM_PTR) prepared_destroy = GEOSFuncFactory("GEOSPreparedGeom_destroy", argtypes=[PREPGEOM_PTR]) [6d766fa4]
- from ctypes import c_byte [9b360ed6]
- from django.contrib.gis.geos.libgeos import GEOM_PTR, PREPGEOM_PTR, GEOSFuncFactory from django.contrib.gis.geos.prototypes.errcheck import check_predicate [91e1d8f8]
- prepared_contains = PreparedPredicate("GEOSPreparedContains") prepared_contains_properly = PreparedPredicate("GEOSPreparedContainsProperly") prepared_covers = PreparedPredicate("GEOSPreparedCovers") prepared_crosses = PreparedPredicate("GEOSPreparedCrosses") prepared_disjoint = PreparedPredicate("GEOSPreparedDisjoint") prepared_intersects = PreparedPredicate("GEOSPreparedIntersects") prepared_overlaps = PreparedPredicate("GEOSPreparedOverlaps") prepared_touches = PreparedPredicate("GEOSPreparedTouches") prepared_within = PreparedPredicate("GEOSPreparedWithin") [1fb02653]
