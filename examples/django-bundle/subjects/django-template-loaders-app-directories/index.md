# django/template/loaders/app_directories

- Subject: django/template/loaders/app_directories (id `e7172b9a-df44-4294-8576-e530e605af3c`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 116 tokens
- Facts shown: 4 facts
- Conflicts: 0
- Gaps: 0

## Facts

- """ Wrapper for loading templates from "templates" directories in INSTALLED_APPS packages. """ [8aca95fe]
- class Loader(FilesystemLoader): def get_dirs(self): return get_app_template_dirs("templates") [c510426a]
- from .filesystem import Loader as FilesystemLoader [099b9c6a]
- from django.template.utils import get_app_template_dirs [ffe2be24]
