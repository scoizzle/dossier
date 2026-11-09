# django/views/generic/list

- Subject: django/views/generic/list (id `dad42f4b-dcd2-42ff-a72d-851fe4e68cc7`)
- Kind: subject
- Budget: 1200 tokens
- Used: 890 tokens
- Facts shown: 10 of 23
- Conflicts: 0
- Gaps: 0

## Facts

- # If the list is a queryset, we'll invent a template name based on the # app and model name. This name gets put at the end of the template # name list so that user-supplied names override the automatically- # generated ones. if hasattr(self.object_list, "model"): opts = self.object_list.model._meta names.append( "%s/%s%s.html" % (opts.app_label, opts.model_name, self.template_name_suffix) ) elif not names: raise ImproperlyConfigured( "%(cls)s requires either a 'template_name' attribute " "or a get_queryset() method that returns a QuerySet." % { "cls": self.__class__.__name__, } ) return names [f810ba4f]
- The return value must be an iterable and may be an instance of `QuerySet` in which case `QuerySet` specific behavior will be enabled. """ if self.queryset is not None: queryset = self.queryset if isinstance(queryset, QuerySet): queryset = queryset.all() elif self.model is not None: queryset = self.model._default_manager.all() else: raise ImproperlyConfigured( "%(cls)s is missing a QuerySet. Define " "%(cls)s.model, %(cls)s.queryset, or override " "%(cls)s.get_queryset()." % {"cls": self.__class__.__name__} ) ordering = self.get_ordering() if ordering: if isinstance(ordering, str): ordering = (ordering,) queryset = queryset.order_by(*ordering) [dfbcc98f]
- if not allow_empty: # When pagination is enabled and object_list is a queryset, # it's better to do a cheap query than to load the unpaginated # queryset in memory. if self.get_paginate_by(self.object_list) is not None and hasattr( self.object_list, "exists" ): is_empty = not self.object_list.exists() else: is_empty = not self.object_list if is_empty: raise Http404( _("Empty list and “%(class_name)s.allow_empty” is False.") % { "class_name": self.__class__.__name__, } ) context = self.get_context_data() return self.render_to_response(context) [9ef51a2d]
- return queryset [c0c05773]
- This requires subclassing to provide a response mixin. """ [d4655f33703909eb-13]
- allow_empty = True queryset = None model = None paginate_by = None paginate_orphans = 0 context_object_name = None paginator_class = Paginator page_kwarg = "page" ordering = None [2f981a1b]
- def get(self, request, *args, **kwargs): self.object_list = self.get_queryset() allow_empty = self.get_allow_empty() [832599ec]
- def get_allow_empty(self): """ Return ``True`` if the view should display empty lists and ``False`` if a 404 should be raised instead. """ return self.allow_empty [194eb139]
- def get_context_data(self, *, object_list=None, **kwargs): """Get the context for this view.""" queryset = object_list if object_list is not None else self.object_list page_size = self.get_paginate_by(queryset) context_object_name = self.get_context_object_name(queryset) if page_size: paginator, page, queryset, is_paginated = self.paginate_queryset( queryset, page_size ) context = { "paginator": paginator, "page_obj": page, "is_paginated": is_paginated, "object_list": queryset, } else: context = { "paginator": None, "page_obj": None, "is_paginated": False, "object_list": queryset, } if context_object_name is not None: context[context_object_name] = queryset context.update(kwargs) return super().get_context_data(**context) [05a79357]
- def get_queryset(self): """ Return the list of items for this view. [90f05136]

## Beyond the budget

13 more facts did not fit in the budget: [c875a666] [5bdfb970] [daee0793] [0faef5ff] [dbf6cf9e] [1c778e64] [42fb2f13] [1fc0463d] [93f520d5] [045f04a9] [78ff2904] [dfb1368b] [7028aa01]
