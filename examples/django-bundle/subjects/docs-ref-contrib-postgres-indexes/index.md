# docs/ref/contrib/postgres/indexes

- Subject: docs/ref/contrib/postgres/indexes (id `3c9e4825-de5b-46ff-af57-6dc8d23bdb34`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2198 tokens
- Facts shown: 57 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- ExclusionConstraint( name="exclude_overlapping_ops", expressions=[ (OpClass("circle", name="circle_ops"), RangeOperators.OVERLAPS), ], ) [dcf50c98]
- Index( OpClass(Lower("username"), name="varchar_pattern_ops"), name="lower_username_idx", ) [054de906]
- UniqueConstraint( OpClass(Upper("description"), name="text_pattern_ops"), name="upper_description_unique", ) [b1f505e4]
- .. _GIN Fast Update Technique: https://www.postgresql.org/docs/current/gin.html#GIN-FAST-UPDATE .. _gin_pending_list_limit: https://www.postgresql.org/docs/current/runtime-config-client.html#GUC-GIN-PENDING-LIST-LIMIT [5ffbc7e7]
- .. _automatic summarization: https://www.postgresql.org/docs/current/brin.html#BRIN-OPERATION [93233f91]
- .. _bloom: https://www.postgresql.org/docs/current/bloom.html [e6788368]
- .. _buffering build: https://www.postgresql.org/docs/current/gist.html#GIST-BUFFERING-BUILD .. _fillfactor: https://www.postgresql.org/docs/current/sql-createindex.html#SQL-CREATEINDEX-STORAGE-PARAMETERS [07e714fb]
- .. _fillfactor: https://www.postgresql.org/docs/current/sql-createindex.html#SQL-CREATEINDEX-STORAGE-PARAMETERS [fde5e67368ef761c]
- .. _fillfactor: https://www.postgresql.org/docs/current/sql-createindex.html#SQL-CREATEINDEX-STORAGE-PARAMETERS [fde5e67368ef761c-2]
- .. _fillfactor: https://www.postgresql.org/docs/current/sql-createindex.html#SQL-CREATEINDEX-STORAGE-PARAMETERS .. _deduplicate_items: https://www.postgresql.org/docs/current/btree.html#BTREE-DEDUPLICATION [0265a4ed]
- .. _operator class: https://www.postgresql.org/docs/current/indexes-opclass.html [952439a6d5e41ed0-2]
- An ``OpClass()`` expression represents the ``expression`` with a custom `operator class`_ that can be used to define functional indexes, functional unique constraints, or exclusion constraints. To use it, you need to add ``'django.contrib.postgres'`` in your :setting:`INSTALLED_APPS`. Set the ``name`` parameter to the name of the `operator class`_. [a61047d3]
- Creates a B-Tree index. [ea780c16]
- Creates a `BRIN index <https://www.postgresql.org/docs/current/brin.html>`_. [143bc79b]
- Creates a `GiST index <https://www.postgresql.org/docs/current/gist.html>`_. These indexes are automatically created on spatial fields with :attr:`spatial_index=True <django.contrib.gis.db.models.BaseSpatialField.spatial_index>`. They're also useful on other types, such as :class:`~django.contrib.postgres.fields.HStoreField` or the :ref:`range fields <range-fields>`. [f3576e92]
- Creates a `gin index <https://www.postgresql.org/docs/current/gin.html>`_. [316d65ea]
- Creates a bloom_ index. [cda848f8]
- Creates a hash index. [793f7472]
- Creates an `SP-GiST index <https://www.postgresql.org/docs/current/spgist.html>`_. [841f8e3f]
- For example:: [28edef836ab93f57-7]
- Provide a boolean value to the deduplicate_items_ parameter to control whether deduplication is enabled. PostgreSQL enables deduplication by default. [13206e46]
- .. class:: OpClass(expression, name) [bccda25c]

## All facts

- [5c7e8b8c] Provide an integer number of bits from 1 to 4096 to the ``length`` parameter to specify the length of each index entry. PostgreSQL's default is 80.
- [59232d2d] Provide an integer number of kilobytes to the gin_pending_list_limit_ parameter to tune the maximum size of the GIN pending list which is used when ``fastupdate`` is enabled.
- [caaed5f03bcc3b0c] Provide an integer value from 10 to 100 to the fillfactor_ parameter to tune how packed the index pages will be. PostgreSQL's default is 90.
- [caaed5f03bcc3b0c-2] Provide an integer value from 10 to 100 to the fillfactor_ parameter to tune how packed the index pages will be. PostgreSQL's default is 90.
- [caaed5f03bcc3b0c-3] Provide an integer value from 10 to 100 to the fillfactor_ parameter to tune how packed the index pages will be. PostgreSQL's default is 90.
- [caaed5f03bcc3b0c-4] Provide an integer value from 10 to 100 to the fillfactor_ parameter to tune how packed the index pages will be. PostgreSQL's default is 90.
- [17984291] Set the ``autosummarize`` parameter to ``True`` to enable `automatic summarization`_ to be performed by autovacuum.
- [e819eae4] Set the ``buffering`` parameter to ``True`` or ``False`` to manually enable or disable `buffering build`_ of the index.
- [f75b8f09] Set the ``fastupdate`` parameter to ``False`` to disable the `GIN Fast Update Technique`_ that's enabled by default in PostgreSQL.
- [0d2cdfec] The ``columns`` argument takes a tuple or list of up to 32 values that are integer number of bits from 1 to 4095.
- [cdcda76f] The ``pages_per_range`` argument takes a positive integer.
- [b7fa0054] To use this index access you need to activate the bloom_ extension on PostgreSQL. You can install it using the :class:`~django.contrib.postgres.operations.BloomExtension` migration operation.
- [cd4786cf] To use this index on data types not in the `built-in operator classes <https://www.postgresql.org/docs/current/gin.html#GIN-BUILTIN-OPCLASSES>`_, you need to activate the `btree_gin extension <https://www.postgresql.org/docs/current/btree-gin.html>`_ on PostgreSQL. You can install it using the :class:`~django.contrib.postgres.operations.BtreeGinExtension` migration operation.
- [516e896c] To use this index on data types not in the built-in `gist operator classes <https://www.postgresql.org/docs/current/gist.html#GIST-BUILTIN-OPCLASSES>`_, you need to activate the `btree_gist extension <https://www.postgresql.org/docs/current/btree-gist.html>`_ on PostgreSQL. You can install it using the :class:`~django.contrib.postgres.operations.BtreeGistExtension` migration operation.
- [aa92b4db] creates a unique constraint on ``Upper('description')`` using ``text_pattern_ops``. ::
- [1a13b10ced393a15-2] creates an exclusion constraint on ``circle`` using ``circle_ops``.
- [6d632603] creates an index on ``Lower('username')`` using ``varchar_pattern_ops``. ::
- [40412d18] .. class:: BTreeIndex(*expressions, fillfactor=None, deduplicate_items=None, **options)
- [d891019a] .. class:: BloomIndex(*expressions, length=None, columns=(), **options)
- [5f3627dc] .. class:: BrinIndex(*expressions, autosummarize=None, pages_per_range=None, **options)
- [bed06e20] .. class:: GinIndex(*expressions, fastupdate=None, gin_pending_list_limit=None, **options)
- [9c5f1de4] .. class:: GistIndex(*expressions, buffering=None, fillfactor=None, **options)
- [a4dbccbf] .. class:: HashIndex(*expressions, fillfactor=None, **options)
- [fd39ca51] .. class:: SpGistIndex(*expressions, fillfactor=None, **options)
- [86ebef80] .. module:: django.contrib.postgres.indexes
- [f519060f] ================================= PostgreSQL specific model indexes =================================
- [e91ec846] The following are PostgreSQL specific :doc:`indexes </ref/models/indexes>` available from the ``django.contrib.postgres.indexes`` module.
- [a7117544] ``BTreeIndex`` ==============
- [23c64ec4] ``BloomIndex`` ==============
- [98294df3] ``BrinIndex`` =============
- [214db592] ``GinIndex`` ============
- [f82aeeb8] ``GistIndex`` =============
- [ded581da] ``HashIndex`` =============
- [0a03c73e] ``OpClass()`` expressions =========================
- [b5e2a853] ``SpGistIndex`` ===============
