# django/contrib/gis/measure

- Subject: django/contrib/gis/measure (id `262723d0-4ab5-4aed-9d97-162df39933ba`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 13 of 39
- Conflicts: 0
- Gaps: 0

## Facts

- # **** Comparison methods **** [e4ae93ab]
- # **** Operators methods **** [ec84f88f]
- # Unit aliases for `UNIT` terms encountered in Spatial Reference WKT. ALIAS = { "centimeter": "cm", "foot": "ft", "inches": "inch", "kilometer": "km", "kilometre": "km", "meter": "m", "metre": "m", "micrometer": "um", "micrometre": "um", "millimeter": "mm", "millimetre": "mm", "mile": "mi", "yard": "yd", "British chain (Benoit 1895 B)": "british_chain_benoit", "British chain (Sears 1922)": "british_chain_sears", "British chain (Sears 1922 truncated)": "british_chain_sears_truncated", "British foot (Sears 1922)": "british_ft", "British foot": "british_ft", "British yard (Sears 1922)": "british_yd", "British yard": "british_yd", "Clarke's Foot": "clarke_ft", "Clarke's link": "clarke_link", "Chain (Benoit)": "chain_benoit", "Chain (Sears)": "chain_sears", "Foot (International)": "ft", "Furrow Long": "furlong", "German legal metre": "german_m", "Gold Coast foot": "gold_coast_ft", "Indian yard": "indian_yd", "Link (Benoit)": "link_benoit", "Link (Sears)": "link_sears", "Nautical Mile": "nm", "Nautical Mile (UK)": "nm_uk", "US survey foot": "survey_ft", "U.S. Foot": "survey_ft", "Yard (Indian)": "indian_yd", "Yard (Sears)": "sears_yd", } LALIAS = {k.lower(): v for k, v in ALIAS.items()} [ea29b42e]
- @classmethod def unit_attname(cls, unit_str): """ Retrieve the unit attribute name for the given unit string. For example, if the given unit string is 'metre', return 'm'. Raise an AttributeError if an attribute cannot be found. """ lower = unit_str.lower() if unit_str in cls.UNITS: return unit_str elif lower in cls.UNITS: return lower elif lower in cls.LALIAS: return cls.LALIAS[lower] else: raise AttributeError(f"Unknown unit type: {unit_str}") [4e467ff7]
- LALIAS = {k.lower(): v for k, v in ALIAS.items()} [8983c963]
- def __add__(self, other): if isinstance(other, self.__class__): return self.__class__( default_unit=self._default_unit, **{self.STANDARD_UNIT: (self.standard + other.standard)}, ) else: raise TypeError( "%(class)s must be added with %(class)s" % {"class": pretty_name(self)} ) [39b34fe2]
- def __bool__(self): return bool(self.standard) [452450bb]
- def __eq__(self, other): if isinstance(other, self.__class__): return self.standard == other.standard else: return NotImplemented [b2218c4b]
- def __getattr__(self, name): if name in self.UNITS: return self.standard / self.UNITS[name] else: raise AttributeError("Unknown unit type: %s" % name) [9be914b6]
- def __hash__(self): return hash(self.standard) [293d689d]
- def __iadd__(self, other): if isinstance(other, self.__class__): self.standard += other.standard return self else: raise TypeError( "%(class)s must be added with %(class)s" % {"class": pretty_name(self)} ) [a0a99af9]
- def __imul__(self, other): if isinstance(other, NUMERIC_TYPES): self.standard *= float(other) return self else: raise TypeError( "%(class)s must be multiplied with number" % {"class": pretty_name(self)} ) [cd0832fd]
- def __init__(self, default_unit=None, **kwargs): value, self._default_unit = self.default_units(kwargs) setattr(self, self.STANDARD_UNIT, value) if default_unit and isinstance(default_unit, str): self._default_unit = default_unit [752e2e4b]

## Beyond the budget

25 more facts did not fit in the budget: [4d32588f] [23cf1235] [271933d6] [dec833e3] [0408e6ff] [18e933c1] [d748d7c9] [b84a233c] [3bacd03e] [21c5301d] [140a8dfe] [d52bedba] [6f2f22ba] [1b1441e0] [65165d30] [425dae5c] [70edb172] [204139ec] [7f9ac9d1] [e4f18c80] [1a5a8460] [af82479c] [bc3e4893] [6fd5935a] [a317a289]
