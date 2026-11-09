# docs/ref/models/constraints

- Subject: docs/ref/models/constraints (id `4964f7aa-e114-47cf-a231-e73cd1c33f93`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 23 of 113
- Conflicts: 0
- Gaps: 0

## Facts

- CheckConstraint( condition=Q(age__gte=18) & Q(expensive_check=condition), name="age_gte_18_and_others", ) [1fbd0346]
- CheckConstraint(condition=Q(age__gte=18) | Q(age__isnull=True), name="age_gte_18") [66797422]
- CheckConstraint(condition=Q(age__gte=18), name="%(app_label)s_%(class)s_is_adult") [54f43eb6]
- Base class for all constraints. Subclasses must implement ``constraint_sql()``, ``create_sql()``, ``remove_sql()`` and ``validate()`` methods. [86c0c942]
- CheckConstraint(condition=Q(age__gte=18), name="age_gte_18") [18ca402b]
- Checks with nullable fields on Oracle < 23c must include a condition allowing for ``NULL`` values in order for :meth:`~BaseConstraint.validate` to behave the same as check constraints validation. For example, if ``age`` is a nullable field:: [4e3808ec]
- Constraints are checked during the :ref:`model validation <validating-objects>`. [2b2b0cf0]
- Constraints are defined in ``django.db.models.constraints``, but for convenience they're imported into :mod:`django.db.models`. The standard convention is to use ``from django.db import models`` and refer to the constraints as ``models.<Foo>Constraint``. [b6a024ea]
- Creates a check constraint in the database. [2882dff1]
- Creates a uniqueness guarantee in the database, enforced by either a unique constraint or a unique index depending on the options used. [6cb0f012]
- Deferrable unique constraints are ignored on MySQL, MariaDB, and SQLite as they do not support them. [0ff9a462]
- Deferred unique constraints may lead to a `performance penalty <https://www.postgresql.org/docs/current/sql-createtable.html#id-1.9.3.85.9.4>`_. [7679ca0b]
- In this documentation, the term "unique constraint" is used for both cases to mean a uniqueness guarantee enforced by the database. [9b6f8e62]
- Setting only :attr:`UniqueConstraint.fields` creates a true database constraint (``ADD CONSTRAINT ... UNIQUE``). Specifying any of :attr:`UniqueConstraint.expressions`, :attr:`UniqueConstraint.opclasses`, :attr:`UniqueConstraint.condition`, or :attr:`UniqueConstraint.include` creates a unique index (``CREATE UNIQUE INDEX``) instead. [eeebc8be]
- UniqueConstraint( name="unique_order", fields=["order"], deferrable=Deferrable.DEFERRED, ) [0ee98cbb]
- UniqueConstraint( name="unique_username", fields=["username"], opclasses=["varchar_pattern_ops"] ) [98a42a27]
- UniqueConstraint(Lower("name").desc(), "category", name="unique_lower_name_category") [31033711]
- UniqueConstraint(fields=["room", "date"], name="unique_booking") [84fab135]
- UniqueConstraint(fields=["user"], condition=Q(status="DRAFT"), name="unique_draft_user") [8f23e5e0]
- UniqueConstraint(name="ordering", fields=["ordering"], nulls_distinct=False) [ceb29f52]
- UniqueConstraint(name="unique_booking", fields=["room", "date"], include=["full_name"]) [e7f49975]
- from django.db.models import Deferrable, UniqueConstraint [9f925ba1]
- .. warning:: [c54b54cb0805732a-46]

## Beyond the budget

87 more facts did not fit in the budget: [8eec3b0b] [619ec54c] [cfd4b574] [d373bb03] [0c176cf9] [703ed62f] [58ac6f74] [728a8f69] [d1083287] [e1e3e5eb] [81bde4e9] [e67743e2] [8d2c27e2] [ee4ad064] [f847f7c1] [fc6b5e8f] [c35f6d15] [c7e671b4] [c3023071] [68e627b4] [439f126a] [92236459] [ccafd2b1] [444327d1] [0306994e] [3a368b18514a814b-4] [b7853682] [ad2f3674] [cb1f9fec] [fb2b3ead] [013ad0dc] [8d5e21bd] [76443292] [6b79972f] [4582a05f3e793cbe-2] [967419e7] [28edef836ab93f57-8] [28edef836ab93f57-9] [28edef836ab93f57-10] [28edef836ab93f57-11] [28edef836ab93f57-12] [28edef836ab93f57-13] [28edef836ab93f57-14] [8a6db4fb] [5f607209] [0e33ae94] [afa824af] [ef19328f] [5c7881cc] [77fb32e9] [57e2bd85a3d0d59e-2] [2b930ffd] [8ecf537a] [cfc085d1] [e6e99c7e] [27a00d8b] [74a099be] [8934387a] [d0ed9073] [4d7bbc32] [f8ad0e87] [c10814a4] [81ac67b3] [03278196] [18ddc562] [3ef04f700014c56a-2] [3ef04f700014c56a-3] [e105880c3e1bde26-2] [aa7d175f0fd55e69-2] [87254620a027401c-2] [dcc88c68300cfc76-2] [e9982e75ca22a002-2] [85b80be9] [43b70adcca41be01] [d0ed3cf94d763803] [fa085906] [4afa7d9a8f7918c6-2] [4afa7d9a8f7918c6-3] [d4a3f1a246802851-2] [d4a3f1a246802851-3] [c5de1b7b] [ec5c9165] [590645af] [7e0a1e12] [cca54573] [f7d317ac] [7b394c45]
