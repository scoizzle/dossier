# django/db/models/fields/reverse_related

- Subject: django/db/models/fields/reverse_related (id `f209cf04-0290-44f8-ba86-701f8b13fa51`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 3162 tokens
- Facts shown: 61 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- Analog of django.db.models.fields.Field.get_choices(), provided initially for utilization by RelatedFieldListFilter. """ if blank_choice is None: blank_choice = [("", get_blank_choice_label())] limit_choices_to = limit_choices_to or self.limit_choices_to qs = self.related_model._default_manager.complex_filter(limit_choices_to) if ordering: qs = qs.order_by(*ordering) return (blank_choice if include_blank else []) + [(x.pk, str(x)) for x in qs] [b964b938]
- if through and not db_constraint: raise ValueError("Can't supply a through model and db_constraint=False") self.through = through [4b8d86c2]
- if through_fields and not through: raise ValueError("Cannot specify through_fields without a through model") self.through_fields = through_fields [e925b434]
- self.field_name = field_name [2401f1b9]
- self.multiple = False [21c41ef0]
- self.symmetrical = False self.multiple = True [d547c1ca]
- self.symmetrical = symmetrical self.db_constraint = db_constraint [5e41b87f]
- # Field flags auto_created = True concrete = False editable = False is_relation = True [ec8509b1]
- # Reverse relations are always nullable (Django can't enforce that a # foreign key on the related model points to this model). null = True empty_strings_allowed = False [c6c9dcaa]
- # Some of the following cached_properties can't be initialized in # __init__ as the field doesn't have its model yet. Calling these methods # before field.contribute_to_class() has been called will result in # AttributeError @cached_property def hidden(self): """Should the related object be hidden?""" return bool(self.related_name) and self.related_name[-1] == "+" [5eafc49a]
- @cached_property def accessor_name(self): return self.get_accessor_name() [fd724df2]
- @cached_property def cache_name(self): """ Return the name of the cache key to use for storing an instance of the forward model on the reverse model. """ return self.accessor_name [856e3746]
- @cached_property def many_to_many(self): return self.field.many_to_many [23837760]
- @cached_property def many_to_one(self): return self.field.one_to_many [11f4af40]
- @cached_property def name(self): return self.field.related_query_name() [935564b5]
- @cached_property def one_to_many(self): return self.field.many_to_one [aafb72cd]
- @cached_property def one_to_one(self): return self.field.one_to_one [634b2d7a]
- @cached_property def path_infos(self): return self.get_path_info() [758a5f452091b8b4-3]
- @cached_property def related_model(self): if not self.field.model: raise AttributeError( "This property can't be accessed before self.field.contribute_to_class " "has been called." ) return self.field.model [609db578]
- @property def db_type(self): return self.field.db_type [079fb8d8]
- @property def identity(self): return ( *super().identity, self.through, make_hashable(self.through_fields), self.db_constraint, ) [5729d8fc]
- @property def identity(self): return (*super().identity, self.field_name) [a3ecee64]

## All facts

- [95776eee] @property def identity(self): return ( self.field, self.model, self.related_name, self.related_query_name, make_hashable(self.limit_choices_to), self.parent_link, self.on_delete, self.symmetrical, self.multiple, )
- [28599ce6] @property def remote_field(self): return self.field
- [39b7b70e] @property def target_field(self): """ When filtering against this relation, return the field on the remote model against which the filtering should happen. """ target_fields = self.path_infos[-1].target_fields if len(target_fields) > 1: raise exceptions.FieldError( "Can't use target_field for multicolumn relations." ) return target_fields[0]
- [c11d430c] Note: Because we somewhat abuse the Rel objects by using them as reverse fields we get the funny situation where ``ManyToOneRel.many_to_one == False`` and ``ManyToOneRel.one_to_many == True``. This is unfortunate but the actual ManyToOneRel class is a private API and there is work underway to turn reverse relations into actual fields. """
- [02b1201a] ``_meta.get_fields()`` returns this class to provide access to the field flags for the reverse relation.
- [b6d66a15bd48e217] ``_meta.get_fields()`` returns this class to provide access to the field flags for the reverse relation. """
- [b6d66a15bd48e217-2] ``_meta.get_fields()`` returns this class to provide access to the field flags for the reverse relation. """
- [b6d66a15bd48e217-3] ``_meta.get_fields()`` returns this class to provide access to the field flags for the reverse relation. """
- [2d7c403e] def __eq__(self, other): if not isinstance(other, self.__class__): return NotImplemented return self.identity == other.identity
- [b9bf7147] def __getstate__(self): state = self.__dict__.copy() # Delete the path_infos cached property because it can be recalculated # at first invocation after deserialization. The attribute must be # removed because subclasses like ManyToOneRel may have a PathInfo # which contains an intermediate M2M table that's been dynamically # created and doesn't exist in the .models module. # This is a reverse relation, so there is no reverse_path_infos to # delete. state.pop("path_infos", None) return state
- [34ebb3c5] def __getstate__(self): state = super().__getstate__() state.pop("related_model", None) return state
- [35803cb27a9b3f58-2] def __hash__(self): return hash(self.identity)
- [0f7f0458] def __init__( self, field, to, field_name, related_name=None, related_query_name=None, limit_choices_to=None, parent_link=False, on_delete=None, ): super().__init__( field, to, field_name, related_name=related_name, related_query_name=related_query_name, limit_choices_to=limit_choices_to, parent_link=parent_link, on_delete=on_delete, )
- [df20c1ad] def __init__( self, field, to, field_name, related_name=None, related_query_name=None, limit_choices_to=None, parent_link=False, on_delete=None, ): super().__init__( field, to, related_name=related_name, related_query_name=related_query_name, limit_choices_to=limit_choices_to, parent_link=parent_link, on_delete=on_delete, )
- [88edca61] def __init__( self, field, to, related_name=None, related_query_name=None, limit_choices_to=None, parent_link=False, on_delete=None, ): self.field = field self.model = to self.related_name = related_name self.related_query_name = related_query_name self.limit_choices_to = {} if limit_choices_to is None else limit_choices_to self.parent_link = parent_link self.on_delete = on_delete
- [dca1956e] def __init__( self, field, to, related_name=None, related_query_name=None, limit_choices_to=None, symmetrical=True, through=None, through_fields=None, db_constraint=True, ): super().__init__( field, to, related_name=related_name, related_query_name=related_query_name, limit_choices_to=limit_choices_to, )
- [9f8ccbc1] def __repr__(self): return "<%s: %s.%s>" % ( type(self).__name__, self.related_model._meta.app_label, self.related_model._meta.model_name, )
- [50585228] def get_accessor_name(self, model=None): # This method encapsulates the logic that decides what name to give an # accessor descriptor that retrieves related many-to-one or # many-to-many objects. It uses the lowercased object_name + "_set", # but this can be overridden with the "related_name" option. Due to # backwards compatibility ModelForms need to be able to provide an # alternate model. See BaseInlineFormSet.get_default_prefix(). opts = model._meta if model else self.related_model._meta model = model or self.related_model if self.multiple: # If this is a symmetrical m2m relation on self, there is no # reverse accessor. if self.symmetrical and model == self.model: return None if self.related_name: return self.related_name return opts.model_name + ("_set" if self.multiple else "")
- [d8a8b2a3] def get_choices( self, include_blank=True, blank_choice=None, limit_choices_to=None, ordering=(), ): """ Return choices with a default blank choices included, for use as <select> choices for this field.
- [7e038f65] def get_extra_restriction(self, alias, related_alias): return self.field.get_extra_restriction(related_alias, alias)
- [d53916ca] def get_internal_type(self): return self.field.get_internal_type()
- [7b2a5ba5] def get_joining_fields(self): return self.field.get_reverse_joining_fields()
- [a1068be7] def get_lookup(self, lookup_name): return self.field.get_lookup(lookup_name)
- [95929e49] def get_lookups(self): return self.field.get_lookups()
- [fa77e773] def get_path_info(self, filtered_relation=None): if filtered_relation: return self.field.get_reverse_path_info(filtered_relation) else: return self.field.reverse_path_infos
- [1cd9b0dd] def get_related_field(self): """ Return the Field in the 'to' object to which this relationship is tied. """ field = self.model._meta.get_field(self.field_name) if not field.concrete: raise exceptions.FieldDoesNotExist( "No related field named '%s'" % self.field_name ) return field
- [b3fa3ca4] def get_related_field(self): """ Return the field in the 'to' object to which this relationship is tied. Provided for symmetry with ManyToOneRel. """ opts = self.through._meta if self.through_fields: field = opts.get_field(self.through_fields[0]) else: for field in opts.fields: rel = getattr(field, "remote_field", None) if rel and rel.model == self.model: break return field.foreign_related_fields[0]
- [cb7a37a1] def get_transform(self, name): return self.field.get_transform(name)
- [4ef8b67b] def set_field_name(self): """ Set the related field's name, this is not available until later stages of app loading, so set_field_name is called from set_attributes_from_rel() """ # By default foreign object doesn't relate to any remote field (for # example custom multicolumn joins currently have no remote field). self.field_name = None
- [a35820a3] def set_field_name(self): self.field_name = self.field_name or self.model._meta.pk.name
- [ef451cc5] """ "Rel objects" for related fields.
- [4b1e5af6] "Rel objects" (for lack of a better name) carry information about the relation modeled by a related field and provide some utility functions. They're stored in the ``remote_field`` attribute of the field.
- [10f46e62] They also act as reverse fields for the purposes of the Meta API because they're the closest concept currently available. """
- [d6b78a3d] class ForeignObjectRel(FieldCacheMixin): """ Used by ForeignObject to store information about the relation.
- [8adc37dd] class ManyToManyRel(ForeignObjectRel): """ Used by ManyToManyField to store information about the relation.
- [4b81bad3] class ManyToOneRel(ForeignObjectRel): """ Used by the ForeignKey field to store information about the relation.
- [a0fcebdb] class OneToOneRel(ManyToOneRel): """ Used by OneToOneField to store information about the relation.
- [7d5c1571] from ..utils import get_blank_choice_label from .mixins import FieldCacheMixin
- [f323cdd1] from django.core import exceptions from django.utils.functional import cached_property from django.utils.hashable import make_hashable
