# django/contrib/admin/forms

- Subject: django/contrib/admin/forms (id `2b3b4a39-f633-478b-b8fd-71c8e703a0e3`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 264 tokens
- Facts shown: 5 facts
- Conflicts: 0
- Gaps: 0

## Facts

- def confirm_login_allowed(self, user): super().confirm_login_allowed(user) if not user.is_staff: raise ValidationError( self.error_messages["invalid_login"], code="invalid_login", params={"username": self.username_field.verbose_name}, ) [011e8a5c]
- error_messages = { **AuthenticationForm.error_messages, "invalid_login": _( "Please enter the correct %(username)s and password for a staff " "account. Note that both fields may be case-sensitive." ), } required_css_class = "required" [86ca46e5]
- class AdminAuthenticationForm(AuthenticationForm): """ A custom authentication form used in the admin app. """ [bc525d5c]
- class AdminPasswordChangeForm(PasswordChangeForm): required_css_class = "required" [9f174a49]
- from django.contrib.auth.forms import AuthenticationForm, PasswordChangeForm from django.core.exceptions import ValidationError from django.utils.translation import gettext_lazy as _ [806fe85f]
