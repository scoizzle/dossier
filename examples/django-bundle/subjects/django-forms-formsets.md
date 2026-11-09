# django/forms/formsets

- Subject: django/forms/formsets (id `8a635685-ec2f-4d61-a804-414057c6a032`)
- Kind: subject
- Budget: 1200 tokens
- Used: 894 tokens
- Facts shown: 12 of 55
- Conflicts: 0
- Gaps: 0

## Facts

- def compare_ordering_key(k): if k[1] is None: return (1, 0) # +infinity, larger than any number return (0, k[1]) [d9dba369]
- self._ordering.sort(key=compare_ordering_key) # Return a list of form.cleaned_data dicts in the order specified by # the form data. return [self.forms[i[0]] for i in self._ordering] [b3bcd4ef]
- for i, form in enumerate(self.forms): # Empty forms are unchanged forms beyond those with initial data. if not form.has_changed() and i >= self.initial_form_count(): empty_forms_count += 1 # Accessing errors calls full_clean() if necessary. # _should_delete_form() requires cleaned_data. form_errors = form.errors if self.can_delete and self._should_delete_form(form): continue self._errors.append(form_errors) try: if ( self.validate_max and self.total_form_count() - len(self.deleted_forms) > self.max_num ) or self.management_form.cleaned_data[ TOTAL_FORM_COUNT ] > self.absolute_max: raise ValidationError( self.error_messages["too_many_forms"] % {"num": self.max_num}, code="too_many_forms", ) if ( self.validate_min and self.total_form_count() - len(self.deleted_forms) - empty_forms_count < self.min_num ): raise ValidationError( self.error_messages["too_few_forms"] % {"num": self.min_num}, code="too_few_forms", ) # Give self.clean() a chance to do cross-form validation. self.clean() except ValidationError as e: self._non_form_errors = self.error_class( e.error_list, error_class="nonform", renderer=self.renderer, ) [503675b9]
- if not self.is_bound: # Stop further processing. return [92808810]
- if not self.management_form.is_valid(): error = ValidationError( self.error_messages["missing_management_form"], params={ "field_names": ", ".join( self.management_form.add_prefix(field_name) for field_name in self.management_form.errors ), }, code="missing_management_form", ) self._non_form_errors.append(error) [0b65a8cd]
- index will be None if the form being constructed is a new empty form. """ return self.form_kwargs.copy() [3a48e33e]
- messages = {} for cls in reversed(type(self).__mro__): messages.update(getattr(cls, "default_error_messages", {})) if error_messages is not None: messages.update(error_messages) self.error_messages = messages [331192a5]
- @cached_property def forms(self): """Instantiate forms at first property access.""" # DoS protection is included in total_form_count() return [ self._construct_form(i, **self.get_form_kwargs(i)) for i in range(self.total_form_count()) ] [9ba61860]
- @cached_property def management_form(self): """Return the ManagementForm instance for this FormSet.""" if self.is_bound: form = ManagementForm( self.data, auto_id=self.auto_id, prefix=self.prefix, renderer=self.renderer, ) form.full_clean() else: form = ManagementForm( auto_id=self.auto_id, prefix=self.prefix, initial={ TOTAL_FORM_COUNT: self.total_form_count(), INITIAL_FORM_COUNT: self.initial_form_count(), MIN_NUM_FORM_COUNT: self.min_num, MAX_NUM_FORM_COUNT: self.max_num, }, renderer=self.renderer, ) return form [8072ccd9]
- @classmethod def get_default_prefix(cls): return "form" [309488a6]
- @classmethod def get_deletion_widget(cls): return cls.deletion_widget [a9b44f4f]
- @classmethod def get_ordering_widget(cls): return cls.ordering_widget [8bcda2f3]

## Beyond the budget

42 more facts did not fit in the budget: [e826da34] [cc7e06db] [b0790311] [6c0cbaf7] [0e794a74] [f8764473] [738bd1a0] [13a4b01b] [a29cc720] [7d0891b5] [33d8b916] [44609eb5] [e29dbdb6] [6f1ead3e] [97c25815] [302ee2bc] [e31f608e] [d4f172ac] [9fe459a3] [19320d51] [f0f29bd2] [934eaba1] [894a9ea6] [71f81c3c] [348ba5c5] [1f0f45ca] [4c51c67e] [a7edd7b7] [0f977cab] [aec86c97] [fde53b42] [b22ab15c] [b5b2638b] [6e55096d] [f7986672] [ceee4fba] [dabea6c2] [f977dd41] [e293a484] [28431c8f] [acdbe8aa] [6ee7f360]
