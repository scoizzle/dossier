# django/core/management/__init__

- Subject: django/core/management/__init__ (id `c8c124e5-14a5-447e-80f9-f80315612959`)
- Kind: subject
- Budget: 1200 tokens
- Used: 892 tokens
- Facts shown: 8 of 46
- Conflicts: 0
- Gaps: 0

## Facts

- # Remove options not compatible with the built-in runserver # (e.g. options for the contrib.staticfiles' runserver). # Changes here require manually testing as described in # #27522. _parser = self.fetch_command("runserver").create_parser( "django", "runserver" ) _options, _args = _parser.parse_known_args(self.argv[2:]) for _arg in _args: self.argv.remove(_arg) [929c5554]
- # In all other cases, django.setup() is required to succeed. else: django.setup() [dc6c7d9b]
- # filter options by current input options = sorted((k, v) for k, v in options if k.startswith(curr)) for opt_label, require_arg in options: # append '=' to options which require args if require_arg: opt_label += "=" print(opt_label) # Exit code of the bash completion function is never passed back to # the user, so it's safe to always exit with 0. # For more details see #25420. sys.exit(0) [f1ec2c5b]
- # Preprocess options to extract --settings and --pythonpath. # These options could affect the commands that are available, so they # must be processed early. parser = CommandParser( prog=self.prog_name, usage="%(prog)s subcommand [options] [args]", add_help=False, allow_abbrev=False, ) parser.add_argument("--settings") parser.add_argument("--pythonpath") parser.add_argument("args", nargs="*") # catch-all try: options, args = parser.parse_known_args(self.argv[2:]) handle_default_options(options) except CommandError: pass # Ignore any option errors at this point. [d045aae2]
- # subcommand if cword == 1: print(" ".join(sorted(filter(lambda x: x.startswith(curr), subcommands)))) # subcommand options # special case: the 'help' subcommand has no options elif cwords[0] in subcommands and cwords[0] != "help": subcommand_cls = self.fetch_command(cwords[0]) # special case: add the names of installed apps to options if cwords[0] in ("dumpdata", "sqlmigrate", "sqlsequencereset", "test"): try: app_configs = apps.get_app_configs() # Get the last part of the dotted path as the app name. options.extend((app_config.label, 0) for app_config in app_configs) except ImportError: # Fail silently if DJANGO_SETTINGS_MODULE isn't set. The # user will find out once they execute the command. pass parser = subcommand_cls.create_parser("", cwords[0]) options.extend( (min(s_opt.option_strings), s_opt.nargs != 0) for s_opt in parser._actions if s_opt.option_strings ) # filter out previously specified options from available options prev_opts = {x.split("=")[0] for x in cwords[1 : cword - 1]} options = (opt for opt in options if opt[0] not in prev_opts) [706db6ea]
- Note: If debugging this function, it is recommended to write the debug output in a separate file. Otherwise the debug output will be treated and formatted as potential completion suggestions. """ # Don't complete if user hasn't sourced bash_completion file. if "DJANGO_AUTO_COMPLETE" not in os.environ: return [9cc4ae1b]
- Subcommand options are saved as pairs. A pair consists of the long option string (e.g. '--exclude') and a boolean value indicating if the option requires arguments. When printing to stdout, an equal sign is appended to options which require arguments. [12f42e5f]
- The `COMP_WORDS` and `COMP_CWORD` BASH environment variables are used to get information about the cli input. Please refer to the BASH man-page for more information about this variables. [fddef8e1]

## Beyond the budget

38 more facts did not fit in the budget: [f7e1d323] [705d6ccf] [773f8afb] [03e26c01] [6a230880] [5c0f600e] [35ca0c8b] [69098268] [d00cf485] [2a69e2dd] [773b0341] [b9aef95f] [2b3cd574] [8baf5620] [55364a0a] [59cbfc1e] [bea265c0] [df0760a9] [1effc35c] [0e3b0b0d] [802f318d] [b2e8ba29] [178a3123] [b4243d99] [01294461] [a28b14a8] [5d1dafe9] [8fa72300] [d6d8eda6] [ef86fc99] [cde11c81] [73d567e4] [610b6924] [a3a78e73] [c3cae589] [41fce336] [c743ad3d] [ef6ba005]
