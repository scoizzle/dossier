# django/contrib/gis/db/backends/oracle/adapter

- Subject: django/contrib/gis/db/backends/oracle/adapter (id `8057b4f6-293d-4859-bf7f-b0be984e662b`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 514 tokens
- Facts shown: 11 of 11
- Conflicts: 0
- Gaps: 0

## Facts

- for i in range(1, len(poly)): if poly[i].is_counterclockwise: poly[i] = list(reversed(poly[i])) [3957534b]
- if not poly.exterior_ring.is_counterclockwise: poly.exterior_ring = list(reversed(poly.exterior_ring)) [e6272594]
- return poly [01aedee9]
- self.wkt = geom.wkt self.srid = geom.srid [262c3dcf]
- @classmethod def _fix_geometry_collection(cls, coll): """ Fix polygon orientations in geometry collections as described in __init__(). """ coll = coll.clone() for i, geom in enumerate(coll): if isinstance(geom, Polygon): coll[i] = cls._fix_polygon(geom, clone=False) return coll [34c63bf3]
- @classmethod def _fix_polygon(cls, poly, clone=True): """Fix single polygon orientation as described in __init__().""" if clone: poly = poly.clone() [8dbabb01]
- @staticmethod def _polygon_must_be_fixed(poly): return not poly.empty and ( not poly.exterior_ring.is_counterclockwise or any(x.is_counterclockwise for x in poly) ) [4e0169ff]
- def __init__(self, geom): """ Oracle requires that polygon rings are in proper orientation. This affects spatial operations and an invalid orientation may cause failures. Correct orientations are: * Outer ring - counter clockwise * Inner ring(s) - clockwise """ if isinstance(geom, Polygon): if self._polygon_must_be_fixed(geom): geom = self._fix_polygon(geom) elif isinstance(geom, GeometryCollection): if any( isinstance(g, Polygon) and self._polygon_must_be_fixed(g) for g in geom ): geom = self._fix_geometry_collection(geom) [ff1870f7]
- class OracleSpatialAdapter(WKTAdapter): input_size = oracledb.CLOB [e847d756]
- from django.contrib.gis.db.backends.base.adapter import WKTAdapter from django.contrib.gis.geos import GeometryCollection, Polygon [f7e1eed3]
- import oracledb [f7636c0e9b50a9d4]
