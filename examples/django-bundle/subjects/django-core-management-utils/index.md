# django/core/management/utils

- Subject: django/core/management/utils (id `fbdfdb73-0dec-4321-be8b-8c654413a1c3`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1395 tokens
- Facts shown: 20 of 20
- Conflicts: 0
- Gaps: 0

## Highlights

- >>> handle_extensions(['.html', 'html,js,py,py,py,.py', 'py,.py']) {'.html', '.js', '.py'} >>> handle_extensions(['.html, txt,.tpl']) {'.html', '.tpl', '.txt'} """ ext_list = [] for ext in extensions: ext_list.extend(ext.replace(" ", "").split(",")) for i, ext in enumerate(ext_list): if not ext.startswith("."): ext_list[i] = ".%s" % ext_list[i] return set(ext_list) [3dd5ef14]
- For example: running 'django-admin makemessages -e js,txt -e xhtml -a' would result in an extension list: ['.js', '.txt', '.xhtml'] [db7db499]
- Return stdout output, stderr output, and OS status code. """ try: p = run(args, capture_output=True, close_fds=os.name != "nt") except OSError as err: raise CommandError("Error executing %s" % args[0]) from err return ( p.stdout.decode(stdout_encoding), p.stderr.decode(DEFAULT_LOCALE_ENCODING, errors="replace"), p.returncode, ) [44a90ded]
- def ignore(pattern): return fnmatch.fnmatchcase(path.name, pattern) or fnmatch.fnmatchcase( str(path), pattern ) [a0100d75]
- for label in labels: if "." in label: try: model = installed_apps.get_model(label) except LookupError: raise CommandError("Unknown model: %s" % label) models.add(model) else: try: app_config = installed_apps.get_app_config(label) except LookupError as e: raise CommandError(str(e)) apps.add(app_config) [177f1227]
- return any(ignore(pattern) for pattern in normalize_path_patterns(ignore_patterns)) [9b0cd2d4]
- return models, apps [a1321e5f]
- def find_command(cmd, path=None, pathext=None): if path is None: path = os.environ.get("PATH", "").split(os.pathsep) if isinstance(path, str): path = [path] # check if there are funny path extensions for executables, e.g. Windows if pathext is None: pathext = os.environ.get("PATHEXT", ".COM;.EXE;.BAT;.CMD").split(os.pathsep) # don't use extensions if the command ends with one of them for ext in pathext: if cmd.endswith(ext): pathext = [""] break # check if we find the command on PATH for p in path: f = os.path.join(p, cmd) if os.path.isfile(f): return f for ext in pathext: fext = f + ext if os.path.isfile(fext): return fext return None [ddd21afb]
- def find_formatters(): return {"black_path": shutil.which("black")} [0147ad00]
- def get_command_line_option(argv, option): """ Return the value of a command line option (which should include leading dashes, e.g. '--testrunner') from an argument list. Return None if the option wasn't passed or if the argument list couldn't be parsed. """ parser = CommandParser(add_help=False, allow_abbrev=False) parser.add_argument(option, dest="value") try: options, _ = parser.parse_known_args(argv[2:]) except CommandError: return None else: return options.value [1696cbc8]
- def get_random_secret_key(): """ Return a 50 character random string usable as a SECRET_KEY setting value. """ chars = "abcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*(-_=+)" return get_random_string(50, chars) [1d788317]
- def handle_extensions(extensions): """ Organize multiple extensions that are separated with commas or passed by using --extension/-e multiple times. [3685a252]
- def popen_wrapper(args, stdout_encoding="utf-8"): """ Friendly wrapper around Popen. [bd88fe48]

## All facts

- [df9103fe] def is_ignored_path(path, ignore_patterns): """ Check if the given path should be ignored or not based on matching one of the glob style `ignore_patterns`. """ path = Path(path)
- [f1aeaa0c] def normalize_path_patterns(patterns): """Normalize an iterable of glob style patterns based on OS.""" patterns = [os.path.normcase(p) for p in patterns] dir_suffixes = {"%s*" % path_sep for path_sep in {"/", os.sep}} norm_patterns = [] for pattern in patterns: for dir_suffix in dir_suffixes: if pattern.endswith(dir_suffix): norm_patterns.append(pattern.removesuffix(dir_suffix)) break else: norm_patterns.append(pattern) return norm_patterns
- [8ceb9bc5] def parse_apps_and_model_labels(labels): """ Parse a list of "app_label.ModelName" or "app_label" strings into actual objects and return a two-element tuple: (set of model classes, set of app_configs). Raise a CommandError if some specified models or apps don't exist. """ apps = set() models = set()
- [37d8bb4e] def run_formatters(written_files, black_path=(sentinel := object()), stderr=sys.stderr): """ Run the black formatter on the specified files. """ # Use a sentinel rather than None, as which() returns None when not found. if black_path is sentinel: black_path = shutil.which("black") if black_path: try: subprocess.run( [black_path, "--fast", "--", *written_files], capture_output=True, ) except OSError: stderr.write("Formatters failed to launch:") traceback.print_exc(file=stderr)
- [b4518402] from .base import CommandError, CommandParser
- [7f0a09fd] from django.apps import apps as installed_apps from django.utils.crypto import get_random_string from django.utils.encoding import DEFAULT_LOCALE_ENCODING
- [44e09d14] import fnmatch import os import shutil import subprocess import sys import traceback from pathlib import Path from subprocess import run
