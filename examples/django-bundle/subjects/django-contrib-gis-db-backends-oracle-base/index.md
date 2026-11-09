# django/contrib/gis/db/backends/oracle/base

- Subject: django/contrib/gis/db/backends/oracle/base (id `75c1647a-a85f-4e78-9a15-5bf58f37c184`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 153 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- class DatabaseWrapper(OracleDatabaseWrapper): SchemaEditorClass = OracleGISSchemaEditor # Classes instantiated in __init__(). features_class = DatabaseFeatures introspection_class = OracleIntrospection ops_class = OracleOperations [4119aa03]
- from .features import DatabaseFeatures from .introspection import OracleIntrospection from .operations import OracleOperations from .schema import OracleGISSchemaEditor [2e92119f]
- from django.db.backends.oracle.base import DatabaseWrapper as OracleDatabaseWrapper [e7849e21]
