# django/db/backends/base/creation

- Subject: django/db/backends/base/creation (id `287f04d5-6eee-4f69-a08c-3080766a20eb`)
- Kind: subject
- Budget: 1200 tokens
- Used: 890 tokens
- Facts shown: 10 of 49
- Conflicts: 0
- Gaps: 0

## Facts

- self.log("Got an error creating the test database: %s" % e) if not autoclobber: confirm = input( "Type 'yes' if you would like to try deleting the test " "database '%s', or 'no' to cancel: " % test_database_name ) if autoclobber or confirm == "yes": try: if verbosity >= 1: self.log( "Destroying old test database for alias %s..." % ( self._get_database_display_str( verbosity, test_database_name ), ) ) cursor.execute("DROP DATABASE %(dbname)s" % test_db_params) self._execute_create_test_db(cursor, test_db_params, keepdb) except Exception as e: self.log("Got an error recreating the test database: %s" % e) sys.exit(2) else: self.log("Tests cancelled.") sys.exit(1) [adacce58]
- loader = MigrationLoader(self.connection) for app_config in apps.get_app_configs(): if ( app_config.models_module is not None and app_config.label in loader.migrated_apps and app_config.name not in settings.TEST_NON_SERIALIZED_APPS ): for model in app_config.get_models(): if model._meta.can_migrate( self.connection ) and router.allow_migrate_model(self.connection.alias, model): queryset = model._base_manager.using( self.connection.alias, ).order_by(model._meta.pk.name) chunk_size = ( 2000 if queryset._prefetch_related_lookups else None ) yield from queryset.iterator(chunk_size=chunk_size) [04d98191]
- self.log( "%s test database for alias %s..." % ( action, self._get_database_display_str(verbosity, test_database_name), ) ) [fe4015dd]
- # Ensure a connection for the side effect of initializing the test # database. self.connection.ensure_connection() [5e7238b1]
- # Iteratively return every object for all models to serialize. def get_objects(): from django.db.migrations.loader import MigrationLoader [e4b3bd42]
- # Restore the original database name if old_database_name is not None: settings.DATABASES[self.connection.alias]["NAME"] = old_database_name self.connection.settings_dict["NAME"] = old_database_name [7d85dc5b]
- # Serialize to a string out = StringIO() serializers.serialize("json", get_objects(), indent=None, stream=out) return out.getvalue() [1ed5b6c5]
- # We could skip this call if keepdb is True, but we instead # give it the keepdb param. See create_test_db for details. self._clone_test_db(suffix, verbosity, keepdb) [871a2a35]
- # We could skip this call if keepdb is True, but we instead # give it the keepdb param. This is to handle the case # where the test DB doesn't exist, in which case we need to # create it, then just not destroy it. If we instead skip # this, we will get an exception. self._create_test_db(verbosity, autoclobber, keepdb) [dc87d5e0]
- # We then serialize the current state of the database into a string # and store it on the connection. This slightly horrific process is so # people who are testing on databases without transactions or who are # using a TransactionTestCase still get a clean database on every test # run. if serialize is not None: warnings.warn( "DatabaseCreation.create_test_db(serialize) is deprecated. Call " "DatabaseCreation.serialize_test_db() once all test databases are set " "up instead if you need fixtures persistence between tests.", stacklevel=2, category=RemovedInDjango2028Warning, ) if serialize: self.connection._test_serialized_contents = ( self.serialize_db_to_string() ) [0a245e52]

## Beyond the budget

38 more facts did not fit in the budget: [40df31ab] [72691778] [299af0e7] [79984dd1] [b575083f] [e1cfd477] [68f17e77] [419c4ed0d0ca83a1] [cb8e55be] [5406a05a] [6a34a60c] [c5db0293] [58d9db0a] [aedcdc0442006877-2] [f0a7ddc935b65180] [b3de4b75] [cfd19420] [ab2a9145] [5890ecea] [25fcf64f] [7201d5bf] [78d27485] [72fc7eb4] [9b85148b] [ae700189] [26f5f425] [9afb2898] [dc13e8f2] [0b851ad0] [37c6cbed] [79b106dd] [e28cf26c] [d529ad15] [17afd79c] [27b5f955] [3cfdc85f] [e824af21] [d14dc323]
