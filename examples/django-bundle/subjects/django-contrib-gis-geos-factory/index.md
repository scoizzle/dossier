# django/contrib/gis/geos/factory

- Subject: django/contrib/gis/geos/factory (id `25284473-871a-497e-a761-9a6153c91f0a`)
- Kind: subject
- Budget: 1200 tokens
- Used: 251 tokens
- Facts shown: 5 of 5
- Conflicts: 0
- Gaps: 0

## Facts

- # If we get WKB need to wrap in memoryview(), so run through regexes. if isinstance(buf, bytes): try: decoded = buf.decode() except UnicodeDecodeError: pass else: if wkt_regex.match(decoded) or hex_regex.match(decoded): return GEOSGeometry(decoded) else: return GEOSGeometry(buf) [6fab98cf]
- return GEOSGeometry(memoryview(buf)) [58da792b]
- def fromfile(file_h): """ Given a string file name, returns a GEOSGeometry. The file may contain WKB, WKT, or HEX. """ # If given a file name, get a real handle. if isinstance(file_h, str): with open(file_h, "rb") as file_h: buf = file_h.read() else: buf = file_h.read() [99274f74]
- def fromstr(string, **kwargs): "Given a string value, return a GEOSGeometry object." return GEOSGeometry(string, **kwargs) [0d6a49ca]
- from django.contrib.gis.geos.geometry import GEOSGeometry, hex_regex, wkt_regex [15c07709]
