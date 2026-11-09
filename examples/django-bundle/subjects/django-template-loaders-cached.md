# django/template/loaders/cached

- Subject: django/template/loaders/cached (id `6081e97d-994a-4366-8c90-68338a03d22c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 885 tokens
- Facts shown: 18 of 20
- Conflicts: 0
- Gaps: 0

## Facts

- x -> a -> a y -> a -> a z -> a -> a """ skip_prefix = "" [3521013a]
- If skip is provided, only origins that match template_name are included in the cache key. This ensures each template is only parsed and cached once if contained in different extend chains like: [1f9ebddf]
- With template debugging disabled, cache the TemplateDoesNotExist class for every missing template and raise a new instance of it after fetching it from the cache. [2a9afec8]
- With template debugging enabled, a unique TemplateDoesNotExist object is cached for each missing template to preserve debug data. When raising an exception, Python sets __traceback__, __context__, and __cause__ attributes on it. Those attributes can contain references to all sorts of objects up the call chain and caching them creates a memory leak. Thus, unraised copies of the exceptions are cached and copies of those copies are raised after they're fetched from the cache. """ key = self.cache_key(template_name, skip) cached = self.get_template_cache.get(key) if cached: if isinstance(cached, type) and issubclass(cached, TemplateDoesNotExist): raise cached(template_name) elif isinstance(cached, TemplateDoesNotExist): raise copy_exception(cached) return cached [3c45e5da]
- if skip: matching = [ origin.name for origin in skip if origin.template_name == template_name ] if matching: skip_prefix = self.generate_hash(matching) [4d15d72e]
- return "-".join(s for s in (str(template_name), skip_prefix) if s) [c20b53d1]
- return template [7656ce01]
- try: template = super().get_template(template_name, skip) except TemplateDoesNotExist as e: self.get_template_cache[key] = ( copy_exception(e) if self.engine.debug else TemplateDoesNotExist ) raise else: self.get_template_cache[key] = template [c2f21d11]
- def cache_key(self, template_name, skip=None): """ Generate a cache key for the template name and skip. [abeb19c4]
- def generate_hash(self, values): return hashlib.sha1("|".join(values).encode()).hexdigest() [8fa5a1b8]
- def get_contents(self, origin): return origin.loader.get_contents(origin) [b564b15e]
- def get_dirs(self): for loader in self.loaders: if hasattr(loader, "get_dirs"): yield from loader.get_dirs() [237dad0d]
- def get_template(self, template_name, skip=None): """ Perform the caching that gives this loader its name. Often many of the templates attempted will be missing, so memory use is of concern here. To keep it in check, caching behavior is a little complicated when a template is not found. See ticket #26306 for more details. [07690699]
- def get_template_sources(self, template_name): for loader in self.loaders: yield from loader.get_template_sources(template_name) [875162f4]
- def reset(self): "Empty the template cache." self.get_template_cache.clear() [dbd3708b]
- """ Wrapper class that takes a list of template loaders as an argument and attempts to load templates from them in order, caching the result. """ [4281cbb6]
- from .base import Loader as BaseLoader [ce213ae266df5867]
- import hashlib [60ac2b4f]

## Beyond the budget

2 more facts did not fit in the budget: [2611c3ef] [d87bfbfe]
