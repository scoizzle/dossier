# django/core/serializers/base

- Subject: django/core/serializers/base (id `d548ad35-8803-414a-ae58-2e3db6fedfda`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 12 of 52
- Conflicts: 0
- Gaps: 0

## Facts

- # prevent a second (possibly accidental) call to save() from saving # the m2m data twice. self.m2m_data = None [9388a42a]
- def m2m_convert(v): return model._meta.pk.to_python(v) [3f06e45e]
- def m2m_convert(value): if hasattr(value, "__iter__") and not isinstance(value, str): return ( model._default_manager.db_manager(using) .get_by_natural_key(*value) .pk ) else: return model._meta.pk.to_python(value) [d0621b9a]
- related = getattr(obj, field.name, None) try: return related.natural_key() except AttributeError: return None [caddb7ef]
- self.start_serialization() self.first = True for count, obj in enumerate(queryset, start=1): self.start_object(obj) # Use the concrete parent class' _meta instead of the object's # _meta This is to avoid local_fields problems for proxy models. # Refs #17717. concrete_model = obj._meta.concrete_model # When using natural primary keys, retrieve the pk field of the # parent for multi-table inheritance child models. That field must # be serialized, otherwise deserialization isn't possible. if self.use_natural_primary_keys: pk = concrete_model._meta.pk pk_parent = ( pk if pk.remote_field and pk.remote_field.parent_link else None ) else: pk_parent = None for field in concrete_model._meta.local_fields: if field.serialize or field is pk_parent: if field.remote_field is None: if ( self.selected_fields is None or field.attname in self.selected_fields ): self.handle_field(obj, field) else: if ( self.selected_fields is None or field.attname[:-3] in self.selected_fields ): self.handle_fk_field(obj, field) for field in concrete_model._meta.local_many_to_many: if field.serialize: if ( self.selected_fields is None or field.attname in self.selected_fields ): self.handle_m2m_field(obj, field) self.end_object(obj) progress_bar.update(count) self.first = self.first and False self.end_serialization() return self.getvalue() [39d6ec26]
- self.stream = stream if stream is not None else self.stream_class() self.selected_fields = fields self.use_natural_foreign_keys = use_natural_foreign_keys self.use_natural_primary_keys = use_natural_primary_keys progress_bar = self.progress_class(progress_output, object_count) [24723b20]
- # Indicates if the implemented serializer is only available for # internal Django use. internal_use_only = False progress_class = ProgressBar stream_class = StringIO [7667c97a]
- @classmethod def WithData(cls, original_exc, model, fk, field_value): """ Factory method for creating a deserialization error which has a more explanatory message. """ return cls( "%s: (%s:pk=%s) field_value was '%s'" % (original_exc, model, fk, field_value) ) [5149f7c6]
- Basically a container for holding the pre-saved deserialized data along with the many-to-many data saved with the object. [89a2072d]
- Call ``save()`` to save the object (with the many-to-many data) to the database; call ``save(save_m2m=False)`` to save just the object fields (and not touch the many-to-many stuff.) """ [b185f7e9]
- def __init__(self, obj, m2m_data=None, deferred_fields=None): self.object = obj self.m2m_data = m2m_data self.deferred_fields = deferred_fields [7388ea6b]
- def __init__(self, original_exc, pk): self.original_exc = original_exc self.pk = pk [06c5667c]

## Beyond the budget

40 more facts did not fit in the budget: [4d880cc8] [035a15ef] [177f52ba] [39fa939991912f8b] [a9826c03] [734cf20a] [2c73ea8a] [773b4415] [973d433b] [124bd416] [e33fe2ac] [c1582223] [dac2a9f9] [fce2bde4] [539c9620] [e62deb67] [41704888] [78b99c9e] [b330c36f] [232f86fc] [0ae8e29b] [6ad07797f4838346-4] [7655780f0d17b825-38] [7655780f0d17b825-39] [41ef8703] [0bd17052] [6a06aff8] [fb3720e5] [d2fdedf8] [2865f258] [0d8abce8] [f1b63e85] [4f9b277f] [845ffbb5] [8ec2e372] [89eb6da6] [b594a682] [ff1700e3] [518eac7b] [b6362c8a]
