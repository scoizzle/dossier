# docs/ref/contrib/gis/geoip2

- Subject: docs/ref/contrib/gis/geoip2 (id `189a32e4-61fe-4e40-b774-ad7131d2aa93`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1805 tokens
- Facts shown: 48 of 51
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [661583e1] All the following querying routines may take an instance of :class:`~ipaddress.IPv4Address` or :class:`~ipaddress.IPv6Address`, a string IP address, or a fully qualified domain name (FQDN). For example, ``IPv4Address("205.186.163.125")``, ``"205.186.163.125"``, and ``"djangoproject.com"`` would all be valid query parameters.
- [458050e52503f721-3] Exceptions ==========
- [9e0500d6] Here is an example of its usage:
- [8d5f6230] In order to perform IP-based geolocation, the :class:`GeoIP2` object requires the :pypi:`geoip2` Python package and the GeoIP ``Country`` and/or ``City`` datasets in binary format (the CSV files will not work!), downloaded from e.g. `MaxMind`__ or `DB-IP`__ websites. Grab the ``GeoLite2-Country.mmdb.gz`` and ``GeoLite2-City.mmdb.gz`` files and unzip them in a directory corresponding to the :setting:`GEOIP_PATH` setting.
- [ec8366aa0d7b3837] Methods =======
- [75696e16fcbb84ec-7] Overview ========
- [cc34e0c3] Querying --------
- [adc11796] Returns a :class:`~django.contrib.gis.geos.Point` object corresponding to the query.
- [d1a2a8b9] Returns a coordinate tuple of (latitude, longitude),
- [63df0f60] Returns a dictionary of city information for the given query. Some of the values in the dictionary may be undefined (``None``).
- [f63a6fad] Returns a dictionary with the country code and country for the given query.
- [4f9e6a90] Returns the country code corresponding to the query.
- [4c74b509] Returns the country name corresponding to the query.
- [94005583b32250b8-2] Settings ========
- [9a4f2149] The :class:`GeoIP2` object is a wrapper for the :pypi:`MaxMind geoip2 Python library <geoip2>`. [#]_
- [010a393a] The ``GeoIP`` object does not require any parameters to use the default settings. However, at the very least the :setting:`GEOIP_PATH` setting should be set with the path of the location of your GeoIP datasets. The following initialization keywords may be used to customize any of the defaults.
- [d54c683d] The basename to use for the GeoIP city data file. Defaults to ``'GeoLite2-City.mmdb'``.
- [f62bd91b] The basename to use for the GeoIP country data file. Defaults to ``'GeoLite2-Country.mmdb'``.
- [ee007657] __ https://dev.maxmind.com/geoip/geolite2-free-geolocation-data __ https://db-ip.com/db/lite.php __ https://github.com/maxmind/libmaxminddb/
- [3824b00f] ``GEOIP_CITY`` --------------
- [ae0dd84d] ``GEOIP_COUNTRY`` -----------------
- [58fc4c14] ``GEOIP_PATH`` --------------
- [a353548c] ``cache`` The cache settings when opening up the GeoIP datasets. May be an integer in (0, 1, 2, 4, 8) corresponding to the ``MODE_AUTO``, ``MODE_MMAP_EXT``, ``MODE_MMAP``, and ``GEOIP_INDEX_CACHE`` ``MODE_MEMORY`` C API settings, respectively. Defaults to 0 (``MODE_AUTO``).
- [74c15054] ``city`` The name of the GeoIP city data file. Defaults to ``GeoLite2-City.mmdb``. Setting this keyword overrides the :setting:`GEOIP_CITY` setting. =================== =======================================================
