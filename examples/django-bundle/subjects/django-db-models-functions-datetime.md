# django/db/models/functions/datetime

- Subject: django/db/models/functions/datetime (id `6a896a6b-c21d-4f9a-a5bd-87a378a2a7a1`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 9 of 53
- Conflicts: 0
- Gaps: 0

## Facts

- To replicate this in Python: (mydatetime.isoweekday() % 7) + 1 """ [6f2d8d2b]
- def __init__( self, expression, output_field=None, tzinfo=None, **extra, ): self.tzinfo = tzinfo super().__init__(expression, output_field=output_field, **extra) [54544b01]
- def __init__(self, expression, lookup_name=None, tzinfo=None, **extra): if self.lookup_name is None: self.lookup_name = lookup_name if self.lookup_name is None: raise ValueError("lookup_name must be provided") self.tzinfo = tzinfo super().__init__(expression, **extra) [066c01bb]
- def as_mysql(self, compiler, connection, **extra_context): return self.as_sql( compiler, connection, template="CURRENT_TIMESTAMP(6)", **extra_context ) [b3e42340]
- def as_oracle(self, compiler, connection, **extra_context): return self.as_sql( compiler, connection, template="LOCALTIMESTAMP", **extra_context ) [a786df27]
- def as_postgresql(self, compiler, connection, **extra_context): # PostgreSQL's CURRENT_TIMESTAMP means "the time at the start of the # transaction". Use STATEMENT_TIMESTAMP to be cross-compatible with # other databases. return self.as_sql( compiler, connection, template="STATEMENT_TIMESTAMP()", **extra_context ) [f9bbae81]
- def as_sql(self, compiler, connection): # Cast to date rather than truncate to date. sql, params = compiler.compile(self.lhs) tzname = self.get_tzname() return connection.ops.datetime_cast_date_sql(sql, tuple(params), tzname) [0dd61c54]
- def as_sql(self, compiler, connection): sql, params = compiler.compile(self.lhs) lhs_output_field = self.lhs.output_field if isinstance(lhs_output_field, DateTimeField): tzname = self.get_tzname() sql, params = connection.ops.datetime_extract_sql( self.lookup_name, sql, tuple(params), tzname ) elif self.tzinfo is not None: raise ValueError("tzinfo can only be used with DateTimeField.") elif isinstance(lhs_output_field, DateField): sql, params = connection.ops.date_extract_sql( self.lookup_name, sql, tuple(params) ) elif isinstance(lhs_output_field, TimeField): sql, params = connection.ops.time_extract_sql( self.lookup_name, sql, tuple(params) ) elif isinstance(lhs_output_field, DurationField): if not connection.features.has_native_duration_field: raise ValueError( "Extract requires native DurationField database support." ) sql, params = connection.ops.time_extract_sql( self.lookup_name, sql, tuple(params) ) else: # resolve_expression has already validated the output_field so this # assert should never be hit. assert False, "Tried to Extract from an invalid type." return sql, params [911406b0]
- def as_sql(self, compiler, connection): sql, params = compiler.compile(self.lhs) tzname = None if isinstance(self.lhs.output_field, DateTimeField): tzname = self.get_tzname() elif self.tzinfo is not None: raise ValueError("tzinfo can only be used with DateTimeField.") if isinstance(self.output_field, DateTimeField): sql, params = connection.ops.datetime_trunc_sql( self.kind, sql, tuple(params), tzname ) elif isinstance(self.output_field, DateField): sql, params = connection.ops.date_trunc_sql( self.kind, sql, tuple(params), tzname ) elif isinstance(self.output_field, TimeField): sql, params = connection.ops.time_trunc_sql( self.kind, sql, tuple(params), tzname ) else: raise ValueError( "Trunc only valid on DateField, TimeField, or DateTimeField." ) return sql, params [38a331fd]

## Beyond the budget

43 more facts did not fit in the budget: [5fce5e47] [feda8a4a] [f704f2bd] [2ae30f76] [47ff3ac9] [98e51ac6] [803e3eac] [b9280047] [db70a243] [0454626a] [034df26b] [ef68493e] [0240300c] [02ea0ef4] [0d2bb552] [67e9af9c] [40c25668] [d571dc67] [3ec2d372] [c466c8b5] [9172d754] [0cc00346] [a13f2335] [9acf8f38] [c8eefa6a] [f0dc2422] [e919b51b] [60691316] [1c0f6b98] [a32f59ce] [95cf95ab] [30260825] [ef153bd0] [23f7b153] [a7da97f9] [25c618da] [fb2fcf31] [68f3f8e2] [2433f1d8] [1b77fdaa] [6322d848] [e434092f] [50dfbee6]
