# django/contrib/gis/gdal/libgdal

- Subject: django/contrib/gis/gdal/libgdal (id `890f04a1-a738-40ba-8619-b7cf13c5aa21`)
- Kind: subject
- Budget: 1200 tokens
- Used: 866 tokens
- Facts shown: 21 of 23
- Conflicts: 0
- Gaps: 0

## Facts

- lib_path = settings.GDAL_LIBRARY_PATH except (AttributeError, ImportError, ImproperlyConfigured, OSError): lib_path = None [f52e7104]
- lwingdal = WinDLL(lib_path) [57225b49]
- # #### Version-information functions. #### [650ee662]
- # Custom library path set? try: from django.conf import settings [91f8017f]
- # On Windows, the GDAL binaries have some OSR routines exported with # STDCALL, while others are not. Thus, the library will also need to # be loaded up as WinDLL for said OSR functions that require the # different calling convention. if os.name == "nt": from ctypes import WinDLL [dece7b7d]
- # Return GDAL library version information with the given key. _version_info = std_call("GDALVersionInfo") _version_info.argtypes = [c_char_p] _version_info.restype = c_char_p [dd604ea7]
- # Set library error handling so as errors are logged CPLErrorHandler = CFUNCTYPE(None, c_int, c_int, c_char_p) [a864bf0d]
- # This loads the GDAL/OGR C library lgdal = CDLL(lib_path) [5149d0eb]
- # Using the ctypes `find_library` utility to find the # path to the GDAL library from the list of library names. if lib_names: for lib_name in lib_names: lib_path = find_library(lib_name) if lib_path is not None: break [6b51f4d8]
- GDAL_VERSION = gdal_version_info() [cf4549a3]
- def err_handler(error_class, error_number, message): logger.error("GDAL_ERROR %d: %s", error_number, message) [046cfeda]
- def function(name, args, restype): func = std_call(name) func.argtypes = args func.restype = restype return func [e8d6bc5e]
- def gdal_full_version(): "Return the full GDAL version information." return _version_info(b"") [208fab90]
- def gdal_version(): "Return only the GDAL version number information." return _version_info(b"RELEASE_NAME") [4961b863]
- def gdal_version_info(): ver = gdal_version() m = re.match(rb"^(?P<major>\d+)\.(?P<minor>\d+)(?:\.(?P<subminor>\d+))?", ver) if not m: raise GDALException('Could not parse GDAL version string "%s"' % ver) major, minor, subminor = m.groups() return (int(major), int(minor), subminor and int(subminor)) [3d5d0d06]
- def std_call(func): """ Return the correct STDCALL function for certain OSR routines on Win32 platforms. """ if os.name == "nt": return lwingdal[func] else: return lgdal[func] [a06fbe67]
- err_handler = CPLErrorHandler(err_handler) [70c368a3]
- from django.contrib.gis.gdal.error import GDALException from django.core.exceptions import ImproperlyConfigured [21697ba3]
- if lib_path is None: raise ImproperlyConfigured( 'Could not find the GDAL library (tried "%s"). Is GDAL installed? ' "If it is, try setting GDAL_LIBRARY_PATH in your settings." % '", "'.join(lib_names) ) [ee44432a]
- import logging import os import re from ctypes import CDLL, CFUNCTYPE, c_char_p, c_int from ctypes.util import find_library [8ab9c7f1]
- logger = logging.getLogger("django.contrib.gis") [e92fc94cc00bbb3c-3]

## Beyond the budget

2 more facts did not fit in the budget: [4c0986f2] [4b8f5f01]
