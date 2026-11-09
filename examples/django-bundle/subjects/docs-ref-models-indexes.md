# docs/ref/models/indexes

- Subject: docs/ref/models/indexes (id `e9c81b50-da86-4bcc-84e8-28ff94a95c88`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 16 of 72
- Conflicts: 0
- Gaps: 0

## Facts

- Creates an index (B-Tree) in the database. [d4e2947e]
- For a list of PostgreSQL-specific indexes, see :mod:`django.contrib.postgres.indexes`. [7cc39105]
- Functional indexes are unsupported and ignored with MariaDB. [66ee3618]
- In addition to B-Tree indexes (via :class:`Index`), PostgreSQL also supports :class:`~django.contrib.postgres.indexes.GistIndex` and :class:`~django.contrib.postgres.indexes.SpGistIndex` indexes. [8f63a84f]
- Index(F("height") * F("weight"), Round("weight"), name="calc_idx") [468a66e0]
- Index(Lower("title").desc(), "pub_date", name="lower_title_date_idx") [f10dc2ba]
- Index(name="covering_index", fields=["headline"], include=["pub_date"]) [be3db829]
- Indexes are defined in ``django.db.models.indexes``, but for convenience they're imported into :mod:`django.db.models`. The standard convention is to use ``from django.db import models`` and refer to the indexes as ``models.<IndexClass>``. [046ae2c0]
- Oracle does not support partial indexes. Instead, partial indexes can be emulated by using functional indexes together with :class:`~django.db.models.expressions.Case` expressions. [031c89dd]
- Oracle requires functions referenced in an index to be marked as ``DETERMINISTIC``. Django doesn't validate this but Oracle will error. This means that functions such as :class:`Random() <django.db.models.functions.Random>` aren't accepted. [afa63dc6]
- PostgreSQL requires functions and operators referenced in an index to be marked as ``IMMUTABLE``. Django doesn't validate this but PostgreSQL will error. This means that functions such as :class:`Concat() <django.db.models.functions.Concat>` aren't accepted. [8d96316a]
- PostgreSQL requires functions referenced in the condition to be marked as IMMUTABLE. Django doesn't validate this but PostgreSQL will error. This means that functions such as :ref:`date-functions` and :class:`~django.db.models.functions.Concat` aren't accepted. If you store dates in :class:`~django.db.models.DateTimeField`, comparison to :class:`~datetime.datetime` objects may require the ``tzinfo`` argument to be provided because otherwise the comparison could result in a mutable function due to the casting Django does for :ref:`lookups <field-lookups>`. [0fa11eb0]
- SQLite `imposes restrictions <https://www.sqlite.org/partialindex.html>`_ on how a partial index can be constructed. [842d1cee]
- The ``condition`` argument is ignored with MySQL and MariaDB as neither supports conditional indexes. [a33105db]
- You must always specify a unique name for an index. As such, you cannot normally specify a partial index on an abstract base class, since the :attr:`Meta.indexes <django.db.models.Options.indexes>` option is inherited by subclasses, with exactly the same values for the attributes (including ``name``) each time. To work around name collisions, part of the name may contain ``'%(app_label)s'`` and ``'%(class)s'``, which are replaced, respectively, by the lowercased app label and class name of the concrete model. For example ``Index(fields=['title'], name='%(app_label)s_%(class)s_title_index')``. [8cf5de25]
- .. admonition:: Oracle [d78ad3ab25cd8d9c-5]

## Beyond the budget

55 more facts did not fit in the budget: [651b89d0] [ae2346d9] [46faa00f] [0cad0d88] [55b9cc69] [882bf015] [bebd87af] [6916dbe8e1a8cc8d] [819421d9] [0eccf1d3] [684ce5ec] [3371c411] [cdb4562c] [7d0c371c] [9ee9c155] [cdde396e] [1c8d974e] [3a368b18514a814b-11] [f8119871] [6b4a5e54e001d097-24] [1cfd44ac] [75cf84c4] [bdab2083] [00e237b9] [94d436d7] [232a8cde] [0ff6cac2] [879861e9] [7bec24fa] [3b0c540c] [6a808e30] [28edef836ab93f57-17] [28edef836ab93f57-18] [af38bc09] [8e0603cb] [c09985c6] [347f08a1] [9f963e5c] [c2cb0216] [2ec04bb7] [fe57da48] [0d170636] [53b7998a] [3ef04f700014c56a-4] [6aa45c0650f66404-2] [aa7d175f0fd55e69-3] [87254620a027401c-3] [dcc88c68300cfc76-3] [869d9cad] [e9982e75ca22a002-3] [43b70adcca41be01-2] [d0ed3cf94d763803-2] [bd7c0aa2] [f7f62925] [b4cde83f]
