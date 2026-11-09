# django/contrib/gis/geos/__init__

- Subject: django/contrib/gis/geos/__init__ (id `22ab16a5-c588-4690-a753-6d0ceb8602fc`)
- Kind: subject
- Budget: 1200 tokens
- Used: 180 tokens
- Facts shown: 2 of 2
- Conflicts: 0
- Gaps: 0

## Facts

- """ The GeoDjango GEOS module. Please consult the GeoDjango documentation for more details: https://docs.djangoproject.com/en/dev/ref/contrib/gis/geos/ """ [b0a4cdb5]
- from .collections import ( # NOQA GeometryCollection, MultiLineString, MultiPoint, MultiPolygon, ) from .error import GEOSException # NOQA from .factory import fromfile, fromstr # NOQA from .geometry import GEOSGeometry, hex_regex, wkt_regex # NOQA from .io import WKBReader, WKBWriter, WKTReader, WKTWriter # NOQA from .libgeos import geos_version # NOQA from .linestring import LinearRing, LineString # NOQA from .point import Point # NOQA from .polygon import Polygon # NOQA [98a6bc0a]
