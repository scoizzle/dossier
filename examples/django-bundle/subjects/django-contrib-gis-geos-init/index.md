# django/contrib/gis/geos/__init__

- Subject: django/contrib/gis/geos/__init__ (id `cd6a13fb-6c67-4776-b2ce-b09c62a24f60`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 180 tokens
- Facts shown: 2 facts
- Conflicts: 0
- Gaps: 0

## Facts

- """ The GeoDjango GEOS module. Please consult the GeoDjango documentation for more details: https://docs.djangoproject.com/en/dev/ref/contrib/gis/geos/ """ [b0a4cdb5]
- from .collections import ( # NOQA GeometryCollection, MultiLineString, MultiPoint, MultiPolygon, ) from .error import GEOSException # NOQA from .factory import fromfile, fromstr # NOQA from .geometry import GEOSGeometry, hex_regex, wkt_regex # NOQA from .io import WKBReader, WKBWriter, WKTReader, WKTWriter # NOQA from .libgeos import geos_version # NOQA from .linestring import LinearRing, LineString # NOQA from .point import Point # NOQA from .polygon import Polygon # NOQA [98a6bc0a]
