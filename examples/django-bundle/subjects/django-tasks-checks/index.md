# django/tasks/checks

- Subject: django/tasks/checks (id `cbae8250-7217-4b75-8e8c-4b9267bb75dd`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 99 tokens
- Facts shown: 4 facts
- Conflicts: 0
- Gaps: 0

## Facts

- for backend in task_backends.all(): yield from backend.check() [d9078901]
- from . import task_backends [a1f45e14]
- @checks.register def check_tasks(app_configs=None, **kwargs): """Checks all registered Task backends.""" [15a215ba]
- from django.core import checks [61bc0f5c]
