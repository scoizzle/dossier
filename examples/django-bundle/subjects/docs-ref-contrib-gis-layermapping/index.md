# docs/ref/contrib/gis/layermapping

- Subject: docs/ref/contrib/gis/layermapping (id `19dc6c6e-1e7a-4a9b-8372-1b8e22a7fe27`)
- Kind: subject
- Budget: 1200 tokens
- Used: 894 tokens
- Facts shown: 21 of 54
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

33 more facts did not fit in the budget: [a004f02b] [7df7c3d8] [b4bff42c] [2849ecb8] [6f936fb3] [63e79bb1] [cf1461d9a1a7899c-3] [5612b493] [0d8128cf] [406bcbfa] [7fcbd3dc] [c1970674] [fde2d8ff] [35d073d6] [7805adea] [45f1e701] [9bd7b303e940ce88-3] [e9275a1e] [68659160] [8f0e4aeb] [d59b1dc8] [adae36e3] [a5f3c9cc] [97bfb4c6] [8b0f818b] [71b996da] [0ffb4d1d] [833bdc86] [464c421a] [039cc309] [cccd00c3] [2135c11b] [c1ecba65]
