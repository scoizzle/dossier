# docs/ref/contrib/gis/serializers

- Subject: docs/ref/contrib/gis/serializers (id `cd159573-3ed5-498c-8127-1c893537b6bc`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 696 tokens
- Facts shown: 16 of 16
- Conflicts: 0
- Gaps: 0

## Facts

- from django.core.serializers import serialize from my_app.models import City [a5ec7661]
- serialize("geojson", City.objects.all(), geometry_field="point", fields=["name"]) [6af6814f]
- { "type": "FeatureCollection", "features": [ { "type": "Feature", "id": 1, "geometry": {"type": "Point", "coordinates": [-87.650175, 41.850385]}, "properties": {"name": "Chicago"}, } ], } [8e051f68]
- * ``geometry_field``: A string containing the name of a geometry field to use for the ``geometry`` key of the GeoJSON feature. This is only needed when you have a model with more than one geometry field and you don't want to use the first defined geometry field (by default, the first geometry field is picked). [65426cc3]
- * ``id_field``: A string containing the name of a field to use for the ``id`` key of the GeoJSON feature. By default, the primary key of objects is used. [7f1f6665]
- * ``srid``: The SRID to use for the ``geometry`` content. Defaults to 4326 (WGS 84). [75f4cf11]
- .. module:: django.contrib.gis.serializers.geojson :synopsis: Serialization of GeoDjango models in the GeoJSON format. [9b99ebff]
- ====================== ``GeoJSON`` Serializer ====================== [990048ff]
- Example:: [acfcf117f82fd4c9-38]
- GeoDjango provides a specific serializer for the `GeoJSON`__ format. See :doc:`/topics/serialization` for more information on serialization. [a501cd17]
- In addition to the options of the ``json`` serializer, the ``geojson`` serializer accepts the following additional option when it is called by ``serializers.serialize()``: [98f2fb26]
- The :ref:`fields <subset-of-fields>` option can be used to limit fields that will be present in the ``properties`` key, as it works with all other serializers. [9ca5d90e]
- The ``geojson`` serializer is not meant for round-tripping data, as it has no deserializer equivalent. For example, you cannot use :djadmin:`loaddata` to reload the output produced by this serializer. If you plan to reload the outputted data, use the plain :ref:`json serializer <serialization-formats-json>` instead. [79d6b58f]
- When the ``fields`` parameter is not specified, the ``geojson`` serializer adds a ``pk`` key to the ``properties`` dictionary with the primary key of the object as the value. [d25d5b89]
- Would output:: [7f36e936]
- __ https://geojson.org/ [06a4177e45ae5e2f-2]
