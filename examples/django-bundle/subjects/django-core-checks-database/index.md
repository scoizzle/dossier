# django/core/checks/database

- Subject: django/core/checks/database (id `0f06b33f-b810-4d33-aab1-6918b1b0c38a`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 106 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- @register(Tags.database) def check_database_backends(databases=None, **kwargs): if databases is None: return [] issues = [] for alias in databases: conn = connections[alias] issues.extend(conn.validation.check(**kwargs)) return issues [65011469]
- from . import Tags, register [5fbdafc2f3b1ddcb]
- from django.db import connections [59b60777]
