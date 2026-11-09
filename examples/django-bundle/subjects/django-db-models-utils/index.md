# django/db/models/utils

- Subject: django/db/models/utils (id `ae66ca6a-f101-4a07-a652-ade52a93b3cb`)
- Kind: subject
- Budget: 1200 tokens
- Used: 660 tokens
- Facts shown: 12 of 12
- Conflicts: 0
- Gaps: 0

## Facts

- super().__init_subclass__(**kwargs) [30efc147]
- def __init_subclass__(cls, **kwargs): for fn_name, fn in vars(cls).items(): if callable(fn) and not hasattr(fn, "alters_data"): for base in cls.__bases__: if base_fn := getattr(base, fn_name, None): if hasattr(base_fn, "alters_data"): fn.alters_data = base_fn.alters_data break [14bd2cd8]
- from .fields import BLANK_CHOICE_DASH, BLANK_CHOICE_LABEL [6824600c]
- if settings.USE_BLANK_CHOICE_DASH: return BLANK_CHOICE_DASH[0][1] return BLANK_CHOICE_LABEL [ce089d1b]
- return type( "Row", (namedtuple("Row", names),), {"__reduce__": __reduce__, "__slots__": ()}, ) [b8cd84e4]
- # RemovedInDjango2028Warning: At the end of the deprecation, remove this # function and use .fields.BLANK_CHOICE_LABEL directly instead. def get_blank_choice_label(): from django.conf import settings [141e4ed4]
- @functools.lru_cache def create_namedtuple_class(*names): # Cache type() with @lru_cache since it's too slow to be called for every # QuerySet evaluation. def __reduce__(self): return unpickle_named_row, (names, tuple(self)) [17089993]
- class AltersData: """ Make subclasses preserve the alters_data attribute on overridden methods. """ [7378ad6a]
- def make_model_tuple(model): """ Take a model or a string of the form "app_label.ModelName" and return a corresponding ("app_label", "modelname") tuple. If a tuple is passed in, assume it's a valid model tuple already and return it unchanged. """ try: if isinstance(model, tuple): model_tuple = model elif isinstance(model, str): app_label, model_name = model.split(".") model_tuple = app_label, model_name.lower() else: model_tuple = model._meta.app_label, model._meta.model_name assert len(model_tuple) == 2 return model_tuple except (ValueError, AssertionError): raise ValueError( "Invalid model reference '%s'. String model references " "must be of the form 'app_label.ModelName'." % model ) [69587328]
- def resolve_callables(mapping): """ Generate key/value pairs for the given mapping where the values are evaluated if they're callable. """ for k, v in mapping.items(): yield k, v() if callable(v) else v [e5b59f8a]
- def unpickle_named_row(names, values): return create_namedtuple_class(*names)(*values) [06aa5b76]
- import functools from collections import namedtuple [f6c76912]
