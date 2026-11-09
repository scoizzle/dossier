# django/contrib/gis/geos/collections

- Subject: django/contrib/gis/geos/collections (id `395fd1b7-6cf1-42e6-befd-b0a51fad7c3b`)
- Kind: subject
- Budget: 1200 tokens
- Used: 877 tokens
- Facts shown: 17 of 20
- Conflicts: 0
- Gaps: 0

## Facts

- # Creating the geometry pointer array. collection = self._create_collection(len(init_geoms), init_geoms) super().__init__(collection, **kwargs) [542a2e19]
- # Ensuring that only the permitted geometries are allowed in this # collection this is moved to list mixin super class self._check_allowed(init_geoms) [8fe5e4be]
- # ### Methods for compatibility with ListMixin ### def _create_collection(self, length, items): # Creating the geometry pointer array. geoms = (GEOM_PTR * length)( *[ # this is a little sloppy, but makes life easier # allow GEOSGeometry types (python wrappers) or pointer types capi.geom_clone(getattr(g, "ptr", g)) for g in items ] ) return capi.create_collection(self._typeid, geoms, length) [b4846658]
- @property def kml(self): "Return the KML for this Geometry Collection." return "<MultiGeometry>%s</MultiGeometry>" % "".join(g.kml for g in self) [cf1e2f81]
- @property def tuple(self): "Return a tuple of all the coordinates in this Geometry Collection" return tuple(g.tuple for g in self) [fe279560]
- _set_single = GEOSGeometry._set_single_rebuild _assign_extended_slice = GEOSGeometry._assign_extended_slice_rebuild [9271859696c6c292]
- coords = tuple [7cf2067ea4ba94b9-5]
- def __init__(self, *args, **kwargs): "Initialize a Geometry Collection from a sequence of Geometry objects." # Checking the arguments if len(args) == 1: # If only one geometry provided or a list of geometries is provided # in the first argument. if isinstance(args[0], (tuple, list)): init_geoms = args[0] else: init_geoms = args else: init_geoms = args [169c1f3e]
- def __iter__(self): "Iterate over each Geometry in the Collection." for i in range(len(self)): yield self[i] [1d7fee70]
- def __len__(self): "Return the number of geometries in this Collection." return self.num_geom [9617a466]
- def _get_single_external(self, index): """ Return the Geometry from this Collection at the given index (0-based). """ # Checking the index and returning the corresponding GEOS geometry. return GEOSGeometry( capi.geom_clone(self._get_single_internal(index)), srid=self.srid ) [93696832]
- def _get_single_internal(self, index): return capi.get_geomn(self.ptr, index) [14ca59f9]
- def _set_list(self, length, items): """ Create a new collection, and destroy the contents of the previous pointer. """ prev_ptr = self.ptr srid = self.srid self.ptr = self._create_collection(length, items) if srid: self.srid = srid capi.destroy_geom(prev_ptr) [a9e6d442]
- """ This module houses the Geometry Collection objects: GeometryCollection, MultiPoint, MultiLineString, and MultiPolygon """ [73bf34b4]
- # MultiPoint, MultiLineString, and MultiPolygon class definitions. class MultiPoint(GeometryCollection): _allowed = Point _typeid = 4 [495393ee]
- # Setting the allowed types here since GeometryCollection is defined before # its subclasses. GeometryCollection._allowed = ( Point, LineString, LinearRing, Polygon, MultiPoint, MultiLineString, MultiPolygon, ) [a5c6b234]
- class GeometryCollection(GEOSGeometry): _typeid = 7 [e28000ec]

## Beyond the budget

3 more facts did not fit in the budget: [3c489c50] [3d284c7c] [1deed241]
