# django/contrib/gis/gdal/srs

- Subject: django/contrib/gis/gdal/srs (id `83578a3c-018b-49b3-9d5e-05718ddde9c4`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 13 of 51
- Conflicts: 0
- Gaps: 0

## Facts

- # If the pointer is NULL, throw an exception. if not srs: raise SRSException( "Could not create spatial reference from: %s" % srs_input ) else: self.ptr = srs [9995bdc9]
- >>> wkt = ( ... 'GEOGCS["WGS 84",' ... ' DATUM["WGS_1984, ... AUTHORITY["EPSG","4326"]' ... ']' ... ) >>> srs = SpatialReference(wkt) # could also use 'WGS84', or 4326 >>> print(srs['GEOGCS']) WGS 84 >>> print(srs['DATUM']) WGS_1984 >>> print(srs['AUTHORITY']) EPSG >>> print(srs['AUTHORITY', 1]) # The authority value 4326 >>> print(srs['TOWGS84', 4]) # the fourth value in this wkt 0 >>> # For the units authority, have to use the pipe symbol. >>> print(srs['UNIT|AUTHORITY']) EPSG >>> print(srs['UNIT|AUTHORITY', 1]) # The authority value for the units 9122 """ if isinstance(target, tuple): return self.attr_value(*target) else: return self.attr_value(target) [edd3c7f8]
- if self.axis_order == AxisOrder.TRADITIONAL: capi.set_axis_strategy(self.ptr, self.axis_order) # Importing from either the user input string or an integer SRID. if srs_type == "user": self.import_user_input(srs_input) elif srs_type == "epsg": self.import_epsg(srs_input) [9c32e54e]
- if srs_type == "ogr": # Input is already an SRS pointer. srs = srs_input else: # Creating a new SRS pointer, using the string buffer. buf = c_char_p(b"") srs = capi.new_srs(buf) [3debf325]
- # #### Boolean Properties #### @property def geographic(self): """ Return True if this SpatialReference is geographic (root node is GEOGCS). """ return bool(capi.isgeographic(self.ptr)) [26548a2c]
- # #### Export Properties #### @property def wkt(self): "Return the WKT representation of this Spatial Reference." return capi.to_wkt(self.ptr, byref(c_char_p())) [ab62fa94]
- # #### Import Routines ##### def import_epsg(self, epsg): "Import the Spatial Reference from the EPSG code (an integer)." capi.from_epsg(self.ptr, epsg) [86f8016d]
- # #### Name & SRID properties #### @property def name(self): "Return the name of this Spatial Reference." if self.projected: return self.attr_value("PROJCS") elif self.geographic: return self.attr_value("GEOGCS") elif self.local: return self.attr_value("LOCAL_CS") else: return None [a6d8a50f]
- # #### SpatialReference Methods #### def attr_value(self, target, index=0): """ The attribute value for the given target node (e.g. 'PROJCS'). The index keyword specifies an index of the child node to return. """ if not isinstance(target, str) or not isinstance(index, int): raise TypeError return capi.get_attr_value(self.ptr, force_bytes(target), index) [dfc6a462]
- # #### Spheroid/Ellipsoid Properties #### @property def ellipsoid(self): """ Return a tuple of the ellipsoid parameters: (semimajor axis, semiminor axis, and inverse flattening) """ return (self.semi_major, self.semi_minor, self.inverse_flattening) [cf3cb4bb]
- # #### Unit Properties #### @property def linear_name(self): "Return the name of the linear units." units, name = capi.linear_units(self.ptr, byref(c_char_p())) return name [1b837c83]
- @property def angular_name(self): "Return the name of the angular units." units, name = capi.angular_units(self.ptr, byref(c_char_p())) return name [f3f7567c]
- @property def proj4(self): "Alias for proj()." return self.proj [e4a8b777]

## Beyond the budget

35 more facts did not fit in the budget: [f43cef22] [bc0d704f] [281560e5] [9deec1ea] [d9886656] [96c870ea] [ce28284e] [2cd9f0c5] [4d3c79f0] [89d9b525] [9931719c] [76b16d75] [8d152680] [c82e7d37] [878174ca] [b7a576f8] [e96c2a36] [742de969] [ad831770] [f4527290] [6edf4864] [85a848e9] [33166ec1] [70a3aae3] [5069928a] [ee1280e9] [97b01d7d] [be16353e] [9bb98cee] [a0102e91] [18e394ff] [cf94c12e] [0a3e74e6] [3a583182] [481ebc6b]
