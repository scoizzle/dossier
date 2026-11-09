# django/contrib/sites/checks

- Subject: django/contrib/sites/checks (id `3b87724b-c8c2-4d8c-9377-3551ab003c8c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 219 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- if hasattr(settings, "SITE_ID"): try: site_id = Site._meta.pk.to_python(settings.SITE_ID) except ValidationError as exc: return [ Error( f"The SITE_ID setting failed to validate: {exc}.", id="sites.E101" ), ] else: # to_python() might coerce a SITE_ID of the wrong type to the valid # type, e.g. "1" to 1 for AutoField. if site_id != settings.SITE_ID: expected_type = type(site_id).__name__ return [ Error( f"The SITE_ID setting must be of type {expected_type}.", id="sites.E101", ), ] return [] [497df3fb]
- def check_site_id(app_configs, **kwargs): # Inner import avoids AppRegistryNotReady from django.contrib.sites.models import Site [30a3b4a3]
- from django.conf import settings from django.core.checks import Error from django.core.exceptions import ValidationError [e57380c7]
