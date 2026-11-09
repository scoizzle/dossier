# django/contrib/gis/apps

- Subject: django/contrib/gis/apps (id `c86d6932-a6e8-44b9-aaa5-6074d8bcce63`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 163 tokens
- Facts shown: 4 facts
- Conflicts: 0
- Gaps: 0

## Facts

- def ready(self): serializers.BUILTIN_SERIALIZERS.setdefault( "geojson", "django.contrib.gis.serializers.geojson" ) checks.register(check_gdal_39, checks.Tags.gis, checks.Tags.security) [c189ce62]
- class GISConfig(AppConfig): default_auto_field = "django.db.models.AutoField" name = "django.contrib.gis" verbose_name = _("GIS") [e5554be7]
- from .checks import check_gdal_39 [a1c83bba]
- from django.apps import AppConfig from django.core import checks, serializers from django.utils.translation import gettext_lazy as _ [1f7cb428]
