# docs/ref/contrib/admin/filters

- Subject: docs/ref/contrib/admin/filters (id `62c2003a-46c0-48f8-b27a-4a233f4c1cab`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 16 of 52
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

36 more facts did not fit in the budget: [db3c0265] [0f8359de] [939d9c38] [e40b77d4] [653c584f] [c6908fdc] [417d0796] [52d74332] [fd054efc] [ec0c550817dfd42f-2] [43209e2b] [942ae6c11625c81c-33] [942ae6c11625c81c-34] [cd5e8b84] [7aba7a4c] [5592bf58] [35351f21] [ee478069] [8ae98626] [2f320e3e] [87f8028a] [0cd3d05d] [f7fd3273] [79979982] [d660b119] [7c27ef60] [f6adce8a] [8e6c894d] [bd2f22a1] [8faf9b77] [fafb40b3] [67c28ec4] [28112a94] [210794d5] [ca5369d8] [17cc4f95]
