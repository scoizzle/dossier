# django/core/checks/model_checks

- Subject: django/core/checks/model_checks (id `9935b81c-4dcc-4bf6-9a0c-bbee9f8880b7`)
- Kind: subject
- Budget: 1200 tokens
- Used: 867 tokens
- Facts shown: 12 of 20
- Conflicts: 0
- Gaps: 0

## Facts

- obj is a callback defined locally in Apps.lazy_model_operation() and annotated there with a `func` attribute so as to imitate a partial. """ operation, args, keywords = obj, [], {} while hasattr(operation, "func"): args.extend(getattr(operation, "args", [])) keywords.update(getattr(operation, "keywords", {})) operation = operation.func return operation, args, keywords [50e7dc71]
- # Here are several functions which return CheckMessage instances for the # most common usages of lazy operations throughout Django. These functions # take the model that was being waited on as an (app_label, modelname) # pair, the original lazy function, and its positional and keyword args as # determined by extract_operation(). [ee75ca62]
- # Maps common uses of lazy operations to corresponding error functions # defined above. If a key maps to None, no error will be produced. # default_error() will be used for usages that don't appear in this dict. known_lazy = { ("django.db.models.fields.related", "resolve_related_class"): field_error, ("django.db.models.fields.related", "set_managed"): None, ("django.dispatch.dispatcher", "connect"): signal_connect_error, } [ae3d504c]
- # Short circuit if there aren't any errors. if not pending_models: return [] [318fb689]
- Lazy references are used in various places throughout Django, primarily in related fields and model signals. Identify those common cases and provide more helpful error messages for them. [c73cb139]
- The ignore parameter is used by StateApps to exclude swappable models from this check. """ pending_models = set(apps._pending_operations) - (ignore or set()) [d4fc0b3e]
- def app_model_error(model_key): try: apps.get_app_config(model_key[0]) model_error = "app '%s' doesn't provide model '%s'" % model_key except LookupError: model_error = "app '%s' isn't installed" % model_key[0] return model_error [103d0d9a]
- def build_error(model_key, func, args, keywords): key = (func.__module__, func.__name__) error_fn = known_lazy.get(key, default_error) return error_fn(model_key, func, args, keywords) if error_fn else None [64a759ed]
- def default_error(model_key, func, args, keywords): error_msg = ( "%(op)s contains a lazy reference to %(model)s, but %(model_error)s." ) params = { "op": func, "model": ".".join(model_key), "model_error": app_model_error(model_key), } return Error(error_msg % params, obj=func, id="models.E022") [513363e2]
- def extract_operation(obj): """ Take a callable found in Apps._pending_operations and identify the original callable passed to Apps.lazy_model_operation(). If that callable was a partial, return the inner, non-partial function and any arguments and keyword arguments that were supplied with it. [a291199f]
- def field_error(model_key, func, args, keywords): error_msg = ( "The field %(field)s was declared with a lazy reference " "to '%(model)s', but %(model_error)s." ) params = { "model": ".".join(model_key), "field": keywords["field"], "model_error": app_model_error(model_key), } return Error(error_msg % params, obj=keywords["field"], id="fields.E307") [00b8f256]
- from django.db.models import signals [519eeb0d]

## Beyond the budget

8 more facts did not fit in the budget: [36393e54] [89ec7463] [e66dda93] [cb8a42fd] [ee83762c] [70c2832b] [aa0aa68a] [8b3fdbcc]
