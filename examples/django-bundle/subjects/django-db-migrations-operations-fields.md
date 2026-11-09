# django/db/migrations/operations/fields

- Subject: django/db/migrations/operations/fields (id `f66c239a-fc6e-4ecf-a7ab-dc4e8ba27cac`)
- Kind: subject
- Budget: 1200 tokens
- Used: 889 tokens
- Facts shown: 18 of 53
- Conflicts: 0
- Gaps: 0

## Facts

- if ( isinstance(operation, DeleteModel) and operation.name_lower == self.model_name_lower ): return [operation] return super().reduce(operation, app_label) [19f4917c]
- @cached_property def model_name_lower(self): return self.model_name.lower() [0eadb4a7d232abbe-2]
- @cached_property def new_name_lower(self): return self.new_name.lower() [10501aecba252e62]
- @cached_property def old_name_lower(self): return self.old_name.lower() [1dc011641d755971]
- @property def migration_name_fragment(self): return "%s_%s" % (self.model_name_lower, self.name_lower) [19031635]
- @property def migration_name_fragment(self): return "rename_%s_%s_%s" % ( self.old_name_lower, self.model_name_lower, self.new_name_lower, ) [8d0da294]
- category = OperationCategory.ADDITION [ac9c8334b988dfa0-3]
- category = OperationCategory.ALTERATION [581948d1f9b584af-2]
- category = OperationCategory.ALTERATION [581948d1f9b584af-3]
- category = OperationCategory.REMOVAL [7d1ad44cd1b46380-2]
- def __init__(self, model_name, name, field, preserve_default=True): self.preserve_default = preserve_default super().__init__(model_name, name, field) [f134af85bfed7692]
- def __init__(self, model_name, old_name, new_name): self.old_name = old_name self.new_name = new_name super().__init__(model_name, old_name) [8b43e683]
- def database_backwards(self, app_label, schema_editor, from_state, to_state): from_model = from_state.apps.get_model(app_label, self.model_name) if self.allow_migrate_model(schema_editor.connection.alias, from_model): schema_editor.remove_field( from_model, from_model._meta.get_field(self.name) ) [44268099]
- def database_backwards(self, app_label, schema_editor, from_state, to_state): self.database_forwards(app_label, schema_editor, from_state, to_state) [368aca2b5c2714ef]
- def database_backwards(self, app_label, schema_editor, from_state, to_state): to_model = to_state.apps.get_model(app_label, self.model_name) if self.allow_migrate_model(schema_editor.connection.alias, to_model): from_model = from_state.apps.get_model(app_label, self.model_name) schema_editor.alter_field( from_model, from_model._meta.get_field(self.new_name), to_model._meta.get_field(self.old_name), ) [fe499ab4]
- def database_forwards(self, app_label, schema_editor, from_state, to_state): to_model = to_state.apps.get_model(app_label, self.model_name) if self.allow_migrate_model(schema_editor.connection.alias, to_model): from_model = from_state.apps.get_model(app_label, self.model_name) field = to_model._meta.get_field(self.name) if not self.preserve_default: field.default = self.field.default schema_editor.add_field( from_model, field, ) if not self.preserve_default: field.default = NOT_PROVIDED [0793a86f]
- def deconstruct(self): kwargs = { "model_name": self.model_name, "name": self.name, "field": self.field, } if self.preserve_default is not True: kwargs["preserve_default"] = self.preserve_default return (self.__class__.__name__, [], kwargs) [f3b5d9f33995b868]
- def deconstruct(self): kwargs = { "model_name": self.model_name, "name": self.name, } return (self.__class__.__name__, [], kwargs) [d69b5d7b]

## Beyond the budget

25 more facts did not fit in the budget: [fe2f81cb] [1eb168f3] [dd93653f] [7f38c21a] [d8e67eb8] [33dd2062] [b6f3f167] [a60fb6a7] [0cce256d] [67343f4a] [3f2708b4] [2c08b38f] [280865f9] [a65d8ac4] [2c0f3173] [1132cd99] [debc275d] [c4dbc519] [f1df1dce] [e3422979] [216999e4] [8d72cff7] [70cfaa45] [3aab3890e152ab07] [a267abb6]
