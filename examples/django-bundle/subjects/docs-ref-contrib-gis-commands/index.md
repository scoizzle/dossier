# docs/ref/contrib/gis/commands

- Subject: docs/ref/contrib/gis/commands (id `dcb9ca85-4c95-43c1-bec7-f6ba1fcd551f`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 944 tokens
- Facts shown: 26 of 27
- Conflicts: 0
- Gaps: 0

## Highlights

- Automatically generate a mapping dictionary for use with :class:`~django.contrib.gis.utils.LayerMapping`. [cf72d4e2]
- Generates a ``__str__()`` method on the model that returns the given field name. [232d669f]
- Specifies the model attribute name to use for the geometry field. Defaults to ``'geom'``. [4467e5f3]
- Suppresses the ``from django.contrib.gis.db import models`` import statement. [59df918f]
- The SRID to use for the geometry field. If not set, ``ogrinspect`` attempts to automatically determine the SRID of the data source. [ad0e4295]
- The key for specifying which layer in the OGR :class:`~django.contrib.gis.gdal.DataSource` source to use. Defaults to 0 (the first layer). May be an integer or a string identifier for the :class:`~django.contrib.gis.gdal.Layer`. When inspecting databases, ``layer`` is generally the table name you want to inspect. [9ea5654e]
- Use a comma separated list of OGR field names to add the ``blank=True`` keyword option to the field definition. Set with ``true`` to apply to all applicable fields. [ee8f0cb2]
- Use a comma separated list of OGR float fields to generate :class:`~django.db.models.DecimalField` instead of the default :class:`~django.db.models.FloatField`. Set to ``true`` to apply to all OGR float fields. [e4feb5d9]
- When generating the geometry field, treat it as a geometry collection. For example, if this setting is enabled then a :class:`~django.contrib.gis.db.models.MultiPolygonField` will be placed in the generated model rather than :class:`~django.contrib.gis.db.models.PolygonField`. [9852a1e0]
- .. describe:: django-admin inspectdb [28a5f6ee]
- .. django-admin-option:: --blank BLANK [6c32f49b]
- .. django-admin-option:: --decimal DECIMAL [0a571cae]
- .. django-admin-option:: --geom-name GEOM_NAME [516600b9]
- .. django-admin-option:: --layer LAYER_KEY [67029f5f]
- .. django-admin-option:: --mapping [2f15d41e]
- .. django-admin-option:: --multi-geom [0c117325]
- .. django-admin-option:: --name-field NAME_FIELD [67236524]
- .. django-admin-option:: --no-imports [0c08422fcf6cb441]
- .. django-admin-option:: --null NULL [cde52ac6]
- .. django-admin-option:: --srid SRID [7c042185]
- .. django-admin:: ogrinspect data_source model_name [c7c36272]
- ============================= GeoDjango Management Commands ============================= [38e63aca]
- The ``ogrinspect`` management command will inspect the given OGR-compatible :class:`~django.contrib.gis.gdal.DataSource` (e.g., a shapefile) and will output a GeoDjango model with the given model name. There's a detailed example of using ``ogrinspect`` :ref:`in the tutorial <ogrinspect-intro>`. [147e2ee5]
- ``inspectdb`` ============= [55982dc7]
- ``ogrinspect`` ============== [179313f0c34e8b4c]

## All facts

- [642f71ac] When :mod:`django.contrib.gis` is in your :setting:`INSTALLED_APPS`, the :djadmin:`inspectdb` management command is overridden with one from GeoDjango. The overridden command is spatially-aware, and places geometry fields in the auto-generated model definition, where appropriate.
