# django/db/models/aggregates

- Subject: django/db/models/aggregates (id `bb3351e7-6d8a-4319-82c7-729965938ae4`)
- Kind: subject
- Budget: 1200 tokens
- Used: 884 tokens
- Facts shown: 18 of 67
- Conflicts: 0
- Gaps: 0

## Facts

- return clone.as_sql( compiler, connection, function="GROUP_CONCAT", **extra_context, ) [01eb4cfd]
- source_expressions[0] = expr.get_cols()[0] result.set_source_expressions(source_expressions) [450ac29f]
- # In case of composite primary keys, count the first column. if isinstance(expr := source_expressions[0], ColPairs): if self.distinct: raise ValueError( "COUNT(DISTINCT) doesn't support composite primary keys" ) [241923d8]
- c = self.copy() # The creation of the delimiter SQL and the ordering of the parameters # must be handled explicitly, as MySQL puts the delimiter at the end of # the aggregate using the `SEPARATOR` declaration (rather than treating # as an expression like other database backends). delimiter_params = [] if c.delimiter: delimiter_sql, delimiter_params = compiler.compile(c.delimiter) # Drop the delimiter from the source expressions. c.source_expressions = c.source_expressions[:-1] extra_context["delimiter"] = delimiter_sql [c7d410d9]
- distinct_sql = "DISTINCT " if self.distinct else "" order_by_sql = "" order_by_params = [] filter_sql = "" filter_params = [] [3d059c57]
- extra_context.update( distinct=distinct_sql, filter=filter_sql, order_by=order_by_sql, ) sql, params = super().as_sql(compiler, connection, **extra_context) return sql, (*params, *order_by_params, *filter_params) [a5e2dc27]
- if (order_by := self.order_by) is not None: order_by_sql, order_by_params = compiler.compile(order_by) [89f0344e]
- if connection.get_database_version() < (3, 44): return self.as_sql( compiler, connection, function="GROUP_CONCAT", **extra_context, ) [6ffef286]
- if self.filter is not None: try: filter_sql, filter_params = compiler.compile(self.filter) except NotSupportedError: # Fallback to a CASE statement on backends that don't support # the FILTER clause. copy = self.copy() copy.filter = None source_expressions = copy.get_source_expressions() condition = When(self.filter.condition, then=source_expressions[0]) copy.set_source_expressions([Case(condition)] + source_expressions[1:]) return copy.as_sql(compiler, connection, **extra_context) [10354fac]
- return result [e6d2cf0b52c4ebca-3]
- return self.as_sql( compiler, connection, function="LISTAGG", template=template, **extra_context, ) [fcc3bc66]
- return self.as_sql( compiler, connection, template=template, **extra_context, ) [cdc1b33f]
- return sql, (*params, *delimiter_params) [e44039ce]
- return super().as_sql(compiler, connection, **extra_context) [1a0b46f5a52f62b5]
- self.distinct = distinct self.filter = None if filter is None else AggregateFilter(filter) self.default = default self.order_by = AggregateOrderBy.from_param( f"{self.__class__.__name__}.order_by", order_by ) super().__init__(*expressions, **extra) [bd67815d]
- sql, params = c.as_sql(compiler, connection, **extra_context) [dba3bd09]
- template = "%(function)s(%(distinct)s%(expressions)s%(order_by)s%(delimiter)s)" extra_context["template"] = template [9702c69b]
- @property def condition(self): return self.source_expressions[0] [300a9477]

## Beyond the budget

47 more facts did not fit in the budget: [d967df7d] [c8af8336] [1efd6084] [007d83d9] [364bcda3] [5c8652b8] [52bd520a] [fb8ef8318565966b] [36179838] [9de842ef] [7b6d4035] [6c188866] [5d68c0b2] [24d04821] [95280174] [baeed201] [e5c6f770] [1b9939fc] [2e6f9a11] [a07e9f50] [8ce2c697] [bcca889fb4987223] [e4a8678e] [f2b73181] [dd8db11a] [6c7842ef] [6c2d60f0] [f19fe3ab] [1ab8f8b3] [823b3af0] [8cd7206e] [e357c8f7] [af8505d4] [7ba3dd2f] [00a49015] [dceab683] [a16829f9] [1aebb279] [55812d68] [7405c39d] [111099c2] [826df137] [2d0b7f34] [99f24d9e] [c67993c0] [3ffe3b39] [b583e9c6]
