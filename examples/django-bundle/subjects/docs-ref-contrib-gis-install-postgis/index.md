# docs/ref/contrib/gis/install/postgis

- Subject: docs/ref/contrib/gis/install/postgis (id `ca9010cf-52f0-4790-bb0e-feb0f9b95278`)
- Kind: subject
- Budget: 1200 tokens
- Used: 867 tokens
- Facts shown: 20 of 21
- Conflicts: 0
- Gaps: 0

## Facts

- $ createdb <db name> $ psql <db name> > CREATE EXTENSION postgis; [9d5b5630]
- class Migration(migrations.Migration): operations = [CreateExtension("postgis"), ...] [824ce545]
- from django.contrib.postgres.operations import CreateExtension from django.db import migrations [e02e23cc]
- postgres# CREATE USER geodjango PASSWORD 'my_passwd'; postgres# CREATE DATABASE geodjango OWNER geodjango; [47058007]
- .. _PostGIS: https://postgis.net/ .. _psycopg: https://www.psycopg.org/psycopg3/ .. _psycopg2: https://www.psycopg.org/ .. _PostGIS requirements: https://postgis.net/docs/postgis_installation.html#install_requirements .. _build from source: https://postgis.net/docs/postgis_installation.html#install_short_version [ead1cd23]
- .. _spatialdb_template: [f948a345]
- .. code-block:: psql [e959c9cb2ba15358]
- .. code-block:: shell [8aa7203c166b13be-100]
- ================== Installing PostGIS ================== [21c6dd24]
- Creating a spatial database --------------------------- [7dc5a913]
- GeoDjango does not currently leverage any `PostGIS topology functionality`__. If you plan to use those features at some point, you can also install the ``postgis_topology`` extension by issuing ``CREATE EXTENSION postgis_topology;``. [8eba3a49]
- If you plan to use PostGIS raster functionality, you should also activate the ``postgis_raster`` extension. You can install the extension using the :class:`~django.contrib.postgres.operations.CreateExtension` migration operation, or directly by running ``CREATE EXTENSION postgis_raster;``. [addf6e9c]
- Managing the database --------------------- [49add772]
- On Debian/Ubuntu, you are advised to install the following packages: ``postgresql-x``, ``postgresql-x-postgis-3``, ``postgresql-server-dev-x``, and ``python3-psycopg3`` (x matching the PostgreSQL version you want to install). Alternately, you can `build from source`_. Consult the platform-specific instructions if you are on :ref:`macos` or :ref:`windows`. [2d4809cf]
- Post-installation ================= [b53b3ede]
- PostGIS includes an extension for PostgreSQL that's used to enable spatial functionality: [896a7478]
- The `psycopg`_ or `psycopg2`_ module is required for use as the database adapter when using GeoDjango with PostGIS. [1f635916]
- The database user must be a superuser in order to run ``CREATE EXTENSION postgis;``. The command is run during the :djadmin:`migrate` process. An alternative is to use a migration operation in your project:: [99f87e4d]
- To administer the database, you can either use the pgAdmin III program (:menuselection:`Start --> PostgreSQL X --> pgAdmin III`) or the SQL Shell (:menuselection:`Start --> PostgreSQL X --> SQL Shell`). For example, to create a ``geodjango`` spatial database and user, the following may be executed from the SQL Shell as the ``postgres`` user: [fd38c5a4]
- __ https://postgis.net/docs/Topology.html [9a1307f9]

## Beyond the budget

1 more facts did not fit in the budget: [0909c0f0]
