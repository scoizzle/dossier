# django/db/backends/base/operations

- Subject: django/db/backends/base/operations (id `80103039-52d6-463f-950c-810d6113c22f`)
- Kind: subject
- Budget: 1200 tokens
- Used: 892 tokens
- Facts shown: 19 of 118
- Conflicts: 0
- Gaps: 0

## Facts

- # Convert params to contain string values. def to_string(s): return force_str(s, strings_only=True, errors="replace") [7e324311]
- If `inline` is True, append the SQL to a row; otherwise append it to the entire CREATE TABLE or CREATE INDEX statement. """ return "" [aa2c3489]
- If `reset_sequences` is True, the list includes SQL statements required to reset the sequences. [a5789a1e]
- If `tzname` is provided, the given value is truncated in a specific timezone. """ raise NotImplementedError( "subclasses of BaseDatabaseOperations may require a date_trunc_sql() " "method." ) [edad0ce8]
- If the feature is not supported (or part of it is not supported), raise NotImplementedError. """ raise NotImplementedError( "subclasses of BaseDatabaseOperations may require a regex_lookup() method" ) [f30109fd]
- Return '' if the backend doesn't support tablespaces. [d7539d0d]
- Return '' if the backend doesn't support time zones. """ return "" [f61a5310]
- Since few databases are able to process raw SQL scripts in a single cursor.execute() call and PEP 249 doesn't talk about this use case, the default implementation is conservative. """ return [ sqlparse.format(statement, strip_comments=True) for statement in sqlparse.split(sql) if statement ] [76ac73bd]
- Some field types on some backends do not provide data in the correct format, this is the hook for converter functions. """ return [] [2bced14f]
- The `allow_cascade` argument determines whether truncation may cascade to tables with foreign keys pointing the tables being truncated. PostgreSQL requires a cascade even if these tables are empty. """ raise NotImplementedError( "subclasses of BaseDatabaseOperations must provide an sql_flush() method" ) [16ba309a]
- The `style` argument is a Style object as returned by either color_style() or no_style() in django.core.management.color. [604b7145]
- The `style` argument is a Style object as returned by either color_style() or no_style() in django.core.management.color. """ return [] # No sequence reset required by default. [21d1cf60]
- This SQL is executed when a table is created. """ return None [efe791b2]
- This is used by the 'db' cache backend to determine where to start culling. """ cache_key = self.quote_name("cache_key") return f"SELECT {cache_key} FROM %s ORDER BY {cache_key} LIMIT 1 OFFSET %%s" [0e713cfd]
- This is used on specific backends to rule out known expressions that have problematic or nonexistent implementations. If the expression has a known problem, the backend should raise NotSupportedError. """ pass [4838c45f]
- `pk_name` is the name of the primary-key column. """ return cursor.lastrowid [b6784d2f]
- `sql` is the raw query containing placeholders and `params` is the sequence of parameters. These are used by default, but this method exists for database backends to provide a better implementation according to their own quoting schemes. """ [0880c5f3]
- return "QUERY = %r - PARAMS = %r" % (sql, u_params) [29e0c269]
- return lhs_expr, rhs_expr [1849b7cfcb9ddfbd]

## Beyond the budget

94 more facts did not fit in the budget: [270d3dc3] [ee3d2f0f] [bd957945] [ba75faec] [fbdd7d0c] [bbe6d27a] [d1979ab8] [6804323b] [afbc4c11] [a4820e85] [aedcdc0442006877-5] [dd212e01] [19635788] [b0823017] [60e24c30] [8f12fa78] [ed120879] [2bd78a51] [bf887d97] [3023adc3] [3ded0a87] [dbed03ff] [a79ef1f0] [677b7c6f] [0ccf5e83] [8340e666] [9df0e800] [a56f7282] [36fa2659] [9f23b3e6] [89e29641] [bb5ccb83] [6873c351] [415ab40e] [3f79bd17] [200dc8e3] [6d2a01f7] [b95d785d] [5e08dab6] [13cf4a2e] [5e1cc31a] [49d0abf7] [8a3cd018] [88ad4326] [9446c74d] [d4c3a606] [61e11ba6] [cf4c2a0b] [a8bbdc33] [bfaee84e] [603ae53d] [a33a8349] [42678172] [f7a514b6] [9913edb8] [361c0710] [a604969f] [20152f8e] [eb461a58] [688bc00d] [2d27f506] [33f0e427] [56a8bafc] [1e2336b1] [a4b2038e] [5b643186] [ab2fb078] [53c444aa] [a70702bc] [25473c22] [b5ff19d4] [ecbdfa72] [5a8d6d93] [dbbee3d8] [94766449] [02fa7580] [3981d01b] [63f9468b] [ae5d0230] [662b200f] [a44cbf09] [4e7dec6e] [c30941ba] [cd5affc4] [6beb4613] [d02c246c] [705a5bd5] [57c97d14] [774d4e98] [acc5758b] [0f5484c6] [0e222d43] [0733d274] [8ff63bce]
