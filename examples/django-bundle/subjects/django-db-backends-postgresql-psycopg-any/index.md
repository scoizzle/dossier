# django/db/backends/postgresql/psycopg_any

- Subject: django/db/backends/postgresql/psycopg_any (id `4b71bc74-1430-4575-8448-ad2dda17599a`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1108 tokens
- Facts shown: 25 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- context.adapters.register_loader("timestamptz", SpecificTzLoader) [4ab60992]
- def __init__(self, oid, context): super().__init__(oid, context) self.orig_loader = orig_tz_loader_cls(oid, context) [0f983563]
- def load(self, data): return self.orig_loader.load(data).replace(tzinfo=self.timezone) [3a957f75]
- def upgrade(self, obj, format): # Dump ranges containing naive datetimes as tstzrange, because # Django doesn't use tz-aware ones. dumper = super().upgrade(obj, format) if dumper is not self and dumper.oid == TSRANGE_OID: dumper.oid = TSTZRANGE_OID return dumper [4f1df7e9]
- timezone = None [1725b290]
- # Adapters. class BaseTzLoader(adapt.Loader): """ Load a PostgreSQL timestamptz using a specific timezone. The timezone can be None too, in which case it will be chopped. """ [d59fc9d5]
- @lru_cache def get_adapters_template(use_tz, timezone): # Create an adapters map extending the base one. ctx = adapt.AdaptersMap(adapters) # Register a no-op dumper to avoid a round trip from psycopg version 3 # decode to json.dumps() to json.loads(), when using a custom decoder # in JSONField. ctx.register_loader("jsonb", TextLoader) # Don't convert automatically from PostgreSQL network types to Python # ipaddress. ctx.register_loader("inet", TextLoader) ctx.register_loader("cidr", TextLoader) ctx.register_dumper(Range, DjangoRangeDumper) # Register a timestamptz loader configured on self.timezone. # This, however, can be overridden by create_cursor. register_tzloader(timezone, ctx) return ctx [3523b4fb]
- DateRange = DateTimeRange = DateTimeTZRange = NumericRange = Range RANGE_TYPES = (Range,) [7a356db0]
- Inet = ipaddress.ip_address [063d4083]
- RANGE_TYPES = (DateRange, DateTimeRange, DateTimeTZRange, NumericRange) [498c68d3]
- TSRANGE_OID = types["tsrange"].oid TSTZRANGE_OID = types["tstzrange"].oid orig_tz_loader_cls = adapters.get_loader( types["timestamptz"].oid, pq.Format.TEXT, ) [7ee128ae]
- class DjangoRangeDumper(RangeDumper): """A Range dumper customized for Django.""" [7dee2371]
- class IsolationLevel(IntEnum): READ_UNCOMMITTED = extensions.ISOLATION_LEVEL_READ_UNCOMMITTED READ_COMMITTED = extensions.ISOLATION_LEVEL_READ_COMMITTED REPEATABLE_READ = extensions.ISOLATION_LEVEL_REPEATABLE_READ SERIALIZABLE = extensions.ISOLATION_LEVEL_SERIALIZABLE [d5be1613]
- class Jsonb(Json): def getquoted(self): quoted = super().getquoted() return quoted + b"::jsonb" [cafb8f3d]
- def _quote(value, connection=None): adapted = extensions.adapt(value) if hasattr(adapted, "encoding"): adapted.encoding = "utf8" # getquoted() returns a quoted bytestring of the adapted value. return adapted.getquoted().decode() [66ead944]
- def mogrify(sql, params, connection): with connection.cursor() as cursor: return ClientCursor(cursor.connection).mogrify(sql, params) [cef114b0]
- def mogrify(sql, params, connection): with connection.cursor() as cursor: return cursor.mogrify(sql, params).decode() [82d058b6]
- def register_tzloader(tz, context): class SpecificTzLoader(BaseTzLoader): timezone = tz [c1942090]

## All facts

- [18cafdc7] from psycopg2 import errors, extensions, sql # NOQA from psycopg2.extras import ( # NOQA DateRange, DateTimeRange, DateTimeTZRange, Inet, Json, NumericRange, Range, )
- [45c26c68] is_psycopg3 = False
- [5ac5000a] is_psycopg3 = True
- [c616059b] sql.quote = _quote
- [ea90e893] except ImportError: from enum import IntEnum
- [f201c440] import ipaddress from functools import lru_cache
- [1cd2aef1] try: from psycopg import ClientCursor, IsolationLevel, adapt, adapters, errors, pq, sql from psycopg.postgres import types from psycopg.types.json import Jsonb from psycopg.types.range import Range, RangeDumper from psycopg.types.string import TextLoader
