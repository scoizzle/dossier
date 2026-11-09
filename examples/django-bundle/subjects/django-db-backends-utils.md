# django/db/backends/utils

- Subject: django/db/backends/utils (id `f7f3221f-1b58-4620-8862-a61825ef4cde`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 14 of 37
- Conflicts: 0
- Gaps: 0

## Facts

- # The following methods cannot be implemented in __getattr__, because the # code must run when the method is invoked, not just when it is accessed. [d1bb1a5a]
- @contextmanager def debug_sql( self, sql=None, params=None, use_last_executed_query=False, many=False ): start = time.monotonic() try: yield finally: stop = time.monotonic() duration = stop - start if use_last_executed_query: sql = self.db.ops.last_executed_query(self.cursor, sql, params) try: times = len(params) if many else "" except TypeError: # params could be an iterator. times = "?" self.db.queries_log.append( { "sql": "%s times: %s" % (times, sql) if many else sql, "time": "%.3f" % duration, } ) logger.debug( "(%.3f) %s; args=%s; alias=%s", duration, sql, params, self.db.alias, extra={ "duration": duration, "sql": sql, "params": params, "alias": self.db.alias, }, ) [80124aa5]
- APPS_NOT_READY_WARNING_MSG = ( "Accessing the database during app initialization is discouraged. To fix this " "warning, avoid executing queries in AppConfig.ready() or when your app " "modules are imported." ) [25e59995]
- If a quote stripped name contains a namespace, e.g. USERNAME"."TABLE, truncate the table portion only. """ namespace, name = split_identifier(identifier) [14632572]
- The identifier could be a table, column, or sequence name might be prefixed by a namespace. """ try: namespace, name = identifier.split('"."') except ValueError: namespace, name = "", identifier return namespace.strip('"'), name.strip('"') [ee5acd4a]
- WRAP_ERROR_ATTRS = frozenset(["fetchone", "fetchmany", "fetchall", "nextset"]) [dc5bc772]
- def __enter__(self): return self [3ef33e95d940f83e-2]
- def __exit__(self, type, value, traceback): # Close instead of passing through to avoid backend-specific behavior # (#17671). Catch errors liberally because errors in cleanup code # aren't useful. try: self.close() except self.db.Database.Error: pass [0900357b]
- def __getattr__(self, attr): cursor_attr = getattr(self.cursor, attr) if attr in CursorWrapper.WRAP_ERROR_ATTRS: return self.db.wrap_database_errors(cursor_attr) else: return cursor_attr [efc837d9]
- def __iter__(self): with self.db.wrap_database_errors: yield from self.cursor [978b1ad8]
- def _execute(self, sql, params, *ignored_wrapper_args): # Raise a warning during app initialization (stored_app_configs is only # ever set during testing). if not apps.ready and not apps.stored_app_configs: warnings.warn(self.APPS_NOT_READY_WARNING_MSG, category=RuntimeWarning) self.db.validate_no_broken_transaction() with self.db.wrap_database_errors: if params is None: # params default might be backend specific. return self.cursor.execute(sql) else: return self.cursor.execute(sql, params) [781aafc1]
- def _execute_with_wrappers(self, sql, params, many, executor): context = {"connection": self.db, "cursor": self} for wrapper in reversed(self.db.execute_wrappers): executor = functools.partial(wrapper, executor) return executor(sql, params, many, context) [9a74c901]
- def execute(self, sql, params=None): return self._execute_with_wrappers( sql, params, many=False, executor=self._execute ) [c2f69116]
- if length is None or len(name) <= length: return identifier [10a9a920]

## Beyond the budget

22 more facts did not fit in the budget: [06f8f917] [bb8c0a89] [a8e61c8d] [5c42400e] [68c59278] [0f4e4ef6] [df9ee2bb] [df159afc] [ebc12ca9] [da2a0b38] [5cd4bb5e] [e9708d45] [a2a0ddc7] [e88b8e26] [663884f3] [98c20ba8] [345bc7bb] [5d24608f] [8b769ccd] [2864c307] [293975d5] [5b8b32d1]
