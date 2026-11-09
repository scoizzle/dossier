# django/contrib/postgres/operations

- Subject: django/contrib/postgres/operations (id `22f59fd2-ea60-4b80-b3d0-ce2fa0f8b60b`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 20 of 61
- Conflicts: 0
- Gaps: 0

## Facts

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
- def database_backwards(self, app_label, schema_editor, from_state, to_state): if schema_editor.connection.vendor != "postgresql" or not router.allow_migrate( schema_editor.connection.alias, app_label, **self.hints ): return if self.extension_exists(schema_editor, self.name): schema_editor.execute( "DROP EXTENSION IF EXISTS %s" % schema_editor.quote_name(self.name) ) # Clear cached, stale oids. get_hstore_oids.cache_clear() get_citext_oids.cache_clear() [ed2a054e]
- def database_backwards(self, app_label, schema_editor, from_state, to_state): self._ensure_not_in_transaction(schema_editor) model = from_state.apps.get_model(app_label, self.model_name) if self.allow_migrate_model(schema_editor.connection.alias, model): schema_editor.remove_index(model, self.index, concurrently=True) [e971f6ec]
- def describe(self): return f"Create collation {self.name}" [09bfcde7]

## Beyond the budget

35 more facts did not fit in the budget: [bbdb8828] [cb83f9f9] [57c93247] [62188702] [0c151cbe] [d9d6ae04] [ac6b1f5a63e03430] [90540e3f] [bd54efae] [2fd2c686] [d9870e5c] [0b61ef73] [a325703a] [fe0afdea] [540b0022] [a77c5d6f] [a952f4ec5eea6cc8] [b1880d00] [2d9680e1] [52c67206] [4a3f0f36] [9e3f07a9] [7b739c18] [b7b8477c] [512d8d49] [c25283ee] [4a6fc813] [6afe7f5b] [9faf0213] [1cdce19f] [4455094e] [86148f97] [12e40a8f] [92afe97b] [457d7761]
