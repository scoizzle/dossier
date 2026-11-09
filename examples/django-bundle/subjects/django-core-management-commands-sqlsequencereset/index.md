# django/core/management/commands/sqlsequencereset

- Subject: django/core/management/commands/sqlsequencereset (id `a3222025-c042-4fc4-b877-df1524607c51`)
- Kind: subject
- Budget: 1200 tokens
- Used: 273 tokens
- Facts shown: 5 of 5
- Conflicts: 0
- Gaps: 0

## Facts

- def add_arguments(self, parser): super().add_arguments(parser) parser.add_argument( "--database", default=DEFAULT_DB_ALIAS, choices=tuple(connections), help=( 'Nominates a database to print the SQL for. Defaults to the "default" ' "database." ), ) [4d103e5cbce72627-2]
- def handle_app_config(self, app_config, **options): if app_config.models_module is None: return connection = connections[options["database"]] models = app_config.get_models(include_auto_created=True) statements = connection.ops.sequence_reset_sql(self.style, models) if not statements and options["verbosity"] >= 1: self.stderr.write("No sequences found.") return "\n".join(statements) [0c8169c9]
- output_transaction = True [43d56bd5f4b3cdb8-3]
- class Command(AppCommand): help = ( "Prints the SQL statements for resetting sequences for the given app name(s)." ) [c3cdb01a]
- from django.core.management.base import AppCommand from django.db import DEFAULT_DB_ALIAS, connections [d2aba29e]
