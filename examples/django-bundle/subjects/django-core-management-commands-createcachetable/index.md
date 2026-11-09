# django/core/management/commands/createcachetable

- Subject: django/core/management/commands/createcachetable (id `f9bb4d32-dd8c-4bf5-807e-428c5431e870`)
- Kind: subject
- Budget: 1200 tokens
- Used: 864 tokens
- Facts shown: 11 of 12
- Conflicts: 0
- Gaps: 0

## Facts

- fields = ( # "key" is a reserved word in MySQL, so use "cache_key" instead. models.CharField( name="cache_key", max_length=255, unique=True, primary_key=True ), models.TextField(name="value"), models.DateTimeField(name="expires", db_index=True), ) table_output = [] index_output = [] qn = connection.ops.quote_name for f in fields: field_output = [ qn(f.name), f.db_type(connection=connection), "%sNULL" % ("NOT " if not f.null else ""), ] if f.primary_key: field_output.append("PRIMARY KEY") elif f.unique: field_output.append("UNIQUE") if f.db_index: unique = "UNIQUE " if f.unique else "" index_output.append( "CREATE %sINDEX %s ON %s (%s);" % ( unique, qn("%s_%s" % (tablename, f.name)), qn(tablename), qn(f.name), ) ) table_output.append(" ".join(field_output)) full_statement = ["CREATE TABLE %s (" % qn(tablename)] for i, line in enumerate(table_output): full_statement.append( " %s%s" % (line, "," if i < len(table_output) - 1 else "") ) full_statement.append(");") [2a860be6]
- full_statement = "\n".join(full_statement) [0d94c78d]
- if dry_run: self.stdout.write(full_statement) for statement in index_output: self.stdout.write(statement) return [0aac8468]
- if self.verbosity > 1: self.stdout.write("Cache table '%s' created." % tablename) [d431b56a]
- if tablename in connection.introspection.table_names(): if self.verbosity > 0: self.stdout.write("Cache table '%s' already exists." % tablename) return [37874061]
- with transaction.atomic( using=database, savepoint=connection.features.can_rollback_ddl ): with connection.cursor() as curs: try: curs.execute(full_statement) except DatabaseError as e: raise CommandError( "Cache table '%s' could not be created.\nThe error was: %s." % (tablename, e) ) for statement in index_output: curs.execute(statement) [84beb96b]
- def add_arguments(self, parser): parser.add_argument( "args", metavar="table_name", nargs="*", help=( "Optional table names. Otherwise, settings.CACHES is used to find " "cache tables." ), ) parser.add_argument( "--database", default=DEFAULT_DB_ALIAS, choices=tuple(connections), help="Nominates a database onto which the cache tables will be " 'installed. Defaults to the "default" database.', ) parser.add_argument( "--dry-run", action="store_true", help="Does not create the table, just prints the SQL that would be run.", ) [46fd7a99]
- def create_table(self, database, tablename, dry_run): cache = BaseDatabaseCache(tablename, {}) if not router.allow_migrate_model(database, cache.cache_model_class): return connection = connections[database] [bba197de]
- def handle(self, *tablenames, **options): db = options["database"] self.verbosity = options["verbosity"] dry_run = options["dry_run"] if tablenames: # Legacy behavior, tablename specified as argument for tablename in tablenames: self.create_table(db, tablename, dry_run) else: for cache_alias in settings.CACHES: cache = caches[cache_alias] if isinstance(cache, BaseDatabaseCache): self.create_table(db, cache._table, dry_run) [6d6be2dd]
- requires_system_checks = [] [72e6d136f77918ef-4]
- class Command(BaseCommand): help = "Creates the tables needed to use the SQL cache backend." [b2efc8e5]

## Beyond the budget

1 more facts did not fit in the budget: [6f6155e3]
