# django/tasks/exceptions

- Subject: django/tasks/exceptions (id `7531886e-dd5c-4d39-9bf3-ce721e7cd478`)
- Kind: subject
- Budget: 1200 tokens
- Used: 189 tokens
- Facts shown: 6 of 6
- Conflicts: 0
- Gaps: 0

## Facts

- class InvalidTask(TaskException): """The provided Task is invalid.""" [c5293999]
- class InvalidTaskBackend(ImproperlyConfigured): """The provided Task backend is invalid.""" [c33e4bd2]
- class TaskException(Exception): """Base class for task-related exceptions. Do not raise directly.""" [255bc9fa]
- class TaskResultDoesNotExist(TaskException): """The requested TaskResult does not exist.""" [04536be0]
- class TaskResultMismatch(TaskException): """The requested TaskResult is invalid.""" [251021d5]
- from django.core.exceptions import ImproperlyConfigured [cb27d71dfadbe105-2]
