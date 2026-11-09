# django/contrib/postgres/fields/ranges

- Subject: django/contrib/postgres/fields/ranges (id `e7ec2d4f-feaf-4af5-a497-9465e39644e1`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 18 of 61
- Conflicts: 0
- Gaps: 0

## Facts

- @classmethod def _choices_is_value(cls, value): return isinstance(value, (list, tuple)) or super()._choices_is_value(value) [d740b49c35160727-2]
- @model.setter def model(self, model): self.__dict__["model"] = model self.base_field.model = model [5d85b883df2cda2e-2]
- @property def model(self): try: return self.__dict__["model"] except KeyError: raise AttributeError( "'%s' object has no attribute 'model'" % self.__class__.__name__ ) [e369aa7f9e116693-2]
- @property def output_field(self): return self.lhs.output_field.base_field [aa8d02fd38786532]
- def __init__(self, *args, **kwargs): if "default_bounds" in kwargs: raise TypeError( f"Cannot use 'default_bounds' with {self.__class__.__name__}." ) # Initializing base_field here ensures that its model matches the model # for self. if hasattr(self, "base_field"): self.base_field = self.base_field() super().__init__(*args, **kwargs) [a40f2d6f]
- def __init__(self, *args, default_bounds=CANONICAL_RANGE_BOUNDS, **kwargs): if default_bounds not in ("[)", "(]", "()", "[]"): raise ValueError("default_bounds must be one of '[)', '(]', '()', or '[]'.") self.default_bounds = default_bounds super().__init__(*args, **kwargs) [1ebd5ca7]
- def __init__(self, inclusive_lower=True, inclusive_upper=False): self.lower = "[" if inclusive_lower else "(" self.upper = "]" if inclusive_upper else ")" [1618b1f6]
- def as_postgresql(self, compiler, connection): sql, params = super().as_postgresql(compiler, connection) # Cast the rhs if needed. cast_sql = "" if ( isinstance(self.rhs, models.Expression) and self.rhs._output_field_or_none and # Skip cast if rhs has a matching range type. not isinstance( self.rhs._output_field_or_none, self.lhs.output_field.__class__ ) ): cast_internal_type = self.lhs.output_field.base_field.get_internal_type() cast_sql = "::{}".format(connection.data_types.get(cast_internal_type)) return "%s%s" % (sql, cast_sql), params [4111e2be]
- def as_sql(self, compiler, connection): return "'%s%s'" % (self.lower, self.upper), [] [36179e08]
- def db_type(self, connection): return "daterange" [642460e1]
- def db_type(self, connection): return "int4range" [ebcb1d8b]
- def db_type(self, connection): return "int8range" [79cb6a89]
- def db_type(self, connection): return "numrange" [4fc01ac4]
- def db_type(self, connection): return "tstzrange" [46b61f4a]
- def deconstruct(self): name, path, args, kwargs = super().deconstruct() if self.default_bounds and self.default_bounds != CANONICAL_RANGE_BOUNDS: kwargs["default_bounds"] = self.default_bounds return name, path, args, kwargs [720dfae5]
- def formfield(self, **kwargs): kwargs.setdefault("default_bounds", self.default_bounds) return super().formfield(**kwargs) [7f85348a]
- def formfield(self, **kwargs): kwargs.setdefault("form_class", self.form_field) return super().formfield(**kwargs) [821c17c1]
- def get_placeholder_sql(self, value, compiler, connection): db_type = self.db_type(connection) if hasattr(value, "as_sql"): sql, params = compiler.compile(value) return f"{sql}::{db_type}", params return f"%s::{db_type}", (value,) [2345d4a2368c520e-2]

## Beyond the budget

42 more facts did not fit in the budget: [9b1f08e6] [3d3da6d8] [fc9edefd] [683bf800] [05b3bce2] [a3396ef7] [6f7aabf41583b6c2-2] [8fb23b41] [8431dcb1] [cd908a44] [f7da154d] [2b1d427b] [b534e13c] [0822cbc4] [81a00cbd] [2bfceb83] [adf33f1a] [d72925bb] [481378a3] [327cae05] [b6e7a4a4] [0c4e5339] [8cfe962e] [411c17fa] [2ab9012d] [02f48dd7] [e47ea7bb] [2e849311] [7db94bb7] [7e569a41] [3e001f6f] [ba7a2afe] [3c43bed1] [b4433d8a] [e76895b8] [6c9f88f0] [3cdebd8f] [d27a4097] [fbb06f8b02770a61-2] [51668302] [50eb3337] [4ff8400c]
