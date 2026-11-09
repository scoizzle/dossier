# django/db/migrations/autodetector

- Subject: django/db/migrations/autodetector (id `2d1ddc20-7863-432d-ad09-45543a3789c8`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 8 of 97
- Conflicts: 0
- Gaps: 0

## Facts

- if len(renamed_index_together_indexes) == 1: renamed_index = renamed_index_together_indexes[0] remove_from_added.append(renamed_index) renamed_indexes.append( (None, renamed_index.name, removed_index_together) ) self.renamed_index_together_values[ index_together_app_label, index_together_model_name ].append(removed_index_together) # Remove renamed indexes from the lists of added and removed # indexes. added_indexes = [ idx for idx in added_indexes if idx not in remove_from_added ] removed_indexes = [ idx for idx in removed_indexes if idx not in remove_from_removed ] [a1a7b604]
- # Are there indexes/unique_together to defer? indexes = model_state.options.pop("indexes") constraints = model_state.options.pop("constraints") unique_together = model_state.options.pop("unique_together", None) order_with_respect_to = model_state.options.pop( "order_with_respect_to", None ) # Depend on the deletion of any possible proxy version of us dependencies = [ OperationDependency( app_label, model_name, None, OperationDependency.Type.REMOVE ), ] # Depend on all bases for base in model_state.bases: if isinstance(base, str) and "." in base: base_app_label, base_name = base.split(".", 1) dependencies.append( OperationDependency( base_app_label, base_name, None, OperationDependency.Type.CREATE, ) ) # Depend on the removal of base fields if the new model has # a field with the same name. old_base_model_state = self.from_state.models.get( (base_app_label, base_name) ) new_base_model_state = self.to_state.models.get( (base_app_label, base_name) ) if old_base_model_state and new_base_model_state: removed_base_fields = ( set(old_base_model_state.fields) .difference( new_base_model_state.fields, ) .intersection(model_state.fields) ) for removed_base_field in removed_base_fields: dependencies.append( OperationDependency( base_app_label, base_name, removed_base_field, OperationDependency.Type.REMOVE, ) ) # Depend on the other end of the primary key if it's a relation if primary_key_rel: dependencies.append( OperationDependency( *resolve_relation(primary_key_rel, app_label, model_name), None, OperationDependency.Type.CREATE, ), ) # Generate creation operation self.add_operation( app_label, operations.CreateModel( name=model_state.name, fields=[ d for d in model_state.fields.items() if d[0] not in related_fields ], options=model_state.options, bases=model_state.bases, managers=model_state.managers, ), dependencies=dependencies, beginning=True, ) [8c252ca3]
- # Don't add operations which modify the database for unmanaged # models if not model_state.options.get("managed", True): continue [8f4b67a4]
- # We run the old version through the field renames to account for # those old_value = old_model_state.options.get(option_name) old_value = ( { tuple( self.renamed_fields.get((app_label, model_name, n), n) for n in unique ) for unique in old_value } if old_value else set() ) [c4a7694a]
- add_constraints = [ c for c in new_constraints if c not in old_constraints and c.name not in alt_constraints_name ] rem_constraints = [ c for c in old_constraints if c not in new_constraints and c.name not in alt_constraints_name ] [6178d696]
- alt_constraints = [] alt_constraints_name = [] [a52886f1]
- new_value = new_model_state.options.get(option_name) new_value = set(new_value) if new_value else set() [2bd282e1]
- return self.migrations [869fef53]

## Beyond the budget

87 more facts did not fit in the budget: [08787268] [53d77da7] [b703b4f5] [1513ecea] [f395bac6] [0e039981] [d22e0a4b] [ca1ed279] [7bc30b64] [e90e085d] [0a97e147] [9a7c75ce] [e4b4aebc] [779d7482] [8574a87b] [a3a5af96] [31eca866] [359d87e6] [3b586d80] [4ce6ab22] [86fa2092] [0b3c2b93] [0afdf827] [201c4f01] [4897b5d6] [59039675] [ae13589a] [942320d8] [4ebb53af] [b2d8d343] [67872559] [0eadb4a7d232abbe] [028de19a] [42ea91b0] [cbee8fe2] [03a3761a] [84ed6b80] [118e646d] [d88344c4] [ca12ff7a] [306058df] [4f137a73] [06507f6c] [1e228742] [4724409f] [c8778dfd] [c95ffa12] [c3a3db7f] [a9e86b3b] [e77f24b9] [3bf0c8a3] [a7807b58] [c7abc2d8] [8b6d3717] [030edf89] [39062070] [3623fc77] [23dc03bd] [d9a2a35c] [167a8671] [566615c8] [68ade956] [f982d0fe] [14cb0f6c] [1459aa62] [0ee96a1c] [1e2115d0] [5e9c7df0] [6abb2aef] [fe668f98] [b51042d0] [442f5aa7] [7ccacecc] [fc815e44] [3c3ef95c] [7646f55f] [61ca1a56] [2562441a] [cb4e8930] [da4e0da2] [39e4c0f5] [06dff3b2] [21304bb3] [8c810b46] [d1c8408f] [8c6fce20] [5c9653b3]
