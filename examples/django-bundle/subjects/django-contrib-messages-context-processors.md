# django/contrib/messages/context_processors

- Subject: django/contrib/messages/context_processors (id `b551675a-3f71-424e-a521-43401d6d4c4f`)
- Kind: subject
- Budget: 1200 tokens
- Used: 99 tokens
- Facts shown: 2 of 2
- Conflicts: 0
- Gaps: 0

## Facts

- def messages(request): """ Return a lazy 'messages' context variable as well as 'DEFAULT_MESSAGE_LEVELS'. """ return { "messages": get_messages(request), "DEFAULT_MESSAGE_LEVELS": DEFAULT_LEVELS, } [942ad988]
- from django.contrib.messages.api import get_messages from django.contrib.messages.constants import DEFAULT_LEVELS [5bd70449]
