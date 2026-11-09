# django/core/management/commands/makemigrations

- Subject: django/core/management/commands/makemigrations (id `ee2c36a8-a3bf-47b7-9708-a139e88d1b19`)
- Kind: subject
- Budget: 1200 tokens
- Used: 890 tokens
- Facts shown: 10 of 28
- Conflicts: 0
- Gaps: 0

## Facts

- for dependency in migration.dependencies: if isinstance(dependency, SwappableTuple): if settings.AUTH_USER_MODEL == dependency.setting: leaf_migration.dependencies.append( ("__setting__", "AUTH_USER_MODEL") ) else: leaf_migration.dependencies.append(dependency) elif dependency[0] != migration.app_label: leaf_migration.dependencies.append(dependency) # Optimize migration. optimizer = MigrationOptimizer() leaf_migration.operations = optimizer.optimize( leaf_migration.operations, app_label ) # Update name. previous_migration_path = MigrationWriter(leaf_migration).path name_fragment = self.migration_name or leaf_migration.suggest_name() suggested_name = leaf_migration.name[:4] + f"_{name_fragment}" if leaf_migration.name == suggested_name: new_name = leaf_migration.name + "_updated" else: new_name = suggested_name leaf_migration.name = new_name # Register overridden migration. new_changes[app_label] = [leaf_migration] update_previous_migration_paths[app_label] = previous_migration_path [2444b370]
- if not self.dry_run: # Write the merge migrations file to the disk with open(writer.path, "w", encoding="utf-8") as fh: fh.write(writer.as_string()) run_formatters([writer.path], stderr=self.stderr) if self.verbosity > 0: self.log("\nCreated new merge migration %s" % writer.path) if self.scriptable: self.stdout.write(writer.path) elif self.verbosity == 3: # Alternatively, makemigrations --merge --dry-run # --verbosity 3 will log the merge migrations rather than # saving the file to the disk. self.log( self.style.MIGRATE_HEADING( "Full merge migrations file '%s':" % writer.filename ) ) self.log(writer.as_string()) [41762e40]
- def all_items_equal(seq): return all(item == seq[0] for item in seq[1:]) [5b678c8e]
- # Detect changes changes = autodetector.changes( graph=loader.graph, trim_to_apps=app_labels or None, convert_apps=app_labels or None, migration_name=self.migration_name, ) [7ba77316]
- # If app_labels is specified, filter out conflicting migrations for # unspecified apps. if app_labels: conflicts = { app_label: conflict for app_label, conflict in conflicts.items() if app_label in app_labels } [0df13914]
- # If they want to make an empty migration, make one for each app if self.empty: if not app_labels: raise CommandError( "You must supply at least one app label when using --empty." ) # Make a fake changes() result we can pass to arrange_for_graph changes = {app: [Migration("custom", app)] for app in app_labels} changes = autodetector.arrange_for_graph( changes=changes, graph=loader.graph, migration_name=self.migration_name, ) self.write_migration_files(changes) return [77a6d29a]
- # If they want to merge and there is something to merge, then # divert into the merge code if self.merge and conflicts: return self.handle_merge(loader, conflicts) [52dbaaac]
- # If they want to merge and there's nothing to merge, then politely # exit if self.merge and not conflicts: self.log("No conflicts detected to merge.") return [5beed56f]
- # Load the current graph state. Pass in None for the connection so # the loader doesn't try to resolve replaced migrations from DB. loader = MigrationLoader(None, ignore_no_migrations=True) [e8a049c0]
- self.write_migration_files(new_changes, update_previous_migration_paths) [e896047b]

## Beyond the budget

18 more facts did not fit in the budget: [39c92426] [3cfc1938] [c389b018] [61eed8bd] [f4510498] [d6775f89] [f88f7d8d] [7217590f] [02cf5fd4] [5a9bdb74] [5cd504e1] [7fd30d6f] [eecfbb0b] [5e40bd45] [61541ddc] [a413ec1d] [2fe69302] [9a7693be]
