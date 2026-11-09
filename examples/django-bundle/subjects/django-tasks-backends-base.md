# django/tasks/backends/base

- Subject: django/tasks/backends/base (id `242a12c7-9614-4b2e-8413-7c6a5ca47d31`)
- Kind: subject
- Budget: 1200 tokens
- Used: 890 tokens
- Facts shown: 20 of 22
- Conflicts: 0
- Gaps: 0

## Facts

- Raise TaskResultDoesNotExist if such result does not exist. """ raise NotImplementedError( "This backend does not support retrieving or refreshing results." ) [464246bb]
- if ( settings.USE_TZ and task.run_after is not None and not timezone.is_aware(task.run_after) ): raise InvalidTask("run_after must be an aware datetime.") [982a8c85]
- if not self.supports_async_task and iscoroutinefunction(task.func): raise InvalidTask("Backend does not support async Tasks.") [4d7493d5]
- if not self.supports_defer and task.run_after is not None: raise InvalidTask("Backend does not support run_after.") [d40b3d15]
- if not self.supports_priority and task.priority != DEFAULT_TASK_PRIORITY: raise InvalidTask("Backend does not support setting priority of tasks.") if ( task.priority < TASK_MIN_PRIORITY or task.priority > TASK_MAX_PRIORITY or int(task.priority) != task.priority ): raise InvalidTask( f"priority must be a whole number between {TASK_MIN_PRIORITY} and " f"{TASK_MAX_PRIORITY}." ) [edc2d3ff]
- if self.queues and task.queue_name not in self.queues: raise InvalidTask(f"Queue '{task.queue_name}' is not valid for backend.") [8295f8c9]
- task_func_args = get_func_args(task.func) if task.takes_context and ( not task_func_args or task_func_args[0] != "context" ): raise InvalidTask( "Task takes context but does not have a first argument of 'context'." ) [8e3ee46b]
- # Does the backend support Tasks to be enqueued with the run_after # attribute? supports_defer = False [97b6383e]
- # Does the backend support coroutines to be enqueued? supports_async_task = False [742baa5f]
- # Does the backend support executing Tasks in a given # priority order? supports_priority = False [dc70bfc3]
- # Does the backend support results being retrieved (from any # thread/process)? supports_get_result = False [74e4bb01]
- @abstractmethod def enqueue(self, task, args, kwargs): """Queue up a task to be executed.""" [13508fb1]
- async def aenqueue(self, task, args, kwargs): """Queue up a task function (or coroutine) to be executed.""" return await sync_to_async(self.enqueue, thread_sensitive=True)( task=task, args=args, kwargs=kwargs ) [d6a971b4]
- async def aget_result(self, result_id): """See get_result().""" return await sync_to_async(self.get_result, thread_sensitive=True)( result_id=result_id ) [be3da74d]
- def __init__(self, alias, params): self.alias = alias self.queues = set(params.get("QUEUES", [DEFAULT_TASK_QUEUE_NAME])) self.options = params.get("OPTIONS", {}) [c667de4a]
- def check(self, **kwargs): return [] [29d2ea2570acf4bf-3]
- def get_result(self, result_id): """ Retrieve a task result by id. [e08e7909475adedd]
- def validate_task(self, task): """ Determine whether the provided Task can be executed by the backend. """ if not is_module_level_function(task.func): raise InvalidTask("Task function must be defined at a module level.") [996646af]
- class BaseTaskBackend(metaclass=ABCMeta): task_class = Task [1d51a7fe]
- from asgiref.sync import sync_to_async [770890ad88958a4c-14]

## Beyond the budget

2 more facts did not fit in the budget: [9a78cee9] [2fd90c59]
