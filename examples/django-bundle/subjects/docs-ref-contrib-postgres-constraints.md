# docs/ref/contrib/postgres/constraints

- Subject: docs/ref/contrib/postgres/constraints (id `26e2c833-343d-4b7f-92c6-04d8a9fdc115`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 19 of 58
- Conflicts: 0
- Gaps: 0

## Facts

- class Meta: constraints = [ ExclusionConstraint( name="exclude_overlapping_reservations", expressions=[ ( TsTzRange("start", "end", RangeBoundary()), RangeOperators.OVERLAPS, ), ("room", RangeOperators.EQUAL), ], condition=Q(cancelled=False), ), ] [b2226881]
- class Meta: constraints = [ ExclusionConstraint( name="exclude_overlapping_reservations", expressions=[ ("timespan", RangeOperators.OVERLAPS), ("room", RangeOperators.EQUAL), ], condition=Q(cancelled=False), ), ] [074dd760]
- Creates an exclusion constraint in the database. Internally, PostgreSQL implements exclusion constraints using indexes. The default index type is `GiST <https://www.postgresql.org/docs/current/gist.html>`_. To use them, you need to activate the `btree_gist extension <https://www.postgresql.org/docs/current/btree-gist.html>`_ on PostgreSQL. You can install it using the :class:`~django.contrib.postgres.operations.BtreeGistExtension` migration operation. [12b61c9f]
- Deferred exclusion constraints may lead to a `performance penalty <https://www.postgresql.org/docs/current/sql-createtable.html#id-1.9.3.85.9.4>`_. [bfee08e3]
- Exclusion constraints are checked during the :ref:`model validation <validating-objects>`. [6df3e1cd]
- ExclusionConstraint( name="exclude_overlapping_deferred", expressions=[ ("timespan", RangeOperators.OVERLAPS), ], deferrable=Deferrable.DEFERRED, ) [6e28e407]
- If you attempt to insert a new row that conflicts with an existing row, an :exc:`~django.db.IntegrityError` is raised. Similarly, when update conflicts with an existing row. [f84c1212]
- Only commutative operators can be used in exclusion constraints. [1b1b842b]
- Support for exclusion constraints using Hash indexes was added. [ca9c61b2]
- class Reservation(models.Model): room = models.ForeignKey("Room", on_delete=models.CASCADE) start = models.DateTimeField() end = models.DateTimeField() cancelled = models.BooleanField(default=False) [2fa9bff1]
- class Reservation(models.Model): room = models.ForeignKey("Room", on_delete=models.CASCADE) timespan = DateTimeRangeField() cancelled = models.BooleanField(default=False) [da54652b]
- class Room(models.Model): number = models.IntegerField() [b7f5031a]
- class TsTzRange(Func): function = "TSTZRANGE" output_field = DateTimeRangeField() [c2de63bd]
- expressions = [ ("timespan", RangeOperators.ADJACENT_TO), (F("room"), RangeOperators.EQUAL), ] [a4162cbf]
- expressions = [ (OpClass("circle", name="circle_ops"), RangeOperators.OVERLAPS), ] [029b0e97]
- from django.contrib.postgres.constraints import ExclusionConstraint from django.contrib.postgres.fields import ( DateTimeRangeField, RangeBoundary, RangeOperators, ) from django.db import models from django.db.models import Func, Q [c6c70398]
- from django.contrib.postgres.constraints import ExclusionConstraint from django.contrib.postgres.fields import RangeOperators from django.db.models import Deferrable [e4b07dc7]
- .. _operator class: https://www.postgresql.org/docs/current/indexes-opclass.html [952439a6d5e41ed0]
- .. warning:: [c54b54cb0805732a-26]

## Beyond the budget

38 more facts did not fit in the budget: [7cebeece] [e4585dd8] [0adcd9a1] [856dd319] [9ad3b066] [23d7c4f0] [c34eb59a] [5c9b8755] [b33dc312] [defb2007] [2a966a198e13032b-8] [b780d249] [7c195c95] [2059e630] [9de1b085] [4582a05f3e793cbe] [62692a07] [1a597c2b] [18f76d5f] [beb51279] [c2d11d41] [9d0f2313] [57e2bd85a3d0d59e] [8b5513b7] [65220e91] [024b67d8] [3e3dd500] [27667ace] [3ef04f700014c56a] [e105880c3e1bde26] [aa7d175f0fd55e69] [dcc88c68300cfc76] [2a4e7985] [3f4dfa8b] [e9982e75ca22a002] [4afa7d9a8f7918c6] [d4a3f1a246802851] [1a13b10ced393a15]
