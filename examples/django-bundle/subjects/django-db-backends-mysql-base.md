# django/db/backends/mysql/base

- Subject: django/db/backends/mysql/base (id `d79cb73c-0cc6-456d-990f-6d52f6b7e87d`)
- Kind: subject
- Budget: 1200 tokens
- Used: 889 tokens
- Facts shown: 13 of 45
- Conflicts: 0
- Gaps: 0

## Facts

- if assignments: with self.cursor() as cursor: cursor.execute("; ".join(assignments)) [2fe92d56]
- if self.isolation_level: assignments.append( "SET SESSION TRANSACTION ISOLATION LEVEL %s" % self.isolation_level.upper() ) [8499e152]
- # For these data types MySQL and MariaDB don't support full width database # indexes. _limited_data_types = ( "tinyblob", "blob", "mediumblob", "longblob", "tinytext", "text", "mediumtext", "longtext", "json", ) [6c97bfde]
- # The patterns below are used to generate SQL pattern lookup clauses when # the right-hand side of the lookup isn't a raw string (it might be an # expression or the result of a bilateral transformation). In those cases, # special characters for LIKE operators (e.g. \, *, _) should be escaped on # database side. # # Note: we use str.format() here for readability as '%' is used as a # wildcard for the LIKE operator. pattern_esc = r"REPLACE(REPLACE(REPLACE({}, '\\', '\\\\'), '%%', '\%%'), '_', '\_')" pattern_ops = { "contains": "LIKE BINARY CONCAT('%%', {}, '%%')", "icontains": "LIKE CONCAT('%%', {}, '%%')", "startswith": "LIKE BINARY CONCAT({}, '%%')", "istartswith": "LIKE CONCAT({}, '%%')", "endswith": "LIKE BINARY CONCAT('%%', {})", "iendswith": "LIKE CONCAT('%%', {})", } [135b34b0]
- @async_unsafe def create_cursor(self, name=None): cursor = self.connection.cursor() return CursorWrapper(cursor) [65032097]
- @async_unsafe def get_new_connection(self, conn_params): connection = Database.connect(**conn_params) return connection [cfe3b0b2]
- @cached_property def data_type_check_constraints(self): if self.features.supports_column_check_constraints: check_constraints = { "PositiveBigIntegerField": "`%(column)s` >= 0", "PositiveIntegerField": "`%(column)s` >= 0", "PositiveSmallIntegerField": "`%(column)s` >= 0", } return check_constraints return {} [bacc5053]
- @cached_property def data_types(self): _data_types = self._data_types.copy() if self.features.has_native_uuid_field: _data_types["UUIDField"] = "uuid" return _data_types [04c69caf]
- @cached_property def display_name(self): return "MariaDB" if self.mysql_is_mariadb else "MySQL" [cd3f132d]
- @cached_property def mysql_is_mariadb(self): return "mariadb" in self.mysql_server_info.lower() [7b7852de]
- @cached_property def mysql_server_data(self): with self.temporary_connection() as cursor: # Select some server variables and test if the time zone # definitions are installed. CONVERT_TZ returns NULL if 'UTC' # timezone isn't loaded into the mysql.time_zone table. cursor.execute(""" SELECT VERSION(), @@sql_mode, @@default_storage_engine, @@sql_auto_is_null, @@lower_case_table_names, CONVERT_TZ('2001-01-01 01:00:00', 'UTC', 'UTC') IS NOT NULL """) row = cursor.fetchone() return { "version": row[0], "sql_mode": row[1], "default_storage_engine": row[2], "sql_auto_is_null": bool(row[3]), "lower_case_table_names": bool(row[4]), "has_zoneinfo_database": bool(row[5]), } [50d28cc3]
- @cached_property def mysql_server_info(self): return self.mysql_server_data["version"] [86cb5c1e]
- @cached_property def sql_mode(self): sql_mode = self.mysql_server_data["sql_mode"] return set(sql_mode.split(",") if sql_mode else ()) [20945a3f]

## Beyond the budget

32 more facts did not fit in the budget: [081a4172] [22591d27] [215766bf] [f6d21573] [d1405c27] [5c63437c1581c6b4] [0513f593] [f078d38d47261009] [b13780cd] [2c75a1e1] [14c580be] [0d677727] [3e8d8650] [3ac2bb61] [f4455885] [c7a7d165] [074cc644] [0a281438] [58494a9ba72da817] [deec4c58] [b5ab13a0] [38868e76] [a2d6592a] [fbfce5cc] [66b1dbac] [291a9792] [fe802270] [9e7bc321] [62de1d45] [bb2606b1] [902cd4a1] [162c57b4]
