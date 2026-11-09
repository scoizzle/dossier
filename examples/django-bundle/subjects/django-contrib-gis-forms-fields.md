# django/contrib/gis/forms/fields

- Subject: django/contrib/gis/forms/fields (id `a4c8dd96-34c6-42e7-a16b-265a9b2963ed`)
- Kind: subject
- Budget: 1200 tokens
- Used: 892 tokens
- Facts shown: 14 of 24
- Conflicts: 0
- Gaps: 0

## Facts

- # Ensuring that the geometry is of the correct type (indicated # using the OGC string label). if ( str(geom.geom_type).upper() != self.geom_type and self.geom_type != "GEOMETRY" ): raise ValidationError( self.error_messages["invalid_geom_type"], code="invalid_geom_type" ) [99d4ed63]
- # Only do a geographic comparison if both values are available if initial and data: data.transform(initial.srid) # If the initial value was not added by the browser, the geometry # provided may be slightly different, the first time it is saved. # The comparison is done with a very low tolerance. return not initial.equals_exact(data, tolerance=0.000001) else: # Check for change of state of existence return bool(initial) != bool(data) [a4f31ee2]
- # Transforming the geometry if the SRID was set. if self.srid and self.srid != -1 and self.srid != geom.srid: try: geom.transform(self.srid) except GEOSException: raise ValidationError( self.error_messages["transform_error"], code="transform_error" ) [b045f474]
- # Try to set the srid if not value.srid: try: value.srid = self.widget.map_srid except AttributeError: if self.srid: value.srid = self.srid return value [1f1bdf7d]
- if not isinstance(value, GEOSGeometry): if hasattr(self.widget, "deserialize"): value = self.widget.deserialize(value) else: try: value = GEOSGeometry( value, max_geom_collections=self.max_geom_collections ) except (GEOSException, ValueError, TypeError): value = None if value is None: raise ValidationError( self.error_messages["invalid_geom"], code="invalid_geom" ) [426df3b7]
- return geom [446538f7]
- try: data = self.to_python(data) initial = self.to_python(initial) except ValidationError: return True [16880665]
- The widget's deserialize() method will raise SuspiciousOperation if it detects a URL-based coordinate reference system (CRS) in a GeoJSON value. """ [98eb7b4b]
- def __init__( self, *, srid=None, geom_type=None, max_geom_collections=None, **kwargs ): self.srid = srid if geom_type is not None: self.geom_type = geom_type if max_geom_collections is not None: self.max_geom_collections = max_geom_collections super().__init__(**kwargs) self.widget.attrs["geom_type"] = self.geom_type # Propagate the limit to the (per-field) widget instance, which does # the actual parsing. Custom widgets that override deserialize() and # ignore this attribute still get the default limit via GEOSGeometry. self.widget.max_geom_collections = self.max_geom_collections [59081d79]
- def clean(self, value): """ Validate that the input value can be converted to a Geometry object and return it. Raise a ValidationError if the value cannot be instantiated as a Geometry. """ geom = super().clean(value) if geom is None: return geom [fbb32884]
- def has_changed(self, initial, data): """Compare geographic value of data with its initial value.""" [6a1221c3]
- def to_python(self, value): """Transform the value to a Geometry object.""" if value in self.empty_values: return None [8200e399]
- widget = OpenLayersWidget geom_type = "GEOMETRY" max_geom_collections = MAX_GEOM_COLLECTIONS [845cfe38]
- class GeometryCollectionField(GeometryField): geom_type = "GEOMETRYCOLLECTION" [a9ff1542]

## Beyond the budget

10 more facts did not fit in the budget: [d795c3d5] [9b905f3b] [2f3bc0d9] [dcf83446] [d3210c32] [310b509e] [385b20b1] [2c2273b5] [193bc16b] [985e762d]
