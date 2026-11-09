# django/contrib/gis/db/backends/spatialite/adapter

- Subject: django/contrib/gis/db/backends/spatialite/adapter (id `9ce3ae0c-6f01-4127-9723-b4f85dcbf2e0`)
- Kind: subject
- Budget: 1200 tokens
- Used: 104 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- def __conform__(self, protocol): if protocol is Database.PrepareProtocol: return str(self) [3860cc89]
- class SpatiaLiteAdapter(WKTAdapter): "SQLite adapter for geometry objects." [f27dea8b]
- from django.contrib.gis.db.backends.base.adapter import WKTAdapter from django.db.backends.sqlite3.base import Database [c47110f9]
