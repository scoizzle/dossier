# docs/ref/class-based-views/mixins-single-object

- Subject: docs/ref/class-based-views/mixins-single-object (id `2c4f1dc9-3977-4fd1-92eb-5ea8c9dac3b5`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2195 tokens
- Facts shown: 52 facts
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [26a7eeb7] Returns the single object that this view will display. If ``queryset`` is provided, that queryset will be used as the source of objects; otherwise, :meth:`get_queryset` will be used. ``get_object()`` looks for a :attr:`pk_url_kwarg` argument in the arguments to the view; if this argument is found, this method performs a primary-key based lookup using that value. If this argument is not found, it looks for a :attr:`slug_url_kwarg` argument, and performs a slug lookup using the :attr:`slug_field`.
- [c1874633] The base implementation of this method requires that the ``self.object`` attribute be set by the view (even if ``None``). Be sure to do this if you are using this mixin without one of the built-in views that does so.
- [d956b93d] The field on the current object instance that can be used to determine the name of a candidate template. If either ``template_name_field`` itself or the value of the ``template_name_field`` on the current object instance is ``None``, the object will not be used for a candidate template name.
- [dff00eea2fe86e53-2] The model that this view will display data for. Specifying ``model = Foo`` is effectively the same as specifying ``queryset = Foo.objects.all()``, where ``objects`` stands for ``Foo``’s :ref:`default manager <default-managers>`.
- [0ebd993a] The name of the URLConf keyword argument that contains the primary key. By default, ``pk_url_kwarg`` is ``'pk'``.
- [b27ad74e] The name of the field on the model that contains the slug. By default, ``slug_field`` is ``'slug'``.
- [e01f89f6] The suffix to append to the auto-generated candidate template name. Default suffix is ``_detail``.
- [b753e42e] This attribute can help mitigate `insecure direct object reference`_ attacks. When applications allow access to individual objects by a sequential primary key, an attacker could brute-force guess all URLs; thereby obtaining a list of all objects in the application. If users with access to individual objects should be prevented from obtaining this list, setting ``query_pk_and_slug`` to ``True`` will help prevent the guessing of URLs as each URL will require two correct, non-sequential arguments. Using a unique slug may serve the same purpose, but this scheme allows you to have non-unique slugs.
- [aaa14ed4] When :attr:`query_pk_and_slug` is ``True``, ``get_object()`` will perform its lookup using both the primary key and the slug.
- [663fbf4ea591ec9f-2] * :class:`~django.views.generic.base.TemplateResponseMixin`
- [f3c346391998d9e9-4] **Extends**
- [83eda2cf63eef8ea-13] **Methods and Attributes**
- [83eda2cf63eef8ea-14] **Methods and Attributes**
- [f20798cb89158385-2] .. attribute:: context_object_name
- [a598e6014e379321-3] .. attribute:: model
- [5fa3128a] .. attribute:: pk_url_kwarg
- [c3127255] .. attribute:: query_pk_and_slug
- [56676d52c9f851d5-2] .. attribute:: queryset
- [58330df8] .. attribute:: slug_field
- [54a2b04f] .. attribute:: slug_url_kwarg
- [6b18b1b3] .. attribute:: template_name_field
- [d458942f800a329c-5] .. attribute:: template_name_suffix
- [0e06ba1d6d133a88-4] .. method:: get_context_data(**kwargs)
- [bb757e24] .. method:: get_context_object_name(obj)
- [4579e2d9] .. method:: get_object(queryset=None)
- [4774f92856134f81-2] .. method:: get_queryset()
- [586fb919] .. method:: get_slug_field()
- [68e197214557455a-3] .. method:: get_template_names()
- [0f42fc73] A mixin class that performs template-based response rendering for views that operate upon a single object instance. Requires that the view it is mixed with provides ``self.object``, the object instance that the view is operating on. ``self.object`` will usually be, but is not required to be, an instance of a Django model. It may be ``None`` if the view is in the process of constructing a new instance.
- [8cdfe019] Provides a mechanism for looking up an object associated with the current HTTP request.
- [0d9a021a] .. class:: django.views.generic.detail.SingleObjectMixin
- [f302639e] .. class:: django.views.generic.detail.SingleObjectTemplateResponseMixin
- [db32bccd] ==================== Single object mixins ====================
- [a24cc84e] ``SingleObjectMixin`` =====================
- [e460e1dc] ``SingleObjectTemplateResponseMixin`` =====================================
