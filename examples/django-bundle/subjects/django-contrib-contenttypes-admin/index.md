# django/contrib/contenttypes/admin

- Subject: django/contrib/contenttypes/admin (id `60a1230e-c1a0-4a0a-9edf-3ad849bdb0ed`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1236 tokens
- Facts shown: 18 of 18
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [5194dc2d] def get_formset(self, request, obj=None, **kwargs): if "fields" in kwargs: fields = kwargs.pop("fields") else: fields = flatten_fieldsets(self.get_fieldsets(request, obj)) excluded = self.get_exclude(request, obj) exclude = [ *(excluded or []), *self.get_readonly_fields(request, obj), ] if excluded is None and hasattr(self.form, "_meta") and self.form._meta.exclude: # Take the custom ModelForm's Meta.exclude into account only if the # GenericInlineModelAdmin doesn't define its own. exclude.extend(self.form._meta.exclude) exclude = exclude or None can_delete = self.can_delete and self.has_delete_permission(request, obj) defaults = { "ct_field": self.ct_field, "fk_field": self.ct_fk_field, "form": self.form, "formfield_callback": partial(self.formfield_for_dbfield, request=request), "formset": self.formset, "extra": self.get_extra(request, obj), "can_delete": can_delete, "can_order": False, "fields": fields, "min_num": self.get_min_num(request, obj), "max_num": self.get_max_num(request, obj), "exclude": exclude, **kwargs, }
- [c9028f49] from django.contrib.admin.checks import InlineModelAdminChecks from django.contrib.admin.options import InlineModelAdmin, flatten_fieldsets from django.contrib.contenttypes.fields import GenericForeignKey from django.contrib.contenttypes.forms import ( BaseGenericInlineFormSet, generic_inlineformset_factory, ) from django.core import checks from django.core.exceptions import FieldDoesNotExist from django.forms import ALL_FIELDS from django.forms.models import modelform_defines_fields
