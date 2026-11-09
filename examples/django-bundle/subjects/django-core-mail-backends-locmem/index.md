# django/core/mail/backends/locmem

- Subject: django/core/mail/backends/locmem (id `65dd4716-d7dc-4f98-a9bd-b212b74b2efe`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 320 tokens
- Facts shown: 8 facts
- Conflicts: 0
- Gaps: 0

## Facts

- # RemovedInDjango2028Warning: *args. (The only supported posarg will be # removed from BaseEmailBackend in Django 2028.) def __init__(self, *args, **kwargs): super().__init__(*args, **kwargs) if not hasattr(mail, "outbox"): mail.outbox = [] [5d2b7532]
- The dummy outbox is accessible through the outbox instance attribute. """ [ab20d73b]
- The test connection stores email messages in a dummy outbox, rather than sending them out on the wire. [971cb50a]
- def send_messages(self, messages): """Redirect messages to the dummy outbox""" msg_count = 0 for message in messages: message.message() # Trigger header validation. msg_copy = copy.deepcopy(message) msg_copy.sent_using = self.alias mail.outbox.append(msg_copy) msg_count += 1 return msg_count [7449743b]
- """ Backend for test environment. """ [c3f20ed6]
- class EmailBackend(BaseEmailBackend): """ An email backend for use during test sessions. [8de5fe8f]
- from django.core import mail from django.core.mail.backends.base import BaseEmailBackend [67b99e05]
- import copy [f73b37390b76138d]
