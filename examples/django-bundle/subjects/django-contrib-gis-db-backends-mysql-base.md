# django/contrib/gis/db/backends/mysql/base

- Subject: django/contrib/gis/db/backends/mysql/base (id `b85fab4d-e540-423d-a2a2-da277b356783`)
- Kind: subject
- Budget: 1200 tokens
- Used: 150 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- class DatabaseWrapper(MySQLDatabaseWrapper): SchemaEditorClass = MySQLGISSchemaEditor # Classes instantiated in __init__(). features_class = DatabaseFeatures introspection_class = MySQLIntrospection ops_class = MySQLOperations [9e524389]
- from .features import DatabaseFeatures from .introspection import MySQLIntrospection from .operations import MySQLOperations from .schema import MySQLGISSchemaEditor [3cee2d71]
- from django.db.backends.mysql.base import DatabaseWrapper as MySQLDatabaseWrapper [504608fc]
