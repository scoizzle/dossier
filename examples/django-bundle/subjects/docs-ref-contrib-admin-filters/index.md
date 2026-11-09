# docs/ref/contrib/admin/filters

- Subject: docs/ref/contrib/admin/filters (id `13f890d8-59ae-4e83-a81f-c607178d0b8c`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2304 tokens
- Facts shown: 52 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- def queryset(self, request, queryset): if request.user.is_superuser: return super().queryset(request, queryset) [9c41c79a]
- # Parameter for the filter that will be used in the URL query. parameter_name = "decade" [b57c3710]
- class AdvancedDecadeBornListFilter(DecadeBornListFilter): def lookups(self, request, model_admin): """ Only show the lookups if there actually is anyone born in the corresponding decades. """ qs = model_admin.get_queryset(request) if qs.filter( birthday__gte=date(1980, 1, 1), birthday__lte=date(1989, 12, 31), ).exists(): yield ("80s", _("in the eighties")) if qs.filter( birthday__gte=date(1990, 1, 1), birthday__lte=date(1999, 12, 31), ).exists(): yield ("90s", _("in the nineties")) [9bef9beb]
- class AuthDecadeBornListFilter(DecadeBornListFilter): def lookups(self, request, model_admin): if request.user.is_superuser: return super().lookups(request, model_admin) [d2c79c9a]
- def __init__(self, field, request, params, model, model_admin, field_path): self.lookup_kwarg = "%s__in" % field_path super().__init__(field, request, params, model, model_admin, field_path) [9381f6d1]
- def expected_parameters(self): return [self.lookup_kwarg] [cc22272d]
- def lookups(self, request, model_admin): """ Returns a list of tuples. The first element in each tuple is the coded value for the option that will appear in the URL query. The second element is the human-readable name for the option that will appear in the right sidebar. """ return [ ("80s", _("in the eighties")), ("90s", _("in the nineties")), ] [51960147]
- def queryset(self, request, queryset): """ Returns the filtered queryset based on the value provided in the query string and retrievable via `self.value()`. """ # Compare the requested value (either '80s' or '90s') # to decide how to filter the queryset. if self.value() == "80s": return queryset.filter( birthday__gte=date(1980, 1, 1), birthday__lte=date(1989, 12, 31), ) if self.value() == "90s": return queryset.filter( birthday__gte=date(1990, 1, 1), birthday__lte=date(1999, 12, 31), ) [2f562b52]
- Also as a convenience, the ``ModelAdmin`` object is passed to the ``lookups`` method, for example if you want to base the lookups on the available data:: [756be28b]
- As a convenience, the ``HttpRequest`` object is passed to the ``lookups`` and ``queryset`` methods, for example:: [82119db5]
- The :class:`~django.contrib.contenttypes.fields.GenericForeignKey` field is not supported. [0178ecdf]
- class BookAdmin(admin.ModelAdmin): list_filter = [ ("author", admin.RelatedOnlyFieldListFilter), ] [ab506fac]
- class BookAdmin(admin.ModelAdmin): list_filter = [ ("title", admin.EmptyFieldListFilter), ] [8fd85ec6]
- class DecadeBornListFilter(admin.SimpleListFilter): # Human-readable title which will be displayed in the # right admin sidebar just above the filter options. title = _("decade born") [98cb47e6]
- class FilterWithCustomSeparator(admin.FieldListFilter): # custom list separator that should be used to separate values. list_separator = "|" [fc996948]
- class FilterWithCustomTemplate(admin.SimpleListFilter): template = "custom_template.html" [74515125]

## All facts

- [db3c0265] class PersonAdmin(admin.ModelAdmin): list_filter = [ ("is_staff", admin.BooleanFieldListFilter), ]
- [0f8359de] class PersonAdmin(admin.ModelAdmin): list_filter = ["is_staff", "company"]
- [939d9c38] class PersonAdmin(admin.ModelAdmin): list_filter = [DecadeBornListFilter]
- [e40b77d4] class PersonAdmin(admin.UserAdmin): list_filter = ["company__name"]
- [653c584f] from datetime import date
- [c6908fdc] from django.contrib import admin from django.utils.translation import gettext_lazy as _
- [417d0796] - A field name. - A subclass of ``django.contrib.admin.SimpleListFilter``. - A 2-tuple containing a field name and a subclass of ``django.contrib.admin.FieldListFilter``.
- [52d74332] .. _facet-filters:
- [fd054efc] .. _modeladmin-list-filters:
- [ec0c550817dfd42f-2] .. currentmodule:: django.contrib.admin
- [43209e2b] .. image:: _images/list_filter.png
- [942ae6c11625c81c-33] .. note::
- [942ae6c11625c81c-34] .. note::
- [cd5e8b84] =========================== ``ModelAdmin`` List Filters ===========================
- [7aba7a4c] Assuming ``author`` is a ``ForeignKey`` to a ``User`` model, this will limit the ``list_filter`` choices to the users who have written a book, instead of listing all users.
- [5592bf58] By default, counts for each filter, known as facets, can be shown by toggling on via the admin UI. These counts will update according to the currently applied filters. See :attr:`ModelAdmin.show_facets` for more details.
- [35351f21] By defining a filter using the ``__in`` lookup, it is possible to filter for any of a group of values. You need to override the ``expected_parameters`` method, and then specify the ``lookup_kwargs`` attribute with the appropriate field name. By default, multiple values in the query string will be separated with commas, but this can be customized via the ``list_separator`` attribute. The following example shows such a filter using the vertical-pipe character as the separator::
- [ee478069] Each specified field should be either a ``BooleanField``, ``CharField``, ``DateField``, ``DateTimeField``, ``IntegerField``, ``ForeignKey`` or ``ManyToManyField``, for example::
- [8ae98626] Facets ======
- [2f320e3e] Field names in ``list_filter`` can also span relations using the ``__`` lookup, for example::
- [87f8028a] Finally, if you wish to specify an explicit filter type to use with a field you may provide a ``list_filter`` item as a 2-tuple, where the first element is a field name and the second element is a class inheriting from ``django.contrib.admin.FieldListFilter``, for example::
- [0cd3d05d] For custom filtering, you can define your own list filter by subclassing ``django.contrib.admin.SimpleListFilter``. You need to provide the ``title`` and ``parameter_name`` attributes, and override the ``lookups`` and ``queryset`` methods, e.g.::
- [f7fd3273] Here the ``is_staff`` field will use the ``BooleanFieldListFilter``. Specifying only the field name, fields will automatically use the appropriate filter for most cases, but this format allows you to control the filter used.
- [79979982] It is possible to specify a custom template for rendering a list filter::
- [d660b119] List filters typically appear only if the filter has more than one choice. A filter's ``has_output()`` method controls whether or not it appears.
- [7c27ef60] See the default template provided by Django (``admin/filter.html``) for a concrete example.
- [f6adce8a] See the examples below for discussion of each of these options for defining ``list_filter``.
- [8e6c894d] The following examples show available filter classes that you need to opt-in to use.
- [bd2f22a1] The simplest option is to specify the required field names from your model.
- [8faf9b77] To activate per-field filtering, set :attr:`ModelAdmin.list_filter` to a list or tuple of elements, where each element is one of the following types:
- [fafb40b3] Using a ``SimpleListFilter`` ============================
- [67c28ec4] Using a field name ==================
- [28112a94] Using a field name and an explicit ``FieldListFilter`` ======================================================
- [210794d5] You can filter empty values using ``EmptyFieldListFilter``, which can filter on both empty strings and nulls, depending on what the field allows to store::
- [ca5369d8] You can limit the choices of a related model to the objects involved in that relation using ``RelatedOnlyFieldListFilter``::
- [17cc4f95] ``ModelAdmin`` classes can define list filters that appear in the right sidebar of the change list page of the admin, as illustrated in the following screenshot:
