# django/contrib/gis/gdal/envelope

- Subject: django/contrib/gis/gdal/envelope (id `615f0e86-3680-41f8-985c-1483e966faa5`)
- Kind: subject
- Budget: 1200 tokens
- Used: 879 tokens
- Facts shown: 16 of 22
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

6 more facts did not fit in the budget: [744e5247] [135706a2] [3df54a55] [30cdd2d2] [1fcbd160] [05db624975f27ad7]
