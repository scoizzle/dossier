# django/tasks/base

- Subject: django/tasks/base (id `f94528b1-2ffb-4086-8572-80c1a905bdfc`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2283 tokens
- Facts shown: 47 of 47
- Conflicts: 0
- Gaps: 0

## Highlights

- If the task didn't succeed, an exception is raised. This is to distinguish against the task returning None. """ if self.status == TaskResultStatus.SUCCESSFUL: return self._return_value elif self.status == TaskResultStatus.FAILED: raise ValueError("Task failed") else: raise ValueError("Task has not finished yet") [0de4a2d5]
- Raise TaskResultDoesNotExist if such result does not exist, or raise TaskResultMismatch if the result exists but belongs to another Task. """ result = self.get_backend().get_result(result_id) if result.task.func != self.func: raise TaskResultMismatch( f"Task does not match (received {result.task.module_path!r})" ) return result [4cc5c6eb]
- changes = {} if priority is not None: changes["priority"] = priority if queue_name is not None: changes["queue_name"] = queue_name if run_after is not None: changes["run_after"] = run_after if backend is not None: changes["backend"] = backend return replace(self, **changes) [12ec69ce]
- for attr in TASK_REFRESH_ATTRS: object.__setattr__(self, attr, getattr(refreshed_task, attr)) [8cfa2ab6]
- if not isclass(exception_class) or not issubclass( exception_class, BaseException ): raise ValueError( f"{self.exception_class_path!r} does not reference a valid exception." ) return exception_class [1af7a553]
- return (self.__class__._reconstruct, (kwargs,)) [401cecbd]
- return task_backends[self.backend] [35e556fa]
- # Time the task was last attempted to be run. last_attempted_at: datetime | None [fed7ebb5]
- # Whether the Task receives the Task context when executed. takes_context: bool = False [fca66b58]
- @classmethod def _reconstruct(cls, kwargs): func_path = kwargs["func"] try: func = import_string(func_path) kwargs["func"] = func.func except (ImportError, AttributeError) as e: msg = f"Expected {func_path!r} to point to a Task instance." raise ValueError(msg) from e return cls(**kwargs) [54b71eb4]
- @property def attempt(self): return self.task_result.attempts [291a9121]
- @property def attempts(self): return len(self.worker_ids) [a2818365]
- @property def exception_class(self): # Lazy resolve the exception class. exception_class = import_string(self.exception_class_path) [e1f1e505]
- @property def is_finished(self): return self.status in {TaskResultStatus.FAILED, TaskResultStatus.SUCCESSFUL} [20a02c6c]
- @property def module_path(self): return f"{self.func.__module__}.{self.func.__qualname__}" [bf550946]
- @property def name(self): return self.func.__name__ [d3c780d6]
- @property def return_value(self): """ The return value of the task. [e2cdc225]
- _return_value: Any | None = field(init=False, default=None) [fb22926c]
- args: list[Any] # Arguments to pass to the task function. kwargs: dict[str, Any] # Keyword arguments to pass to the task function. backend: str errors: list[TaskError] # Errors raised when running the task. worker_ids: list[str] # Workers which have processed the task. [44df2a0e]
- def __post_init__(self): self.get_backend().validate_task(self) [d922b1ff]

## All facts

- [c2fa3eb5] async def acall(self, *args, **kwargs): if iscoroutinefunction(self.func): return await self.func(*args, **kwargs) return await sync_to_async(self.func)(*args, **kwargs)
- [75fb3302] async def aenqueue(self, *args, **kwargs): """Queue up the Task to be executed.""" return await self.get_backend().aenqueue(self, args, kwargs)
- [6d57833e] async def aget_result(self, result_id): """See get_result().""" result = await self.get_backend().aget_result(result_id) if result.task.func != self.func: raise TaskResultMismatch( f"Task does not match (received {result.task.module_path!r})" ) return result
- [68089cd8] async def arefresh(self): """ Reload the cached task data from the task store """ refreshed_task = await self.task.get_backend().aget_result(self.id) for attr in TASK_REFRESH_ATTRS: object.__setattr__(self, attr, getattr(refreshed_task, attr))
- [89ebc3c0] def __post_init__(self): object.__setattr__(self, "args", normalize_json(self.args)) object.__setattr__(self, "kwargs", normalize_json(self.kwargs))
- [abb4aea9] def __reduce__(self): kwargs = {f.name: getattr(self, f.name) for f in fields(self)} kwargs["func"] = self.module_path
- [744b3620] def call(self, *args, **kwargs): if iscoroutinefunction(self.func): return async_to_sync(self.func)(*args, **kwargs) return self.func(*args, **kwargs)
- [cfeab73e] def enqueue(self, *args, **kwargs): """Queue up the Task to be executed.""" return self.get_backend().enqueue(self, args, kwargs)
- [bd4effb7] def get_backend(self): from . import task_backends
- [e08e7909475adedd-2] def get_result(self, result_id): """ Retrieve a task result by id.
- [6933644e] def refresh(self): """Reload the cached task data from the task store.""" refreshed_task = self.task.get_backend().get_result(self.id)
- [e4f143f7] def using( self, *, priority=None, queue_name=None, run_after=None, backend=None, ): """Create a new Task with modified defaults."""
- [ba098a97] def wrapper(f): return task_backends[backend].task_class( func=f, priority=priority, queue_name=queue_name, backend=backend, takes_context=takes_context, **kwargs, )
- [a17a1204] id: str # Unique identifier for the task result. status: TaskResultStatus enqueued_at: datetime | None # Time the task was enqueued. started_at: datetime | None # Time the task was started. finished_at: datetime | None # Time the task was finished.
- [5e011790] if "run_after" in kwargs: raise TypeError( "run_after cannot be defined statically with the @task decorator. " "Use .using(run_after=...) to set it dynamically." )
- [e820b1fa] if function: return wrapper(function) return wrapper
- [b4790545] @dataclass(frozen=True, slots=True, kw_only=True) class Task: func: Callable[..., Any] # The Task function. priority: int = DEFAULT_TASK_PRIORITY backend: str = DEFAULT_TASK_BACKEND_ALIAS queue_name: str = DEFAULT_TASK_QUEUE_NAME run_after: datetime | None = None # The earliest this Task will run.
- [16b9acf4] @dataclass(frozen=True, slots=True, kw_only=True) class TaskContext: task_result: TaskResult
- [75222f0c] @dataclass(frozen=True, slots=True, kw_only=True) class TaskError: exception_class_path: str traceback: str
- [7f63ff47] @dataclass(frozen=True, slots=True, kw_only=True) class TaskResult: task: Task
- [7717ba08] DEFAULT_TASK_BACKEND_ALIAS = "default" DEFAULT_TASK_PRIORITY = 0 DEFAULT_TASK_QUEUE_NAME = "default" TASK_MAX_PRIORITY = 100 TASK_MIN_PRIORITY = -100 TASK_REFRESH_ATTRS = { "errors", "_return_value", "finished_at", "started_at", "last_attempted_at", "status", "enqueued_at", "worker_ids", }
- [e23aace4] class TaskResultStatus(TextChoices): # The Task has just been enqueued, or is ready to be executed again. READY = ("READY", pgettext_lazy("Task", "Ready")) # The Task is currently running. RUNNING = ("RUNNING", pgettext_lazy("Task", "Running")) # The Task raised an exception during execution, or was unable to start. FAILED = ("FAILED", pgettext_lazy("Task", "Failed")) # The Task has finished running successfully. SUCCESSFUL = ("SUCCESSFUL", pgettext_lazy("Task", "Successful"))
- [a811dfd5] def task( function=None, *, priority=DEFAULT_TASK_PRIORITY, queue_name=DEFAULT_TASK_QUEUE_NAME, backend=DEFAULT_TASK_BACKEND_ALIAS, takes_context=False, **kwargs, ): from . import task_backends
- [fcae0a99] from .exceptions import TaskResultMismatch
- [cf6bbf2daef2deb8-5] from asgiref.sync import async_to_sync, sync_to_async
- [b5410d83] from collections.abc import Callable from dataclasses import dataclass, field, fields, replace from datetime import datetime from inspect import isclass, iscoroutinefunction from typing import Any
- [59b8ee03] from django.db.models.enums import TextChoices from django.utils.json import normalize_json from django.utils.module_loading import import_string from django.utils.translation import pgettext_lazy
