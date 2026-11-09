# django/contrib/gis/geos/io

- Subject: django/contrib/gis/geos/io (id `b39397f6-8a28-40e8-bc5b-cde432bb277e`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 236 tokens
- Facts shown: 5 of 5
- Conflicts: 0
- Gaps: 0

## Facts

- """ Module that holds classes for performing I/O operations on GEOS geometry objects. Specifically, this has Python implementations of WKB/WKT reader and writer classes. """ [f47b0be4]
- # Public classes for (WKB|WKT)Reader, which return GEOSGeometry class WKBReader(_WKBReader): def read(self, wkb): "Return a GEOSGeometry for the given WKB buffer." return GEOSGeometry(super().read(wkb)) [c45d53dd]
- __all__ = ["WKBWriter", "WKTWriter", "WKBReader", "WKTReader"] [15793e58]
- class WKTReader(_WKTReader): def read(self, wkt): "Return a GEOSGeometry for the given WKT string." return GEOSGeometry(super().read(wkt)) [03c4a34d]
- from django.contrib.gis.geos.geometry import GEOSGeometry from django.contrib.gis.geos.prototypes.io import ( WKBWriter, WKTWriter, _WKBReader, _WKTReader, ) [cb673305]
