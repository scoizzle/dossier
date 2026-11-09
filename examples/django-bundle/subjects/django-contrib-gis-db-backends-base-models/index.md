# django/contrib/gis/db/backends/base/models

- Subject: django/contrib/gis/db/backends/base/models (id `df4d67f9-88b6-4404-ac3b-b6f0c311404c`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 942 tokens
- Facts shown: 21 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- if not string: return sphere_name, sphere_params else: # `string` parameter used to place in format acceptable by PostGIS if len(sphere_params) == 3: radius, flattening = sphere_params[0], sphere_params[2] else: radius, flattening = sphere_params return 'SPHEROID["%s",%s,%s]' % (sphere_name, radius, flattening) [215ed0e0]
- raise Exception( "Could not get OSR SpatialReference.\n" f"Error for WKT '{self.wkt}': {wkt_error}\n" f"Error for PROJ.4 '{self.proj4text}': {proj4_error}" ) [a5b3f0cc]
- try: return gdal.SpatialReference(self.proj4text) except Exception as e: proj4_error = e [2fb6d117]
- @cached_property def srs(self): """ Return a GDAL SpatialReference object. """ try: return gdal.SpatialReference(self.wkt) except Exception as e: wkt_error = e [33610096]
- @classmethod def get_spheroid(cls, wkt, string=True): """ Class method used by GeometryField on initialization to retrieve the `SPHEROID[..]` parameters from the given WKT. """ srs = gdal.SpatialReference(wkt) sphere_params = srs.ellipsoid sphere_name = srs["spheroid"] [28195e30]
- @classmethod def get_units(cls, wkt): """ Return a tuple of (unit_value, unit_name) for the given WKT without using any of the database fields. """ return gdal.SpatialReference(wkt).units [20f0d079]
- @property def angular_name(self): "Return the name of the angular units." return self.srs.angular_name [584a5b7f]
- @property def angular_units(self): "Return the angular units." return self.srs.angular_units [059c2b30]
- @property def datum(self): "Return the datum for this spatial reference." return self.srs["datum"] [e106fe35]
- @property def ellipsoid(self): """ Return a tuple of the ellipsoid parameters: (semimajor axis, semiminor axis, and inverse flattening). """ return self.srs.ellipsoid [d60379e5]
- @property def geographic(self): "Is this Spatial Reference geographic?" return self.srs.geographic [c3fd783e]
- @property def linear_name(self): "Return the linear units name." return self.srs.linear_name [376c493e]
- @property def linear_units(self): "Return the linear units." return self.srs.linear_units [27711506]
- @property def local(self): "Is this Spatial Reference local?" return self.srs.local [6d2ab5d6]
- @property def name(self): "Return the projection name." return self.srs.name [a4fd1cf7]
- @property def projected(self): "Is this Spatial Reference projected?" return self.srs.projected [9b1873da]
- @property def spheroid(self): "Return the spheroid name for this spatial reference." return self.srs["spheroid"] [3cd9a84c]
- @property def units(self): "Return a tuple of the units and the name." if self.projected or self.local: return (self.linear_units, self.linear_name) elif self.geographic: return (self.angular_units, self.angular_name) else: return (None, None) [7c889fea]
- def __str__(self): """ Return the string representation, a 'pretty' OGC WKT. """ return str(self.srs) [3c1e3087]
- from django.contrib.gis import gdal from django.utils.functional import cached_property [91ab5492]

## All facts

- [24595224] class SpatialRefSysMixin: """ The SpatialRefSysMixin is a class used by the database-dependent SpatialRefSys objects to reduce redundant code. """
