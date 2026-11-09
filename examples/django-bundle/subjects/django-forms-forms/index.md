# django/forms/forms

- Subject: django/forms/forms (id `a5b24d7b-131f-48ff-9585-1a2db6ce7260`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 3773 tokens
- Facts shown: 59 of 59
- Conflicts: 0
- Gaps: 0

## Highlights

- # Field shadowing. for attr, value in base.__dict__.items(): if value is None and attr in declared_fields: declared_fields.pop(attr) [a64b09d3]
- # Initialize form renderer. Use a global default if not specified # either as an argument or as self.default_renderer. if renderer is None: if self.default_renderer is None: renderer = get_default_renderer() else: renderer = self.default_renderer if isinstance(self.default_renderer, type): renderer = renderer() self.renderer = renderer [9339c614]
- # The base_fields class attribute is the *class-wide* definition of # fields. Because a particular *instance* of the class might want to # alter self.fields, we create self.fields here by copying base_fields. # Instances should always modify self.fields; they should not modify # self.base_fields. self.fields = copy.deepcopy(self.base_fields) self._bound_fields_cache = {} self.order_fields(self.field_order if field_order is None else field_order) [ea7eda99]
- # Walk through the MRO. declared_fields = {} for base in reversed(new_class.__mro__): # Collect fields from base class. if hasattr(base, "declared_fields"): declared_fields.update(base.declared_fields) [f30f2708]
- If `error` is a dictionary, the `field` argument *must* be None and errors will be added to the fields that correspond to the keys of the dictionary. """ if not isinstance(error, ValidationError): # Normalize to ValidationError and let its constructor # do the hard work of making sense of the input. error = ValidationError(error) [f086aa1a]
- Subclasses may wish to override. """ return "%s-%s" % (self.prefix, field_name) if self.prefix else field_name [42bda2ba]
- The `error` argument can be a single error, a list of errors, or a dictionary that maps field names to lists of errors. An "error" can be either a simple string or an instance of ValidationError with its message attribute set and a "list or dictionary" can be an actual `list` or `dict` or an instance of ValidationError with its `error_list` or `error_dict` attribute set. [fefa48db]
- The `field` argument is the name of the field to which the errors should be added. If it's None, treat the errors as NON_FIELD_ERRORS. [c50b069e]
- field_order is a list of field names specifying the order. Append fields not included in the list in the default order for backward compatibility with subclasses not overriding field_order. If field_order is None, keep all fields in the order defined in the class. Ignore unknown fields in field_order to allow disabling fields in form subclasses without redefining ordering. """ if field_order is None: return fields = {} for key in field_order: try: fields[key] = self.fields.pop(key) except KeyError: # ignore unknown fields pass fields.update(self.fields) # add remaining fields in original order self.fields = fields [5b4bbf22]
- if hasattr(error, "error_dict"): if field is not None: raise TypeError( "The argument `field` must be `None` when the `error` " "argument is a dictionary." ) else: error = error.error_dict else: error = {field or NON_FIELD_ERRORS: error.error_list} [168324d9]
- if self.empty_permitted and self.use_required_attribute: raise ValueError( "The empty_permitted and use_required_attribute arguments may " "not both be True." ) [154e2027]

## All facts

- [3b88fe90] for field, error_list in error.items(): if field not in self.errors: if field != NON_FIELD_ERRORS and field not in self.fields: raise ValueError( "'%s' has no field named '%s'." % (self.__class__.__name__, field) ) if field == NON_FIELD_ERRORS: self._errors[field] = self.error_class( error_class="nonfield", renderer=self.renderer ) else: self._errors[field] = self.error_class( renderer=self.renderer, field_id=self[field].auto_id, ) self._errors[field].extend(error_list) if field in self.cleaned_data: del self.cleaned_data[field]
- [30629879] if use_required_attribute is not None: self.use_required_attribute = use_required_attribute
- [a80a6a50] new_class = super().__new__(mcs, name, bases, attrs)
- [f1d1d920] new_class.base_fields = declared_fields new_class.declared_fields = declared_fields
- [9ada69c78b7df1fa] return new_class
- [675d58ff] self._clean_fields() self._clean_form() self._post_clean()
- [5629ee19] self.bound_field_class = ( bound_field_class or self.bound_field_class or getattr(self.renderer, "bound_field_class", None) )
- [3a0a8439] # This is a separate class from BaseForm in order to abstract the way # self.fields is specified. This class (Form) is the one that does the # fancy metaclass stuff purely for the semantic sugar -- it allows one # to define a form using declarative syntax. # BaseForm itself has no way of designating self.fields.
- [c6c1e29e] @cached_property def changed_data(self): return [name for name, bf in self._bound_items() if bf._has_changed()]
- [fd42fdda] @property def errors(self): """Return an ErrorDict for the data provided for the form.""" if self._errors is None: self.full_clean() return self._errors
- [134c1b2e] @property def media(self): """Return all media required to render the widgets on this form.""" media = Media() for field in self.fields.values(): media += field.widget.media return media
- [d45e9a18] @property def template_name(self): return self.renderer.form_template_name
- [a1f57b51ea7de95b] bound_field_class = None
- [26f412b3] def __getitem__(self, name): """Return a BoundField with the given name.""" try: field = self.fields[name] except KeyError: raise KeyError( "Key '%s' not found in '%s'. Choices are: %s." % ( name, self.__class__.__name__, ", ".join(sorted(self.fields)), ) ) if name not in self._bound_fields_cache: self._bound_fields_cache[name] = field.get_bound_field(self, name) return self._bound_fields_cache[name]
- [c11754ab] def __init__( self, data=None, files=None, auto_id="id_%s", prefix=None, initial=None, error_class=ErrorList, label_suffix=None, empty_permitted=False, field_order=None, use_required_attribute=None, renderer=None, bound_field_class=None, ): self.is_bound = data is not None or files is not None self.data = MultiValueDict() if data is None else data self.files = MultiValueDict() if files is None else files self.auto_id = auto_id if prefix is not None: self.prefix = prefix self.initial = initial or {} self.error_class = error_class # Translators: This is the default suffix added to form field labels self.label_suffix = label_suffix if label_suffix is not None else _(":") self.empty_permitted = empty_permitted self._errors = None # Stores the errors after clean() has been called.
- [ff4a9d19] def __iter__(self): """Yield the form's fields as BoundField objects.""" for name in self.fields: yield self[name]
- [0a9e6124] def __new__(mcs, name, bases, attrs): # Collect fields from current class and remove them from attrs. attrs["declared_fields"] = { key: attrs.pop(key) for key, value in list(attrs.items()) if isinstance(value, Field) }
- [b5104f44] def __repr__(self): if self._errors is None: is_valid = "Unknown" else: is_valid = self.is_bound and not self._errors return "<%(cls)s bound=%(bound)s, valid=%(valid)s, fields=(%(fields)s)>" % { "cls": self.__class__.__name__, "bound": self.is_bound, "valid": is_valid, "fields": ";".join(self.fields), }
- [4f1d51c3] def _bound_items(self): """Yield (name, bf) pairs, where bf is a BoundField object.""" for name in self.fields: yield name, self[name]
- [1439c3e9] def _clean_fields(self): for name, bf in self._bound_items(): field = bf.field try: self.cleaned_data[name] = field._clean_bound_field(bf) if hasattr(self, "clean_%s" % name): value = getattr(self, "clean_%s" % name)() self.cleaned_data[name] = value except ValidationError as e: self.add_error(name, e)
- [a045047e] def _clean_form(self): try: cleaned_data = self.clean() except ValidationError as e: self.add_error(None, e) else: if cleaned_data is not None: self.cleaned_data = cleaned_data
- [47870585] def _post_clean(self): """ An internal hook for performing additional cleaning after form cleaning is complete. Used for model validation in model forms. """ pass
- [bf8a914b] def _widget_data_value(self, widget, html_name): # value_from_datadict() gets the data from the data dictionaries. # Each widget type knows how to retrieve its own data, because some # widgets split data over several HTML fields. return widget.value_from_datadict(self.data, self.files, html_name)
- [2bbd1ef1] def add_error(self, field, error): """ Update the content of `self._errors`.
- [ed95f052] def add_initial_prefix(self, field_name): """Add an 'initial' prefix for checking dynamic initial values.""" return "initial-%s" % self.add_prefix(field_name)
- [6530549e] def add_prefix(self, field_name): """ Return the field name with a prefix appended, if this Form has a prefix set.
- [d67acba1] def clean(self): """ Hook for doing any extra form-wide cleaning after Field.clean() has been called on every field. Any ValidationError raised by this method will not be associated with a particular field; it will have a special-case association with the field named '__all__'. """ return self.cleaned_data
- [91287246] def full_clean(self): """ Clean all of self.data and populate self._errors and self.cleaned_data. """ self._errors = ErrorDict(renderer=self.renderer) if not self.is_bound: # Stop further processing. return self.cleaned_data = {} # If the form is permitted to be empty, and none of the form data has # changed from the initial data, short circuit any validation. if self.empty_permitted and not self.has_changed(): return
- [dd207892] def get_context(self): fields = [] hidden_fields = [] top_errors = self.non_field_errors().copy() for name, bf in self._bound_items(): if bf.is_hidden: if bf.errors: top_errors += [ _("(Hidden field %(name)s) %(error)s") % {"name": name, "error": str(e)} for e in bf.errors ] hidden_fields.append(bf) else: fields.append((bf, bf.errors)) return { "form": self, "fields": fields, "hidden_fields": hidden_fields, "errors": top_errors, }
- [15c163a2] def get_initial_for_field(self, field, field_name): """ Return initial data for field on form. Use initial data from the form or the field, in that order. Evaluate callable values. """ value = self.initial.get(field_name, field.initial) if callable(value): value = value() # If this is an auto-generated default date, nix the microseconds # for standardized handling. See #22502. if ( isinstance(value, (datetime.datetime, datetime.time)) and not field.widget.supports_microseconds ): value = value.replace(microsecond=0) return value
- [b94b4525] def has_changed(self): """Return True if data differs from initial.""" return bool(self.changed_data)
- [71b0eefb] def has_error(self, field, code=None): return field in self.errors and ( code is None or any(error.code == code for error in self.errors.as_data()[field]) )
- [a4a88f83] def hidden_fields(self): """ Return a list of all the BoundField objects that are hidden fields. Useful for manual form layout in templates. """ return [field for field in self if field.is_hidden]
- [3ec15c71] def is_multipart(self): """ Return True if the form needs to be multipart-encoded, i.e. it has FileInput, or False otherwise. """ return any(field.widget.needs_multipart_form for field in self.fields.values())
- [bdd7d0ef] def is_valid(self): """Return True if the form has no errors, or False otherwise.""" return self.is_bound and not self.errors
- [d968038a] def non_field_errors(self): """ Return an ErrorList of errors that aren't associated with a particular field -- i.e., from Form.clean(). Return an empty ErrorList if there are none. """ return self.errors.get( NON_FIELD_ERRORS, self.error_class(error_class="nonfield", renderer=self.renderer), )
- [42e067a6] def order_fields(self, field_order): """ Rearrange the fields according to field_order.
- [b95911cb] def visible_fields(self): """ Return a list of BoundField objects that aren't hidden fields. The opposite of the hidden_fields() method. """ return [field for field in self if not field.is_hidden]
- [1fe42e0c] default_renderer = None field_order = None prefix = None use_required_attribute = True
- [be24c6f6] template_name_div = "django/forms/div.html" template_name_p = "django/forms/p.html" template_name_table = "django/forms/table.html" template_name_ul = "django/forms/ul.html" template_name_label = "django/forms/label.html"
- [7ef7281c] """ Form classes """
- [f2b16fbc] __all__ = ("BaseForm", "Form")
- [f4450af6] class BaseForm(RenderableFormMixin): """ The main implementation of all the Form logic. Note that this class is different than Form. See the comments by the Form class for more info. Any improvements to the form API should be made to this class, not to the Form class. """
- [ec87a2c1] class DeclarativeFieldsMetaclass(MediaDefiningClass): """Collect Fields declared on the base classes."""
- [ac56ead0] class Form(BaseForm, metaclass=DeclarativeFieldsMetaclass): "A collection of Fields, plus their associated data."
- [35a56185e9b19e08] from .renderers import get_default_renderer
- [7034c4a9] from django.core.exceptions import NON_FIELD_ERRORS, ValidationError from django.forms.fields import Field from django.forms.utils import ErrorDict, ErrorList, RenderableFormMixin from django.forms.widgets import Media, MediaDefiningClass from django.utils.datastructures import MultiValueDict from django.utils.functional import cached_property from django.utils.translation import gettext as _
- [ee295430] import copy import datetime
