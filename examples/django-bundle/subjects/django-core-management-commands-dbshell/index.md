# django/core/management/commands/dbshell

- Subject: django/core/management/commands/dbshell (id `8ddac8fd-a81d-4073-a798-73ddc9d0700b`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 394 tokens
- Facts shown: 6 of 6
- Conflicts: 0
- Gaps: 0

## Facts

- def add_arguments(self, parser): parser.add_argument( "--database", default=DEFAULT_DB_ALIAS, choices=tuple(connections), help=( "Nominates a database onto which to open a shell. Defaults to the " '"default" database.' ), ) parameters = parser.add_argument_group("parameters") parameters.add_argument("parameters", nargs="*") [fc688425]
- def handle(self, **options): connection = connections[options["database"]] try: connection.client.runshell(options["parameters"]) except FileNotFoundError: # Note that we're assuming the FileNotFoundError relates to the # command missing. It could be raised for some other reason, in # which case this error message would be inaccurate. Still, this # message catches the common case. raise CommandError( "You appear not to have the %r program installed or on your path." % connection.client.executable_name ) except subprocess.CalledProcessError as e: raise CommandError( '"%s" returned non-zero exit status %s.' % ( " ".join(map(str, e.cmd)), e.returncode, ), returncode=e.returncode, ) [42be72b9]
- requires_system_checks = [] [72e6d136f77918ef-5]
- class Command(BaseCommand): help = ( "Runs the command-line client for specified database, or the " "default database if none is provided." ) [ed1918f4]
- from django.core.management.base import BaseCommand, CommandError from django.db import DEFAULT_DB_ALIAS, connections [01aa0241]
- import subprocess [824c1781]
