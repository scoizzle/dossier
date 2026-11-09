# django/db/models/sql/where

- Subject: django/db/models/sql/where (id `6f4a3f0b-caaf-456a-8a01-e4d5e262b610`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2816 tokens
- Facts shown: 42 facts
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [e8cda27d] However, a child could also be any class with as_sql() and either relabeled_clone() method or relabel_aliases() and clone() methods and contains_aggregate attribute. """
- [d7fef707] The class is tied to the Query class that created it (in order to create the correct SQL).
- [a642a92d1dcfc432-2] contains_aggregate = False contains_over_clause = False
- [25b218b7] def __init__(self, sqls, params): self.sqls = sqls self.params = params
- [6c1a49a3] def as_sql(self, compiler, connection): """ Return the SQL version of the where clause and the value to be substituted in. Return '', [] if this node matches everything, None, [] if this node is empty, and raise EmptyResultSet if this node can't match anything. """ result = [] result_params = [] if self.connector == AND: full_needed, empty_needed = len(self.children), 1 else: full_needed, empty_needed = 1, len(self.children)
- [07cd48e8] def as_sql(self, compiler=None, connection=None): raise EmptyResultSet
- [d4b9d2da] def as_sql(self, compiler=None, connection=None): sqls = ["(%s)" % sql for sql in self.sqls] return " AND ".join(sqls), list(self.params or ())
- [ed9e3a8a] def clone(self): clone = self.create(connector=self.connector, negated=self.negated) for child in self.children: if hasattr(child, "clone"): child = child.clone() clone.children.append(child) return clone
- [04c1448e] def get_db_converters(self, connection): return self.output_field.get_db_converters(connection)
- [0f56c28b] def get_group_by_cols(self): cols = [] for child in self.children: cols.extend(child.get_group_by_cols()) return cols
- [06f038c4a2bc2157-2] def get_lookup(self, lookup): return self.output_field.get_lookup(lookup)
- [b1c201f3] def get_refs(self): refs = set() for child in self.children: refs |= child.get_refs() return refs
- [4bb9769a] def get_source_expressions(self): return self.children[:]
- [1204654e] def leaves(self): for child in self.children: if isinstance(child, WhereNode): yield from child.leaves() else: yield child
- [cd2e7152] def relabel_aliases(self, change_map): """ Relabel the alias values of any children. 'change_map' is a dictionary mapping old (current) alias values to the new values. """ if not change_map: return self for pos, child in enumerate(self.children): if hasattr(child, "relabel_aliases"): # For example another WhereNode child.relabel_aliases(change_map) elif hasattr(child, "relabeled_clone"): self.children[pos] = child.relabeled_clone(change_map)
- [b30e58e5] def relabeled_clone(self, change_map): clone = self.clone() clone.relabel_aliases(change_map) return clone
- [431d84ea] def replace_expressions(self, replacements): if not replacements: return self if replacement := replacements.get(self): return replacement clone = self.create(connector=self.connector, negated=self.negated) for child in self.children: clone.children.append(child.replace_expressions(replacements)) return clone
- [a2b3b4c9] def resolve_expression(self, *args, **kwargs): clone = self.clone() clone._resolve_node(clone, *args, **kwargs) clone.resolved = True return clone
- [32d8845afa870a07-2] def select_format(self, compiler, sql, params): # Wrap filters with a CASE WHEN expression if a database backend # (e.g. Oracle) doesn't support boolean expression in SELECT or GROUP # BY list. if not compiler.connection.features.supports_boolean_expr_in_select_clause: sql = f"CASE WHEN {sql} THEN 1 ELSE 0 END" return sql, params
- [d3a4dd59] def set_source_expressions(self, children): assert len(children) == len(self.children) self.children = children
- [aec2d313] def split_having_qualify(self, negated=False, must_group_by=False): """ Return three possibly None nodes: one for those parts of self that should be included in the WHERE clause, one for those parts of self that must be included in the HAVING clause, and one for those parts that refer to window functions. """ if not self.contains_aggregate and not self.contains_over_clause: return self, None, None in_negated = negated ^ self.negated # Whether or not children must be connected in the same filtering # clause (WHERE > HAVING > QUALIFY) to maintain logical semantic. must_remain_connected = ( (in_negated and self.connector == AND) or (not in_negated and self.connector == OR) or self.connector == XOR ) if ( must_remain_connected and self.contains_aggregate and not self.contains_over_clause ): # It's much cheaper to short-circuit and stash everything in the # HAVING clause than split children if possible. return None, self, None where_parts = [] having_parts = [] qualify_parts = [] for c in self.children: if hasattr(c, "split_having_qualify"): where_part, having_part, qualify_part = c.split_having_qualify( in_negated, must_group_by ) if where_part is not None: where_parts.append(where_part) if having_part is not None: having_parts.append(having_part) if qualify_part is not None: qualify_parts.append(qualify_part) elif c.contains_over_clause: qualify_parts.append(c) elif c.contains_aggregate: having_parts.append(c) else: where_parts.append(c) if must_remain_connected and qualify_parts: # Disjunctive heterogeneous predicates can be pushed down to # qualify as long as no conditional aggregation is involved. if not where_parts or (where_parts and not must_group_by): return None, None, self elif where_parts: # In theory this should only be enforced when dealing with # where_parts containing predicates against multi-valued # relationships that could affect aggregation results but this # is complex to infer properly. raise NotImplementedError( "Heterogeneous disjunctive predicates against window functions are " "not implemented when performing conditional aggregation." ) where_node = ( self.create(where_parts, self.connector, self.negated) if where_parts else None ) having_node = ( self.create(having_parts, self.connector, self.negated) if having_parts else None ) qualify_node = ( self.create(qualify_parts, self.connector, self.negated) if qualify_parts else None ) return where_node, having_node, qualify_node
- [71cfd164] default = AND resolved = False conditional = True
- [3a01d367] """ Code to manage the creation and SQL rendering of 'where' constraints. """
- [126919f0] # Connection types AND = "AND" OR = "OR" XOR = "XOR"
- [f422205e] class ExtraWhere: # The contents are a black box - assume no aggregates or windows are used. contains_aggregate = False contains_over_clause = False
- [050cd457] class NothingNode: """A node that matches nothing."""
- [49943131] class WhereNode(tree.Node): """ An SQL WHERE clause.
- [c8c31d70] from django.core.exceptions import EmptyResultSet, FullResultSet from django.db.models.expressions import Case, When from django.db.models.functions import Mod from django.db.models.lookups import Exact from django.utils import tree from django.utils.functional import cached_property
- [862d79b4] import operator from functools import reduce
