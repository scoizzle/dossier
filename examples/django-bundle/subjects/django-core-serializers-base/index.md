# django/core/serializers/base

- Subject: django/core/serializers/base (id `cb8136c1-b113-4f88-b641-d7bb4cc2ff66`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 3116 tokens
- Facts shown: 52 facts
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [4d880cc8] If the model instance doesn't have a primary key and the model supports natural keys, try to retrieve it from the database. """ default_manager = Model._meta.default_manager pk = data.get(Model._meta.pk.attname) if ( pk is None and hasattr(default_manager, "get_by_natural_key") and hasattr(Model, "natural_key") ): obj = Model(**data) obj._state.db = db natural_key = obj.natural_key() try: data[Model._meta.pk.attname] = Model._meta.pk.to_python( default_manager.db_manager(db).get_by_natural_key(*natural_key).pk ) except Model.DoesNotExist: pass return Model(**data)
- [035a15ef] def __init__(self, output, total_count): self.output = output self.total_count = total_count self.prev_done = 0
- [177f52ba] def __init__(self, stream_or_string, **options): """ Init this serializer given a stream or a string """ self.options = options if isinstance(stream_or_string, str): self.stream = StringIO(stream_or_string) else: self.stream = stream_or_string
- [39fa939991912f8b] def __iter__(self): return self
- [a9826c03] def __next__(self): """Iteration interface -- return the next item in the stream""" raise NotImplementedError( "subclasses of Deserializer must provide a __next__() method" )
- [734cf20a] def __repr__(self): return "<%s: %s(pk=%s)>" % ( self.__class__.__name__, self.object._meta.label, self.object.pk, )
- [2c73ea8a] def _model_supports_natural_key(self, model): """Return True if the model defines a natural_key() method.""" try: return callable(model.natural_key) except AttributeError: return False
- [773b4415] def _resolve_fk_natural_key(self, obj, field): """ Return the natural key for a ForeignKey's related object, or None if not supported. """ if not self._model_supports_natural_key(field.remote_field.model): return None
- [973d433b] def _resolve_natural_key(self, obj): """Return a natural key tuple for the given object when available.""" try: return obj.natural_key() except AttributeError: return None
- [124bd416] def end_object(self, obj): """ Called when serializing of an object ends. """ pass
- [e33fe2ac] def end_serialization(self): """ Called when serializing of the queryset ends. """ pass
- [c1582223] def getvalue(self): """ Return the fully serialized queryset (or None if the output stream is not seekable). """ if callable(getattr(self.stream, "getvalue", None)): return self.stream.getvalue()
- [dac2a9f9] def handle_field(self, obj, field): """ Called to handle each individual (non-relational) field on an object. """ raise NotImplementedError( "subclasses of Serializer must provide a handle_field() method" )
- [fce2bde4] def handle_fk_field(self, obj, field): """ Called to handle a ForeignKey field. """ raise NotImplementedError( "subclasses of Serializer must provide a handle_fk_field() method" )
- [539c9620] def handle_m2m_field(self, obj, field): """ Called to handle a ManyToManyField. """ raise NotImplementedError( "subclasses of Serializer must provide a handle_m2m_field() method" )
- [e62deb67] def save(self, save_m2m=True, using=None, **kwargs): # Call save on the Model baseclass directly. This bypasses any # model-defined save. The save is also forced to be raw. # raw=True is passed to any pre/post_save and m2m_changed signals. models.Model.save_base(self.object, using=using, raw=True, **kwargs) if self.m2m_data and save_m2m: for accessor_name, object_list in self.m2m_data.items(): getattr(self.object, accessor_name).set_base(object_list, raw=True)
- [41704888] def save_deferred_fields(self, using=None): self.m2m_data = {} for field, field_value in self.deferred_fields.items(): opts = self.object._meta label = opts.app_label + "." + opts.model_name if isinstance(field.remote_field, models.ManyToManyRel): try: values = deserialize_m2m_values( field, field_value, using, handle_forward_references=False ) except M2MDeserializationError as e: raise DeserializationError.WithData( e.original_exc, label, self.object.pk, e.pk ) self.m2m_data[field.name] = values elif isinstance(field.remote_field, models.ManyToOneRel): try: value = deserialize_fk_value( field, field_value, using, handle_forward_references=False ) except Exception as e: raise DeserializationError.WithData( e, label, self.object.pk, field_value ) setattr(self.object, field.attname, value) self.save()
- [78b99c9e] def serialize( self, queryset, *, stream=None, fields=None, use_natural_foreign_keys=False, use_natural_primary_keys=False, progress_output=None, object_count=0, **options, ): """ Serialize a queryset. """ self.options = options
- [b330c36f] def start_object(self, obj): """ Called when serializing of an object starts. """ raise NotImplementedError( "subclasses of Serializer must provide a start_object() method" )
- [232f86fc] def start_serialization(self): """ Called when serializing of the queryset starts. """ raise NotImplementedError( "subclasses of Serializer must provide a start_serialization() method" )
- [0ae8e29b] def update(self, count): if not self.output: return perc = count * 100 // self.total_count done = perc * self.progress_width // 100 if self.prev_done >= done: return self.prev_done = done cr = "" if self.total_count == 1 else "\r" self.output.write( cr + "[" + "." * done + " " * (self.progress_width - done) + "]" ) if done == self.progress_width: self.output.write("\n") self.output.flush()
- [6ad07797f4838346-4] else:
- [7655780f0d17b825-38] pass
- [7655780f0d17b825-39] pass
- [41ef8703] try: pks_iter = iter(field_value) except TypeError as e: raise M2MDeserializationError(e, field_value) try: values = [] for pk in pks_iter: values.append(m2m_convert(pk)) return values except Exception as e: if isinstance(e, ObjectDoesNotExist) and handle_forward_references: return DEFER_FIELD else: raise M2MDeserializationError(e, pk)
- [0bd17052] """ Module for abstract serializer/unserializer base classes. """
- [6a06aff8] DEFER_FIELD = object()
- [fb3720e5] class DeserializationError(Exception): """Something bad happened during deserialization."""
- [d2fdedf8] class DeserializedObject: """ A deserialized model.
- [2865f258] class Deserializer: """ Abstract base deserializer class. """
- [0d8abce8] class M2MDeserializationError(Exception): """Something bad happened during deserialization of a ManyToManyField."""
- [f1b63e85] class ProgressBar: progress_width = 75
- [4f9b277f] class SerializationError(Exception): """Something bad happened during serialization."""
- [845ffbb5] class Serializer: """ Abstract serializer base class. """
- [8ec2e372] class SerializerDoesNotExist(KeyError): """The requested serializer was not found."""
- [89eb6da6] def build_instance(Model, data, db): """ Build a model instance.
- [b594a682] def deserialize_fk_value(field, field_value, using, handle_forward_references): if field_value is None: return None model = field.remote_field.model default_manager = model._default_manager field_name = field.remote_field.field_name if ( hasattr(default_manager, "get_by_natural_key") and hasattr(field_value, "__iter__") and not isinstance(field_value, str) ): try: obj = default_manager.db_manager(using).get_by_natural_key(*field_value) except ObjectDoesNotExist: if handle_forward_references: return DEFER_FIELD else: raise value = getattr(obj, field_name) # If this is a natural foreign key to an object that has a FK/O2O as # the foreign key, use the FK value. if model._meta.pk.remote_field: value = value.pk return value return model._meta.get_field(field_name).to_python(field_value)
- [ff1700e3] def deserialize_m2m_values(field, field_value, using, handle_forward_references): model = field.remote_field.model if hasattr(model._default_manager, "get_by_natural_key"):
- [518eac7b] from django.core.exceptions import ObjectDoesNotExist from django.db import models
- [b6362c8a] from io import StringIO
