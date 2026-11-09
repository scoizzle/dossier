# django/core/serializers/python

- Subject: django/core/serializers/python (id `dd641ad8-162d-47b3-acb1-b2c057c3e2e7`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2011 tokens
- Facts shown: 37 of 37
- Conflicts: 0
- Gaps: 0

## Highlights

- def m2m_value(value): if natural := value.natural_key(): return natural else: return self._value_from_field(value, value._meta.pk) [292d9395]
- def m2m_value(value): return self._value_from_field(value, value._meta.pk) [395b675d]
- def queryset_iterator(obj, field): attr = getattr(obj, field.name) chunk_size = ( 2000 if getattr(attr, "prefetch_cache_name", None) else None ) query_set = attr.all() if not query_set.totally_ordered: current_ordering = ( query_set.query.order_by or query_set.model._meta.ordering or [] ) query_set = query_set.order_by(*current_ordering, "pk") return query_set.iterator(chunk_size) [c62f4a1b586b7adc]
- def queryset_iterator(obj, field): query_set = getattr(obj, field.name).select_related(None).only("pk") if not query_set.totally_ordered: current_ordering = ( query_set.query.order_by or query_set.model._meta.ordering or [] ) query_set = query_set.order_by(*current_ordering, "pk") chunk_size = 2000 if query_set._prefetch_related_lookups else None return query_set.iterator(chunk_size=chunk_size) [e7465ca7f2518df7]
- # Handle FK fields elif field.remote_field and isinstance( field.remote_field, models.ManyToOneRel ): try: value = self._handle_fk_field_node(field, field_value) if value == base.DEFER_FIELD: deferred_fields[field] = field_value else: data[field.attname] = value except Exception as e: raise base.DeserializationError.WithData( e, obj["model"], obj.get("pk"), field_value ) [d8e802e1]
- # Handle M2M relations if field.remote_field and isinstance( field.remote_field, models.ManyToManyRel ): try: values = self._handle_m2m_field_node(field, field_value) if values == base.DEFER_FIELD: deferred_fields[field] = field_value else: m2m_data[field.name] = values except base.M2MDeserializationError as e: raise base.DeserializationError.WithData( e.original_exc, obj["model"], obj.get("pk"), e.pk ) [e89ab0a8]
- # Handle all other fields else: try: data[field.name] = field.to_python(field_value) except Exception as e: raise base.DeserializationError.WithData( e, obj["model"], obj.get("pk"), field_value ) [5b747007]
- else: [6ad07797f4838346-5]
- field = Model._meta.get_field(field_name) [c551646a]
- m2m_iter = getattr(obj, "_prefetched_objects_cache", {}).get( field.name, queryset_iterator(obj, field), ) self._current[field.name] = [m2m_value(related) for related in m2m_iter] [915d1a1b]
- # Handle each field for field_name, field_value in obj["fields"].items(): if self.ignorenonexistent and field_name not in field_names: # skip fields no longer on model continue [6f23b6a3]
- # Look up the model and starting build a dict of data for it. try: Model = self._get_model_from_node(obj["model"]) except base.DeserializationError: if self.ignorenonexistent: return raise if "pk" in obj: try: data[Model._meta.pk.attname] = Model._meta.pk.to_python(obj.get("pk")) except Exception as e: raise base.DeserializationError.WithData( e, obj["model"], obj.get("pk"), None ) [749b14c8]
- if Model not in self.field_names_cache: self.field_names_cache[Model] = {f.name for f in Model._meta.get_fields()} field_names = self.field_names_cache[Model] [bcda2ca7]
- def __iter__(self): for obj in self.stream: yield from self._handle_object(obj) [fa6c7a80]

## All facts

- [ba68e04d] model_instance = base.build_instance(Model, data, self.using) yield base.DeserializedObject(model_instance, m2m_data, deferred_fields)
- [109968e1] @staticmethod def _get_model_from_node(model_identifier): """Look up a model from an "app_label.model_name" string.""" try: return apps.get_model(model_identifier) except (LookupError, TypeError): raise base.DeserializationError( f"Invalid model identifier: {model_identifier}" )
- [cc74788d] It's expected that you pass the Python objects themselves (instead of a stream or a string) to the constructor """
- [6dab2d3c] def __init__( self, object_list, *, using=DEFAULT_DB_ALIAS, ignorenonexistent=False, **options ): super().__init__(object_list, **options) self.handle_forward_references = options.pop("handle_forward_references", False) self.using = using self.ignorenonexistent = ignorenonexistent self.field_names_cache = {} # Model: <list of field_names> self._iterator = None
- [d5e3dd6d] def __next__(self): if self._iterator is None: self._iterator = iter(self) return next(self._iterator)
- [cccbe80b] def _handle_fk_field_node(self, field, field_value): return base.deserialize_fk_value( field, field_value, self.using, self.handle_forward_references )
- [b95c1f2d] def _handle_m2m_field_node(self, field, field_value): return base.deserialize_m2m_values( field, field_value, self.using, self.handle_forward_references )
- [b527cb4d] def _handle_object(self, obj): data = {} m2m_data = {} deferred_fields = {}
- [f44733cb] def _value_from_field(self, obj, field): if isinstance(field, CompositePrimaryKey): return [self._value_from_field(obj, f) for f in field] value = field.value_from_object(obj) # Protected types (i.e., primitives like None, numbers, dates, # and Decimals) are passed through as is. All other values are # converted to string first. return value if is_protected_type(value) else field.value_to_string(obj)
- [4e6d5c2a] def end_object(self, obj): self.objects.append(self.get_dump_object(obj)) self._current = None
- [1c2cd4c3] def end_serialization(self): pass
- [0e3ea88c] def get_dump_object(self, obj): data = {"model": str(obj._meta)} if not self.use_natural_primary_keys or not self._resolve_natural_key(obj): data["pk"] = self._value_from_field(obj, obj._meta.pk) data["fields"] = self._current return data
- [8503db00] def getvalue(self): return self.objects
- [8bacb044] def handle_field(self, obj, field): self._current[field.name] = self._value_from_field(obj, field)
- [0475b81c] def handle_fk_field(self, obj, field): if self.use_natural_foreign_keys and ( natural_key_value := self._resolve_fk_natural_key(obj, field) ): value = natural_key_value else: value = self._value_from_field(obj, field) self._current[field.name] = value
- [0c844d66] def handle_m2m_field(self, obj, field): if field.remote_field.through._meta.auto_created: if self.use_natural_foreign_keys and self._model_supports_natural_key( field.remote_field.model ):
- [fb908ca4] def start_object(self, obj): self._current = {}
- [68364316] def start_serialization(self): self._current = None self.objects = []
- [82f019d5] internal_use_only = True
- [65c0896d] """ A Python "serializer". Doesn't do much serializing per se -- just converts to and from basic Python data types (lists, dicts, strings, etc.). Useful as a basis for other serializers. """
- [39841ed5] class Deserializer(base.Deserializer): """ Deserialize simple Python objects back into Django ORM instances.
- [1898132e] class Serializer(base.Serializer): """ Serialize a QuerySet to basic Python objects. """
- [88284035] from django.apps import apps from django.core.serializers import base from django.db import DEFAULT_DB_ALIAS, models from django.db.models import CompositePrimaryKey from django.utils.encoding import is_protected_type
