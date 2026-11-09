# django/db/backends/base/client

- Subject: django/db/backends/base/client (id `c31069b7-6ee5-45f6-b24a-cef754ef9f97`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 284 tokens
- Facts shown: 7 facts
- Conflicts: 0
- Gaps: 0

## Facts

- # This should be a string representing the name of the executable # (e.g., "psql"). Subclasses must override this. executable_name = None [5cb1941c]
- @classmethod def settings_to_cmd_args_env(cls, settings_dict, parameters): raise NotImplementedError( "subclasses of BaseDatabaseClient must provide a " "settings_to_cmd_args_env() method or override a runshell()." ) [6bd295c6]
- def __del__(self): del self.connection [aedcdc0442006877]
- def __init__(self, connection): # connection is an instance of BaseDatabaseWrapper. self.connection = connection [68db2619]
- def runshell(self, parameters): args, env = self.settings_to_cmd_args_env( self.connection.settings_dict, parameters ) env = {**os.environ, **env} if env else None subprocess.run(args, env=env, check=True) [f568e6d2]
- class BaseDatabaseClient: """Encapsulate backend-specific methods for opening a client shell.""" [fd1c6f7d]
- import os import subprocess [cd71baa3]
