# django/db/migrations/operations/fields

- Subject: django/db/migrations/operations/fields (id `3864dd9b-62bb-4a99-bf8b-481971d6b204`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 3029 tokens
- Facts shown: 53 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- if ( isinstance(operation, DeleteModel) and operation.name_lower == self.model_name_lower ): return [operation] return super().reduce(operation, app_label) [19f4917c]
- @cached_property def model_name_lower(self): return self.model_name.lower() [0eadb4a7d232abbe-2]
- @cached_property def name_lower(self): return self.name.lower() [0eeb44ca74e0840e]
- @cached_property def new_name_lower(self): return self.new_name.lower() [10501aecba252e62]
- @cached_property def old_name_lower(self): return self.old_name.lower() [1dc011641d755971]
- @property def migration_name_fragment(self): return "%s_%s" % (self.model_name_lower, self.name_lower) [19031635]
- @property def migration_name_fragment(self): return "alter_%s_%s" % (self.model_name_lower, self.name_lower) [577947d8]
- @property def migration_name_fragment(self): return "remove_%s_%s" % (self.model_name_lower, self.name_lower) [617c8694]
- @property def migration_name_fragment(self): return "rename_%s_%s_%s" % ( self.old_name_lower, self.model_name_lower, self.new_name_lower, ) [8d0da294]
- category = OperationCategory.ADDITION [ac9c8334b988dfa0-3]
- category = OperationCategory.ALTERATION [581948d1f9b584af-2]
- category = OperationCategory.ALTERATION [581948d1f9b584af-3]
- category = OperationCategory.REMOVAL [7d1ad44cd1b46380-2]
- def __init__(self, model_name, name, field, preserve_default=True): self.preserve_default = preserve_default super().__init__(model_name, name, field) [f134af85bfed7692]
- def __init__(self, model_name, name, field, preserve_default=True): self.preserve_default = preserve_default super().__init__(model_name, name, field) [f134af85bfed7692-2]
- def __init__(self, model_name, old_name, new_name): self.old_name = old_name self.new_name = new_name super().__init__(model_name, old_name) [8b43e683]
- def database_backwards(self, app_label, schema_editor, from_state, to_state): from_model = from_state.apps.get_model(app_label, self.model_name) if self.allow_migrate_model(schema_editor.connection.alias, from_model): schema_editor.remove_field( from_model, from_model._meta.get_field(self.name) ) [44268099]
- def database_backwards(self, app_label, schema_editor, from_state, to_state): self.database_forwards(app_label, schema_editor, from_state, to_state) [368aca2b5c2714ef]
- def database_backwards(self, app_label, schema_editor, from_state, to_state): to_model = to_state.apps.get_model(app_label, self.model_name) if self.allow_migrate_model(schema_editor.connection.alias, to_model): from_model = from_state.apps.get_model(app_label, self.model_name) schema_editor.add_field(from_model, to_model._meta.get_field(self.name)) [dc6c4e23]
- def database_backwards(self, app_label, schema_editor, from_state, to_state): to_model = to_state.apps.get_model(app_label, self.model_name) if self.allow_migrate_model(schema_editor.connection.alias, to_model): from_model = from_state.apps.get_model(app_label, self.model_name) schema_editor.alter_field( from_model, from_model._meta.get_field(self.new_name), to_model._meta.get_field(self.old_name), ) [fe499ab4]

## All facts

- [06af1c7b] def database_forwards(self, app_label, schema_editor, from_state, to_state): from_model = from_state.apps.get_model(app_label, self.model_name) if self.allow_migrate_model(schema_editor.connection.alias, from_model): schema_editor.remove_field( from_model, from_model._meta.get_field(self.name) )
- [0793a86f] def database_forwards(self, app_label, schema_editor, from_state, to_state): to_model = to_state.apps.get_model(app_label, self.model_name) if self.allow_migrate_model(schema_editor.connection.alias, to_model): from_model = from_state.apps.get_model(app_label, self.model_name) field = to_model._meta.get_field(self.name) if not self.preserve_default: field.default = self.field.default schema_editor.add_field( from_model, field, ) if not self.preserve_default: field.default = NOT_PROVIDED
- [476d56a1] def database_forwards(self, app_label, schema_editor, from_state, to_state): to_model = to_state.apps.get_model(app_label, self.model_name) if self.allow_migrate_model(schema_editor.connection.alias, to_model): from_model = from_state.apps.get_model(app_label, self.model_name) from_field = from_model._meta.get_field(self.name) to_field = to_model._meta.get_field(self.name) if not self.preserve_default: to_field.default = self.field.default schema_editor.alter_field(from_model, from_field, to_field) if not self.preserve_default: to_field.default = NOT_PROVIDED
- [8ba98a62] def database_forwards(self, app_label, schema_editor, from_state, to_state): to_model = to_state.apps.get_model(app_label, self.model_name) if self.allow_migrate_model(schema_editor.connection.alias, to_model): from_model = from_state.apps.get_model(app_label, self.model_name) schema_editor.alter_field( from_model, from_model._meta.get_field(self.old_name), to_model._meta.get_field(self.new_name), )
- [f3b5d9f33995b868] def deconstruct(self): kwargs = { "model_name": self.model_name, "name": self.name, "field": self.field, } if self.preserve_default is not True: kwargs["preserve_default"] = self.preserve_default return (self.__class__.__name__, [], kwargs)
- [f3b5d9f33995b868-2] def deconstruct(self): kwargs = { "model_name": self.model_name, "name": self.name, "field": self.field, } if self.preserve_default is not True: kwargs["preserve_default"] = self.preserve_default return (self.__class__.__name__, [], kwargs)
- [d69b5d7b] def deconstruct(self): kwargs = { "model_name": self.model_name, "name": self.name, } return (self.__class__.__name__, [], kwargs)
- [fe2f81cb] def deconstruct(self): kwargs = { "model_name": self.model_name, "old_name": self.old_name, "new_name": self.new_name, } return (self.__class__.__name__, [], kwargs)
- [1eb168f3] def describe(self): return "Add field %s to %s" % (self.name, self.model_name)
- [dd93653f] def describe(self): return "Alter field %s on %s" % (self.name, self.model_name)
- [7f38c21a] def describe(self): return "Remove field %s from %s" % (self.name, self.model_name)
- [d8e67eb8] def describe(self): return "Rename field %s on %s to %s" % ( self.old_name, self.model_name, self.new_name, )
- [33dd2062] def is_same_field_operation(self, operation): return ( self.is_same_model_operation(operation) and self.name_lower == operation.name_lower )
- [b6f3f167] def is_same_model_operation(self, operation): return self.model_name_lower == operation.model_name_lower
- [a60fb6a7] def reduce(self, operation, app_label): from .models import DeleteModel
- [0cce256d] def reduce(self, operation, app_label): if ( isinstance(operation, RenameField) and self.is_same_model_operation(operation) and self.new_name_lower == operation.old_name_lower ): return [replace(self, new_name=operation.new_name)] # Skip `FieldOperation.reduce` as we want to run `references_field` # against self.old_name and self.new_name. return super(FieldOperation, self).reduce(operation, app_label) or not ( operation.references_field(self.model_name, self.old_name, app_label) or operation.references_field(self.model_name, self.new_name, app_label) )
- [67343f4a] def reduce(self, operation, app_label): if isinstance( operation, (AlterField, RemoveField) ) and self.is_same_field_operation(operation): return [operation] elif ( isinstance(operation, RenameField) and self.is_same_field_operation(operation) and self.field.db_column is None ): return [ operation, replace(self, name=operation.new_name), ] return super().reduce(operation, app_label)
- [3f2708b4] def reduce(self, operation, app_label): if isinstance(operation, FieldOperation) and self.is_same_field_operation( operation ): if isinstance(operation, AlterField): return [ replace( self, name=operation.name, field=operation.field, ), ] elif isinstance(operation, RemoveField): return [] elif isinstance(operation, RenameField): return [replace(self, name=operation.new_name)] return super().reduce(operation, app_label)
- [2c08b38f] def reduce(self, operation, app_label): return super().reduce(operation, app_label) or not operation.references_field( self.model_name, self.name, app_label )
- [280865f9] def references_field(self, model_name, name, app_label): model_name_lower = model_name.lower() # Check if this operation locally references the field. if model_name_lower == self.model_name_lower: if name == self.name: return True if self.field: if ( hasattr(self.field, "from_fields") and name in self.field.from_fields ): return True elif self.field.generated and any( field_name == name for field_name, *_ in Model._get_expr_references( self.field.expression ) ): return True # Check if this operation remotely references the field. if self.field is None: return False return bool( field_references( (app_label, self.model_name_lower), self.field, (app_label, model_name_lower), name, ) )
- [a65d8ac4] def references_field(self, model_name, name, app_label): return self.references_model(model_name, app_label) and ( name.lower() == self.old_name_lower or name.lower() == self.new_name_lower )
- [2c0f3173] def references_model(self, name, app_label): name_lower = name.lower() if name_lower == self.model_name_lower: return True if self.field: return bool( field_references( (app_label, self.model_name_lower), self.field, (app_label, name_lower), ) ) return False
- [1132cd99] def state_forwards(self, app_label, state): state.add_field( app_label, self.model_name_lower, self.name, self.field, self.preserve_default, )
- [3b5b46f3] def state_forwards(self, app_label, state): state.alter_field( app_label, self.model_name_lower, self.name, self.field, self.preserve_default, )
- [debc275d] def state_forwards(self, app_label, state): state.remove_field(app_label, self.model_name_lower, self.name)
- [c4dbc519] def state_forwards(self, app_label, state): state.rename_field( app_label, self.model_name_lower, self.old_name, self.new_name )
- [f1df1dce] class AddField(FieldOperation): """Add a field to a model."""
- [e3422979] class AlterField(FieldOperation): """ Alter a field's database column (e.g. null, max_length) to the provided new field. """
- [216999e4] class FieldOperation(Operation): def __init__(self, model_name, name, field=None): self.model_name = model_name self.name = name self.field = field
- [8d72cff7] class RemoveField(FieldOperation): """Remove a field from a model."""
- [70cfaa45] class RenameField(FieldOperation): """Rename a field on the model. Might affect db_column too."""
- [3aab3890e152ab07] from .base import Operation, OperationCategory
- [a267abb6] from django.db.migrations.utils import field_references from django.db.models import NOT_PROVIDED, Model from django.utils.copy import replace from django.utils.functional import cached_property
