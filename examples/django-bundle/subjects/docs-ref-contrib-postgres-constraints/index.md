# docs/ref/contrib/postgres/constraints

- Subject: docs/ref/contrib/postgres/constraints (id `c5cc9492-200f-486e-a2d5-5fc096c366af`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2375 tokens
- Facts shown: 58 facts
- Conflicts: 0
- Gaps: 0

## Highlights

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
- from django.contrib.postgres.constraints import ExclusionConstraint from django.contrib.postgres.fields import DateTimeRangeField, RangeOperators from django.db import models from django.db.models import Q [4412cc7b]
- .. _operator class: https://www.postgresql.org/docs/current/indexes-opclass.html [952439a6d5e41ed0]

## All facts

- [e4b07dc7] from django.contrib.postgres.constraints import ExclusionConstraint from django.contrib.postgres.fields import RangeOperators from django.db.models import Deferrable
- [7cebeece] .. admonition:: Restrictions on operators.
- [e4585dd8] .. attribute:: ExclusionConstraint.condition
- [0adcd9a1] .. attribute:: ExclusionConstraint.deferrable
- [856dd319] .. attribute:: ExclusionConstraint.expressions
- [9ad3b066] .. attribute:: ExclusionConstraint.include
- [23d7c4f0] .. attribute:: ExclusionConstraint.index_type
- [c34eb59a] .. attribute:: ExclusionConstraint.name
- [5c9b8755] .. attribute:: ExclusionConstraint.violation_error_code
- [b33dc312] .. class:: ExclusionConstraint(*, name, expressions, index_type=None, condition=None, deferrable=None, include=None, violation_error_code=None, violation_error_message=None)
- [defb2007] .. module:: django.contrib.postgres.constraints :synopsis: PostgreSQL specific database constraint
- [2a966a198e13032b-8] .. versionchanged:: 6.1
- [c54b54cb0805732a-26] .. warning::
- [b780d249] ======================================== PostgreSQL specific database constraints ========================================
- [7c195c95] A :class:`~django.db.models.Q` object that specifies the condition to restrict a constraint to a subset of rows. For example, ``condition=Q(cancelled=False)``.
- [2059e630] A list or tuple of the names of the fields to be included in the covering exclusion constraint as non-key columns. This allows index-only scans to be used for queries that select only included fields (:attr:`~ExclusionConstraint.include`) and filter only by indexed fields (:attr:`~ExclusionConstraint.expressions`).
- [9de1b085] An iterable of 2-tuples. The first element is an expression or string. The second element is an SQL operator represented as a string. To avoid typos, you may use :class:`~django.contrib.postgres.fields.RangeOperators` which maps the operators with strings. For example::
- [4582a05f3e793cbe] By default constraints are not deferred. A deferred constraint will not be enforced until the end of the transaction. An immediate constraint will be enforced immediately after every command.
- [62692a07] Examples --------
- [1a597c2b] In case your model defines a range using two fields, instead of the native PostgreSQL range types, you should write an expression that uses the equivalent function (e.g. ``TsTzRange()``), and use the delimiters for the field. Most often, the delimiters will be ``'[)'``, meaning that the lower bound is inclusive and the upper bound is exclusive. You may use the :class:`~django.contrib.postgres.fields.RangeBoundary` that provides an expression mapping for the `range boundaries <https://www.postgresql.org/docs/ current/rangetypes.html#RANGETYPES-INCLUSIVITY>`_. For example::
- [18f76d5f] PostgreSQL supports additional data integrity constraints available from the ``django.contrib.postgres.constraints`` module. They are added in the model :attr:`Meta.constraints <django.db.models.Options.constraints>` option.
- [beb51279] See :attr:`.BaseConstraint.name`.
- [c2d11d41] Set this parameter to create a deferrable exclusion constraint. Accepted values are ``Deferrable.DEFERRED`` or ``Deferrable.IMMEDIATE``. For example::
- [9d0f2313] The :class:`OpClass() <django.contrib.postgres.indexes.OpClass>` expression can be used to specify a custom `operator class`_ for the constraint expressions. For example::
- [57e2bd85a3d0d59e] The error code used when ``ValidationError`` is raised during :ref:`model validation <validating-objects>`. Defaults to ``None``.
- [8b5513b7] The error message used when ``ValidationError`` is raised during :ref:`model validation <validating-objects>`. Defaults to :attr:`.BaseConstraint.violation_error_message`.
- [65220e91] The following example restricts overlapping reservations in the same room, not taking canceled reservations into account::
- [024b67d8] The index type of the constraint. Accepted values are ``GiST``, ``Hash``, or ``SPGiST``. Matching is case insensitive. If not provided, the default index type is ``GIST``.
- [3e3dd500] These conditions have the same database restrictions as :attr:`django.db.models.Index.condition`.
- [27667ace] ``ExclusionConstraint`` =======================
- [3ef04f700014c56a] ``condition`` -------------
- [e105880c3e1bde26] ``deferrable`` --------------
- [aa7d175f0fd55e69] ``expressions`` ---------------
- [dcc88c68300cfc76] ``include`` -----------
- [2a4e7985] ``include`` is supported for GiST and SP-GiST indexes.
- [3f4dfa8b] ``index_type`` --------------
- [e9982e75ca22a002] ``name`` --------
- [4afa7d9a8f7918c6] ``violation_error_code`` ------------------------
- [d4a3f1a246802851] ``violation_error_message`` ---------------------------
- [1a13b10ced393a15] creates an exclusion constraint on ``circle`` using ``circle_ops``.
