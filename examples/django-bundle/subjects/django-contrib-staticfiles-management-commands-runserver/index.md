# django/contrib/staticfiles/management/commands/runserver

- Subject: django/contrib/staticfiles/management/commands/runserver (id `a8797ad6-5166-48b4-b847-ad61bc0038c3`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 324 tokens
- Facts shown: 4 facts
- Conflicts: 0
- Gaps: 0

## Facts

- def add_arguments(self, parser): super().add_arguments(parser) parser.add_argument( "--nostatic", action="store_false", dest="use_static_handler", help="Tells Django to NOT automatically serve static files at STATIC_URL.", ) parser.add_argument( "--insecure", action="store_true", dest="insecure_serving", help="Allows serving static files even if DEBUG is False.", ) [02c55b7a]
- def get_handler(self, *args, **options): """ Return the static files serving handler wrapping the default handler, if static files should be served. Otherwise return the default handler. """ handler = super().get_handler(*args, **options) use_static_handler = options["use_static_handler"] insecure_serving = options["insecure_serving"] if use_static_handler and (settings.DEBUG or insecure_serving): return StaticFilesHandler(handler) return handler [c12734a0]
- class Command(RunserverCommand): help = ( "Starts a lightweight web server for development and also serves static files." ) [68d57358]
- from django.conf import settings from django.contrib.staticfiles.handlers import StaticFilesHandler from django.core.management.commands.runserver import Command as RunserverCommand [f872e7e6]
