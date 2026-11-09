# django/db/backends/sqlite3/base

- Subject: django/db/backends/sqlite3/base (id `7b6ee2d2-5489-432b-8de6-e21f28beda18`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 14 of 38
- Conflicts: 0
- Gaps: 0

## Facts

- Staying in autocommit mode works around a bug of sqlite3 that breaks savepoints when autocommit is disabled. """ if self.transaction_mode is None: self.cursor().execute("BEGIN") else: self.cursor().execute(f"BEGIN {self.transaction_mode}") [15acb150]
- conn.execute("PRAGMA foreign_keys = ON") # The macOS bundled SQLite defaults legacy_alter_table ON, which # prevents atomic table renames. conn.execute("PRAGMA legacy_alter_table = OFF") for init_command in self.init_commands: if init_command := init_command.strip(): conn.execute(init_command) return conn [0ff6bff5]
- init_command = kwargs.pop("init_command", "") self.init_commands = init_command.split(";") return kwargs [1c37d814]
- # The patterns below are used to generate SQL pattern lookup clauses when # the right-hand side of the lookup isn't a raw string (it might be an # expression or the result of a bilateral transformation). In those cases, # special characters for LIKE operators (e.g. \, *, _) should be escaped on # database side. # # Note: we use str.format() here for readability as '%' is used as a # wildcard for the LIKE operator. pattern_esc = r"REPLACE(REPLACE(REPLACE({}, '\', '\\'), '%%', '\%%'), '_', '\_')" pattern_ops = { "contains": r"LIKE '%%' || {} || '%%' ESCAPE '\'", "icontains": r"LIKE '%%' || UPPER({}) || '%%' ESCAPE '\'", "startswith": r"LIKE {} || '%%' ESCAPE '\'", "istartswith": r"LIKE UPPER({}) || '%%' ESCAPE '\'", "endswith": r"LIKE '%%' || {} ESCAPE '\'", "iendswith": r"LIKE '%%' || UPPER({}) ESCAPE '\'", } [6827ccc2]
- - "format" style to "qmark" style - "pyformat" style to "named" style [923108b9]
- @async_unsafe def close(self): self.validate_thread_sharing() # If database is in memory, closing the connection destroys the # database. To prevent accidental data loss, ignore close requests on # an in-memory db. if not self.is_in_memory_db(): BaseDatabaseWrapper.close(self) [4dddeb46]
- @async_unsafe def get_new_connection(self, conn_params): conn = Database.connect(**conn_params) register_functions(conn) [7ec24f36]
- Database = Database SchemaEditorClass = DatabaseSchemaEditor # Classes instantiated in __init__(). client_class = DatabaseClient creation_class = DatabaseCreation features_class = DatabaseFeatures introspection_class = DatabaseIntrospection ops_class = DatabaseOperations [834dbb72]
- In both cases, if you want to use a literal "%s", you'll need to use "%%s". """ [071ed3a0]
- This wrapper performs the following conversions: [ce4f92e5]
- def _savepoint_allowed(self): # When 'isolation_level' is not None, sqlite3 commits before each # savepoint; it's a bug. When it is None, savepoints don't make sense # because autocommit is enabled. The only exception is inside 'atomic' # blocks. To work around that bug, on SQLite, 'atomic' starts a # transaction explicitly rather than simply disable autocommit. return self.in_atomic_block [bd4612a6]
- def _start_transaction_under_autocommit(self): """ Start a transaction explicitly in autocommit mode. [e4f6aebd]
- def create_cursor(self, name=None): return self.connection.cursor(factory=SQLiteCursorWrapper) [53c19f53]
- def is_usable(self): return True [105dcdc39af5d768-2]

## Beyond the budget

24 more facts did not fit in the budget: [ba0ce2ac] [b60152ab] [95401dac] [8cd1cd81] [49d93457] [c89cb12c] [f427986a] [8ab94104] [cfcb27c7] [c0f9cd24] [74d23a5d] [41a813ee] [ed49842c] [0beea6b9] [2a1e4784] [4cfffde1] [8408ada0] [393c642c0b56a256-2] [179fd0a6] [ae6571eb] [576c6075] [df6d1333] [def15ed6] [5e1058d9]
