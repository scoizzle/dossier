# django/views/generic/edit

- Subject: django/views/generic/edit (id `98c88ff0-6a0a-425f-8663-cd863d874777`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2388 tokens
- Facts shown: 51 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- if self.fields is None: raise ImproperlyConfigured( "Using ModelFormMixin (base class of %s) without " "the 'fields' attribute is prohibited." % self.__class__.__name__ ) [a9a67dd4]
- return model_forms.modelform_factory(model, fields=self.fields) [df96be97]
- if self.request.method in ("POST", "PUT"): kwargs.update( { "data": self.request.POST, "files": self.request.FILES, } ) return kwargs [be5f3baf]
- # Add support for browsers which only accept GET and POST for now. def post(self, request, *args, **kwargs): return self.delete(request, *args, **kwargs) [41be494e]
- # PUT is a valid HTTP verb for creating (with a known URL) or editing an # object, note that browsers only support POST for now. def put(self, *args, **kwargs): return self.post(*args, **kwargs) [c5d84966]
- This requires subclassing to provide a response mixin. """ [d4655f33703909eb-10]
- This requires subclassing to provide a response mixin. """ [d4655f33703909eb-11]
- This requires subclassing to provide a response mixin. """ [d4655f33703909eb-12]
- def delete(self, request, *args, **kwargs): """ Call the delete() method on the fetched object and then redirect to the success URL. """ self.object = self.get_object() success_url = self.get_success_url() self.object.delete() return HttpResponseRedirect(success_url) [a311b65c]
- def form_invalid(self, form): """If the form is invalid, render the invalid form.""" return self.render_to_response(self.get_context_data(form=form)) [a79ee8b0]
- def form_valid(self, form): """If the form is valid, redirect to the supplied URL.""" return HttpResponseRedirect(self.get_success_url()) [d31a1bb1]
- def form_valid(self, form): """If the form is valid, save the associated model.""" self.object = form.save() return super().form_valid(form) [dcb9144b]
- def form_valid(self, form): success_url = self.get_success_url() self.object.delete() return HttpResponseRedirect(success_url) [a04d9f52]
- def get(self, request, *args, **kwargs): """Handle GET requests: instantiate a blank version of the form.""" return self.render_to_response(self.get_context_data()) [cedd652d]
- def get(self, request, *args, **kwargs): self.object = None return super().get(request, *args, **kwargs) [ce4361d0]
- def get(self, request, *args, **kwargs): self.object = self.get_object() return super().get(request, *args, **kwargs) [bb5961cd]
- def get_context_data(self, **kwargs): """Insert the form into the context dict.""" if "form" not in kwargs: kwargs["form"] = self.get_form() return super().get_context_data(**kwargs) [b5ab5785]
- def get_form(self, form_class=None): """Return an instance of the form to be used in this view.""" if form_class is None: form_class = self.get_form_class() return form_class(**self.get_form_kwargs()) [b9a1ed50]
- def get_form_class(self): """Return the form class to use.""" return self.form_class [c7f19c7d]
- def get_form_kwargs(self): """Return the keyword arguments for instantiating the form.""" kwargs = { "initial": self.get_initial(), "prefix": self.get_prefix(), } [85d472db]

## All facts

- [9207ef40] def get_form_class(self): """Return the form class to use in this view.""" if self.fields is not None and self.form_class: raise ImproperlyConfigured( "Specifying both 'fields' and 'form_class' is not permitted." ) if self.form_class: return self.form_class else: if self.model is not None: # If a model has been explicitly provided, use it model = self.model elif getattr(self, "object", None) is not None: # If this view is operating on a single object, use # the class of that object model = self.object.__class__ else: # Try to get a queryset and extract the model class # from that model = self.get_queryset().model
- [57088388] def get_form_kwargs(self): """Return the keyword arguments for instantiating the form.""" kwargs = super().get_form_kwargs() if hasattr(self, "object"): kwargs.update({"instance": self.object}) return kwargs
- [63d14d12] def get_initial(self): """Return the initial data to use for forms on this view.""" return self.initial.copy()
- [e43adcf0] def get_prefix(self): """Return the prefix to use for forms.""" return self.prefix
- [acb03bbf] def get_success_url(self): """Return the URL to redirect to after processing a valid form.""" if not self.success_url: raise ImproperlyConfigured("No URL to redirect to. Provide a success_url.") return str(self.success_url) # success_url may be lazy
- [7f3be0b1] def get_success_url(self): """Return the URL to redirect to after processing a valid form.""" if self.success_url: url = self.success_url.format(**self.object.__dict__) else: try: url = self.object.get_absolute_url() except AttributeError: raise ImproperlyConfigured( "No URL to redirect to. Either provide a url or define" " a get_absolute_url method on the Model." ) return url
- [f728b99f] def get_success_url(self): if self.success_url: return self.success_url.format(**self.object.__dict__) else: raise ImproperlyConfigured("No URL to redirect to. Provide a success_url.")
- [a6f7fd58] def post(self, request, *args, **kwargs): """ Handle POST requests: instantiate a form instance with the passed POST variables and then check if it's valid. """ form = self.get_form() if form.is_valid(): return self.form_valid(form) else: return self.form_invalid(form)
- [11c651ee] def post(self, request, *args, **kwargs): # Set self.object before the usual form processing flow. # Inlined because having DeletionMixin as the first base, for # get_success_url(), makes leveraging super() with ProcessFormView # overly complex. self.object = self.get_object() form = self.get_form() if form.is_valid(): return self.form_valid(form) else: return self.form_invalid(form)
- [30b78748] def post(self, request, *args, **kwargs): self.object = None return super().post(request, *args, **kwargs)
- [428d768c] def post(self, request, *args, **kwargs): self.object = self.get_object() return super().post(request, *args, **kwargs)
- [f19afb77] fields = None
- [9463b075] form_class = Form
- [dd8b929a] initial = {} form_class = None success_url = None prefix = None
- [568ecdc9] success_url = None
- [69195468] template_name_suffix = "_confirm_delete"
- [e55e83e81b3bbb7d] template_name_suffix = "_form"
- [e55e83e81b3bbb7d-2] template_name_suffix = "_form"
- [6e362fd1] class BaseCreateView(ModelFormMixin, ProcessFormView): """ Base view for creating a new object instance.
- [aff73634] class BaseDeleteView(DeletionMixin, FormMixin, BaseDetailView): """ Base view for deleting an object.
- [b78a0e38] class BaseFormView(FormMixin, ProcessFormView): """A base view for displaying a form."""
- [f4453fdc] class BaseUpdateView(ModelFormMixin, ProcessFormView): """ Base view for updating an existing object.
- [cd1ea75f] class CreateView(SingleObjectTemplateResponseMixin, BaseCreateView): """ View for creating a new object, with a response rendered by a template. """
- [d15df8bf] class DeleteView(SingleObjectTemplateResponseMixin, BaseDeleteView): """ View for deleting an object retrieved with self.get_object(), with a response rendered by a template. """
- [d71e8747] class DeletionMixin: """Provide the ability to delete objects."""
- [4eda837f] class FormMixin(ContextMixin): """Provide a way to show and handle a form in a request."""
- [10e9262a] class FormView(TemplateResponseMixin, BaseFormView): """A view for displaying a form and rendering a template response."""
- [219fee90] class ModelFormMixin(FormMixin, SingleObjectMixin): """Provide a way to show and handle a ModelForm in a request."""
- [75063d23] class ProcessFormView(View): """Render a form on GET and processes it on POST."""
- [fa5d207f] class UpdateView(SingleObjectTemplateResponseMixin, BaseUpdateView): """View for updating an object, with a response rendered by a template."""
- [e3cd21af] from django.core.exceptions import ImproperlyConfigured from django.forms import Form from django.forms import models as model_forms from django.http import HttpResponseRedirect from django.views.generic.base import ContextMixin, TemplateResponseMixin, View from django.views.generic.detail import ( BaseDetailView, SingleObjectMixin, SingleObjectTemplateResponseMixin, )
