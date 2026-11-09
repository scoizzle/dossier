# django/contrib/admin/sites

- Subject: django/contrib/admin/sites (id `cbd439e4-ce1d-4e88-892c-acec5253edc2`)
- Kind: subject
- Budget: 1200 tokens
- Used: 895 tokens
- Facts shown: 14 of 95
- Conflicts: 0
- Gaps: 0

## Facts

- urls = super().get_urls() urls += [ path('my_view/', self.admin_view(some_view)) ] return urls [22684b26]
- # Instantiate the admin class to save in the registry self._registry[model] = admin_class(model, self) [abcbbb15]
- def get_urls(self): from django.urls import path [7fe96c3fe54f6174-2]
- return redirect_to_login( request.get_full_path(), reverse("admin:login", current_app=self.name), ) return view(request, *args, **kwargs) [60cd3b20]
- # Check whether user has any perm for this module. # If so, add the module to the model_list. if True not in perms.values(): continue [4e3e0dd2]
- # Ignore the registration if the model has been # swapped out. if not model._meta.swapped: # If we got **options then dynamically construct a subclass of # admin_class with those **options. if options: # For reasons I don't quite understand, without a # __module__ the created class appears to "live" in the # wrong place, which causes issues later on. options["__module__"] = __name__ admin_class = type( "%sAdmin" % model.__name__, (admin_class,), options ) [bfc05800]
- class MyAdminSite(AdminSite): [2cbcac6e]
- has_module_perms = model_admin.has_module_permission(request) if not has_module_perms: continue [0aec5722]
- if app_label in app_dict: app_dict[app_label]["models"].append(model_dict) else: app_dict[app_label] = { "name": apps.get_app_config(app_label).verbose_name, "app_label": app_label, "app_url": reverse( "admin:app_list", kwargs={"app_label": app_label}, current_app=self.name, ), "has_module_perms": has_module_perms, "models": [model_dict], } [48168404]
- if self.is_registered(model): registered_admin = str(self.get_model_admin(model)) msg = "The model %s is already registered " % model.__name__ if registered_admin.endswith(".ModelAdmin"): # Most likely registered without a ModelAdmin subclass. msg += "in app %r." % registered_admin.removesuffix(".ModelAdmin") else: msg += "with %r." % registered_admin raise AlreadyRegistered(msg) [e16c1877]
- info = (app_label, model._meta.model_name) model_dict = { "model": model, "name": capfirst(model._meta.verbose_name_plural), "object_name": model._meta.object_name, "perms": perms, "admin_url": None, "add_url": None, } if perms.get("change") or perms.get("view"): model_dict["view_only"] = not perms.get("change") try: model_dict["admin_url"] = reverse( "admin:%s_%s_changelist" % info, current_app=self.name ) except NoReverseMatch: pass if perms.get("add"): try: model_dict["add_url"] = reverse( "admin:%s_%s_add" % info, current_app=self.name ) except NoReverseMatch: pass [55590f84]
- perms = model_admin.get_model_perms(request) [406e4da7]
- wrapper.admin_site = self # Used by LoginRequiredMiddleware. wrapper.login_url = reverse_lazy("admin:login", current_app=self.name) return update_wrapper(wrapper, view) [9ea5e6e8]
- # Add in each model's views, and create a list of valid URLS for the # app_index valid_app_labels = [] for model, model_admin in self._registry.items(): urlpatterns += [ path( "%s/%s/" % (model._meta.app_label, model._meta.model_name), include(model_admin.urls), ), ] if model._meta.app_label not in valid_app_labels: valid_app_labels.append(model._meta.app_label) [8ae97e80]

## Beyond the budget

80 more facts did not fit in the budget: [ce2bb8dd] [6dddb5d9] [2d7c6f1b] [055c27e2] [f6692e5f] [46f176c4] [b5384ed7] [caf409a3] [425b11d2] [1e6c353e] [6ac3bf62] [ee3963d0] [d172cfa9] [8e35218e] [24e37837] [92d2d2d7] [2816cae7] [6c2b541b] [508a4619] [effdf598] [6eeedc7f] [3fdd0711] [ce2b29b1] [9f707dfa] [aa4d77ff] [48ee5d2f] [43786273] [834ba342] [aa9b1cd6] [eb4914fd755250ce] [de2fcee0] [4a8ba5b8] [bc65e96a] [8e190bfe] [3497b24a] [23c3d3c8] [921d8bd2] [0b3ffb30] [dba8a5c1] [2f383287] [2ef3027f] [0c86985e] [15375a00] [a3db5cf0] [d5754079] [4e5ed078] [0efd1953] [357d28f157a8ff25] [4d336d96] [5254ad99] [ddad30f7] [aac81f31] [023fd0d0] [8bd7280d] [d732a0bd] [885bfa91] [4c25831c] [4a13700f] [35f9b7e5] [ccaaaef3] [e9b95c65] [54c59660] [4c9f26b5] [00fdf12b] [6ded9df8] [e00fa29b] [14ae7c00] [ac5d135e] [3f74ffed] [ccde23a9] [e307e301] [dcae7730] [1ec3a345] [69ac67b5] [f73c8a14] [9aee1efc] [53079f74] [f583f115] [b27989c3] [96745985]
