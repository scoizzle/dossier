# django/contrib/messages/utils

- Subject: django/contrib/messages/utils (id `fb2a3463-fb54-46d1-9845-63fabc09e130`)
- Kind: subject
- Budget: 1200 tokens
- Used: 75 tokens
- Facts shown: 2 of 2
- Conflicts: 0
- Gaps: 0

## Facts

- def get_level_tags(): """ Return the message level tags. """ return { **constants.DEFAULT_TAGS, **getattr(settings, "MESSAGE_TAGS", {}), } [9d0a1297]
- from django.conf import settings from django.contrib.messages import constants [0270fc6d]
