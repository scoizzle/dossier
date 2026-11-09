# django/core/management/commands/showmigrations

- Subject: django/core/management/commands/showmigrations (id `cd2f1d48-ffee-45e3-9ec9-3b0482c89f58`)
- Kind: subject
- Budget: 1200 tokens
- Used: 889 tokens
- Facts shown: 14 of 15
- Conflicts: 0
- Gaps: 0

## Facts

- # Generate the plan for target in targets: for migration in graph.forwards_plan(target): if migration not in seen: node = graph.node_map[migration] plan.append(node) seen.add(migration) [ea0018e8]
- # Get the database we're operating from db = options["database"] connection = connections[db] [d8100dbe]
- # Output def print_deps(node): out = [] for parent in sorted(node.parents): out.append("%s.%s" % parent.key) if out: return " ... (%s)" % ", ".join(out) return "" [5bcea605]
- for node in plan: deps = "" if self.verbosity >= 2: deps = print_deps(node) if node.key in loader.applied_migrations: self.stdout.write("[X] %s.%s%s" % (node.key[0], node.key[1], deps)) else: self.stdout.write("[ ] %s.%s%s" % (node.key[0], node.key[1], deps)) if not plan: self.stdout.write("(no migrations)", self.style.ERROR) [d31c85c4]
- formats = parser.add_mutually_exclusive_group() formats.add_argument( "--list", "-l", action="store_const", dest="format", const="list", help=( "Shows a list of all migrations and which are applied. " "With a verbosity level of 2 or above, the applied datetimes " "will be included." ), ) formats.add_argument( "--plan", "-p", action="store_const", dest="format", const="plan", help=( "Shows all migrations in the order they will be applied. With a " "verbosity level of 2 or above all direct migration dependencies and " "reverse dependencies (run_before) will be included." ), ) [ccb04f92]
- if options["format"] == "plan": return self.show_plan(connection, options["app_label"]) else: return self.show_list(connection, options["app_label"]) [27a2b350]
- parser.set_defaults(format="list") [e607c264]
- def _validate_app_names(self, loader, app_names): has_bad_names = False for app_name in app_names: try: apps.get_app_config(app_name) except LookupError as err: self.stderr.write(str(err)) has_bad_names = True if has_bad_names: sys.exit(2) [341b7b9d]
- def add_arguments(self, parser): parser.add_argument( "app_label", nargs="*", help="App labels of applications to limit the output to.", ) parser.add_argument( "--database", default=DEFAULT_DB_ALIAS, choices=tuple(connections), help=( "Nominates a database to show migrations for. Defaults to the " '"default" database.' ), ) [b9473696]
- def handle(self, *args, **options): self.verbosity = options["verbosity"] [f50a8cb5]
- def show_plan(self, connection, app_names=None): """ Show all known migrations (or only those of the specified app_names) in the order they will be applied. """ # Load migrations from disk/DB loader = MigrationLoader(connection) graph = loader.graph if app_names: self._validate_app_names(loader, app_names) targets = [key for key in graph.leaf_nodes() if key[0] in app_names] else: targets = graph.leaf_nodes() plan = [] seen = set() [fb25b44d]
- class Command(BaseCommand): help = "Shows all available migrations for the current project" [1e5e0b54]
- from django.apps import apps from django.core.management.base import BaseCommand from django.db import DEFAULT_DB_ALIAS, connections from django.db.migrations.loader import MigrationLoader from django.db.migrations.recorder import MigrationRecorder [9ec99ae0]
- import sys [6b0cb2be5ea1bc3c-2]

## Beyond the budget

1 more facts did not fit in the budget: [060dda52]
