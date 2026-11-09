# docs/ref/contrib/gis/geoip2

- Subject: docs/ref/contrib/gis/geoip2 (id `b1e6e068-3cfc-4ba6-89d8-56afbcf85721`)
- Kind: subject
- Budget: 1200 tokens
- Used: 889 tokens
- Facts shown: 24 of 51
- Conflicts: 0
- Gaps: 0

## Facts

- >>> from django.contrib.gis.geoip2 import GeoIP2 >>> g = GeoIP2() >>> g.country("google.com") {'continent_code': 'NA', 'continent_name': 'North America', 'country_code': 'US', 'country_name': 'United States', 'is_in_european_union': False} >>> g.city("72.14.207.99") {'accuracy_radius': 1000, 'city': 'Mountain View', 'continent_code': 'NA', 'continent_name': 'North America', 'country_code': 'US', 'country_name': 'United States', 'is_in_european_union': False, 'latitude': 37.419200897216797, 'longitude': -122.05740356445312, 'metro_code': 807, 'postal_code': '94043', 'region_code': 'CA', 'region_name': 'California', 'time_zone': 'America/Los_Angeles', 'dma_code': 807, 'region': 'CA'} >>> g.lat_lon("salon.com") (39.0437, -77.4875) >>> g.lon_lat("uh.edu") (-95.4342, 29.834) >>> g.geos("24.124.1.80").wkt 'POINT (-97 38)' [3f5544a5]
- The exception raised when an error occurs in the :class:`GeoIP2` wrapper. Exceptions from the underlying ``geoip2`` library are passed through unchanged. [81045dad]
- .. _geoip2-overview: [fc8526a6]
- .. class:: GeoIP2(path=None, cache=0, country=None, city=None) [06ac15d5]
- .. code-block:: pycon [eaf050be34acb41d-133]
- .. exception:: GeoIP2Exception [c8048d71]
- .. method:: GeoIP2.city(query) [7231510a]
- .. method:: GeoIP2.country(query) [87e04f46]
- .. method:: GeoIP2.country_code(query) [9c54ead6]
- .. method:: GeoIP2.country_name(query) [7cc09a35]
- .. method:: GeoIP2.geos(query) [3839e14a]
- .. method:: GeoIP2.lat_lon(query) [7a325b44]
- .. module:: django.contrib.gis.geoip2 :synopsis: Python interface for MaxMind's GeoIP2 databases. [df479e65]
- .. rubric:: Footnotes .. [#] GeoIP(R) is a registered trademark of MaxMind, Inc. [9bd509ef]
- .. setting:: GEOIP_CITY [d7e82c7a]
- .. setting:: GEOIP_COUNTRY [98fbb5de]
- .. setting:: GEOIP_PATH [6b2b75d5]
- =================== ======================================================= Keyword Arguments Description =================== ======================================================= ``path`` Base directory to where GeoIP data is located or the full path to where the city or country data files (``.mmdb``) are located. Assumes that both the city and country datasets are located in this directory; overrides the :setting:`GEOIP_PATH` setting. [810c88e4]
- ======================= Geolocation with GeoIP2 ======================= [a60b3b8b]
- A string or :class:`pathlib.Path` specifying the directory where the GeoIP data files are located. This setting is *required* unless manually specified with ``path`` keyword when initializing the :class:`GeoIP2` object. [7e6f3d44]
- API Reference ============= [b230c4722728fb5b-2]
- Additionally, it is recommended to install the `libmaxminddb C library`__, so that ``geoip2`` can leverage the C library's faster speed. [eba04a03]
- Coordinate Retrieval -------------------- [5e22c39a]
- Example ======= [cf1461d9a1a7899c-2]

## Beyond the budget

24 more facts did not fit in the budget: [661583e1] [458050e52503f721-3] [9e0500d6] [8d5f6230] [ec8366aa0d7b3837] [75696e16fcbb84ec-7] [cc34e0c3] [adc11796] [d1a2a8b9] [63df0f60] [f63a6fad] [4f9e6a90] [4c74b509] [94005583b32250b8-2] [9a4f2149] [010a393a] [d54c683d] [f62bd91b] [ee007657] [3824b00f] [ae0dd84d] [58fc4c14] [a353548c] [74c15054]
