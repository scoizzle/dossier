# django/contrib/contenttypes/fields

- Subject: django/contrib/contenttypes/fields (id `42c8d570-2fc6-497e-b774-b671309ed3d7`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 14 of 116
- Conflicts: 0
- Gaps: 0

## Facts

- self.remove(*old_objs) self.add(*new_objs, bulk=bulk) [ff9e6cd7]
- self.model._base_manager.using(db).filter(pk__in=pks).update( **{ self.content_type_field_name: self.content_type, self.object_id_field_name: self.pk_val, } ) else: with transaction.atomic(using=db, savepoint=False): for obj in objs: check_and_update_obj(obj) obj.save() [088a4ff1]
- db = router.db_for_write(self.model, instance=self.instance) with transaction.atomic(using=db, savepoint=False): if clear: self.clear() self.add(*objs, bulk=bulk) else: old_objs = set(self.using(db).all()) new_objs = [] for obj in objs: if obj in old_objs: old_objs.remove(obj) else: new_objs.append(obj) [0e5b872b]
- def check_and_update_obj(obj): if not isinstance(obj, self.model): raise TypeError( "'%s' instance expected, got %r" % (self.model._meta.object_name, obj) ) setattr(obj, self.content_type_field_name, self.content_type) setattr(obj, self.object_id_field_name, self.pk_val) [9f562a26]
- def make_generic_foreign_order_accessors(related_model, model): if self._is_matching_generic_foreign_key( model._meta.order_with_respect_to ): make_foreign_order_accessors(model, related_model) [eb98fa42]
- if bulk: pks = [] for obj in objs: if obj._state.adding or obj._state.db != db: raise ValueError( "%r instance isn't saved. Use bulk=False or save " "the object first." % obj ) check_and_update_obj(obj) pks.append(obj.pk) [827512fd]
- lazy_related_operation( make_generic_foreign_order_accessors, self.model, self.remote_field.model, ) [5254f09e]
- ret_val.extend(queryset.fetch_mode(instances[0]._state.fetch_mode)) [d752161b]
- self.core_filters = { "%s__pk" % self.content_type_field_name: self.content_type.id, self.object_id_field_name: self.pk_val, } [aa67f23e]
- self.instance = instance [dfbf7a2c685d65c9]
- self.model = rel.model self.get_content_type = functools.partial( ContentType.objects.db_manager(instance._state.db).get_for_model, for_concrete_model=rel.field.for_concrete_model, ) self.content_type = self.get_content_type(instance) self.content_type_field_name = rel.field.content_type_field_name self.object_id_field_name = rel.field.object_id_field_name self.prefetch_cache_name = rel.field.attname self.pk_val = instance.pk [68e59e09]
- # Add get_RELATED_order() and set_RELATED_order() to the model this # field belongs to, if the model on the other end of this relation # is ordered with respect to its corresponding GenericForeignKey. if not cls._meta.abstract: [d46851cd]
- # Don't use getattr(instance, self.ct_field) here because that might # reload the same ContentType over and over (#5570). Instead, get the # content type ID here, and later when the actual instance is needed, # use ContentType.objects.get_for_id(), which has a global cache. f = self.field.model._meta.get_field(self.field.ct_field) ct_id = getattr(instance, f.attname, None) pk_val = getattr(instance, self.field.fk_field) [1d2c29e4]
- # Reverse relations are always nullable (Django can't enforce that a # foreign key on the related model points to this model). kwargs["null"] = True kwargs["blank"] = True kwargs["on_delete"] = models.CASCADE kwargs["editable"] = False kwargs["serialize"] = False [8ee8a784]

## Beyond the budget

99 more facts did not fit in the budget: [149b21fa] [6a4da346] [7a50f4b4] [b4d3b68eef051f81] [f499c94e23f07ee5] [3a74b1f45ab47fab] [576409106383f1ca] [4f35f36a17cab1a3] [6c126b1d98a061cc] [c9131a0e9b2c331b] [bc48feccc450613f] [3434eecf7cd14c12] [9f3f26cae09870be] [2698ceb5ad4b32cc] [ebc04f4cc76f7fa0] [895f46b98568eca6] [28fc4ccb] [f3750fe957b9e064] [2c650fdeabb2939b] [c62a50b1] [347b90046126c94d] [e4adf9a2] [e589de80] [77c560f5] [347980d3] [764e6034] [8e68aaec] [04d542a0] [f1152df6] [69390d01] [3d7fe9b6] [eacb2df9] [d81b22ed] [86d9f0d0] [fda8c66e065de4e2] [ce9adfa1a6799e1e] [08942695] [630e86e7] [021ded2ac309d7b4] [0e17eecc] [7432df5b] [842d8245] [180d0826c75792e9] [62be44fb] [2e9b28d6d374cb12] [6efcf12a] [9eaae4b79d471c16] [8aa982a1] [d6702543] [03b76986ddf3adcd] [527ebd44] [3427b1fa] [8b69665c] [6cb055affe3d46b9] [a4deab19] [46ac776c] [8b550ae9] [f397fa16] [353b7f5d] [f4c9cebb] [1bfcebca] [d2d6b8bc] [cfaebf94] [2a5b8763] [1cc936b1] [3157e908] [f954b53f] [1dfda774] [d214b79f] [683cc108] [4d29a1428d772041] [f4d03970] [b5dbbce8] [377a2e79] [7b4b5f0f] [7b5db00f] [d9475ad0] [bdc22432] [bffe8a36] [ecf38c9f] [0c994562] [472175b3] [56fac176bcde2407] [d4b06ab4] [93affb1664b85670] [864dda8a] [1a35d3f5] [f882b84d] [1b4e403a] [18b530e5] [79c95ee7] [7e7e1923] [0d881666] [809387f3] [973b65c1] [fa9dd246] [770890ad88958a4c-4] [e5f283cc] [f0770f49]
