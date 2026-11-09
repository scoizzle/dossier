# django/core/serializers/python

- Subject: django/core/serializers/python (id `e67b9c1e-4e87-435d-bb1f-05927613b72e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 14 of 37
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

23 more facts did not fit in the budget: [ba68e04d] [109968e1] [cc74788d] [6dab2d3c] [d5e3dd6d] [cccbe80b] [b95c1f2d] [b527cb4d] [f44733cb] [4e6d5c2a] [1c2cd4c3] [0e3ea88c] [8503db00] [8bacb044] [0475b81c] [0c844d66] [fb908ca4] [68364316] [82f019d5] [65c0896d] [39841ed5] [1898132e] [88284035]
