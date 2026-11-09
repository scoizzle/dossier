# django/contrib/gis/forms/widgets

- Subject: django/contrib/gis/forms/widgets (id `8bc0f449-25d3-40ff-87f4-7916da026bbe`)
- Kind: subject
- Budget: 1200 tokens
- Used: 882 tokens
- Facts shown: 17 of 18
- Conflicts: 0
- Gaps: 0

## Facts

- if value: # Check that srid of value and map match if value.srid and value.srid != self.map_srid: try: ogr = value.ogr ogr.transform(self.map_srid) value = ogr except gdal.GDALException as err: logger.error( "Error transforming geometry from srid '%s' to srid '%s' (%s)", value.srid, self.map_srid, err, ) context["serialized"] = self.serialize(value) geom_type = gdal.OGRGeomType(self.attrs["geom_type"]).name context["widget"]["attrs"]["geom_name"] = ( "Geometry" if geom_type == "Unknown" else geom_type ) return context [eacbb20a]
- base_layer = "osm" default_lon = 5 default_lat = 47 default_zoom = 12 [2993c3bc]
- base_layer = None geom_type = "GEOMETRY" map_srid = 4326 display_raw = False max_geom_collections = MAX_GEOM_COLLECTIONS [d4ea6c0b]
- class Media: css = { "all": ( "https://cdn.jsdelivr.net/npm/ol@v10.9.0/ol.css", "gis/css/ol3.css", ) } js = ( "https://cdn.jsdelivr.net/npm/ol@v10.9.0/dist/ol.js", "gis/js/OLMapWidget.js", ) [3d2660cb]
- def __init__(self, attrs=None): if attrs is None: attrs = {} attrs.setdefault("default_lon", self.default_lon) attrs.setdefault("default_lat", self.default_lat) attrs.setdefault("default_zoom", self.default_zoom) super().__init__(attrs=attrs) [577dd8af]
- def __init__(self, attrs=None): self.attrs = { key: getattr(self, key) for key in ("base_layer", "geom_type", "map_srid", "display_raw") } if attrs: self.attrs.update(attrs) [72451e07]
- def deserialize(self, value): geom = super().deserialize(value) # GeoJSON assumes WGS84 (4326). Use the map's SRID instead. if geom and json_regex.match(value) and self.map_srid != 4326: geom.srid = self.map_srid return geom [426acc48]
- def deserialize(self, value): try: return GEOSGeometry(value, max_geom_collections=self.max_geom_collections) except (GEOSException, GDALException, ValueError, TypeError) as err: # Trim large values, keeping the suffix out of the escaped args. trimmed, suffix = trim_value(value) log_message( logger, "Error creating geometry from value '%s" + suffix + "' (%s)", trimmed, err, level="error", ) return None [fee48d0c]
- def get_context(self, name, value, attrs): context = super().get_context(name, value, attrs) # If a string reaches here (via a validation error on another # field) then just reconstruct the Geometry. if value and isinstance(value, str): value = self.deserialize(value) [56a6a14a]
- def serialize(self, value): return value.json if value else "" [9ace0205]
- def serialize(self, value): return value.wkt if value else "" [582e6f72]
- supports_3d = False template_name = "" # set on subclasses [0afdb45a]
- class BaseGeometryWidget(Widget): """ The base class for rich geometry widgets. Render a map using the WKT of the geometry. """ [36d256c3]
- class OSMWidget(OpenLayersWidget): """ An OpenLayers/OpenStreetMap-based widget. """ [5548df0a]
- class OpenLayersWidget(BaseGeometryWidget): base_layer = "nasaWorldview" template_name = "gis/openlayers.html" map_srid = 3857 [d41b5482]
- import logging [47bc951ed6a0e3cc-2]
- logger = logging.getLogger("django.contrib.gis") [e92fc94cc00bbb3c-2]

## Beyond the budget

1 more facts did not fit in the budget: [34e78501]
