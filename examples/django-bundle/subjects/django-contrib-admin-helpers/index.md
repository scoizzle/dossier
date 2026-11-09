# django/contrib/admin/helpers

- Subject: django/contrib/admin/helpers (id `f8651698-88d4-4bae-946a-f8f9cab718cd`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 10 of 57
- Conflicts: 0
- Gaps: 0

## Facts

- field, obj, model_admin = ( self.field["field"], self.form.instance, self.model_admin, ) try: f, attr, value = lookup_field(field, obj, model_admin) except (AttributeError, ValueError, ObjectDoesNotExist): result_repr = self.empty_value_display else: if f is None: if getattr(attr, "boolean", False): result_repr = _boolean_icon(value) else: if hasattr(value, "__html__"): result_repr = value else: result_repr = linebreaksbr(value) else: if isinstance(f.remote_field, ManyToManyRel) and value is not None: result_repr = ", ".join(map(str, value.all())) elif ( isinstance(f.remote_field, (ForeignObjectRel, OneToOneField)) and value is not None ): result_repr = self.get_admin_url(f.remote_field, value) else: result_repr = display_for_field(value, f, self.empty_value_display) result_repr = linebreaksbr(result_repr) return conditional_escape(result_repr) [00cb9072]
- for form, original in zip( self.formset.initial_forms, self.formset.get_queryset() ): view_on_site_url = self.opts.get_view_on_site_url(original) yield InlineAdminForm( self.formset, form, self.fieldsets, self.prepopulated_fields, original, readonly_fields_for_editing, model_admin=self.opts, view_on_site_url=view_on_site_url, ) for form in self.formset.extra_forms: yield InlineAdminForm( self.formset, form, self.fieldsets, self.prepopulated_fields, None, self.readonly_fields, model_admin=self.opts, ) if self.has_add_permission: yield InlineAdminForm( self.formset, self.formset.empty_form, self.fieldsets, self.prepopulated_fields, None, self.readonly_fields, model_admin=self.opts, ) [952ea951]
- if field in form.fields: is_hidden = form.fields[field].widget.is_hidden else: is_hidden = False [8f7193dc]
- if form._meta.help_texts and class_name in form._meta.help_texts: help_text = form._meta.help_texts[class_name] else: help_text = help_text_for_field(class_name, form._meta.model) [cf540ae0]
- if form._meta.labels and class_name in form._meta.labels: label = form._meta.labels[class_name] else: label = label_for_field(field, form._meta.model, model_admin, form=form) [e51ba6a9]
- if form.is_bound: self.extend(form.errors.values()) for inline_formset in inline_formsets: self.extend(inline_formset.non_form_errors()) for errors_in_inline_form in inline_formset.errors: self.extend(errors_in_inline_form.values()) [b5277013]
- if self.field.field.required: classes.append("required") if not self.is_first: classes.append("inline") attrs = {"class": " ".join(classes)} if classes else {} tag = "legend" if self.is_fieldset else None # checkboxes should not have a label suffix as the checkbox appears # to the left of the label. return self.field.label_tag( contents=mark_safe(contents), attrs=attrs, label_suffix="" if self.is_checkbox else None, tag=tag, ) [3d8be7a4]
- return AdminField(self.form, DELETION_FIELD_NAME, False) [5b41b8bf]
- self.field = { "name": class_name, "label": label, "help_text": help_text, "field": field, "is_hidden": is_hidden, } self.form = form self.model_admin = model_admin self.is_first = is_first self.is_checkbox = False self.is_readonly = True self.empty_value_display = model_admin.get_empty_value_display() [fd4a430a]
- @cached_property def is_collapsible(self): if any(field in self.fields for field in self.form.errors): return False return "collapse" in self.classes [1d8d4ad5]

## Beyond the budget

47 more facts did not fit in the budget: [c22ea742] [ea2cda1b] [d88b4aeb] [45554d66] [48877c33] [e9074d48] [93a879b1] [b6b8d206] [e2338bab] [1aa3bda7] [01e7b212] [9c287ded] [9e94a99d] [a455574c] [507858ab] [f23cbdd1] [148f27f5] [a25946c9] [ffaa4cea] [f1a4cde9] [75d7e675] [687d5007] [3418a7b3] [75cc38d3] [15e29eae] [afb54ec0] [6887b61b] [dc8e0485] [574ae7ac] [a4bb8853] [0ef648f3] [4687d921] [1ecf5bd1] [48605710] [31cdf1eb] [49177f7f] [1b3b3cc5] [eccfe0d9] [a7e6e508] [d093725f] [aa6c05a4] [634e67d1] [c887164f] [71b7c2cd] [1864a9b1] [41f89849] [5766bf5bad9de4d2]
