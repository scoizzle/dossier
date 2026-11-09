# django/db/migrations/operations/models

- Subject: django/db/migrations/operations/models (id `4d1d8792-ddc7-4ed0-9c7a-ea515a8befd4`)
- Kind: subject
- Budget: 1200 tokens
- Used: 894 tokens
- Facts shown: 16 of 172
- Conflicts: 0
- Gaps: 0

## Facts

- # Check we didn't inherit from the model reference_model_tuple = (app_label, name_lower) for base in self.bases: if ( base is not models.Model and isinstance(base, (models.base.ModelBase, str)) and resolve_relation(base, app_label) == reference_model_tuple ): return True [36e44ac2]
- # Check we have no FKs/M2Ms with it for _name, field in self.fields: if field_references( (app_label, self.name_lower), field, reference_model_tuple ): return True return False [6633f9f4]
- if self.old_fields: from_model = from_state.apps.get_model(app_label, self.model_name) columns = [ from_model._meta.get_field(field).column for field in self.old_fields ] matching_index_name = schema_editor._constraint_names( from_model, column_names=columns, index=True, unique=False, ) if len(matching_index_name) != 1: raise ValueError( "Found wrong number (%s) of indexes for %s(%s)." % ( len(matching_index_name), from_model._meta.db_table, ", ".join(columns), ) ) old_index = models.Index( fields=self.old_fields, name=matching_index_name[0], ) else: from_model_state = from_state.models[app_label, self.model_name_lower] old_index = from_model_state.get_index_by_name(self.old_name) # Don't alter when the index name is not changed. if old_index.name == self.new_name: return [ddc2afde]
- self.database_forwards(app_label, schema_editor, from_state, to_state) [d1bba3a9cecba686]
- self.new_name_lower, self.old_name_lower = ( self.old_name_lower, self.new_name_lower, ) self.new_name, self.old_name = self.old_name, self.new_name [342de65a7363da42]
- to_model_state = to_state.models[app_label, self.model_name_lower] new_index = to_model_state.get_index_by_name(self.new_name) schema_editor.rename_index(model, old_index, new_index) [3e2ecf27]
- # Model options we want to compare and preserve in an AlterModelOptions op ALTER_OPTION_KEYS = [ "base_manager_name", "default_manager_name", "default_related_name", "get_latest_by", "managed", "ordering", "permissions", "default_permissions", "select_on_save", "verbose_name", "verbose_name_plural", ] [20885491]
- @cached_property def model_name_lower(self): return self.model_name.lower() [0eadb4a7d232abbe-3]
- @cached_property def new_name_lower(self): return self.new_name.lower() [10501aecba252e62-2]
- @cached_property def old_name_lower(self): return self.old_name.lower() [1dc011641d755971-2]
- @cached_property def option_value(self): return getattr(self, self.option_name) [354cc95f]
- @property def migration_name_fragment(self): if self.old_name: return "rename_%s_%s" % (self.old_name_lower, self.new_name_lower) return "rename_%s_%s_%s" % ( self.model_name_lower, "_".join(self.old_fields), self.new_name_lower, ) [e3765039]
- @property def migration_name_fragment(self): return "%s_%s" % (self.model_name_lower, self.constraint.name.lower()) [b6272f0a]
- @property def migration_name_fragment(self): return "%s_%s" % (self.model_name_lower, self.index.name.lower()) [84778fc1]
- @property def migration_name_fragment(self): return "alter_%s_%s" % (self.name_lower, self.option_name) [83ca31f0]
- @property def migration_name_fragment(self): return "alter_%s_managers" % self.name_lower [6112150e]

## Beyond the budget

122 more facts did not fit in the budget: [afa78075] [e5db6da7] [2c25aeab] [eb491307] [f95194bc0ebcb48e] [9bc6f6e7] [30c5d63f] [5a33afdc] [ac9c8334b988dfa0-4] [40a0d51c] [581948d1f9b584af-4] [581948d1f9b584af-5] [7d1ad44cd1b46380-3] [7d1ad44cd1b46380-4] [ac7864cb] [4e9b77c5] [d314c5ef4f2e7b9b-2] [743d01d3] [fff4f709] [7532b870] [9da0661e] [3ea3fb6b] [948137e4] [5f20e0e5] [20be77ea] [16030403] [452c0e26] [6f2e7039] [58b9034c] [e511dc9f] [10f5df25] [d1eb42bf] [132177f29b518d35] [14e2fd26d6736c88] [900f106a] [782f048d] [2d51a74b] [f499f927] [436e0125] [ff71a36e] [7f7e8c04] [2eff5f66] [b02508a3cefe6ce8] [1efc6bd2] [77bf1d24] [78da171d] [57928487] [be3b1a33] [4d21da37] [678be040] [0e3b14af] [6f440ffc] [2d9bcaec] [60809c47] [526e897d] [83da1e95] [b94efa29] [8b898b1d] [a3f683c8] [bf5ae8c2] [89d1390a] [ef72fd81] [2261acd8] [2b9b8b2f] [f87b1f35] [491dc291] [6030ca30] [de0b2fe6] [b5acc333] [745f8102] [a7fa8455] [be0ca11a] [7e813f0d] [c0ea8fab] [364fec58] [7524deb4] [ac6a7f8b] [715c5507] [b7f81db3] [0e14ad6b] [e2fa9fbc] [ee78e132] [8b021dd4] [381a2056] [029ded09] [4c9f4751] [b7f2b6d4] [eae19f94] [82a0f3f4] [dd9bfc9e] [3b694420] [f8fd0fe3] [a7b59579] [d5668f02] [ae71fdcd] [0f693b1e] [61424b3c] [8a0a494b] [3ffd126c] [20851220] [887436d6] [17ff0cb6] [7af95e3e] [bff7652b] [5b83628c] [48b79972] [02c2995b] [8087be11] [9375452a] [a2556926] [d3dbcf06] [9d40181d] [b4143ecf] [ce6e6b7c] [210fbbc5] [337b481a] [dca1a9be] [580467e9] [69197b93] [13bd30d3] [c58c2301] [7c8574af]
