# django/tasks/signals

- Subject: django/tasks/signals (id `b084a1f1-5cdd-4a6b-b327-2de7ced2a350`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 475 tokens
- Facts shown: 11 facts
- Conflicts: 0
- Gaps: 0

## Facts

- task_backends._settings = task_backends.settings = ( task_backends.configure_settings(None) ) task_backends._connections = Local() [aac2090b]
- @receiver(setting_changed) def clear_tasks_handlers(*, setting, **kwargs): """Reset the connection handler whenever the settings change.""" if setting == "TASKS": from . import task_backends [fb4496d0]
- @receiver(task_enqueued) def log_task_enqueued(sender, task_result, **kwargs): logger.debug( "Task id=%s path=%s enqueued backend=%s", task_result.id, task_result.task.module_path, task_result.backend, ) [3ef46850]
- @receiver(task_finished) def log_task_finished(sender, task_result, **kwargs): # Signal is sent inside exception handlers, so exc_info() is available. exc_info = sys.exc_info() logger.log( ( logging.ERROR if task_result.status == TaskResultStatus.FAILED else logging.INFO ), "Task id=%s path=%s state=%s", task_result.id, task_result.task.module_path, task_result.status, exc_info=exc_info if exc_info[0] else None, ) [eeed0394]
- @receiver(task_started) def log_task_started(sender, task_result, **kwargs): logger.info( "Task id=%s path=%s state=%s", task_result.id, task_result.task.module_path, task_result.status, ) [7b66dc79]
- from .base import TaskResultStatus [0b469ac5]
- from asgiref.local import Local [6beab4e4549a99b7]
- from django.core.signals import setting_changed from django.dispatch import Signal, receiver [6f6a858e]
- import logging import sys [bf933052]
- logger = logging.getLogger("django.tasks") [27aca4e5]
- task_enqueued = Signal() task_finished = Signal() task_started = Signal() [2ecf4d7e]
