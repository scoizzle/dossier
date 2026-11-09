# docs/ref/class-based-views/mixins-multiple-object

- Subject: docs/ref/class-based-views/mixins-multiple-object (id `c196809d-fc38-4a9f-a207-d6d340773943`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 18 of 76
- Conflicts: 0
- Gaps: 0

## Facts

- ``queryset`` is a class attribute with a *mutable* value so care must be taken when using it directly. Before using it, either call its :meth:`~django.db.models.query.QuerySet.all` method or retrieve it with :meth:`get_queryset` which takes care of the cloning behind the scenes. [73dbef469a1e5ea6]
- /objects/?page=3 [da7f53de]
- * the value of ``template_name`` on the view (if provided) * ``<app_label>/<model_name><template_name_suffix>.html`` [bc52e96f]
- .. warning:: [c54b54cb0805732a-12]
- /objects/?page=last [7a6b3cd1]
- A ``QuerySet`` that represents the objects. If provided, the value of ``queryset`` supersedes the value provided for :attr:`model`. [04b2c5e2de01f784]
- A boolean specifying whether to display the page if no objects are available. If this is ``False`` and no objects are available, the view will raise a 404 instead of displaying an empty page. By default, this is ``True``. [1e5e4c88]
- A string or list of strings specifying the ordering to apply to the ``queryset``. Valid values are the same as those for :meth:`~django.db.models.query.QuerySet.order_by`. [6237104d]
- A string specifying the name to use for the page parameter. The view will expect this parameter to be available either as a query string parameter (via ``request.GET``) or as a kwarg variable specified in the URLconf. Defaults to ``page``. [ae32be5d]
- An integer specifying how many objects should be displayed per page. If this is given, the view will paginate objects with ``paginate_by`` objects per page. The view will expect either a ``page`` query string parameter (via ``request.GET``) or a ``page`` variable specified in the URLconf. [27ec2c89]
- An integer specifying the number of "overflow" objects the last page can contain. By default this returns the value of :attr:`paginate_orphans`. [8f4e044b]
- An integer specifying the number of "overflow" objects the last page can contain. This extends the :attr:`paginate_by` limit on the last page by up to ``paginate_orphans``, in order to keep the last page from having a very small number of objects. [12bf7b9b]
- Constructed by paginating ``queryset`` into pages of size ``page_size``. If the request contains a ``page`` argument, either as a captured URL argument or as a GET argument, ``object_list`` will correspond to the objects from that page. [42d8c892]
- Designates the name of the variable to use in the context. [2f289f72e2dfd96d]
- Get the list of items for this view. This must be an iterable and may be a queryset (in which queryset-specific behavior will be enabled). [d0196f6a]
- Return the context variable name that will be used to contain the list of data that this view is manipulating. If ``object_list`` is a queryset of Django objects and :attr:`context_object_name` is not set, the context name will be the ``model_name`` of the model that the queryset is composed from, with postfix ``'_list'`` appended. For example, the model ``Article`` would have a context object named ``article_list``. [e3dbc4d5]
- Returns :attr:`ordering` by default. [404481d0]
- .. code-block:: text [3a9340cd0d877339-17]

## Beyond the budget

56 more facts did not fit in the budget: [a8c0876e] [bc607ad2] [0df91948] [a6fca086] [7fd58491] [6daafa6e] [dff00eea2fe86e53] [dcb92b8c] [c1442de8] [08a4ef8c] [f9349e9ad1d5a49b-2] [663fbf4ea591ec9f] [4c49d60f] [cdb1efc8] [5559776d] [626ad2a7] [22f6d328] [ac0dd05fa9a91c22-8] [f3c346391998d9e9-2] [f3c346391998d9e9-3] [83eda2cf63eef8ea-11] [83eda2cf63eef8ea-12] [e7b6c80190b0dbd9-2] [f20798cb89158385] [a598e6014e379321-2] [ef8b1911] [6fdf5adc] [71bf37ba] [92f358fb] [d6ca6df5] [56676d52c9f851d5] [d458942f800a329c-4] [3a9340cd0d877339-18] [708250ad] [0e06ba1d6d133a88-2] [222c66d8] [06e2c47d] [068efeaa] [2d68c45a] [b3c30b0b] [4774f92856134f81] [68e197214557455a] [5efcda8c] [3c5f343c] [0ebc46e8] [7f96930f] [2b5c244b] [0b94ae4b] [c74868ac] [ddc7b684] [1b73d427] [e47a6c6e] [76b54220] [d8585dcd] [0bdc28d2] [5968e075]
