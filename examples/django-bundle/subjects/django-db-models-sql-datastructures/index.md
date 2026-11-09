# django/db/models/sql/datastructures

- Subject: django/db/models/sql/datastructures (id `b8316186-9a2b-4381-8f07-ef78f0a2980b`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 11 of 24
- Conflicts: 0
- Gaps: 0

## Facts

- # Add a single condition inside parentheses for whatever # get_extra_restriction() returns. extra_cond = self.join_field.get_extra_restriction( self.table_alias, self.parent_alias ) if extra_cond: extra_sql, extra_params = compiler.compile(extra_cond) join_conditions.append("(%s)" % extra_sql) params.extend(extra_params) if self.filtered_relation: try: extra_sql, extra_params = compiler.compile(self.filtered_relation) except FullResultSet: pass else: join_conditions.append("(%s)" % extra_sql) params.extend(extra_params) if not join_conditions: # This might be a rel on the other end of an actual declared field. declared_field = getattr(self.join_field, "field", self.join_field) raise ValueError( "Join generated an empty ON clause. %s did not yield either " "joining columns or extra restrictions." % declared_field.__class__ ) on_clause_sql = " AND ".join(join_conditions) alias_str = ( "" if self.table_alias == self.table_name else (" %s" % qn(self.table_alias)) ) sql = "%s %s%s ON (%s)" % ( self.join_type, qn(self.table_name), alias_str, on_clause_sql, ) return sql, params [a416792a]
- @property def identity(self): return ( self.__class__, self.table_name, self.parent_alias, self.join_field, self.filtered_relation, ) [01ad808b]
- @property def identity(self): return self.__class__, self.table_name, self.table_alias [2ce0fea3]
- This class is primarily used in Query.alias_map. All entries in alias_map must be Join compatible by providing the following attributes and methods: - table_name (string) - table_alias (possible alias for the table, can be None) - join_type (can be None for those entries that aren't joined from anything) - parent_alias (which table is this join's parent, can be None similarly to join_type) - as_sql() - relabeled_clone() """ [8023e3d3]
- def __eq__(self, other): if not isinstance(other, BaseTable): return NotImplemented return self.identity == other.identity [902448f2]
- def __eq__(self, other): if not isinstance(other, Join): return NotImplemented return self.identity == other.identity [9b157ed5]
- def __hash__(self): return hash(self.identity) [35803cb27a9b3f58-4]
- def __init__( self, table_name, parent_alias, table_alias, join_type, join_field, nullable, filtered_relation=None, ): # Join table self.table_name = table_name self.parent_alias = parent_alias # Note: table_alias is not necessarily known at instantiation time. self.table_alias = table_alias # LOUTER or INNER self.join_type = join_type # A list of 2-tuples to use in the ON clause of the JOIN. # Each 2-tuple will create one join condition in the ON clause. self.join_fields = join_field.get_joining_fields() self.join_cols = tuple( (lhs_field.column, rhs_field.column) for lhs_field, rhs_field in self.join_fields ) # Along which field (or ForeignObjectRel in the reverse join case) self.join_field = join_field # Is this join nullable? self.nullable = nullable self.filtered_relation = filtered_relation [a0b35728]
- def __init__(self, names_pos, path_with_names): self.level = names_pos # The path travelled, this includes the path to the multijoin. self.names_with_path = path_with_names [3b287816]
- def __init__(self, table_name, alias): self.table_name = table_name self.table_alias = alias [5d91a2e2]
- class Empty: pass [da2d6b092e543d28-2]

## Beyond the budget

12 more facts did not fit in the budget: [572d67c6] [2c06ee81] [e6377fb2] [0a804f5c] [edc7abbf] [23c480fb] [0160acb8] [a140e6a1] [29660197] [e78a1819] [8b694ad5] [554a6b91]
