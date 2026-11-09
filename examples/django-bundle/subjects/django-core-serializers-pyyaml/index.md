# django/core/serializers/pyyaml

- Subject: django/core/serializers/pyyaml (id `f11e8e1c-c83a-4a2d-9d4b-e6ebdea4f208`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 752 tokens
- Facts shown: 17 facts
- Conflicts: 0
- Gaps: 0

## Facts

- def __init__(self, stream_or_string, **options): stream = stream_or_string if isinstance(stream_or_string, bytes): stream = stream_or_string.decode() try: objects = yaml.load(stream, Loader=SafeLoader) except Exception as exc: raise DeserializationError() from exc super().__init__(objects, **options) [040eef7c]
- def _handle_object(self, obj): try: yield from super()._handle_object(obj) except (GeneratorExit, DeserializationError): raise except Exception as exc: raise DeserializationError(f"Error deserializing object: {exc}") from exc [f825e824de238a63-3]
- def end_serialization(self): self.options.setdefault("allow_unicode", True) self.options.setdefault("sort_keys", False) yaml.dump( self.objects, self.stream, Dumper=DjangoSafeDumper, **self.options, ) [cbdf1d82]
- def getvalue(self): # Grandparent super return super(PythonSerializer, self).getvalue() [45802a07b4efff30-3]
- def represent_decimal(self, data): return self.represent_scalar("tag:yaml.org,2002:str", str(data)) [2cf50c38]
- def represent_time(self, data): # Base YAML doesn't support serialization of time types (as opposed to # dates or datetimes, which it does support). Converting them to # strings isn't perfect, but it's better than a "!!python/time" type # which would prevent deserialization under any other language. return self.represent_scalar("tag:yaml.org,2002:str", str(data)) [8eab61ff]
- internal_use_only = False [8a17a1b3f025bc34-4]
- """ YAML serializer. [b1ff71d6]
- # Use the C (faster) implementation if possible try: from yaml import CSafeDumper as SafeDumper from yaml import CSafeLoader as SafeLoader except ImportError: from yaml import SafeDumper, SafeLoader [306d5208]
- DjangoSafeDumper.add_representer(decimal.Decimal, DjangoSafeDumper.represent_decimal) DjangoSafeDumper.add_representer(datetime.time, DjangoSafeDumper.represent_time) [d626d565]
- Requires PyYaml (https://pyyaml.org/), but that's checked for in __init__. """ [94a41469]
- class Deserializer(PythonDeserializer): """Deserialize a stream or string of YAML data.""" [3d7f3c5e]
- class DjangoSafeDumper(SafeDumper): # The "safe" serializer is used for better interoperability. [eb0e241c]
- class Serializer(PythonSerializer): """Convert a queryset to YAML.""" [73629a11]
- from django.core.serializers.base import DeserializationError from django.core.serializers.python import Deserializer as PythonDeserializer from django.core.serializers.python import Serializer as PythonSerializer [087fa028]
- import datetime import decimal [e2937da268df9eae]
- import yaml [ceff3239]
