# django/db/migrations/state

- Subject: django/db/migrations/state (id `4df46cda-9199-43ec-81e9-5ededb528645`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 15 of 98
- Conflicts: 0
- Gaps: 0

## Facts

- # 2. All related models of migrated apps for rel_app_label, rel_model_name in related_models: try: model_state = self.models[rel_app_label, rel_model_name] except KeyError: pass else: states_to_be_rendered.append(model_state) [dd2907b6]
- # Construct the new ModelState return cls( model._meta.app_label, model._meta.object_name, fields, options, bases, managers, ) [dd156ecc]
- # For all direct related models recursively get all related models. related_models.update(direct_related_models) for rel_app_label, rel_model_name in direct_related_models: try: rel_model = self.apps.get_model(rel_app_label, rel_model_name) except LookupError: pass else: if delay: related_models.update(get_related_models_tuples(rel_model)) else: related_models.update(get_related_models_recursive(rel_model)) [d40694fd]
- # Get all outgoing references from the model to be rendered model_state = self.models[(app_label, model_name)] # Directly related models are the models pointed to by ForeignKeys, # OneToOneFields, and ManyToManyFields. direct_related_models = set() for field in model_state.fields.values(): if field.is_relation: if field.remote_field.model == RECURSIVE_RELATIONSHIP_CONSTANT: continue rel_app_label, rel_model_name = _get_app_label_and_model_name( field.related_model, app_label ) direct_related_models.add((rel_app_label, rel_model_name.lower())) [99cea93c]
- # Ignore a shimmed default manager called objects if it's the only one. if managers == [("objects", default_manager_shim)]: managers = [] [ae35038a]
- # Include the model itself related_models.add((app_label, model_name)) [bd27cb53]
- # Make our record bases = tuple( (base._meta.label_lower if hasattr(base, "_meta") else base) for base in flattened_bases ) # Ensure at least one base inherits from models.Model if not any( (isinstance(base, str) or issubclass(base, models.Model)) for base in bases ): bases = (models.Model,) [a3f4cfae]
- # No need to actually clone them, they'll never change clone.real_models = self.real_models return clone [ed1ad14d]
- # Render all models self.apps.render_multiple(states_to_be_rendered) [0d682d63]
- # Restore managers body.update(self.construct_managers()) # Then, make a Model object (apps.register_model is called in __new__) return type(self.name, bases, body) [ac9cc273]
- # There shouldn't be any operations pending at this point. from django.core.checks.model_checks import _check_lazy_references [376eceae]
- # These locks get in the way of copying as implemented in clone(), # which is called whenever Django duplicates a StateApps before # updating it. self._lock = None self.ready_event = None [bf209253]
- # We can't rely on __mro__ directly because we only want to flatten # abstract models and not the whole tree. However by recursing on # __bases__ we may end up with duplicates and ordering issues, we # therefore discard any duplicates and reorder the bases according # to their index in the MRO. flattened_bases = sorted( set(flatten_bases(model)), key=lambda x: model.__mro__.index(x) ) [a3e293e6]
- for model_key in concretes: self.resolve_model_relations(model_key, concretes) [d5ff799a]
- related_models = set() [7b1b7713]

## Beyond the budget

83 more facts did not fit in the budget: [bfc2a3d9] [283e8c52] [d22e23ff] [4398ce75] [d8986e1e] [47bf3a8b] [262302e6] [3b2ad22c] [59bea3a4] [ce56be1c] [b5bf1d8a] [a5def5b8] [3ebe8472] [374e30df] [22aaa031] [0eeb44ca74e0840e-3] [c1835afb] [f2ef421c] [8c3b177e] [ca0c60a8] [86719184] [666c68c0] [67dcbfc6] [205669d6] [b6680b4a] [779a4b99] [f46d989f] [dcc046a2] [86307ad4] [d078a42b] [ee320c29] [8f41c9b8] [54e2ec0c] [8c8188f9] [507b5d40] [7448e2de] [a927dc8b] [db45c649] [c4d73383] [172af484] [ab03bb80] [e22a3da0] [66e9390a] [ffd15951] [0886eb00] [37faf216] [6bb4c147] [dc612561] [fa96a4ae] [28b5e04b] [cfe12e3a] [4f599c41] [ea93abb2] [ac9f3372] [b8c0be90] [1b85066d] [f502c64b] [ecb4712a] [266faf1a] [b5ab62a0] [274b35b8] [c50baa41] [69a36cd0] [9581f456] [293b8893] [adce7057] [d3b07597] [bf8b3d94] [1c1724b8] [9192992c] [33082b49] [e8a4ab71] [e1a8d0d6] [8d4be605] [9833cd90] [d944143e] [cb1997ac] [2e7ef620] [484c3e2f] [c3920cc1] [6b7ca3b7] [35cb2b12] [5904a7b0]
