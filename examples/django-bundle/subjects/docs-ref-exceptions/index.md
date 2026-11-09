# docs/ref/exceptions

- Subject: docs/ref/exceptions (id `25929357-3845-4c26-85be-08b59ecfca3b`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 18 of 118
- Conflicts: 0
- Gaps: 0

## Facts

- * ``DisallowedHost`` * ``DisallowedModelAdminLookup`` * ``DisallowedModelAdminToField`` * ``DisallowedRedirect`` * ``InvalidSessionKey`` * ``RequestDataTooBig`` * ``SuspiciousFileOperation`` * ``SuspiciousMultipartForm`` * ``SuspiciousSession`` * ``TooManyFieldsSent`` * ``TooManyFilesSent`` [3d8ec97c]
- - A field in a model clashes with a field of the same name from an abstract base class - An infinite loop is caused by ordering - A keyword cannot be parsed from the filter parameters - A field cannot be determined from a keyword in the query parameters - A join is not permitted on the specified field - A field name is invalid - A query contains invalid order_by arguments [beabd39b]
- :exc:`SessionInterrupted` is raised when a session is destroyed in a concurrent request. It's a subclass of :exc:`~django.core.exceptions.BadRequest`. [66229b07]
- :exc:`TransactionManagementError` is raised for any and all problems related to database transactions. [ff1a38b2]
- :exc:`UnreadablePostError` is raised when a user cancels an upload. [a71e5397]
- :exc:`~client.RedirectCycleError` is raised when the test client detects a loop or an overly long chain of redirects. [3c219b5f]
- If a ``SuspiciousOperation`` exception reaches the ASGI/WSGI handler level it is logged at the ``Error`` level and results in a :class:`~django.http.HttpResponseBadRequest`. See the :doc:`logging documentation </topics/logging/>` for more information. [644fea73]
- If you are trying to call code that is synchronous-only from an asynchronous thread, then create a synchronous thread and call it in that. You can accomplish this is with :func:`asgiref.sync.sync_to_async`. [edd09b3e]
- It is internal to the HTTP handler modules and you are unlikely to see it elsewhere. If you are modifying HTTP handling code, you should raise this when you encounter an aborted request to make sure the socket is closed cleanly. [86126cff]
- Raised when a field would be fetched on-demand and the :attr:`~django.db.models.FETCH_RAISE` fetch mode is active. [e1b2c9f1]
- See :meth:`~django.db.models.Model.save`. [607dc0e0]
- See :meth:`~django.db.models.query.QuerySet.get`. [32217f6417c5039c]
- The :exc:`BadRequest` exception is raised when the request cannot be processed due to a client error. If a ``BadRequest`` exception reaches the ASGI/WSGI handler level it results in a :class:`~django.http.HttpResponseBadRequest`. [a14b751f]
- The :exc:`FieldError` exception is raised when there is a problem with a model field. This can happen for several reasons: [d6127633]
- The :exc:`ImproperlyConfigured` exception is raised when Django is somehow improperly configured -- for example, if a value in ``settings.py`` is incorrect or unparseable. [3d995243]
- The :exc:`MiddlewareNotUsed` exception is raised when a middleware is not used in the server configuration. [98116832]
- The :exc:`NoReverseMatch` exception is raised by :mod:`django.urls` when a matching URL in your URLconf cannot be identified based on the parameters supplied. [dbc7ccdc]
- .. currentmodule:: django.db [04523769]

## Beyond the budget

99 more facts did not fit in the budget: [1d555299] [9d540b41] [9a549be0] [b4c2c6ae] [59b4d3aa] [fedb1557] [67dfd47b] [6dedf199] [b327c123] [2450a3f1] [d6a7e0a9] [614ab981] [df800ad4] [ac8f1bd5] [279d1463] [c4af99c4] [a75f1536] [b14a2a311af32750] [33d1731627b8b1b3] [c877cf83] [6055ee0a] [c388c4fb] [814332fa] [6e796314] [e6032923] [8c965ff0] [a356d5de] [18a9c4c4] [6da0906f] [9a3cd129] [58a42540] [4bddeaa5] [7a79ad65] [b421d14b] [7df110ac] [52135248] [e7fe7984] [b203fe23] [c9bb9298] [169897a5] [cf95150c] [97ec152d] [3c0e80c4] [d392d692] [afdf09fc] [fc01895d] [9bf1be2e] [1dc0dae4] [a1eb26d754a3d60c-22] [0cf180bcf4ecfab5-10] [61a8fc1f] [7e3e3b48] [25524882] [42df4f47] [d15ff4d7] [4c381107] [de0c547b] [f6c61706] [f34ed08a] [379177fa] [6c60ee29] [3b830854] [4a3594c6] [e84e9678] [0557d723] [68303ae0] [755355f8] [0b123f61] [1cf593ac] [594ced0a] [30c8e34a] [61d6fe3b] [f4bf3f3a] [eb02ac1f] [c0c484eb] [1dc30b08] [5237a646] [1ac63626] [86c5812c] [4e1da572] [518e6ed3] [267df5e7] [77c87fbbd18bdfb0] [ad136136] [3c11c201] [af7fcffd] [ffeb1ee9] [5fb07009] [56b8c826] [24d47510] [fc42eb59] [dfa8e089] [bb074c3e] [367a66f8] [4ae80b24] [5ed465d7] [fa75a2c5] [147d6acc] [53085b4e]
