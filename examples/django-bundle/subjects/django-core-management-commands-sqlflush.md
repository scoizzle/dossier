# django/core/management/commands/sqlflush

- Subject: django/core/management/commands/sqlflush (id `9c10c63b-73d3-467d-bd1b-a2582c735b02`)
- Kind: subject
- Budget: 1200 tokens
- Used: 263 tokens
- Facts shown: 5 of 5
- Conflicts: 0
- Gaps: 0

## Facts

- def add_arguments(self, parser): super().add_arguments(parser) parser.add_argument( "--database", default=DEFAULT_DB_ALIAS, choices=tuple(connections), help=( 'Nominates a database to print the SQL for. Defaults to the "default" ' "database." ), ) [4d103e5cbce72627]
- def handle(self, **options): sql_statements = sql_flush(self.style, connections[options["database"]]) if not sql_statements and options["verbosity"] >= 1: self.stderr.write("No tables found.") return "\n".join(sql_statements) [e7a4468e]
- output_transaction = True [43d56bd5f4b3cdb8]
- class Command(BaseCommand): help = ( "Returns a list of the SQL statements required to return all tables in " "the database to the state they were in just after they were installed." ) [11fdfabf]
- from django.core.management.base import BaseCommand from django.core.management.sql import sql_flush from django.db import DEFAULT_DB_ALIAS, connections [74b7b093]
