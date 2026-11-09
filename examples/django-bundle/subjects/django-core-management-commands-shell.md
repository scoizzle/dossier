# django/core/management/commands/shell

- Subject: django/core/management/commands/shell (id `80bb8684-e358-4209-b2ab-8ba39c051351`)
- Kind: subject
- Budget: 1200 tokens
- Used: 894 tokens
- Facts shown: 12 of 41
- Conflicts: 0
- Gaps: 0

## Facts

- if "." in path: module, name = path.rsplit(".", 1) else: module = None name = path if (name, obj) not in auto_imports[module]: auto_imports[module].append((name, obj)) [95a34a7a]
- readline.set_completer(rlcompleter.Completer(imported_objects).complete) except ImportError: pass [93fc99e7]
- """ default_imports = [ "django.conf.settings", "django.db.connection", "django.db.models", "django.db.models.functions", "django.db.reset_queries", "django.utils.timezone", ] app_models_imports = default_imports + [ f"{model.__module__}.{model.__name__}" for model in reversed(apps.get_models()) if model.__module__ ] return app_models_imports [f79c968c]
- # By default, this will set up readline to do tab completion and to # read and write history to the .python_history file, but this can be # overridden by $PYTHONSTARTUP or ~/.pythonrc.py. try: hook = sys.__interactivehook__ except AttributeError: # Match the behavior of the cpython shell where a missing # sys.__interactivehook__ is ignored. pass else: try: hook() except Exception: # Match the behavior of the cpython shell where an error in # sys.__interactivehook__ prints a warning and the exception # and continues. print("Failed calling sys.__interactivehook__") traceback.print_exc() [4a946b92]
- # Execute stdin if it has anything to read and exit. # Not supported on Windows due to select.select() limitations. if ( sys.platform != "win32" and not sys.stdin.isatty() and select.select([sys.stdin], [], [], 0)[0] ): exec(sys.stdin.read(), {**globals(), **self.get_namespace(**options)}) return [5c47a60f]
- # Set up a dictionary to serve as the environment for the shell. imported_objects = self.get_namespace(**options) [890ddcea]
- # Set up tab completion for objects imported by $PYTHONSTARTUP or # ~/.pythonrc.py. try: import readline import rlcompleter [45fa3bb0]
- # Start the interactive interpreter. code.interact(local=imported_objects) [39ef3209]
- # We want to honor both $PYTHONSTARTUP and .pythonrc.py, so follow # system conventions and get $PYTHONSTARTUP first then .pythonrc.py. if not options["no_startup"]: for pythonrc in OrderedSet( [os.environ.get("PYTHONSTARTUP"), os.path.expanduser("~/.pythonrc.py")] ): if not pythonrc: continue if not os.path.isfile(pythonrc): continue with open(pythonrc) as handle: pythonrc_code = handle.read() # Match the behavior of the cpython shell where an error in # PYTHONSTARTUP prints an exception and continues. try: exec(compile(pythonrc_code, pythonrc, "exec"), imported_objects) except Exception: traceback.print_exc() [16d01489]
- By default, import paths for models in INSTALLED_APPS and some common utilities are included, with models from earlier apps taking precedence in case of a name collision. [929163c9]
- For example, for an unchanged INSTALLED_APPS, this method returns: [2e381eba]
- [ "django.conf.settings", "django.db.connection", "django.db.models", "django.db.models.functions", "django.db.reset_queries", "django.utils.timezone", "django.contrib.sessions.models.Session", "django.contrib.contenttypes.models.ContentType", "django.contrib.auth.models.User", "django.contrib.auth.models.Group", "django.contrib.auth.models.Permission", "django.contrib.admin.models.LogEntry", ] [7b0052b8]

## Beyond the budget

29 more facts did not fit in the budget: [fa745b54] [b604e2da] [aea3ad0d] [d3719d4b] [45450c08] [eb4eab06] [c6d1ea1f] [40e85e24] [1cdb1e6d] [b012a37f] [62b082c1] [1c281426] [e4785b42] [2029e3ae] [03f41066] [87cffd66] [3914baf8] [844b0afd] [0c00ecb6] [99c0e015] [e3510cd5] [2125bfc1] [f05d265e] [5d2fea05] [d8914d64] [b4ed469d] [4436ac25] [49f9df48] [ef466b1a]
