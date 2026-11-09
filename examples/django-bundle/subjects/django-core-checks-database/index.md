# django/core/checks/database

- Subject: django/core/checks/database (id `e22f1c2a-a3f2-4620-9d12-6a7bb96b7698`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 106 tokens
- Facts shown: 3 facts
- Conflicts: 0
- Gaps: 0

## Facts

- @register(Tags.database) def check_database_backends(databases=None, **kwargs): if databases is None: return [] issues = [] for alias in databases: conn = connections[alias] issues.extend(conn.validation.check(**kwargs)) return issues [65011469]
- from . import Tags, register [5fbdafc2f3b1ddcb]
- from django.db import connections [59b60777]
