# django/views/generic/edit

- Subject: django/views/generic/edit (id `eaca8f1f-4a4c-4259-b54a-261dfb874999`)
- Kind: subject
- Budget: 1200 tokens
- Used: 888 tokens
- Facts shown: 16 of 51
- Conflicts: 0
- Gaps: 0

## Facts

- if self.fields is None: raise ImproperlyConfigured( "Using ModelFormMixin (base class of %s) without " "the 'fields' attribute is prohibited." % self.__class__.__name__ ) [a9a67dd4]
- return model_forms.modelform_factory(model, fields=self.fields) [df96be97]
- if self.request.method in ("POST", "PUT"): kwargs.update( { "data": self.request.POST, "files": self.request.FILES, } ) return kwargs [be5f3baf]
- # Add support for browsers which only accept GET and POST for now. def post(self, request, *args, **kwargs): return self.delete(request, *args, **kwargs) [41be494e]
- # PUT is a valid HTTP verb for creating (with a known URL) or editing an # object, note that browsers only support POST for now. def put(self, *args, **kwargs): return self.post(*args, **kwargs) [c5d84966]
- This requires subclassing to provide a response mixin. """ [d4655f33703909eb-10]
- def delete(self, request, *args, **kwargs): """ Call the delete() method on the fetched object and then redirect to the success URL. """ self.object = self.get_object() success_url = self.get_success_url() self.object.delete() return HttpResponseRedirect(success_url) [a311b65c]
- def form_invalid(self, form): """If the form is invalid, render the invalid form.""" return self.render_to_response(self.get_context_data(form=form)) [a79ee8b0]
- def form_valid(self, form): """If the form is valid, redirect to the supplied URL.""" return HttpResponseRedirect(self.get_success_url()) [d31a1bb1]
- def form_valid(self, form): """If the form is valid, save the associated model.""" self.object = form.save() return super().form_valid(form) [dcb9144b]
- def form_valid(self, form): success_url = self.get_success_url() self.object.delete() return HttpResponseRedirect(success_url) [a04d9f52]
- def get(self, request, *args, **kwargs): """Handle GET requests: instantiate a blank version of the form.""" return self.render_to_response(self.get_context_data()) [cedd652d]
- def get(self, request, *args, **kwargs): self.object = None return super().get(request, *args, **kwargs) [ce4361d0]
- def get_context_data(self, **kwargs): """Insert the form into the context dict.""" if "form" not in kwargs: kwargs["form"] = self.get_form() return super().get_context_data(**kwargs) [b5ab5785]
- def get_form(self, form_class=None): """Return an instance of the form to be used in this view.""" if form_class is None: form_class = self.get_form_class() return form_class(**self.get_form_kwargs()) [b9a1ed50]
- def get_form_class(self): """Return the form class to use in this view.""" if self.fields is not None and self.form_class: raise ImproperlyConfigured( "Specifying both 'fields' and 'form_class' is not permitted." ) if self.form_class: return self.form_class else: if self.model is not None: # If a model has been explicitly provided, use it model = self.model elif getattr(self, "object", None) is not None: # If this view is operating on a single object, use # the class of that object model = self.object.__class__ else: # Try to get a queryset and extract the model class # from that model = self.get_queryset().model [9207ef40]

## Beyond the budget

31 more facts did not fit in the budget: [c7f19c7d] [57088388] [85d472db] [63d14d12] [e43adcf0] [acb03bbf] [7f3be0b1] [f728b99f] [a6f7fd58] [11c651ee] [30b78748] [428d768c] [f19afb77] [9463b075] [dd8b929a] [568ecdc9] [69195468] [e55e83e81b3bbb7d] [6e362fd1] [aff73634] [b78a0e38] [f4453fdc] [cd1ea75f] [d15df8bf] [d71e8747] [4eda837f] [10e9262a] [219fee90] [75063d23] [fa5d207f] [e3cd21af]
