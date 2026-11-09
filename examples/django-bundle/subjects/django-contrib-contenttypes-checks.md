# django/contrib/contenttypes/checks

- Subject: django/contrib/contenttypes/checks (id `8d38c001-8d7d-45bc-ad8e-80de7a9b60e3`)
- Kind: subject
- Budget: 1200 tokens
- Used: 300 tokens
- Facts shown: 5 of 5
- Conflicts: 0
- Gaps: 0

## Facts

- if app_configs is None: models = apps.get_models() else: models = chain.from_iterable( app_config.get_models() for app_config in app_configs ) errors = [] descriptors = ( obj for model in models for obj in vars(model).values() if isinstance(obj, GenericForeignKeyDescriptor) ) for descriptor in descriptors: errors.extend(descriptor.field.check()) return errors [15c210d3]
- def check_generic_foreign_keys(app_configs, **kwargs): from .fields import GenericForeignKeyDescriptor [bf200c7e]
- def check_model_name_lengths(app_configs, **kwargs): if app_configs is None: models = apps.get_models() else: models = chain.from_iterable( app_config.get_models() for app_config in app_configs ) errors = [] for model in models: if len(model._meta.model_name) > 100: errors.append( Error( "Model names must be at most 100 characters (got %d)." % (len(model._meta.model_name),), obj=model, id="contenttypes.E005", ) ) return errors [1e203872]
- from django.apps import apps from django.core.checks import Error [1b32819d]
- from itertools import chain [a79448688635df7c-2]
