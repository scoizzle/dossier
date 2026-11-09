# docs/ref/contrib/postgres/functions

- Subject: docs/ref/contrib/postgres/functions (id `dceb2c35-c773-4e08-af9e-6a0d7e61dc80`)
- Kind: subject
- Budget: 1200 tokens
- Used: 564 tokens
- Facts shown: 18 of 18
- Conflicts: 0
- Gaps: 0

## Facts

- :class:`django.db.models.functions.UUID4` is a cross-database version of this function. ``RandomUUID`` may be deprecated in the future. [6444a748]
- >>> from django.contrib.postgres.functions import RandomUUID >>> Article.objects.update(uuid=RandomUUID()) [e8b25573]
- >>> from django.contrib.postgres.functions import TransactionNow >>> Article.objects.filter(published__lte=TransactionNow()) <QuerySet [<Article: How to Django>]> [06378e50]
- .. admonition:: Use :class:`django.db.models.functions.UUID4` instead. [c67318ca]
- .. class:: RandomUUID() [78a84948]
- .. class:: TransactionNow() [ef98ca2f]
- .. code-block:: pycon [eaf050be34acb41d-240]
- .. code-block:: pycon [eaf050be34acb41d-241]
- .. currentmodule:: django.contrib.postgres.functions [20882eca]
- ====================================== PostgreSQL specific database functions ====================================== [8df83e3d]
- All of these functions are available from the ``django.contrib.postgres.functions`` module. [fd15d7b9]
- Note that only the outermost call to :func:`~django.db.transaction.atomic` sets up a transaction and thus sets the time that ``TransactionNow()`` will return; nested calls create savepoints which do not affect the transaction time. [8d841ae9]
- Returns a version 4 UUID. [107e2bbf]
- Returns the date and time on the database server that the current transaction started. If you are not in a transaction it will return the date and time of the current statement. This is a complement to :class:`django.db.models.functions.Now`, which returns the date and time of the current statement. [123a2d38]
- Usage example: [3ecdcd2d485c92ad]
- Usage example: [3ecdcd2d485c92ad-2]
- ``RandomUUID`` ============== [acddc00e]
- ``TransactionNow`` ================== [3387d3df]
