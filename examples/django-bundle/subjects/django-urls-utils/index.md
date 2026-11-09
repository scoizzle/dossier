# django/urls/utils

- Subject: django/urls/utils (id `d8415a72-f26d-46d0-855a-ce9aea785ede`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 506 tokens
- Facts shown: 7 of 7
- Conflicts: 0
- Gaps: 0

## Facts

- if not isinstance(lookup_view, str): raise ViewDoesNotExist( "'%s' is not a callable or a dot-notation path" % lookup_view ) [3556d013]
- mod_name, func_name = get_mod_func(lookup_view) if not func_name: # No '.' in lookup_view raise ImportError( "Could not import '%s'. The path must be fully qualified." % lookup_view ) [97e8a646]
- try: mod = import_module(mod_name) except ImportError: parentmod, submod = get_mod_func(mod_name) if submod and not module_has_submodule(import_module(parentmod), submod): raise ViewDoesNotExist( "Could not import '%s'. Parent module %s does not exist." % (lookup_view, mod_name) ) else: raise else: try: view_func = getattr(mod, func_name) except AttributeError: raise ViewDoesNotExist( "Could not import '%s'. View does not exist in module %s." % (lookup_view, mod_name) ) else: if not callable(view_func): raise ViewDoesNotExist( "Could not import '%s.%s'. View is not callable." % (mod_name, func_name) ) return view_func [e25c02b9]
- @functools.cache def get_callable(lookup_view): """ Return a callable corresponding to lookup_view. * If lookup_view is already a callable, return it. * If lookup_view is a string import path that can be resolved to a callable, import that callable and return it, otherwise raise an exception (ImportError or ViewDoesNotExist). """ if callable(lookup_view): return lookup_view [c07f22a2]
- def get_mod_func(callback): # Convert 'django.views.news.stories.story_detail' to # ['django.views.news.stories', 'story_detail'] try: dot = callback.rindex(".") except ValueError: return callback, "" return callback[:dot], callback[dot + 1 :] [da0a1188]
- from django.core.exceptions import ViewDoesNotExist from django.utils.module_loading import module_has_submodule [d05b9f5a]
- import functools from importlib import import_module [f1add282]
