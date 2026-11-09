# docs/ref/contrib/gis/install/geolibs

- Subject: docs/ref/contrib/gis/install/geolibs (id `08ced577-e01f-4d80-bc14-624601f85ee7`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 25 of 95
- Conflicts: 0
- Gaps: 0

## Facts

- $ sudo make install $ sudo ldconfig [184adc00]
- $ cd gdal-X.Y.Z $ mkdir build $ cd build [de67cc2a]
- $ cd geos-X.Y.Z $ mkdir build $ cd build [8878087e]
- $ cd proj-X.Y.Z $ mkdir build $ cd build [e687c231]
- $ cmake -DCMAKE_BUILD_TYPE=Release .. $ cmake --build . $ sudo cmake --build . --target install [a4433d9dcd5dc0e0]
- $ cmake .. $ cmake --build . $ sudo cmake --build . --target install [8a53ab59]
- $ sudo apt-get install binutils libproj-dev gdal-bin [cdd94c41]
- $ tar xzf proj-X.Y.Z.tar.gz $ cd proj-X.Y.Z/data $ tar xzf ../../proj-data-X.Y.tar.gz $ cd ../.. [827a3b3c]
- $ wget https://download.osgeo.org/gdal/X.Y.Z/gdal-X.Y.Z.tar.gz $ tar xzf gdal-X.Y.Z.tar.gz [541619ff]
- $ wget https://download.osgeo.org/geos/geos-X.Y.Z.tar.bz2 $ tar xjf geos-X.Y.Z.tar.bz2 [3930123b]
- $ wget https://download.osgeo.org/proj/proj-X.Y.Z.tar.gz [870ac478]
- $ wget https://download.osgeo.org/proj/proj-data-X.Y.tar.gz [b0e97773]
- .. code-block:: shell [8aa7203c166b13be-76]
- GDAL_LIBRARY_PATH = '/home/sue/local/lib/libgdal.so' [3c63dd33]
- GEOS_LIBRARY_PATH = '/home/bob/local/lib/libgeos_c.so' [7daae456]
- ImportError: Could not find the GEOS library (tried "geos_c"). Try setting GEOS_LIBRARY_PATH in your settings. [286a7d4f]
- On Linux platforms, it may be necessary to run the ``ldconfig`` command after installing each library. For example: [4d53c71d]
- The GeoDjango interfaces to GEOS, GDAL, and GeoIP may be used independently of Django. In other words, no database or settings file required -- import them as normal from :mod:`django.contrib.gis`. [72f8a9ee]
- The setting must be the *full* path to the **C** shared library; in other words you want to use ``libgeos_c.so``, not ``libgeos.so``. [3f30e74846c0e0ab-2]
- macOS users must install `Xcode`_ in order to compile software from source. [bcdfe356]
- .. Libs release dates: GEOS 3.10.0 2021-10-20 GEOS 3.11.0 2022-07-01 GEOS 3.12.0 2023-06-27 GEOS 3.13.0 2024-09-06 GEOS 3.14.0 2025-08-21 GDAL 3.3.0 2021-05-03 GDAL 3.4.0 2021-11-04 GDAL 3.5.0 2022-05-13 GDAL 3.6.0 2022-11-03 GDAL 3.7.0 2023-05-10 GDAL 3.8.0 2023-11-13 GDAL 3.9.0 2024-05-10 GDAL 3.10.0 2024-11-06 GDAL 3.11.0 2025-05-09 GDAL 3.12.0 2025-11-07 GDAL 3.13.0 2026-05-08 PostGIS 3.2.0 2021-12-18 PostGIS 3.3.0 2022-08-27 PostGIS 3.4.0 2023-08-15 PostGIS 3.5.0 2024-09-25 PostGIS 3.6.0 2025-09-02 PROJ 9.0.0 2022-03-01 PROJ 8.0.0 2021-03-01 PROJ 8.0.0 2021-03-01 PROJ 7.0.0 2020-02-25 PROJ 6.0.0 2019-02-26 SpatiaLite 4.3.0 2015-09-07 SpatiaLite 5.0.0 2020-08-23 SpatiaLite 5.1.0 2023-08-04 [67319ab3]
- .. _PROJ RFC-7: https://proj.org/community/rfc/rfc-7.html#rfc7 .. _build requirements: https://proj.org/install.html#build-requirements [805d4182]
- .. _PROJ: https://proj.org/ __ https://postgis.net/ __ https://www.gaia-gis.it/gaia-sins/ [7174b26d]
- .. _Xcode: https://developer.apple.com/xcode/ [11da3fa0]
- .. _build_from_source: [44bcb7ba]

## Beyond the budget

68 more facts did not fit in the budget: [4a0b3345] [3e08085d] [87acd429] [188db0a2] [233012eb] [58d423b0] [20a2d09f] [faf6f5a8efbd7831-13] [8aa7203c166b13be-77] [8aa7203c166b13be-78] [8aa7203c166b13be-79] [8aa7203c166b13be-80] [8aa7203c166b13be-81] [8aa7203c166b13be-82] [8aa7203c166b13be-83] [8aa7203c166b13be-84] [8aa7203c166b13be-85] [8aa7203c166b13be-86] [8aa7203c166b13be-87] [8aa7203c166b13be-88] [8aa7203c166b13be-89] [3a9340cd0d877339-22] [942ae6c11625c81c-54] [942ae6c11625c81c-55] [942ae6c11625c81c-56] [942ae6c11625c81c-57] [dce3f40b] [01575819] [ef3c7cc1] [fe6d61ab] [7028b256] [02881dfa] [7f44c62c] [a325803f] [5642f834] [3742e552] [671f3f8d] [50113fd8] [e8a4e1ac] [f8f99b24] [f9d2ea23] [236f5208] [9a1b4a29] [5fd4cf44] [27ef2e7e] [aa916f35] [7bcb4842] [bd8932f6] [f8012547] [dc912279] [9271b09b] [8c1d9815] [450a6a05] [fe0e85e7] [91aa2826] [131eafa2] [de68df03] [5e7e9fff] [76ffcd0980399518] [76ffcd0980399518-2] [56501c7d] [86c1f78d] [17c96b5c] [e2a669e4] [d313aa2e] [f3032a50] [e93979f7] [2cbc39fe]
