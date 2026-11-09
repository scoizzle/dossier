# django/contrib/postgres/forms/array

- Subject: django/contrib/postgres/forms/array (id `a92dfe69-b038-42a9-aa59-24f3aeb4d61b`)
- Kind: subject
- Budget: 1200 tokens
- Used: 894 tokens
- Facts shown: 12 of 26
- Conflicts: 0
- Gaps: 0

## Facts

- @property def is_hidden(self): return self.widget.is_hidden [e151b4126b88bc16-2]
- @property def media(self): return self.widget.media [dc077395698011df-2]
- @property def needs_multipart_form(self): return self.widget.needs_multipart_form [53475e32]
- def __deepcopy__(self, memo): obj = super().__deepcopy__(memo) obj.widget = copy.deepcopy(self.widget) return obj [ad5ec56a]
- def __init__( self, base_field, *, delimiter=",", max_length=None, min_length=None, **kwargs ): self.base_field = base_field self.delimiter = delimiter super().__init__(**kwargs) if min_length is not None: self.min_length = min_length self.validators.append(ArrayMinLengthValidator(int(min_length))) if max_length is not None: self.max_length = max_length self.validators.append(ArrayMaxLengthValidator(int(max_length))) [ea51f007]
- def __init__(self, base_field, size, *, remove_trailing_nulls=False, **kwargs): self.base_field = base_field self.size = size self.remove_trailing_nulls = remove_trailing_nulls widget = SplitArrayWidget(widget=base_field.widget, size=size) kwargs.setdefault("widget", widget) super().__init__(**kwargs) [7275f760]
- def __init__(self, widget, size, **kwargs): self.widget = widget() if isinstance(widget, type) else widget self.size = size super().__init__(**kwargs) [c4f4efd7]
- def _remove_trailing_nulls(self, values): index = None if self.remove_trailing_nulls: for i, value in reversed(list(enumerate(values))): if value in self.base_field.empty_values: index = i else: break if index is not None: values = values[:index] return values, index [0fac7d28]
- def clean(self, value): cleaned_data = [] errors = [] if not any(value) and self.required: raise ValidationError(self.error_messages["required"]) max_size = max(self.size, len(value)) for index in range(max_size): item = value[index] try: cleaned_data.append(self.base_field.clean(item)) except ValidationError as error: errors.append( prefix_validation_error( error, self.error_messages["item_invalid"], code="item_invalid", params={"nth": index + 1}, ) ) cleaned_data.append(item) else: errors.append(None) cleaned_data, null_index = self._remove_trailing_nulls(cleaned_data) if null_index is not None: errors = errors[:null_index] errors = list(filter(None, errors)) if errors: raise ValidationError(list(chain.from_iterable(errors))) return cleaned_data [857dfe87]
- def clean(self, value): value = super().clean(value) return [self.base_field.clean(val) for val in value] [f03fc696]
- def get_context(self, name, value, attrs=None): attrs = {} if attrs is None else attrs context = super().get_context(name, value, attrs) if self.is_localized: self.widget.is_localized = self.is_localized value = value or [] context["widget"]["subwidgets"] = [] final_attrs = self.build_attrs(attrs) id_ = final_attrs.get("id") for i in range(max(len(value), self.size)): try: widget_value = value[i] except IndexError: widget_value = None if id_: final_attrs = {**final_attrs, "id": "%s_%s" % (id_, i)} context["widget"]["subwidgets"].append( self.widget.get_context(name + "_%s" % i, widget_value, final_attrs)[ "widget" ] ) return context [8e42e90b]
- def id_for_label(self, id_): # See the comment for RadioSelect.id_for_label() if id_: id_ += "_0" return id_ [09f5a8c3]

## Beyond the budget

13 more facts did not fit in the budget: [7e82ddb9] [a932828d] [4b4d501c] [cd75d472] [6fd28d47] [dbcee69e] [96e89215] [0c6dc7be] [6fdd7a81] [367bac30] [c072f89b] [aa18ab2d] [e749c48e]
