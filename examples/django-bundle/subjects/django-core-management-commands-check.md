# django/core/management/commands/check

- Subject: django/core/management/commands/check (id `88745fac-93b0-481e-adb5-7740bc6a4d31`)
- Kind: subject
- Budget: 1200 tokens
- Used: 576 tokens
- Facts shown: 8 of 8
- Conflicts: 0
- Gaps: 0

## Facts

- if app_labels: app_configs = [apps.get_app_config(app_label) for app_label in app_labels] else: app_configs = None [8e6c8d6d]
- self.check( app_configs=app_configs, tags=tags, display_num_errors=True, include_deployment_checks=include_deployment_checks, fail_level=getattr(checks, options["fail_level"]), databases=options["databases"], ) [6b2d9fef]
- tags = options["tags"] if tags: try: invalid_tag = next( tag for tag in tags if not checks.tag_exists(tag, include_deployment_checks) ) except StopIteration: # no invalid tags pass else: raise CommandError( 'There is no system check with the "%s" tag.' % invalid_tag ) [e717f98e]
- def add_arguments(self, parser): parser.add_argument("args", metavar="app_label", nargs="*") parser.add_argument( "--tag", "-t", action="append", dest="tags", help="Run only checks labeled with given tag.", ) parser.add_argument( "--list-tags", action="store_true", help=( "List available tags. Specify --deploy to include available deployment " "tags." ), ) parser.add_argument( "--deploy", action="store_true", help="Check deployment settings.", ) parser.add_argument( "--fail-level", default="ERROR", choices=["CRITICAL", "ERROR", "WARNING", "INFO", "DEBUG"], help=( "Message level that will cause the command to exit with a " "non-zero status. Default is ERROR." ), ) parser.add_argument( "--database", action="append", choices=tuple(connections), dest="databases", help="Run database related checks against these aliases.", ) [7a3b1d25]
- def handle(self, *app_labels, **options): include_deployment_checks = options["deploy"] if options["list_tags"]: self.stdout.write( "\n".join(sorted(registry.tags_available(include_deployment_checks))) ) return [1057d768]
- requires_system_checks = [] [72e6d136f77918ef-2]
- class Command(BaseCommand): help = "Checks the entire Django project for potential problems." [9cf5aa4a]
- from django.apps import apps from django.core import checks from django.core.checks.registry import registry from django.core.management.base import BaseCommand, CommandError from django.db import connections [fe1a6940]
