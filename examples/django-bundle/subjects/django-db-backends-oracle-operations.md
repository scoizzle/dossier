# django/db/backends/oracle/operations

- Subject: django/db/backends/oracle/operations (id `bde609fe-9e3f-4eb8-b383-bad1748d9bd5`)
- Kind: subject
- Budget: 1200 tokens
- Used: 887 tokens
- Facts shown: 11 of 71
- Conflicts: 0
- Gaps: 0

## Facts

- # Oracle doesn't support tz-aware times if timezone.is_aware(value): raise ValueError("Oracle backend does not support timezone-aware times.") [5a1f5ac1]
- # oracledb doesn't support tz-aware datetimes if timezone.is_aware(value): if settings.USE_TZ: value = timezone.make_naive(value, self.connection.timezone) else: raise ValueError( "Oracle backend does not support timezone-aware datetimes when " "USE_TZ is False." ) [a92d1b5e]
- If naive datetime is passed assumes that is in UTC. Normally Django models.DateTimeField makes sure that if USE_TZ is True passed datetime is timezone aware. """ [5c8d8769]
- if isinstance(value, str): return datetime.datetime.strptime(value, "%H:%M:%S") [29953266]
- if value is None: return None [881e2b19]
- return Oracle_datetime( 1900, 1, 1, value.hour, value.minute, value.second, value.microsecond ) [b3fb025c]
- return Oracle_datetime.from_datetime(value) [14e8c536]
- truncated_tables = {table.upper() for table in tables} constraints = set() # Oracle's TRUNCATE CASCADE only works with ON DELETE CASCADE foreign # keys which Django doesn't define. Emulate the PostgreSQL behavior # which truncates all dependent tables by manually retrieving all # foreign key constraints and resolving dependencies. for table in tables: for foreign_table, constraint in self._foreign_key_constraints( table, recursive=allow_cascade ): if allow_cascade: truncated_tables.add(foreign_table) constraints.add((foreign_table, constraint)) sql = ( [ "%s %s %s %s %s %s %s %s;" % ( style.SQL_KEYWORD("ALTER"), style.SQL_KEYWORD("TABLE"), style.SQL_FIELD(self.quote_name(table)), style.SQL_KEYWORD("DISABLE"), style.SQL_KEYWORD("CONSTRAINT"), style.SQL_FIELD(self.quote_name(constraint)), style.SQL_KEYWORD("KEEP"), style.SQL_KEYWORD("INDEX"), ) for table, constraint in constraints ] + [ "%s %s %s;" % ( style.SQL_KEYWORD("TRUNCATE"), style.SQL_KEYWORD("TABLE"), style.SQL_FIELD(self.quote_name(table)), ) for table in truncated_tables ] + [ "%s %s %s %s %s %s;" % ( style.SQL_KEYWORD("ALTER"), style.SQL_KEYWORD("TABLE"), style.SQL_FIELD(self.quote_name(table)), style.SQL_KEYWORD("ENABLE"), style.SQL_KEYWORD("CONSTRAINT"), style.SQL_FIELD(self.quote_name(constraint)), ) for table, constraint in constraints ] ) if reset_sequences: sequences = [ sequence for sequence in self.connection.introspection.sequence_list() if sequence["table"].upper() in truncated_tables ] # Since we've just deleted all the rows, running our sequence ALTER # code will reset the sequence to 0. sql.extend(self.sequence_reset_by_name_sql(style, sequences)) return sql [73c84eb7]
- # EXTRACT format cannot be passed in parameters. _extract_format_re = _lazy_re_compile(r"[A-Z_]+") [d51ce70b9c1630cd-2]
- # Oracle crashes with "ORA-03113: end-of-file on communication channel" # if the time zone name is passed in parameter. Use interpolation instead. # https://groups.google.com/forum/#!msg/django-developers/zwQju7hbG78/9l934yelwfsJ # This regexp matches all time zone names from the zoneinfo database. _tzname_re = _lazy_re_compile(r"^[\w/:+-]+$") [c489933b]
- # oracledb always returns datetime.datetime objects for # DATE and TIMESTAMP columns, but Django wants to see a # python datetime.date, .time, or .datetime. [577c9fcd]

## Beyond the budget

60 more facts did not fit in the budget: [4f2a26dc] [d02191eb] [512b5cc8] [a6c473a9] [36a3bbb6] [feedc9e2] [5235116d] [5203b27a] [8d28dd6c] [a67b7ac9] [69e35ed28cef2bca-2] [0c66d29a] [6acd2fe4] [1466fe300f8d56b4] [36c6da6fa0266bb9-2] [261c78b9] [4096feae] [87c72ca3] [999b4c37] [a5bfeefdfb4f74a2-2] [63631614] [b28e1da37b4a4ece-2] [d7af8dfc] [3ca98ee4] [e6ed82d78972eefd-2] [060b7e5f] [64892adc] [886d8984] [d21ead53] [3fa54f3f] [37aa25c1] [9fdf550584590da8] [72c984fe] [cca62eab] [94a99616] [b60f86c7] [c0d88257] [929fb761] [8ece7ccc] [ffd4db45] [a2a607c5] [6110e0c140984a1d] [16b23464df2517ba-2] [e55834a68bf49ab9] [c00053ab] [9aea9b8a] [e87a4d29] [a17c96c4] [a2656ecf] [687ec08e] [d6b2815e1ddcc509-2] [3fd0b95e] [73fa3735] [2aac8c59021c4801] [8b14af7f] [88f89f76] [66f20882] [1c4426ac] [40d11d7a] [481dac9f]
