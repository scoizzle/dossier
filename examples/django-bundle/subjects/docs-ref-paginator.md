# docs/ref/paginator

- Subject: docs/ref/paginator (id `de5d132f-6524-4a75-9816-8f48860783fe`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 23 of 101
- Conflicts: 0
- Gaps: 0

## Facts

- >>> from django.core.paginator import Paginator >>> paginator = Paginator([1, 2, 3], 2) >>> paginator.page(5) Traceback (most recent call last): ... EmptyPage: That page contains no results [f8f4ada9]
- >>> paginator = Paginator( ... [1, 2, 3], ... 2, ... error_messages={"no_results": "Page does not exist"}, ... ) >>> paginator.page(5) Traceback (most recent call last): ... EmptyPage: Page does not exist [4cd5c7b4]
- If you're using a ``QuerySet`` with a very large number of items, requesting high page numbers might be slow on some databases, because the resulting ``LIMIT``/``OFFSET`` query needs to count the number of ``OFFSET`` records which takes longer as the page number gets higher. [33be2cb0]
- Returns ``AsyncPage.object_list`` as a list. This method must be awaited before ``AsyncPage`` can be treated as a sequence of ``AsyncPage.object_list``. [e7278f84]
- Support for the ``orphans`` argument being larger than or equal to the ``per_page`` argument is deprecated. [f1d67ec8]
- When determining the number of objects contained in ``object_list``, ``Paginator`` will first try calling ``object_list.count()``. If ``object_list`` has no ``count()`` method, then ``Paginator`` will fall back to using ``len(object_list)``. This allows objects, such as ``QuerySet``, to use a more efficient ``count()`` method when available. [51dc7b9e]
- * The attribute :attr:`.Paginator.count` is supported as an asynchronous method ``AsyncPaginator.acount()``. * The attribute :attr:`.Paginator.num_pages` is supported as an asynchronous method ``AsyncPaginator.anum_pages()``. * The attribute :attr:`.Paginator.page_range` is supported as an asynchronous method ``AsyncPaginator.apage_range()``. [a4ab9bee]
- .. admonition:: Performance issues paginating large ``QuerySet``\s [b2e0a7bd]
- .. code-block:: pycon [eaf050be34acb41d-550]
- .. code-block:: pycon [eaf050be34acb41d-551]
- .. deprecated:: 6.0 [7904e6f98dc4b6fe-3]
- .. method:: AsyncPage.aget_object_list() [9361a55a]
- .. note:: [942ae6c11625c81c-131]
- A 1-based range iterator of page numbers, e.g. yielding ``[1, 2, 3, 4]``. [40336c28]
- A base class for exceptions raised when a paginator is passed an invalid page number. [d59a343c]
- A page acts like a sequence of :attr:`Page.object_list` when using ``len()`` or iterating it directly. [9fa81af8]
- A paginator acts like a sequence of :class:`Page` when using ``len()`` or iterating it directly. [4df5c1b8]
- A translatable string used as a substitute for elided page numbers in the page range returned by :meth:`~Paginator.get_elided_page_range`. Default is ``'…'``. [71e9f8bc]
- And here is a custom error message: [2eeaf9708b8932bc-2]
- Asynchronous version of :class:`Page`. [04debd0d]
- Asynchronous version of :class:`Paginator`. [e958fe18]
- For example, here is the default error message: [ff5f248d]
- Raised when :meth:`~Paginator.page` is given a valid value but no objects exist on that page. [3af2ae8b]

## Beyond the budget

77 more facts did not fit in the budget: [56ffef36] [878e53c1] [54c914d2] [5848f8dd] [2bc67500] [d25b2890] [825fff42] [0c681418] [d3feeffe] [2053395d] [5897abc0] [e3f3158a] [6ba8557b] [ecb0c13d] [66484965] [d7600a3c] [d5e68cb1] [b13bbb15] [7d8c375d] [74ed4beb] [ae280882] [eb72d44c] [5f56807a] [f6079ec6] [ee173019] [7ff97efe] [08ec9751] [0a3b5c46] [bdc4722c] [f3f98e50] [ce6a68ac] [9c3395a0] [7fafc84b] [9ae9f283] [956f9cd2] [39050812] [bdfd975c] [6e031b25] [93e7b6cb] [36875daa] [058e181e] [7475732e] [f7031f8c] [ed57e436] [71a90290] [ead27381] [f770e73a] [13e861d5] [8e0d0f1d] [6353a428] [5ddca3d0] [d1469533] [32db6eef] [c6f4a790] [d8c8bef4] [7f3bfd58] [bfdcc7c4] [f799030c] [6608f895] [7b5440e6] [a1eb26d754a3d60c-28] [a1eb26d754a3d60c-29] [1b28a76e] [bb91fb20711fda29-3] [bb91fb20711fda29-4] [a730ec0f] [35c7ac83] [458050e52503f721-5] [b7c8b04a] [d5882157dc780592-6] [d5882157dc780592-7] [cbd39995] [8950cd65] [2fd88194] [153f1be3] [da8796b6] [15b0301c]
