# docs/howto/custom-lookups

- Subject: docs/howto/custom-lookups (id `dbdc9d63-4e04-440d-8b91-a00226fdbe67`)
- Kind: subject
- Budget: 1200 tokens
- Used: 888 tokens
- Facts shown: 27 of 91
- Conflicts: 0
- Gaps: 0

## Facts

- @property def output_field(self): return FloatField() [6385f90b]
- def as_sql(self, compiler, connection): lhs, lhs_params = compiler.compile(self.lhs.lhs) rhs, rhs_params = self.process_rhs(compiler, connection) params = lhs_params + rhs_params + lhs_params + rhs_params return "%s < %s AND %s > -%s" % (lhs, rhs, lhs, rhs), params [7b788422]
- @Field.register_lookup class NotEqualLookup(Lookup): ... [e54f4bbe]
- SELECT .. WHERE "experiments"."change" < 27 AND "experiments"."change" > -27 [f1302d47]
- SELECT ... DISTINCT ON ABS("experiments"."change") [e9f703db]
- SELECT ... ORDER BY ABS("experiments"."change") ASC [34121b9c]
- SELECT ... WHERE ABS("experiments"."change") < 27 [b6b77324]
- SELECT ... WHERE UPPER("author"."name") = UPPER('doe') [bab31f45]
- class AbsoluteValue(Transform): lookup_name = "abs" function = "ABS" [71365885e940e4eb]
- class CoordinatesField(Field): def get_lookup(self, lookup_name): if lookup_name.startswith("x"): try: dimension = int(lookup_name.removeprefix("x")) except ValueError: pass else: return get_coordinate_lookup(dimension) return super().get_lookup(lookup_name) [54863ad1]
- from django.db.models import Field [843257ed3e771056]
- from django.db.models import FloatField, Transform [f9efdb27]
- "author"."name" <> 'Jack' [0e090e0d]
- AbsoluteValue.register_lookup(AbsoluteValueLessThan) [ba214683]
- CharField.register_lookup(UpperCase) TextField.register_lookup(UpperCase) [571a14d0]
- Field.register_lookup(MySQLNotEqual) [b988e35c]
- Field.register_lookup(NotEqual) [b84f5316]
- IntegerField.register_lookup(AbsoluteValue) [7919a5d3]
- class AbsoluteValueLessThan(Lookup): lookup_name = "lt" [ab14caa1]
- class MySQLNotEqual(NotEqual): def as_mysql(self, compiler, connection, **extra_context): lhs, lhs_params = self.process_lhs(compiler, connection) rhs, rhs_params = self.process_rhs(compiler, connection) params = lhs_params + rhs_params return "%s != %s" % (lhs, rhs), params [cfcaa6aa]
- class NotEqual(Lookup): lookup_name = "ne" [9f30cd9e]
- class UpperCase(Transform): lookup_name = "upper" function = "UPPER" bilateral = True [92fdb582]
- from django.db.models import CharField, TextField [a3805cde]
- from django.db.models import IntegerField [75c589bf]
- from django.db.models import Lookup [9099c674b8f0850a]
- - ``.filter(myfield__mylookup)`` will call ``myfield.get_lookup('mylookup')``. - ``.filter(myfield__mytransform__mylookup)`` will call ``myfield.get_transform('mytransform')``, and then ``mytransform.get_lookup('mylookup')``. - ``.filter(myfield__mytransform)`` will first call ``myfield.get_lookup('mytransform')``, which will fail, so it will fall back to calling ``myfield.get_transform('mytransform')`` and then ``mytransform.get_lookup('exact')``. [97514652]
- .. code-block:: sql [0ee73173f492412a-2]

## Beyond the budget

57 more facts did not fit in the budget: [0ee73173f492412a-3] [0ee73173f492412a-4] [0ee73173f492412a-5] [0ee73173f492412a-6] [0ee73173f492412a-7] [0ee73173f492412a-8] [3a368b18514a814b] [3746f028] [63d8ce70] [9b33dfca] [2012fe75] [41d0d2d0] [d22220df] [fe425b2c] [5d540da1] [03f7413e] [dd3dad22] [5d9a72c6] [ca1f3859] [344b7002] [5dbca7ea] [6b602622] [1c140b37] [350910a3] [63e30e37] [9345e80a] [eccc87b4] [d79d7803] [8c60409e] [3b0009ac] [bbfd7ea3] [13f587a0] [73b53753] [0b98f40e] [f4304712] [fe81a9a4] [ca448d92] [8379284e] [533cc3b3] [34be4cc3] [29217ba3] [d2608595] [0a779e79] [78f49cb1] [6c7b1115] [8e60b822] [b4308d31] [4f942c31] [c49b0df8] [f682b726] [21600dc4] [e8d2a6fe] [4a773061] [9fdacfdc] [cf03b2f6] [e3d29dc8] [fd329152]
