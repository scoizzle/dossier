# django/contrib/gis/sitemaps/kml

- Subject: django/contrib/gis/sitemaps/kml (id `340cc419-7a67-4198-a495-da7a7fbd75ba`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 561 tokens
- Facts shown: 10 facts
- Conflicts: 0
- Gaps: 0

## Facts

- If no sources are provided, then all models. """ kml_sources = [] if sources is None: sources = apps.get_models() for source in sources: if isinstance(source, models.base.ModelBase): for field in source._meta.fields: if isinstance(field, GeometryField): kml_sources.append( ( source._meta.app_label, source._meta.model_name, field.name, ) ) elif isinstance(source, (list, tuple)): if len(source) != 3: raise ValueError( "Must specify a 3-tuple of (app_label, module_name, " "field_name)." ) kml_sources.append(source) else: raise TypeError("KML Sources must be a model or a 3-tuple.") return kml_sources [d1b09b83]
- def __init__(self, locations=None): # If no locations specified, then we try to build for # every model in installed applications. self.locations = self._build_kml_sources(locations) [f70a8b35]
- def _build_kml_sources(self, sources): """ Go through the given sources and return a 3-tuple of the application label, module name, and field name of every GeometryField encountered in the sources. [90ca5585]
- def get_urls(self, page=1, site=None, protocol=None): """ This method is overridden so the appropriate `geo_format` attribute is placed on each URL element. """ urls = Sitemap.get_urls(self, page=page, site=site, protocol=protocol) for url in urls: url["geo_format"] = self.geo_format return urls [1c5b3e41]
- def items(self): return self.locations [17b9d3de]
- def location(self, obj): return reverse( "django.contrib.gis.sitemaps.views.%s" % self.geo_format, kwargs={ "label": obj[0], "model": obj[1], "field_name": obj[2], }, ) [bb914310]
- geo_format = "kml" [2546fbd9]
- class KMLSitemap(Sitemap): """ A minimal hook to produce KML sitemaps. """ [1c68b004]
- class KMZSitemap(KMLSitemap): geo_format = "kmz" [7cff8e29]
- from django.apps import apps from django.contrib.gis.db.models import GeometryField from django.contrib.sitemaps import Sitemap from django.db import models from django.urls import reverse [17eef86a]
