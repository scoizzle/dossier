# django/contrib/messages/views

- Subject: django/contrib/messages/views (id `a49a7d83-84a5-4a61-94e0-5312582b1355`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 165 tokens
- Facts shown: 5 facts
- Conflicts: 0
- Gaps: 0

## Facts

- def form_valid(self, form): response = super().form_valid(form) success_message = self.get_success_message(form.cleaned_data) if success_message: messages.success(self.request, success_message) return response [184bef35]
- def get_success_message(self, cleaned_data): return self.success_message % cleaned_data [163dff37]
- success_message = "" [83bdfe7c]
- class SuccessMessageMixin: """ Add a success message on successful form submission. """ [ddea3067]
- from django.contrib import messages [f9b61329]
