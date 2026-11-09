# django/contrib/auth/admin

- Subject: django/contrib/auth/admin (id `dd03b2ae-b86e-49b6-abb7-07ad2039eb69`)
- Kind: subject
- Budget: 1200 tokens
- Used: 890 tokens
- Facts shown: 9 of 18
- Conflicts: 0
- Gaps: 0

## Facts

- user = form.save() change_message = self.construct_change_message(request, form, None) self.log_change(request, user, change_message) if user.has_usable_password(): msg = gettext("Password changed successfully.") else: msg = gettext("Password-based authentication was disabled.") messages.success(request, msg) update_session_auth_hash(request, form.user) return HttpResponseRedirect( reverse( "%s:%s_%s_change" % ( self.admin_site.name, user._meta.app_label, user._meta.model_name, ), args=(user.pk,), ) ) else: form = self.change_password_form(user) [d06fbe29]
- fieldsets = [(None, {"fields": list(form.base_fields)})] admin_form = admin.helpers.AdminForm(form, fieldsets, {}) [dec5f47b]
- if user.has_usable_password(): title = _("Change password: %s") else: title = _("Set password: %s") context = { "title": title % escape(user.get_username()), "adminForm": admin_form, "form_url": form_url, "form": form, "is_popup": (IS_POPUP_VAR in request.POST or IS_POPUP_VAR in request.GET), "is_popup_var": IS_POPUP_VAR, "add": True, "change": False, "has_delete_permission": False, "has_change_permission": True, "has_absolute_url": False, "opts": self.opts, "original": user, "save_as": False, "show_save": True, **self.admin_site.each_context(request), } [0ef3280b]
- request.current_app = self.admin_site.name [2bb3ef7bce3635ac-4]
- return TemplateResponse( request, self.change_user_password_template or "admin/auth/user/change_password.html", context, ) [0ea42f54]
- with transaction.atomic(using=router.db_for_write(self.model)): return self._add_view(request, form_url, extra_context) [515d44fe]
- @method_decorator([sensitive_post_parameters(), csrf_protect]) def add_view(self, request, form_url="", extra_context=None): if request.method in ("GET", "HEAD", "OPTIONS", "TRACE"): return self._add_view(request, form_url, extra_context) [d76c4da5]
- @method_decorator(sensitive_post_parameters()) def user_change_password(self, request, id, form_url=""): user = self.get_object(request, unquote(id)) if not self.has_change_permission(request, user): raise PermissionDenied if user is None: raise Http404( _("%(name)s object with primary key %(key)r does not exist.") % { "name": self.opts.verbose_name, "key": escape(id), } ) if request.method == "POST": form = self.change_password_form(user, request.POST) if form.is_valid(): # If disabling password-based authentication was requested # (via the form field `usable_password`), the submit action # must be "unset-password". This check is most relevant when # the admin user has two submit buttons available (for example # when Javascript is disabled). valid_submission = ( form.cleaned_data["set_usable_password"] or "unset-password" in request.POST ) if not valid_submission: msg = gettext("Conflicting form data submitted. Please try again.") messages.error(request, msg) return HttpResponseRedirect(request.get_full_path()) [9a496a62]
- def formfield_for_manytomany(self, db_field, request=None, **kwargs): if db_field.name == "permissions": qs = kwargs.get("queryset", db_field.remote_field.model.objects) # Avoid a major performance hit resolving permission names which # triggers a content_type load: kwargs["queryset"] = qs.select_related("content_type") return super().formfield_for_manytomany(db_field, request=request, **kwargs) [f0ec7c13]

## Beyond the budget

9 more facts did not fit in the budget: [c7b9da25] [956428c6] [b8dfb1b5] [9503e779] [f8c78ac1] [4ecc3055] [6ce2b836] [d37e1feb] [60558f4e]
