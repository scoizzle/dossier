# django/contrib/gis/utils/__init__

- Subject: django/contrib/gis/utils/__init__ (id `ac59227d-2921-480a-83ce-2f27658a1758`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 136 tokens
- Facts shown: 3 facts
- Conflicts: 0
- Gaps: 0

## Facts

- """ This module contains useful utilities for GeoDjango. """ [f6e095e9]
- __all__ = [ "add_srs_entry", "mapping", "ogrinfo", "ogrinspect", "LayerMapError", "LayerMapping", ] [c91c6b2f]
- from django.contrib.gis.utils.layermapping import LayerMapError, LayerMapping from django.contrib.gis.utils.ogrinfo import ogrinfo from django.contrib.gis.utils.ogrinspect import mapping, ogrinspect from django.contrib.gis.utils.srs import add_srs_entry [cf668eee]
