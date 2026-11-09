# django/contrib/gis/db/backends/postgis/base

- Subject: django/contrib/gis/db/backends/postgis/base (id `35c7a726-1e57-412a-9a0a-531b35c3fd7c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 895 tokens
- Facts shown: 23 of 31
- Conflicts: 0
- Gaps: 0

## Facts

- cls.GeometryDumper = type( "GeometryDumper", (base_dumper,), {"oid": geo_oid} ) cls.GeographyDumper = type( "GeographyDumper", (base_dumper,), {"oid": geog_oid} ) cls.RasterDumper = type( "RasterDumper", (BaseTextDumper,), {"oid": raster_oid} ) [81246af1]
- PostGISTextDumper, PostGISBinaryDumper = postgis_adapters( geo_oid, geog_oid, raster_oid ) pg_connection.adapters.register_dumper(PostGISAdapter, PostGISTextDumper) pg_connection.adapters.register_dumper(PostGISAdapter, PostGISBinaryDumper) [2dad9681]
- def dump(self, obj): raise NotImplementedError [219609db]
- def get_key(self, obj, format): if obj.is_geometry: return GeographyType if obj.geography else GeometryType else: return RasterType [d9e88a0b]
- def upgrade(self, obj, format): if obj.is_geometry: if obj.geography: return self.GeographyDumper(GeographyType) else: return self.GeometryDumper(GeometryType) else: return self.RasterDumper(RasterType) [67fef7bf]
- geo_oid = self._register_type(pg_connection, "geometry") geog_oid = self._register_type(pg_connection, "geography") raster_oid = self._register_type(pg_connection, "raster") [bcd9446f]
- if info: # Can be None if the type does not exist (yet). info.register(pg_connection) pg_connection.adapters.register_loader(info.oid, TextLoader) pg_connection.adapters.register_loader(info.oid, TextBinaryLoader) [dd04c238]
- return info.oid if info else None [62fdafe4]
- class PostGISBinaryDumper(BaseDumper, base_dumper=BaseBinaryDumper): format = Format.BINARY [665e6868]
- class PostGISTextDumper(BaseDumper, base_dumper=BaseTextDumper): pass [756415a2]
- def _register_type(self, pg_connection, typename): registry = self._type_infos[typename] try: info = registry[self.alias] except KeyError: info = TypeInfo.fetch(pg_connection, typename) registry[self.alias] = info [8f19a52c]
- def dump(self, obj): return obj.ewkb [60e389e4]
- def register_geometry_adapters(self, pg_connection, clear_caches=False): if clear_caches: for typename in self._type_infos: self._type_infos[typename].pop(self.alias, None) [d4aac203]
- return PostGISTextDumper, PostGISBinaryDumper [83181ff2]
- super().__init__(*args, **kwargs) [a84ca41e6642a566]
- @lru_cache def postgis_adapters(geo_oid, geog_oid, raster_oid): class BaseDumper(Dumper): def __init_subclass__(cls, base_dumper): super().__init_subclass__() [083d0846]
- _type_infos = { "geometry": {}, "geography": {}, "raster": {}, } [6970d69f]
- class BaseBinaryDumper(Dumper): format = Format.BINARY [4497adfb]
- class BaseTextDumper(Dumper): def dump(self, obj): # Return bytes as hex for text formatting return obj.ewkb.hex().encode() [833536e0]
- class GeographyType: pass [fe262592]
- class GeometryType: pass [fef03d1e]
- class RasterType: pass [cfe4ae33]
- def get_new_connection(self, conn_params): connection = super().get_new_connection(conn_params) if is_psycopg3: self.register_geometry_adapters(connection) return connection [ccb81859]

## Beyond the budget

8 more facts did not fit in the budget: [df2cea5e] [0bd290f0] [d71a6fba044908db] [5544fafd] [589aa68e] [0ef97426] [e2007df7] [2ef6c341]
