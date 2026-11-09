# docs/ref/contrib/gis/layermapping

- Subject: docs/ref/contrib/gis/layermapping (id `9b450dba-45f0-4976-8b34-3ee151f359e4`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2669 tokens
- Facts shown: 54 of 54
- Conflicts: 0
- Gaps: 0

## Highlights

- def __str__(self): return "Name: %s" % self.name [d77d9427]
- >>> from django.contrib.gis.gdal import DataSource >>> ds = DataSource("test_poly.shp") >>> layer = ds[0] >>> print(layer.fields) # Exploring the fields in the layer, we only want the 'str' field. ['float', 'int', 'str'] >>> print(len(layer)) # getting the number of features in the layer (should be 3) 3 >>> print(layer.geom_type) # Should be 'Polygon' Polygon >>> print(layer.srs) # WGS84 in WKT GEOGCS["GCS_WGS_1984", DATUM["WGS_1984", SPHEROID["WGS_1984",6378137,298.257223563]], PRIMEM["Greenwich",0], UNIT["Degree",0.017453292519943295]] [e31fedf4]
- >>> from django.contrib.gis.utils import LayerMapping >>> from geoapp.models import TestGeo >>> mapping = { ... "name": "str", # The 'name' model field maps to the 'str' layer field. ... "poly": "POLYGON", # For geometry fields use OGC name. ... } # The mapping is a dictionary >>> lm = LayerMapping(TestGeo, "test_poly.shp", mapping) >>> lm.save(verbose=True) # Save the layermap, imports the data. Saved: Name: 1 Saved: Name: 2 Saved: Name: 3 [755a4f10]
- GIS data sources, like shapefiles, may be very large. If you find that :class:`LayerMapping` is using too much memory, set :setting:`DEBUG` to ``False`` in your settings. When :setting:`DEBUG` is set to ``True``, Django :ref:`automatically logs <faq-see-raw-sql-queries>` *every* SQL query -- and when SQL statements contain geometries, this may consume more memory than is typical. [eb0fb536]
- OperationalError: (1153, "Got a packet bigger than 'max_allowed_packet' bytes") [f5e714f0]
- Use of :class:`LayerMapping` requires GDAL. [8dc35f88]
- class TestGeo(models.Model): name = models.CharField(max_length=25) # corresponds to the 'str' field poly = models.PolygonField(srid=4269) # we want our model in a different SRID [eb92d9ee]
- from django.contrib.gis.db import models [bc102196f7767c3e-2]
- max_allowed_packet = 10M [5a914b1b]
- #. Now we define our corresponding Django model (make sure to use :djadmin:`migrate`):: [6f098faa]
- #. Use :class:`LayerMapping` to extract all the features and place them in the database: [a8306a16]
- #. You need a GDAL-supported data source, like a shapefile (here we're using a simple polygon shapefile, ``test_poly.shp``, with three features): [3ffe0f34]
- .. class:: LayerMapping(model, data_source, mapping, layer=0, source_srs=None, encoding=None, transaction_mode='commit_on_success', transform=True, unique=True, using='default') [8e5ef5d8]
- .. code-block:: ini [ab16e0aa61fdec9d-4]
- .. code-block:: pycon [eaf050be34acb41d-178]
- .. code-block:: pycon [eaf050be34acb41d-179]
- .. code-block:: pytb [fccd37de02dbdecc-5]
- .. currentmodule:: django.contrib.gis.utils [bb0075f5955ee7c2]
- .. method:: LayerMapping.save(verbose=False, fid_range=False, step=False, progress=False, silent=False, stream=sys.stdout, strict=False) [f3e516c4]
- .. module:: django.contrib.gis.utils.layermapping :synopsis: Spatial data import utility for GeoDjango models. [5d882e1f]
- .. note:: [942ae6c11625c81c-66]

## All facts

- [a004f02b] .. warning ::
- [7df7c3d8] ================= ========================================================= Argument Description ================= ========================================================= ``model`` The geographic model, *not* an instance.
- [b4bff42c] ===================== ===================================================== Keyword Arguments ===================== ===================================================== ``layer`` The index of the layer to use from the Data Source (defaults to 0)
- [2849ecb8] =========================== ================================================= Save Keyword Arguments Description =========================== ================================================= ``fid_range`` May be set with a slice or tuple of (begin, end) feature ID's to map from the data source. In other words, this keyword enables the user to selectively import a subset range of features in the geographic data source.
- [6f936fb3] ==================================== ``LayerMapping`` data import utility ====================================
- [63e79bb1] As noted in the warning at the top of this section, Django stores all SQL queries when ``DEBUG=True``. Set ``DEBUG=False`` in your settings, and this should stop excessive memory use when running ``LayerMapping`` scripts.
- [cf1461d9a1a7899c-3] Example =======
- [5612b493] Here, :class:`LayerMapping` transformed the three geometries from the shapefile in their original spatial reference system (WGS84) to the spatial reference system of the GeoDjango model (NAD83). If no spatial reference system is defined for the layer, use the ``source_srs`` keyword with a :class:`~django.contrib.gis.gdal.SpatialReference` object to specify one.
- [0d8128cf] If you encounter the following error when using ``LayerMapping`` and MySQL:
- [406bcbfa] MySQL: ``max_allowed_packet`` error -----------------------------------
- [7fcbd3dc] Running out of memory ---------------------
- [c1970674] The :class:`LayerMapping` class provides a way to map the contents of vector spatial data files (e.g. shapefiles) into GeoDjango models.
- [fde2d8ff] The ``save()`` method also accepts keywords. These keywords are used for controlling output logging, error handling, and for importing specific feature ranges.
- [35d073d6] The following are the arguments and keywords that may be used during instantiation of ``LayerMapping`` objects.
- [7805adea] Then the solution is to increase the value of the ``max_allowed_packet`` setting in your MySQL configuration. For example, the default value may be something low like one megabyte -- the setting may be modified in MySQL's configuration file (``my.cnf``) in the ``[mysqld]`` section:
- [45f1e701] This utility grew out of the author's personal needs to eliminate the code repetition that went into pulling geometries and fields out of a vector layer, converting to another coordinate system (e.g. WGS84), and then inserting into a GeoDjango model.
- [9bd7b303e940ce88-3] Troubleshooting ===============
- [e9275a1e] ``LayerMapping`` API ====================
- [68659160] ``data_source`` The path to the OGR-supported data source file (e.g., a shapefile). Also accepts :class:`django.contrib.gis.gdal.DataSource` instances.
- [8f0e4aeb] ``encoding`` Specifies the character set encoding of the strings in the OGR data source. For example, ``'latin-1'``, ``'utf-8'``, and ``'cp437'`` are all valid encoding parameters.
- [d59b1dc8] ``mapping`` A dictionary: keys are strings corresponding to the model field, and values correspond to string field names for the OGR feature, or if the model field is a geographic then it should correspond to the OGR geometry type, e.g., ``'POINT'``, ``'LINESTRING'``, ``'POLYGON'``. ================= =========================================================
- [adae36e3] ``progress`` When this keyword is set, status information will be printed giving the number of features processed and successfully saved. By default, progress information will be printed every 1000 features processed, however, this default may be overridden by setting this keyword with an integer for the desired interval.
- [a5f3c9cc] ``save()`` Keyword Arguments ----------------------------
- [97bfb4c6] ``silent`` By default, non-fatal error notifications are printed to ``sys.stdout``, but this keyword may be set to disable these notifications.
- [8b0f818b] ``source_srs`` Use this to specify the source SRS manually (for example, some shapefiles don't come with a ``'.prj'`` file). An integer SRID, WKT or PROJ strings, and :class:`django.contrib.gis.gdal.SpatialReference` objects are accepted.
- [71b996da] ``step`` If set with an integer, transactions will occur at every step interval. For example, if ``step=1000``, a commit would occur after the 1,000th feature, the 2,000th feature etc.
- [0ffb4d1d] ``stream`` Status information will be written to this file handle. Defaults to using ``sys.stdout``, but any object with a ``write`` method is supported.
- [833bdc86] ``strict`` Execution of the model mapping will cease upon the first error encountered. The default value (``False``) behavior is to attempt to continue.
- [464c421a] ``transaction_mode`` May be ``'commit_on_success'`` (default) or ``'autocommit'``.
- [039cc309] ``transform`` Setting this to False will disable coordinate transformations. In other words, geometries will be inserted into the database unmodified from their original state in the data source.
- [cccd00c3] ``unique`` Setting this to the name, or a tuple of names, from the given model will create models unique only to the given name(s). Geometries from each feature will be added into the collection associated with the unique model. Forces the transaction mode to be ``'autocommit'``.
- [2135c11b] ``using`` Sets the database to use when importing spatial data. Default is ``'default'``. ===================== =====================================================
- [c1ecba65] ``verbose`` If set, information will be printed subsequent to each model save executed on the database. =========================== =================================================
