# django/db/models/manager

- Subject: django/db/models/manager (id `1981ddd7-0a7e-4432-b79c-e339b0738634`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1685 tokens
- Facts shown: 35 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- return manager_method [c2f1ab69]
- Raise a ValueError if the manager is dynamically generated. """ qs_class = self._queryset_class if getattr(self, "_built_with_as_manager", False): # using MyQuerySet.as_manager() return ( True, # as_manager None, # manager_class "%s.%s" % (qs_class.__module__, qs_class.__name__), # qs_class None, # args None, # kwargs ) else: module_name = self.__module__ name = self.__class__.__name__ # Make sure it's actually there and not an inner class module = import_module(module_name) if not hasattr(module, name): raise ValueError( "Could not find manager %s in %s.\n" "Please note that you need to inherit from managers you " "dynamically generated with 'from_queryset()'." % (name, module_name) ) return ( False, # as_manager "%s.%s" % (module_name, name), # manager_class None, # qs_class self._constructor_args[0], # args self._constructor_args[1], # kwargs ) [23a5c137]
- cls._meta.add_manager(self) [11c41e7c]
- if cls._meta.abstract: raise AttributeError( "Manager isn't available; %s is abstract" % (cls._meta.object_name,) ) [e5569a1a]
- if cls._meta.swapped: raise AttributeError( "Manager isn't available; '%s' has been swapped for '%s'" % ( cls._meta.label, cls._meta.swapped, ) ) [4bc3c9ca]
- new_methods = {} for name, method in inspect.getmembers( queryset_class, predicate=inspect.isfunction ): # Only copy missing methods. if hasattr(cls, name): continue # Only copy public methods or methods with the attribute # queryset_only=False. queryset_only = getattr(method, "queryset_only", None) if queryset_only or (queryset_only is None and name.startswith("_")): continue # Copy the method onto the manager. new_methods[name] = create_method(name, method) return new_methods [1e90078d]
- return cls._meta.managers_map[self.manager.name] [b41208e9]
- setattr(cls, name, ManagerDescriptor(self)) [ea54aa7c]
- # Set to True for the 'objects' managers that are automatically created. auto_created = False [9a07c230]
- ####################### # PROXIES TO QUERYSET # ####################### [2c38c091]
- #: If set to True the manager will be serialized into migrations and will #: thus be available in e.g. RunPython operations. use_in_migrations = False [e4cebb03]
- @classmethod def _get_queryset_methods(cls, queryset_class): def create_method(name, method): @wraps(method) def manager_method(self, *args, **kwargs): return getattr(self.get_queryset(), name)(*args, **kwargs) [46496dec]
- @classmethod def from_queryset(cls, queryset_class, class_name=None): if class_name is None: class_name = "%sFrom%s" % (cls.__name__, queryset_class.__name__) return type( class_name, (cls,), { "_queryset_class": queryset_class, **cls._get_queryset_methods(queryset_class), }, ) [d16d6fa6]
- @property def db(self): return self._db or router.db_for_read(self.model, **self._hints) [91be03ee]
- def __class_getitem__(cls, *args, **kwargs): return cls [59678c39296a52e4-3]
- def __eq__(self, other): return ( isinstance(other, self.__class__) and self._constructor_args == other._constructor_args ) [29b5cfec]
- def __hash__(self): return id(self) [91f359af]

## All facts

- [33db25d8] def __get__(self, instance, cls=None): if instance is not None: raise AttributeError( "Manager isn't accessible via %s instances" % cls.__name__ )
- [7c86dafc] def __init__(self): super().__init__() self._set_creation_counter() self.model = None self.name = None self._db = None self._hints = {}
- [7cb57085] def __new__(cls, *args, **kwargs): # Capture the arguments to make returning them trivial. obj = super().__new__(cls) obj._constructor_args = (args, kwargs) return obj
- [c4f93dac] def __str__(self): """Return "app_label.model_label.manager_name".""" return "%s.%s" % (self.model._meta.label, self.name)
- [0ddeeaea] def _set_creation_counter(self): """ Set the creation counter value for this instance and increment the class-level copy. """ self.creation_counter = BaseManager.creation_counter BaseManager.creation_counter += 1
- [52e208d1] def all(self): # We can't proxy this method through the `QuerySet` like we do for the # rest of the `QuerySet` methods. This is because `QuerySet.all()` # works by creating a "copy" of the current queryset and in making said # copy, all the cached `prefetch_related` lookups are lost. See the # implementation of `RelatedManager.get_queryset()` for a better # understanding of how this comes into play. return self.get_queryset()
- [29d2ea2570acf4bf-2] def check(self, **kwargs): return []
- [26573fd3] def contribute_to_class(self, cls, name): self.name = self.name or name self.model = cls
- [9726fd64] def db_manager(self, using=None, hints=None): obj = copy.copy(self) obj._db = using or self._db obj._hints = hints or self._hints return obj
- [0c9fa81d] def deconstruct(self): """ Return a 5-tuple of the form (as_manager (True), manager_class, queryset_class, args, kwargs).
- [b3094dc1] def get_queryset(self): """ Return a new QuerySet object. Subclasses can override this method to customize the behavior of the Manager. """ return self._queryset_class(model=self.model, using=self._db, hints=self._hints)
- [706f26f3] def get_queryset(self): return super().get_queryset().none()
- [7f9b4845] class BaseManager: # To retain order, track each time a Manager instance is created. creation_counter = 0
- [d2c5d03e] class EmptyManager(Manager): def __init__(self, model): super().__init__() self.model = model
- [e1179bcd] class Manager(BaseManager.from_queryset(QuerySet)): pass
- [04b93c30] class ManagerDescriptor: def __init__(self, manager): self.manager = manager
- [ed10271b] from django.db import router from django.db.models.query import QuerySet
- [8bc32ce6] import copy import inspect from functools import wraps from importlib import import_module
