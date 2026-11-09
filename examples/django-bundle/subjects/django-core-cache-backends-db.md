# django/core/cache/backends/db

- Subject: django/core/cache/backends/db (id `857971f2-890a-424a-94c1-cf8db6e34bf3`)
- Kind: subject
- Budget: 1200 tokens
- Used: 887 tokens
- Facts shown: 13 of 35
- Conflicts: 0
- Gaps: 0

## Facts

- exp = connection.ops.adapt_datetimefield_value(exp) if result and mode == "touch": cursor.execute( "UPDATE %s SET %s = %%s WHERE %s = %%s" % (table, quote_name("expires"), quote_name("cache_key")), [exp, key], ) elif result and ( mode == "set" or (mode == "add" and current_expires < now) ): cursor.execute( "UPDATE %s SET %s = %%s, %s = %%s WHERE %s = %%s" % ( table, quote_name("value"), quote_name("expires"), quote_name("cache_key"), ), [b64encoded, exp, key], ) elif mode != "touch": cursor.execute( "INSERT INTO %s (%s, %s, %s) VALUES (%%s, %%s, %%s)" % ( table, quote_name("cache_key"), quote_name("value"), quote_name("expires"), ), [key, b64encoded, exp], ) else: return False # touch failed. except DatabaseError: # To be threadsafe, updates/inserts are allowed to fail # silently return False else: return True [b4b87c75]
- if result: current_expires = result[1] expression = models.Expression( output_field=models.DateTimeField() ) for converter in connection.ops.get_db_converters( expression ) + expression.get_db_converters(connection): current_expires = converter( current_expires, expression, connection ) [7c97f797]
- class CacheEntry: _meta = Options(table) [2308df55]
- db = router.db_for_read(self.cache_model_class) connection = connections[db] quote_name = connection.ops.quote_name [225fc673]
- db = router.db_for_write(self.cache_model_class) connection = connections[db] quote_name = connection.ops.quote_name table = quote_name(self._table) [78da2588]
- key_map = { self.make_and_validate_key(key, version=version): key for key in keys } [334dd0b9]
- now = tz_now().replace(microsecond=0, tzinfo=None) [463d6031]
- result = {} expired_keys = [] expression = models.Expression(output_field=models.DateTimeField()) converters = connection.ops.get_db_converters( expression ) + expression.get_db_converters(connection) for key, value, expires in rows: for converter in converters: expires = converter(expires, expression, connection) if expires < tz_now(): expired_keys.append(key) else: value = connection.ops.process_clob(value) value = pickle.loads(base64.b64decode(value.encode(), validate=True)) result[key_map.get(key)] = value self._base_delete_many(expired_keys) return result [35f4980a]
- self.cache_model_class = CacheEntry [44812aaa]
- with connection.cursor() as cursor: cursor.execute( "DELETE FROM %s WHERE %s IN (%s)" % ( table, quote_name("cache_key"), ", ".join(["%s"] * len(keys)), ), keys, ) return bool(cursor.rowcount) [53b812bd]
- with connection.cursor() as cursor: cursor.execute( "SELECT %s FROM %s WHERE %s = %%s and %s > %%s" % ( quote_name("cache_key"), quote_name(self._table), quote_name("cache_key"), quote_name("expires"), ), [key, connection.ops.adapt_datetimefield_value(now)], ) return cursor.fetchone() is not None [3e7f01c7]
- with connection.cursor() as cursor: cursor.execute( "SELECT %s, %s, %s FROM %s WHERE %s IN (%s)" % ( quote_name("cache_key"), quote_name("value"), quote_name("expires"), table, quote_name("cache_key"), ", ".join(["%s"] * len(key_map)), ), list(key_map), ) rows = cursor.fetchall() [79793ef1]
- This allows cache operations to be controlled by the router """ [10ab3cf4]

## Beyond the budget

20 more facts did not fit in the budget: [c5ee6b50] [41183fab] [e2dcdd74] [46f8baed] [bdfa5c72] [80a8fced] [fd500094] [410d7a7e] [af8dff99] [d3c82c78] [8b8496de] [aa34fbf4] [b2ac8c3e] [57716e3f] [b264102d] [a4d16172] [32fa9207] [50af6cdf] [f590c189] [085f8e5c]
