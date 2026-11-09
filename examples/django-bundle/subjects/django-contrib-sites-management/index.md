# django/contrib/sites/management

- Subject: django/contrib/sites/management (id `cf507aea-b969-4c7f-9710-825805c4e8c9`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 408 tokens
- Facts shown: 6 of 6
- Conflicts: 0
- Gaps: 0

## Facts

- # We set an explicit pk instead of relying on auto-incrementation, # so we need to reset the database sequence. See #17415. sequence_sql = connections[using].ops.sequence_reset_sql(no_style(), [Site]) if sequence_sql: if verbosity >= 2: print("Resetting sequence") with connections[using].cursor() as cursor: for command in sequence_sql: cursor.execute(command) [f2747a76]
- if not Site.objects.using(using).exists(): # The default settings set SITE_ID = 1, and some tests in Django's test # suite rely on this value. However, if database sequences are reused # (e.g. in the test suite after flush/syncdb), it isn't guaranteed that # the next id will be 1, so we coerce it. See #15573 and #16353. This # can also crop up outside of tests - see #15346. if verbosity >= 2: print("Creating example.com Site object") Site( pk=getattr(settings, "SITE_ID", 1), domain="example.com", name="example.com" ).save(using=using) [01a62a14]
- if not router.allow_migrate_model(using, Site): return [6dcd201e]
- """ Creates the default Site object. """ [505f0e75]
- def create_default_site( app_config, verbosity=2, interactive=True, using=DEFAULT_DB_ALIAS, apps=global_apps, **kwargs, ): try: Site = apps.get_model("sites", "Site") except LookupError: return [1637e7ab]
- from django.apps import apps as global_apps from django.conf import settings from django.core.management.color import no_style from django.db import DEFAULT_DB_ALIAS, connections, router [ae1c0b32]
