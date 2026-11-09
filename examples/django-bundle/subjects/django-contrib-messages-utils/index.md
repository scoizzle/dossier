# django/contrib/messages/utils

- Subject: django/contrib/messages/utils (id `a1918f78-6853-4d7e-a9fd-3b433b315c98`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 75 tokens
- Facts shown: 2 facts
- Conflicts: 0
- Gaps: 0

## Facts

- def get_level_tags(): """ Return the message level tags. """ return { **constants.DEFAULT_TAGS, **getattr(settings, "MESSAGE_TAGS", {}), } [9d0a1297]
- from django.conf import settings from django.contrib.messages import constants [0270fc6d]
