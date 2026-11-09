# django/core/management/commands/testserver

- Subject: django/core/management/commands/testserver (id `af75eab8-fb1b-4787-88fb-83666a5539c4`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 512 tokens
- Facts shown: 8 facts
- Conflicts: 0
- Gaps: 0

## Facts

- # Create a test database. db_name = connection.creation.create_test_db( verbosity=verbosity, autoclobber=not interactive ) [32820409]
- # Import the fixture data into the test database. call_command("loaddata", *fixture_labels, verbosity=verbosity) [2618163c]
- # Run the development server. Turn off auto-reloading because it causes # a strange error -- it causes this handle() method to be called # multiple times. shutdown_message = ( "\nServer stopped.\nNote that the test database, %r, has not been " "deleted. You can explore it on your own." % db_name ) use_threading = connection.features.test_db_allows_multiple_connections call_command( "runserver", addrport=options["addrport"], shutdown_message=shutdown_message, use_reloader=False, use_ipv6=options["use_ipv6"], use_threading=use_threading, ) [7db4228a]
- def add_arguments(self, parser): parser.add_argument( "args", metavar="fixture", nargs="*", help="Path(s) to fixtures to load before running the server.", ) parser.add_argument( "--noinput", "--no-input", action="store_false", dest="interactive", help="Tells Django to NOT prompt the user for input of any kind.", ) parser.add_argument( "--addrport", default="", help="Port number or ipaddr:port to run the server on.", ) parser.add_argument( "--ipv6", "-6", action="store_true", dest="use_ipv6", help="Tells Django to use an IPv6 address.", ) [12b8eec4]
- def handle(self, *fixture_labels, **options): verbosity = options["verbosity"] interactive = options["interactive"] [99d35e72]
- requires_system_checks = [] [72e6d136f77918ef-8]
- class Command(BaseCommand): help = "Runs a development server with data from the given fixture(s)." [04b60359]
- from django.core.management import call_command from django.core.management.base import BaseCommand from django.db import connection [2ee4238d]
