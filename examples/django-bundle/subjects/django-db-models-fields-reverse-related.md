# django/db/models/fields/reverse_related

- Subject: django/db/models/fields/reverse_related (id `7eb4d8c1-584c-4e6b-850a-de340f6ee25b`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 21 of 61
- Conflicts: 0
- Gaps: 0

## Facts

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
- @cached_property def name(self): return self.field.related_query_name() [935564b5]
- @cached_property def one_to_one(self): return self.field.one_to_one [634b2d7a]
- @cached_property def path_infos(self): return self.get_path_info() [758a5f452091b8b4-3]
- @cached_property def related_model(self): if not self.field.model: raise AttributeError( "This property can't be accessed before self.field.contribute_to_class " "has been called." ) return self.field.model [609db578]
- @property def db_type(self): return self.field.db_type [079fb8d8]
- @property def identity(self): return ( *super().identity, self.through, make_hashable(self.through_fields), self.db_constraint, ) [5729d8fc]
- @property def identity(self): return ( self.field, self.model, self.related_name, self.related_query_name, make_hashable(self.limit_choices_to), self.parent_link, self.on_delete, self.symmetrical, self.multiple, ) [95776eee]
- @property def remote_field(self): return self.field [28599ce6]

## Beyond the budget

34 more facts did not fit in the budget: [a3ecee64] [39b7b70e] [c11d430c] [02b1201a] [2d7c403e] [b9bf7147] [34ebb3c5] [35803cb27a9b3f58-2] [0f7f0458] [88edca61] [dca1956e] [9f8ccbc1] [50585228] [d8a8b2a3] [7e038f65] [d53916ca] [7b2a5ba5] [a1068be7] [95929e49] [fa77e773] [1cd9b0dd] [b3fa3ca4] [cb7a37a1] [4ef8b67b] [a35820a3] [ef451cc5] [4b1e5af6] [10f46e62] [d6b78a3d] [8adc37dd] [4b81bad3] [a0fcebdb] [7d5c1571] [f323cdd1]
