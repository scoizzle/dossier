# django/db/backends/postgresql/psycopg_any

- Subject: django/db/backends/postgresql/psycopg_any (id `abb4dea1-a30e-4b1a-9b6d-c788b92a3905`)
- Kind: subject
- Budget: 1200 tokens
- Used: 893 tokens
- Facts shown: 19 of 25
- Conflicts: 0
- Gaps: 0

## Facts

- context.adapters.register_loader("timestamptz", SpecificTzLoader) [4ab60992]
- def __init__(self, oid, context): super().__init__(oid, context) self.orig_loader = orig_tz_loader_cls(oid, context) [0f983563]
- def load(self, data): return self.orig_loader.load(data).replace(tzinfo=self.timezone) [3a957f75]
- def upgrade(self, obj, format): # Dump ranges containing naive datetimes as tstzrange, because # Django doesn't use tz-aware ones. dumper = super().upgrade(obj, format) if dumper is not self and dumper.oid == TSRANGE_OID: dumper.oid = TSTZRANGE_OID return dumper [4f1df7e9]
- timezone = None [1725b290]
- # Adapters. class BaseTzLoader(adapt.Loader): """ Load a PostgreSQL timestamptz using a specific timezone. The timezone can be None too, in which case it will be chopped. """ [d59fc9d5]
- @lru_cache def get_adapters_template(use_tz, timezone): # Create an adapters map extending the base one. ctx = adapt.AdaptersMap(adapters) # Register a no-op dumper to avoid a round trip from psycopg version 3 # decode to json.dumps() to json.loads(), when using a custom decoder # in JSONField. ctx.register_loader("jsonb", TextLoader) # Don't convert automatically from PostgreSQL network types to Python # ipaddress. ctx.register_loader("inet", TextLoader) ctx.register_loader("cidr", TextLoader) ctx.register_dumper(Range, DjangoRangeDumper) # Register a timestamptz loader configured on self.timezone. # This, however, can be overridden by create_cursor. register_tzloader(timezone, ctx) return ctx [3523b4fb]
- DateRange = DateTimeRange = DateTimeTZRange = NumericRange = Range RANGE_TYPES = (Range,) [7a356db0]
- Inet = ipaddress.ip_address [063d4083]
- TSRANGE_OID = types["tsrange"].oid TSTZRANGE_OID = types["tstzrange"].oid orig_tz_loader_cls = adapters.get_loader( types["timestamptz"].oid, pq.Format.TEXT, ) [7ee128ae]
- class DjangoRangeDumper(RangeDumper): """A Range dumper customized for Django.""" [7dee2371]
- class IsolationLevel(IntEnum): READ_UNCOMMITTED = extensions.ISOLATION_LEVEL_READ_UNCOMMITTED READ_COMMITTED = extensions.ISOLATION_LEVEL_READ_COMMITTED REPEATABLE_READ = extensions.ISOLATION_LEVEL_REPEATABLE_READ SERIALIZABLE = extensions.ISOLATION_LEVEL_SERIALIZABLE [d5be1613]
- class Jsonb(Json): def getquoted(self): quoted = super().getquoted() return quoted + b"::jsonb" [cafb8f3d]
- def _quote(value, connection=None): adapted = extensions.adapt(value) if hasattr(adapted, "encoding"): adapted.encoding = "utf8" # getquoted() returns a quoted bytestring of the adapted value. return adapted.getquoted().decode() [66ead944]
- def mogrify(sql, params, connection): with connection.cursor() as cursor: return ClientCursor(cursor.connection).mogrify(sql, params) [cef114b0]
- def mogrify(sql, params, connection): with connection.cursor() as cursor: return cursor.mogrify(sql, params).decode() [82d058b6]
- def register_tzloader(tz, context): class SpecificTzLoader(BaseTzLoader): timezone = tz [c1942090]
- is_psycopg3 = False [45c26c68]
- is_psycopg3 = True [5ac5000a]

## Beyond the budget

5 more facts did not fit in the budget: [18cafdc7] [c616059b] [ea90e893] [f201c440] [1cd2aef1]
