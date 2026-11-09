# django/core/management/commands/loaddata

- Subject: django/core/management/commands/loaddata (id `fcab6112-f3d9-47bf-b13a-9edff41853e4`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 11 of 47
- Conflicts: 0
- Gaps: 0

## Facts

- for obj in objects: objects_in_fixture += 1 if self.save_obj(obj): loaded_objects_in_fixture += 1 if show_progress: self.stdout.write( "\rProcessed %i object(s)." % loaded_objects_in_fixture, ending="", ) except Exception as e: if not isinstance(e, CommandError): e.args = ( "Problem installing fixture '%s': %s" % (fixture_file, e), ) raise finally: fixture.close() [9b663556]
- # Check kept for backwards-compatibility; it isn't clear why # duplicates are only allowed in different directories. if len(fixture_files_in_dir) > 1: raise CommandError( "Multiple fixtures named '%s' in %s. Aborting." % (fixture_name, humanize(fixture_dir)) ) fixture_files.extend(fixture_files_in_dir) [256965b8]
- if objects_in_fixture and show_progress: self.stdout.write() # Add a newline after progress indicator. self.loaded_object_count += loaded_objects_in_fixture self.fixture_object_count += objects_in_fixture # Warn if the fixture we loaded contains 0 objects. if objects_in_fixture == 0: warnings.warn( "No fixture data found for '%s'. (File format may be " "invalid.)" % fixture_name, RuntimeWarning, ) [919afe89]
- if self.app_label and app_label != self.app_label: continue if os.path.isdir(app_dir): dirs.append(app_dir) dirs.extend(fixture_dirs) dirs.append("") return [os.path.realpath(d) for d in dirs] [d29cf0e6]
- # Close the DB connection -- unless we're still in a transaction. This # is required as a workaround for an edge case in MySQL: if the same # connection is used to create tables, load data, and query, the query # can return incorrect results. See Django #7572, MySQL #37735. if transaction.get_autocommit(self.using): connections[self.using].close() [0853a7e1]
- # Django's test suite repeatedly tries to load initial_data fixtures # from apps that don't have any fixtures. Because disabling constraint # checks can be expensive on some database (especially MSSQL), bail # out early if no fixtures are found. for fixture_label in fixture_labels: if self.find_fixtures(fixture_label): break else: return [2e3cdc63]
- # If we found even one object in a fixture, we need to reset the # database sequences. if self.loaded_object_count > 0: self.reset_sequences(connection, self.models) [7f3de8d7]
- # Keep a count of the installed objects and fixtures self.fixture_count = 0 self.loaded_object_count = 0 self.fixture_object_count = 0 self.models = set() [5d922e0c]
- # Since we disabled constraint checks, we must manually check for # any invalid keys that might have been added table_names = [model._meta.db_table for model in self.models] try: connection.check_constraints(table_names=table_names) except Exception as e: e.args = ("Problem installing fixtures: %s" % e,) raise [f6610fde]
- fixture_name, fixture_dirs = self.get_fixture_name_and_dirs(fixture_name) targets = self.get_targets(fixture_name, ser_fmt, cmp_fmt) fixture_files = [] for fixture_dir in fixture_dirs: if self.verbosity >= 2: self.stdout.write("Checking %s for fixtures..." % humanize(fixture_dir)) fixture_files_in_dir = self.find_fixture_files_in_dir( fixture_dir, fixture_name, targets, ) if self.verbosity >= 2 and not fixture_files_in_dir: self.stdout.write( "No fixture '%s' in %s." % (fixture_name, humanize(fixture_dir)) ) [fdbcc422]
- name = ".".join(parts) [9d65eb36]

## Beyond the budget

36 more facts did not fit in the budget: [8c6db958] [b2a2fcd5] [bb25a686] [f4e88ccf] [af19a1d5] [d4340cd2] [544ced47] [71b985bc] [44f82321] [4184f1ca] [7e7dbef7] [c942230f] [edc4f175] [8cdb4231] [69799106] [6a6a0a32] [ba22f2e2] [f312fe7a] [bac60213] [812f0d20] [59e3c807] [5cf975f0] [50510f0f] [27023127] [63a5c62d] [e4423ed5] [774b9cde7dc731fe-2] [c57526821f3d9823-2] [1425b923] [618c5aa5] [a53eb1af] [dbab2da5] [7728b9e8] [f74580c4] [b8873fe84a6dd996-2] [72504776bae1f8f5-2]
