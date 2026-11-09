# django/contrib/sessions/management/commands/clearsessions

- Subject: django/contrib/sessions/management/commands/clearsessions (id `ef6810a2-832f-4aca-a477-ce7bf6d18a35`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 177 tokens
- Facts shown: 4 facts
- Conflicts: 0
- Gaps: 0

## Facts

- def handle(self, **options): engine = import_module(settings.SESSION_ENGINE) try: engine.SessionStore.clear_expired() except NotImplementedError: raise CommandError( "Session engine '%s' doesn't support clearing expired " "sessions." % settings.SESSION_ENGINE ) [a66a9aee]
- class Command(BaseCommand): help = ( "Can be run as a cronjob or directly to clean out expired sessions " "when the backend supports it." ) [8e55768f]
- from django.conf import settings from django.core.management.base import BaseCommand, CommandError [048b5a21]
- from importlib import import_module [9bec51b522c69a7b]
