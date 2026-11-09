# django/contrib/gis/db/backends/base/adapter

- Subject: django/contrib/gis/db/backends/base/adapter (id `3dd0969a-7150-464a-80b2-3a94ffd3f520`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 177 tokens
- Facts shown: 6 facts
- Conflicts: 0
- Gaps: 0

## Facts

- @classmethod def _fix_polygon(cls, poly): # Hook for Oracle. return poly [e78b7a8b]
- def __eq__(self, other): return ( isinstance(other, WKTAdapter) and self.wkt == other.wkt and self.srid == other.srid ) [a4e99d7e]
- def __hash__(self): return hash((self.wkt, self.srid)) [3036eb88]
- def __init__(self, geom): self.wkt = geom.wkt self.srid = geom.srid [e2bf6519]
- def __str__(self): return self.wkt [8a94773b]
- class WKTAdapter: """ An adaptor for Geometries sent to the MySQL and Oracle database backends. """ [22acdd04]
