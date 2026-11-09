# django/core/management/commands/squashmigrations

- Subject: django/core/management/commands/squashmigrations (id `4587ee23-b164-4ca4-bda9-8b6f292cfd3e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 892 tokens
- Facts shown: 11 of 19
- Conflicts: 0
- Gaps: 0

## Facts

- if self.interactive: answer = None while not answer or answer not in "yn": answer = input("Do you wish to proceed? [y/N] ") if not answer: answer = "n" break else: answer = answer[0].lower() if answer != "y": return [e4255c61]
- if self.verbosity > 0: if len(new_operations) == len(operations): self.stdout.write(" No optimizations possible.") else: self.stdout.write( " Optimized from %s operations to %s operations." % (len(operations), len(new_operations)) ) [9174f4df]
- optimizer = MigrationOptimizer() new_operations = optimizer.optimize(operations, migration.app_label) [b1a51fcc]
- # Load the operations from all those migrations and concat together, # along with collecting external dependencies and detecting # double-squashing operations = [] dependencies = set() # We need to take all dependencies from the first migration in the list # as it may be 0002 depending on 0001 first_migration = True for smigration in migrations_to_squash: operations.extend(smigration.operations) for dependency in smigration.dependencies: if isinstance(dependency, SwappableTuple): if settings.AUTH_USER_MODEL == dependency.setting: dependencies.add(("__setting__", "AUTH_USER_MODEL")) else: dependencies.add(dependency) elif dependency[0] != smigration.app_label or first_migration: dependencies.add(dependency) first_migration = False [783ef87a]
- # Make a new migration with those operations subclass = type( "Migration", (migrations.Migration,), { "dependencies": dependencies, "operations": new_operations, "replaces": replaces, }, ) if start_migration_name: if squashed_name: # Use the name from --squashed-name. prefix, _ = start_migration.name.split("_", 1) name = "%s_%s" % (prefix, squashed_name) else: # Generate a name. name = "%s_squashed_%s" % (start_migration.name, migration.name) new_migration = subclass(name, app_label) else: name = "0001_%s" % (squashed_name or "squashed_%s" % migration.name) new_migration = subclass(name, app_label) new_migration.initial = True [0efb1421]
- # Tell them what we're doing and optionally ask if we should proceed if self.verbosity > 0 or self.interactive: self.stdout.write( self.style.MIGRATE_HEADING("Will squash the following migrations:") ) for migration in migrations_to_squash: self.stdout.write(" - %s" % migration.name) [3cdef730]
- # Work out the list of predecessor migrations migrations_to_squash = [ loader.get_migration(al, mn) for al, mn in loader.graph.forwards_plan( (migration.app_label, migration.name) ) if al == migration.app_label ] [22170bc1]
- # Write out the new migration file writer = MigrationWriter(new_migration, include_header) if os.path.exists(writer.path): raise CommandError( f"Migration {new_migration.name} already exists. Use a different name." ) with open(writer.path, "w", encoding="utf-8") as fh: fh.write(writer.as_string()) run_formatters([writer.path], stderr=self.stderr) [4237e2fc]
- if no_optimize: if self.verbosity > 0: self.stdout.write( self.style.MIGRATE_HEADING("(Skipping optimization.)") ) new_operations = operations else: if self.verbosity > 0: self.stdout.write(self.style.MIGRATE_HEADING("Optimizing...")) [de7c6da0]
- migration = self.find_migration(loader, app_label, migration_name) [10373607]
- import os import shutil [f3ff1053]

## Beyond the budget

8 more facts did not fit in the budget: [591053b2] [7c85e980] [44c3f311] [6a055d5d] [a931d245] [a783835a] [0074a476] [401a482a]
