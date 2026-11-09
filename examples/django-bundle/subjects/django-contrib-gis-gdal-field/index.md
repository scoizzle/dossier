# django/contrib/gis/gdal/field

- Subject: django/contrib/gis/gdal/field (id `29db9fe4-f682-4fd5-b14a-f2eaadd63589`)
- Kind: subject
- Budget: 1200 tokens
- Used: 888 tokens
- Facts shown: 17 of 35
- Conflicts: 0
- Gaps: 0

## Facts

- # Getting the pointer for this field. fld_ptr = capi.get_feat_field_defn(feat.ptr, index) if not fld_ptr: raise GDALException("Cannot create OGR Field, invalid pointer given.") self.ptr = fld_ptr [11538f53]
- # Setting the class depending upon the OGR Field Type (OFT) self.__class__ = OGRFieldTypes[self.type] [c8c0ffb1]
- # #### Field Methods #### def as_double(self): "Retrieve the Field's value as a double (float)." return ( capi.get_field_as_double(self._feat.ptr, self._index) if self.is_set else None ) [1812280a]
- # #### Field Properties #### @property def is_set(self): "Return True if the value of this field isn't null, False otherwise." return capi.is_field_set(self._feat.ptr, self._index) [d7b28ddd]
- @property def name(self): "Return the name of this Field." name = capi.get_field_name(self.ptr) return force_str(name, encoding=self._feat.encoding, strings_only=True) [dbc185b3]
- @property def precision(self): "Return the precision of this Field." return capi.get_field_precision(self.ptr) [c14cae49]
- @property def type(self): """ GDAL uses OFTReals to represent OFTIntegers in created shapefiles -- forcing the type here since the underlying field type may actually be OFTReal. """ return 0 [f93eb794]
- @property def type(self): "Return the OGR type of this Field." return capi.get_field_type(self.ptr) [dde1b7d7]
- @property def type_name(self): "Return the OGR field type name for this Field." return capi.get_field_type_name(self.type) [b235f784]
- @property def value(self): "Return an integer contained in this field." return self.as_int(self._bit64) [e6730620]
- @property def value(self): "Return the value of this Field." # Default is to get the field as a string. return self.as_string() [ffad6ee5]
- @property def width(self): "Return the width of this Field." return capi.get_field_width(self.ptr) [b7f0ecee]
- def __init__(self, feat, index): """ Initialize on the feature object and the integer index of the field within the feature. """ # Setting the feature pointer and index. self._feat = feat self._index = index [cc696f5c]
- def __str__(self): "Return the string representation of the Field." return str(self.value).strip() [579baf27]
- def as_datetime(self): "Retrieve the Field's value as a tuple of date & time components." if not self.is_set: return None yy, mm, dd, hh, mn, ss, tz = [c_int() for i in range(7)] status = capi.get_field_as_datetime( self._feat.ptr, self._index, byref(yy), byref(mm), byref(dd), byref(hh), byref(mn), byref(ss), byref(tz), ) if status: return (yy, mm, dd, hh, mn, ss, tz) else: raise GDALException( "Unable to retrieve date & time information from the field." ) [c7bf0ee2]
- def as_int(self, is_64=False): "Retrieve the Field's value as an integer." if is_64: return ( capi.get_field_as_integer64(self._feat.ptr, self._index) if self.is_set else None ) else: return ( capi.get_field_as_integer(self._feat.ptr, self._index) if self.is_set else None ) [dd35e93d]
- # ### The Field sub-classes for each OGR Field type. ### class OFTInteger(Field): _bit64 = False [b740dece]

## Beyond the budget

18 more facts did not fit in the budget: [cbed2860] [3956868a] [a76205fe] [8327c22e] [3155e974] [8af91739] [946a5c99] [79011eed] [af42ab22] [cc3415ac] [f90447a2] [54aba65f] [a7a0af4e] [e7e9f1d1] [1df1d556] [fa410f59] [659f8d78] [765143df]
