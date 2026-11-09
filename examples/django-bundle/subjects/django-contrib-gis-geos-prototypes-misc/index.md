# django/contrib/gis/geos/prototypes/misc

- Subject: django/contrib/gis/geos/prototypes/misc (id `511e4e46-4b56-4614-a809-06c2644173da`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 366 tokens
- Facts shown: 8 facts
- Conflicts: 0
- Gaps: 0

## Facts

- restype = c_int # Status code returned errcheck = staticmethod(check_dbl) [73f602f0]
- """ This module is for the miscellaneous GEOS routines, particularly the ones that return the area, distance, and length. """ [653fb1d3]
- # ### ctypes prototypes ### [343628900675080d-2]
- # Area, distance, and length prototypes. geos_area = DblFromGeom("GEOSArea", argtypes=[GEOM_PTR, POINTER(c_double)]) geos_distance = DblFromGeom( "GEOSDistance", argtypes=[GEOM_PTR, GEOM_PTR, POINTER(c_double)] ) geos_length = DblFromGeom("GEOSLength", argtypes=[GEOM_PTR, POINTER(c_double)]) geos_isvalidreason = GEOSFuncFactory( "GEOSisValidReason", restype=geos_char_p, errcheck=check_string, argtypes=[GEOM_PTR] ) [9d800aa2]
- __all__ = ["geos_area", "geos_distance", "geos_length", "geos_isvalidreason"] [c37872bc]
- class DblFromGeom(GEOSFuncFactory): """ Argument is a Geometry, return type is double that is passed in by reference as the last argument. """ [b7161bfa]
- from ctypes import POINTER, c_double, c_int [b529c8c9]
- from django.contrib.gis.geos.libgeos import GEOM_PTR, GEOSFuncFactory from django.contrib.gis.geos.prototypes.errcheck import check_dbl, check_string from django.contrib.gis.geos.prototypes.geom import geos_char_p [337e161d]
