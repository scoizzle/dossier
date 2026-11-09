# django/contrib/gis/db/models/functions

- Subject: django/contrib/gis/db/models/functions (id `d4642801-5a7f-4e76-ade4-292f63722c0a`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 12 of 88
- Conflicts: 0
- Gaps: 0

## Facts

- # Ensure that expressions are geometric. source_fields = res.get_source_fields() for pos in self.geom_param_pos: field = source_fields[pos] if not isinstance(field, GeometryField): raise TypeError( "%s function requires a GeometryField in position %s, got %s." % ( self.name, pos + 1, type(field).__name__, ) ) [88c5c336]
- # Ensure that value expressions are geometric. for pos in self.geom_param_pos: expr = self.source_expressions[pos] if not isinstance(expr, Value): continue try: output_field = expr.output_field except FieldError: output_field = None geom = expr.value if ( not isinstance(geom, GEOSGeometry) or output_field and not isinstance(output_field, GeometryField) ): raise TypeError( "%s function requires a geometric argument in position %d." % (self.name, pos + 1) ) if not geom.srid and not output_field: raise ValueError("SRID is required for all geometries.") if not output_field: self.source_expressions[pos] = Value( geom, output_field=GeometryField(srid=geom.srid) ) [8e23f800]
- base_srid = res.geo_field.srid for pos in self.geom_param_pos[1:]: expr = res.source_expressions[pos] expr_srid = expr.output_field.srid if expr_srid != base_srid: # Automatic SRID conversion so objects are comparable. res.source_expressions[pos] = Transform( expr, base_srid ).resolve_expression(*args, **kwargs) return res [b8c78973]
- if not geography and self.geo_field.geodetic(connection): # Geometry fields with geodetic (lon/lat) coordinates need special # distance functions. if self.spheroid: # DistanceSpheroid is more accurate and resource intensive than # DistanceSphere. function = connection.ops.spatial_function_name("DistanceSpheroid") # Replace boolean param by the real spheroid of the base field clone.source_expressions.append( Value(self.geo_field.spheroid(connection)) ) else: function = connection.ops.spatial_function_name("DistanceSphere") return super(Distance, clone).as_sql( compiler, connection, function=function, **extra_context ) [dd32f3c9]
- @cached_property def geo_field(self): return self.source_expressions[self.geom_param_pos[0]].field [b52603bc]
- @cached_property def output_field(self): return AreaField(self.geo_field) [74e6fad4]
- @property def name(self): return self.__class__.__name__ [c394096c]
- def __init__(self, *expressions, **extra): super().__init__(*expressions, **extra) [8a46e1c8]
- def __init__(self, expr1, expr2, spheroid=None, **extra): expressions = [expr1, expr2] if spheroid is not None: self.spheroid = self._handle_param(spheroid, "spheroid", bool) super().__init__(*expressions, **extra) [f8b38092]
- def __init__(self, expression, bbox=False, crs=False, precision=8, **extra): expressions = [expression] if precision is not None: expressions.append(self._handle_param(precision, "precision", int)) options = 0 if crs and bbox: options = 3 elif bbox: options = 1 elif crs: options = 2 expressions.append(options) super().__init__(*expressions, **extra) [d01e5c6e]
- def __init__(self, expression, precision=8, **extra): expressions = [expression] if precision is not None: expressions.append(self._handle_param(precision, "precision", int)) super().__init__(*expressions, **extra) [dc3528e0]
- NUMERIC_TYPES = (int, float, Decimal) [14554d4b]

## Beyond the budget

72 more facts did not fit in the budget: [5f84c936] [d37b1b08] [b0b086ac] [4ab6e70b] [85efd08c] [601a1d1c] [f5e0a1de] [178694aa] [dc8e685e] [a23709fe] [857a8ebe] [ad05d1c9] [d7ad3688] [0385c023] [171a4296] [f59cdb65] [3f714f23] [1584e58d] [56f4ab28] [0e67fc17] [3c1b4a4d] [33f33294] [50d45b85] [7a4777ac] [e57f56d6] [51769e09] [406cae14] [4943b119] [7e8f340b] [87da1e18] [00cd8bc1] [cea51edf] [b9d01f4f] [2a4852e1] [c62f17ae] [f86c6023] [2942935f] [b98c9f43] [f0fa0000] [eb54f37e] [9043e440] [91ec0add] [ac914cd2] [9940ab49] [cd35e65a] [5e6a28d5] [f7742758] [38fbc21c] [171f540f] [04759f2d] [86d5f3c0] [58bbcb44] [57c95325] [fc931073] [8dc8625a] [aa856f34] [303a0ace] [9626d0b1] [cda91bc8] [f317906f] [5c226917] [24b843d0] [3734a309] [2c454a91] [1332375a] [73baa847] [0b5ae469] [61de362f] [a22a9eda] [c4d466c8] [2f76b6f177b243e2] [1ffdeddd]
