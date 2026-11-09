# django/db/utils

- Subject: django/db/utils (id `e6973fb6-07b0-4a83-8cfa-9a698bd59c23`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2242 tokens
- Facts shown: 41 facts
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [60a5a62b] def __exit__(self, exc_type, exc_value, traceback): if exc_type is None: return for dj_exc_type in ( DataError, OperationalError, IntegrityError, InternalError, ProgrammingError, NotSupportedError, DatabaseError, InterfaceError, Error, ): db_exc_type = getattr(self.wrapper.Database, dj_exc_type.__name__) if issubclass(exc_type, db_exc_type): dj_exc_value = dj_exc_type(*exc_value.args) # Only set the 'errors_occurred' flag for errors that may make # the connection unusable. if dj_exc_type not in (DataError, IntegrityError): self.wrapper.errors_occurred = True raise dj_exc_value.with_traceback(traceback) from exc_value
- [d915321d] def _router_func(action): def _route_db(self, model, **hints): chosen_db = None for router in self.routers: try: method = getattr(router, action) except AttributeError: # If the router doesn't have a method, skip to the next # one. pass else: chosen_db = method(model, **hints) if chosen_db: return chosen_db instance = hints.get("instance") if instance is not None and instance._state.db: return instance._state.db return DEFAULT_DB_ALIAS
- [58845e0c] def allow_relation(self, obj1, obj2, **hints): for router in self.routers: try: method = router.allow_relation except AttributeError: # If the router doesn't have a method, skip to the next one. pass else: allow = method(obj1, obj2, **hints) if allow is not None: return allow return obj1._state.db == obj2._state.db
- [0e99c4b6] def configure_settings(self, databases): databases = super().configure_settings(databases) if databases == {}: databases[DEFAULT_DB_ALIAS] = {"ENGINE": "django.db.backends.dummy"} elif DEFAULT_DB_ALIAS not in databases: raise ImproperlyConfigured( f"You must define a '{DEFAULT_DB_ALIAS}' database." ) elif databases[DEFAULT_DB_ALIAS] == {}: databases[DEFAULT_DB_ALIAS]["ENGINE"] = "django.db.backends.dummy"
- [ab95d9b9] def create_connection(self, alias): db = self.settings[alias] backend = load_backend(db["ENGINE"]) return backend.DatabaseWrapper(db, alias)
- [0299b782] def get_migratable_models(self, app_config, db, include_auto_created=False): """Return app models allowed to be migrated on provided db.""" models = app_config.get_models(include_auto_created=include_auto_created) return [model for model in models if self.allow_migrate_model(db, model)]
- [eca6e2cb] try: return import_module("%s.base" % backend_name) except ImportError as e_user: # The database backend wasn't found. Display a helpful error message # listing all built-in database backends. import django.db.backends
- [50463ca0] # For backwards compatibility with Django < 3.2 from django.utils.connection import ConnectionDoesNotExist # NOQA: F401 from django.utils.connection import BaseConnectionHandler from django.utils.functional import cached_property from django.utils.module_loading import import_string
- [6359438d] DEFAULT_DB_ALIAS = "default" DJANGO_VERSION_PICKLE_KEY = "_django_version"
- [7d4b34e2] class ConnectionHandler(BaseConnectionHandler): settings_name = "DATABASES" # Connections needs to still be an actual thread local, as it's truly # thread-critical. Database backends should use @async_unsafe to protect # their code from async contexts, but this will give those contexts # separate connections in case it's needed as well. There's no cleanup # after async contexts, though, so we don't allow that if we can help it. thread_critical = True
- [72ef9815] class ConnectionRouter: def __init__(self, routers=None): """ If routers is not specified, default to settings.DATABASE_ROUTERS. """ self._routers = routers
- [170e93d4] class DataError(DatabaseError): pass
- [4b95e64a] class DatabaseError(Error): pass
- [7fc0e4f7] class DatabaseErrorWrapper: """ Context manager and decorator that reraises backend-specific database exceptions using Django's common wrappers. """
- [b55bf23f] class Error(Exception): pass
- [806f46fa] class IntegrityError(DatabaseError): pass
- [e82e62ab] class InterfaceError(Error): pass
- [793fe434] class InternalError(DatabaseError): pass
- [ee78fe09] class NotSupportedError(DatabaseError): pass
- [cea468f9] class OperationalError(DatabaseError): pass
- [6b0db530] class ProgrammingError(DatabaseError): pass
- [b700293d] def load_backend(backend_name): """ Return a database backend's "base" module given a fully qualified database backend name, or raise an error if it doesn't exist. """ # This backend was renamed in Django 1.9. if backend_name == "django.db.backends.postgresql_psycopg2": backend_name = "django.db.backends.postgresql"
- [1af0304e183f826c-2] from django.conf import settings from django.core.exceptions import ImproperlyConfigured
- [9c027f15] import pkgutil from importlib import import_module
