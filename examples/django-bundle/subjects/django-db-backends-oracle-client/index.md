# django/db/backends/oracle/client

- Subject: django/db/backends/oracle/client (id `687630c6-4e56-4ea9-88d8-e241921dc181`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 224 tokens
- Facts shown: 6 facts
- Conflicts: 0
- Gaps: 0

## Facts

- return '%s/"%s"@%s' % ( settings_dict["USER"], settings_dict["PASSWORD"], dsn(settings_dict), ) [a9a3069c]
- @classmethod def settings_to_cmd_args_env(cls, settings_dict, parameters): args = [cls.executable_name, "-L", cls.connect_string(settings_dict)] wrapper_path = shutil.which(cls.wrapper_name) if wrapper_path: args = [wrapper_path, *args] args.extend(parameters) return args, None [ba655cbc]
- @staticmethod def connect_string(settings_dict): from django.db.backends.oracle.utils import dsn [243d42f3]
- class DatabaseClient(BaseDatabaseClient): executable_name = "sqlplus" wrapper_name = "rlwrap" [88cffdcd]
- from django.db.backends.base.client import BaseDatabaseClient [560efb2fec4a3db8-2]
- import shutil [455aba58]
