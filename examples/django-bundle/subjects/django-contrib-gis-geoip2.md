# django/contrib/gis/geoip2

- Subject: django/contrib/gis/geoip2 (id `56ae4687-e2f1-4443-85c1-8b123bbbd35d`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 20 of 38
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

16 more facts did not fit in the budget: [1e252689] [47394f0b] [cbe41753] [25a05390] [16f8f77b] [90f44440] [104e2691] [05764be7] [826537bb] [2a2876ec] [7dc7b68c] [210e26d2] [646cc327] [3c6c1b4c] [59f62387] [2cfb4f6d]
