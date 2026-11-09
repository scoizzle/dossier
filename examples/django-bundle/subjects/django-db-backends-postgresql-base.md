# django/db/backends/postgresql/base

- Subject: django/db/backends/postgresql/base (id `1ee748d5-68b9-4efe-a7fe-c6d262f66fb3`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 14 of 67
- Conflicts: 0
- Gaps: 0

## Facts

- connect_kwargs = self.get_connection_params() # Ensure we run in autocommit, Django properly sets it later on. connect_kwargs["autocommit"] = True enable_checks = self.settings_dict["CONN_HEALTH_CHECKS"] # Copy to avoid mutating the user's settings dict. pool_options = {**pool_options} pool_options.setdefault( "check", ConnectionPool.check_connection if enable_checks else None ) pool = ConnectionPool( kwargs=connect_kwargs, open=False, # Do not open the pool during startup. configure=self._configure_connection, **pool_options, ) # setdefault() ensures that multiple threads don't set this in # parallel. Since we do not open the pool during its init above, # this means that at worst during startup multiple threads generate # pool objects and the first to set it wins. self._connection_pools.setdefault(self.alias, pool) [f43e1d48]
- if commit and not self.get_autocommit(): self.connection.commit() [27e92d7a]
- qparts = [sql.SQL("SELECT * FROM "), name, sql.SQL("(")] if args: for item in args: qparts.append(sql.Literal(item)) qparts.append(sql.SQL(",")) del qparts[-1] [a527e359]
- qparts.append(sql.SQL(")")) stmt = sql.Composed(qparts) self.execute(stmt) return args [fb83a542]
- try: from psycopg_pool import ConnectionPool except ImportError as err: raise ImproperlyConfigured( "Error loading psycopg_pool module.\nDid you install psycopg[pool]?" ) from err [e47a1b86]
- # Commit after setting the time zone. commit_tz = self._configure_timezone(connection) # Set the role on the connection. This is useful if the credential used # to login is not the same as the role that owns database resources. As # can be the case when using temporary or ephemeral credentials. commit_role = self._configure_role(connection) [394feabe]
- ClientCursorMixin forces the usage of client-side bindings while ServerCursor implements the logic required to declare and scroll through named cursors. [c469c659]
- Mixing ClientCursorMixin in wouldn't be necessary if Cursor allowed to specify how parameters should be bound instead, which ServerCursor would inherit, but that's not the case. """ [8b5d0e5d]
- conn_params.pop("assume_role", None) conn_params.pop("isolation_level", None) [4b4b8f16]
- def callproc(self, name, args=None): if not isinstance(name, sql.Identifier): name = sql.Identifier(name) [574a910e]
- def copy_to(self, file, table, *args, **kwargs): with self.debug_sql(sql="COPY %s TO STDOUT" % table): return self.cursor.copy_to(file, table, *args, **kwargs) [053d7462]
- if is_psycopg3: # Register the cursor timezone only if the connection disagrees, to # avoid copying the adapter map. tzloader = self.connection.adapters.get_loader(TIMESTAMPTZ_OID, Format.TEXT) if self.timezone != tzloader.timezone: register_tzloader(self.timezone, cursor) else: cursor.tzinfo_factory = self.tzinfo_factory if settings.USE_TZ else None return cursor [f607ab6b]
- if self.alias not in self._connection_pools: if self.settings_dict.get("CONN_MAX_AGE", 0) != 0: raise ImproperlyConfigured( "Pooling doesn't support persistent connections." ) # Set the default options. if pool_options is True: pool_options = {} [230c76bc]
- return commit_role or commit_tz [fdc69118]

## Beyond the budget

53 more facts did not fit in the budget: [e9ffe1bc] [7b54bf60] [75f41ea1] [c063377e] [4a5a91d2] [6ac2a623] [b021a3a4] [07284e20] [6f775e37] [ddf380c3] [635c1fcc] [625adaf6] [7f6b951d] [651c89f3] [eacc1ed6] [03ca6eb8] [75858019] [9abaf9c5] [c666b413] [009ca339] [dcfb8e8d] [4fae7a55] [39f24b1d] [88963ec7] [679f2b4aaecb8bda-2] [50b9cc734782b3f8-2] [9b9307c89d39e1a7-2] [ac8d31bd] [12745444] [8db236e0] [4e87d933] [57bc457f] [50a0108e] [eda0acb3] [97198f86] [e3d39f86] [02d2e6e0] [14d785ac] [0ca58588] [ec30cb46] [461cf4b3] [7f456acb] [dfbd3a39] [393c642c0b56a256] [ee6071cc] [a635f385] [2ce6280e] [7cf0fc75] [d71a6fba044908db-2] [745d95df] [b655a973] [42222f94] [9ab62e70]
