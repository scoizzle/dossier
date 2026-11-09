# docs/ref/forms/validation

- Subject: docs/ref/forms/validation (id `31e57e32-9def-407c-98f4-a29f47768127`)
- Kind: subject
- Budget: 1200 tokens
- Used: 893 tokens
- Facts shown: 25 of 92
- Conflicts: 0
- Gaps: 0

## Facts

- # Always return a value to use as the new cleaned data, even if # this method didn't change it. return data [906094bd]
- if urgent and subject and "help" not in subject: self.add_error( "subject", "Must put 'help' in the subject for urgent requests." ) self.add_error( "urgent", "Must not mark urgent unless 'help' is in the subject." ) [dc9b66a8]
- if urgent and subject: # Only do something if both fields are valid so far. if "help" not in subject: raise ValidationError( "Must put 'help' in the subject for urgent requests." ) [30e9c230]
- def clean(self): cleaned_data = super().clean() urgent = cleaned_data.get("urgent") subject = cleaned_data.get("subject") [3c0dd9e59eb33c71]
- def clean_recipients(self): data = self.cleaned_data["recipients"] if not all(email.endswith("@example.com") for email in data): raise ValidationError("All recipients must be @example.com.") [f76e701f]
- def validate(self, value): """Check if value consists only of valid emails.""" # Use the parent's handling of required fields, etc. super().validate(value) for email in value: validate_email(email) [c628633c]
- # Bad ValidationError( _("Invalid value: %s"), params=("42",), ) [a30a81c5]
- # Bad ValidationError("Invalid value") [af508c14]
- # Bad ValidationError(_("Invalid value: %s") % value) [780e060a]
- # Good ValidationError( _("Invalid value: %(value)s"), params={"value": "42"}, ) [1a4fa7db8e9da72e]
- # Good ValidationError(_("Invalid value")) [231030be]
- # Good ValidationError(_("Invalid value"), code="invalid") [ccc081b0]
- # Bad raise ValidationError( [ _("Error 1"), _("Error 2"), ] ) [12c1cc2b]
- # Good raise ValidationError( [ ValidationError(_("Error 1"), code="error1"), ValidationError(_("Error 2"), code="error2"), ] ) [9f6a46c5]
- ValidationError(_("Invalid value: %s") % value) [f4dd216b]
- class ContactForm(forms.Form): # Everything as before. ... [78af0fd413e99702]
- class ContactForm(forms.Form): subject = forms.CharField(max_length=100) message = forms.CharField() contact_email = forms.EmailField() recipients = MultiEmailField() urgent = forms.BooleanField(required=False) [cfc14fcd]
- class MultiEmailField(forms.Field): def to_python(self, value): """Normalize data to a list of strings.""" # Return an empty list if no input was given. if not value: return [] return value.split(",") [07737c13]
- class SlugField(CharField): default_validators = [validators.validate_slug] [45aeff7c]
- from django import forms [9ee3a9405e27875c-6]
- from django import forms from django.core.exceptions import ValidationError [16586e74373992d7]
- from django import forms from django.core.validators import validate_email [775121b8]
- from django.core import validators from django.forms import CharField [30e607bb]
- raise ValidationError( _("Invalid value: %(value)s"), code="invalid", params={"value": "42"}, ) [64524247]
- slug = forms.SlugField() [0c192c1e]

## Beyond the budget

60 more facts did not fit in the budget: [d2f5602e] [d8cfb1ee] [b1e4b9c5] [d7e5f41b] [3dd46d37] [24249028] [2d77e016] [48e0428e] [ab71f0f7] [686e183d] [d73bfe4f] [d28383ba] [2b856a21] [ddd7a135] [14adce87] [07872261] [ae7bfc4b] [2b929197] [a2ffb48b] [23954fefb31ab08f-3] [df7c4ced] [51950eea] [2158ee55] [9320fd6c] [81c571a9] [7c377ee2] [51e8553a] [45059b4e] [8c5e1a66] [400874e0] [1bf66fcd] [ae6511ce] [f23c599f] [3ec46498] [303eb4fd] [4aaa7ac8] [b42ffd55] [e57dc6de] [67db4935] [a77c3be1] [8c2d605b] [b384859e] [b1a9f0ca] [6e03f56f] [5a2056b6] [43f0f031] [7a829965] [c476a272] [3758cd45] [f3af3490] [a7c18c45] [e3591123] [a7230a83] [7f57bf13] [d13f38ca] [629719c3] [e4f07a30] [bced1f0f] [3c236757] [3cc81b7e80043ec5]
