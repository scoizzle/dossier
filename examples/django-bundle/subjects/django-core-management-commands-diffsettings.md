# django/core/management/commands/diffsettings

- Subject: django/core/management/commands/diffsettings (id `12b107df-8990-4004-9daf-24b8440ad670`)
- Kind: subject
- Budget: 1200 tokens
- Used: 778 tokens
- Facts shown: 10 of 10
- Conflicts: 0
- Gaps: 0

## Facts

- # Because settings are imported lazily, we need to explicitly load # them. if not settings.configured: settings._setup() [d8e5ef77]
- user_settings = module_to_dict(settings._wrapped) default = options["default"] default_settings = module_to_dict( Settings(default) if default else global_settings ) output_func = { "hash": self.output_hash, "unified": self.output_unified, }[options["output"]] return "\n".join(output_func(user_settings, default_settings, **options)) [72c89f19]
- def add_arguments(self, parser): parser.add_argument( "--all", action="store_true", help=( 'Display all settings, regardless of their value. In "hash" ' 'mode, default values are prefixed by "###".' ), ) parser.add_argument( "--default", metavar="MODULE", help=( "The settings module to compare the current settings against. Leave " "empty to compare against Django's default settings." ), ) parser.add_argument( "--output", default="hash", choices=("hash", "unified"), help=( "Selects the output format. 'hash' mode displays each changed " "setting, with the settings that don't appear in the defaults " "followed by ###. 'unified' mode prefixes the default setting " "with a minus sign, followed by the changed setting prefixed " "with a plus sign." ), ) [7184c498]
- def handle(self, **options): from django.conf import Settings, global_settings, settings [560d599d]
- def output_hash(self, user_settings, default_settings, **options): # Inspired by Postfix's "postconf -n". output = [] for key in sorted(user_settings): if key not in default_settings: output.append("%s = %s ###" % (key, user_settings[key])) elif user_settings[key] != default_settings[key]: output.append("%s = %s" % (key, user_settings[key])) elif options["all"]: output.append("### %s = %s" % (key, user_settings[key])) return output [2355587c]
- def output_unified(self, user_settings, default_settings, **options): output = [] for key in sorted(user_settings): if key not in default_settings: output.append( self.style.SUCCESS("+ %s = %s" % (key, user_settings[key])) ) elif user_settings[key] != default_settings[key]: output.append( self.style.ERROR("- %s = %s" % (key, default_settings[key])) ) output.append( self.style.SUCCESS("+ %s = %s" % (key, user_settings[key])) ) elif options["all"]: output.append(" %s = %s" % (key, user_settings[key])) return output [e5c69770]
- requires_system_checks = [] [72e6d136f77918ef-6]
- class Command(BaseCommand): help = """Displays differences between the current settings.py and Django's default settings.""" [8219e3c9]
- def module_to_dict(module, omittable=lambda k: k.startswith("_") or not k.isupper()): """Convert a module namespace to a Python dictionary.""" return {k: repr(getattr(module, k)) for k in dir(module) if not omittable(k)} [9c755d31]
- from django.core.management.base import BaseCommand [76ec1e1a]
