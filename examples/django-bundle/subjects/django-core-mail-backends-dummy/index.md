# django/core/mail/backends/dummy

- Subject: django/core/mail/backends/dummy (id `3a46427a-1ddc-4c44-a50a-3f2ab92dd3ad`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 87 tokens
- Facts shown: 3 facts
- Conflicts: 0
- Gaps: 0

## Facts

- """ Dummy email backend that does nothing. """ [ecc70c1f]
- class EmailBackend(BaseEmailBackend): def send_messages(self, email_messages): return len(list(email_messages)) [3b0b7914]
- from django.core.mail.backends.base import BaseEmailBackend [d74effabf6033594-2]
