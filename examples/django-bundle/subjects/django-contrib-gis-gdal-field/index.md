# django/contrib/gis/gdal/field

- Subject: django/contrib/gis/gdal/field (id `1d5873d7-153a-491b-8bd1-2df09fca26a1`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1757 tokens
- Facts shown: 35 facts
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [cbed2860] def as_string(self): "Retrieve the Field's value as a string." if not self.is_set: return None string = capi.get_field_as_string(self._feat.ptr, self._index) return force_str(string, encoding=self._feat.encoding, strings_only=True)
- [3956868a] # Class mapping dictionary for OFT Types and reverse mapping. OGRFieldTypes = { 0: OFTInteger, 1: OFTIntegerList, 2: OFTReal, 3: OFTRealList, 4: OFTString, 5: OFTStringList, 6: OFTWideString, 7: OFTWideStringList, 8: OFTBinary, 9: OFTDate, 10: OFTTime, 11: OFTDateTime, 12: OFTInteger64, 13: OFTInteger64List, } ROGRFieldTypes = {cls: num for num, cls in OGRFieldTypes.items()}
- [a76205fe] # For more information, see the OGR C API source code: # https://gdal.org/api/vector_c_api.html # # The OGR_Fld_* routines are relevant here. class Field(GDALBase): """ Wrap an OGR Field. Needs to be instantiated from a Feature object. """
- [8327c22e] # List fields are also just subclasses class OFTIntegerList(Field): pass
- [3155e974] # OFTDate, OFTTime, OFTDateTime fields. class OFTDate(Field): @property def value(self): "Return a Python `date` object for the OFTDate field." try: yy, mm, dd, hh, mn, ss, tz = self.as_datetime() return date(yy.value, mm.value, dd.value) except (TypeError, ValueError, GDALException): return None
- [8af91739] # String & Binary fields, just subclasses class OFTString(Field): pass
- [946a5c99] class OFTBinary(Field): pass
- [79011eed] class OFTDateTime(Field): @property def value(self): "Return a Python `datetime` object for this OFTDateTime field." # TODO: Adapt timezone information. See: # https://lists.osgeo.org/pipermail/gdal-dev/2006-February/007990.html # The `tz` variable has values of: 0=unknown, 1=localtime (ambiguous), # 100=GMT, 104=GMT+1, 80=GMT-5, etc. try: yy, mm, dd, hh, mn, ss, tz = self.as_datetime() return datetime(yy.value, mm.value, dd.value, hh.value, mn.value, ss.value) except (TypeError, ValueError, GDALException): return None
- [af42ab22] class OFTInteger64(OFTInteger): _bit64 = True
- [cc3415ac] class OFTInteger64List(Field): pass
- [f90447a2] class OFTReal(Field): @property def value(self): "Return a float contained in this field." return self.as_double()
- [54aba65f] class OFTRealList(Field): pass
- [a7a0af4e] class OFTStringList(Field): pass
- [e7e9f1d1] class OFTTime(Field): @property def value(self): "Return a Python `time` object for this OFTTime field." try: yy, mm, dd, hh, mn, ss, tz = self.as_datetime() return time(hh.value, mn.value, ss.value) except (ValueError, GDALException): return None
- [1df1d556] class OFTWideString(Field): pass
- [fa410f59] class OFTWideStringList(Field): pass
- [659f8d78] from ctypes import byref, c_int from datetime import date, datetime, time
- [765143df] from django.contrib.gis.gdal.base import GDALBase from django.contrib.gis.gdal.error import GDALException from django.contrib.gis.gdal.prototypes import ds as capi from django.utils.encoding import force_str
