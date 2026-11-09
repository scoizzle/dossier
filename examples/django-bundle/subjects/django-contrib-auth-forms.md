# django/contrib/auth/forms

- Subject: django/contrib/auth/forms (id `4d83a06f-9cc3-4231-b2f2-063334cda815`)
- Kind: subject
- Budget: 1200 tokens
- Used: 887 tokens
- Facts shown: 15 of 81
- Conflicts: 0
- Gaps: 0

## Facts

- # Set the max length and label for the "username" field. self.username_field = UserModel._meta.get_field(UserModel.USERNAME_FIELD) username_max_length = self.username_field.max_length or 254 self.fields["username"].max_length = username_max_length self.fields["username"].widget.attrs["maxlength"] = username_max_length if self.fields["username"].label is None: self.fields["username"].label = capfirst(self.username_field.verbose_name) [b605206e]
- If the given user cannot log in, this method should raise a ``ValidationError``. [807f3dee]
- If the given user may log in, this method should return None. """ if not user.is_active: raise ValidationError( self.error_messages["inactive"], code="inactive", ) [c72401cd]
- This allows subclasses to more easily customize the default policies that prevent inactive users and users with unusable passwords from resetting their password. """ email_field_name = UserModel.get_email_field_name() active_users = UserModel._default_manager.filter( **{ "%s__iexact" % email_field_name: email, "is_active": True, } ) return ( u for u in active_users if u.has_usable_password() and _unicode_ci_compare(email, getattr(u, email_field_name)) ) [60927ab7]
- email_message = EmailMultiAlternatives(subject, body, from_email, [to_email]) if html_email_template_name is not None: html_email = loader.render_to_string(html_email_template_name, context) email_message.attach_alternative(html_email, "text/html") [a63e7501]
- if not password1 and password1_field_name not in self.errors: error = ValidationError( self.fields[password1_field_name].error_messages["required"], code="required", ) self.add_error(password1_field_name, error) [25dd9ad7]
- if not usable_password: return [0f17cb8e]
- if password1 and password2 and password1 != password2: error = ValidationError( self.error_messages["password_mismatch"], code="password_mismatch", ) self.add_error(password2_field_name, error) [b93c229e]
- if username is not None and password: self.user_cache = authenticate( self.request, username=username, password=password ) if self.user_cache is None: raise self.get_invalid_login_error() else: self.confirm_login_allowed(self.user_cache) [3ed2bc42]
- password1 = self.cleaned_data.get(password1_field_name) password2 = self.cleaned_data.get(password2_field_name) [055be61d]
- return self.cleaned_data [cc4b27e0]
- super().validate_passwords(password1_field_name, password2_field_name) [7d7ec314]
- try: email_message.send() except Exception: logger.exception( "Failed to send password reset email to %s", context["user"].pk ) [1e665429]
- @property def changed_data(self): data = super().changed_data if "set_usable_password" in data or "password1" in data and "password2" in data: return ["password"] return [] [eb9038fe]
- @sensitive_variables("old_password") def clean_old_password(self): """ Validate that the old_password field is correct. """ old_password = self.cleaned_data["old_password"] if not self.user.check_password(old_password): raise ValidationError( self.error_messages["password_incorrect"], code="password_incorrect", ) return old_password [fe219689]

## Beyond the budget

64 more facts did not fit in the budget: [094c1d78] [549c801a] [5d111d47] [b17e6845] [a3eda9e9] [5bf25e22] [4262c18a] [91e62cf7] [ce9ff60d] [59678c39296a52e4] [04ce5a38] [b1d59037] [7860bb2e] [cff1ef7d] [ca6d952d] [6d65d2c3] [67aff269] [fbd8c9d9] [45d53a1b] [0ea594ad] [be9625c2] [05c481d2] [79813533] [7576ba25] [6ed89ed7] [1c2839eb] [20d1d440] [bdf0855e] [4e7f5085] [49b9e532] [f915b023] [77c6bef9] [591f43b9] [2509349d] [ec338b7c] [23a00f2a] [85811f03] [b319f073] [a5ef6eda] [e29c8c79] [7354b239] [fb27d8bf] [66428156] [eef0fcd8] [ad503429] [ec5f180d] [a50c12bc] [b04ef5c4] [eaeec31f] [c923fb59] [bcf381ea] [eaa13932] [3982e864] [18a20366] [244a0842] [bcf55202] [61ca2bd2] [6b5b2964] [55b63a0a] [4016bdee] [1a87c447] [5d65ac9d] [6a5c4091] [3a183579]
