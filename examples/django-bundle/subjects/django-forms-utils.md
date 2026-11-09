# django/forms/utils

- Subject: django/forms/utils (id `38fc1d61-6b26-4f91-8e79-56a0bf03f250`)
- Kind: subject
- Budget: 1200 tokens
- Used: 880 tokens
- Facts shown: 22 of 44
- Conflicts: 0
- Gaps: 0

## Facts

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
- def copy(self): copy = super().copy() copy.error_class = self.error_class copy.renderer = self.renderer return copy [be1a91e3]

## Beyond the budget

21 more facts did not fit in the budget: [0fa32ed5] [72d74876] [8180cb00] [05247882] [378eb712] [8c6f2085] [8987bbe7] [0001e2df] [11659d16] [15d0e8a8] [d8de47ab] [59b37967] [77f60388] [3158afe8] [b1ee11bd] [ee73bf0b] [1958953c] [f6a86132] [1ce4e094] [572c8099] [04a649b8]
