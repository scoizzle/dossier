# django/core/management/commands/migrate

- Subject: django/core/management/commands/migrate (id `f7f3a0dd-9e42-4059-83fd-16368e1306b6`)
- Kind: subject
- Budget: 1200 tokens
- Used: 894 tokens
- Facts shown: 8 of 30
- Conflicts: 0
- Gaps: 0

## Facts

- # Deferred SQL is executed when exiting the editor's context. if self.verbosity >= 1: self.stdout.write(" Running deferred SQL...") [36357af1]
- # At this point, ignore run_syncdb if there aren't any apps to sync. run_syncdb = options["run_syncdb"] and executor.loader.unmigrated_apps # Print some useful info if self.verbosity >= 1: self.stdout.write(self.style.MIGRATE_HEADING("Operations to perform:")) if run_syncdb: if options["app_label"]: self.stdout.write( self.style.MIGRATE_LABEL( " Synchronize unmigrated app: %s" % app_label ) ) else: self.stdout.write( self.style.MIGRATE_LABEL(" Synchronize unmigrated apps: ") + (", ".join(sorted(executor.loader.unmigrated_apps))) ) if target_app_labels_only: self.stdout.write( self.style.MIGRATE_LABEL(" Apply all migrations: ") + (", ".join(sorted({a for a, n in targets})) or "(none)") ) else: if targets[0][1] is None: self.stdout.write( self.style.MIGRATE_LABEL(" Unapply all migrations: ") + str(targets[0][0]) ) else: self.stdout.write( self.style.MIGRATE_LABEL(" Target specific migration: ") + "%s, from %s" % (targets[0][1], targets[0][0]) ) [94ded4ec]
- # Before anything else, see if there's conflicting apps and drop out # hard if there are any conflicts = executor.loader.detect_conflicts() if conflicts: name_str = "; ".join( "%s in %s" % (", ".join(names), app) for app, names in conflicts.items() ) raise CommandError( "Conflicting migrations detected; multiple leaf nodes in the " "migration graph: (%s).\nTo fix them run " "'python manage.py makemigrations --merge'" % name_str ) [9de88b44]
- # Build the manifest of apps and models that are to be synchronized. all_models = [ ( app_config.label, router.get_migratable_models( app_config, connection.alias, include_auto_created=False ), ) for app_config in apps.get_app_configs() if app_config.models_module is not None and app_config.label in app_labels ] [d8b82df2]
- # Create the tables for each model if self.verbosity >= 1: self.stdout.write(" Creating tables...") with connection.schema_editor() as editor: for app_name, model_list in manifest.items(): for model in model_list: # Never install unmanaged models, etc. if not model._meta.can_migrate(connection): continue if self.verbosity >= 3: self.stdout.write( " Processing %s.%s model" % (app_name, model._meta.object_name) ) if self.verbosity >= 1: self.stdout.write( " Creating table %s" % model._meta.db_table ) editor.create_model(model) [3b8a7d7a]
- # Get the database we're operating from connection = connections[database] [ab0c56ca]
- # Hook for backends needing any database preparation connection.prepare_database() # Work out which apps have migrations and which do not executor = MigrationExecutor(connection, self.migration_progress_callback) [d0b35396]
- # If they supplied command line arguments, work out what they mean. run_syncdb = options["run_syncdb"] target_app_labels_only = True if options["app_label"]: # Validate app_label. app_label = options["app_label"] try: apps.get_app_config(app_label) except LookupError as err: raise CommandError(str(err)) if run_syncdb: if app_label in executor.loader.migrated_apps: raise CommandError( "Can't use run_syncdb with app '%s' as it has migrations." % app_label ) elif app_label not in executor.loader.migrated_apps: raise CommandError("App '%s' does not have migrations." % app_label) [a4f1aecd]

## Beyond the budget

22 more facts did not fit in the budget: [fed2062e] [3e230afa] [46695815] [5d980a9a] [ddd8122c] [67f03fa4] [46cf4a4e] [37c31823] [42f59a97] [6fe3e5df] [18b838bf] [5bbcccdf] [5380c192] [b2f33794] [458654c9] [969b2227] [8280655d] [4750605b] [fb84c4b6] [7ac4b804] [ac03e399] [e783bc13]
