# django/contrib/admin/widgets

- Subject: django/contrib/admin/widgets (id `66c5497d-fe46-4487-9571-088d41a140f2`)
- Kind: subject
- Budget: 1200 tokens
- Used: 885 tokens
- Facts shown: 9 of 80
- Conflicts: 0
- Gaps: 0

## Facts

- params = self.url_parameters() if params: related_url += "?" + urlencode(params) context["related_url"] = related_url context["link_title"] = _("Lookup") # The JavaScript code looks for this class. css_class = "vForeignKeyRawIdAdminField" if isinstance(self.rel.get_related_field(), UUIDField): css_class += " vUUIDField" context["widget"]["attrs"].setdefault("class", css_class) else: context["related_url"] = None if context["widget"]["value"]: context["link_label"], context["link_url"] = self.label_and_url_for_value( value ) else: context["link_label"] = None return context [a08194f5]
- Attributes can be set using the html5 data attribute. Nested attributes require a double dash as per https://select2.org/configuration/data-attributes#nested-subkey-options """ attrs = super().build_attrs(base_attrs, extra_attrs=extra_attrs) attrs.setdefault("class", "") attrs.update( { "data-ajax--cache": "true", "data-ajax--delay": 250, "data-ajax--type": "GET", "data-ajax--url": self.get_url(), "data-app-label": self.field.model._meta.app_label, "data-model-name": self.field.model._meta.model_name, "data-field-name": self.field.name, "data-theme": "admin-autocomplete", "data-allow-clear": json.dumps(not self.is_required), "data-placeholder": "", # Allows clearing of the input. "lang": self.i18n_name, "class": attrs["class"] + (" " if attrs["class"] else "") + "admin-autocomplete", } ) return attrs [d140edcc]
- params = self.base_url_parameters() params.update({TO_FIELD_VAR: self.rel.get_related_field().name}) return params [cd0e13f8]
- rel_opts = self.rel.model._meta info = (rel_opts.app_label, rel_opts.model_name) related_field_name = self.rel.get_related_field().name app_label = self.rel.field.model._meta.app_label model_name = self.rel.field.model._meta.model_name [029826c8]
- return Truncator(obj).words(14), url [8305c046]
- try: url = reverse( "%s:%s_%s_change" % ( self.admin_site.name, obj._meta.app_label, obj._meta.model_name, ), args=(obj.pk,), ) except NoReverseMatch: url = "" # Admin not registered for target model. [09930e6a]
- url_params = "&".join( "%s=%s" % param for param in [ (TO_FIELD_VAR, related_field_name), (IS_POPUP_VAR, 1), (SOURCE_MODEL_VAR, f"{app_label}.{model_name}"), ] ) context = { "rendered_widget": self.widget.render(name, value, attrs), "is_hidden": self.is_hidden, "name": name, "url_params": url_params, "model": rel_opts.verbose_name, "model_name": rel_opts.model_name, "can_add_related": self.can_add_related, "can_change_related": self.can_change_related, "can_delete_related": self.can_delete_related, "can_view_related": self.can_view_related, "model_has_limit_choices_to": self.rel.limit_choices_to, } if self.can_add_related: context["add_related_url"] = self.get_related_url(info, "add") if self.can_delete_related: context["delete_related_template_url"] = self.get_related_url( info, "delete", "__fk__" ) if self.can_view_related or self.can_change_related: context["view_related_url_params"] = f"{TO_FIELD_VAR}={related_field_name}" context["change_related_template_url"] = self.get_related_url( info, "change", "__fk__" ) return context [25d22008]
- @choices.setter def choices(self, value): self.widget.choices = value [18311be3]
- @property def choices(self): return self.widget.choices [f0191091]

## Beyond the budget

70 more facts did not fit in the budget: [e151b4126b88bc16] [7faaba17] [dc077395698011df] [2cd3d058] [f4672408] [606e40a8] [442c0a2b] [da8a0462] [891d1481] [84795a75] [912fc1cb] [680e36b0] [8831b6fb] [df4fc897] [5259a6b6] [be6e2a1c] [3e3989ed] [e82156fe] [a30cbdf6] [b8f44268] [3bebeed2] [46ce2e3d] [a4a5bb45] [6140856b] [72213ff4] [8b769813] [d5151ede] [7e1af501] [bd504a42] [93ad8e19] [cb0aa27e] [e0b6a335] [64036cfe] [33e78e5a] [a1e5870e] [c936fc5c] [6961f33f] [7d4a9106] [9cda38eb] [8a82b7d0] [4dd7e428] [79326702] [d77bac3d] [d7415c32] [36cd1743] [ab43882f] [982d9ed5] [e868a4b7] [28929656] [fb3a763c] [fed3af09] [549ab858] [7d9a1936] [c3b19c92] [e669d65d] [4523abfc] [9f1bca3f] [1b8e688f] [db6eb593] [81ef0be9] [af448bdc] [ba0ea892] [d453060b] [74111cde] [9ac9ae4d] [0f51b033] [bd1e9a89] [22f6b0b3] [70226447] [87a174f0]
