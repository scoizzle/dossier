# django/contrib/postgres/forms/ranges

- Subject: django/contrib/postgres/forms/ranges (id `5d9d890a-dcc5-43a5-9d42-2dc09a2520d2`)
- Kind: subject
- Budget: 1200 tokens
- Used: 883 tokens
- Facts shown: 14 of 14
- Conflicts: 0
- Gaps: 0

## Facts

- def __init__(self, **kwargs): if "widget" not in kwargs: kwargs["widget"] = RangeWidget(self.base_field.widget) if "fields" not in kwargs: kwargs["fields"] = [ self.base_field(required=False), self.base_field(required=False), ] kwargs.setdefault("required", False) kwargs.setdefault("require_all_fields", False) self.range_kwargs = {} if default_bounds := kwargs.pop("default_bounds", None): self.range_kwargs = {"bounds": default_bounds} super().__init__(**kwargs) [bd4635bc]
- def __init__(self, attrs=None): super().__init__(HiddenInput, attrs) [708d2018]
- def compress(self, values): if not values: return None lower, upper = values if lower is not None and upper is not None and lower > upper: raise exceptions.ValidationError( self.error_messages["bound_ordering"], code="bound_ordering", ) try: range_value = self.range_type(lower, upper, **self.range_kwargs) except TypeError: raise exceptions.ValidationError( self.error_messages["invalid"], code="invalid", ) else: return range_value [b5355523]
- def decompress(self, value): if value: return (value.lower, value.upper) return (None, None) [b11ab93e]
- def prepare_value(self, value): lower_base, upper_base = self.fields if isinstance(value, self.range_type): return [ lower_base.prepare_value(value.lower), upper_base.prepare_value(value.upper), ] if value is None: return [ lower_base.prepare_value(None), upper_base.prepare_value(None), ] return value [6e2fd89a]
- __all__ = [ "BaseRangeField", "IntegerRangeField", "DecimalRangeField", "DateTimeRangeField", "DateRangeField", "HiddenRangeWidget", "RangeWidget", ] [f1bc73bd]
- class BaseRangeField(forms.MultiValueField): default_error_messages = { "invalid": _("Enter two valid values."), "bound_ordering": _( "The start of the range must not exceed the end of the range." ), } hidden_widget = HiddenRangeWidget [fe414387]
- class DateRangeField(BaseRangeField): default_error_messages = {"invalid": _("Enter two valid dates.")} base_field = forms.DateField range_type = DateRange [fad78dad]
- class DateTimeRangeField(BaseRangeField): default_error_messages = {"invalid": _("Enter two valid date/times.")} base_field = forms.DateTimeField range_type = DateTimeTZRange [30e60d48]
- class DecimalRangeField(BaseRangeField): default_error_messages = {"invalid": _("Enter two numbers.")} base_field = forms.DecimalField range_type = NumericRange [e0f183a7]
- class HiddenRangeWidget(RangeWidget): """A widget that splits input into two <input type="hidden"> inputs.""" [f06d0527]
- class IntegerRangeField(BaseRangeField): default_error_messages = {"invalid": _("Enter two whole numbers.")} base_field = forms.IntegerField range_type = NumericRange [d3f52c6b]
- class RangeWidget(MultiWidget): def __init__(self, base_widget, attrs=None): widgets = (base_widget, base_widget) super().__init__(widgets, attrs) [c5699ef0]
- from django import forms from django.core import exceptions from django.db.backends.postgresql.psycopg_any import ( DateRange, DateTimeTZRange, NumericRange, ) from django.forms.widgets import HiddenInput, MultiWidget from django.utils.translation import gettext_lazy as _ [28f9f4f1]
