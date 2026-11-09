# docs/ref/contrib/postgres/expressions

- Subject: docs/ref/contrib/postgres/expressions (id `22ee4c47-d84d-42e9-926a-49cc01b366f7`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 454 tokens
- Facts shown: 10 of 10
- Conflicts: 0
- Gaps: 0

## Facts

- >>> from django.db.models import OuterRef >>> from django.db.models.functions import JSONObject >>> from django.contrib.postgres.expressions import ArraySubquery >>> books = Book.objects.filter(author=OuterRef("pk")).values( ... json=JSONObject(title="title", pages="pages") ... ) >>> author = Author.objects.annotate(books=ArraySubquery(books)).first() >>> author.books [{'title': 'Solaris', 'pages': 204}, {'title': 'The Cyberiad', 'pages': 295}] [46501fe7]
- .. class:: ArraySubquery(queryset) [b7c2a062]
- .. code-block:: pycon [eaf050be34acb41d-219]
- .. module:: django.contrib.postgres.expressions :synopsis: PostgreSQL specific query expressions [2ac44716]
- ===================================== PostgreSQL specific query expressions ===================================== [2c21d1d1]
- For example, if you want to annotate all related books to an author as JSON objects: [d1f0b233]
- These expressions are available from the ``django.contrib.postgres.expressions`` module. [a057b02f]
- This class differs from :class:`~django.contrib.postgres.aggregates.ArrayAgg` in the way that it does not act as an aggregate function and does not require an SQL ``GROUP BY`` clause to build the list of values. [f5bde740]
- ``ArraySubquery()`` expressions =============================== [781ac75b]
- ``ArraySubquery`` is a :class:`~django.db.models.Subquery` that uses the PostgreSQL ``ARRAY`` constructor to build a list of values from the queryset, which must use :meth:`.QuerySet.values` to return only a single column. [eb3a51ae]
