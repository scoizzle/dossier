# django/db/models/sql/where

- Subject: django/db/models/sql/where (id `6c3936f9-19ce-4fc5-b8a4-9547973bfc32`)
- Kind: subject
- Budget: 1200 tokens
- Used: 892 tokens
- Facts shown: 13 of 42
- Conflicts: 0
- Gaps: 0

## Facts

- for child in self.children: try: sql, params = compiler.compile(child) except EmptyResultSet: empty_needed -= 1 except FullResultSet: full_needed -= 1 else: if sql: result.append(sql) result_params.extend(params) else: full_needed -= 1 # Check if this node matches nothing or everything. # First check the amount of full nodes and empty nodes # to make this node empty/full. # Now, check if this node is full/empty using the # counts. if empty_needed == 0: if self.negated: raise FullResultSet else: raise EmptyResultSet if full_needed == 0: if self.negated: raise EmptyResultSet else: raise FullResultSet conn = " %s " % self.connector sql_string = conn.join(result) if not sql_string: raise FullResultSet if self.negated: # Some backends (Oracle at least) need parentheses around the inner # SQL in the negated case, even if the inner SQL contains just a # single expression. sql_string = "NOT (%s)" % sql_string elif len(result) > 1 or self.resolved: sql_string = "(%s)" % sql_string return sql_string, result_params [b411e7c9]
- if self.connector == XOR and not connection.features.supports_logical_xor: # Convert if the database doesn't support XOR: # a XOR b XOR c XOR ... # to: # (a OR b OR c OR ...) AND MOD(a + b + c + ..., 2) == 1 # The result of an n-ary XOR is true when an odd number of operands # are true. lhs = self.__class__(self.children, OR) rhs_sum = reduce( operator.add, (Case(When(c, then=1), default=0) for c in self.children), ) if len(self.children) > 2: rhs_sum = Mod(rhs_sum, 2) rhs = Exact(1, rhs_sum) return self.__class__([lhs, rhs], AND, self.negated).as_sql( compiler, connection ) [23958a4e]
- return BooleanField() [25a5f20c]
- @cached_property def contains_aggregate(self): return self._contains_aggregate(self) [cd21b8aa]
- @cached_property def contains_over_clause(self): return self._contains_over_clause(self) [889e7da3]
- @cached_property def output_field(self): from django.db.models import BooleanField [edde3bf8]
- @classmethod def _contains_aggregate(cls, obj): if isinstance(obj, tree.Node): return any(cls._contains_aggregate(c) for c in obj.children) return obj.contains_aggregate [03923e01]
- @classmethod def _contains_over_clause(cls, obj): if isinstance(obj, tree.Node): return any(cls._contains_over_clause(c) for c in obj.children) return obj.contains_over_clause [8f629635]
- @classmethod def _resolve_node(cls, node, query, *args, **kwargs): if hasattr(node, "children"): for child in node.children: cls._resolve_node(child, query, *args, **kwargs) if hasattr(node, "lhs"): node.lhs = cls._resolve_leaf(node.lhs, query, *args, **kwargs) if hasattr(node, "rhs"): node.rhs = cls._resolve_leaf(node.rhs, query, *args, **kwargs) [f80d1208]
- @property def _output_field_or_none(self): return self.output_field [a53b9b10]
- @property def is_summary(self): return any(child.is_summary for child in self.children) [bc570d3a]
- @staticmethod def _resolve_leaf(expr, query, *args, **kwargs): if hasattr(expr, "resolve_expression"): expr = expr.resolve_expression(query, *args, **kwargs) return expr [afbe750e]
- A child is usually an expression producing boolean values. Most likely the expression is a Lookup instance. [439f69c0]

## Beyond the budget

29 more facts did not fit in the budget: [e8cda27d] [d7fef707] [a642a92d1dcfc432-2] [25b218b7] [6c1a49a3] [07cd48e8] [d4b9d2da] [ed9e3a8a] [04c1448e] [0f56c28b] [06f038c4a2bc2157-2] [b1c201f3] [4bb9769a] [1204654e] [cd2e7152] [b30e58e5] [431d84ea] [a2b3b4c9] [32d8845afa870a07-2] [d3a4dd59] [aec2d313] [71cfd164] [3a01d367] [126919f0] [f422205e] [050cd457] [49943131] [c8c31d70] [862d79b4]
