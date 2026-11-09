# django/tasks/checks

- Subject: django/tasks/checks (id `baffb9ba-8f1e-446e-a1d8-346faee9234e`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 99 tokens
- Facts shown: 4 of 4
- Conflicts: 0
- Gaps: 0

## Facts

- for backend in task_backends.all(): yield from backend.check() [d9078901]
- from . import task_backends [a1f45e14]
- @checks.register def check_tasks(app_configs=None, **kwargs): """Checks all registered Task backends.""" [15a215ba]
- from django.core import checks [61bc0f5c]
