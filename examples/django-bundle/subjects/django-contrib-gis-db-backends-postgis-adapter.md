# django/contrib/gis/db/backends/postgis/adapter

- Subject: django/contrib/gis/db/backends/postgis/adapter (id `a7b1f974-d579-42cb-baf0-91bacba04693`)
- Kind: subject
- Budget: 1200 tokens
- Used: 523 tokens
- Facts shown: 12 of 12
- Conflicts: 0
- Gaps: 0

## Facts

- # Getting the WKB (in string form, to allow easy pickling of # the adaptor) and the SRID from the geometry or raster. if self.is_geometry: self.ewkb = bytes(obj.ewkb) else: self.ewkb = to_pgraster(obj) [9097211e]
- if proto == ISQLQuote: return self else: raise Exception( "Error implementing psycopg2 protocol. Is psycopg2 installed?" ) [28dac14e]
- self.srid = obj.srid self.geography = geography [ec2fff7c]
- @classmethod def _fix_polygon(cls, poly): return poly [f7053ca7]
- def __conform__(self, proto): """Does the given protocol conform to what Psycopg2 expects?""" from psycopg2.extensions import ISQLQuote [0536241e]
- def __eq__(self, other): return isinstance(other, PostGISAdapter) and self.ewkb == other.ewkb [9248b213]
- def __hash__(self): return hash(self.ewkb) [46e349f1]
- def __str__(self): return self.getquoted().decode() [6e08c470]
- def getquoted(self): """ Return a properly quoted string for use in PostgreSQL/PostGIS. """ if self.is_geometry: # Psycopg will figure out whether to use E'\\000' or '\000'. return b"%s(%s)" % ( b"ST_GeogFromWKB" if self.geography else b"ST_GeomFromEWKB", sql.quote(self.ewkb).encode(), ) else: # For rasters, add explicit type cast to WKB string. return b"'%s'::raster" % self.ewkb.hex().encode() [167216e7]
- """ This object provides quoting for GEOS geometries into PostgreSQL/PostGIS. """ [70c07efb]
- class PostGISAdapter: def __init__(self, obj, geography=False): """ Initialize on the spatial object. """ self.is_geometry = isinstance(obj, (GEOSGeometry, PostGISAdapter)) [b09d1e52]
- from django.contrib.gis.db.backends.postgis.pgraster import to_pgraster from django.contrib.gis.geos import GEOSGeometry from django.db.backends.postgresql.psycopg_any import sql [e24ceace]
