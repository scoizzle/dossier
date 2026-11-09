# django/db/backends/postgresql/client

- Subject: django/db/backends/postgresql/client (id `f8169332-918d-4938-b116-af52c595b3cc`)
- Kind: subject
- Budget: 1200 tokens
- Used: 472 tokens
- Facts shown: 8 of 8
- Conflicts: 0
- Gaps: 0

## Facts

- env = {} if passwd: env["PGPASSWORD"] = str(passwd) if service: env["PGSERVICE"] = str(service) if sslmode: env["PGSSLMODE"] = str(sslmode) if sslrootcert: env["PGSSLROOTCERT"] = str(sslrootcert) if sslcert: env["PGSSLCERT"] = str(sslcert) if sslkey: env["PGSSLKEY"] = str(sslkey) if passfile: env["PGPASSFILE"] = str(passfile) return args, (env or None) [3614430b]
- host = settings_dict.get("HOST") port = settings_dict.get("PORT") dbname = settings_dict.get("NAME") user = settings_dict.get("USER") passwd = settings_dict.get("PASSWORD") passfile = options.get("passfile") service = options.get("service") sslmode = options.get("sslmode") sslrootcert = options.get("sslrootcert") sslcert = options.get("sslcert") sslkey = options.get("sslkey") [f08afcfe]
- if not dbname and not service: # Connect to the default 'postgres' db. dbname = "postgres" if user: args += ["-U", user] if host: args += ["-h", host] if port: args += ["-p", str(port)] args.extend(parameters) if dbname: args += [dbname] [8f9a1834]
- @classmethod def settings_to_cmd_args_env(cls, settings_dict, parameters): args = [cls.executable_name] options = settings_dict["OPTIONS"] [dd1e0a3b]
- def runshell(self, parameters): sigint_handler = signal.getsignal(signal.SIGINT) try: # Allow SIGINT to pass to psql to abort queries. signal.signal(signal.SIGINT, signal.SIG_IGN) super().runshell(parameters) finally: # Restore the original SIGINT handler. signal.signal(signal.SIGINT, sigint_handler) [80672da8]
- class DatabaseClient(BaseDatabaseClient): executable_name = "psql" [a9009bf2]
- from django.db.backends.base.client import BaseDatabaseClient [560efb2fec4a3db8-3]
- import signal [e1bdff4f31499e73-2]
