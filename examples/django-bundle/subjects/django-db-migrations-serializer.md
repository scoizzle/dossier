# django/db/migrations/serializer

- Subject: django/db/migrations/serializer (id `3f40224e-1236-4c0e-9fdc-5e862d5d9408`)
- Kind: subject
- Budget: 1200 tokens
- Used: 879 tokens
- Facts shown: 16 of 52
- Conflicts: 0
- Gaps: 0

## Facts

- if "<" not in self.value.__qualname__: # Qualname can include <locals> return "%s.%s" % (module_name, self.value.__qualname__), { "import %s" % self.value.__module__ } [da169c74]
- module_name = self.value.__module__ [53aea867]
- raise ValueError( "Could not find function %s in %s.\n" % (self.value.__name__, module_name) ) [c1215e05]
- return "%s(%s)" % (name, ", ".join(strings)), imports [c7604616]
- string, imports = OperationWriter(self.value, indentation=0).serialize() # Nested operation, trailing comma is handled in upper # OperationWriter._write() return string.rstrip(","), imports [e10fa0ef]
- @classmethod def register(cls, type_, serializer): if not issubclass(serializer, BaseSerializer): raise ValueError( "'%s' must inherit from 'BaseSerializer'." % serializer.__name__ ) cls._registry[type_] = serializer [21672062]
- @classmethod def unregister(cls, type_): cls._registry.pop(type_) [977dd76b]
- @staticmethod def _serialize_path(path): module, name = path.rsplit(".", 1) if module == "django.db.models": imports = {"from django.db import models"} name = "models.%s" % name else: imports = {"import %s" % module} name = path return name, imports [79c694e8]
- def serialize(self): if self.value.tzinfo is not None and self.value.tzinfo != datetime.UTC: self.value = self.value.astimezone(datetime.UTC) imports = ["import datetime"] return repr(self.value), set(imports) [a727444e]
- def serialize(self): imports = set() strings = [] for item in self.value: item_string, item_imports = serializer_factory(item).serialize() imports.update(item_imports) strings.append(item_string) value = self._format() return value % (", ".join(strings)), imports [616a1b7a]
- def serialize(self): raise NotImplementedError( "Subclasses of BaseSerializer must implement the serialize() method." ) [203127e0]
- def serialize(self): return repr(self.value), {"import datetime"} [75bb1025]
- def serialize(self): return self.serialize_deconstructed(*self.value.deconstruct()) [8d879d80]
- if isinstance(value, models.Field): return ModelFieldSerializer(value) if isinstance(value, models.manager.BaseManager): return ModelManagerSerializer(value) if isinstance(value, Operation): return OperationSerializer(value) if isinstance(value, type): return TypeSerializer(value) # Anything that knows how to deconstruct itself. if hasattr(value, "deconstruct"): return DeconstructibleSerializer(value) for type_, serializer_cls in Serializer._registry.items(): if isinstance(value, type_): return serializer_cls(value) raise ValueError( "Cannot serialize: %r\nThere are some values Django cannot serialize into " "migration files.\nFor more, see https://docs.djangoproject.com/en/%s/" "topics/migrations/#migration-serializing" % (value, get_docs_version()) ) [14ec055a]
- FUNCTION_TYPES = (types.FunctionType, types.BuiltinFunctionType, types.MethodType) [4d8b663a]
- class BaseSequenceSerializer(BaseSerializer): def _format(self): raise NotImplementedError( "Subclasses of BaseSequenceSerializer must implement the _format() method." ) [2a901e8e]

## Beyond the budget

36 more facts did not fit in the budget: [792dca4a] [c7718c45] [9ad21f56] [97a7aae7] [1f9a6209] [4b33dd7b] [2ebf3234] [6287adef] [2663b4af] [70ee3193] [cfb8120b] [df0f4394] [edccb9ef] [6b0037f9] [5191a6d2] [1c8531e7] [dc11d372] [82b70f8f] [6a27d8b3] [e7049336] [f9473d20] [f8833644] [0d001075] [3609c2f7] [43505bf1] [fdee9139] [972da24a] [03c724cd] [23ff39dc] [b78b8f5e] [65480c04] [c4edf2ce] [53020c1b] [f1f1c7d9] [3b1be58d] [592c8228]
