# django/contrib/gis/gdal/raster/base

- Subject: django/contrib/gis/gdal/raster/base (id `cd3fd049-ee82-4f6d-9d5f-224d209eb8d8`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 609 tokens
- Facts shown: 7 facts
- Conflicts: 0
- Gaps: 0

## Facts

- # Free domain list array. capi.free_dsl(meta_list) [3e3a653d]
- # Get additional metadata domains from the raster. meta_list = capi.get_ds_metadata_domain_list(self._ptr) if meta_list: # The number of domains is unknown, so retrieve data until there # are no more values in the ctypes array. counter = 0 domain = meta_list[counter] while domain: domain_list.append(domain.decode()) counter += 1 domain = meta_list[counter] [79b25547]
- # Retrieve metadata values for each domain. result = {} for domain in domain_list: # Get metadata for this domain. data = capi.get_ds_metadata( self._ptr, (None if domain == "DEFAULT" else domain.encode()), ) if not data: continue # The number of metadata items is unknown, so retrieve data until # there are no more values in the ctypes array. domain_meta = {} counter = 0 item = data[counter] while item: key, val = item.decode().split("=") domain_meta[key] = val counter += 1 item = data[counter] # The default domain values are returned if domain is None. result[domain or "DEFAULT"] = domain_meta return result [191a0774]
- @metadata.setter def metadata(self, value): """ Set the metadata. Update only the domains that are contained in the value dictionary. """ # Loop through domains. for domain, metadata in value.items(): # Set the domain to None for the default, otherwise encode. domain = None if domain == "DEFAULT" else domain.encode() # Set each metadata entry separately. for meta_name, meta_value in metadata.items(): capi.set_ds_metadata_item( self._ptr, meta_name.encode(), meta_value.encode() if meta_value else None, domain, ) [7bd89b59]
- @property def metadata(self): """ Return the metadata for this raster or band. The return value is a nested dictionary, where the first-level key is the metadata domain and the second-level is the metadata item names and values for that domain. """ # The initial metadata domain list contains the default domain. # The default is returned if domain name is None. domain_list = ["DEFAULT"] [5d1db0c3]
- class GDALRasterBase(GDALBase): """ Attributes that exist on both GDALRaster and GDALBand. """ [98de6307]
- from django.contrib.gis.gdal.base import GDALBase from django.contrib.gis.gdal.prototypes import raster as capi [55b6142f]
