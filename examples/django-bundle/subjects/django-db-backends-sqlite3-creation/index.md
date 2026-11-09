# django/db/backends/sqlite3/creation

- Subject: django/db/backends/sqlite3/creation (id `db560a6c-1026-4104-90f3-0fa401ab32a1`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1426 tokens
- Facts shown: 14 of 14
- Conflicts: 0
- Gaps: 0

## Highlights

- This takes into account the special cases of ":memory:" and "" for SQLite since the databases will be distinct despite having the same TEST NAME. See https://www.sqlite.org/inmemorydb.html """ test_database_name = self._get_test_db_name() sig = [self.connection.settings_dict["NAME"]] if self.is_in_memory_db(test_database_name): sig.append(self.connection.alias) else: sig.append(test_database_name) return tuple(sig) [b6ac99b7]
- if keepdb: return test_database_name if not self.is_in_memory_db(test_database_name): # Erase the old test database if verbosity >= 1: self.log( "Destroying old test database for alias %s..." % (self._get_database_display_str(verbosity, test_database_name),) ) if os.access(test_database_name, os.F_OK): if not autoclobber: confirm = input( "Type 'yes' if you would like to try deleting the test " "database '%s', or 'no' to cancel: " % test_database_name ) if autoclobber or confirm == "yes": try: os.remove(test_database_name) except Exception as e: self.log("Got an error deleting the old test database: %s" % e) sys.exit(2) else: self.log("Tests cancelled.") sys.exit(1) return test_database_name [222e5bfa]
- if not self.is_in_memory_db(source_database_name): root, ext = os.path.splitext(source_database_name) return {**orig_settings_dict, "NAME": f"{root}_{suffix}{ext}"} [88a248a7]
- start_method = multiprocessing.get_start_method() if start_method == "fork": return orig_settings_dict if start_method in {"forkserver", "spawn"}: return { **orig_settings_dict, "NAME": f"{self.connection.alias}_{suffix}.sqlite3", } raise NotSupportedError( f"Cloning with start method {start_method!r} is not supported." ) [a96757cc]
- def _clone_test_db(self, suffix, verbosity, keepdb=False): source_database_name = self.connection.settings_dict["NAME"] target_database_name = self.get_test_db_clone_settings(suffix)["NAME"] if not self.is_in_memory_db(source_database_name): # Erase the old test database if os.access(target_database_name, os.F_OK): if keepdb: return if verbosity >= 1: self.log( "Destroying old test database for alias %s..." % ( self._get_database_display_str( verbosity, target_database_name ), ) ) try: os.remove(target_database_name) except Exception as e: self.log("Got an error deleting the old test database: %s" % e) sys.exit(2) try: shutil.copy(source_database_name, target_database_name) except Exception as e: self.log("Got an error cloning the test database: %s" % e) sys.exit(2) # Forking automatically makes a copy of an in-memory database. # Forkserver and spawn require migrating to disk which will be # re-opened in setup_worker_connection. elif multiprocessing.get_start_method() in {"forkserver", "spawn"}: ondisk_db = sqlite3.connect(target_database_name, uri=True) self.connection.connection.backup(ondisk_db) ondisk_db.close() [2379db6b]
- def _create_test_db(self, verbosity, autoclobber, keepdb=False): test_database_name = self._get_test_db_name() [8346e990]
- def _destroy_test_db(self, test_database_name, verbosity): if test_database_name and not self.is_in_memory_db(test_database_name): # Remove the SQLite database file os.remove(test_database_name) [78d313df]
- def get_test_db_clone_settings(self, suffix): orig_settings_dict = self.connection.settings_dict source_database_name = orig_settings_dict["NAME"] or ":memory:" [a407266e]

## All facts

- [49ca3eac] def _get_test_db_name(self): test_database_name = self.connection.settings_dict["TEST"]["NAME"] or ":memory:" if test_database_name == ":memory:": return "file:memorydb_%s?mode=memory&cache=shared" % self.connection.alias return test_database_name
- [91231be0] def setup_worker_connection(self, _worker_id): settings_dict = self.get_test_db_clone_settings(_worker_id) # connection.settings_dict must be updated in place for changes to be # reflected in django.db.connections. Otherwise new threads would # connect to the default database instead of the appropriate clone. start_method = multiprocessing.get_start_method() if start_method == "fork": # Update settings_dict in place. self.connection.settings_dict.update(settings_dict) self.connection.close() elif start_method in {"forkserver", "spawn"}: alias = self.connection.alias connection_str = ( f"file:memorydb_{alias}_{_worker_id}?mode=memory&cache=shared" ) source_db_name = settings_dict["NAME"] source_db = self.connection.Database.connect( f"file:{source_db_name}?mode=ro", uri=True ) target_db = sqlite3.connect(connection_str, uri=True) source_db.backup(target_db) source_db.close() # Update settings_dict in place. self.connection.settings_dict.update(settings_dict) self.connection.settings_dict["NAME"] = connection_str # Re-open connection to in-memory database before closing copy # connection. self.connection.connect() target_db.close()
- [be207370] def test_db_signature(self): """ Return a tuple that uniquely identifies a test database.
- [f683c619] class DatabaseCreation(BaseDatabaseCreation): @staticmethod def is_in_memory_db(database_name): return not isinstance(database_name, Path) and ( database_name == ":memory:" or "mode=memory" in database_name )
- [86c5c8cd] from django.db import NotSupportedError from django.db.backends.base.creation import BaseDatabaseCreation
- [2b255c6b] import multiprocessing import os import shutil import sqlite3 import sys from pathlib import Path
