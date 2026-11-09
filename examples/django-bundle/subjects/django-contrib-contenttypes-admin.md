# django/contrib/contenttypes/admin

- Subject: django/contrib/contenttypes/admin (id `b3f3115b-4843-4c7f-a3c6-395256fe44f5`)
- Kind: subject
- Budget: 1200 tokens
- Used: 833 tokens
- Facts shown: 16 of 18
- Conflicts: 0
- Gaps: 0

## Facts

- # There's one or more GenericForeignKeys; make sure that one of # them uses the right ct_field and ct_fk_field. for gfk in gfks: if gfk.ct_field == obj.ct_field and gfk.fk_field == obj.ct_fk_field: return [] [b2171fd9]
- return [ checks.Error( "'%s' has no GenericForeignKey using content type field '%s' and " "object ID field '%s'." % ( obj.model._meta.label, obj.ct_field, obj.ct_fk_field, ), obj=obj.__class__, id="admin.E304", ) ] [497dd818]
- try: obj.model._meta.get_field(obj.ct_fk_field) except FieldDoesNotExist: return [ checks.Error( "'ct_fk_field' references '%s', which is not a field on '%s'." % ( obj.ct_fk_field, obj.model._meta.label, ), obj=obj.__class__, id="admin.E303", ) ] [42b8587f]
- base_model_form = defaults["form"] can_change = self.has_change_permission(request, obj) if request else True can_add = self.has_add_permission(request, obj) if request else True [6069c5ed]
- class PermissionProtectedModelForm(base_model_form): def has_changed(self): # Protect against unauthorized edits. if not can_change and not self.instance._state.adding: return False if not can_add and self.instance._state.adding: return False return super().has_changed() [6e442a69]
- defaults["form"] = PermissionProtectedModelForm [43b84369]
- gfks = [ f for f in obj.model._meta.private_fields if isinstance(f, GenericForeignKey) ] if not gfks: return [ checks.Error( "'%s' has no GenericForeignKey." % obj.model._meta.label, obj=obj.__class__, id="admin.E301", ) ] else: # Check that the ct_field and ct_fk_fields exist try: obj.model._meta.get_field(obj.ct_field) except FieldDoesNotExist: return [ checks.Error( "'ct_field' references '%s', which is not a field on '%s'." % ( obj.ct_field, obj.model._meta.label, ), obj=obj.__class__, id="admin.E302", ) ] [29d98e83]
- if defaults["fields"] is None and not modelform_defines_fields( defaults["form"] ): defaults["fields"] = ALL_FIELDS [6688bcb5]
- return generic_inlineformset_factory(self.model, **defaults) [ce69c29b]
- checks_class = GenericInlineModelAdminChecks [adecb63a]
- def _check_relation(self, obj, parent_model): # There's no FK, but we do need to confirm that the ct_field and # ct_fk_field are valid, and that they are part of a GenericForeignKey. [36b36486]
- class GenericInlineModelAdmin(InlineModelAdmin): ct_field = "content_type" ct_fk_field = "object_id" formset = BaseGenericInlineFormSet [917055bf]
- class GenericInlineModelAdminChecks(InlineModelAdminChecks): def _check_exclude_of_parent_model(self, obj, parent_model): # There's no FK to exclude, so no exclusion checks are required. return [] [e63555b3]
- class GenericStackedInline(GenericInlineModelAdmin): template = "admin/edit_inline/stacked.html" [247a725c]
- class GenericTabularInline(GenericInlineModelAdmin): template = "admin/edit_inline/tabular.html" [0091b1ea]
- from functools import partial [200ae996befcd23a]

## Beyond the budget

2 more facts did not fit in the budget: [5194dc2d] [c9028f49]
