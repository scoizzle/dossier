# django/db/models/lookups

- Subject: django/db/models/lookups (id `ae1aab26-568c-44c3-a917-230b584b88e0`)
- Kind: subject
- Budget: 1200 tokens
- Used: 889 tokens
- Facts shown: 15 of 111
- Conflicts: 0
- Gaps: 0

## Facts

- # rhs should be an iterable; use batch_process_rhs() to # prepare/transform those values. sqls, sqls_params = self.batch_process_rhs(compiler, connection, rhs) placeholder = "(" + ", ".join(sqls) + ")" return (placeholder, sqls_params) return super().process_rhs(compiler, connection) [5c4c5bf0]
- if isinstance(rhs, Query): raise NotImplementedError( "Bilateral transformations on nested querysets are not implemented." ) self.bilateral_transforms = bilateral_transforms [6c2a707e]
- if not rhs: raise EmptyResultSet [ac162514]
- if self.rhs_is_direct_value(): self.rhs = Value(self.rhs) self.rhs = Replace( self.rhs, Value("-"), Value(""), output_field=CharField() ) rhs, params = super().process_rhs(qn, connection) return rhs, params [edf26915]
- if isinstance(query := self.rhs, Query): if not query.has_limit_one(): raise ValueError( "The QuerySet value for an exact lookup must be limited to " "one result using slicing." ) lhs_len = len(self.lhs) if isinstance(self.lhs, (ColPairs, tuple)) else 1 if (rhs_len := query._subquery_fields_len) != lhs_len: raise ValueError( f"The QuerySet value for the exact lookup must have {lhs_len} " f"selected fields (received {rhs_len})" ) if not query.has_select_fields: query.clear_select_clause() query.add_fields(["pk"]) return super().get_prep_lookup() [04447164]
- if isinstance(self.rhs, Query): lhs_len = len(self.lhs) if isinstance(self.lhs, (ColPairs, tuple)) else 1 if (rhs_len := self.rhs._subquery_fields_len) != lhs_len: raise ValueError( f"The QuerySet value for the 'in' lookup must have {lhs_len} " f"selected fields (received {rhs_len})" ) self.rhs.clear_ordering(clear_default=True) if not self.rhs.has_select_fields: self.rhs.clear_select_clause() self.rhs.add_fields(["pk"]) return super().get_prep_lookup() [3ea339c9]
- if self.rhs_is_direct_value(): # Remove None from the list as NULL is never equal to anything. try: rhs = OrderedSet(self.rhs) rhs.discard(None) except TypeError: # Unhashable items in self.rhs rhs = [r for r in self.rhs if r is not None] [c6e6e6bd]
- iso_year = isinstance(self.lhs, ExtractIsoYear) output_field = self.lhs.lhs.output_field if isinstance(output_field, DateTimeField): bounds = connection.ops.year_lookup_bounds_for_datetime_field( year, iso_year=iso_year, ) else: bounds = connection.ops.year_lookup_bounds_for_date_field( year, iso_year=iso_year, ) return bounds [8c9b1c32]
- @cached_property def allowed_default(self): return self.lhs.allowed_default and self.rhs.allowed_default [1b261b413c1ee8d4-2]
- @cached_property def output_field(self): return BooleanField() [f57f8672]
- @property def identity(self): return self.__class__, self.lhs, self.rhs [c6c3215c]
- @property def is_simple_lookup(self): # A "simple lookup" is a Python value (as long as it's not a bilateral # transform). return self.rhs_is_direct_value() and not self.bilateral_transforms [ca1193f4]
- @property def lhs(self): return self.get_source_expressions()[0] [c752d501]
- bilateral = False arity = 1 [74d431c0]
- def __eq__(self, other): if not isinstance(other, Lookup): return NotImplemented return self.identity == other.identity [4f4d4cbf]

## Beyond the budget

95 more facts did not fit in the budget: [c06a877c] [44fbba4c] [e8e3eaeb] [3938bc35] [e1dba32c] [5109f003] [f900753e] [9586d0eb] [5e31f857] [ec93781a] [240a412e] [eded4065] [3244ceca] [fbe6095a] [d954c20b] [8dfd67a4] [fd1f1309] [4cb65ffc] [afe01f39] [d4f98d46] [b7072a4d15402fa7-2] [4099b601] [89c085d594e66e49] [846ad9a5] [d17dd370] [56e82f78] [acce8e8c] [a39d4272] [05df5a0c] [09b070af] [99d1802d] [a74f0b5b] [6b80e1b3] [d32ccec2] [6dbdcf9d] [966a9e2d] [7d46dd41] [a716741c] [c536b438] [676c4f40] [61af208b] [ee74eadc] [32d8845afa870a07] [35a69b38] [3330a722] [3f63307b] [43fd7d8c] [bdf76bd1] [1c5a09ad] [bffe85dc] [ed3f304f] [c2d04f5d] [62530189] [0dd619ad] [df2f2262] [85347b47] [258380b0] [adef707f] [64f94ac5] [00d826a7] [d3ab9d26] [845eb0fe] [948c2267] [1301d13e] [a9b12d23] [fac4aedc] [d39cc2ef] [9e84e48a] [01dcdcbd] [f6df01b6] [c4a37c90] [0b2012ec] [8cac3568] [41cfdfc1] [c609d6f5] [17a3784a] [be0cdcf0] [9de92b9d] [9f4b0834] [c454398c] [fc0b7dfe] [1733896b] [6c34273f] [b4797fa7] [bbd2f1e2] [bb2ebd55] [78898d92] [42408eba] [18526822] [556daf57] [a12d87d7] [a1b3f877] [68481c8d] [c67916b6] [e36028c0]
