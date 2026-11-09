# django/db/migrations/recorder

- Subject: django/db/migrations/recorder (id `f6665330-450f-480f-bcd7-18f6a95105ac`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 18 of 20
- Conflicts: 0
- Gaps: 0

## Facts

- class Meta: apps = Apps() app_label = "migrations" db_table = "django_migrations" [63e7c435]
- def __str__(self): return "Migration %s for %s" % (self.name, self.app) [30e614a2]
- class Migration(models.Model): app = models.CharField(max_length=255) name = models.CharField(max_length=255) applied = models.DateTimeField(default=now) [b339198f]
- cls._migration_class = Migration return cls._migration_class [8cc05195]
- self._has_table = self.Migration._meta.db_table in tables return self._has_table [cab53419]
- @classproperty def Migration(cls): """ Lazy load to avoid AppRegistryNotReady if installed apps import MigrationRecorder. """ if cls._migration_class is None: [08dcf4b9]
- @property def migration_qs(self): return self.Migration.objects.using(self.connection.alias) [a1fdfeb5]
- Because this table is actually itself used for dealing with model creation, it's the one thing we can't do normally via migrations. We manually handle table creation/schema updating (using schema backend) and then have a floating model to do queries with. [ca9f5bcc]
- If a migration is unapplied its row is removed from the table. Having a row in the table always means a migration is applied. """ [c6729a27]
- _migration_class = None [5580aff0]
- def __init__(self, connection): self.connection = connection self._has_table = False [c7bf9664]
- def applied_migrations(self): """ Return a dict mapping (app_name, migration_name) to Migration instances for all applied migrations. """ if self.has_table(): return { (migration.app, migration.name): migration for migration in self.migration_qs } else: # If the django_migrations table doesn't exist, then no migrations # are applied. return {} [de9bd98d]
- def ensure_schema(self): """Ensure the table exists and has the correct schema.""" # If the table's there, that's fine - we've never changed its schema # in the codebase. if self.has_table(): return # Make the table try: with self.connection.schema_editor() as editor: editor.create_model(self.Migration) except DatabaseError as exc: raise MigrationSchemaMissing( "Unable to create the django_migrations table (%s)" % exc ) [1ae1d338]
- def flush(self): """Delete all migration records. Useful for testing migrations.""" self.migration_qs.all().delete() [e16f28fb]
- def has_table(self): """Return True if the django_migrations table exists.""" # If the migrations table has already been confirmed to exist, don't # recheck its existence. if self._has_table: return True # It hasn't been confirmed to exist, recheck. with self.connection.cursor() as cursor: tables = self.connection.introspection.table_names(cursor) [c8764061]
- def record_applied(self, app, name): """Record that a migration was applied.""" self.ensure_schema() self.migration_qs.create(app=app, name=name) [181fb73c]
- def record_unapplied(self, app, name): """Record that a migration was unapplied.""" self.ensure_schema() self.migration_qs.filter(app=app, name=name).delete() [a48f5eb0]
- class MigrationRecorder: """ Deal with storing migration records in the database. [e1f4c174]

## Beyond the budget

2 more facts did not fit in the budget: [1c212820] [097bb444]
