# django/core/serializers/__init__

- Subject: django/core/serializers/__init__ (id `f649d6e5-731a-4302-a8d6-d419059fd3be`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 11 of 38
- Conflicts: 0
- Gaps: 0

## Facts

- # If all of the models in the dependency list are either already # on the final model list, or not on the original serialization # list, then we've found another model with all it's dependencies # satisfied. if all(d not in models or d in model_list for d in deps): model_list.append(model) changed = True else: skipped.append((model, deps)) if not changed: if allow_cycles: # If cycles are allowed, add the last skipped model and ignore # its dependencies. This could be improved by some graph # analysis to ignore as few dependencies as possible. model, _ = skipped.pop() model_list.append(model) else: raise RuntimeError( "Can't resolve dependencies for %s in serialized app list." % ", ".join( model._meta.label for model, deps in sorted( skipped, key=lambda obj: obj[0].__name__ ) ), ) model_dependencies = skipped [01f68307]
- # Now add a dependency for any FK relation with a model that # defines a natural key for field in model._meta.fields: if field.remote_field: rel_model = field.remote_field.model if hasattr(rel_model, "natural_key") and rel_model != model: deps.append(rel_model) # Also add a dependency for any simple M2M relation with a model # that defines a natural key. M2M relations with explicit through # models don't count as dependencies. for field in model._meta.many_to_many: if field.remote_field.through._meta.auto_created: rel_model = field.remote_field.model if hasattr(rel_model, "natural_key") and rel_model != model: deps.append(rel_model) model_dependencies.append((model, deps)) [9991a095]
- for model in model_list: models.add(model) # Add any explicitly defined dependencies if hasattr(model, "natural_key"): deps = getattr(model.natural_key, "dependencies", []) if deps: deps = [apps.get_model(dep) for dep in deps] else: deps = [] [66f13ba4]
- module = type( "BadSerializerModule", (), { "Deserializer": bad_serializer, "Serializer": bad_serializer, }, ) [40407009]
- If ``serializers`` is not provided, the registration will be made directly into the global register of serializers. Adding serializers directly is not a thread-safe operation. """ if serializers is None and not _serializers: _load_serializers() [066a9b40]
- If ``serializers`` is provided, the registration will be added to the provided dictionary. [f22c9f31]
- If allow_cycles is True, return the best-effort ordering that will respect most of dependencies but ignore some of them to break the cycles. """ # Process the list of models, and get the list of dependencies model_dependencies = [] models = set() for app_config, model_list in app_list: if model_list is None: model_list = app_config.get_models() [67a09685]
- SERIALIZATION_MODULES = { "csv": "path.to.csv.serializer", "txt": "path.to.txt.serializer", } [3cc879c6]
- The single list of models is sorted so that any model with a natural key is serialized before a normal model, and any model with a natural key dependency has it's dependencies serialized first. [359f0aa3]
- This allows the serializer registration to cache serializers and if there is an error raised in the process of creating a serializer it will be raised and passed along to the caller when the serializer is used. """ [e30d749a]
- ``serializer_module`` should be the fully qualified module name for the serializer. [f35d21c3]

## Beyond the budget

27 more facts did not fit in the budget: [ea807245] [b6ad573e] [d0949e3d] [45289836] [8a17a1b3f025bc34] [6afc52c6] [239b3a77] [c307fa12] [d346d78f8c109f45-2] [6fd4bb8c] [e5611047] [7364ef02] [a898892ae0cdf6fe-3] [5a955ee7] [59a9970d] [16f95dd6] [a23fa2c7] [6442d322] [495ef977] [31784cb7] [094d7286] [8921a304] [288ad434] [b7c7f751] [27199a1b] [f54234d8] [ae7ba571]
