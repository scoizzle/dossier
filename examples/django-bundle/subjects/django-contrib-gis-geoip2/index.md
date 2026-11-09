# django/contrib/gis/geoip2

- Subject: django/contrib/gis/geoip2 (id `9c961fe3-3d2d-45d9-998f-173363eda596`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2234 tokens
- Facts shown: 38 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- # Try the path first in case it is the full path to a database. for path in (path, path / city, path / country): if path.is_file(): self._path = path self._reader = geoip2.database.Reader(path, mode=cache) break else: raise GeoIP2Exception( "Path must be a valid database or directory containing databases." ) [64c4dd03]
- * cache: The cache settings when opening up the GeoIP datasets. May be an integer in (0, 1, 2, 4, 8) corresponding to the MODE_AUTO, MODE_MMAP_EXT, MODE_MMAP, MODE_FILE, and MODE_MEMORY, `GeoIPOptions` C API settings, respectively. Defaults to 0, meaning MODE_AUTO. [8fa99492]
- * city: The name of the GeoIP city data file. Defaults to 'GeoLite2-City.mmdb'; overrides the GEOIP_CITY setting. """ if cache not in self.cache_options: raise GeoIP2Exception("Invalid GeoIP caching option: %s" % cache) [7cedd825]
- * country: The name of the GeoIP country data file. Defaults to 'GeoLite2-Country.mmdb'; overrides the GEOIP_COUNTRY setting. [31e98d66]
- * path: Base directory to where GeoIP data is located or the full path to where the city or country data files (*.mmdb) are located. Assumes that both the city and country data sets are located in this directory; overrides the GEOIP_PATH setting. [8769c1cb]
- database_type = self._metadata.database_type if database_type not in SUPPORTED_DATABASE_TYPES: raise GeoIP2Exception(f"Unable to handle database edition: {database_type}") [9581ae4a]
- function = self._reader.city if self.is_city else self._reader.country return function(query) [f761e4ca]
- if isinstance(query, str): try: validate_ipv46_address(query) except ValidationError: # GeoIP2 only takes IP addresses, so try to resolve a hostname. query = socket.gethostbyname(query) [c4329c30]
- if not path: raise GeoIP2Exception( "GeoIP path must be provided via parameter or the GEOIP_PATH setting." ) [9c4f251a]
- if require_city and not self.is_city: raise GeoIP2Exception(f"Invalid GeoIP city data file: {self._path}") [e2313a1c]
- path = path or getattr(settings, "GEOIP_PATH", None) city = city or getattr(settings, "GEOIP_CITY", "GeoLite2-City.mmdb") country = country or getattr(settings, "GEOIP_COUNTRY", "GeoLite2-Country.mmdb") [24733933]
- path = to_path(path) [401e7582]
- return Point(self.lon_lat(query), srid=4326) [25437ef1]
- @cached_property def _metadata(self): return self._reader.metadata() [4748e2ae]
- @cached_property def is_city(self): return "City" in self._metadata.database_type [1b7344a5]
- @cached_property def is_country(self): return "Country" in self._metadata.database_type [f9a098b5]
- _path = None _reader = None [b50bae28]
- def __del__(self): # Cleanup any GeoIP file handles lying around. if self._reader: self._reader.close() [3cd4b863]
- def __init__(self, path=None, cache=0, country=None, city=None): """ Initialize the GeoIP object. No parameters are required to use default settings. Keyword arguments may be passed in to customize the locations of the GeoIP datasets. [046f4d81]
- __all__ = ["HAS_GEOIP2"] [97f17867]

## All facts

- [1e252689] def __repr__(self): m = self._metadata version = f"v{m.binary_format_major_version}.{m.binary_format_minor_version}" return f"<{self.__class__.__name__} [{version}] _path='{self._path}'>"
- [47394f0b] def _query(self, query, *, require_city=False): if not isinstance(query, (str, ipaddress.IPv4Address, ipaddress.IPv6Address)): raise TypeError( "GeoIP query must be a string or instance of IPv4Address or " "IPv6Address, not type %s" % type(query).__name__, )
- [cbe41753] def city(self, query): """ Return a dictionary of city information for the given IP address or Fully Qualified Domain Name (FQDN). Some information in the dictionary may be undefined (None). """ response = self._query(query, require_city=True) region = response.subdivisions[0] if response.subdivisions else None return { "accuracy_radius": response.location.accuracy_radius, "city": response.city.name, "continent_code": response.continent.code, "continent_name": response.continent.name, "country_code": response.country.iso_code, "country_name": response.country.name, "is_in_european_union": response.country.is_in_european_union, "latitude": response.location.latitude, "longitude": response.location.longitude, "metro_code": response.location.metro_code, "postal_code": response.postal.code, "region_code": region.iso_code if region else None, "region_name": region.name if region else None, "time_zone": response.location.time_zone, # Kept for backward compatibility. "dma_code": response.location.metro_code, "region": region.iso_code if region else None, }
- [25a05390] def country(self, query): """ Return a dictionary with the country code and name when given an IP address or a Fully Qualified Domain Name (FQDN). For example, both '24.124.1.80' and 'djangoproject.com' are valid parameters. """ response = self._query(query, require_city=False) return { "continent_code": response.continent.code, "continent_name": response.continent.name, "country_code": response.country.iso_code, "country_name": response.country.name, "is_in_european_union": response.country.is_in_european_union, }
- [16f8f77b] def country_code(self, query): "Return the country code for the given IP Address or FQDN." return self.country(query)["country_code"]
- [3dbb8c4e] def country_name(self, query): "Return the country name for the given IP Address or FQDN." return self.country(query)["country_name"]
- [90f44440] def geos(self, query): "Return a GEOS Point object for the given query." # Allows importing and using GeoIP2() when GEOS is not installed. from django.contrib.gis.geos import Point
- [104e2691] def lat_lon(self, query): "Return a tuple of the (latitude, longitude) for the given query." data = self.city(query) return data["latitude"], data["longitude"]
- [28cd7ecb] def lon_lat(self, query): "Return a tuple of the (longitude, latitude) for the given query." data = self.city(query) return data["longitude"], data["latitude"]
- [05764be7] """ This module houses the GeoIP2 object, a wrapper for the MaxMind GeoIP2(R) Python API (https://geoip2.readthedocs.io/). This is an alternative to the Python GeoIP2 interface provided by MaxMind.
- [826537bb] # These are the values stored in the `database_type` field of the metadata. # See https://maxmind.github.io/MaxMind-DB/#database_type for details. SUPPORTED_DATABASE_TYPES = { "DBIP-City-Lite", "DBIP-Country-Lite", "GeoIP2-City", "GeoIP2-Country", "GeoLite2-City", "GeoLite2-Country", }
- [2a2876ec] For IP-based geolocation, this module requires the GeoLite2 Country and City datasets, in binary format (CSV will not work!). The datasets may be downloaded from MaxMind at https://dev.maxmind.com/geoip/geoip2/geolite2/. Grab GeoLite2-Country.mmdb.gz and GeoLite2-City.mmdb.gz, and unzip them in the directory corresponding to settings.GEOIP_PATH. """
- [7dc7b68c] GeoIP(R) is a registered trademark of MaxMind, Inc.
- [210e26d2] class GeoIP2: # The flags for GeoIP memory caching. # Try MODE_MMAP_EXT, MODE_MMAP, MODE_FILE in that order. MODE_AUTO = 0 # Use the C extension with memory map. MODE_MMAP_EXT = 1 # Read from memory map. Pure Python. MODE_MMAP = 2 # Read database as standard file. Pure Python. MODE_FILE = 4 # Load database into memory. Pure Python. MODE_MEMORY = 8 cache_options = frozenset( (MODE_AUTO, MODE_MMAP_EXT, MODE_MMAP, MODE_FILE, MODE_MEMORY) )
- [646cc327] class GeoIP2Exception(Exception): pass
- [3c6c1b4c] from django.conf import settings from django.core.exceptions import ValidationError from django.core.validators import validate_ipv46_address from django.utils._os import to_path from django.utils.functional import cached_property
- [59f62387] import ipaddress import socket
- [2cfb4f6d] try: import geoip2.database except ImportError: # pragma: no cover HAS_GEOIP2 = False else: HAS_GEOIP2 = True __all__ += ["GeoIP2", "GeoIP2Exception"]
