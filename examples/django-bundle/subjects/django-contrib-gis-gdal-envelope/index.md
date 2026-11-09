# django/contrib/gis/gdal/envelope

- Subject: django/contrib/gis/gdal/envelope (id `8a6cebbe-fe5f-46c5-9206-9861f97d8f3b`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1579 tokens
- Facts shown: 22 of 22
- Conflicts: 0
- Gaps: 0

## Highlights

- +----------o Upper right; (max_x, max_y) | | | | | | Lower left (min_x, min_y) o----------+ """ [f9413125]
- # Checking the x,y coordinates if self.min_x > self.max_x: raise GDALException("Envelope minimum X > maximum X.") if self.min_y > self.max_y: raise GDALException("Envelope minimum Y > maximum Y.") [619f155c]
- if len(args) == 1: if isinstance(args[0], OGREnvelope): # OGREnvelope (a ctypes Structure) was passed in. self._envelope = args[0] elif isinstance(args[0], (tuple, list)): # A tuple was passed in. if len(args[0]) != 4: raise GDALException( "Incorrect number of tuple elements (%d)." % len(args[0]) ) else: self._from_sequence(args[0]) else: raise TypeError("Incorrect type of argument: %s" % type(args[0])) elif len(args) == 4: # Individual parameters passed in. # Thanks to ww for the help self._from_sequence([float(a) for a in args]) else: raise GDALException("Incorrect number (%d) of arguments." % len(args)) [ec3e5508]
- @property def ll(self): "Return the lower-left coordinate." return (self.min_x, self.min_y) [02fb8032]
- @property def max_x(self): "Return the value of the maximum X coordinate." return self._envelope.MaxX [c3cd340f]
- @property def max_y(self): "Return the value of the maximum Y coordinate." return self._envelope.MaxY [388b9601]
- @property def min_x(self): "Return the value of the minimum X coordinate." return self._envelope.MinX [75edc283]
- @property def min_y(self): "Return the value of the minimum Y coordinate." return self._envelope.MinY [15b2059b]
- @property def tuple(self): "Return a tuple representing the envelope." return (self.min_x, self.min_y, self.max_x, self.max_y) [0c686555]
- @property def ur(self): "Return the upper-right coordinate." return (self.max_x, self.max_y) [32d3b976]
- @property def wkt(self): "Return WKT representing a Polygon for this envelope." # TODO: Fix significant figures. return "POLYGON((%s %s,%s %s,%s %s,%s %s,%s %s))" % ( self.min_x, self.min_y, self.min_x, self.max_y, self.max_x, self.max_y, self.max_x, self.min_y, self.min_x, self.min_y, ) [eb4ab6c6]
- _fields_ = [ ("MinX", c_double), ("MaxX", c_double), ("MinY", c_double), ("MaxY", c_double), ] [0c6d6a3e]
- def __eq__(self, other): """ Return True if the envelopes are equivalent; can compare against other Envelopes and 4-tuples. """ if isinstance(other, Envelope): return ( (self.min_x == other.min_x) and (self.min_y == other.min_y) and (self.max_x == other.max_x) and (self.max_y == other.max_y) ) elif isinstance(other, tuple) and len(other) == 4: return ( (self.min_x == other[0]) and (self.min_y == other[1]) and (self.max_x == other[2]) and (self.max_y == other[3]) ) else: raise GDALException("Equivalence testing only works with other Envelopes.") [fc3e2dcf]
- def __init__(self, *args): """ The initialization function may take an OGREnvelope structure, 4-element tuple or list, or 4 individual arguments. """ [1fa259b6]
- def __str__(self): "Return a string representation of the tuple." return str(self.tuple) [9c869d14]
- from ctypes import Structure, c_double [8267a3aa]

## All facts

- [744e5247] def _from_sequence(self, seq): "Initialize the C OGR Envelope structure from the given sequence." self._envelope = OGREnvelope() self._envelope.MinX = seq[0] self._envelope.MinY = seq[1] self._envelope.MaxX = seq[2] self._envelope.MaxY = seq[3]
- [135706a2] def expand_to_include(self, *args): """ Modify the envelope to expand to include the boundaries of the passed-in 2-tuple (a point), 4-tuple (an extent) or envelope. """ # We provide a number of different signatures for this method, # and the logic here is all about converting them into a # 4-tuple single parameter which does the actual work of # expanding the envelope. if len(args) == 1: if isinstance(args[0], Envelope): return self.expand_to_include(args[0].tuple) elif hasattr(args[0], "x") and hasattr(args[0], "y"): return self.expand_to_include( args[0].x, args[0].y, args[0].x, args[0].y ) elif isinstance(args[0], (tuple, list)): # A tuple was passed in. if len(args[0]) == 2: return self.expand_to_include( (args[0][0], args[0][1], args[0][0], args[0][1]) ) elif len(args[0]) == 4: minx, miny, maxx, maxy = args[0] if minx < self._envelope.MinX: self._envelope.MinX = minx if miny < self._envelope.MinY: self._envelope.MinY = miny if maxx > self._envelope.MaxX: self._envelope.MaxX = maxx if maxy > self._envelope.MaxY: self._envelope.MaxY = maxy else: raise GDALException( "Incorrect number of tuple elements (%d)." % len(args[0]) ) else: raise TypeError("Incorrect type of argument: %s" % type(args[0])) elif len(args) == 2: # An x and an y parameter were passed in return self.expand_to_include((args[0], args[1], args[0], args[1])) elif len(args) == 4: # Individual parameters passed in. return self.expand_to_include(args) else: raise GDALException("Incorrect number (%d) of arguments." % len(args[0]))
- [3df54a55] """ The GDAL/OGR library uses an Envelope structure to hold the bounding box information for a geometry. The envelope (bounding box) contains two pairs of coordinates, one for the lower left coordinate and one for the upper right coordinate:
- [30cdd2d2] # The OGR definition of an Envelope is a C structure containing four doubles. # See the 'ogr_core.h' source file for more information: # https://gdal.org/doxygen/ogr__core_8h_source.html class OGREnvelope(Structure): "Represent the OGREnvelope C Structure."
- [1fcbd160] class Envelope: """ The Envelope object is a C structure that contains the minimum and maximum X, Y coordinates for a rectangle bounding box. The naming of the variables is compatible with the OGR Envelope structure. """
- [05db624975f27ad7] from django.contrib.gis.gdal.error import GDALException
