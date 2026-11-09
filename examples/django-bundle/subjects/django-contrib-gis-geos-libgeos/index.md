# django/contrib/gis/geos/libgeos

- Subject: django/contrib/gis/geos/libgeos (id `1cfb5c71-3dfc-43de-87ce-c8e5bf70af79`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1475 tokens
- Facts shown: 31 of 31
- Conflicts: 0
- Gaps: 0

## Highlights

- func = GEOSFunc(self.func_name) func.argtypes = self.argtypes or [] func.restype = self.restype if self.errcheck: func.errcheck = self.errcheck return func [39af6bfd]
- lib_path = settings.GEOS_LIBRARY_PATH except (AttributeError, ImportError, ImproperlyConfigured, OSError): lib_path = None [bfe35eb4]
- # No GEOS library could be found. if lib_path is None: raise ImportError( 'Could not find the GEOS library (tried "%s"). ' "Try setting GEOS_LIBRARY_PATH in your settings." % '", "'.join(lib_names) ) # Getting the GEOS C library. The C interface (CDLL) is used for # both *NIX and Windows. # See the GEOS C API source code for more details on the library function # calls: https://libgeos.org/doxygen/geos__c_8h_source.html _lgeos = CDLL(lib_path) # Here we set up the prototypes for the GEOS_init_r and GEOS_finish_r # routines, as well as the context handler setters. # These functions aren't actually called until they are # attached to a GEOS context handle -- this actually occurs in # geos/prototypes/threadsafe.py. _lgeos.GEOS_init_r.restype = CONTEXT_PTR _lgeos.GEOS_finish_r.argtypes = [CONTEXT_PTR] _lgeos.GEOSContext_setErrorHandler_r.argtypes = [CONTEXT_PTR, ERRORFUNC] _lgeos.GEOSContext_setNoticeHandler_r.argtypes = [CONTEXT_PTR, NOTICEFUNC] # Set restype for compatibility across 32 and 64-bit platforms. _lgeos.GEOSversion.restype = c_char_p return _lgeos [87143485]
- # Setting the appropriate names for the GEOS-C library. if lib_path: lib_names = None elif os.name == "nt": # Windows NT libraries lib_names = ["geos_c", "libgeos_c-1"] elif os.name == "posix": # *NIX libraries lib_names = ["geos_c", "GEOS"] else: raise ImportError('Unsupported OS "%s"' % os.name) [88bea21a]
- # Using the ctypes `find_library` utility to find the path to the GEOS # shared library. This is better than manually specifying each library name # and extension (e.g., libgeos_c.[so|so.1|dylib].). if lib_names: for lib_name in lib_names: lib_path = find_library(lib_name) if lib_path is not None: break [3e63a7f9]
- @cached_property def func(self): from django.contrib.gis.geos.prototypes.threadsafe import GEOSFunc [1d86e3f7]
- argtypes = None restype = None errcheck = None [3353c9e2]
- def __call__(self, *args): return self.func(*args) [f0becf7d]
- def __init__(self, func_name, *, restype=None, errcheck=None, argtypes=None): self.func_name = func_name if restype is not None: self.restype = restype if errcheck is not None: self.errcheck = errcheck if argtypes is not None: self.argtypes = argtypes [118186db]
- """ This module houses the ctypes initialization procedures, as well as the notice and error handler function callbacks (get called when an error occurs in GEOS). [4b91287e]
- # #### GEOS Geometry C data structures, and utility functions. #### [c452813a]
- # Opaque GEOS geometry structures, used for GEOM_PTR and CS_PTR class GEOSGeom_t(Structure): pass [c3e25d87]
- # Pointers to opaque GEOS geometry structures. GEOM_PTR = POINTER(GEOSGeom_t) PREPGEOM_PTR = POINTER(GEOSPrepGeom_t) CS_PTR = POINTER(GEOSCoordSeq_t) CONTEXT_PTR = POINTER(GEOSContextHandle_t) [2ffb3c61]
- ERRORFUNC = CFUNCTYPE(None, c_char_p, c_char_p) [29936937]

## All facts

- [12c1169b] # The notice and error handler C function callback definitions. # Supposed to mimic the GEOS message handler (C below): # typedef void (*GEOSMessageHandler)(const char *fmt, ...); NOTICEFUNC = CFUNCTYPE(None, c_char_p, c_char_p)
- [f344a72a] This module also houses GEOS Pointer utilities, including get_pointer_arr(), and GEOM_PTR. """
- [968ab02e] class GEOSContextHandle_t(Structure): pass
- [6a218f20] class GEOSCoordSeq_t(Structure): pass
- [c6b5289d] class GEOSFuncFactory: """ Lazy loading of GEOS functions. """
- [c4e64dbd] class GEOSPrepGeom_t(Structure): pass
- [33665927] def error_h(fmt, lst): fmt, lst = fmt.decode(), lst.decode() try: err_msg = fmt % lst except TypeError: err_msg = fmt logger.error("GEOS_ERROR: %s\n", err_msg)
- [b15fa571] def geos_version(): """Return the string version of the GEOS library.""" return lgeos.GEOSversion()
- [ceb9ce70] def geos_version_tuple(): """Return the GEOS version as a tuple (major, minor, subminor).""" return get_version_tuple(geos_version().decode())
- [d79abff3] def load_geos(): # Custom library path set? try: from django.conf import settings
- [d9d1e644] def notice_h(fmt, lst): fmt, lst = fmt.decode(), lst.decode() try: warn_msg = fmt % lst except TypeError: warn_msg = fmt logger.warning("GEOS_NOTICE: %s\n", warn_msg)
- [b21462d5] error_h = ERRORFUNC(error_h)
- [9b257647] from django.core.exceptions import ImproperlyConfigured from django.utils.functional import SimpleLazyObject, cached_property from django.utils.version import get_version_tuple
- [630143bd] import logging import os from ctypes import CDLL, CFUNCTYPE, POINTER, Structure, c_char_p from ctypes.util import find_library
- [03f5a946] lgeos = SimpleLazyObject(load_geos)
- [e92fc94cc00bbb3c-4] logger = logging.getLogger("django.contrib.gis")
- [d0af8805] notice_h = NOTICEFUNC(notice_h)
