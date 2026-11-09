# django/contrib/gis/db/models/lookups

- Subject: django/contrib/gis/db/models/lookups (id `a0428d58-6e19-4627-8228-3ba2aa682c19`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 14 of 65
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

51 more facts did not fit in the budget: [3a9dac26] [5fb916d5] [7729edaa] [405c6198] [e983fc7e] [1fc9cade] [547c5f52] [b6e339cd] [f0d5519f] [5c79a44a] [7c15eccf] [d0b55b42] [d1c235bf] [ca5e48e7] [68e01135] [cdda70f8] [88e1a045] [dea5700f] [70a1a6ce] [ce40240f] [17412aa0] [ac533940] [67e6208f] [de8528eb] [71734b35] [e447c6f1] [0c011aa4] [e59a64ca] [9ef49cda] [110dfb78] [d967428e] [d8b9da24] [1ccdb930] [7df0b054] [39c4f92a] [20426639] [15c0291b] [62e3e47e] [ac356bf4] [25b898b2] [faaf28b6] [4966bcce] [e7ca278f] [87930f58] [6dcb0e93] [879a1a29] [944e6054] [71fce8e3] [270fe5d9] [e3428f68] [2e30dbfa]
