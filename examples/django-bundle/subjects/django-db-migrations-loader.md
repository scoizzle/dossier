# django/db/migrations/loader

- Subject: django/db/migrations/loader (id `56209b1b-2947-42e4-8833-b67544f07083`)
- Kind: subject
- Budget: 1200 tokens
- Used: 888 tokens
- Facts shown: 12 of 29
- Conflicts: 0
- Gaps: 0

## Facts

- See graph.make_state() for the meaning of "nodes" and "at_end". """ return self.graph.make_state( nodes=nodes, at_end=at_end, real_apps=self.unmigrated_apps ) [23be06d7]
- replaced_keys = self._resolve_replaced_migration_keys(migration) # Get applied status of each found replacement target. applied_statuses = [ (target in self.applied_migrations) for target in replaced_keys ] # The replacing migration is only marked as applied if all of its # replacement targets are applied. if all(applied_statuses): self.applied_migrations[migration_key] = migration else: self.applied_migrations.pop(migration_key, None) # A replacing migration can be used if either all or none of its # replacement targets have been applied. if all(applied_statuses) or (not any(applied_statuses)): self.graph.remove_replaced_nodes(migration_key, migration.replaces) else: # This replacing migration cannot be used because it is # partially applied. Remove it from the graph and remap # dependencies to it (#25945). self.graph.remove_replacement_node(migration_key, migration.replaces) [a075406f]
- return False [8ca7a36d9615f007-2]
- self.replacements_progress[migration_key] = True [02e8b98d]
- @classmethod def migrations_module(cls, app_label): """ Return the path to the migrations module for the specified app_label and a boolean indicating if the module is specified in settings.MIGRATION_MODULE. """ if app_label in settings.MIGRATION_MODULES: return settings.MIGRATION_MODULES[app_label], True else: app_package_name = apps.get_app_config(app_label).name return "%s.%s" % (app_package_name, MIGRATIONS_MODULE_NAME), False [89b8bd71]
- Migration files are expected to live in the "migrations" directory of an app. Their names are entirely unimportant from a code perspective, but will probably follow the 1234_name.py convention. [9af311ad]
- On initialization, this class will scan those directories, and open and read the Python files, looking for a class called Migration, which should inherit from django.db.migrations.Migration. See django.db.migrations.migration for what that looks like. [084a2f0c]
- Some migrations will be marked as "replacing" another set of migrations. These are loaded into a separate set of migrations away from the main ones. If all the migrations they replace are either unapplied or missing from disk, then they are injected into the main set, replacing the named migrations. Any dependency pointers to the replaced migrations are re-pointed to the new migration. [74ed80cb]
- This does mean that this class MUST also talk to the database as well as to disk, but this is probably fine. We're already not just operating in memory. """ [3e1a8738]
- def __init__( self, connection, load=True, ignore_no_migrations=False, replace_migrations=True, ): self.connection = connection self.disk_migrations = None self.applied_migrations = None self.ignore_no_migrations = ignore_no_migrations self.replace_migrations = replace_migrations if load: self.build_graph() [e5d4be66]
- def get_migration(self, app_label, name_prefix): """Return the named migration or raise NodeNotFoundError.""" return self.graph.nodes[app_label, name_prefix] [8bc14425]
- MIGRATIONS_MODULE_NAME = "migrations" [dae991cc]

## Beyond the budget

17 more facts did not fit in the budget: [91d9ee02] [6259c5ed] [e03c50c8] [2e9146da] [8289dd9e] [cac69956] [da20375f] [a4ee0eda] [5a13a6d4] [2ce054df] [75addc76] [23fb96c3] [fa43fd95] [5dc556c2] [b8f51229] [d88c227f] [18a68795]
