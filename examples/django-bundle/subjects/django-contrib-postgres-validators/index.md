# django/contrib/postgres/validators

- Subject: django/contrib/postgres/validators (id `483d4549-0dad-453a-8200-572a943bb864`)
- Kind: subject
- Budget: 1200 tokens
- Used: 690 tokens
- Facts shown: 12 of 12
- Conflicts: 0
- Gaps: 0

## Facts

- def __call__(self, value): keys = set(value) missing_keys = self.keys - keys if missing_keys: raise ValidationError( self.messages["missing_keys"], code="missing_keys", params={"keys": ", ".join(missing_keys)}, ) if self.strict: extra_keys = keys - self.keys if extra_keys: raise ValidationError( self.messages["extra_keys"], code="extra_keys", params={"keys": ", ".join(extra_keys)}, ) [c4366083]
- def __eq__(self, other): return ( isinstance(other, self.__class__) and self.keys == other.keys and self.messages == other.messages and self.strict == other.strict ) [88752d4d]
- def __init__(self, keys, strict=False, messages=None): self.keys = set(keys) self.strict = strict if messages is not None: self.messages = {**self.messages, **messages} [3cad727b]
- message = _( "Ensure that the lower bound of the range is not less than %(limit_value)s." ) [a044cd8e]
- message = _( "Ensure that the upper bound of the range is not greater than %(limit_value)s." ) [24b3ebd3]
- messages = { "missing_keys": _("Some keys were missing: %(keys)s"), "extra_keys": _("Some unknown keys were provided: %(keys)s"), } strict = False [91c2424c]
- @deconstructible class KeysValidator: """A validator designed for HStore to require/restrict keys.""" [e1e44870]
- class ArrayMaxLengthValidator(MaxLengthValidator): message = ngettext_lazy( "List contains %(show_value)d item, it should contain no more than " "%(limit_value)d.", "List contains %(show_value)d items, it should contain no more than " "%(limit_value)d.", "show_value", ) [878a5e95]
- class ArrayMinLengthValidator(MinLengthValidator): message = ngettext_lazy( "List contains %(show_value)d item, it should contain no fewer than " "%(limit_value)d.", "List contains %(show_value)d items, it should contain no fewer than " "%(limit_value)d.", "show_value", ) [171c0bcb]
- class RangeMaxValueValidator(MaxValueValidator): def compare(self, a, b): return a.upper is None or a.upper > b [1f9597d9]
- class RangeMinValueValidator(MinValueValidator): def compare(self, a, b): return a.lower is None or a.lower < b [ee5da18a]
- from django.core.exceptions import ValidationError from django.core.validators import ( MaxLengthValidator, MaxValueValidator, MinLengthValidator, MinValueValidator, ) from django.utils.deconstruct import deconstructible from django.utils.translation import gettext_lazy as _ from django.utils.translation import ngettext_lazy [adce02a0]
