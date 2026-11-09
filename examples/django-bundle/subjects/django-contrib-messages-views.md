# django/contrib/messages/views

- Subject: django/contrib/messages/views (id `3bbf98ea-736d-4363-ad3a-8a1647b45265`)
- Kind: subject
- Budget: 1200 tokens
- Used: 165 tokens
- Facts shown: 5 of 5
- Conflicts: 0
- Gaps: 0

## Facts

- def form_valid(self, form): response = super().form_valid(form) success_message = self.get_success_message(form.cleaned_data) if success_message: messages.success(self.request, success_message) return response [184bef35]
- def get_success_message(self, cleaned_data): return self.success_message % cleaned_data [163dff37]
- success_message = "" [83bdfe7c]
- class SuccessMessageMixin: """ Add a success message on successful form submission. """ [ddea3067]
- from django.contrib import messages [f9b61329]
