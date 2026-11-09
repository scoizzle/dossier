# django/template/loaders/app_directories

- Subject: django/template/loaders/app_directories (id `3af582c8-de50-4324-a166-435d67312889`)
- Kind: subject
- Budget: 1200 tokens
- Used: 116 tokens
- Facts shown: 4 of 4
- Conflicts: 0
- Gaps: 0

## Facts

- """ Wrapper for loading templates from "templates" directories in INSTALLED_APPS packages. """ [8aca95fe]
- class Loader(FilesystemLoader): def get_dirs(self): return get_app_template_dirs("templates") [c510426a]
- from .filesystem import Loader as FilesystemLoader [099b9c6a]
- from django.template.utils import get_app_template_dirs [ffe2be24]
