# django/forms/utils

- Subject: django/forms/utils (id `d2af7ce7-5908-486b-96e1-8db3321c111b`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2124 tokens
- Facts shown: 44 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- if error_class is None: self.error_class = "errorlist" else: self.error_class = "errorlist {}".format(error_class) self.renderer = renderer or get_default_renderer() self.field_id = field_id [b48acc53]
- The dictionary keys are the field names, and the values are the errors. """ [87af5b18]
- The result is passed through 'mark_safe' (by way of 'format_html_join'). """ key_value_attrs = [] boolean_attrs = [] for attr, value in attrs.items(): if isinstance(value, bool): if value: boolean_attrs.append((attr,)) elif value is not None: key_value_attrs.append((attr, value)) [32b79ef5]
- __html__ = __str__ [a1978bfe]
- __str__ = render __html__ = render [c64288d1]
- def __contains__(self, item): return item in list(self) [a824615d]
- def __eq__(self, other): return list(self) == other [9555f912]
- def __getitem__(self, i): error = self.data[i] if isinstance(error, ValidationError): return next(iter(error)) return error [b913d41c]
- def __init__(self, *args, renderer=None, **kwargs): super().__init__(*args, **kwargs) self.renderer = renderer or get_default_renderer() [4ae08be4]
- def __init__(self, initlist=None, error_class=None, renderer=None, field_id=None): super().__init__(initlist) [8de75a94]
- def __reduce_ex__(self, *args, **kwargs): # The `list` reduce function returns an iterator as the fourth element # that is normally used for repopulating. Since we only inherit from # `list` for `isinstance` backward compatibility (Refs #17413) we # nullify this iterator as it would otherwise result in duplicate # entries. (Refs #23594) info = super(UserList, self).__reduce_ex__(*args, **kwargs) return info[:3] + (None, None) [3aee5e5b]
- def __repr__(self): return repr(list(self)) [60f405b3]
- def __str__(self): """Render this field as an HTML widget.""" if self.field.show_hidden_initial: return self.as_widget() + self.as_hidden(only_initial=True) return self.as_widget() [8dbadb24]
- def as_data(self): return ValidationError(self.data).error_list [3dcd3534]
- def as_data(self): return {f: e.as_data() for f, e in self.items()} [888b2f31]
- def as_div(self): """Render as <div> elements.""" return self.render(self.template_name_div) [3f7e9852]
- def as_hidden(self): raise NotImplementedError( "Subclasses of RenderableFieldMixin must provide an as_hidden() method." ) [ca900bb1]
- def as_table(self): """Render as <tr> elements excluding the surrounding <table> tag.""" return self.render(self.template_name_table) [e797daf5]
- def as_text(self): return self.render(self.template_name_text) [699bb2c3]
- def as_ul(self): """Render as <li> elements excluding the surrounding <ul> tag.""" return self.render(self.template_name_ul) [636b65b0]
- def as_ul(self): return self.render(self.template_name_ul) [44bbd853]
- def as_widget(self): raise NotImplementedError( "Subclasses of RenderableFieldMixin must provide an as_widget() method." ) [f2acef77]

## All facts

- [be1a91e3] def copy(self): copy = super().copy() copy.error_class = self.error_class copy.renderer = self.renderer return copy
- [0fa32ed5] def get_context(self): return { "errors": self, "error_class": self.error_class, }
- [72d74876] def get_context(self): return { "errors": self.items(), "error_class": "errorlist", }
- [8180cb00] def get_json_data(self, escape_html=False): errors = [] for error in self.as_data(): message = next(iter(error)) errors.append( { "message": escape(message) if escape_html else message, "code": error.code or "", } ) return errors
- [05247882] def get_json_data(self, escape_html=False): return {f: e.get_json_data(escape_html) for f, e in self.items()}
- [378eb712] def render(self, template_name=None, context=None, renderer=None): renderer = renderer or self.renderer template = template_name or self.template_name context = context or self.get_context() return mark_safe(renderer.render(template, context))
- [8c6f2085] return format_html_join("", ' {}="{}"', sorted(key_value_attrs)) + format_html_join( "", " {}", sorted(boolean_attrs) )
- [8987bbe7] template_name = "django/forms/errors/dict/default.html" template_name_text = "django/forms/errors/dict/text.txt" template_name_ul = "django/forms/errors/dict/ul.html"
- [0001e2df] template_name = "django/forms/errors/list/default.html" template_name_text = "django/forms/errors/list/text.txt" template_name_ul = "django/forms/errors/list/ul.html"
- [11659d16] # Utilities for time zone support in DateTimeField et al.
- [15d0e8a8] class ErrorDict(dict, RenderableErrorMixin): """ A collection of errors that knows how to display itself in various formats.
- [d8de47ab] class ErrorList(UserList, list, RenderableErrorMixin): """ A collection of errors that knows how to display itself in various formats. """
- [59b37967] class RenderableErrorMixin(RenderableMixin): def as_json(self, escape_html=False): return json.dumps(self.get_json_data(escape_html))
- [77f60388] class RenderableFieldMixin(RenderableMixin): def as_field_group(self): return self.render()
- [3158afe8] class RenderableFormMixin(RenderableMixin): def as_p(self): """Render as <p> elements.""" return self.render(self.template_name_p)
- [b1ee11bd] class RenderableMixin: def get_context(self): raise NotImplementedError( "Subclasses of RenderableMixin must provide a get_context() method." )
- [ee73bf0b] def flatatt(attrs): """ Convert a dictionary of attributes to a single string. The returned string will contain a leading space followed by key="value", XML-style pairs. In the case of a boolean value, the key will appear without a value. It is assumed that the keys do not need to be XML-escaped. If the passed dictionary is empty, then return an empty string.
- [1958953c] def from_current_timezone(value): """ When time zone support is enabled, convert naive datetimes entered in the current time zone to aware datetimes. """ if settings.USE_TZ and value is not None and timezone.is_naive(value): current_timezone = timezone.get_current_timezone() try: if timezone._datetime_ambiguous_or_imaginary(value, current_timezone): raise ValueError("Ambiguous or non-existent time.") return timezone.make_aware(value, current_timezone) except Exception as exc: raise ValidationError( _( "%(datetime)s couldn’t be interpreted " "in time zone %(current_timezone)s; it " "may be ambiguous or it may not exist." ), code="ambiguous_timezone", params={"datetime": value, "current_timezone": current_timezone}, ) from exc return value
- [f6a86132] def pretty_name(name): """Convert 'first_name' to 'First name'.""" if not name: return "" return name.replace("_", " ").capitalize()
- [1ce4e094] def to_current_timezone(value): """ When time zone support is enabled, convert aware datetimes to naive datetimes in the current time zone for display. """ if settings.USE_TZ and value is not None and timezone.is_aware(value): return timezone.make_naive(value) return value
- [572c8099] from django.conf import settings from django.core.exceptions import ValidationError from django.forms.renderers import get_default_renderer from django.utils import timezone from django.utils.html import escape, format_html_join from django.utils.safestring import mark_safe from django.utils.translation import gettext_lazy as _
- [04a649b8] import json from collections import UserList
