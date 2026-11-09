# docs/ref/contrib/postgres/lookups

- Subject: docs/ref/contrib/postgres/lookups (id `bd882033-fa12-4abf-9d99-2474ac641477`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1367 tokens
- Facts shown: 33 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- >>> City.objects.filter(name__trigram_similar="Middlesborough") <QuerySet [<City: Middlesbrough>]> [dc3c4f84]
- >>> City.objects.filter(name__unaccent="México") <QuerySet [<City: Mexico>]> [b1345f99]
- >>> Sentence.objects.filter(name__trigram_word_similar="Middlesborough") <QuerySet [<Sentence: Gumby rides on the path of Middlesbrough>]> [4b0ad22d]
- >>> User.objects.filter(first_name__unaccent__startswith="Jerem") <QuerySet [<User: Jeremy>, <User: Jérémy>, <User: Jérémie>, <User: Jeremie>]> [8a4a56af]
- ``unaccent`` lookups should perform fine in most use cases. However, queries using this filter will generally perform full table scans, which can be slow on large tables. In those cases, using dedicated full text indexing tools might be appropriate. [de2fabec]
- .. _`pg_trgm extension`: https://www.postgresql.org/docs/current/pgtrgm.html [59967c8f]
- .. _unaccent extension on PostgreSQL: https://www.postgresql.org/docs/current/unaccent.html [79f972cc]
- .. code-block:: pycon [eaf050be34acb41d-242]
- .. code-block:: pycon [eaf050be34acb41d-243]
- .. code-block:: pycon [eaf050be34acb41d-244]
- .. fieldlookup:: trigram_similar [6a21cf38]
- .. fieldlookup:: trigram_strict_word_similar [e6ef65da]
- .. fieldlookup:: trigram_word_similar [a89b5262]
- .. fieldlookup:: unaccent [e7671c47]
- .. warning:: [c54b54cb0805732a-28]
- =========================== PostgreSQL specific lookups =========================== [63b36c18]
- Similar to :lookup:`trigram_word_similar`, except that it forces extent boundaries to match word boundaries. [11941d86]
- The ``trigram_similar`` lookup allows you to perform trigram lookups, measuring the number of trigrams (three consecutive characters) shared, using a dedicated PostgreSQL extension. A trigram lookup is given an expression and returns results that have a similarity measurement greater than the current similarity threshold. [d2147dcc]
- The ``trigram_similar`` lookup can be used on :class:`~django.db.models.CharField` and :class:`~django.db.models.TextField`: [6edfb397]
- The ``trigram_strict_word_similar`` lookup can be used on :class:`~django.db.models.CharField` and :class:`~django.db.models.TextField`. [036aa98e]
- The ``trigram_word_similar`` lookup allows you to perform trigram word similarity lookups using a dedicated PostgreSQL extension. It can be approximately understood as measuring the greatest number of trigrams shared between the parameter and any substring of the field. A trigram word lookup is given an expression and returns results that have a word similarity measurement greater than the current similarity threshold. [7b493633]
- The ``trigram_word_similar`` lookup can be used on :class:`~django.db.models.CharField` and :class:`~django.db.models.TextField`: [a97c39a8]
- The ``unaccent`` lookup allows you to perform accent-insensitive lookups using a dedicated PostgreSQL extension. [d49d5bd8]
- ``Unaccent`` ============ [edf962c1]

## All facts

- [42252da3] The ``unaccent`` lookup can be used on :class:`~django.db.models.CharField` and :class:`~django.db.models.TextField`:
- [e1f9e305] This lookup is implemented using :class:`~django.db.models.Transform`, so it can be chained with other lookup functions. To use it, you need to add ``'django.contrib.postgres'`` in your :setting:`INSTALLED_APPS` and activate the `unaccent extension on PostgreSQL`_. The :class:`~django.contrib.postgres.operations.UnaccentExtension` migration operation is available if you want to perform this activation using migrations.
- [5db16fcc1bbcfb35] To use it, add ``'django.contrib.postgres'`` in your :setting:`INSTALLED_APPS` and activate the `pg_trgm extension`_ on PostgreSQL. You can install the extension using the :class:`~django.contrib.postgres.operations.TrigramExtension` migration operation.
- [5db16fcc1bbcfb35-2] To use it, add ``'django.contrib.postgres'`` in your :setting:`INSTALLED_APPS` and activate the `pg_trgm extension`_ on PostgreSQL. You can install the extension using the :class:`~django.contrib.postgres.operations.TrigramExtension` migration operation.
- [5db16fcc1bbcfb35-3] To use it, add ``'django.contrib.postgres'`` in your :setting:`INSTALLED_APPS` and activate the `pg_trgm extension`_ on PostgreSQL. You can install the extension using the :class:`~django.contrib.postgres.operations.TrigramExtension` migration operation.
- [fbf4d8b26aa7310d] Trigram similarity ==================
- [2a46a5ce] ``trigram_similar`` -------------------
- [684ac06a] ``trigram_strict_word_similar`` -------------------------------
- [26282979] ``trigram_word_similar`` ------------------------
