# django/contrib/gis/geometry

- Subject: django/contrib/gis/geometry (id `5a66f285-5682-487d-b175-c90c7827147e`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 220 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- # Regular expression for recognizing HEXEWKB and WKT. A prophylactic measure # to prevent potentially malicious input from reaching the underlying C # library. Not a substitute for good web security programming practices. hex_regex = _lazy_re_compile(r"^[0-9A-F]+$", re.I) wkt_regex = _lazy_re_compile( r"^(SRID=(?P<srid>\-?[0-9]+);)?" r"(?P<wkt>" r"(?P<type>POINT|LINESTRING|LINEARRING|POLYGON|MULTIPOINT|" r"MULTILINESTRING|MULTIPOLYGON|GEOMETRYCOLLECTION|CIRCULARSTRING|COMPOUNDCURVE|" r"CURVEPOLYGON|MULTICURVE|MULTISURFACE|CURVE|SURFACE|POLYHEDRALSURFACE|TIN|" r"TRIANGLE)" r"[ACEGIMLONPSRUTYZ0-9,.+() -]+)$", re.I, ) json_regex = _lazy_re_compile(r"^(\s+)?\{.*}(\s+)?$", re.DOTALL) [68a3a993]
- from django.utils.regex_helper import _lazy_re_compile [e384d60811aaeff5]
- import re [dae3b101b4aa9562-6]
