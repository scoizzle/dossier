# django/contrib/gis/utils/srs

- Subject: django/contrib/gis/utils/srs (id `5df16c4f-d3fd-48c4-8dc1-731ceb5d1527`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 776 tokens
- Facts shown: 12 facts
- Conflicts: 0
- Gaps: 0

## Facts

- auth_srid: This keyword may be customized with the value of the `auth_srid` field. Defaults to the SRID determined by GDAL. [c033278f]
- database: The name of the database connection to use; the default is the value of `django.db.DEFAULT_DB_ALIAS` (at the time of this writing, its value is 'default'). """ database = database or DEFAULT_DB_ALIAS connection = connections[database] [7aaf54d5]
- ref_sys_name: For SpatiaLite users only, sets the value of the `ref_sys_name` field. Defaults to the name determined by GDAL. [0e53241b]
- # Creating the spatial_ref_sys model. try: # Try getting via SRID only, because using all kwargs may # differ from exact wkt/proj in database. SpatialRefSys.objects.using(database).get(srid=srs.srid) except SpatialRefSys.DoesNotExist: SpatialRefSys.objects.using(database).create(**kwargs) [cf4adb4e]
- # If argument is not a `SpatialReference` instance, use it as parameter # to construct a `SpatialReference` instance. if not isinstance(srs, SpatialReference): srs = SpatialReference(srs) [bb313921]
- # Initializing the keyword arguments dictionary for both PostGIS # and SpatiaLite. kwargs = { "srid": srs.srid, "auth_name": auth_name, "auth_srid": auth_srid or srs.srid, "proj4text": srs.proj4, } # Backend-specific fields for the SpatialRefSys model. srs_field_names = {f.name for f in SpatialRefSys._meta.get_fields()} if "srtext" in srs_field_names: kwargs["srtext"] = srs.wkt if "ref_sys_name" in srs_field_names: # SpatiaLite specific kwargs["ref_sys_name"] = ref_sys_name or srs.name [cedda4a5]
- >>> from django.contrib.gis.utils import add_srs_entry >>> add_srs_entry(3857) [73ab9e4c]
- Keyword Arguments: auth_name: This keyword may be customized with the value of the `auth_name` field. Defaults to 'EPSG'. [77b48f8b]
- if not hasattr(connection.ops, "spatial_version"): raise Exception("The `add_srs_entry` utility only works with spatial backends.") if not connection.features.supports_add_srs_entry: raise Exception("This utility does not support your database backend.") SpatialRefSys = connection.ops.spatial_ref_sys() [4dcce402]
- if srs.srid is None: raise Exception( "Spatial reference requires an SRID to be " "compatible with the spatial backend." ) [27da6975]
- def add_srs_entry( srs, auth_name="EPSG", auth_srid=None, ref_sys_name=None, database=None ): """ Take a GDAL SpatialReference system and add its information to the `spatial_ref_sys` table of the spatial backend. Doing this enables database-level spatial transformations for the backend. Thus, this utility is useful for adding spatial reference systems not included by default with the backend: [7cb67639]
- from django.contrib.gis.gdal import SpatialReference from django.db import DEFAULT_DB_ALIAS, connections [29e34e5c]
