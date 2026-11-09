# django/tasks/base

- Subject: django/tasks/base (id `ae6df5d8-e7d2-4785-8b74-c97d6c9fbcac`)
- Kind: subject
- Budget: 1200 tokens
- Used: 893 tokens
- Facts shown: 20 of 47
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

27 more facts did not fit in the budget: [c2fa3eb5] [75fb3302] [6d57833e] [68089cd8] [89ebc3c0] [abb4aea9] [744b3620] [cfeab73e] [bd4effb7] [e08e7909475adedd-2] [6933644e] [e4f143f7] [ba098a97] [a17a1204] [5e011790] [e820b1fa] [b4790545] [16b9acf4] [75222f0c] [7f63ff47] [7717ba08] [e23aace4] [a811dfd5] [fcae0a99] [cf6bbf2daef2deb8-5] [b5410d83] [59b8ee03]
