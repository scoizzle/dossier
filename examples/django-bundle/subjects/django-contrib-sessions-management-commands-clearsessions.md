# django/contrib/sessions/management/commands/clearsessions

- Subject: django/contrib/sessions/management/commands/clearsessions (id `a5852e19-a0c2-4c97-a58b-7da6306824fa`)
- Kind: subject
- Budget: 1200 tokens
- Used: 177 tokens
- Facts shown: 4 of 4
- Conflicts: 0
- Gaps: 0

## Facts

- def handle(self, **options): engine = import_module(settings.SESSION_ENGINE) try: engine.SessionStore.clear_expired() except NotImplementedError: raise CommandError( "Session engine '%s' doesn't support clearing expired " "sessions." % settings.SESSION_ENGINE ) [a66a9aee]
- class Command(BaseCommand): help = ( "Can be run as a cronjob or directly to clean out expired sessions " "when the backend supports it." ) [8e55768f]
- from django.conf import settings from django.core.management.base import BaseCommand, CommandError [048b5a21]
- from importlib import import_module [9bec51b522c69a7b]
