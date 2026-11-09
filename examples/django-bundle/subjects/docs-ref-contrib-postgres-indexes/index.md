# docs/ref/contrib/postgres/indexes

- Subject: docs/ref/contrib/postgres/indexes (id `2ac969d1-9073-4782-91f0-af6151b68fd0`)
- Kind: subject
- Budget: 1200 tokens
- Used: 887 tokens
- Facts shown: 21 of 57
- Conflicts: 0
- Gaps: 0

## Facts

- ExclusionConstraint( name="exclude_overlapping_ops", expressions=[ (OpClass("circle", name="circle_ops"), RangeOperators.OVERLAPS), ], ) [dcf50c98]
- Index( OpClass(Lower("username"), name="varchar_pattern_ops"), name="lower_username_idx", ) [054de906]
- UniqueConstraint( OpClass(Upper("description"), name="text_pattern_ops"), name="upper_description_unique", ) [b1f505e4]
- .. _GIN Fast Update Technique: https://www.postgresql.org/docs/current/gin.html#GIN-FAST-UPDATE .. _gin_pending_list_limit: https://www.postgresql.org/docs/current/runtime-config-client.html#GUC-GIN-PENDING-LIST-LIMIT [5ffbc7e7]
- .. _automatic summarization: https://www.postgresql.org/docs/current/brin.html#BRIN-OPERATION [93233f91]
- .. _bloom: https://www.postgresql.org/docs/current/bloom.html [e6788368]
- .. _buffering build: https://www.postgresql.org/docs/current/gist.html#GIST-BUFFERING-BUILD .. _fillfactor: https://www.postgresql.org/docs/current/sql-createindex.html#SQL-CREATEINDEX-STORAGE-PARAMETERS [07e714fb]
- .. _fillfactor: https://www.postgresql.org/docs/current/sql-createindex.html#SQL-CREATEINDEX-STORAGE-PARAMETERS [fde5e67368ef761c]
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
- Provide an integer number of bits from 1 to 4096 to the ``length`` parameter to specify the length of each index entry. PostgreSQL's default is 80. [5c7e8b8c]

## Beyond the budget

31 more facts did not fit in the budget: [59232d2d] [caaed5f03bcc3b0c] [17984291] [e819eae4] [f75b8f09] [0d2cdfec] [cdcda76f] [b7fa0054] [cd4786cf] [aa92b4db] [1a13b10ced393a15-2] [6d632603] [40412d18] [d891019a] [5f3627dc] [bed06e20] [9c5f1de4] [a4dbccbf] [bccda25c] [fd39ca51] [86ebef80] [f519060f] [e91ec846] [a7117544] [23c64ec4] [98294df3] [214db592] [f82aeeb8] [ded581da] [0a03c73e] [b5e2a853]
