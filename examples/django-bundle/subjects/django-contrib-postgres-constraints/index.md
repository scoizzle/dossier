# django/contrib/postgres/constraints

- Subject: django/contrib/postgres/constraints (id `e720e831-e405-47fa-89f2-8bb11c819dd6`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 5 of 17
- Conflicts: 0
- Gaps: 0

## Facts

- def __eq__(self, other): if isinstance(other, self.__class__): return ( self.name == other.name and self.index_type.lower() == other.index_type.lower() and self.expressions == other.expressions and self.condition == other.condition and self.deferrable == other.deferrable and self.include == other.include and self.violation_error_code == other.violation_error_code and self.violation_error_message == other.violation_error_message ) return super().__eq__(other) [aedc0562]
- def __init__( self, *, name, expressions, index_type=None, condition=None, deferrable=None, include=None, violation_error_code=None, violation_error_message=None, ): if index_type and index_type.lower() not in {"gist", "hash", "spgist"}: raise ValueError( "Exclusion constraints only support GiST, Hash, or SP-GiST indexes." ) if not expressions: raise ValueError( "At least one expression is required to define an exclusion " "constraint." ) if not all( isinstance(expr, (list, tuple)) and len(expr) == 2 for expr in expressions ): raise ValueError("The expressions must be a list of 2-tuples.") if not isinstance(condition, (NoneType, Q)): raise ValueError("ExclusionConstraint.condition must be a Q instance.") if not isinstance(deferrable, (NoneType, Deferrable)): raise ValueError( "ExclusionConstraint.deferrable must be a Deferrable instance." ) if not isinstance(include, (NoneType, list, tuple)): raise ValueError("ExclusionConstraint.include must be a list or tuple.") if index_type and index_type.lower() == "hash": if include: raise ValueError( "Covering exclusion constraints using Hash indexes are not " "supported." ) if not expressions: pass elif len(expressions) > 1: raise ValueError( "Composite exclusion constraints using Hash indexes are not " "supported." ) elif expressions[0][1] != RangeOperators.EQUAL: raise ValueError( "Exclusion constraints using Hash indexes only support the EQUAL " "operator." ) self.expressions = expressions self.index_type = index_type or "GIST" self.condition = condition self.deferrable = deferrable self.include = tuple(include) if include else () super().__init__( name=name, violation_error_code=violation_error_code, violation_error_message=violation_error_message, ) [6be14b43]
- def __repr__(self): return "<%s: index_type=%s expressions=%s name=%s%s%s%s%s%s>" % ( self.__class__.__qualname__, repr(self.index_type), repr(self.expressions), repr(self.name), "" if self.condition is None else " condition=%s" % self.condition, "" if self.deferrable is None else " deferrable=%r" % self.deferrable, "" if not self.include else " include=%s" % repr(self.include), ( "" if self.violation_error_code is None else " violation_error_code=%r" % self.violation_error_code ), ( "" if self.violation_error_message is None or self.violation_error_message == self.default_violation_error_message else " violation_error_message=%r" % self.violation_error_message ), ) [1cfc8c35]
- def _get_condition_sql(self, compiler, schema_editor, query): if self.condition is None: return None where = query.build_where(self.condition) sql, params = where.as_sql(compiler, schema_editor.connection) return sql % tuple(schema_editor.quote_value(p) for p in params) [ae780fd1]
- def create_sql(self, model, schema_editor): return Statement( "ALTER TABLE %(table)s ADD %(constraint)s", table=Table(model._meta.db_table, schema_editor.quote_name), constraint=self.constraint_sql(model, schema_editor), ) [ace50db9]

## Beyond the budget

12 more facts did not fit in the budget: [b6f5980a] [b7e61649] [dfac7baf] [7b694c8e] [813e445a] [e3377b0c] [7bc422c9] [a340c2f5] [4b828279] [5225503b] [d9014306] [91c09431be7a5272]
