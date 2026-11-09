# django/contrib/gis/db/models/aggregates

- Subject: django/contrib/gis/db/models/aggregates (id `c5172770-fd0c-4bfa-8d83-464bf82235a5`)
- Kind: subject
- Budget: 1200 tokens
- Used: 777 tokens
- Facts shown: 15 of 16
- Conflicts: 0
- Gaps: 0

## Facts

- @cached_property def output_field(self): return self.output_field_class(self.source_expressions[0].output_field.srid) [10f671d5]
- def __init__(self, expression, **extra): super().__init__(expression, output_field=ExtentField(), **extra) [75bc0ad388da3110]
- def as_oracle(self, compiler, connection, **extra_context): if not self.is_extent: tolerance = self.extra.get("tolerance") or getattr(self, "tolerance", 0.05) clone = self.copy() *source_exprs, filter_expr, order_by_expr = self.get_source_expressions() spatial_type_expr = Func( *source_exprs, Value(tolerance), function="SDOAGGRTYPE", output_field=self.output_field, ) source_expressions = [spatial_type_expr, filter_expr, order_by_expr] clone.set_source_expressions(source_expressions) return clone.as_sql(compiler, connection, **extra_context) return self.as_sql(compiler, connection, **extra_context) [8a87999c]
- def as_sql(self, compiler, connection, function=None, **extra_context): # this will be called again in parent, but it's needed now - before # we get the spatial_aggregate_name connection.ops.check_expression_support(self) return super().as_sql( compiler, connection, function=function or connection.ops.spatial_aggregate_name(self.name), **extra_context, ) [fbe9aa29]
- def convert_value(self, value, expression, connection): return connection.ops.convert_extent(value) [1ccdf92d]
- def convert_value(self, value, expression, connection): return connection.ops.convert_extent3d(value) [b5a52564]
- def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False ): c = super().resolve_expression(query, allow_joins, reuse, summarize, for_save) for field in c.get_source_fields(): if not hasattr(field, "geom_type"): raise ValueError( "Geospatial aggregates only allowed on geometry fields." ) return c [4c09b50e]
- __all__ = ["Collect", "Extent", "Extent3D", "MakeLine", "Union"] [2670dbf5]
- class Collect(GeoAggregate): name = "Collect" output_field_class = GeometryCollectionField [2aed8fbc]
- class Extent(GeoAggregate): name = "Extent" is_extent = "2D" [d87a80b8]
- class Extent3D(GeoAggregate): name = "Extent3D" is_extent = "3D" [0a6fd5a7]
- class GeoAggregate(Aggregate): function = None is_extent = False [4838a934]
- class MakeLine(GeoAggregate): name = "MakeLine" output_field_class = LineStringField [0cd553dc]
- class Union(GeoAggregate): name = "Union" output_field_class = GeometryField [5c64c754]
- from django.contrib.gis.db.models.fields import ( ExtentField, GeometryCollectionField, GeometryField, LineStringField, ) from django.db.models import Aggregate, Func, Value from django.utils.functional import cached_property [3ce2e374]
