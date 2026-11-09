# django/contrib/gis/db/models/lookups

- Subject: django/contrib/gis/db/models/lookups (id `db2533ef-d5a2-49a9-a9c5-efee68146184`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 3205 tokens
- Facts shown: 65 of 65
- Conflicts: 0
- Gaps: 0

## Highlights

- # Check if the second parameter is a band index. if len(self.rhs_params) > 1 and self.rhs_params[1] != "spheroid": self.process_band_indices() [05010fe7]
- if isinstance(self.lhs, RasterBandTransform): self.band_lhs = self.lhs.band_index + 1 else: self.band_lhs = 1 [5fcea906]
- self.band_rhs, *self.rhs_params = self.rhs_params [830ab21c]
- template_params = { "lhs": lhs_sql, "rhs": rhs_sql, "value": "%s", **self.template_params, } rhs_op = self.get_rhs_op(connection, rhs_sql) return rhs_op.as_sql(connection, self, template_params, sql_params) [3d19bfe5]
- def __init__(self, lhs, rhs): rhs, *self.rhs_params = rhs if isinstance(rhs, (list, tuple)) else (rhs,) super().__init__(lhs, rhs) self.template_params = {} self.process_rhs_params() [5b39756c]
- def as_sql(self, compiler, connection): lhs_sql, lhs_params = self.process_lhs(compiler, connection) rhs_sql, rhs_params = self.process_rhs(compiler, connection) sql_params = (*lhs_params, *rhs_params) [ac1e633d]
- def get_db_prep_lookup(self, value, connection): # get_db_prep_lookup is called by process_rhs from super class return ("%s", (connection.ops.Adapter(value),)) [5e253c37]
- def get_rhs_op(self, connection, rhs): # Unlike BuiltinLookup, the GIS get_rhs_op() implementation should # return an object (SpatialOperator) with an as_sql() method to allow # for more complex computations (where the lhs part can be mixed in). return connection.ops.gis_operators[self.lookup_name] [0bc396ac]
- def process_band_indices(self, only_lhs=False): """ Extract the lhs band index from the band transform class and the rhs band index from the input tuple. """ # PostGIS band indices are 1-based, so the band index needs to be # increased to be consistent with the GDALRaster band indices. if only_lhs: self.band_rhs = 1 self.band_lhs = self.lhs.band_index + 1 return [b0dd8c2c]
- def process_distance(self, compiler, connection): dist_param = self.rhs_params[0] if ( not connection.features.supports_dwithin_distance_expr and hasattr(dist_param, "resolve_expression") and not isinstance(dist_param, Distance) ): raise NotSupportedError( "This backend does not support expressions for specifying " "distance in the dwithin lookup." ) return super().process_distance(compiler, connection) [c71f9e97]
- def process_distance(self, compiler, connection): dist_param = self.rhs_params[0] return ( compiler.compile(dist_param.resolve_expression(compiler.query)) if hasattr(dist_param, "resolve_expression") else ( "%s", connection.ops.get_distance( self.lhs.output_field, self.rhs_params, self.lookup_name ), ) ) [c8aecb9a]
- def process_rhs(self, compiler, connection): # Check the pattern argument pattern = self.rhs_params[0] backend_op = connection.ops.gis_operators[self.lookup_name] if hasattr(backend_op, "check_relate_argument"): backend_op.check_relate_argument(pattern) elif not isinstance(pattern, str) or not self.pattern_regex.match(pattern): raise ValueError('Invalid intersection matrix pattern "%s".' % pattern) sql, params = super().process_rhs(compiler, connection) return sql, (*params, pattern) [c819d59b]
- lookup_name = "bbcontains" [87ed294e]
- lookup_name = "bboverlaps" [3cb38591]

## All facts

- [3a9dac26] def process_rhs(self, compiler, connection): dist_sql, dist_params = self.process_distance(compiler, connection) self.template_params["value"] = dist_sql rhs_sql, params = super().process_rhs(compiler, connection) return rhs_sql, (*params, *dist_params)
- [5fb916d5] def process_rhs(self, compiler, connection): if isinstance(self.rhs, Query): # If rhs is some Query, don't touch it. return super().process_rhs(compiler, connection) if isinstance(self.rhs, Expression): rhs = self.rhs.resolve_expression(compiler.query) else: rhs = connection.ops.Adapter(self.rhs) return connection.ops.get_geom_placeholder_sql( self.lhs.output_field, rhs, compiler )
- [7729edaa] def process_rhs_params(self): if not 1 <= len(self.rhs_params) <= 3: raise ValueError( "2, 3, or 4-element tuple required for '%s' lookup." % self.lookup_name ) elif len(self.rhs_params) == 3 and self.rhs_params[2] != "spheroid": raise ValueError( "For 4-element tuples the last argument must be the 'spheroid' " "directive." )
- [405c6198] def process_rhs_params(self): if self.rhs_params: # Check if a band index was passed in the query argument. if len(self.rhs_params) == (2 if self.lookup_name == "relate" else 1): self.process_band_indices() elif len(self.rhs_params) > 1: raise ValueError("Tuple too long for lookup %s." % self.lookup_name) elif isinstance(self.lhs, RasterBandTransform): self.process_band_indices(only_lhs=True)
- [e983fc7e] lookup_name = "contained"
- [1fc9cade] lookup_name = "left"
- [547c5f52] lookup_name = "overlaps_above"
- [b6e339cd] lookup_name = "overlaps_below"
- [f0d5519f] lookup_name = "overlaps_left"
- [5c79a44a] lookup_name = "overlaps_right"
- [7c15eccf] lookup_name = "right"
- [d0b55b42] lookup_name = "same_as"
- [d1c235bf] lookup_name = "strictly_above"
- [ca5e48e7] lookup_name = "strictly_below"
- [68e01135] # ------------------ # Geometry functions # ------------------
- [cdda70f8] # ------------------ # Geometry operators # ------------------
- [88e1a045] @BaseSpatialField.register_lookup class BBContainsLookup(GISLookup): """ The 'bbcontains' operator returns true if A's bounding box completely contains by B's bounding box. """
- [dea5700f] @BaseSpatialField.register_lookup class BBOverlapsLookup(GISLookup): """ The 'bboverlaps' operator returns true if A's bounding box overlaps B's bounding box. """
- [70a1a6ce] @BaseSpatialField.register_lookup class ContainedLookup(GISLookup): """ The 'contained' operator returns true if A's bounding box is completely contained by B's bounding box. """
- [ce40240f] @BaseSpatialField.register_lookup class ContainsLookup(GISLookup): lookup_name = "contains"
- [17412aa0] @BaseSpatialField.register_lookup class ContainsProperlyLookup(GISLookup): lookup_name = "contains_properly"
- [ac533940] @BaseSpatialField.register_lookup class CoveredByLookup(GISLookup): lookup_name = "coveredby"
- [67e6208f] @BaseSpatialField.register_lookup class CoversLookup(GISLookup): lookup_name = "covers"
- [de8528eb] @BaseSpatialField.register_lookup class CrossesLookup(GISLookup): lookup_name = "crosses"
- [71734b35] @BaseSpatialField.register_lookup class DWithinLookup(DistanceLookupBase): lookup_name = "dwithin" sql_template = "%(func)s(%(lhs)s, %(rhs)s, %(value)s)"
- [e447c6f1] @BaseSpatialField.register_lookup class DisjointLookup(GISLookup): lookup_name = "disjoint"
- [0c011aa4] @BaseSpatialField.register_lookup class DistanceGTELookup(DistanceLookupFromFunction): lookup_name = "distance_gte" op = ">="
- [e59a64ca] @BaseSpatialField.register_lookup class DistanceGTLookup(DistanceLookupFromFunction): lookup_name = "distance_gt" op = ">"
- [9ef49cda] @BaseSpatialField.register_lookup class DistanceLTELookup(DistanceLookupFromFunction): lookup_name = "distance_lte" op = "<="
- [110dfb78] @BaseSpatialField.register_lookup class DistanceLTLookup(DistanceLookupFromFunction): lookup_name = "distance_lt" op = "<"
- [d967428e] @BaseSpatialField.register_lookup class EqualsLookup(GISLookup): lookup_name = "equals"
- [d8b9da24] @BaseSpatialField.register_lookup class IntersectsLookup(GISLookup): lookup_name = "intersects"
- [1ccdb930] @BaseSpatialField.register_lookup class LeftLookup(GISLookup): """ The 'left' operator returns true if A's bounding box is strictly to the left of B's bounding box. """
- [7df0b054] @BaseSpatialField.register_lookup class OverlapsAboveLookup(GISLookup): """ The 'overlaps_above' operator returns true if A's bounding box overlaps or is above B's bounding box. """
- [39c4f92a] @BaseSpatialField.register_lookup class OverlapsBelowLookup(GISLookup): """ The 'overlaps_below' operator returns true if A's bounding box overlaps or is below B's bounding box. """
- [20426639] @BaseSpatialField.register_lookup class OverlapsLeftLookup(GISLookup): """ The overlaps_left operator returns true if A's bounding box overlaps or is to the left of B's bounding box. """
- [15c0291b] @BaseSpatialField.register_lookup class OverlapsLookup(GISLookup): lookup_name = "overlaps"
- [62e3e47e] @BaseSpatialField.register_lookup class OverlapsRightLookup(GISLookup): """ The 'overlaps_right' operator returns true if A's bounding box overlaps or is to the right of B's bounding box. """
- [ac356bf4] @BaseSpatialField.register_lookup class RelateLookup(GISLookup): lookup_name = "relate" sql_template = "%(func)s(%(lhs)s, %(rhs)s, %%s)" pattern_regex = _lazy_re_compile(r"^[012TF*]{9}$")
- [25b898b2] @BaseSpatialField.register_lookup class RightLookup(GISLookup): """ The 'right' operator returns true if A's bounding box is strictly to the right of B's bounding box. """
- [faaf28b6] @BaseSpatialField.register_lookup class SameAsLookup(GISLookup): """ The "~=" operator is the "same as" operator. It tests actual geometric equality of two features. So if A and B are the same feature, vertex-by-vertex, the operator returns true. """
- [4966bcce] @BaseSpatialField.register_lookup class StrictlyAboveLookup(GISLookup): """ The 'strictly_above' operator returns true if A's bounding box is strictly above B's bounding box. """
- [e7ca278f] @BaseSpatialField.register_lookup class StrictlyBelowLookup(GISLookup): """ The 'strictly_below' operator returns true if A's bounding box is strictly below B's bounding box. """
- [87930f58] @BaseSpatialField.register_lookup class TouchesLookup(GISLookup): lookup_name = "touches"
- [6dcb0e93] @BaseSpatialField.register_lookup class WithinLookup(GISLookup): lookup_name = "within"
- [879a1a29] BaseSpatialField.register_lookup(SameAsLookup, "exact")
- [944e6054] class DistanceLookupBase(GISLookup): distance = True sql_template = "%(func)s(%(lhs)s, %(rhs)s) %(op)s %(value)s"
- [71fce8e3] class DistanceLookupFromFunction(DistanceLookupBase): def as_sql(self, compiler, connection): spheroid = ( len(self.rhs_params) == 2 and self.rhs_params[-1] == "spheroid" ) or None distance_expr = connection.ops.distance_expr_for_lookup( self.lhs, self.rhs, spheroid=spheroid ) sql, params = compiler.compile(distance_expr.resolve_expression(compiler.query)) dist_sql, dist_params = self.process_distance(compiler, connection) return ( "%(func)s %(op)s %(dist)s" % {"func": sql, "op": self.op, "dist": dist_sql}, (*params, *dist_params), )
- [270fe5d9] class GISLookup(Lookup): sql_template = None transform_func = None distance = False band_rhs = None band_lhs = None
- [e3428f68] class RasterBandTransform(Transform): def as_sql(self, compiler, connection): return compiler.compile(self.lhs)
- [2e30dbfa] from django.contrib.gis.db.models.fields import BaseSpatialField from django.contrib.gis.measure import Distance from django.db import NotSupportedError from django.db.models import Expression, Lookup, Transform from django.db.models.sql.query import Query from django.utils.regex_helper import _lazy_re_compile
