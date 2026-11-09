# django/tasks/backends/dummy

- Subject: django/tasks/backends/dummy (id `5230c82d-221e-4b0d-9104-16ed0507c14c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 531 tokens
- Facts shown: 13 of 13
- Conflicts: 0
- Gaps: 0

## Facts

- # Copy the task to prevent mutation issues. return deepcopy(result) [c0fc99df]
- result = TaskResult( task=task, id=get_random_string(32), status=TaskResultStatus.READY, enqueued_at=None, started_at=None, last_attempted_at=None, finished_at=None, args=args, kwargs=kwargs, backend=self.alias, errors=[], worker_ids=[], ) [528ab8db]
- self._store_result(result) [e1d5d132]
- async def aget_result(self, result_id): try: return next(result for result in self.results if result.id == result_id) except StopIteration: raise TaskResultDoesNotExist(result_id) from None [bc444b8f]
- def __init__(self, alias, params): super().__init__(alias, params) self.results = [] [9699a17b]
- def _store_result(self, result): object.__setattr__(result, "enqueued_at", timezone.now()) self.results.append(result) task_enqueued.send(type(self), task_result=result) [148ae471]
- def clear(self): self.results.clear() [3dd54dab]
- def enqueue(self, task, args, kwargs): self.validate_task(task) [3214eb3522808c86]
- def get_result(self, result_id): # Results are only scoped to the current thread, hence # supports_get_result is False. try: return next(result for result in self.results if result.id == result_id) except StopIteration: raise TaskResultDoesNotExist(result_id) from None [f5b8fed7]
- class DummyBackend(BaseTaskBackend): supports_defer = True supports_async_task = True supports_priority = True [f8da94c7]
- from .base import BaseTaskBackend [ec93358e22b4631a]
- from copy import deepcopy [ed4edd1d59c7513d-2]
- from django.tasks.base import TaskResult, TaskResultStatus from django.tasks.exceptions import TaskResultDoesNotExist from django.tasks.signals import task_enqueued from django.utils import timezone from django.utils.crypto import get_random_string [69399d32]
