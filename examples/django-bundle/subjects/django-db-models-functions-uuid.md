# django/db/models/functions/uuid

- Subject: django/db/models/functions/uuid (id `ea737a58-9e26-47f9-909f-1bcfc9bfbe3e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 876 tokens
- Facts shown: 14 of 15
- Conflicts: 0
- Gaps: 0

## Facts

- if len(self.source_expressions) == 1: if not connection.features.supports_uuid7_function_shift: msg = ( "The shift argument to UUID7 is not supported " "on this database backend." ) raise NotSupportedError(msg) [92e4a3fb]
- return super().as_sql(compiler, connection, **extra_context) [1a0b46f5a52f62b5-2]
- # PY314: When dropping support for 3.14, remove the entire method. def as_sqlite(self, compiler, connection, **extra_context): if connection.features.supports_uuid7_function: return self.as_sql(compiler, connection, **extra_context) raise NotSupportedError( "UUID7 on SQLite requires Python version 3.14 or later." ) [695bac51]
- def __init__(self, shift=None, **extra): super().__init__(shift, **extra) [1c0cd1ff]
- def _parse_expressions(self, *expressions): if expressions[0] is None: expressions = expressions[1:] return super()._parse_expressions(*expressions) [ebd44319]
- def as_mysql(self, compiler, connection, **extra_context): if connection.features.supports_uuid7_function: return self.as_sql( compiler, connection, function="UUID_V7", **extra_context ) if connection.mysql_is_mariadb: raise NotSupportedError("UUID7 requires MariaDB version 11.7 or later.") raise NotSupportedError("UUID7 is not supported on MySQL.") [d60db7e0]
- def as_oracle(self, compiler, connection, **extra_context): if not connection.features.supports_uuid4_function: raise NotSupportedError( "UUID4 requires Oracle version 23ai/26ai (23.9) or later." ) # UUID4() produces a RAW(16) on Oracle, which is implicitly uppercased # via RAWTOHEX() when persisted to UUIDField's VARCHAR2(32) type. For # parity with python UUID values, make explicit and wrap with LOWER(). return self.as_sql( compiler, connection, function="UUID", template=f"LOWER(RAWTOHEX({self.template}))", **extra_context, ) [d85538ee]
- def as_postgresql(self, compiler, connection, **extra_context): if connection.features.is_postgresql_18: return self.as_sql(compiler, connection, **extra_context) return self.as_sql( compiler, connection, function="GEN_RANDOM_UUID", **extra_context ) [d12f9b3f]
- def as_postgresql(self, compiler, connection, **extra_context): if connection.features.supports_uuid7_function: return self.as_sql(compiler, connection, **extra_context) raise NotSupportedError("UUID7 requires PostgreSQL version 18 or later.") [fffc113a]
- def as_sql(self, compiler, connection, **extra_context): if connection.features.supports_uuid4_function: return super().as_sql(compiler, connection, **extra_context) raise NotSupportedError("UUID4 is not supported on this database backend.") [fa88f7cb]
- def as_sql(self, compiler, connection, **extra_context): if not connection.features.supports_uuid7_function: raise NotSupportedError("UUID7 is not supported on this database backend.") [71aefafb]
- class UUID4(Func): function = "UUIDV4" arity = 0 output_field = UUIDField() [549cf6ec]
- class UUID7(Func): function = "UUIDV7" arity = 1 output_field = UUIDField() [044a79b1]
- from django.db import NotSupportedError from django.db.models.expressions import Func from django.db.models.fields import UUIDField [b1ee52ac]
