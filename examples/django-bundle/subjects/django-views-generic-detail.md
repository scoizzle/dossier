# django/views/generic/detail

- Subject: django/views/generic/detail (id `4a7e0e85-b2c4-41a1-b7f3-fcc4aebe5f23`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 12 of 26
- Conflicts: 0
- Gaps: 0

## Facts

- # If self.template_name_field is set, grab the value of the field # of that name from the object; this is the most specific template # name, if given. if self.object and self.template_name_field: name = getattr(self.object, self.template_name_field, None) if name: names.insert(0, name) [7e513eee]
- # If we still haven't managed to find any template names, we should # re-raise the ImproperlyConfigured to alert the user. if not names: raise ImproperlyConfigured( "SingleObjectTemplateResponseMixin requires a definition " "of 'template_name', 'template_name_field', or 'model'; " "or an implementation of 'get_template_names()'." ) [f7a547a8]
- # The least-specific option is the default # <app>/<model>_detail.html; only use this if the object in # question is a model. if isinstance(self.object, models.Model): object_meta = self.object._meta names.append( "%s/%s%s.html" % ( object_meta.app_label, object_meta.model_name, self.template_name_suffix, ) ) elif getattr(self, "model", None) is not None and issubclass( self.model, models.Model ): names.append( "%s/%s%s.html" % ( self.model._meta.app_label, self.model._meta.model_name, self.template_name_suffix, ) ) [e9300c0b]
- # If none of those are defined, it's an error. if pk is None and slug is None: raise AttributeError( "Generic detail view %s must be called with either an object " "pk or a slug in the URLconf." % self.__class__.__name__ ) [49b30bce]
- # Next, try looking up by primary key. pk = self.kwargs.get(self.pk_url_kwarg) slug = self.kwargs.get(self.slug_url_kwarg) if pk is not None: queryset = queryset.filter(pk=pk) [b780b0e3]
- # Next, try looking up by slug. if slug is not None and (pk is None or self.query_pk_and_slug): slug_field = self.get_slug_field() queryset = queryset.filter(**{slug_field: slug}) [2bc29db3]
- * the contents of the ``template_name_field`` field on the object instance that the view is operating upon (if available) * ``<app_label>/<model_name><template_name_suffix>.html`` """ try: names = super().get_template_names() except ImproperlyConfigured: # If template_name isn't specified, it's not a problem -- # we just start with an empty list. names = [] [082f4d45]
- Require `self.queryset` and a `pk` or `slug` argument in the URLconf. Subclasses can override this to return any object. """ # Use a custom queryset if provided; this is required for subclasses # like DateDetailView if queryset is None: queryset = self.get_queryset() [eb682467]
- This method is called by the default implementation of get_object() and may not be called if get_object() is overridden. """ if self.queryset is None: if self.model: return self.model._default_manager.all() else: raise ImproperlyConfigured( "%(cls)s is missing a QuerySet. Define " "%(cls)s.model, %(cls)s.queryset, or override " "%(cls)s.get_queryset()." % {"cls": self.__class__.__name__} ) return self.queryset.all() [e758fabd]
- return names [495e9341]
- try: # Get the single item from the filtered queryset obj = queryset.get() except queryset.model.DoesNotExist: raise Http404( _("No %(verbose_name)s found matching the query") % {"verbose_name": queryset.model._meta.verbose_name} ) return obj [2930a271]
- This requires subclassing to provide a response mixin. """ [d4655f33703909eb-9]

## Beyond the budget

14 more facts did not fit in the budget: [bd930545] [e024bd13] [54d58d02] [7720ad11] [c9fd95fb] [db4e3005] [1194cb2a] [fdb63e61] [3f06fbe8] [63836e37] [53212b3e] [52fb1598] [5150fb20] [bc907d1d]
