# django/contrib/admin/__init__

- Subject: django/contrib/admin/__init__ (id `073cd2cf-7a7d-4d79-b86a-a830c5739090`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 307 tokens
- Facts shown: 3 facts
- Conflicts: 0
- Gaps: 0

## Facts

- __all__ = [ "action", "Action", "ActionLocation", "display", "register", "ModelAdmin", "HORIZONTAL", "VERTICAL", "StackedInline", "TabularInline", "AdminSite", "site", "ListFilter", "SimpleListFilter", "FieldListFilter", "BooleanFieldListFilter", "RelatedFieldListFilter", "ChoicesFieldListFilter", "DateFieldListFilter", "AllValuesFieldListFilter", "EmptyFieldListFilter", "RelatedOnlyFieldListFilter", "ShowFacets", "autodiscover", ] [e8564667]
- def autodiscover(): autodiscover_modules("admin", register_to=site) [4fe5179f]
- from django.contrib.admin.decorators import action, display, register from django.contrib.admin.filters import ( AllValuesFieldListFilter, BooleanFieldListFilter, ChoicesFieldListFilter, DateFieldListFilter, EmptyFieldListFilter, FieldListFilter, ListFilter, RelatedFieldListFilter, RelatedOnlyFieldListFilter, SimpleListFilter, ) from django.contrib.admin.options import ( HORIZONTAL, VERTICAL, Action, ActionLocation, ModelAdmin, ShowFacets, StackedInline, TabularInline, ) from django.contrib.admin.sites import AdminSite, site from django.utils.module_loading import autodiscover_modules [690d265d]
