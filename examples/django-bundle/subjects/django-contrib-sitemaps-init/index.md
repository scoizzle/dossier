# django/contrib/sitemaps/__init__

- Subject: django/contrib/sitemaps/__init__ (id `041b9558-6c62-4ef1-95d7-36e70c52909e`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1610 tokens
- Facts shown: 32 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- if all_items_lastmod: all_items_lastmod = lastmod is not None if all_items_lastmod and ( latest_lastmod is None or lastmod > latest_lastmod ): latest_lastmod = lastmod [9b9509b2]
- if self.i18n and self.alternates: item_languages = self.get_languages_for_item(item[0]) for lang_code in item_languages: loc = f"{protocol}://{domain}{self._location(item, lang_code)}" url_info["alternates"].append( { "location": loc, "lang_code": lang_code, } ) if self.x_default and settings.LANGUAGE_CODE in item_languages: lang_code = settings.LANGUAGE_CODE loc = f"{protocol}://{domain}{self._location(item, lang_code)}" loc = loc.replace(f"/{lang_code}/", "/", 1) url_info["alternates"].append( { "location": loc, "lang_code": "x-default", } ) [76474af8]
- url_info = { "item": item, "location": loc, "lastmod": lastmod, "changefreq": self._get("changefreq", item), "priority": str(priority if priority is not None else ""), "alternates": [], } [5233cb2f]
- urls.append(url_info) [b8001792]
- if all_items_lastmod and latest_lastmod: self.latest_lastmod = latest_lastmod [962fd6fa]
- paginator_page = self.paginator.page(page) for item in paginator_page.object_list: loc = f"{protocol}://{domain}{self._location(item)}" priority = self._get("priority", item) lastmod = self._get("lastmod", item) [03431c61]
- return urls [b980958a]
- # Add an alternate/hreflang link with value 'x-default'. x_default = False [3271f4c5]
- # Enables generating URLs for all languages. i18n = False [468ceec8]
- # Enables generating alternate/hreflang links. alternates = False [df752de4]
- # If protocol is None, the URLs in the sitemap will use the protocol # with which the sitemap was requested. protocol = None [c1fa69bc]
- # Override list of languages to use. languages = None [8fa8da19]
- @property def paginator(self): return paginator.Paginator(self._items(), self.limit) [0e07dc89]
- def __init__(self, info_dict, priority=None, changefreq=None, protocol=None): self.queryset = info_dict["queryset"] self.date_field = info_dict.get("date_field") self.priority = self.priority or priority self.changefreq = self.changefreq or changefreq self.protocol = self.protocol or protocol [c9061ec1]
- def _get(self, name, item, default=None): try: attr = getattr(self, name) except AttributeError: return default if callable(attr): if self.i18n: # Split the (item, lang_code) tuples again for the location, # priority, lastmod and changefreq method calls. item, lang_code = item return attr(item) return attr [f3a2ce2b]
- def _items(self): if self.i18n: # Create (item, lang_code) tuples for all items and languages. # This is necessary to paginate with all languages already # considered. items = [ (item, lang_code) for item in self.items() for lang_code in self.get_languages_for_item(item) ] return items return self.items() [5284f37c]
- def _languages(self): if self.languages is not None: return self.languages return [lang_code for lang_code, _ in settings.LANGUAGES] [86645ae0]
- def items(self): return [] [77c7b4ed]

## All facts

- [987560bc] def _location(self, item, force_lang_code=None): if self.i18n: obj, lang_code = item # Activate language from item-tuple or forced one before calling # location. with translation.override(force_lang_code or lang_code): return self._get("location", item) return self._get("location", item)
- [f7c195d5] def _urls(self, page, protocol, domain): urls = [] latest_lastmod = None all_items_lastmod = True # track if all items have a lastmod
- [85f3cffd] def get_domain(self, site=None): # Determine domain if site is None: if django_apps.is_installed("django.contrib.sites"): Site = django_apps.get_model("sites.Site") try: site = Site.objects.get_current() except Site.DoesNotExist: pass if site is None: raise ImproperlyConfigured( "To use sitemaps, either enable the sites framework or pass " "a Site/RequestSite object in your view." ) return site.domain
- [ac8e2c99] def get_languages_for_item(self, item): """Languages for which this item is displayed.""" return self._languages()
- [9a0dee3b] def get_latest_lastmod(self): if not hasattr(self, "lastmod"): return None if callable(self.lastmod): try: return max([self.lastmod(item) for item in self.items()], default=None) except TypeError: return None else: return self.lastmod
- [c8e6fec5] def get_latest_lastmod(self): if self.date_field is not None: return ( self.queryset.order_by("-" + self.date_field) .values_list(self.date_field, flat=True) .first() ) return None
- [82a61ed5] def get_protocol(self, protocol=None): # Determine protocol return self.protocol or protocol or "https"
- [77708090] def get_urls(self, page=1, site=None, protocol=None): protocol = self.get_protocol(protocol) domain = self.get_domain(site) return self._urls(page, protocol, domain)
- [5f1679ea] def items(self): # Make sure to return a clone; we don't want premature evaluation. return self.queryset.filter()
- [6dcea328] def lastmod(self, item): if self.date_field is not None: return getattr(item, self.date_field) return None
- [9b5f45e5] def location(self, item): return item.get_absolute_url()
- [ba8a74bc] class GenericSitemap(Sitemap): priority = None changefreq = None
- [f891c4e8] class Sitemap: # This limit is defined by Google. See the index documentation at # https://www.sitemaps.org/protocol.html#index. limit = 50000
- [56fad2f5] from django.apps import apps as django_apps from django.conf import settings from django.core import paginator from django.core.exceptions import ImproperlyConfigured from django.utils import translation
