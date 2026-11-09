# docs/ref/checks

- Subject: docs/ref/checks (id `e7f32724-759e-493a-a38f-4c7aaad49b1e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 12 of 109
- Conflicts: 0
- Gaps: 0

## Facts

- Constructor arguments are: [2df22b96]
- The warnings and errors raised by system checks must be instances of ``CheckMessage``. An instance encapsulates a single reportable error or warning. It also provides context and hints applicable to the message, and a unique identifier that is used for filtering purposes. [95403215]
- ``hint`` A single-line string providing a hint for fixing the problem. If no hint can be provided, or the hint is self-evident from the error message, the hint can be omitted, or a value of ``None`` can be used. [918bb5e1]
- ``id`` Optional string. A unique identifier for the issue. Identifiers should follow the pattern ``applabel.X001``, where ``X`` is one of the letters ``CEWID``, indicating the message severity (``C`` for criticals, ``E`` for errors and so). The number can be allocated by the application, but should be unique within that application. [d2220baf]
- ``level`` The severity of the message. Use one of the predefined values: ``DEBUG`` , ``INFO``, ``WARNING``, ``ERROR``, ``CRITICAL``. If the level is greater or equal to ``ERROR``, then Django will prevent management commands from executing. Messages with level lower than ``ERROR`` (i.e. warnings) are reported to the console, but can be silenced. [f6fb39dc]
- ``msg`` A short (less than 80 characters) string describing the problem. The string should *not* contain newlines. [c3e74b44]
- ``obj`` Optional. An object providing context for the message (for example, the model where the problem was discovered). The object should be a model, field, or manager or any other object that defines a ``__str__()`` method. The method is used while reporting all messages and its result precedes the message. [5c78c509]
- The ``gis`` tag was added. [84bbd6d2]
- * **2_0.W001**: Your URL pattern ``<pattern>`` has a ``route`` that contains ``(?P<``, begins with a ``^``, or ends with a ``$``. This was likely an oversight when migrating from ``url()`` to :func:`~django.urls.path`. * **4_0.E001**: As of Django 4.0, the values in the :setting:`CSRF_TRUSTED_ORIGINS` setting must start with a scheme (usually ``http://`` or ``https://``) but found ``<hostname>``. [27956cd2]
- * **admin.E201**: Cannot exclude the field ``<field name>``, because it is the foreign key to the parent model ``<app_label>.<model>``. * **admin.E202**: ``<model>`` has no ``ForeignKey`` to ``<parent model>``./ ``<model>`` has more than one ``ForeignKey`` to ``<parent model>``. You must specify a ``fk_name`` attribute. * **admin.E203**: The value of ``extra`` must be an integer. * **admin.E204**: The value of ``max_num`` must be an integer. * **admin.E205**: The value of ``min_num`` must be an integer. * **admin.E206**: The value of ``formset`` must inherit from ``BaseModelFormSet``. [a30059a5]
- * **admin.E301**: ``<model>`` has no ``GenericForeignKey``. * **admin.E302**: ``'ct_field'`` references ``<label>``, which is not a field on ``<model>``. * **admin.E303**: ``'ct_fk_field'`` references ``<label>``, which is not a field on ``<model>``. * **admin.E304**: ``<model>`` has no ``GenericForeignKey`` using content type field ``<field name>`` and object ID field ``<field name>``. [f743a31c]
- .. _sites-system-checks: [5773811c]

## Beyond the budget

95 more facts did not fit in the budget: [80943660] [99e39815] [6f9d328b] [80b58c60] [db1a85d4] [1c82c241] [4c3904f8] [f3d40c46] [b2a183b9] [edda9212] [d4ae9c9f] [d58093ec] [4a26b67c] [fd06c59d] [5953a98a] [65b212a9] [9a87ba6e] [2d1fbd96] [43cc9c1c] [79a87cde] [14eb1ed2] [c3ba36bc] [f6adf825] [41d88798] [809aec1c] [05416de9] [b979a457] [0ddca764] [83789d19] [734851ed] [b27ca4ff] [acbd0c51f780d445] [8cfe0e5e] [e3d58a01] [07429ef8] [492100e1] [8f01f09d] [69232ba0] [67ff5d59] [67f9ac2b] [1fc628c8] [aedca6f2] [45f3e68f] [20c7749c] [2601129f] [e6e29add] [7db73fed] [c1d53000] [04559b65] [c375cb9f] [41ad03dd1251d50b] [43704c69] [5984b998] [a8781ba8] [6638661763b46374] [a1b10647] [6d720004] [2b9444a730838e7a] [c0d7d146] [f0b54d4f] [9e4d0fc0] [8a2b9838] [9f46a4c9] [d5491821] [a7ca519f] [c155baa8] [fc963867] [2a577a12] [77572920] [96b828b8] [b7886a68] [3796ba1f] [ae915c92] [c0e4af0f] [0f05670e] [5011740b] [3333c0d5] [c49daa75] [87512950] [997837f8] [173938a2] [3a41affc1b4582de] [1f9a83c5] [929689c6] [8efd848e] [d70f43f0] [7bf38ae1] [7e84336b] [305f3bc3] [fbed108d] [3a0e3754] [8a12fe0a] [335fb65b] [90f37906] [dac14a54]
