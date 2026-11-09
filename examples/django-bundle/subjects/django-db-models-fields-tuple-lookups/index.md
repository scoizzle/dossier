# django/db/models/fields/tuple_lookups

- Subject: django/db/models/fields/tuple_lookups (id `f4653e44-176b-4022-9b8d-79684a350fed`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 17 of 49
- Conflicts: 0
- Gaps: 0

## Facts

- # e.g.: (a, b, c) in [(x1, y1, z1), (x2, y2, z2)] as SQL: # WHERE (a = x1 AND b = y1 AND c = z1) # OR (a = x2 AND b = y2 AND c = z2) root = WhereNode([], connector=OR) lhs = self.lhs [27a09884]
- # e.g.: (a, b, c) in [(x1, y1, z1), (x2, y2, z2)] as SQL: # WHERE (a, b, c) IN ((x1, y1, z1), (x2, y2, z2)) result = [] lhs = self.lhs [eea6fca9]
- for col, val in zip(cols_iter, vals_iter): lookup = next(lookups) connector = next(connectors) child = WhereNode([lookup(col, val)], connector=connector) node.children.append(child) node = child [826ed8531e44fec5]
- for vals in rhs: # Remove any tuple containing None from the list as NULL is never # equal to anything. if any(val is None for val in vals): continue lookups = [Exact(col, val) for col, val in zip(lhs, vals)] root.children.append(WhereNode(lookups, connector=AND)) [4e993664]
- for vals in rhs: # Remove any tuple containing None from the list as NULL is never # equal to anything. if any(val is None for val in vals): continue result.append( Tuple( *[ ( val if hasattr(val, "as_sql") else Value(val, output_field=col.output_field) ) for col, val in zip(lhs, vals) ] ) ) [c646282e]
- if not result: raise EmptyResultSet [5be3c10a]
- if not root.children: raise EmptyResultSet return root.as_sql(compiler, connection) [588f89eb]
- return compiler.compile(Tuple(*result)) [3b5f6518]
- return root.as_sql(compiler, connection) [df8b6734a98f6c6e]
- return self.rhs # skip checks from mixin [c2c8c3ab]
- rhs = self.rhs if not rhs: raise EmptyResultSet [dbe6f7a3]
- def __iter__(self): return iter(self.source_expressions) [1218d716]
- def __len__(self): return len(self.source_expressions) [35b7a8e7]
- def as_sql(self, compiler, connection): # e.g.: (a, b, c) is None as SQL: # WHERE a IS NULL OR b IS NULL OR c IS NULL # e.g.: (a, b, c) is not None as SQL: # WHERE a IS NOT NULL AND b IS NOT NULL AND c IS NOT NULL rhs = self.rhs lookups = [IsNull(col, rhs) for col in self.lhs] root = WhereNode(lookups, connector=OR if rhs else AND) return root.as_sql(compiler, connection) [f42f5373]
- def as_sql(self, compiler, connection): if ( not connection.features.supports_tuple_comparison_against_subquery and isinstance(self.rhs, Query) and self.rhs.subquery and isinstance( self, (GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual) ) ): lookup = self.lookup_name msg = ( f'"{lookup}" cannot be used to target composite fields ' "through subqueries on this backend" ) raise NotSupportedError(msg) if not connection.features.supports_tuple_lookups: return self.get_fallback_sql(compiler, connection) return super().as_sql(compiler, connection) [bb023067]
- def as_sqlite(self, compiler, connection): if connection.get_database_version() < (3, 37) and isinstance( first_expr := self.source_expressions[0], Tuple ): first_expr = first_expr.copy() first_expr.function = "VALUES" return Tuple(first_expr, *self.source_expressions[1:]).as_sql( compiler, connection ) return self.as_sql(compiler, connection) [182022c4]
- def get_prep_lhs(self): if isinstance(self.lhs, (tuple, list)): return Tuple(*self.lhs) return super().get_prep_lhs() [6a895954]

## Beyond the budget

22 more facts did not fit in the budget: [022b5a46] [06762cd0] [cb060ac0] [4ab7ad47] [817b733c] [853d1fc3] [517800f1] [072da646] [b2da4280] [e04f3b84] [54883654] [2afe6e21] [f3ee2bab] [d92f0556] [e85b9250] [befbfd0e] [fcd028d4] [d42a3f6a] [8baa3192] [52d0f712] [a8b14593] [5e8fce20]
