# django/contrib/messages/apps

- Subject: django/contrib/messages/apps (id `0468b3ad-1abd-4d1d-9857-b9718421f2c2`)
- Kind: subject
- Budget: 1200 tokens
- Used: 186 tokens
- Facts shown: 4 of 4
- Conflicts: 0
- Gaps: 0

## Facts

- def ready(self): setting_changed.connect(update_level_tags) [9e51f2eb]
- class MessagesConfig(AppConfig): name = "django.contrib.messages" verbose_name = _("Messages") [8d78c712]
- def update_level_tags(setting, **kwargs): if setting == "MESSAGE_TAGS": base.LEVEL_TAGS = SimpleLazyObject(get_level_tags) [b5c3457e]
- from django.apps import AppConfig from django.contrib.messages.storage import base from django.contrib.messages.utils import get_level_tags from django.core.signals import setting_changed from django.utils.functional import SimpleLazyObject from django.utils.translation import gettext_lazy as _ [b41cacca]
