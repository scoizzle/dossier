# django/db/backends/sqlite3/client

- Subject: django/db/backends/sqlite3/client (id `263d36db-80ba-4e46-aea2-7111e730c1a9`)
- Kind: subject
- Budget: 1200 tokens
- Used: 104 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- @classmethod def settings_to_cmd_args_env(cls, settings_dict, parameters): args = [cls.executable_name, settings_dict["NAME"], *parameters] return args, None [632288b0]
- class DatabaseClient(BaseDatabaseClient): executable_name = "sqlite3" [c5b2da51]
- from django.db.backends.base.client import BaseDatabaseClient [560efb2fec4a3db8-4]
