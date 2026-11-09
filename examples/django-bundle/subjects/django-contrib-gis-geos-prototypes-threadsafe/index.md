# django/contrib/gis/geos/prototypes/threadsafe

- Subject: django/contrib/gis/geos/prototypes/threadsafe (id `2e5491ef-c541-45e4-b2c1-021885848d09`)
- Kind: subject
- Budget: 1200 tokens
- Used: 719 tokens
- Facts shown: 20 of 20
- Conflicts: 0
- Gaps: 0

## Facts

- # argtypes property def _get_argtypes(self): return self.cfunc.argtypes [908160ce]
- # errcheck property def _get_errcheck(self): return self.cfunc.errcheck [84167daa]
- # restype property def _get_restype(self): return self.cfunc.restype [a21d1dd1]
- argtypes = property(_get_argtypes, _set_argtypes) [6433c173]
- def __call__(self, *args): # Create a context handle if one doesn't exist for this thread. self.thread_context.handle = self.thread_context.handle or GEOSContextHandle() # Call the threaded GEOS routine with the pointer of the context handle # as the first argument. return self.cfunc(self.thread_context.handle.ptr, *args) [4f69f16a]
- def __init__(self): self.ptr = lgeos.GEOS_init_r() lgeos.GEOSContext_setNoticeHandler_r(self.ptr, notice_h) lgeos.GEOSContext_setErrorHandler_r(self.ptr, error_h) [12ede8a0]
- def __init__(self, func_name): # GEOS thread-safe function signatures end with '_r' and take an # additional context handle parameter. self.cfunc = getattr(lgeos, func_name + "_r") # Create a reference to thread_context so it's not garbage-collected # before an attempt to call this object. self.thread_context = thread_context [6e648eec]
- def __str__(self): return self.cfunc.__name__ [65ddfed0]
- def _set_argtypes(self, argtypes): self.cfunc.argtypes = [CONTEXT_PTR, *argtypes] [667632b1]
- def _set_errcheck(self, errcheck): self.cfunc.errcheck = errcheck [c605098c]
- def _set_restype(self, restype): self.cfunc.restype = restype [40a4a07d]
- errcheck = property(_get_errcheck, _set_errcheck) [732c1ae5]
- ptr_type = CONTEXT_PTR destructor = lgeos.GEOS_finish_r [c339e57e]
- restype = property(_get_restype, _set_restype) [a2536b14]
- # Defining a thread-local object and creating an instance # to hold a reference to GEOSContextHandle for this thread. class GEOSContext(threading.local): handle = None [34001c49]
- class GEOSContextHandle(GEOSBase): """Represent a GEOS context handle.""" [3f0289ea]
- class GEOSFunc: """ Serve as a wrapper for GEOS C Functions. Use thread-safe function variants when available. """ [38218ce2]
- from django.contrib.gis.geos.base import GEOSBase from django.contrib.gis.geos.libgeos import CONTEXT_PTR, error_h, lgeos, notice_h [194c9db6]
- import threading [f14f4c10]
- thread_context = GEOSContext() [bb7d0ad3]
