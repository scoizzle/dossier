# django/contrib/gis/db/models/proxy

- Subject: django/contrib/gis/db/models/proxy (id `5463f7bf-2e8d-4ad8-9044-bf6cb000287b`)
- Kind: subject
- Budget: 1200 tokens
- Used: 789 tokens
- Facts shown: 11 of 11
- Conflicts: 0
- Gaps: 0

## Facts

- # Getting the value of the field. try: geo_value = instance.__dict__[self.field.attname] except KeyError: geo_value = super().__get__(instance, cls) [41941246]
- # Setting the object's dictionary with the value, and returning. instance.__dict__[self.field.attname] = value return value [ed955dba]
- To set geometries, use values of None, HEXEWKB, or WKT. To set rasters, use JSON or dict values. """ # The geographic type of the field. gtype = self.field.geom_type [26905c1c]
- if gtype == "RASTER" and ( value is None or isinstance(value, (str, dict, self._klass)) ): # For raster fields, ensure input is None or a string, dict, or # raster instance. pass elif isinstance(value, self._klass): # The geometry type must match that of the field -- unless the # general GeometryField is used. if value.srid is None: # Assigning the field SRID if the geometry has no SRID. value.srid = self.field.srid elif value is None or isinstance(value, (str, memoryview)): # Set geometries with None, WKT, HEX, or WKB pass else: raise TypeError( "Cannot set %s SpatialProxy (%s) with value of type: %s" % (instance.__class__.__name__, gtype, type(value)) ) [5f3cb0bc]
- if isinstance(geo_value, self._klass): geo_obj = geo_value elif (geo_value is None) or (geo_value == ""): geo_obj = None else: # Otherwise, a geometry or raster object is built using the field's # contents, and the model's corresponding attribute is set. try: max_geoms = self.field.max_geom_collections except AttributeError: geo_obj = self._load_func(geo_value) else: geo_obj = self._load_func(geo_value, max_geom_collections=max_geoms) setattr(instance, self.field.attname, geo_obj) return geo_obj [70ba4e63]
- def __get__(self, instance, cls=None): """ Retrieve the geometry or raster, initializing it using the corresponding class specified during initialization and the value of the field. Currently, GEOS or OGR geometries as well as GDALRasters are supported. """ if instance is None: # Accessed on a class, not an instance return self [af459e95]
- def __set__(self, instance, value): """ Retrieve the proxied geometry or raster with the corresponding class specified during initialization. [61911db6]
- """ The SpatialProxy object allows for lazy-geometries and lazy-rasters. The proxy uses Python descriptors for instantiating and setting Geometry or Raster objects corresponding to geographic model fields. [b6558859]
- Thanks to Robert Coup for providing this functionality (see #4322). """ [1cc8ec50]
- class SpatialProxy(DeferredAttribute): def __init__(self, klass, field, load_func=None): """ Initialize on the given Geometry or Raster class (not an instance) and the corresponding field. """ self._klass = klass self._load_func = load_func or klass super().__init__(field) [74950126]
- from django.db.models.query_utils import DeferredAttribute [c3714341]
