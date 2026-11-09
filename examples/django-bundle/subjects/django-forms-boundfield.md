# django/forms/boundfield

- Subject: django/forms/boundfield (id `5dcd24e6-5c16-4660-b437-5653b6377e76`)
- Kind: subject
- Budget: 1200 tokens
- Used: 893 tokens
- Facts shown: 12 of 44
- Conflicts: 0
- Gaps: 0

## Facts

- If attrs are given, use them as HTML attributes on the <label> tag. [36c5b80b]
- This property is cached so that only one database query occurs when rendering ModelChoiceFields. """ id_ = self.field.widget.attrs.get("id") or self.auto_id attrs = {"id": id_} if id_ else {} attrs = self.build_widget_attrs(attrs) return [ BoundWidget(self.field.widget, widget, self.form.renderer) for widget in self.field.widget.subwidgets( self.html_name, self.value(), attrs=attrs ) ] [2fc6bb75]
- label_suffix overrides the form's label_suffix. """ contents = contents or self.label if label_suffix is None: label_suffix = ( self.field.label_suffix if self.field.label_suffix is not None else self.form.label_suffix ) # Only add the suffix if the label does not end in punctuation. # Translators: If found as last label character, these punctuation # characters will prevent the default label_suffix to be appended to # the label if label_suffix and contents and contents[-1] not in _(":?.!"): contents = format_html("{}{}", contents, label_suffix) widget = self.field.widget id_ = widget.attrs.get("id") or self.auto_id if id_: attrs = {**(attrs or {})} id_for_label = widget.id_for_label(id_) if id_for_label: if tag != "legend": attrs = {**attrs, "for": id_for_label} if self.field.required and hasattr(self.form, "required_css_class"): if "class" in attrs: attrs["class"] += " " + self.form.required_css_class else: attrs["class"] = self.form.required_css_class context = { "field": self, "label": contents, "attrs": attrs, "use_tag": bool(id_), "tag": tag or "label", } return self.form.render(self.form.template_name_label, context) [536a9b27]
- label_suffix overrides the form's label_suffix. """ return self.label_tag(contents, attrs, label_suffix, tag="legend") [22bc1047]
- @cached_property def initial(self): return self.form.get_initial_for_field(self.field, self.name) [8e8b3847]
- @cached_property def subwidgets(self): """ Most widgets yield a single subwidget, but others like RadioSelect and CheckboxSelectMultiple produce one subwidget for each choice. [30d7fbdf]
- @property def aria_describedby(self): # Preserve aria-describedby set on the widget. if self.field.widget.attrs.get("aria-describedby"): return None aria_describedby = [] if self.auto_id and not self.is_hidden: if self.help_text: aria_describedby.append(f"{self.auto_id}_helptext") if self.errors: aria_describedby.append(f"{self.auto_id}_error") return " ".join(aria_describedby) [4341da44]
- @property def auto_id(self): """ Calculate and return the ID attribute for this BoundField, if the associated Form has specified auto_id. Return an empty string otherwise. """ auto_id = self.form.auto_id # Boolean or string if auto_id and "%s" in str(auto_id): return auto_id % self.html_name elif auto_id: return self.html_name return "" [834233ed]
- @property def choice_label(self): return self.data["label"] [8637e527]
- @property def data(self): """ Return the data for this BoundField, or None if it wasn't given. """ return self.form._widget_data_value(self.field.widget, self.html_name) [709a834d]
- @property def id_for_label(self): return self.data["attrs"].get("id") [ab0ad6a6]
- def __iter__(self): return iter(self.subwidgets) [04af4eed]

## Beyond the budget

30 more facts did not fit in the budget: [64558683] [98ff5b46] [73f01127] [b922286e] [f7fd0433] [67400b52] [6caf6a76] [54d5a817] [5fad8508] [8765d778] [c9f42c21] [cda03f48] [71271e05] [8cee5f4e] [64e36be1] [4e0c78b9] [9d69575d] [36f81b2e] [efa522ee] [e417a9bc] [d2bc2b42] [eedc2381] [fb1f23f9] [62f42ad1] [f990185d] [1bc4f65d] [cbfe2f82] [fc3f909a] [de3741e7] [dae3b101b4aa9562-8]
