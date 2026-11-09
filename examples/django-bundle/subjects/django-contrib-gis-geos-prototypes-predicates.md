# django/contrib/gis/geos/prototypes/predicates

- Subject: django/contrib/gis/geos/prototypes/predicates (id `f5e85056-660a-4918-9dc8-e4a8cc0c4feb`)
- Kind: subject
- Budget: 1200 tokens
- Used: 511 tokens
- Facts shown: 9 of 9
- Conflicts: 0
- Gaps: 0

## Facts

- argtypes = [GEOM_PTR, GEOM_PTR] [8acc1d3b]
- argtypes = [GEOM_PTR] restype = c_byte errcheck = staticmethod(check_predicate) [b141cceb]
- """ This module houses the GEOS ctypes prototype functions for the unary and binary predicate operations on geometries. """ [893d0249]
- # ## Binary & unary predicate factories ## class UnaryPredicate(GEOSFuncFactory): "For GEOS unary predicate functions." [8763c12d]
- # ## Binary Predicates ## geos_contains = BinaryPredicate("GEOSContains") geos_covers = BinaryPredicate("GEOSCovers") geos_crosses = BinaryPredicate("GEOSCrosses") geos_disjoint = BinaryPredicate("GEOSDisjoint") geos_equals = BinaryPredicate("GEOSEquals") geos_equalsexact = BinaryPredicate( "GEOSEqualsExact", argtypes=[GEOM_PTR, GEOM_PTR, c_double] ) geos_equalsidentical = BinaryPredicate("GEOSEqualsIdentical") geos_intersects = BinaryPredicate("GEOSIntersects") geos_overlaps = BinaryPredicate("GEOSOverlaps") geos_relatepattern = BinaryPredicate( "GEOSRelatePattern", argtypes=[GEOM_PTR, GEOM_PTR, c_char_p] ) geos_touches = BinaryPredicate("GEOSTouches") geos_within = BinaryPredicate("GEOSWithin") [9a9602c7]
- # ## Unary Predicates ## geos_hasz = UnaryPredicate("GEOSHasZ") geos_hasm = UnaryPredicate("GEOSHasM") geos_isclosed = UnaryPredicate("GEOSisClosed") geos_isempty = UnaryPredicate("GEOSisEmpty") geos_isring = UnaryPredicate("GEOSisRing") geos_issimple = UnaryPredicate("GEOSisSimple") geos_isvalid = UnaryPredicate("GEOSisValid") [d600b81e]
- class BinaryPredicate(UnaryPredicate): "For GEOS binary predicate functions." [6571077c]
- from ctypes import c_byte, c_char_p, c_double [de7e83b5]
- from django.contrib.gis.geos.libgeos import GEOM_PTR, GEOSFuncFactory from django.contrib.gis.geos.prototypes.errcheck import check_predicate [077b9c52]
