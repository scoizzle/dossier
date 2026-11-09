# django/db/backends/oracle/client

- Subject: django/db/backends/oracle/client (id `7dfe81c4-3ad1-4457-ae63-70c4f2b2d883`)
- Kind: subject
- Budget: 1200 tokens
- Used: 224 tokens
- Facts shown: 6 of 6
- Conflicts: 0
- Gaps: 0

## Facts

- return '%s/"%s"@%s' % ( settings_dict["USER"], settings_dict["PASSWORD"], dsn(settings_dict), ) [a9a3069c]
- @classmethod def settings_to_cmd_args_env(cls, settings_dict, parameters): args = [cls.executable_name, "-L", cls.connect_string(settings_dict)] wrapper_path = shutil.which(cls.wrapper_name) if wrapper_path: args = [wrapper_path, *args] args.extend(parameters) return args, None [ba655cbc]
- @staticmethod def connect_string(settings_dict): from django.db.backends.oracle.utils import dsn [243d42f3]
- class DatabaseClient(BaseDatabaseClient): executable_name = "sqlplus" wrapper_name = "rlwrap" [88cffdcd]
- from django.db.backends.base.client import BaseDatabaseClient [560efb2fec4a3db8-2]
- import shutil [455aba58]
