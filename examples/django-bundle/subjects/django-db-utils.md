# django/db/utils

- Subject: django/db/utils (id `85aa685a-1438-4c64-bb29-800517dc59e1`)
- Kind: subject
- Budget: 1200 tokens
- Used: 894 tokens
- Facts shown: 17 of 41
- Conflicts: 0
- Gaps: 0

## Facts

- allow = method(db, app_label, **hints) [865825ec]
- if allow is not None: return allow return True [6833b789]
- test_settings = conn.setdefault("TEST", {}) default_test_settings = [ ("CHARSET", None), ("COLLATION", None), ("MIGRATE", True), ("MIRROR", None), ("NAME", None), ] for key, value in default_test_settings: test_settings.setdefault(key, value) return databases [4399cb42]
- # Configure default settings. for conn in databases.values(): conn.setdefault("ATOMIC_REQUESTS", False) conn.setdefault("AUTOCOMMIT", True) conn.setdefault("ENGINE", "django.db.backends.dummy") if conn["ENGINE"] == "django.db.backends." or not conn["ENGINE"]: conn["ENGINE"] = "django.db.backends.dummy" conn.setdefault("CONN_MAX_AGE", 0) conn.setdefault("CONN_HEALTH_CHECKS", False) conn.setdefault("OPTIONS", {}) conn.setdefault("TIME_ZONE", None) for setting in ["NAME", "USER", "PASSWORD", "HOST", "PORT"]: conn.setdefault(setting, "") [1b9d7c20]
- It must have a Database attribute defining PEP-249 exceptions. """ self.wrapper = wrapper [b2d6a76f]
- builtin_backends = [ name for _, name, ispkg in pkgutil.iter_modules(django.db.backends.__path__) if ispkg and name not in {"base", "dummy"} ] if backend_name not in ["django.db.backends.%s" % b for b in builtin_backends]: backend_reprs = map(repr, sorted(builtin_backends)) raise ImproperlyConfigured( "%r isn't an available database backend or couldn't be " "imported. Check the above exception. To use one of the " "built-in backends, use 'django.db.backends.XXX', where XXX " "is one of:\n" " %s" % (backend_name, ", ".join(backend_reprs)) ) from e_user else: # If there's some other error, this must be an error in Django raise [a7b7e915]
- return _route_db [2d86cb19]
- return inner [b9689d746b8236ce-3]
- @cached_property def routers(self): if self._routers is None: self._routers = settings.DATABASE_ROUTERS routers = [] for r in self._routers: if isinstance(r, str): router = import_string(r)() else: router = r routers.append(router) return routers [53dd086e]
- @property def databases(self): # Maintained for backward compatibility as some 3rd party packages have # made use of this private API in the past. It is no longer used within # Django itself. return self.settings [7c2618da]
- db_for_read = _router_func("db_for_read") db_for_write = _router_func("db_for_write") [b3271b55]
- def __call__(self, func): # Note that we are intentionally not using @wraps here for performance # reasons. Refs #21109. def inner(*args, **kwargs): with self: return func(*args, **kwargs) [d64b00e9]
- def __del__(self): del self.wrapper [b315085f]
- def __enter__(self): pass [d56d0967]
- def __init__(self, wrapper): """ wrapper is a database wrapper. [9116fe27]
- def allow_migrate(self, db, app_label, **hints): for router in self.routers: try: method = router.allow_migrate except AttributeError: # If the router doesn't have a method, skip to the next one. continue [aa9e11b3]
- def allow_migrate_model(self, db, model): return self.allow_migrate( db, model._meta.app_label, model_name=model._meta.model_name, model=model, ) [861ed1de]

## Beyond the budget

24 more facts did not fit in the budget: [60a5a62b] [d915321d] [58845e0c] [0e99c4b6] [ab95d9b9] [0299b782] [eca6e2cb] [50463ca0] [6359438d] [7d4b34e2] [72ef9815] [170e93d4] [4b95e64a] [7fc0e4f7] [b55bf23f] [806f46fa] [e82e62ab] [793fe434] [ee78fe09] [cea468f9] [6b0db530] [b700293d] [1af0304e183f826c-2] [9c027f15]
