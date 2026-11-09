# docs/ref/class-based-views/mixins-single-object

- Subject: docs/ref/class-based-views/mixins-single-object (id `99108979-fe56-42d8-916e-a4422c87888e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 17 of 52
- Conflicts: 0
- Gaps: 0

## Facts

- Any variables from :meth:`get_context_data` take precedence over context variables from :ref:`context processors <subclassing-context-requestcontext>`. For example, if your view sets the :attr:`model` attribute to :class:`~django.contrib.auth.models.User`, the default context object name of ``user`` would override the ``user`` variable from the :func:`django.contrib.auth.context_processors.auth` context processor. Use :meth:`get_context_object_name` to avoid a clash. [8d3482c2]
- ``queryset`` is a class attribute with a *mutable* value so care must be taken when using it directly. Before using it, either call its :meth:`~django.db.models.query.QuerySet.all` method or retrieve it with :meth:`get_queryset` which takes care of the cloning behind the scenes. [73dbef469a1e5ea6-2]
- * ``object``: The object that this view is displaying (``self.object``). * ``context_object_name``: ``self.object`` will also be stored under the name returned by :meth:`get_context_object_name`, which defaults to the lowercased version of the model name. [ccf11f95]
- * the contents of the ``template_name_field`` field on the object instance that the view is operating upon (if available) * ``<app_label>/<model_name><template_name_suffix>.html`` [4984d5dd]
- .. _insecure direct object reference: https://wiki.owasp.org/index.php/Top_10_2013-A4-Insecure_Direct_Object_References [625c84a9]
- .. admonition:: Context variables override values from template context processors [25fd8b69]
- .. warning:: [c54b54cb0805732a-13]
- A ``QuerySet`` that represents the objects. If provided, the value of ``queryset`` supersedes the value provided for :attr:`model`. [04b2c5e2de01f784-2]
- Designates the name of the variable to use in the context. [2f289f72e2dfd96d-2]
- If ``True``, causes :meth:`get_object` to perform its lookup using both the primary key and the slug. Defaults to ``False``. [ad0a165e]
- It returns a dictionary with these contents: [8f66db97]
- Return the context variable name that will be used to contain the data that this view is manipulating. If :attr:`context_object_name` is not set, the context name will be constructed from the ``model_name`` of the model that the queryset is composed from. For example, the model ``Article`` would have context object named ``'article'``. [feb72665]
- Returns a list of candidate template names. Return a list containing ``template_name``, if set on the value. Otherwise, return a list containing: [950ef6d7]
- Returns context data for displaying the object. [2203bbd6]
- Returns the name of a slug field to be used to look up by slug. By default this returns the value of :attr:`slug_field`. [8e5aaa24]
- Returns the queryset that will be used to retrieve the object that this view will display. By default, :meth:`get_queryset` returns the value of the :attr:`queryset` attribute if it is set, otherwise it constructs a :class:`~django.db.models.query.QuerySet` by calling the ``all()`` method on the :attr:`model` attribute's default manager. [48dbd495]
- The name of the URLConf keyword argument that contains the slug. By default, ``slug_url_kwarg`` is ``'slug'``. [6290d7c8]

## Beyond the budget

35 more facts did not fit in the budget: [26a7eeb7] [c1874633] [d956b93d] [dff00eea2fe86e53-2] [0ebd993a] [b27ad74e] [e01f89f6] [b753e42e] [aaa14ed4] [663fbf4ea591ec9f-2] [f3c346391998d9e9-4] [83eda2cf63eef8ea-13] [83eda2cf63eef8ea-14] [f20798cb89158385-2] [a598e6014e379321-3] [5fa3128a] [c3127255] [56676d52c9f851d5-2] [58330df8] [54a2b04f] [6b18b1b3] [d458942f800a329c-5] [0e06ba1d6d133a88-4] [bb757e24] [4579e2d9] [4774f92856134f81-2] [586fb919] [68e197214557455a-3] [0f42fc73] [8cdfe019] [0d9a021a] [f302639e] [db32bccd] [a24cc84e] [e460e1dc]
