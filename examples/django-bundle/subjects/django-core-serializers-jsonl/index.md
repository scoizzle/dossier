# django/core/serializers/jsonl

- Subject: django/core/serializers/jsonl (id `5c0a9fca-5107-43d4-aa7b-4dcef3c4c717`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 609 tokens
- Facts shown: 13 of 13
- Conflicts: 0
- Gaps: 0

## Facts

- @staticmethod def _get_lines(stream): for line in stream: if not line.strip(): continue try: yield json.loads(line) except Exception as exc: raise DeserializationError() from exc [decd0c88]
- def __init__(self, stream_or_string, **options): if isinstance(stream_or_string, bytes): stream_or_string = stream_or_string.decode() if isinstance(stream_or_string, str): stream_or_string = stream_or_string.splitlines() super().__init__(Deserializer._get_lines(stream_or_string), **options) [c86fe7b4]
- def _handle_object(self, obj): try: yield from super()._handle_object(obj) except (GeneratorExit, DeserializationError): raise except Exception as exc: raise DeserializationError(f"Error deserializing object: {exc}") from exc [f825e824de238a63-2]
- def _init_options(self): self._current = None self.json_kwargs = self.options.copy() self.json_kwargs.pop("stream", None) self.json_kwargs.pop("fields", None) self.json_kwargs.pop("indent", None) self.json_kwargs["separators"] = (",", ": ") self.json_kwargs.setdefault("cls", DjangoJSONEncoder) self.json_kwargs.setdefault("ensure_ascii", False) [94f4baa8]
- def end_object(self, obj): # self._current has the field data json.dump(self.get_dump_object(obj), self.stream, **self.json_kwargs) self.stream.write("\n") self._current = None [7c6a4f5d]
- def getvalue(self): # Grandparent super return super(PythonSerializer, self).getvalue() [45802a07b4efff30-2]
- def start_serialization(self): self._init_options() [08bcae5f]
- internal_use_only = False [8a17a1b3f025bc34-3]
- """ Serialize data to/from JSON Lines """ [91fb0cca]
- class Deserializer(PythonDeserializer): """Deserialize a stream or string of JSON data.""" [f8bf2896a7c9b000-2]
- class Serializer(PythonSerializer): """Convert a queryset to JSON Lines.""" [6ba0208a]
- from django.core.serializers.base import DeserializationError from django.core.serializers.json import DjangoJSONEncoder from django.core.serializers.python import Deserializer as PythonDeserializer from django.core.serializers.python import Serializer as PythonSerializer [cdec0ac7]
- import json [5766bf5bad9de4d2-10]
