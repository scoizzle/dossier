# django/db/models/fields/generated

- Subject: django/db/models/fields/generated (id `82e5344d-aa71-439e-9f70-ab434a59f517`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 10 of 21
- Conflicts: 0
- Gaps: 0

## Facts

- return Col(self.model._meta.db_table, self, self.output_field) [22262bc9]
- self._query = Query(model=self.model, alias_cols=False) # Register lookups from the output_field class. for lookup_name, lookup in self.output_field.get_class_lookups().items(): self.register_lookup(lookup, lookup_name=lookup_name) [19a301f7]
- self.expression = expression self.output_field = output_field self.db_persist = db_persist super().__init__(**kwargs) [a271a002]
- @cached_property def cached_col(self): from django.db.models.expressions import Col [bd267b679aa06c01-2]
- @cached_property def referenced_fields(self): resolved_expression = self.expression.resolve_expression( self._query, allow_joins=False ) referenced_fields = [] for col in self._query._gen_cols([resolved_expression]): referenced_fields.append(col.target) return frozenset(referenced_fields) [159a3066]
- _query = None output_field = None [465f0265]
- def __init__(self, *, expression, output_field, db_persist, **kwargs): if kwargs.setdefault("editable", False): raise ValueError("GeneratedField cannot be editable.") if not kwargs.setdefault("blank", True): raise ValueError("GeneratedField must be blank.") if kwargs.get("default", NOT_PROVIDED) is not NOT_PROVIDED: raise ValueError("GeneratedField cannot have a default.") if kwargs.get("db_default", NOT_PROVIDED) is not NOT_PROVIDED: raise ValueError("GeneratedField cannot have a database default.") if db_persist not in (True, False): raise ValueError("GeneratedField.db_persist must be True or False.") [9ad80700]
- def _check_persistence(self, databases): errors = [] for db in databases: if not router.allow_migrate_model(db, self.model): continue connection = connections[db] if ( self.model._meta.required_db_vendor and self.model._meta.required_db_vendor != connection.vendor ): continue if not self.db_persist and not ( connection.features.supports_virtual_generated_columns or "supports_virtual_generated_columns" in self.model._meta.required_db_features ): errors.append( checks.Error( f"{connection.display_name} does not support non-persisted " "GeneratedFields.", obj=self, id="fields.E221", hint="Set db_persist=True on the field.", ) ) if self.db_persist and not ( connection.features.supports_stored_generated_columns or "supports_stored_generated_columns" in self.model._meta.required_db_features ): errors.append( checks.Error( f"{connection.display_name} does not support persisted " "GeneratedFields.", obj=self, id="fields.E222", hint="Set db_persist=False on the field.", ) ) return errors [38ce02d3]
- def _check_supported(self, databases): errors = [] for db in databases: if not router.allow_migrate_model(db, self.model): continue connection = connections[db] if ( self.model._meta.required_db_vendor and self.model._meta.required_db_vendor != connection.vendor ): continue if not ( connection.features.supports_virtual_generated_columns or "supports_stored_generated_columns" in self.model._meta.required_db_features ) and not ( connection.features.supports_stored_generated_columns or "supports_virtual_generated_columns" in self.model._meta.required_db_features ): errors.append( checks.Error( f"{connection.display_name} does not support GeneratedFields.", obj=self, id="fields.E220", ) ) return errors [f4ed573e]
- __all__ = ["GeneratedField"] [c208f1b6]

## Beyond the budget

10 more facts did not fit in the budget: [fceb3203] [f10b1bda] [90f087cf] [79ebaf56] [d57b0ae8] [80ffc14f] [23af3e5f] [a89684ae] [99393d2a] [f093878c]
