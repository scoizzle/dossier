# django/contrib/sitemaps/__init__

- Subject: django/contrib/sitemaps/__init__ (id `565945fe-4c14-4ba2-8e88-3b58a9121d60`)
- Kind: subject
- Budget: 1200 tokens
- Used: 882 tokens
- Facts shown: 18 of 32
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

14 more facts did not fit in the budget: [987560bc] [f7c195d5] [85f3cffd] [ac8e2c99] [9a0dee3b] [c8e6fec5] [82a61ed5] [77708090] [5f1679ea] [6dcea328] [9b5f45e5] [ba8a74bc] [f891c4e8] [56fad2f5]
