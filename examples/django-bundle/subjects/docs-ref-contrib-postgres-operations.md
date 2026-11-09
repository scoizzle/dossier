# docs/ref/contrib/postgres/operations

- Subject: docs/ref/contrib/postgres/operations (id `2060db46-cd89-4352-ae79-02ab41fa4a48`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 37 of 99
- Conflicts: 0
- Gaps: 0

## Facts

- .. versionadded:: 6.0 [a1eb26d754a3d60c-11]
- .. versionadded:: 6.0 [a1eb26d754a3d60c-12]
- .. versionadded:: 6.0 [a1eb26d754a3d60c-13]
- .. versionadded:: 6.0 [a1eb26d754a3d60c-14]
- .. versionadded:: 6.0 [a1eb26d754a3d60c-15]
- .. versionadded:: 6.0 [a1eb26d754a3d60c-16]
- .. versionadded:: 6.0 [a1eb26d754a3d60c-17]
- .. versionadded:: 6.0 [a1eb26d754a3d60c-18]
- .. versionadded:: 6.0 [a1eb26d754a3d60c-19]
- The optional ``hints`` argument will be passed as ``**hints`` to the :meth:`allow_migrate` method of database routers to assist them in :ref:`making routing decisions <topics-db-multi-db-hints>`. [8705a8910c5812e0]
- This is a required argument. The name of the extension to be installed. [9fd827e9]
- operations = [ CreateCollation( "case_insensitive", provider="icu", locale="und-u-ks-level2", deterministic=False, ), ..., ] [e229373e]
- operations = [HStoreExtension(), ...] [d52fe96b]
- .. attribute:: hints [3c424b3911ef1fc8]
- .. attribute:: hints [3c424b3911ef1fc8-2]
- .. attribute:: hints [3c424b3911ef1fc8-3]
- .. attribute:: hints [3c424b3911ef1fc8-4]
- .. attribute:: hints [3c424b3911ef1fc8-5]
- .. attribute:: hints [3c424b3911ef1fc8-6]
- .. attribute:: hints [3c424b3911ef1fc8-7]
- .. attribute:: hints [3c424b3911ef1fc8-8]
- .. attribute:: hints [3c424b3911ef1fc8-9]
- .. attribute:: name [80d47dc5547c9038-11]
- An ``Operation`` subclass which installs a PostgreSQL extension. For common extensions, use one of the more specific subclasses below. [655be0ec]
- Creates a collation with the given ``name``, ``locale`` and ``provider``. [e00f4008]
- Installs the ``bloom`` extension. [3fc6e7dc]
- Installs the ``btree_gin`` extension. [9e86e0a5]
- Installs the ``btree_gist`` extension. [2cee8add]
- Installs the ``citext`` extension. [98c340c8]
- Installs the ``hstore`` extension and also sets up the connection to interpret hstore data for possible use in subsequent migrations. [de11f0b6]
- Installs the ``pg_trgm`` extension. [e305649e]
- Installs the ``pgcrypto`` extension. [4c1a275e]
- Installs the ``unaccent`` extension. [fd920c4c]
- Like :class:`~django.db.migrations.operations.AddConstraint`, but avoids validating the constraint on existing rows. [5c449583]
- Like :class:`~django.db.migrations.operations.AddIndex`, but creates an index with the ``CONCURRENTLY`` option. This has a few caveats to be aware of when using this option, see `the PostgreSQL documentation of building indexes concurrently <https://www.postgresql.org/docs/current/ sql-createindex.html#SQL-CREATEINDEX-CONCURRENTLY>`_. [f0f3c9b2]
- Removes the collations named ``name``. [e74e95bb]
- Scans through the table and validates the given check constraint on existing rows. [c7c871e8]

## Beyond the budget

54 more facts did not fit in the budget: [6563f699] [47b54514] [a117bb62] [ff061728] [5a491eba] [c8e61e6abe4f0fc0-2] [c8e61e6abe4f0fc0-3] [6793599c] [f1d0d303] [270431c5] [9cbf3cef] [d3d1111b] [fb384344] [8ca13461] [769097e4] [fbd97694] [a461ca4d] [fc909b0d] [a12da9e0] [c08027a1] [a1cf7266] [384eb543] [8c3f8a7d] [88c1c9d6] [ebb41f0d] [49b6d6b2] [9f26dd28] [942ae6c11625c81c-85] [942ae6c11625c81c-86] [80c7b11d] [71d286cf] [3d321021] [f961f2bf] [7a006268] [8eff6b14] [4b21c63b] [b86b270b] [0cfaed26] [21a87979] [9402c282] [0d49df97] [45c79552] [33069776] [ec7c9399] [27548945] [cbfd00bf] [4e579881] [8fa641dc] [d7b86d6c] [ea7d7565] [4d9c13e9] [997a30a0] [81196898] [3b1c8683]
