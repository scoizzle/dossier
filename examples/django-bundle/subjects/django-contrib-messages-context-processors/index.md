# django/contrib/messages/context_processors

- Subject: django/contrib/messages/context_processors (id `cb45841d-274c-4d59-998d-44e5f47d7c19`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 99 tokens
- Facts shown: 2 of 2
- Conflicts: 0
- Gaps: 0

## Facts

- def messages(request): """ Return a lazy 'messages' context variable as well as 'DEFAULT_MESSAGE_LEVELS'. """ return { "messages": get_messages(request), "DEFAULT_MESSAGE_LEVELS": DEFAULT_LEVELS, } [942ad988]
- from django.contrib.messages.api import get_messages from django.contrib.messages.constants import DEFAULT_LEVELS [5bd70449]
