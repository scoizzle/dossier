# django/tasks/__init__

- Subject: django/tasks/__init__ (id `e2c5ab46-b84c-41b2-b462-30657b64f8c2`)
- Kind: subject
- Budget: 1200 tokens
- Used: 332 tokens
- Facts shown: 7 of 7
- Conflicts: 0
- Gaps: 0

## Facts

- def create_connection(self, alias): params = self.settings[alias] backend = params["BACKEND"] try: backend_cls = import_string(backend) except ImportError as e: raise InvalidTaskBackend(f"Could not find backend '{backend}': {e}") from e return backend_cls(alias=alias, params=params) [87e9dcc2]
- __all__ = [ "DEFAULT_TASK_BACKEND_ALIAS", "DEFAULT_TASK_QUEUE_NAME", "default_task_backend", "task", "task_backends", "Task", "TaskContext", "TaskResult", "TaskResultStatus", ] [57702ea0]
- class TaskBackendHandler(BaseConnectionHandler): settings_name = "TASKS" exception_class = InvalidTaskBackend [da09b3a2]
- default_task_backend = ConnectionProxy(task_backends, DEFAULT_TASK_BACKEND_ALIAS) [0c297920]
- from . import checks, signals # NOQA from .base import ( DEFAULT_TASK_BACKEND_ALIAS, DEFAULT_TASK_QUEUE_NAME, Task, TaskContext, TaskResult, TaskResultStatus, task, ) from .exceptions import InvalidTaskBackend [460c18b8]
- from django.utils.connection import BaseConnectionHandler, ConnectionProxy from django.utils.module_loading import import_string [bf5cd5c4]
- task_backends = TaskBackendHandler() [92736168]
