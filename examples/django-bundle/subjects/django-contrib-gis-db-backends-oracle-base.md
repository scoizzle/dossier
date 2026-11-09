# django/contrib/gis/db/backends/oracle/base

- Subject: django/contrib/gis/db/backends/oracle/base (id `fdd6c270-7ca1-429e-9510-0aaf2da01a2a`)
- Kind: subject
- Budget: 1200 tokens
- Used: 153 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- class DatabaseWrapper(OracleDatabaseWrapper): SchemaEditorClass = OracleGISSchemaEditor # Classes instantiated in __init__(). features_class = DatabaseFeatures introspection_class = OracleIntrospection ops_class = OracleOperations [4119aa03]
- from .features import DatabaseFeatures from .introspection import OracleIntrospection from .operations import OracleOperations from .schema import OracleGISSchemaEditor [2e92119f]
- from django.db.backends.oracle.base import DatabaseWrapper as OracleDatabaseWrapper [e7849e21]
