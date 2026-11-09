# django/core/management/commands/compilemessages

- Subject: django/core/management/commands/compilemessages (id `547ef1d8-cf00-4faf-808f-bb7d41a445ea`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1462 tokens
- Facts shown: 24 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- # Check writability on first location if i == 0 and not is_dir_writable(mo_path.parent): self.stderr.write( "The po files under %s are in a seemingly not writable " "location. mo files will not be updated/created." % dirpath ) self.has_errors = True return [563b9da0]
- args = [self.program, *self.program_options, "-o", mo_path, po_path] futures.append(executor.submit(popen_wrapper, args)) [89dd6900]
- if has_bom(po_path): self.stderr.write( "The %s file has a BOM (Byte Order Mark). Django only " "supports .po files encoded in UTF-8 and without any BOM." % po_path ) self.has_errors = True continue [4b9949bd]
- basedirs.extend(settings.LOCALE_PATHS) [d9e1bb92]
- for future in concurrent.futures.as_completed(futures): output, errors, status = future.result() if status: if self.verbosity > 0: if errors: self.stderr.write( "Execution of %s failed: %s" % (self.program, errors) ) else: self.stderr.write("Execution of %s failed" % self.program) self.has_errors = True [74572f7c]
- # Account for excluded locales locales = locale or all_locales locales = set(locales).difference(exclude) [68f9a0da]
- # Build locale list all_locales = [] for basedir in basedirs: locale_dirs = filter(os.path.isdir, glob.glob("%s/*" % basedir)) all_locales.extend(map(os.path.basename, locale_dirs)) [fd00ec6a]
- # Gather existing directories. basedirs = set(map(os.path.abspath, filter(os.path.isdir, basedirs))) [ff2def80]
- # Walk entire tree, looking for locale directories for dirpath, dirnames, filenames in os.walk(".", topdown=True): # As we may modify dirnames, iterate through a copy of it instead for dirname in list(dirnames): if is_ignored_path( os.path.normpath(os.path.join(dirpath, dirname)), ignore_patterns ): dirnames.remove(dirname) elif dirname == "locale": basedirs.append(os.path.join(dirpath, dirname)) [56865d1f]
- basedirs = [os.path.join("conf", "locale"), "locale"] if os.environ.get("DJANGO_SETTINGS_MODULE"): from django.conf import settings [04e8cc1c]
- if find_command(self.program) is None: raise CommandError( f"Can't find {self.program}. Make sure you have GNU gettext " "tools 0.19 or newer installed." ) [9607ea8b]
- if not basedirs: raise CommandError( "This script should be run from the Django Git " "checkout or your project or app tree, or with " "the settings module specified." ) [69be778c]
- if self.has_errors: raise CommandError("compilemessages generated one or more errors.") [5488ecd1]
- self.has_errors = False for basedir in basedirs: if locales: dirs = [ os.path.join(basedir, locale, "LC_MESSAGES") for locale in locales ] else: dirs = [basedir] locations = [] for ldir in dirs: for dirpath, dirnames, filenames in os.walk(ldir): locations.extend( (dirpath, f) for f in filenames if f.endswith(".po") ) if locations: self.compile_messages(locations) [fe35685d]
- def handle(self, **options): locale = options["locale"] exclude = options["exclude"] ignore_patterns = set(options["ignore_patterns"]) self.verbosity = options["verbosity"] if options["fuzzy"]: self.program_options = [*self.program_options, "-f"] [61788836]
- requires_system_checks = [] [72e6d136f77918ef-3]

## All facts

- [03c34c12] def add_arguments(self, parser): parser.add_argument( "--locale", "-l", action="append", default=[], help="Locale(s) to process (e.g. de_AT). Default is to process all. " "Can be used multiple times.", ) parser.add_argument( "--exclude", "-x", action="append", default=[], help="Locales to exclude. Default is none. Can be used multiple times.", ) parser.add_argument( "--use-fuzzy", "-f", dest="fuzzy", action="store_true", help="Use fuzzy translations.", ) parser.add_argument( "--ignore", "-i", action="append", dest="ignore_patterns", default=[], metavar="PATTERN", help="Ignore directories matching this glob-style pattern. " "Use multiple times to ignore more.", )
- [9892e536] def compile_messages(self, locations): """ Locations is a list of tuples: [(directory, file), ...] """ with concurrent.futures.ThreadPoolExecutor() as executor: futures = [] for i, (dirpath, f) in enumerate(locations): po_path = Path(dirpath) / f mo_path = po_path.with_suffix(".mo") try: if mo_path.stat().st_mtime >= po_path.stat().st_mtime: if self.verbosity > 0: self.stdout.write( "File “%s” is already compiled and up to date." % po_path ) continue except FileNotFoundError: pass if self.verbosity > 0: self.stdout.write("processing file %s in %s" % (f, dirpath))
- [8b5439e8] program = "msgfmt" program_options = ["--check-format"]
- [11bf41c2] class Command(BaseCommand): help = "Compiles .po files to .mo files for use with builtin gettext support."
- [d97bad39] def has_bom(fn): with fn.open("rb") as f: sample = f.read(4) return sample.startswith( (codecs.BOM_UTF8, codecs.BOM_UTF16_LE, codecs.BOM_UTF16_BE) )
- [a3f770a5] def is_dir_writable(path): try: with tempfile.NamedTemporaryFile(dir=path): pass except OSError: return False return True
- [6a7dc76b] from django.core.management.base import BaseCommand, CommandError from django.core.management.utils import find_command, is_ignored_path, popen_wrapper
- [fe81f2f6] import codecs import concurrent.futures import glob import os import tempfile from pathlib import Path
