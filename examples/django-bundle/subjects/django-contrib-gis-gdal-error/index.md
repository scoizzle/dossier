# django/contrib/gis/gdal/error

- Subject: django/contrib/gis/gdal/error (id `992c1fae-a14b-4f9c-884d-f0fd9279e8aa`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 452 tokens
- Facts shown: 9 facts
- Conflicts: 0
- Gaps: 0

## Facts

- if code == ERR_NONE: return elif code in err_dict: e, msg = err_dict[code] raise e(msg) else: raise GDALException('Unknown error code: "%s"' % code) [7eeaaadc]
- """ This module houses the GDAL & SRS Exception objects, and the check_err() routine which checks the status code returned by GDAL/OGR methods. """ [e4f0a154]
- # #### GDAL & SRS Exceptions #### class GDALException(Exception): pass [c39addef]
- # #### GDAL/OGR error checking codes and routine #### [c75dfd93]
- # CPL Error Codes # https://gdal.org/api/cpl.html#cpl-error-h CPLERR_DICT = { 1: (GDALException, "AppDefined"), 2: (GDALException, "OutOfMemory"), 3: (GDALException, "FileIO"), 4: (GDALException, "OpenFailed"), 5: (GDALException, "IllegalArg"), 6: (GDALException, "NotSupported"), 7: (GDALException, "AssertionFailed"), 8: (GDALException, "NoWriteAccess"), 9: (GDALException, "UserInterrupt"), 10: (GDALException, "ObjectNull"), } [a1566a00]
- # OGR Error Codes OGRERR_DICT = { 1: (GDALException, "Not enough data."), 2: (GDALException, "Not enough memory."), 3: (GDALException, "Unsupported geometry type."), 4: (GDALException, "Unsupported operation."), 5: (GDALException, "Corrupt data."), 6: (GDALException, "OGR failure."), 7: (SRSException, "Unsupported SRS."), 8: (GDALException, "Invalid handle."), } [4248b70c]
- ERR_NONE = 0 [f16f76d4]
- class SRSException(Exception): pass [a2c9a67d]
- def check_err(code, cpl=False): """ Check the given CPL/OGRERR and raise an exception where appropriate. """ err_dict = CPLERR_DICT if cpl else OGRERR_DICT [088166b6]
