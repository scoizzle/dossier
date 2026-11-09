# django/db/models/functions/datetime

- Subject: django/db/models/functions/datetime (id `aac50cfe-7b8a-4781-bd14-93f60cdcd99a`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 3028 tokens
- Facts shown: 52 of 53
- Conflicts: 0
- Gaps: 0

## Highlights

- To replicate this in Python: (mydatetime.isoweekday() % 7) + 1 """ [6f2d8d2b]
- def __init__( self, expression, output_field=None, tzinfo=None, **extra, ): self.tzinfo = tzinfo super().__init__(expression, output_field=output_field, **extra) [54544b01]
- def __init__(self, expression, lookup_name=None, tzinfo=None, **extra): if self.lookup_name is None: self.lookup_name = lookup_name if self.lookup_name is None: raise ValueError("lookup_name must be provided") self.tzinfo = tzinfo super().__init__(expression, **extra) [066c01bb]
- def as_mysql(self, compiler, connection, **extra_context): return self.as_sql( compiler, connection, template="CURRENT_TIMESTAMP(6)", **extra_context ) [b3e42340]
- def as_oracle(self, compiler, connection, **extra_context): return self.as_sql( compiler, connection, template="LOCALTIMESTAMP", **extra_context ) [a786df27]
- def as_postgresql(self, compiler, connection, **extra_context): # PostgreSQL's CURRENT_TIMESTAMP means "the time at the start of the # transaction". Use STATEMENT_TIMESTAMP to be cross-compatible with # other databases. return self.as_sql( compiler, connection, template="STATEMENT_TIMESTAMP()", **extra_context ) [f9bbae81]
- def as_sql(self, compiler, connection): # Cast to date rather than truncate to date. sql, params = compiler.compile(self.lhs) tzname = self.get_tzname() return connection.ops.datetime_cast_date_sql(sql, tuple(params), tzname) [0dd61c54]
- def as_sql(self, compiler, connection): sql, params = compiler.compile(self.lhs) lhs_output_field = self.lhs.output_field if isinstance(lhs_output_field, DateTimeField): tzname = self.get_tzname() sql, params = connection.ops.datetime_extract_sql( self.lookup_name, sql, tuple(params), tzname ) elif self.tzinfo is not None: raise ValueError("tzinfo can only be used with DateTimeField.") elif isinstance(lhs_output_field, DateField): sql, params = connection.ops.date_extract_sql( self.lookup_name, sql, tuple(params) ) elif isinstance(lhs_output_field, TimeField): sql, params = connection.ops.time_extract_sql( self.lookup_name, sql, tuple(params) ) elif isinstance(lhs_output_field, DurationField): if not connection.features.has_native_duration_field: raise ValueError( "Extract requires native DurationField database support." ) sql, params = connection.ops.time_extract_sql( self.lookup_name, sql, tuple(params) ) else: # resolve_expression has already validated the output_field so this # assert should never be hit. assert False, "Tried to Extract from an invalid type." return sql, params [911406b0]
- def as_sql(self, compiler, connection): sql, params = compiler.compile(self.lhs) tzname = None if isinstance(self.lhs.output_field, DateTimeField): tzname = self.get_tzname() elif self.tzinfo is not None: raise ValueError("tzinfo can only be used with DateTimeField.") if isinstance(self.output_field, DateTimeField): sql, params = connection.ops.datetime_trunc_sql( self.kind, sql, tuple(params), tzname ) elif isinstance(self.output_field, DateField): sql, params = connection.ops.date_trunc_sql( self.kind, sql, tuple(params), tzname ) elif isinstance(self.output_field, TimeField): sql, params = connection.ops.time_trunc_sql( self.kind, sql, tuple(params), tzname ) else: raise ValueError( "Trunc only valid on DateField, TimeField, or DateTimeField." ) return sql, params [38a331fd]

## All facts

- [5fce5e47] def as_sqlite(self, compiler, connection, **extra_context): return self.as_sql( compiler, connection, template="STRFTIME('%%%%Y-%%%%m-%%%%d %%%%H:%%%%M:%%%%f', 'NOW')", **extra_context, )
- [feda8a4a] def convert_value(self, value, expression, connection): return connection.ops.convert_trunc_expression(value, expression)
- [f704f2bd] def get_tzname(self): # Timezone conversions must happen to the input datetime *before* # applying a function. 2015-12-31 23:00:00 -02:00 is stored in the # database as 2016-01-01 01:00:00 +00:00. Any results should be # based on the input datetime not the stored datetime. tzname = None if settings.USE_TZ: if self.tzinfo is None: tzname = timezone.get_current_timezone_name() else: tzname = timezone._get_timezone_name(self.tzinfo) return tzname
- [2ae30f76] def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False ): copy = super().resolve_expression( query, allow_joins, reuse, summarize, for_save ) field = copy.lhs.output_field # DateTimeField is a subclass of DateField so this works for both. if not isinstance(field, (DateField, TimeField)): raise TypeError( "%r isn't a DateField, TimeField, or DateTimeField." % field.name ) # If self.output_field was None, then accessing the field will trigger # the resolver to assign it to self.lhs.output_field. if not isinstance(copy.output_field, (DateField, DateTimeField, TimeField)): raise ValueError( "output_field must be either DateField, TimeField, or DateTimeField" ) # Passing dates or times to functions expecting datetimes is most # likely a mistake. class_output_field = ( self.__class__.output_field if isinstance(self.__class__.output_field, Field) else None ) output_field = class_output_field or copy.output_field has_explicit_output_field = ( class_output_field or field.__class__ is not copy.output_field.__class__ ) if type(field) is DateField and ( isinstance(output_field, DateTimeField) or copy.kind in ("hour", "minute", "second", "time") ): raise ValueError( "Cannot truncate DateField '%s' to %s." % ( field.name, ( output_field.__class__.__name__ if has_explicit_output_field else "DateTimeField" ), ) ) elif isinstance(field, TimeField) and ( isinstance(output_field, DateTimeField) or copy.kind in ("year", "quarter", "month", "week", "day", "date") ): raise ValueError( "Cannot truncate TimeField '%s' to %s." % ( field.name, ( output_field.__class__.__name__ if has_explicit_output_field else "DateTimeField" ), ) ) return copy
- [47ff3ac9] def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False ): copy = super().resolve_expression( query, allow_joins, reuse, summarize, for_save ) field = getattr(copy.lhs, "output_field", None) if field is None: return copy if not isinstance(field, (DateField, DateTimeField, TimeField, DurationField)): raise ValueError( "Extract input expression must be DateField, DateTimeField, " "TimeField, or DurationField." ) # Passing dates to functions expecting datetimes is most likely a # mistake. if type(field) is DateField and copy.lookup_name in ( "hour", "minute", "second", ): raise ValueError( "Cannot extract time component '%s' from DateField '%s'." % (copy.lookup_name, field.name) ) if isinstance(field, DurationField) and copy.lookup_name in ( "year", "iso_year", "month", "week", "week_day", "iso_week_day", "quarter", ): raise ValueError( "Cannot extract component '%s' from DurationField '%s'." % (copy.lookup_name, field.name) ) return copy
- [98e51ac6] kind = "week"
- [803e3eac] lookup_name = "iso_week_day"
- [b9280047] lookup_name = "iso_year"
- [db70a243] lookup_name = "week"
- [0454626a] lookup_name = "week_day"
- [034df26b] DateField.register_lookup(ExtractYear) DateField.register_lookup(ExtractMonth) DateField.register_lookup(ExtractDay) DateField.register_lookup(ExtractWeekDay) DateField.register_lookup(ExtractIsoWeekDay) DateField.register_lookup(ExtractWeek) DateField.register_lookup(ExtractIsoYear) DateField.register_lookup(ExtractQuarter)
- [ef68493e] DateTimeField.register_lookup(ExtractHour) DateTimeField.register_lookup(ExtractMinute) DateTimeField.register_lookup(ExtractSecond)
- [0240300c] DateTimeField.register_lookup(TruncDate) DateTimeField.register_lookup(TruncTime)
- [02ea0ef4] ExtractIsoYear.register_lookup(YearExact) ExtractIsoYear.register_lookup(YearGt) ExtractIsoYear.register_lookup(YearGte) ExtractIsoYear.register_lookup(YearLt) ExtractIsoYear.register_lookup(YearLte)
- [0d2bb552] ExtractYear.register_lookup(YearExact) ExtractYear.register_lookup(YearGt) ExtractYear.register_lookup(YearGte) ExtractYear.register_lookup(YearLt) ExtractYear.register_lookup(YearLte)
- [67e9af9c] TimeField.register_lookup(ExtractHour) TimeField.register_lookup(ExtractMinute) TimeField.register_lookup(ExtractSecond)
- [40c25668] class Extract(TimezoneMixin, Transform): lookup_name = None output_field = IntegerField()
- [d571dc67] class ExtractDay(Extract): lookup_name = "day"
- [3ec2d372] class ExtractHour(Extract): lookup_name = "hour"
- [c466c8b5] class ExtractIsoWeekDay(Extract): """Return Monday=1 through Sunday=7, based on ISO-8601."""
- [9172d754] class ExtractIsoYear(Extract): """Return the ISO-8601 week-numbering year."""
- [0cc00346] class ExtractMinute(Extract): lookup_name = "minute"
- [a13f2335] class ExtractMonth(Extract): lookup_name = "month"
- [9acf8f38] class ExtractQuarter(Extract): lookup_name = "quarter"
- [c8eefa6a] class ExtractSecond(Extract): lookup_name = "second"
- [f0dc2422] class ExtractWeek(Extract): """ Return 1-52 or 53, based on ISO-8601, i.e., Monday is the first of the week. """
- [e919b51b] class ExtractWeekDay(Extract): """ Return Sunday=1 through Saturday=7.
- [60691316] class ExtractYear(Extract): lookup_name = "year"
- [1c0f6b98] class Now(Func): template = "CURRENT_TIMESTAMP" output_field = DateTimeField()
- [a32f59ce] class TimezoneMixin: tzinfo = None
- [95cf95ab] class Trunc(TruncBase): def __init__( self, expression, kind, output_field=None, tzinfo=None, **extra, ): self.kind = kind super().__init__(expression, output_field=output_field, tzinfo=tzinfo, **extra)
- [30260825] class TruncBase(TimezoneMixin, Transform): kind = None tzinfo = None
- [ef153bd0] class TruncDate(TruncBase): kind = "date" lookup_name = "date" output_field = DateField()
- [23f7b153] class TruncDay(TruncBase): kind = "day"
- [a7da97f9] class TruncHour(TruncBase): kind = "hour"
- [25c618da] class TruncMinute(TruncBase): kind = "minute"
- [fb2fcf31] class TruncMonth(TruncBase): kind = "month"
- [68f3f8e2] class TruncQuarter(TruncBase): kind = "quarter"
- [2433f1d8] class TruncSecond(TruncBase): kind = "second"
- [1b77fdaa] class TruncTime(TruncBase): kind = "time" lookup_name = "time" output_field = TimeField()
- [6322d848] class TruncWeek(TruncBase): """Truncate to midnight on the Monday of the week."""
- [e434092f] class TruncYear(TruncBase): kind = "year"
- [50dfbee6] from django.conf import settings from django.db.models.expressions import Func from django.db.models.fields import ( DateField, DateTimeField, DurationField, Field, IntegerField, TimeField, ) from django.db.models.lookups import ( Transform, YearExact, YearGt, YearGte, YearLt, YearLte, ) from django.utils import timezone
