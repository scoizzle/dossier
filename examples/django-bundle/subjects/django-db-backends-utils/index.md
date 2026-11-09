# django/db/backends/utils

- Subject: django/db/backends/utils (id `27ffb6f4-56b5-44c0-81bb-16734e008203`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2598 tokens
- Facts shown: 37 facts
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [06f8f917] def _executemany(self, sql, param_list, *ignored_wrapper_args): # Raise a warning during app initialization (stored_app_configs is only # ever set during testing). if not apps.ready and not apps.stored_app_configs: warnings.warn(self.APPS_NOT_READY_WARNING_MSG, category=RuntimeWarning) self.db.validate_no_broken_transaction() with self.db.wrap_database_errors: return self.cursor.executemany(sql, param_list)
- [bb8c0a89] def callproc(self, procname, params=None, kparams=None): # Keyword parameters for callproc aren't supported in PEP 249, but the # database driver may support them (e.g. oracledb). if kparams is not None and not self.db.features.supports_callproc_kwargs: raise NotSupportedError( "Keyword parameters for callproc are not supported on this " "database backend." ) # Raise a warning during app initialization (stored_app_configs is only # ever set during testing). if not apps.ready and not apps.stored_app_configs: warnings.warn(self.APPS_NOT_READY_WARNING_MSG, category=RuntimeWarning) self.db.validate_no_broken_transaction() with self.db.wrap_database_errors: if params is None and kparams is None: return self.cursor.callproc(procname) elif kparams is None: return self.cursor.callproc(procname, params) else: params = params or () return self.cursor.callproc(procname, params, kparams)
- [a8e61c8d] def execute(self, sql, params=None): with self.debug_sql(sql, params, use_last_executed_query=True): return super().execute(sql, params)
- [5c42400e] def executemany(self, sql, param_list): return self._execute_with_wrappers( sql, param_list, many=True, executor=self._executemany )
- [68c59278] def executemany(self, sql, param_list): with self.debug_sql(sql, param_list, many=True): return super().executemany(sql, param_list)
- [0f4e4ef6] digest = names_digest(name, length=hash_len) return "%s%s%s" % ( '%s"."' % namespace if namespace else "", name[: length - hash_len], digest, )
- [df9ee2bb] ############################################### # Converters from Python to database (string) # ###############################################
- [517f02f5] ############################################### # Converters from database (string) to Python # ###############################################
- [df159afc] @contextmanager def debug_transaction(connection, sql): start = time.monotonic() try: yield finally: if connection.queries_logged: stop = time.monotonic() duration = stop - start connection.queries_log.append( { "sql": "%s" % sql, "time": "%.3f" % duration, } ) logger.debug( "(%.3f) %s; args=%s; alias=%s", duration, sql, None, connection.alias, extra={ "duration": duration, "sql": sql, "alias": connection.alias, }, )
- [ebc12ca9] class CursorDebugWrapper(CursorWrapper): # XXX callproc isn't instrumented at this time.
- [da2a0b38] class CursorWrapper: def __init__(self, cursor, db): self.cursor = cursor self.db = db
- [5cd4bb5e] def format_number(value, max_digits, decimal_places): """ Format a number into a string with the requisite number of digits and decimal places. """ if value is None: return None context = decimal.getcontext().copy() if max_digits is not None: context.prec = max_digits if decimal_places is not None: value = value.quantize( decimal.Decimal(1).scaleb(-decimal_places), context=context ) else: context.traps[decimal.Rounded] = 1 value = context.create_decimal(value) return "{:f}".format(value)
- [e9708d45] def names_digest(*args, length): """ Generate a 32-bit digest of a set of arguments that can be used to shorten identifying names. """ h = md5(usedforsecurity=False) for arg in args: h.update(arg.encode()) return h.hexdigest()[:length]
- [a2a0ddc7] def split_identifier(identifier): """ Split an SQL identifier into a two element tuple of (namespace, name).
- [e88b8e26] def split_tzname_delta(tzname): """ Split a time zone name into a 3-tuple of (name, sign, offset). """ for sign in ["+", "-"]: if sign in tzname: name, offset = tzname.rsplit(sign, 1) if offset and parse_time(offset): if ":" not in offset: offset = f"{offset}:00" return name, sign, offset return tzname, None, None
- [663884f3] def strip_quotes(table_name): """ Strip quotes off of quoted table names to make them safe for use in index names, sequence names, etc. For example '"USER"."TABLE"' (an Oracle naming scheme) becomes 'USER"."TABLE'. """ has_quotes = table_name.startswith('"') and table_name.endswith('"') return table_name[1:-1] if has_quotes else table_name
- [98c20ba8] def truncate_name(identifier, length=None, hash_len=4): """ Shorten an SQL identifier to a repeatable mangled version with the given length.
- [345bc7bb] def typecast_date(s): return ( datetime.date(*map(int, s.split("-"))) if s else None ) # return None if s is null
- [5d24608f] def typecast_time(s): # does NOT store time zone information if not s: return None hour, minutes, seconds = s.split(":") if "." in seconds: # check whether seconds have a fractional part seconds, microseconds = seconds.split(".") else: microseconds = "0" return datetime.time( int(hour), int(minutes), int(seconds), int((microseconds + "000000")[:6]) )
- [8b769ccd] def typecast_timestamp(s): # does NOT store time zone information # "2005-07-29 15:48:00.590358-05" # "2005-07-29 09:56:00-05" if not s: return None if " " not in s: return typecast_date(s) d, t = s.split() # Remove timezone information. if "-" in t: t, _ = t.split("-", 1) elif "+" in t: t, _ = t.split("+", 1) dates = d.split("-") times = t.split(":") seconds = times[2] if "." in seconds: # check whether seconds have a fractional part seconds, microseconds = seconds.split(".") else: microseconds = "0" return datetime.datetime( int(dates[0]), int(dates[1]), int(dates[2]), int(times[0]), int(times[1]), int(seconds), int((microseconds + "000000")[:6]), )
- [2864c307] from django.apps import apps from django.db import NotSupportedError from django.utils.dateparse import parse_time
- [293975d5] import datetime import decimal import functools import logging import time import warnings from contextlib import contextmanager from hashlib import md5
- [5b8b32d1] logger = logging.getLogger("django.db.backends")
