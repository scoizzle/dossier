# django/core/checks/commands

- Subject: django/core/checks/commands (id `752f72f6-9f76-4494-8dbf-daaa66c560d9`)
- Kind: subject
- Budget: 1200 tokens
- Used: 248 tokens
- Facts shown: 6 of 6
- Conflicts: 0
- Gaps: 0

## Facts

- commands = get_commands() [477acc06]
- if make_migrations.autodetector is not migrate.autodetector: return [ Error( "The migrate and makemigrations commands must have the same " "autodetector.", hint=( f"makemigrations.Command.autodetector is " f"{make_migrations.autodetector.__name__}, but " f"migrate.Command.autodetector is " f"{migrate.autodetector.__name__}." ), id="commands.E001", ) ] [96ebd102]
- make_migrations = load_command_class(commands["makemigrations"], "makemigrations") migrate = load_command_class(commands["migrate"], "migrate") [b4bf6edb]
- return [] [637c4c5c01c1a891-2]
- @register(Tags.commands) def migrate_and_makemigrations_autodetector(**kwargs): from django.core.management import get_commands, load_command_class [eb423637]
- from django.core.checks import Error, Tags, register [0d7e3aba]
