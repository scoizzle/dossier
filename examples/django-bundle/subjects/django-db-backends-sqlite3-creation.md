# django/db/backends/sqlite3/creation

- Subject: django/db/backends/sqlite3/creation (id `f112a5af-d5ad-426e-9e28-ea23065ea247`)
- Kind: subject
- Budget: 1200 tokens
- Used: 887 tokens
- Facts shown: 8 of 14
- Conflicts: 0
- Gaps: 0

## Facts

- This takes into account the special cases of ":memory:" and "" for SQLite since the databases will be distinct despite having the same TEST NAME. See https://www.sqlite.org/inmemorydb.html """ test_database_name = self._get_test_db_name() sig = [self.connection.settings_dict["NAME"]] if self.is_in_memory_db(test_database_name): sig.append(self.connection.alias) else: sig.append(test_database_name) return tuple(sig) [b6ac99b7]
- if keepdb: return test_database_name if not self.is_in_memory_db(test_database_name): # Erase the old test database if verbosity >= 1: self.log( "Destroying old test database for alias %s..." % (self._get_database_display_str(verbosity, test_database_name),) ) if os.access(test_database_name, os.F_OK): if not autoclobber: confirm = input( "Type 'yes' if you would like to try deleting the test " "database '%s', or 'no' to cancel: " % test_database_name ) if autoclobber or confirm == "yes": try: os.remove(test_database_name) except Exception as e: self.log("Got an error deleting the old test database: %s" % e) sys.exit(2) else: self.log("Tests cancelled.") sys.exit(1) return test_database_name [222e5bfa]
- if not self.is_in_memory_db(source_database_name): root, ext = os.path.splitext(source_database_name) return {**orig_settings_dict, "NAME": f"{root}_{suffix}{ext}"} [88a248a7]
- start_method = multiprocessing.get_start_method() if start_method == "fork": return orig_settings_dict if start_method in {"forkserver", "spawn"}: return { **orig_settings_dict, "NAME": f"{self.connection.alias}_{suffix}.sqlite3", } raise NotSupportedError( f"Cloning with start method {start_method!r} is not supported." ) [a96757cc]
- def _clone_test_db(self, suffix, verbosity, keepdb=False): source_database_name = self.connection.settings_dict["NAME"] target_database_name = self.get_test_db_clone_settings(suffix)["NAME"] if not self.is_in_memory_db(source_database_name): # Erase the old test database if os.access(target_database_name, os.F_OK): if keepdb: return if verbosity >= 1: self.log( "Destroying old test database for alias %s..." % ( self._get_database_display_str( verbosity, target_database_name ), ) ) try: os.remove(target_database_name) except Exception as e: self.log("Got an error deleting the old test database: %s" % e) sys.exit(2) try: shutil.copy(source_database_name, target_database_name) except Exception as e: self.log("Got an error cloning the test database: %s" % e) sys.exit(2) # Forking automatically makes a copy of an in-memory database. # Forkserver and spawn require migrating to disk which will be # re-opened in setup_worker_connection. elif multiprocessing.get_start_method() in {"forkserver", "spawn"}: ondisk_db = sqlite3.connect(target_database_name, uri=True) self.connection.connection.backup(ondisk_db) ondisk_db.close() [2379db6b]
- def _create_test_db(self, verbosity, autoclobber, keepdb=False): test_database_name = self._get_test_db_name() [8346e990]
- def _destroy_test_db(self, test_database_name, verbosity): if test_database_name and not self.is_in_memory_db(test_database_name): # Remove the SQLite database file os.remove(test_database_name) [78d313df]
- def get_test_db_clone_settings(self, suffix): orig_settings_dict = self.connection.settings_dict source_database_name = orig_settings_dict["NAME"] or ":memory:" [a407266e]

## Beyond the budget

6 more facts did not fit in the budget: [49ca3eac] [91231be0] [be207370] [f683c619] [86c5c8cd] [2b255c6b]
