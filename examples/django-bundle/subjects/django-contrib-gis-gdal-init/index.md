# django/contrib/gis/gdal/__init__

- Subject: django/contrib/gis/gdal/__init__ (id `669d5dcd-a2e8-4b9b-beef-41c46eaf4527`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 549 tokens
- Facts shown: 11 of 11
- Conflicts: 0
- Gaps: 0

## Facts

- """ This module houses ctypes interfaces for GDAL objects. The following GDAL objects are supported: [9baffffb]
- CoordTransform: Used for coordinate transformations from one spatial reference system to another. [d14e1e63]
- DataSource: Wrapper for the OGR data source object, supports OGR-supported data sources. [c66396d6]
- Driver: Wraps an OGR data source driver. [54356a6c]
- Envelope: A ctypes structure for bounding boxes (GDAL library not required). [0c526758]
- OGRGeomType: A class for representing the different OGR Geometry types (GDAL library not required). [483fbbd5]
- OGRGeometry: Object for accessing OGR Geometry functionality. [127c8542]
- SpatialReference: Represents OSR Spatial Reference objects. [531bd88f]
- The GDAL library will be imported from the system path using the default library name for the current OS. The default library path may be overridden by setting `GDAL_LIBRARY_PATH` in your settings with the path to the GDAL C library on your system. """ [320be6db]
- __all__ = ( "AxisOrder", "Driver", "DataSource", "CoordTransform", "Envelope", "GDALException", "GDALRaster", "GDAL_VERSION", "OGRGeometry", "OGRGeomType", "SpatialReference", "SRSException", "check_err", "gdal_version", "gdal_full_version", ) [d4223e44]
- from django.contrib.gis.gdal.datasource import DataSource from django.contrib.gis.gdal.driver import Driver from django.contrib.gis.gdal.envelope import Envelope from django.contrib.gis.gdal.error import GDALException, SRSException, check_err from django.contrib.gis.gdal.geometries import OGRGeometry from django.contrib.gis.gdal.geomtype import OGRGeomType from django.contrib.gis.gdal.libgdal import ( GDAL_VERSION, gdal_full_version, gdal_version, ) from django.contrib.gis.gdal.raster.source import GDALRaster from django.contrib.gis.gdal.srs import AxisOrder, CoordTransform, SpatialReference [e447c162]
