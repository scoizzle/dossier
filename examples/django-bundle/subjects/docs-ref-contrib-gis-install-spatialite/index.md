# docs/ref/contrib/gis/install/spatialite

- Subject: docs/ref/contrib/gis/install/spatialite (id `e9c69979-71e5-4bb0-939a-97b8d95c7ebc`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1319 tokens
- Facts shown: 46 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- $ ./configure --target=macosx [662ae733]
- $ CFLAGS="-DSQLITE_ENABLE_RTREE=1" ./configure $ make $ sudo make install $ cd .. [285e2f59]
- $ brew --prefix /opt/homebrew [0a07d9a8]
- $ brew update $ brew install spatialite-tools $ brew install gdal [76f1bb5a]
- $ wget https://www.gaia-gis.it/gaia-sins/libspatialite-sources/libspatialite-X.Y.Z.tar.gz $ tar xaf libspatialite-X.Y.Z.tar.gz $ cd libspatialite-X.Y.Z $ ./configure $ make $ sudo make install [8a19623f]
- $ wget https://www.sqlite.org/YYYY/sqlite-amalgamation-XXX0000.zip $ unzip sqlite-amalgamation-XXX0000.zip $ cd sqlite-amalgamation-XXX0000 [8bcd68f4]
- .. code-block:: shell [8aa7203c166b13be-101]
- For macOS users building from source, the SpatiaLite library *and* tools need to have their ``target`` configured: [4be8f1d2]
- SPATIALITE_LIBRARY_PATH = "/opt/homebrew/lib/mod_spatialite.dylib" [23314677]
- sqlite> CREATE VIRTUAL TABLE testrtree USING rtree(id,minX,maxX,minY,maxY); [f42018c0]
- .. _Homebrew: https://brew.sh/ [5b368f9f]
- .. _spatialite_macos: [0f66bd83]
- .. _spatialite_source: [dbe18db2]
- .. _spatialitebuild: [33dd0fd9]
- .. code-block:: console [faf6f5a8efbd7831-14]
- .. code-block:: shell [8aa7203c166b13be-102]
- .. code-block:: shell [8aa7203c166b13be-103]
- .. code-block:: shell [8aa7203c166b13be-104]
- .. code-block:: shell [8aa7203c166b13be-105]
- .. code-block:: sqlite3 [92341da9]
- .. note:: [942ae6c11625c81c-65]
- :doc:`GEOS and PROJ</ref/contrib/gis/install/geolibs>` should be installed prior to building SpatiaLite. [086d9fd3]
- ===================== Installing SpatiaLite ===================== [feeb98ce]
- Check first if SQLite is compiled with the `R*Tree module`__. Run the sqlite3 command line interface and enter the following query: [2b0a397d]
- Finally, for GeoDjango to be able to find the SpatiaLite library, set the ``SPATIALITE_LIBRARY_PATH`` setting to its path. This will be within your brew install path, which you can check with: [23ef5bca]
- First, check if you can install SpatiaLite from system packages or binaries. [0f456c24]
- For Windows, you may find binaries on the `Gaia-SINS`__ home page. [9625062d]
- For example, on Debian-based distributions that package SpatiaLite 4.3+, try to install the ``libsqlite3-mod-spatialite`` package. For older releases install ``spatialite-bin``. [82b5844a]
- For macOS, follow the :ref:`instructions below<spatialite_macos>`. [ee986ef7]
- Get the latest SpatiaLite library source bundle from the `download page`__: [58c5e6cb]
- Homebrew -------- [97d6bf9d]
- If you obtain an error, you will have to recompile SQLite from source. Otherwise, skip this section. [cbac806c]
- Installing from source ====================== [a97aa4e7]

## All facts

- [db5156b0] In any case, you should always be able to :ref:`install from source <spatialite_source>`.
- [5eb2ab30] Next, run the ``configure`` script -- however the ``CFLAGS`` environment variable needs to be customized so that SQLite knows to build the R*Tree module:
- [e8569145] SQLite ------
- [a643e7e1] SpatiaLite library (``libspatialite``) --------------------------------------
- [da015e7f] To install from sources, download the latest amalgamation source archive from the `SQLite download page`__, and extract:
- [4b952821] To install the SpatiaLite library and tools, macOS users can use `Homebrew`_.
- [20af7518] Using this brew install path, the full path can be constructed like this::
- [2f631c59] __ https://www.gaia-gis.it/fossil/libspatialite/index __ https://www.gaia-gis.it/gaia-sins/
- [158dd8e6] __ https://www.gaia-gis.it/gaia-sins/libspatialite-sources/
- [ac9e49aa] __ https://www.sqlite.org/rtree.html __ https://www.sqlite.org/download.html
- [c2ea94bb] `Homebrew`_ handles all the SpatiaLite related packages on your behalf, including SQLite, SpatiaLite, PROJ, and GEOS. Install them like this:
- [97ee2123] `SpatiaLite`__ adds spatial support to SQLite, turning it into a full-featured spatial database.
- [4996c8fb] macOS-specific instructions ==============================
