# django/core/management/commands/startproject

- Subject: django/core/management/commands/startproject (id `151d5782-9c38-4a01-b164-7da3043605b8`)
- Kind: subject
- Budget: 1200 tokens
- Used: 236 tokens
- Facts shown: 5 of 5
- Conflicts: 0
- Gaps: 0

## Facts

- # Create a random SECRET_KEY to put it in the main settings. options["secret_key"] = SECRET_KEY_INSECURE_PREFIX + get_random_secret_key() [2fa96996]
- super().handle("project", project_name, target, **options) [70a48b0e]
- def handle(self, **options): project_name = options.pop("name") target = options.pop("directory") [cd11e16c]
- class Command(TemplateCommand): help = ( "Creates a Django project directory structure for the given project " "name in the current directory or optionally in the given directory." ) missing_args_message = "You must provide a project name." [d57c2788]
- from django.core.checks.security.base import SECRET_KEY_INSECURE_PREFIX from django.core.management.templates import TemplateCommand from django.core.management.utils import get_random_secret_key [ea9f8491]
