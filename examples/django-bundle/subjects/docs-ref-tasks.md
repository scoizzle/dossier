# docs/ref/tasks

- Subject: docs/ref/tasks (id `46961245-ed49-4ea7-881c-3caa3ecc0b33`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 27 of 174
- Conflicts: 0
- Gaps: 0

## Facts

- * :attr:`priority <Task.priority>` * :attr:`backend <Task.backend>` * :attr:`queue_name <Task.queue_name>` * :attr:`run_after <Task.run_after>` [93757dd0]
- @task(foo=5, bar=600) def my_task(): pass [6710b8a3]
- A dictionary of extra parameters for the Task backend. These are provided using the :setting:`OPTIONS <TASKS-OPTIONS>` setting. [73260931]
- A list of :class:`TaskError` instances for the errors raised as part of each execution of the Task. [1e584054]
- A list of results for the enqueued Tasks, in the order they were enqueued. [28de00a4]
- A unique identifier for the result, which can be passed to :meth:`Task.get_result`. [3c80154f]
- Arguments are passed to the ``Task``'s function after a round-trip through a :func:`json.dumps`/:func:`json.loads` cycle. Hence, all arguments must be JSON-serializable and preserve their type after the round-trip. [c57fb4a3]
- Clears the list of stored results. [0ffd68c3]
- Creates a new ``Task`` with modified defaults. The existing ``Task`` is left unchanged. [ce5bef95]
- Enqueues the ``Task`` to the ``Task`` backend for later execution. [de94ae03]
- If the ``Task`` did not finish successfully, :exc:`ValueError` is raised. [0b214f83]
- If the ``Task`` is not valid according to the backend, :exc:`~django.tasks.exceptions.InvalidTask` is raised. [47469314]
- If the backend does not support ``get_result()``, :exc:`NotImplementedError` is raised. [7ead6c5a]
- If the result does not exist, :exc:`TaskResultDoesNotExist <django.tasks.exceptions.TaskResultDoesNotExist>` is raised. If the result is not the same type as the current Task, :exc:`TaskResultMismatch <django.tasks.exceptions.TaskResultMismatch>` is raised. If the backend does not support ``get_result()``, :exc:`NotImplementedError` is raised. [6f5ade99]
- If the task is currently running, it does not count as an attempt. [579bed86]
- Refresh the result's attributes from the queue store. [01a355cf]
- Retrieve a result by its id. If the result does not exist, :exc:`TaskResultDoesNotExist <django.tasks.exceptions.TaskResultDoesNotExist>` is raised. [a0d1dc38]
- Retrieves a result by its id. [67a192b1]
- See :ref:`Task results <task-results>` for more details. [baae7aa7]
- See :ref:`enqueueing Tasks <enqueueing-tasks>` for usage examples. [4a94111c]
- See :ref:`modifying Tasks <modifying-tasks>` for usage examples. [058ad9f7]
- See :ref:`return values <task-return-values>` for usage examples. [bb2e400f]
- Support for passing arbitrary ``**kwargs`` to the ``@task`` decorator is added. [4d4c87fd]
- Task backends which subclass ``BaseTaskBackend`` should implement this method as a minimum. [b3f7347b]
- The :class:`TaskResult` currently being run. [b0b73316]
- The :class:`Task` has finished executing successfully. [27d0c60c]
- .. attribute:: Task.backend [c793e4ea]

## Beyond the budget

146 more facts did not fit in the budget: [c268d8ce] [10fdad01] [a5e017a9] [67386759] [6664fec5] [a5c69650] [d59f0c09] [49d253c5] [040fc0f6] [b52a3c4a] [885377a6] [9ccc8d55] [93322a66] [49efb46c] [1bb43bb6] [5f4c8716] [672fe107] [50480a94] [873043a7] [38d9860c] [e3d3972e] [e784a154] [5ba1b0ef] [faf73cce] [80f7abd6] [66b071d9] [04ffe37e] [69e1e9b0] [6cf653a0] [a9a7d0f8] [2f20dc80] [e2af7f41] [737b0e8c] [9fc9d0de] [d7ee9f4f] [50bc0caf] [b6936793] [733e2894] [74185d42] [56547294] [b5591972] [87187d41] [41fc2434] [45a1f5e1] [4ae3ba7c] [a94941c3] [6dc1a91c] [2b04ca86] [328b5417] [afd4ed72] [7cf7a31a] [d5866d5e] [9ba73312] [8f3351d2] [266f5a24] [f02c0b8a] [f0db2c19] [700c0cb3] [9308b202] [42244f90] [626f3398] [2caefcfc] [35d52473] [63eb0c20] [3da28cb7] [03bdecc9] [8cb494f7] [a576fe82] [507eca9e] [326caa5c] [b426df57] [3ccd4b53] [909630ad] [4bf8479f] [019215a6] [963d126e] [95cd8b7e] [2a966a198e13032b-26] [aae17f13] [6325cfd0] [01e25781] [095db439] [0caa3949] [cd4dab69] [3eb0c0fa] [c3e4e08d] [3b047703] [f7805b53] [ae9e7003] [c180fba0] [be9e9733] [d21a6d9f] [f77b9e52] [b145ea91] [412c5211] [6ccfc51c] [c9a2727c] [370fe608] [9cd6e114] [8ee649ef] [ed711c46] [51519b08] [f78b1d6e] [ba65c0c3] [d1f7f909] [63a89301] [29feccb3] [033159bc] [932b16cb] [1252f2a1] [8172a79d] [2b380f5e] [d463424d] [b6f77b51] [d17846f3] [12e4041f] [1e0b71c8] [cebee45b] [8deac109] [ba446b8f] [951ffb85] [545c270d] [1213fd20] [61df3195] [f4a71c89] [a1eb26d754a3d60c-34] [c1321a15] [2ad464b1] [9b614504] [b60cb2ef] [d35c23ae] [3744dbd6] [5d778bec] [c01017e7] [458050e52503f721-6] [0c8ab375] [76ba946b] [16fb0378] [167ae344] [c0c8aedb] [2b2aa894] [21c8ba7a] [d0627662] [e1dd7bd8] [6ef63d77] [2a024f94]
