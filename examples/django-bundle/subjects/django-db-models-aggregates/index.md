# django/db/models/aggregates

- Subject: django/db/models/aggregates (id `1566c7c0-52ef-4279-903a-eea620989bba`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 3678 tokens
- Facts shown: 65 of 67
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [d967df7d] @property def default_alias(self): expressions = [ expr for expr in self.get_source_expressions() if expr is not None ] if len(expressions) == 1 and hasattr(expressions[0], "name"): return "%s__%s" % (expressions[0].name, self.name.lower()) raise TypeError("Complex expressions require an alias")
- [c8af8336] def __init__( self, *expressions, distinct=False, filter=None, default=None, order_by=None, **extra, ): if distinct and not self.allow_distinct: raise TypeError("%s does not allow distinct." % self.__class__.__name__) if order_by and not self.allow_order_by: raise TypeError("%s does not allow order_by." % self.__class__.__name__) if default is not None and self.empty_result_set_value is not None: raise TypeError(f"{self.__class__.__name__} does not allow default.")
- [1efd6084] def __init__(self, expression, **extra): super().__init__(expression, **extra) # self.default is reset in Aggregate.resolve_expression(). Store the # information for the later check in as_sql(). self._has_default = self.default is not None
- [007d83d9] def __init__(self, expression, delimiter, **extra): self.delimiter = StringAggDelimiter(delimiter) super().__init__(expression, self.delimiter, **extra)
- [364bcda3] def __init__(self, expression, filter=None, **extra): if expression == "*": expression = Star() if isinstance(expression, Star) and filter is not None: raise ValueError("Star cannot be used with filter. Please specify a field.") super().__init__(expression, filter=filter, **extra)
- [5c8652b8] def __init__(self, expression, sample=False, **extra): self.function = "STDDEV_SAMP" if sample else "STDDEV_POP" super().__init__(expression, **extra)
- [52bd520a] def __init__(self, value): self.value = value super().__init__(value)
- [fb8ef8318565966b] def __str__(self): return self.arg_joiner.join(str(arg) for arg in self.source_expressions)
- [36179838] def _get_repr_options(self): options = super()._get_repr_options() if self.distinct: options["distinct"] = self.distinct if self.filter: options["filter"] = self.filter if self.order_by: options["order_by"] = self.order_by return options
- [9de842ef] def _get_repr_options(self): return {**super()._get_repr_options(), "sample": self.function == "STDDEV_SAMP"}
- [7b6d4035] def _get_repr_options(self): return {**super()._get_repr_options(), "sample": self.function == "VAR_SAMP"}
- [6c188866] def as_mysql(self, compiler, connection, **extra_context): extra_context["function"] = "GROUP_CONCAT"
- [5d68c0b2] def as_mysql(self, compiler, connection, **extra_context): template = " SEPARATOR %(expressions)s"
- [24d04821] def as_oracle(self, compiler, connection, **extra_context): if self.order_by: template = ( "%(function)s(%(distinct)s%(expressions)s) WITHIN GROUP (%(order_by)s)" "%(filter)s" ) else: template = "%(function)s(%(distinct)s%(expressions)s)%(filter)s"
- [95280174] def as_oracle(self, compiler, connection, **extra_context): return self.as_sql( compiler, connection, function=f"{self.function}_AGG", **extra_context, )
- [baeed201] def as_sql(self, compiler, connection, **extra_context): if ( self.distinct and not connection.features.supports_aggregate_distinct_multiple_argument and len(super().get_source_expressions()) > 1 ): raise NotSupportedError( f"{self.name} does not support distinct with multiple expressions on " f"this database backend." )
- [e5c6f770] def as_sql(self, compiler, connection, **extra_context): if not connection.features.supports_aggregate_filter_clause: raise NotSupportedError( "Aggregate filter clauses are not supported on this database backend." ) try: return super().as_sql(compiler, connection, **extra_context) except FullResultSet: return "", ()
- [1b9939fc] def as_sql(self, compiler, connection, **extra_context): if not connection.features.supports_aggregate_order_by_clause: raise NotSupportedError( "This database backend does not support specifying an order on " "aggregates." )
- [2e6f9a11] def as_sql(self, compiler, connection, **extra_context): if not connection.features.supports_any_value: raise NotSupportedError( "ANY_VALUE is not supported on this database backend." ) return super().as_sql(compiler, connection, **extra_context)
- [a07e9f50] def as_sql(self, compiler, connection, **extra_context): if not connection.features.supports_bit_aggregations: raise NotSupportedError( f"{self.name} is not supported on {connection.vendor}." ) if ( self._has_default and not connection.features.supports_default_in_bit_aggregations ): raise NotSupportedError( f"{self.name} does not support the default parameter on " f"{connection.vendor}." ) return super().as_sql(compiler, connection, **extra_context)
- [8ce2c697] def as_sqlite(self, compiler, connection, **extra_context): if ( self.distinct and isinstance(self.delimiter.value, Value) and self.delimiter.value.value == "," ): clone = self.copy() source_expressions = clone.get_source_expressions() clone.set_source_expressions( source_expressions[:1] + source_expressions[2:] )
- [bcca889fb4987223] def get_group_by_cols(self): return []
- [e4a8678e] def get_source_expressions(self): source_expressions = super().get_source_expressions() return [*source_expressions, self.filter, self.order_by]
- [f2b73181] def get_source_fields(self): # Don't consider filter and order by expression as they have nothing # to do with the output field resolution. return [e._output_field_or_none for e in super().get_source_expressions()]
- [dd8db11a] def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False ): # Aggregates are not allowed in UPDATE queries, so ignore for_save c = super().resolve_expression(query, allow_joins, reuse, summarize) if summarize: # Summarized aggregates cannot refer to summarized aggregates. for ref in c.get_refs(): if query.annotations[ref].is_summary: raise FieldError( f"Cannot compute {c.name}('{ref}'): '{ref}' is an aggregate" ) elif not self.is_summary: # Call Aggregate.get_source_expressions() to avoid # returning self.filter and including that in this loop. expressions = super(Aggregate, c).get_source_expressions() for index, expr in enumerate(expressions): if expr.contains_aggregate: before_resolved = self.get_source_expressions()[index] name = ( before_resolved.name if hasattr(before_resolved, "name") else repr(before_resolved) ) raise FieldError( "Cannot compute %s('%s'): '%s' is an aggregate" % (c.name, name, name) ) if (default := c.default) is None: return c if hasattr(default, "resolve_expression"): default = default.resolve_expression(query, allow_joins, reuse, summarize) if default._output_field_or_none is None: default.output_field = c._output_field_or_none else: default = Value(default, c._output_field_or_none) c.default = None # Reset the default argument before wrapping. coalesce = Coalesce(c, default, output_field=c._output_field_or_none) coalesce.is_summary = c.is_summary return coalesce
- [6c7842ef] def resolve_expression(self, *args, **kwargs): result = super().resolve_expression(*args, **kwargs) source_expressions = result.get_source_expressions()
- [6c2d60f0] def set_source_expressions(self, exprs): *exprs, self.filter, self.order_by = exprs return super().set_source_expressions(exprs)
- [f19fe3ab] """ Classes to represent the definitions of aggregate functions. """
- [1ab8f8b3] __all__ = [ "Aggregate", "AnyValue", "Avg", "BitAnd", "BitOr", "BitXor", "Count", "Max", "Min", "StdDev", "StringAgg", "Sum", "Variance", ]
- [823b3af0] class Aggregate(Func): template = "%(function)s(%(distinct)s%(expressions)s%(order_by)s)%(filter)s" contains_aggregate = True name = None window_compatible = True allow_distinct = False allow_order_by = False empty_result_set_value = None
- [8cd7206e] class AggregateFilter(Func): arity = 1 template = " FILTER (WHERE %(expressions)s)"
- [e357c8f7] class AggregateOrderBy(OrderByList): template = " ORDER BY %(expressions)s"
- [af8505d4] class AnyValue(Aggregate): function = "ANY_VALUE" name = "AnyValue" arity = 1 window_compatible = False
- [7ba3dd2f] class Avg(FixDurationInputMixin, NumericOutputFieldMixin, Aggregate): function = "AVG" name = "Avg" allow_distinct = True arity = 1
- [00a49015] class BitAggregate(Aggregate): arity = 1
- [dceab683] class BitAnd(BitAggregate): function = "BIT_AND" name = "BitAnd"
- [a16829f9] class BitOr(BitAggregate): function = "BIT_OR" name = "BitOr"
- [1aebb279] class BitXor(BitAggregate): function = "BIT_XOR" name = "BitXor"
- [55812d68] class Count(Aggregate): function = "COUNT" name = "Count" output_field = IntegerField() allow_distinct = True empty_result_set_value = 0 arity = 1 allows_composite_expressions = True
- [7405c39d] class Max(Aggregate): function = "MAX" name = "Max" arity = 1
- [111099c2] class Min(Aggregate): function = "MIN" name = "Min" arity = 1
- [826df137] class StdDev(NumericOutputFieldMixin, Aggregate): name = "StdDev" arity = 1
- [2d0b7f34] class StringAgg(Aggregate): template = "%(function)s(%(distinct)s%(expressions)s%(order_by)s)%(filter)s" function = "STRING_AGG" name = "StringAgg" allow_distinct = True allow_order_by = True output_field = TextField()
- [99f24d9e] class StringAggDelimiter(Func): arity = 1 template = "%(expressions)s"
- [c67993c0] class Sum(FixDurationInputMixin, Aggregate): function = "SUM" name = "Sum" allow_distinct = True arity = 1
- [3ffe3b39] class Variance(NumericOutputFieldMixin, Aggregate): name = "Variance" arity = 1
- [b583e9c6] from django.core.exceptions import FieldError, FullResultSet from django.db import NotSupportedError from django.db.models.expressions import ( Case, ColPairs, Func, OrderByList, Star, Value, When, ) from django.db.models.fields import IntegerField, TextField from django.db.models.functions import Coalesce from django.db.models.functions.mixins import ( FixDurationInputMixin, NumericOutputFieldMixin, )
