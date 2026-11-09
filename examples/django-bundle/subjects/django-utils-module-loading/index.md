# django/utils/module_loading

- Subject: django/utils/module_loading (id `f1788793-667e-4a5d-96f2-cd85df881eb4`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 930 tokens
- Facts shown: 13 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- # Decide whether to bubble up this error. If the app just # doesn't have the module in question, we can ignore the error # attempting to import it, otherwise we want it to bubble up. if module_has_submodule(app_config.module, module_to_search): raise [5474b1ac]
- import_module("%s.%s" % (app_config.name, module_to_search)) except Exception: # Reset the registry to the state before the last import # as this import will have to reoccur on the next request and # this could raise NotRegistered and AlreadyRegistered # exceptions (see #8245). if register_to: register_to._registry = before_import_registry [c414e1f7]
- Raise ValueError otherwise, e.g. for namespace packages that are split over several directories. """ # Convert to list because __path__ may not support indexing. paths = list(getattr(module, "__path__", [])) if len(paths) == 1: return paths[0] else: filename = getattr(module, "__file__", None) if filename is not None: return os.path.dirname(filename) raise ValueError("Cannot determine directory containing %s" % module) [7f18c770]
- You may provide a register_to keyword parameter as a way to access a registry. This register_to object must have a _registry instance variable to access it. """ from django.apps import apps [e3eb8a2d]
- full_module_name = package_name + "." + module_name try: return importlib_find(full_module_name, package_path) is not None except ModuleNotFoundError: # When module_name is an invalid dotted path, Python raises # ModuleNotFoundError. return False [c7082f16]
- register_to = kwargs.get("register_to") for app_config in apps.get_app_configs(): for module_to_search in args: # Attempt to import the app's module. try: if register_to: before_import_registry = copy.copy(register_to._registry) [7a2f794f]
- try: return cached_import(module_path, class_name) except AttributeError as err: raise ImportError( 'Module "%s" does not define a "%s" attribute/class' % (module_path, class_name) ) from err [689a88d4]
- def autodiscover_modules(*args, **kwargs): """ Auto-discover INSTALLED_APPS modules and fail silently when not present. This forces an import on them to register any admin bits they may want. [e55d24e4]
- def cached_import(module_path, class_name): # Check whether module is loaded and fully initialized. if not ( (module := sys.modules.get(module_path)) and (spec := getattr(module, "__spec__", None)) and getattr(spec, "_initializing", False) is False ): module = import_module(module_path) return getattr(module, class_name) [dd569dc5]
- def import_string(dotted_path): """ Import a dotted module path and return the attribute/class designated by the last name in the path. Raise ImportError if the import failed. """ try: module_path, class_name = dotted_path.rsplit(".", 1) except ValueError as err: raise ImportError("%s doesn't look like a module path" % dotted_path) from err [c111fa1a]
- def module_dir(module): """ Find the name of the directory that contains a module, if possible. [bf3d2c56]
- def module_has_submodule(package, module_name): """See if 'module' is in 'package'.""" try: package_name = package.__name__ package_path = package.__path__ except AttributeError: # package isn't a package. return False [c4da4f11]

## All facts

- [334afe73] import copy import os import sys from importlib import import_module from importlib.util import find_spec as importlib_find
