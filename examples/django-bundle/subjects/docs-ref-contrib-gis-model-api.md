# docs/ref/contrib/gis/model-api

- Subject: docs/ref/contrib/gis/model-api (id `b91d31c4-ab03-4ae2-bb62-37c19edaa22d`)
- Kind: subject
- Budget: 1200 tokens
- Used: 893 tokens
- Facts shown: 33 of 86
- Conflicts: 0
- Gaps: 0

## Facts

- At this time 3D support is limited to the PostGIS and SpatiaLite backends. [71787a4b]
- Geography support is limited to PostGIS and will force the SRID to be 4326. [0c41a9bc]
- If you wish to perform arbitrary distance queries using non-point geometries in WGS84 in PostGIS and you want decent performance, enable the :attr:`GeometryField.geography` keyword so that :ref:`geography database type <geography-type>` is used instead. [07010743]
- This is different from the ``db_index`` field option because spatial indexes are created in a different manner than regular database indexes. Specifically, spatial indexes are typically created using a variant of the R-Tree, while regular database indexes typically use B-Trees. [85191000]
- Zipcode.objects.annotate(geom=Cast("geography_field", PointField())).filter( geom__within=poly ) [038cd3f1]
- class Elevation(models.Model): name = models.CharField(max_length=100) rast = models.RasterField() [bf6b7050]
- class Zipcode(models.Model): code = models.CharField(max_length=5) poly = models.PolygonField() [d7ffca26]
- from django.contrib.gis.db import models [bc102196f7767c3e-3]
- from django.contrib.gis.db.models import PointField from django.db.models.functions import Cast [38ca27cd]
- * :lookup:`bboverlaps` * :lookup:`coveredby` * :lookup:`covers` * :lookup:`intersects` [183fe6f7]
- * `spatialreference.org`__: A database of spatial reference systems. * `The State Plane Coordinate System`__: A website covering the various projection systems used in the United States. Much of the U.S. spatial data encountered will be in one of these coordinate systems rather than in a geographic coordinate system such as WGS84. [8aa260fa]
- .. _geography-type: [593fcea8]
- .. _geometry-field-options: [c9a562f9]
- .. _selecting-an-srid: [8d7105da]
- .. attribute:: BaseSpatialField.spatial_index [329e9bcc]
- .. attribute:: BaseSpatialField.srid [810479b7]
- .. attribute:: GeometryField.dim [7b8cf7ee]
- .. attribute:: GeometryField.geography [04fdf125]
- .. attribute:: GeometryField.max_geom_collections [b0f4c9bd]
- .. class:: GeometryCollectionField [160d780b6ce6fd6c-2]
- .. class:: GeometryField [3983ea1ab09d5868-2]
- .. class:: LineStringField [977fb9b7a523e42f-2]
- .. class:: MultiLineStringField [bbf614d2ad7f98a6-2]
- .. class:: MultiPointField [05cf772aa4fe68a8-2]
- .. class:: MultiPolygonField [1365f1b7479fa4fc-2]
- .. class:: PointField [1c408a7f583703aa-2]
- .. class:: PolygonField [28d5de5a729e7af3-2]
- .. class:: RasterField [6ab720db]
- .. module:: django.contrib.gis.db.models :synopsis: GeoDjango model and field API. [8fe13e62]
- .. note:: [942ae6c11625c81c-68]
- .. note:: [942ae6c11625c81c-69]
- .. note:: [942ae6c11625c81c-70]
- .. note:: [942ae6c11625c81c-71]

## Beyond the budget

53 more facts did not fit in the budget: [95108d35] [66f6072d] [31ce4140] [1f3d8520] [95d35582] [0f6f471e] [b0ea95b9] [da181879] [1e7b747e] [034ec2d4] [b929e212] [7e52ae7b] [91103e58] [5e35c7e4] [b67c5568] [7e9b112a] [49a7ba71] [5af6d37f] [4d9dccf9] [80845b2d] [6a0b168b] [5719f55b] [673eaf05] [d3d25aa5] [c9c6f1de] [ab6d2d6d] [21cd8774] [311fa26a] [5ada5b8f] [9d188430] [fa74b064] [53a575c4] [cce67b27] [9f455ad4] [95acb724] [ee64e804] [1291ddee] [8ed37e5a] [3d1cd0ed68e7ef60-2] [6c06d2aefdf0cb8d-2] [442fee6fb28555e8-2] [9f19b9320977b49c-2] [0479ce898ba8a6e9-2] [2538f7a50bc0b974-2] [88b43530d52f6112-2] [f5cb4fc6fec3fdd7-2] [fbf3e70d] [3de8e13a] [b4c3006e] [3fe43898] [f2a7c32a6ae7776e-2] [0ea72560] [d57521a189731a2a-2]
