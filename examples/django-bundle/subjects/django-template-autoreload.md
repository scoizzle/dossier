# django/template/autoreload

- Subject: django/template/autoreload (id `e71fc040-db7c-4020-a806-1affbdcbdd53`)
- Kind: subject
- Budget: 1200 tokens
- Used: 544 tokens
- Facts shown: 10 of 10
- Conflicts: 0
- Gaps: 0

## Facts

- for loader in backend.engine.template_loaders: if not hasattr(loader, "get_dirs"): continue items.update( cwd / to_path(directory) for directory in loader.get_dirs() if directory and not is_django_path(directory) ) return items [f861bac3]
- items.update(cwd / to_path(dir) for dir in backend.engine.dirs if dir) [e152aad0]
- backend = getattr(get_default_renderer(), "engine", None) if isinstance(backend, DjangoTemplates): for loader in backend.engine.template_loaders: loader.reset() [6f8fb75b]
- for backend in engines.all(): if not isinstance(backend, DjangoTemplates): continue for loader in backend.engine.template_loaders: loader.reset() [dc47dcd0]
- @receiver(autoreload_started, dispatch_uid="template_loaders_watch_changes") def watch_for_template_changes(sender, **kwargs): for directory in get_template_directories(): sender.watch_dir(directory, "**/*") [36441c46]
- @receiver(file_changed, dispatch_uid="template_loaders_file_changed") def template_changed(sender, file_path, **kwargs): if file_path.suffix == ".py": return for template_dir in get_template_directories(): if template_dir in file_path.parents: reset_loaders() return True [7a6a0d42]
- def get_template_directories(): # Iterate through each template backend and find # any template_loader that has a 'get_dirs' method. # Collect the directories, filtering out Django templates. cwd = Path.cwd() items = set() for backend in engines.all(): if not isinstance(backend, DjangoTemplates): continue [5dd0f7bc]
- def reset_loaders(): from django.forms.renderers import get_default_renderer [e20c49f7]
- from django.dispatch import receiver from django.template import engines from django.template.backends.django import DjangoTemplates from django.utils._os import to_path from django.utils.autoreload import autoreload_started, file_changed, is_django_path [c86eea6f]
- from pathlib import Path [8d8744708e7830c8-3]
