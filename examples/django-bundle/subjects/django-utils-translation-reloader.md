# django/utils/translation/reloader

- Subject: django/utils/translation/reloader (id `81df66f5-6c97-455d-a063-4e940ff0c5d4`)
- Kind: subject
- Budget: 1200 tokens
- Used: 321 tokens
- Facts shown: 8 of 8
- Conflicts: 0
- Gaps: 0

## Facts

- from django.utils.translation import trans_real [ed7f6e15]
- gettext._translations = {} trans_real._translations = {} trans_real._default = None trans_real._active = Local() return True [97a8c104]
- if settings.USE_I18N: directories = [Path("locale")] directories.extend( Path(config.path) / "locale" for config in apps.get_app_configs() if not is_django_module(config.module) ) directories.extend(Path(p) for p in settings.LOCALE_PATHS) for path in directories: sender.watch_dir(path, "**/*.mo") [14b955dd]
- def translation_file_changed(sender, file_path, **kwargs): """Clear the internal translations cache if a .mo file is modified.""" if file_path.suffix == ".mo": import gettext [4ed1dd22]
- def watch_for_translation_changes(sender, **kwargs): """Register file watchers for .mo files in potential locale paths.""" from django.conf import settings [021f9732]
- from asgiref.local import Local [6beab4e4549a99b7-7]
- from django.apps import apps from django.utils.autoreload import is_django_module [6892708b]
- from pathlib import Path [8d8744708e7830c8-5]
