# django/db/models/enums

- Subject: django/db/models/enums (id `32efeae3-68ae-4fe0-97f3-fac93f828074`)
- Kind: subject
- Budget: 1200 tokens
- Used: 668 tokens
- Facts shown: 17 of 17
- Conflicts: 0
- Gaps: 0

## Facts

- # A similar format was proposed for Python 3.10. def __repr__(self): return f"{self.__class__.__qualname__}.{self._name_}" [d4f2b40e79af3ae1-2]
- @enum_property def label(self): return self._label_ [c2496fe9]
- @property def choices(cls): empty = [(None, cls.__empty__)] if hasattr(cls, "__empty__") else [] return empty + [(member.value, member.label) for member in cls] [e741d9e4]
- @property def labels(cls): return [label for _, label in cls.choices] [9157869c]
- @property def names(cls): empty = ["__empty__"] if hasattr(cls, "__empty__") else [] return empty + [member.name for member in cls] [1e1dcb51]
- @property def values(cls): return [value for value, _ in cls.choices] [cfb23bc3]
- @staticmethod def _generate_next_value_(name, start, count, last_values): return name [167baf78]
- def __new__(metacls, classname, bases, classdict, **kwds): labels = [] for key in classdict._member_names: value = classdict[key] if ( isinstance(value, (list, tuple)) and len(value) > 1 and isinstance(value[-1], (Promise, str)) ): *value, label = value value = tuple(value) else: label = key.replace("_", " ").title() labels.append(label) # Use dict.__setitem__() to suppress defenses against double # assignment in enum's classdict. dict.__setitem__(classdict, key, value) cls = super().__new__(metacls, classname, bases, classdict, **kwds) for member, label in zip(cls.__members__.values(), labels): member._label_ = label return enum.unique(cls) [e471b19d]
- do_not_call_in_templates = enum.nonmember(True) [5ecd53aa]
- pass [7655780f0d17b825-48]
- __all__ = ["Choices", "IntegerChoices", "TextChoices"] [5bdd7003]
- class Choices(enum.Enum, metaclass=ChoicesType): """Class for creating enumerated choices.""" [e6ca6332]
- class ChoicesType(EnumType): """A metaclass for creating a enum choices.""" [e434a898]
- class IntegerChoices(Choices, IntEnum): """Class for creating enumerated integer choices.""" [98172200]
- class TextChoices(Choices, StrEnum): """Class for creating enumerated string choices.""" [174b573d]
- from django.utils.functional import Promise [5c7dba87c48e193e]
- import enum from enum import EnumType, IntEnum, StrEnum from enum import property as enum_property [eb516ff6]
