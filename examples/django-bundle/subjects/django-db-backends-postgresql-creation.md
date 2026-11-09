# django/db/backends/postgresql/creation

- Subject: django/db/backends/postgresql/creation (id `00492d3e-bc7a-4cbe-9e81-c085c14b36e9`)
- Kind: subject
- Budget: 1200 tokens
- Used: 831 tokens
- Facts shown: 10 of 10
- Conflicts: 0
- Gaps: 0

## Facts

- source_database_name = self.connection.settings_dict["NAME"] target_database_name = self.get_test_db_clone_settings(suffix)["NAME"] test_db_params = { "dbname": self._quote_name(target_database_name), "suffix": self._get_database_create_suffix(template=source_database_name), } with self._nodb_cursor() as cursor: try: self._execute_create_test_db(cursor, test_db_params, keepdb) except Exception: try: if verbosity >= 1: self.log( "Destroying old test database for alias %s..." % ( self._get_database_display_str( verbosity, target_database_name ), ) ) cursor.execute("DROP DATABASE %(dbname)s" % test_db_params) self._execute_create_test_db(cursor, test_db_params, keepdb) except Exception as e: self.log("Got an error cloning the test database: %s" % e) sys.exit(2) [b650e1b2]
- def _clone_test_db(self, suffix, verbosity, keepdb=False): # CREATE DATABASE ... WITH TEMPLATE ... requires closing connections # to the template database. self.connection.close() self.connection.close_pool() [c399c23e]
- def _database_exists(self, cursor, database_name): cursor.execute( "SELECT 1 FROM pg_catalog.pg_database WHERE datname = %s", [strip_quotes(database_name)], ) return cursor.fetchone() is not None [81ae7f8e]
- def _destroy_test_db(self, test_database_name, verbosity): self.connection.close_pool() return super()._destroy_test_db(test_database_name, verbosity) [5d32bd1c]
- def _execute_create_test_db(self, cursor, parameters, keepdb=False): try: if keepdb and self._database_exists(cursor, parameters["dbname"]): # If the database should be kept and it already exists, don't # try to create a new one. return super()._execute_create_test_db(cursor, parameters, keepdb) except Exception as e: if not isinstance(e.__cause__, errors.DuplicateDatabase): # All errors except "database already exists" cancel tests. self.log("Got an error creating the test database: %s" % e) sys.exit(2) elif not keepdb: # If the database should be kept, ignore "database already # exists". raise [1a2670b6]
- def _get_database_create_suffix(self, encoding=None, template=None): suffix = "" if encoding: suffix += " ENCODING '{}'".format(encoding) if template: suffix += " TEMPLATE {}".format(self._quote_name(template)) return suffix and "WITH" + suffix [05c5f57c]
- def sql_table_creation_suffix(self): test_settings = self.connection.settings_dict["TEST"] if test_settings.get("COLLATION") is not None: raise ImproperlyConfigured( "PostgreSQL does not support collation setting at database " "creation time." ) return self._get_database_create_suffix( encoding=test_settings["CHARSET"], template=test_settings.get("TEMPLATE"), ) [0cb62c33]
- class DatabaseCreation(BaseDatabaseCreation): def _quote_name(self, name): return self.connection.ops.quote_name(name) [394c54c5]
- from django.core.exceptions import ImproperlyConfigured from django.db.backends.base.creation import BaseDatabaseCreation from django.db.backends.postgresql.psycopg_any import errors from django.db.backends.utils import strip_quotes [04c868ab]
- import sys [6b0cb2be5ea1bc3c-6]
