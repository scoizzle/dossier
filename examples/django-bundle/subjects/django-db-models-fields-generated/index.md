# django/db/models/fields/generated

- Subject: django/db/models/fields/generated (id `4a875cec-aed3-4b85-af75-309b43b03b95`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1657 tokens
- Facts shown: 21 facts
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [fceb3203] def check(self, **kwargs): databases = kwargs.get("databases") or [] errors = [ *super().check(**kwargs), *self._check_supported(databases), *self._check_persistence(databases), ] output_field_clone = self.output_field.clone() output_field_clone.model = self.model output_field_checks = output_field_clone.check(databases=databases) if output_field_checks: separator = "\n " error_messages = separator.join( f"{output_check.msg} ({output_check.id})" for output_check in output_field_checks if isinstance(output_check, checks.Error) ) if error_messages: errors.append( checks.Error( "GeneratedField.output_field has errors:" f"{separator}{error_messages}", obj=self, id="fields.E223", ) ) warning_messages = separator.join( f"{output_check.msg} ({output_check.id})" for output_check in output_field_checks if isinstance(output_check, checks.Warning) ) if warning_messages: errors.append( checks.Warning( "GeneratedField.output_field has warnings:" f"{separator}{warning_messages}", obj=self, id="fields.W224", ) ) return errors
- [f10b1bda] def contribute_to_class(self, *args, **kwargs): super().contribute_to_class(*args, **kwargs)
- [90f087cf] def db_parameters(self, connection): return self.output_field.db_parameters(connection)
- [209377a3] def db_type_parameters(self, connection): return self.output_field.db_type_parameters(connection)
- [79ebaf56] def deconstruct(self): name, path, args, kwargs = super().deconstruct() del kwargs["blank"] del kwargs["editable"] kwargs["db_persist"] = self.db_persist kwargs["expression"] = self.expression kwargs["output_field"] = self.output_field return name, path, args, kwargs
- [d57b0ae8] def generated_sql(self, connection): compiler = connection.ops.compiler("SQLCompiler")( self._query, connection=connection, using=None ) resolved_expression = self.expression.resolve_expression( self._query, allow_joins=False ) sql, params = compiler.compile(resolved_expression) if ( getattr(self.expression, "conditional", False) and not connection.features.supports_boolean_expr_in_select_clause ): sql = f"CASE WHEN {sql} THEN 1 ELSE 0 END" return sql, params
- [80ffc14f] def get_col(self, alias, output_field=None): if alias != self.model._meta.db_table and output_field in (None, self): output_field = self.output_field return super().get_col(alias, output_field)
- [23af3e5f] def get_internal_type(self): return self.output_field.get_internal_type()
- [a89684ae] class GeneratedField(Field): generated = True db_returning = True
- [99393d2a] from . import NOT_PROVIDED, Field
- [f093878c] from django.core import checks from django.db import connections, router from django.db.models.sql import Query from django.utils.functional import cached_property
