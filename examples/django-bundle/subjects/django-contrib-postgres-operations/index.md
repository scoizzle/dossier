# django/contrib/postgres/operations

- Subject: django/contrib/postgres/operations (id `61f860bc-b2d6-4a04-a6d9-4e716f59be93`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 3258 tokens
- Facts shown: 61 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- @property def migration_name_fragment(self): return "%s_validate_%s" % (self.model_name.lower(), self.name.lower()) [cede26cd]
- @property def migration_name_fragment(self): return "create_collation_%s" % self.name.lower() [61d1e70c]
- @property def migration_name_fragment(self): return "create_extension_%s" % self.name [6012a1a0]
- @property def migration_name_fragment(self): return "remove_collation_%s" % self.name.lower() [437cb2df]
- @property def migration_name_fragment(self): return super().migration_name_fragment + "_not_valid" [40173a56]
- atomic = False category = OperationCategory.ADDITION [76007c39]
- atomic = False category = OperationCategory.REMOVAL [b89e3206]
- category = OperationCategory.ADDITION [ac9c8334b988dfa0]
- category = OperationCategory.ADDITION [ac9c8334b988dfa0-2]
- category = OperationCategory.ALTERATION [581948d1f9b584af]
- category = OperationCategory.REMOVAL [7d1ad44cd1b46380]
- def __init__(self, model_name, constraint): if not isinstance(constraint, CheckConstraint): raise TypeError( "AddConstraintNotValid.constraint must be a check constraint." ) super().__init__(model_name, constraint) [0996cfa0]
- def __init__(self, model_name, name): self.model_name = model_name self.name = name [d314c5ef4f2e7b9b]
- def __init__(self, name, hints=None): self.name = name self.hints = hints or {} [6995d39c]
- def create_collation(self, schema_editor): args = {"locale": schema_editor.quote_name(self.locale)} if self.provider != "libc": args["provider"] = schema_editor.quote_name(self.provider) if self.deterministic is False: args["deterministic"] = "false" schema_editor.execute( "CREATE COLLATION %(name)s (%(args)s)" % { "name": schema_editor.quote_name(self.name), "args": ", ".join( f"{option}={value}" for option, value in args.items() ), } ) [bb921680]
- def database_backwards(self, app_label, schema_editor, from_state, to_state): # PostgreSQL does not provide a way to make a constraint invalid. pass [be06e6a8]
- def database_backwards(self, app_label, schema_editor, from_state, to_state): if not router.allow_migrate(schema_editor.connection.alias, app_label): return self.create_collation(schema_editor) [500ccda1]
- def database_backwards(self, app_label, schema_editor, from_state, to_state): if not router.allow_migrate(schema_editor.connection.alias, app_label): return self.remove_collation(schema_editor) [1cfa78ac]
- def database_backwards(self, app_label, schema_editor, from_state, to_state): if schema_editor.connection.vendor != "postgresql" or not router.allow_migrate( schema_editor.connection.alias, app_label, **self.hints ): return if self.extension_exists(schema_editor, self.name): schema_editor.execute( "DROP EXTENSION IF EXISTS %s" % schema_editor.quote_name(self.name) ) # Clear cached, stale oids. get_hstore_oids.cache_clear() get_citext_oids.cache_clear() [ed2a054e]
- def deconstruct(self): return ( self.__class__.__name__, [], { "model_name": self.model_name, "name": self.name, }, ) [ac6b1f5a63e03430]

## All facts

- [e971f6ec] def database_backwards(self, app_label, schema_editor, from_state, to_state): self._ensure_not_in_transaction(schema_editor) model = from_state.apps.get_model(app_label, self.model_name) if self.allow_migrate_model(schema_editor.connection.alias, model): schema_editor.remove_index(model, self.index, concurrently=True)
- [bbdb8828] def database_backwards(self, app_label, schema_editor, from_state, to_state): self._ensure_not_in_transaction(schema_editor) model = to_state.apps.get_model(app_label, self.model_name) if self.allow_migrate_model(schema_editor.connection.alias, model): to_model_state = to_state.models[app_label, self.model_name_lower] index = to_model_state.get_index_by_name(self.name) schema_editor.add_index(model, index, concurrently=True)
- [cb83f9f9] def database_forwards(self, app_label, schema_editor, from_state, to_state): if schema_editor.connection.vendor != "postgresql" or not router.allow_migrate( schema_editor.connection.alias, app_label ): return self.create_collation(schema_editor)
- [860f30cc] def database_forwards(self, app_label, schema_editor, from_state, to_state): if schema_editor.connection.vendor != "postgresql" or not router.allow_migrate( schema_editor.connection.alias, app_label ): return self.remove_collation(schema_editor)
- [57c93247] def database_forwards(self, app_label, schema_editor, from_state, to_state): if schema_editor.connection.vendor != "postgresql" or not router.allow_migrate( schema_editor.connection.alias, app_label, **self.hints ): return if not self.extension_exists(schema_editor, self.name): schema_editor.execute( "CREATE EXTENSION IF NOT EXISTS %s" % schema_editor.quote_name(self.name) ) # Clear cached, stale oids. get_hstore_oids.cache_clear() get_citext_oids.cache_clear() # Registering new type handlers cannot be done before the extension is # installed, otherwise a subsequent data migration would use the same # connection. register_type_handlers(schema_editor.connection) if hasattr(schema_editor.connection, "register_geometry_adapters"): schema_editor.connection.register_geometry_adapters( schema_editor.connection.connection, True )
- [62188702] def database_forwards(self, app_label, schema_editor, from_state, to_state): model = from_state.apps.get_model(app_label, self.model_name) if self.allow_migrate_model(schema_editor.connection.alias, model): constraint_sql = self.constraint.create_sql(model, schema_editor) if constraint_sql: # Constraint.create_sql returns interpolated SQL which makes # params=None a necessity to avoid escaping attempts on # execution. schema_editor.execute(str(constraint_sql) + " NOT VALID", params=None)
- [0c151cbe] def database_forwards(self, app_label, schema_editor, from_state, to_state): model = from_state.apps.get_model(app_label, self.model_name) if self.allow_migrate_model(schema_editor.connection.alias, model): schema_editor.execute( "ALTER TABLE %s VALIDATE CONSTRAINT %s" % ( schema_editor.quote_name(model._meta.db_table), schema_editor.quote_name(self.name), ) )
- [29e0d212] def database_forwards(self, app_label, schema_editor, from_state, to_state): self._ensure_not_in_transaction(schema_editor) model = from_state.apps.get_model(app_label, self.model_name) if self.allow_migrate_model(schema_editor.connection.alias, model): from_model_state = from_state.models[app_label, self.model_name_lower] index = from_model_state.get_index_by_name(self.name) schema_editor.remove_index(model, index, concurrently=True)
- [c1be775a] def database_forwards(self, app_label, schema_editor, from_state, to_state): self._ensure_not_in_transaction(schema_editor) model = to_state.apps.get_model(app_label, self.model_name) if self.allow_migrate_model(schema_editor.connection.alias, model): schema_editor.add_index(model, self.index, concurrently=True)
- [d9d6ae04] def deconstruct(self): kwargs = {"name": self.name, "locale": self.locale} if self.provider and self.provider != "libc": kwargs["provider"] = self.provider if self.deterministic is False: kwargs["deterministic"] = self.deterministic return ( self.__class__.__qualname__, [], kwargs, )
- [90540e3f] def describe(self): return "Concurrently create index %s on field(s) %s of model %s" % ( self.index.name, ", ".join(self.index.fields), self.model_name, )
- [bd54efae] def describe(self): return "Concurrently remove index %s from %s" % (self.name, self.model_name)
- [2fd2c686] def describe(self): return "Create not valid constraint %s on model %s" % ( self.constraint.name, self.model_name, )
- [d9870e5c] def describe(self): return "Creates extension %s" % self.name
- [0b61ef73] def describe(self): return "Validate constraint %s on model %s" % (self.name, self.model_name)
- [09bfcde7] def describe(self): return f"Create collation {self.name}"
- [a325703a] def describe(self): return f"Remove collation {self.name}"
- [fe0afdea] def extension_exists(self, schema_editor, extension): with schema_editor.connection.cursor() as cursor: cursor.execute( "SELECT 1 FROM pg_extension WHERE extname = %s", [extension], ) return bool(cursor.fetchone())
- [540b0022] def reduce(self, operation, app_label): if isinstance(operation, RemoveCollation) and self.name == operation.name: return [] return super().reduce(operation, app_label)
- [a77c5d6f] def remove_collation(self, schema_editor): schema_editor.execute( "DROP COLLATION %s" % schema_editor.quote_name(self.name), )
- [a952f4ec5eea6cc8] def state_forwards(self, app_label, state): pass
- [a952f4ec5eea6cc8-2] def state_forwards(self, app_label, state): pass
- [a952f4ec5eea6cc8-3] def state_forwards(self, app_label, state): pass
- [b1880d00] class AddConstraintNotValid(AddConstraint): """ Add a table constraint without enforcing validation, using PostgreSQL's NOT VALID syntax. """
- [2d9680e1] class AddIndexConcurrently(NotInTransactionMixin, AddIndex): """Create an index using PostgreSQL's CREATE INDEX CONCURRENTLY syntax."""
- [52c67206] class BloomExtension(CreateExtension): def __init__(self, hints=None): super().__init__("bloom", hints=hints)
- [4a3f0f36] class BtreeGinExtension(CreateExtension): def __init__(self, hints=None): super().__init__("btree_gin", hints=hints)
- [9e3f07a9] class BtreeGistExtension(CreateExtension): def __init__(self, hints=None): super().__init__("btree_gist", hints=hints)
- [7b739c18] class CITextExtension(CreateExtension): def __init__(self, hints=None): super().__init__("citext", hints=hints)
- [b7b8477c] class CollationOperation(Operation): def __init__(self, name, locale, *, provider="libc", deterministic=True): self.name = name self.locale = locale self.provider = provider self.deterministic = deterministic
- [512d8d49] class CreateCollation(CollationOperation): """Create a collation."""
- [c25283ee] class CreateExtension(Operation): reversible = True category = OperationCategory.ADDITION
- [4a6fc813] class CryptoExtension(CreateExtension): def __init__(self, hints=None): super().__init__("pgcrypto", hints=hints)
- [6afe7f5b] class HStoreExtension(CreateExtension): def __init__(self, hints=None): super().__init__("hstore", hints=hints)
- [9faf0213] class NotInTransactionMixin: def _ensure_not_in_transaction(self, schema_editor): if schema_editor.connection.in_atomic_block: raise NotSupportedError( "The %s operation cannot be executed inside a transaction " "(set atomic = False on the migration)." % self.__class__.__name__ )
- [1cdce19f] class RemoveCollation(CollationOperation): """Remove a collation."""
- [4455094e] class RemoveIndexConcurrently(NotInTransactionMixin, RemoveIndex): """Remove an index using PostgreSQL's DROP INDEX CONCURRENTLY syntax."""
- [86148f97] class TrigramExtension(CreateExtension): def __init__(self, hints=None): super().__init__("pg_trgm", hints=hints)
- [12e40a8f] class UnaccentExtension(CreateExtension): def __init__(self, hints=None): super().__init__("unaccent", hints=hints)
- [92afe97b] class ValidateConstraint(Operation): """Validate a table NOT VALID constraint."""
- [457d7761] from django.contrib.postgres.signals import ( get_citext_oids, get_hstore_oids, register_type_handlers, ) from django.db import NotSupportedError, router from django.db.migrations import AddConstraint, AddIndex, RemoveIndex from django.db.migrations.operations.base import Operation, OperationCategory from django.db.models.constraints import CheckConstraint
