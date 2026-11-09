# django/core/management/commands/startapp

- Subject: django/core/management/commands/startapp (id `f95e8c7d-8682-4593-9e43-75777f3c359b`)
- Kind: subject
- Budget: 1200 tokens
- Used: 143 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- def handle(self, **options): app_name = options.pop("name") target = options.pop("directory") super().handle("app", app_name, target, **options) [8af809ed]
- class Command(TemplateCommand): help = ( "Creates a Django app directory structure for the given app name in " "the current directory or optionally in the given directory." ) missing_args_message = "You must provide an application name." [fb8ad8ea]
- from django.core.management.templates import TemplateCommand [df98b2fc]
