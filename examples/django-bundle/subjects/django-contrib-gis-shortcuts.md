# django/contrib/gis/shortcuts

- Subject: django/contrib/gis/shortcuts (id `df10e257-9f64-461a-ab0e-9c7d27a68d3c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 292 tokens
- Facts shown: 6 of 6
- Conflicts: 0
- Gaps: 0

## Facts

- # NumPy supported? try: import numpy except ImportError: numpy = False [71c68a38]
- def compress_kml(kml): "Return compressed KMZ from the given KML string." kmz = BytesIO() with zipfile.ZipFile(kmz, "a", zipfile.ZIP_DEFLATED) as zf: zf.writestr("doc.kml", kml.encode(settings.DEFAULT_CHARSET)) kmz.seek(0) return kmz.read() [310d2d77]
- def render_to_kml(*args, **kwargs): "Render the response as KML (using the correct MIME type)." return HttpResponse( loader.render_to_string(*args, **kwargs), content_type="application/vnd.google-earth.kml+xml", ) [1fc59b55]
- def render_to_kmz(*args, **kwargs): """ Compress the KML content and return as KMZ (using the correct MIME type). """ return HttpResponse( compress_kml(loader.render_to_string(*args, **kwargs)), content_type="application/vnd.google-earth.kmz", ) [22d12f00]
- from django.conf import settings from django.http import HttpResponse from django.template import loader [d7eb9dc1]
- import zipfile from io import BytesIO [af040e41]
