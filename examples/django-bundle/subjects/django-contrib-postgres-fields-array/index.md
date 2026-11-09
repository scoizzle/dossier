# django/contrib/postgres/fields/array

- Subject: django/contrib/postgres/fields/array (id `7bedc2ba-11ef-4c40-bb18-7075966d6504`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 17 of 47
- Conflicts: 0
- Gaps: 0

## Facts

- for val in vals: if val is None: values.append(None) else: obj = AttributeSetter(base_field.attname, val) values.append(base_field.value_to_string(obj)) return json.dumps(values, ensure_ascii=False) [7c7987d3]
- @classmethod def _choices_is_value(cls, value): return isinstance(value, (list, tuple)) or super()._choices_is_value(value) [d740b49c35160727]
- @model.setter def model(self, model): self.__dict__["model"] = model self.base_field.model = model [5d85b883df2cda2e]
- @property def description(self): return "Array of %s" % self.base_field.description [b08ce0db]
- @property def model(self): try: return self.__dict__["model"] except KeyError: raise AttributeError( "'%s' object has no attribute 'model'" % self.__class__.__name__ ) [e369aa7f9e116693]
- @property def output_field(self): return self.base_field [5bf8c190]
- def __call__(self, *args, **kwargs): return IndexTransform(self.index, self.base_field, *args, **kwargs) [f2e50264]
- def __call__(self, *args, **kwargs): return SliceTransform(self.start, self.end, *args, **kwargs) [ad1bc4ff]
- def __init__(self, base_field, size=None, **kwargs): self.base_field = base_field self.db_collation = getattr(self.base_field, "db_collation", None) self.size = size if self.size: self.default_validators = [ *self.default_validators, ArrayMaxLengthValidator(self.size), ] # For performance, only add a from_db_value() method if the base field # implements it. if hasattr(self.base_field, "from_db_value"): self.from_db_value = self._from_db_value super().__init__(**kwargs) [7be1e344]
- def _from_db_value(self, value, expression, connection): if value is None: return value return [ self.base_field.from_db_value(item, expression, connection) for item in value ] [1c0ec953]
- def _rhs_not_none_values(self, rhs): for x in rhs: if isinstance(x, (list, tuple)): yield from self._rhs_not_none_values(x) elif x is not None: yield True [90994b10]
- def as_sql(self, compiler, connection): lhs, params = compiler.compile(self.lhs) # Distinguish NULL and empty arrays return ( "CASE WHEN %(lhs)s IS NULL THEN NULL ELSE " "coalesce(array_length(%(lhs)s, 1), 0) END" ) % {"lhs": lhs}, params * 2 [814fea49]
- def as_sql(self, compiler, connection): lhs, params = compiler.compile(self.lhs) # self.start is set to 1 if slice start is not provided. if self.end is None: return f"({lhs})[%s:]", (*params, self.start) else: return f"({lhs})[%s:%s]", (*params, self.start, self.end) [2db59fad]
- def as_sql(self, compiler, connection): lhs, params = compiler.compile(self.lhs) if not lhs.endswith("]"): lhs = "(%s)" % lhs return "%s[%%s]" % lhs, (*params, self.index) [08c032fd]
- def cast_db_type(self, connection): size = self.size or "" return "%s[%s]" % (self.base_field.cast_db_type(connection), size) [9abb3ef0]
- def db_parameters(self, connection): db_params = super().db_parameters(connection) db_params["collation"] = self.db_collation return db_params [2b62b3d8ddb2a195]
- def formfield(self, **kwargs): return super().formfield( **{ "form_class": SimpleArrayField, "base_field": self.base_field.formfield(), "max_length": self.size, **kwargs, } ) [68fddfb0]

## Beyond the budget

28 more facts did not fit in the budget: [906dcfa1] [80410078] [d04ca6ba] [2345d4a2368c520e] [efa5a875] [13e9819a] [42493a16] [6f7aabf41583b6c2] [6d89a908] [fa8673a9] [6100dde2] [425a2822] [26b6219e] [e75849bc] [3c77b7c3] [56735151] [849a4ac5] [c054430a] [a868c4c1] [0b29c4fd] [0bb908ab] [3535d821] [cba88ecd] [51b41844] [92716cad] [fbb06f8b02770a61] [45c9b7fd] [5766bf5bad9de4d2-7]
