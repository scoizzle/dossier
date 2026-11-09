# django/utils/inspect

- Subject: django/utils/inspect (id `a541fcea-61fb-4e2d-89d0-96ed3e68ccc4`)
- Kind: subject
- Budget: 1200 tokens
- Used: 895 tokens
- Facts shown: 17 of 21
- Conflicts: 0
- Gaps: 0

## Facts

- This context manager is not reentrant. """ if PY315 or not PY314: yield return with lock: original_helper = inspect._signature_from_callable inspect._signature_from_callable = safe_signature_from_callable try: yield finally: inspect._signature_from_callable = original_helper [40164182]
- This private helper should only be used for Python 3.14, as https://github.com/python/cpython/issues/141560 was fixed in 3.15. [b1a0cb7a]
- if "<locals>" in func.__qualname__: return False [cfc4d5d1]
- if not PY315: lock = threading.Lock() safe_signature_from_callable = functools.partial( inspect._signature_from_callable, annotation_format=annotationlib.Format.FORWARDREF, ) [03e7fec5]
- return True [710da0373775b09e-3]
- @contextmanager def lazy_annotations(): """ inspect.getfullargspec eagerly evaluates type annotations. To add compatibility with Python 3.14+ deferred evaluation, patch the module-level helper to provide the annotation_format that we are using elsewhere. [d9bad448]
- @functools.lru_cache(maxsize=512) def _get_func_parameters(func, remove_first): parameters = tuple(signature(func).parameters.values()) if remove_first: parameters = parameters[1:] return parameters [46b1e940]
- ARG_KINDS = frozenset( { inspect.Parameter.POSITIONAL_ONLY, inspect.Parameter.KEYWORD_ONLY, inspect.Parameter.POSITIONAL_OR_KEYWORD, } ) [1cbc4872]
- def _get_callable_parameters(meth_or_func): is_method = inspect.ismethod(meth_or_func) func = meth_or_func.__func__ if is_method else meth_or_func return _get_func_parameters(func, remove_first=is_method) [4ec25c75]
- def func_accepts_kwargs(func): """Return True if function 'func' accepts keyword arguments **kwargs.""" return any(p for p in _get_callable_parameters(func) if p.kind == p.VAR_KEYWORD) [4bf0712e]
- def func_accepts_var_args(func): """ Return True if function 'func' accepts positional arguments *args. """ return any(p for p in _get_callable_parameters(func) if p.kind == p.VAR_POSITIONAL) [b54cd570]
- def func_supports_parameter(func, name): return any(param.name == name for param in _get_callable_parameters(func)) [24ff48d5]
- def get_func_args(func): params = _get_callable_parameters(func) return [param.name for param in params if param.kind in ARG_KINDS] [9f32f3e0]
- def get_func_full_args(func): """ Return a list of (argument name, default value) tuples. If the argument does not have a default value, omit it in the tuple. Arguments such as *args and **kwargs are also included. """ params = _get_callable_parameters(func) args = [] for param in params: name = param.name # Ignore 'self' if name == "self": continue if param.kind == inspect.Parameter.VAR_POSITIONAL: name = "*" + name elif param.kind == inspect.Parameter.VAR_KEYWORD: name = "**" + name if param.default != inspect.Parameter.empty: args.append((name, param.default)) else: args.append((name,)) return args [82462871]
- def is_module_level_function(func): if not inspect.isfunction(func) or inspect.isbuiltin(func): return False [4feecfbf]
- from django.utils.version import PY314, PY315 [2d1921d8]
- if PY314: import annotationlib [819614d5]

## Beyond the budget

4 more facts did not fit in the budget: [1e624da6] [5c78c5ed] [0bd4f256] [cfb2747e]
