# django/contrib/gis/management/commands/inspectdb

- Subject: django/contrib/gis/management/commands/inspectdb (id `ea96f4fd-7290-4e08-bcdf-106ce3b9d6fb`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 189 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- def get_field_type(self, connection, table_name, row): field_type, field_params, field_notes = super().get_field_type( connection, table_name, row ) if field_type == "GeometryField": # Getting a more specific field type and any additional parameters # from the `get_geometry_type` routine for the spatial backend. field_type, geo_params = connection.introspection.get_geometry_type( table_name, row ) field_params.update(geo_params) return field_type, field_params, field_notes [3cab632d]
- class Command(InspectDBCommand): db_module = "django.contrib.gis.db" [5dbc64d9]
- from django.core.management.commands.inspectdb import Command as InspectDBCommand [6f333326]
