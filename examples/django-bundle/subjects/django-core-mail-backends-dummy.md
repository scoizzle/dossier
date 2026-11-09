# django/core/mail/backends/dummy

- Subject: django/core/mail/backends/dummy (id `eef735c8-35a9-4771-a800-982e87d7bc69`)
- Kind: subject
- Budget: 1200 tokens
- Used: 87 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- """ Dummy email backend that does nothing. """ [ecc70c1f]
- class EmailBackend(BaseEmailBackend): def send_messages(self, email_messages): return len(list(email_messages)) [3b0b7914]
- from django.core.mail.backends.base import BaseEmailBackend [d74effabf6033594-2]
