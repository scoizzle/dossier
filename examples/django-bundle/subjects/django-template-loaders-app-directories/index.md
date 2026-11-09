# django/template/loaders/app_directories

- Subject: django/template/loaders/app_directories (id `01fc3258-3db8-411e-b4c5-614a94d22f8b`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 116 tokens
- Facts shown: 4 of 4
- Conflicts: 0
- Gaps: 0

## Facts

- """ Wrapper for loading templates from "templates" directories in INSTALLED_APPS packages. """ [8aca95fe]
- class Loader(FilesystemLoader): def get_dirs(self): return get_app_template_dirs("templates") [c510426a]
- from .filesystem import Loader as FilesystemLoader [099b9c6a]
- from django.template.utils import get_app_template_dirs [ffe2be24]
