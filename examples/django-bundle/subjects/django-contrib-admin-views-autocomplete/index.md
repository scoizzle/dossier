# django/contrib/admin/views/autocomplete

- Subject: django/contrib/admin/views/autocomplete (id `ead5c992-976f-43cd-bf5e-8374d88924f9`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1051 tokens
- Facts shown: 18 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- # Retrieve objects from parameters. try: source_model = apps.get_model(app_label, model_name) except LookupError as e: raise PermissionDenied from e [e2557ea4]
- # Validate suitability of objects. if not model_admin.get_search_fields(request): raise Http404( "%s must have search_fields for the autocomplete_view." % type(model_admin).__qualname__ ) [0d025f22]
- Raise Http404 if the target model admin is not configured properly with search_fields. """ term = request.GET.get("term", "") try: app_label = request.GET["app_label"] model_name = request.GET["model_name"] field_name = request.GET["field_name"] except KeyError as e: raise PermissionDenied from e [cabe7a1b]
- Since the subsequent view permission check requires the target model admin, which is determined here, raise PermissionDenied if the requested app, model or field are malformed. [ac48b981]
- if not self.has_perm(request): raise PermissionDenied [b5513830]
- return term, model_admin, source_field, to_field_name [455e99d8]
- self.object_list = self.get_queryset() context = self.get_context_data() return JsonResponse( { "results": [ self.serialize_result(obj, to_field_name) for obj in context["object_list"] ], "pagination": {"more": context["page_obj"].has_next()}, } ) [cbeb6d87]
- to_field_name = getattr( source_field.remote_field, "field_name", remote_model._meta.pk.attname ) to_field_name = remote_model._meta.get_field(to_field_name).attname if not model_admin.to_field_allowed(request, to_field_name): raise PermissionDenied [bf0ef5c3]
- try: source_field = source_model._meta.get_field(field_name) except FieldDoesNotExist as e: raise PermissionDenied from e try: remote_model = source_field.remote_field.model except AttributeError as e: raise PermissionDenied from e try: model_admin = self.admin_site.get_model_admin(remote_model) except NotRegistered as e: raise PermissionDenied from e [b31d9c0e]
- def get(self, request, *args, **kwargs): """ Return a JsonResponse with search results as defined in serialize_result(), by default: { results: [{id: "123" text: "foo"}], pagination: {more: true} } """ ( self.term, self.model_admin, self.source_field, to_field_name, ) = self.process_request(request) [13f0ee18]
- def get_paginator(self, *args, **kwargs): """Use the ModelAdmin's paginator.""" return self.model_admin.get_paginator(self.request, *args, **kwargs) [ca498e66]
- def get_queryset(self): """Return queryset based on ModelAdmin.get_search_results().""" qs = self.model_admin.get_queryset(self.request) qs = qs.complex_filter(self.source_field.get_limit_choices_to()) qs, search_use_distinct = self.model_admin.get_search_results( self.request, qs, self.term ) if search_use_distinct: qs = qs.distinct() return qs [4b71d1d8]
- def has_perm(self, request, obj=None): """Check if user has permission to access the related model.""" return self.model_admin.has_view_permission(request, obj=obj) [40822024]
- def process_request(self, request): """ Validate request integrity, extract and return request parameters. [aa56d44d]
- paginate_by = 20 admin_site = None [8ca22c52]

## All facts

- [a002ac4d] def serialize_result(self, obj, to_field_name): """ Convert the provided model object to a dictionary that is added to the results list. """ return {"id": str(getattr(obj, to_field_name)), "text": str(obj)}
- [59f1aef7] class AutocompleteJsonView(BaseListView): """Handle AutocompleteWidget's AJAX requests for data."""
- [3706117b] from django.apps import apps from django.contrib.admin.exceptions import NotRegistered from django.core.exceptions import FieldDoesNotExist, PermissionDenied from django.http import Http404, JsonResponse from django.views.generic.list import BaseListView
