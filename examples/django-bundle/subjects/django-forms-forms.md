# django/forms/forms

- Subject: django/forms/forms (id `e0c44380-8383-4f68-b057-28af42f58825`)
- Kind: subject
- Budget: 1200 tokens
- Used: 893 tokens
- Facts shown: 11 of 59
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

48 more facts did not fit in the budget: [3b88fe90] [30629879] [a80a6a50] [f1d1d920] [9ada69c78b7df1fa] [675d58ff] [5629ee19] [3a0a8439] [c6c1e29e] [fd42fdda] [134c1b2e] [d45e9a18] [a1f57b51ea7de95b] [26f412b3] [c11754ab] [ff4a9d19] [0a9e6124] [b5104f44] [4f1d51c3] [1439c3e9] [a045047e] [47870585] [bf8a914b] [2bbd1ef1] [ed95f052] [6530549e] [d67acba1] [91287246] [dd207892] [15c163a2] [b94b4525] [71b0eefb] [a4a88f83] [3ec15c71] [bdd7d0ef] [d968038a] [42e067a6] [b95911cb] [1fe42e0c] [be24c6f6] [7ef7281c] [f2b16fbc] [f4450af6] [ec87a2c1] [ac56ead0] [35a56185e9b19e08] [7034c4a9] [ee295430]
