# django/contrib/admin/checks

- Subject: django/contrib/admin/checks (id `1e15d0e5-9d8c-4677-9ab2-97939fdaf761`)
- Kind: subject
- Budget: 1200 tokens
- Used: 884 tokens
- Facts shown: 10 of 108
- Conflicts: 0
- Gaps: 0

## Facts

- # Validate the field string try: get_fields_from_path(obj.model, field) except (NotRelationField, FieldDoesNotExist): return [ checks.Error( "The value of '%s' refers to '%s', which does not refer to a " "Field." % (label, field), obj=obj.__class__, id="admin.E116", ) ] else: return [] [d4ef41e1]
- # Actions with an allowed_permission attribute require the ModelAdmin # to implement a has_<perm>_permission() method for each permission. for action in actions: if not hasattr(action.func, "allowed_permissions"): continue for permission in action.func.allowed_permissions: method_name = "has_%s_permission" % permission if not hasattr(obj, method_name): errors.append( checks.Error( "%s must define a %s() method for the %s action." % ( obj.__class__.__name__, method_name, action.func.__name__, ), obj=obj.__class__, id="admin.E129", ) ) # Names need to be unique. names = collections.Counter(action.name for action in actions) for name, count in names.items(): if count > 1: errors.append( checks.Error( "__name__ attributes of actions defined in %s must be " "unique. Name %r is not unique." % ( obj.__class__.__name__, name, ), obj=obj.__class__, id="admin.E130", ) ) return errors [9d7af971]
- # Skip if `fk_name` is invalid. if self._check_relation(obj, parent_model): return [] [83635fb6]
- # ordering = None if obj.ordering is None: # The default value is None return [] elif not isinstance(obj.ordering, (list, tuple)): return must_be( "a list or tuple", option="ordering", obj=obj, id="admin.E031" ) else: return list( chain.from_iterable( self._check_ordering_item(obj, field_name, "ordering[%d]" % index) for index, field_name in enumerate(obj.ordering) ) ) [aa460a8e]
- fieldset_fields = flatten(fieldset[1]["fields"]) seen_fields.extend(fieldset_fields) field_counts = collections.Counter(seen_fields) fieldset_fields_set = set(fieldset_fields) if duplicate_fields := [ field for field, count in field_counts.items() if count > 1 and field in fieldset_fields_set ]: return [ checks.Error( "There are duplicate field(s) in '%s[1]'." % label, hint="Remove duplicates of %s." % ", ".join(map(repr, duplicate_fields)), obj=obj.__class__, id="admin.E012", ) ] return list( chain.from_iterable( self._check_field_spec(obj, fieldset_fields, '%s[1]["fields"]' % label) for fieldset_fields in fieldset[1]["fields"] ) ) [3953be83]
- fk = _get_foreign_key(parent_model, obj.model, fk_name=obj.fk_name) if fk.name in obj.exclude: return [ checks.Error( "Cannot exclude the field '%s', because it is the foreign key " "to the parent model '%s'." % ( fk.name, parent_model._meta.label, ), obj=obj.__class__, id="admin.E201", ) ] else: return [] [4fcd365b]
- from django.contrib.admin.options import HORIZONTAL, VERTICAL [ba1e69de]
- from django.contrib.admin.options import InlineModelAdmin [5780c9ee]
- if isinstance(fields, tuple): return list( chain.from_iterable( self._check_field_spec_item( obj, field_name, "%s[%d]" % (label, index) ) for index, field_name in enumerate(fields) ) ) else: return self._check_field_spec_item(obj, fields, label) [3fc4f694]
- if not _issubclass(obj.formset, BaseModelFormSet): return must_inherit_from( parent="BaseModelFormSet", option="formset", obj=obj, id="admin.E206" ) else: return [] [76d1e542]

## Beyond the budget

94 more facts did not fit in the budget: [4e638528] [c5cf8ab8] [628ec41a] [6eb882f4] [9e8066bb] [33a9f426] [695dd818] [6687e5e1] [51206865] [982addf9] [4c60d6d2] [d81cb700] [dd348c30] [60f621cd] [1e954806] [24f98477] [3e800d72] [6cf973bc] [de113c65] [d20b89b8] [4238e537] [c4a8f8fb] [8e11ce1c] [bd4827b8] [c0416717] [3bbe5dd4] [9d0b0630] [0f490476] [7a76c87f] [262f830d] [bb1d76f9] [f47c552e] [51004315] [bc23db1f] [e68a408f] [380bef3c] [d8770130] [3cffecda] [a04060cc] [6e2f6ba4] [f61b6856] [40123973] [c0dea25c] [8fd2ad33] [34b8016d] [54edd3f5] [5705d504] [4addee0c] [e0672902] [58700273] [50598b10] [bb5bf4de] [42877302] [57eb703b] [3d29d9ee] [7b986f31] [c4bd444a] [128e2c14] [5d0873eb] [e710e58a] [6fb6256c] [ece1b3f0] [bdb3864a] [2b842a91] [79efcdcf] [153649f5] [8ca3c0b7] [79762886] [fa48c7af] [b7f2862e] [3caab758] [134bfe73] [bbe9ac9e] [f33ad1dc] [10f189d7] [50e48737] [a1f6b004] [f080244a] [b5fe5d05] [99727ea0] [e43cefef] [b219c943] [5e798f61] [824da490] [a4db36b8] [0507bf69] [2195783f] [5b9c0107] [f9b82960] [5ad621ab] [57fdeac1] [f3950da9] [34a5d6c4] [ca1e80a9]
