# django/db/backends/oracle/base

- Subject: django/db/backends/oracle/base (id `ca7e90cf-e768-406b-8f25-a3d291f84cd5`)
- Kind: subject
- Budget: 1200 tokens
- Used: 895 tokens
- Facts shown: 8 of 66
- Conflicts: 0
- Gaps: 0

## Facts

- pool = Database.create_pool( user=self.settings_dict["USER"], password=self.settings_dict["PASSWORD"], dsn=dsn(self.settings_dict), **connect_kwargs, ) self._connection_pools.setdefault(pool_key, pool) [9ead54f7]
- if self.settings_dict.get("CONN_MAX_AGE", 0) != 0: raise ImproperlyConfigured( "Pooling doesn't support persistent connections." ) [73b0bff4]
- pool_key = (self.alias, self.settings_dict["USER"]) if pool_key not in self._connection_pools: connect_kwargs = self.get_connection_params() pool_options = connect_kwargs.pop("pool") if pool_options is not True: connect_kwargs.update(pool_options) [c3830330]
- return self._connection_pools[pool_key] [7f7e92d2]
- string_size = 0 has_boolean_data_type = ( cursor.database.features.supports_boolean_expr_in_select_clause ) if not has_boolean_data_type: # Oracle < 23c doesn't recognize True and False correctly. if param is True: param = 1 elif param is False: param = 0 if hasattr(param, "bind_parameter"): self.force_bytes = param.bind_parameter(cursor) elif isinstance(param, (bytes, datetime.timedelta)): self.force_bytes = param else: # To transmit to the database, we need Unicode if supported # To get size right, we must consider bytes. self.force_bytes = force_str(param, cursor.charset, strings_only) if isinstance(self.force_bytes, str): # We could optimize by only converting up to 4000 bytes here string_size = len(force_bytes(param, cursor.charset, strings_only)) if hasattr(param, "input_size"): # If parameter has `input_size` attribute, use that. self.input_size = param.input_size elif string_size > 4000: # Mark any string param greater than 4000 characters as a CLOB. self.input_size = Database.DB_TYPE_CLOB elif isinstance(param, datetime.datetime): self.input_size = Database.DB_TYPE_TIMESTAMP elif has_boolean_data_type and isinstance(param, bool): self.input_size = Database.DB_TYPE_BOOLEAN else: self.input_size = None if self.input_size in self.lob_types: if self.force_bytes is not None and not isinstance( self.force_bytes, Database.LOB ): self.force_bytes = cursor.connection.createlob( self.input_size, self.force_bytes ) self.input_size = None [d2ac8e7d]
- # Oracle doesn't support a database index on these columns. _limited_data_types = ("clob", "nclob", "blob") [fe7581a3]
- # Oracle doesn't support releasing savepoints. But we fake them when query # logging is enabled to keep query counts consistent with other backends. def _savepoint_commit(self, sid): if self.queries_logged: self.queries_log.append( { "sql": "-- RELEASE SAVEPOINT %s (faked)" % self.ops.quote_name(sid), "time": "0.000", } ) [75489a18]
- # The patterns below are used to generate SQL pattern lookup clauses when # the right-hand side of the lookup isn't a raw string (it might be an # expression or the result of a bilateral transformation). In those cases, # special characters for LIKE operators (e.g. \, %, _) should be escaped on # the database side. # # Note: we use str.format() here for readability as '%' is used as a # wildcard for the LIKE operator. pattern_esc = r"REPLACE(REPLACE(REPLACE({}, '\', '\\'), '%%', '\%%'), '_', '\_')" _pattern_ops = { "contains": "'%%' || {} || '%%'", "icontains": "'%%' || UPPER({}) || '%%'", "startswith": "{} || '%%'", "istartswith": "UPPER({}) || '%%'", "endswith": "'%%' || {}", "iendswith": "'%%' || UPPER({})", } [055d31f3]

## Beyond the budget

58 more facts did not fit in the budget: [3a9e800a] [ef5ecf1b] [99323113] [7e0ada53] [56c3a758] [bd7d4f00] [6dea0d3a] [74b90b1e] [9ef219fe] [61342b78] [f1563712] [ab210cc1] [e844b8ad] [548513ff] [5c63437c1581c6b4-2] [928ce47b] [ed72b50d] [4d9b941e] [56bc93c2] [f10c8d18] [f078d38d47261009-2] [10ee8bfb] [f04db9dc] [f65bf7be] [1c2898dc] [d8965edf] [9b9bcd23] [679f2b4aaecb8bda] [0fa1a556] [8721b904] [50b9cc734782b3f8] [daa4051e] [9b9307c89d39e1a7] [6f4d9f77] [974bff7e] [4652eb45] [e0c43227] [12d3bc6d] [a39dbbe3] [58494a9ba72da817-2] [959f10d9] [91c952f7] [cb67ed5f] [0ac541ab] [aa8bb872] [0ad74b77] [4468430c] [3d582d9f] [d1409065] [9d6fdbe4] [aafec0d9] [5453d943] [15f86334] [ed843cc3] [f6a0047b] [fbd4b368] [712559e3] [64b2d63e]
