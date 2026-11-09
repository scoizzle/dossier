# docs/ref/class-based-views/base

- Subject: docs/ref/class-based-views/base (id `865b37a4-65d1-47a1-aee6-df1becdc6ae4`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 22 of 98
- Conflicts: 0
- Gaps: 0

## Facts

- ["get", "post", "put", "patch", "delete", "head", "options", "trace"] [581a13c3]
- def get_context_data(self, **kwargs): context = super().get_context_data(**kwargs) context["latest_articles"] = Article.objects.all()[:5] return context [8dc90cbd]
- def get_redirect_url(self, *args, **kwargs): article = get_object_or_404(Article, pk=kwargs["pk"]) article.update_counter() return super().get_redirect_url(*args, **kwargs) [3375f7e3]
- response = MyView.as_view()(request) [b9206c5a]
- .. versionadded:: 6.1 [0cf180bcf4ecfab5]
- Assigns the :class:`~django.http.HttpRequest` to the view's ``request`` attribute, and any positional and/or keyword arguments :ref:`captured from the URL pattern <how-django-processes-a-request>` to the ``args`` and ``kwargs`` attributes, respectively. [799df16a]
- By default, a ``HEAD`` request will be delegated to ``get()``. If you need to handle ``HEAD`` requests in a different way than ``GET``, you can override the ``head()`` method. See :ref:`supporting-other-http-methods` for an example. [20570c69]
- Constructs the target URL for redirection. [13378905]
- Default:: [ba513adf016e975e]
- Handles responding to requests for the OPTIONS HTTP verb. Returns a response with the ``Allow`` header containing a list of the view's allowed HTTP method names. [cd531065]
- If :attr:`url` is not set, ``get_redirect_url()`` tries to reverse the :attr:`pattern_name` using what was captured in the URL (both named and unnamed groups are used). [79201b46]
- If a ``View`` subclass defines asynchronous (``async def``) method handlers, ``as_view()`` will mark the returned callable as a coroutine function. An ``ImproperlyConfigured`` exception will be raised if both asynchronous (``async def``) and synchronous (``def``) handlers are defined on a single view-class. [c2e36138]
- If overriding this method, you must call ``super()``. [4a5aa1f5]
- If requested by :attr:`query_string`, it will also append the query string to the generated URL. Subclasses may implement any behavior they wish, as long as the method returns a redirect-ready URL string. [3fce417a]
- If the other HTTP methods handlers on the class are asynchronous (``async def``) then the response will be wrapped in a coroutine function for use with ``await``. [cc94c71a]
- If the view was called with an HTTP method it doesn't support, this method is called instead. [0f7e7e01]
- Performs key view initialization prior to :meth:`dispatch`. [072e1f3a]
- Returns a callable view that takes a request and returns a response:: [aca29df1]
- The URL to redirect to, as a string. Or ``None`` to raise a 410 (Gone) HTTP error. [f4f94abb]
- The ``args`` and ``kwargs`` arguments are positional and/or keyword arguments :ref:`captured from the URL pattern <how-django-processes-a-request>`, respectively. [bba17688]
- The ``view`` part of the view -- the method that accepts a ``request`` argument plus arguments, and returns an HTTP response. [6305191a]
- **Attributes** [37f612b97e1bc71b]

## Beyond the budget

72 more facts did not fit in the budget: [60ed48d7] [5596a997] [a85a3d04] [f6eaf024] [5d7f131c] [a5351651] [ecd5db31] [69f58cc5] [2542f458] [a862d9a1] [83f36ede] [c5e0a864] [cafee15d] [1d91c9c1] [69dbb3213d5b379f] [94f78459] [d46bb570] [c537d1941a7e3025-6] [b64869c9] [6a848170] [8054800a] [b643e9e3] [9a52e769] [06553aa8] [6aa16a3c] [8f278462] [347eab05] [d84fb157] [704e9dc2] [b7741a2ef07f59a9] [3ec736cc] [32590fb0e4b1f943] [32590fb0e4b1f943-2] [37f612b97e1bc71b-2] [ac0dd05fa9a91c22] [0bb9c224e2c5db9d] [0bb9c224e2c5db9d-2] [0bb9c224e2c5db9d-3] [1732ea16a7d09411] [1732ea16a7d09411-2] [1732ea16a7d09411-3] [9096df2856e2660f] [9096df2856e2660f-2] [9096df2856e2660f-3] [7407ef7dca9e98ce] [7407ef7dca9e98ce-2] [585bb9b7] [af3198bf] [b46bb1c9] [ad94400b] [3246d720] [f829ce117aa64776] [3b917f24] [6232ddf4] [856cc8e5] [5ea08ff0] [35f439e2] [39d839f8] [aaf21089] [ffa42a65] [2e5f4209] [47418807] [c3d4a605] [ac4b98ec] [8827e2af] [b88ee002] [7feafc49] [c517bc2b] [15e01f83] [28e4e4be] [c8f67616] [45581b4b]
