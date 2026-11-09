# django/forms/models

- Subject: django/forms/models (id `a1cd4592-7f53-4478-aa7d-4d10b8e9fcc5`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 13 of 177
- Conflicts: 0
- Gaps: 0

## Facts

- # Don't perform model validation on fields that were defined # manually on the form and excluded via the ModelForm's Meta # class. See #12901. elif self._meta.fields and field not in self._meta.fields: exclude.add(f.name) elif self._meta.exclude and field in self._meta.exclude: exclude.add(f.name) [b7a243dc]
- # Exclude empty fields that are not required by the form, if the # underlying model field is required. This keeps the model field # from raising a required error. Note: don't exclude the field from # validation if the model field allows blanks. If it does, the # blank value may be included in a unique check, so cannot be # excluded from validation. else: form_field = self.fields[field] field_value = self.cleaned_data.get(field) if ( not f.blank and not form_field.required and field_value in form_field.empty_values ): exclude.add(f.name) return exclude [e6fa8ae0]
- # Exclude fields that failed form validation. There's no need for # the model fields to validate them as well. elif field in self._errors: exclude.add(f.name) [9ec046a7]
- # If the queryset isn't already ordered we need to add an # artificial ordering here to make sure that all formsets # constructed from this queryset have the same form order. if not qs.totally_ordered: current_ordering = qs.query.order_by or qs.model._meta.ordering or [] qs = qs.order_by(*current_ordering, "pk") [ad497f93]
- # Removed queryset limiting here. As per discussion re: #13023 # on django-dev, max_num should not prevent existing # related objects/inlines from being displayed. self._queryset = qs return self._queryset [ecb63ed4]
- # make sure opts.fields doesn't specify an invalid field none_model_fields = {k for k, v in fields.items() if not v} missing_fields = none_model_fields.difference(new_class.declared_fields) if missing_fields: message = "Unknown field(s) (%s) specified for %s" message %= (", ".join(missing_fields), opts.model.__name__) raise FieldError(message) # Include all the other declared fields. fields.update(new_class.declared_fields) else: fields = new_class.declared_fields [63d1849a]
- def save_m2m(): for form in self.saved_forms: form.save_m2m() [39d40920]
- fields = fields_for_model( opts.model, opts.fields, opts.exclude, opts.widgets, opts.formfield_callback, opts.localized_fields, opts.labels, opts.help_texts, opts.error_messages, opts.field_classes, # limit_choices_to will be applied during ModelForm.__init__(). apply_limit_choices_to=False, form_declared_fields=new_class.declared_fields, ) [97212409]
- for message in messages: if ( isinstance(message, ValidationError) and message.code in error_messages ): message.message = error_messages[message.code] [e4f54ee8]
- if opts.fields == ALL_FIELDS: # Sentinel for fields_for_model to indicate "get the list of # fields from the model" opts.fields = None [ece8b3c5]
- if to_field.has_default() and ( # Don't ignore a parent's auto-generated key if it's not the # parent model's pk and form data is provided. to_field.attname == self.fk.remote_field.model._meta.pk.name or not form.data ): setattr(self.instance, to_field.attname, None) [6f0cf46c]
- exclude = self._get_validation_exclusions() [7e5d2355]
- if errors: raise ValidationError(errors) [22c6a0100843fcbe-4]

## Beyond the budget

154 more facts did not fit in the budget: [c3eefc80] [8d4aad1d] [2557decb] [0bde0301] [bd21b09b] [005b5528] [77fbfa24] [96d95ad5] [820673b9] [411ee7b5] [7c945b0c] [ec889ecd] [da9044a0] [c3a99f3e] [2308e21b] [a332dfff] [b392266d] [1cbe6f2d] [50400300] [0bde57ef] [f030694f] [272c327d] [30b31cc4] [9ada69c78b7df1fa-2] [4c906e82] [56d1d7c5] [322691d3] [3ec014b7] [4b835590] [f397c7de] [0f6f17f8] [75ea1a91] [b840f899] [9dd8477c] [0d948836] [452a9377] [bcc938e6] [53c9e0e5] [a3330731b82638b1] [8886f3a4960c3ab6] [e1324f50] [16a6392c] [11c75ecf] [c412c4d6] [198143a4] [58e23c9b] [b73f66a0] [b9d4b5c1a9c7a8f3] [184d62219b3cb639] [89c474e36f3a7f9c] [d85f59833eee5b7f] [1fb45f431c81f469] [cd7e955f] [05ce5582] [29bafc0c] [b3fbc1f8] [a5b7e80a] [c58ded0e] [1ba0bd85] [38837299] [5a9971b4] [42c3279c] [d0461080] [008b05eb] [b79b24f7] [4fef7887] [8d1de78c] [2cf243b5] [c356bbc1] [4d904e9c] [db2e49b4] [5d17c395] [bffaf81b] [80c7933b] [c852ac8e] [6b3fccc9] [71700e3b] [53847abf] [d50d5d10] [981663ef] [b4c4c3b4] [4a6ef68a] [1a1fd7c9] [b50ec794] [e69ea1ef] [6ce78225] [3e46841b] [d3e95c68] [13ae70c7] [2fd92815] [ce0e28d8] [6ef55c69] [f419fd80] [deda98ba] [915c6faa] [fd58fb2e] [6f2b91eff8b83123-2] [8bba83c9] [e3f7f028] [16db7b47] [dfc16f47] [517e0847] [80602381] [d3c04282] [6e6fdbdd] [6a9a6358] [470b6524] [22025a83] [3f1badf5] [99d38273] [fa59d7ba] [f29c0361] [9e9a93b1] [ac139bec] [5832c7d2] [c651d9d4] [0fc72757] [931f01c1] [48538069] [7dc5dfbf] [62dd43db] [f5d522f57fd5e2a5-3] [bab7a55e] [76e92725] [9ebeca52] [a44f37c9] [c067fa3f] [5f504899] [8674aed8] [458fda17] [6f66cf32] [dbc15215] [482ba37f] [c69cab1a] [4d0647e7] [ec9d7368] [e2c3f055] [f2f353c3] [6563ae4b] [1b86e167] [85cf11cd] [634e6297] [e6d1384f] [dde8a087] [e35907e5] [d8678bd7] [b110c06d] [c76836d8] [ffbcb981] [735ec9aa] [aaab03a2] [f9f396e5] [c35eee94] [a79448688635df7c-3]
