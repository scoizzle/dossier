# django/contrib/contenttypes/apps

- Subject: django/contrib/contenttypes/apps (id `dda0576e-8d56-4cc0-bbb8-39982ac9987a`)
- Kind: subject
- Budget: 1200 tokens
- Used: 239 tokens
- Facts shown: 4 of 4
- Conflicts: 0
- Gaps: 0

## Facts

- def ready(self): pre_migrate.connect(inject_rename_contenttypes_operations, sender=self) post_migrate.connect(create_contenttypes) checks.register(check_generic_foreign_keys, checks.Tags.models) checks.register(check_model_name_lengths, checks.Tags.models) [4a38979c]
- class ContentTypesConfig(AppConfig): default_auto_field = "django.db.models.AutoField" name = "django.contrib.contenttypes" verbose_name = _("Content Types") [115a6f7a]
- from .management import create_contenttypes, inject_rename_contenttypes_operations [a407efbd]
- from django.apps import AppConfig from django.contrib.contenttypes.checks import ( check_generic_foreign_keys, check_model_name_lengths, ) from django.core import checks from django.db.models.signals import post_migrate, pre_migrate from django.utils.translation import gettext_lazy as _ [410b3322]
