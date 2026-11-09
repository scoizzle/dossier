# django/contrib/contenttypes/models

- Subject: django/contrib/contenttypes/models (id `353ec3e2-d90e-4840-833c-0c93c6f3829c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 884 tokens
- Facts shown: 14 of 22
- Conflicts: 0
- Gaps: 0

## Facts

- # The ContentType entry was not found in the cache, therefore we # proceed to load or create it. try: # Start with get() and not get_or_create() in order to use # the db_for_read (see #20401). ct = self.get(app_label=opts.app_label, model=opts.model_name) except self.model.DoesNotExist: # Not found in the database; we proceed to create it. This time # use get_or_create to take care of any race conditions. ct, created = self.get_or_create( app_label=opts.app_label, model=opts.model_name, ) self._add_to_cache(self.db, ct) return ct [48c37ab8]
- @property def app_labeled_name(self): model = self.model_class() if not model: return "%s | %s" % (self.app_label, self.model) return "%s | %s" % ( model._meta.app_config.verbose_name, model._meta.verbose_name, ) [630d6914]
- @property def name(self): model = self.model_class() if not model: return self.model return str(model._meta.verbose_name) [4fa0c5a3]
- class Meta: verbose_name = _("content type") verbose_name_plural = _("content types") db_table = "django_content_type" unique_together = [["app_label", "model"]] [a9cc32b4]
- def __init__(self, *args, **kwargs): super().__init__(*args, **kwargs) # Cache shared by all the get_for_* methods to speed up # ContentType retrieval. self._cache = {} [02571384]
- def __str__(self): return self.app_labeled_name [dc6fd33b]
- def _add_to_cache(self, using, ct): """Insert a ContentType into the cache.""" # Note it's possible for ContentType objects to be stale; model_class() # will return None. Hence, there is no reliance on # model._meta.app_label here, just using the model fields instead. key = (ct.app_label, ct.model) self._cache.setdefault(using, {})[key] = ct self._cache.setdefault(using, {})[ct.id] = ct [3addf016]
- def _get_from_cache(self, opts): key = (opts.app_label, opts.model_name) return self._cache[self.db][key] [5fd0cb77]
- def _get_opts(self, model, for_concrete_model): if for_concrete_model: model = model._meta.concrete_model return model._meta [94319138]
- def clear_cache(self): """ Clear out the content-type cache. """ self._cache.clear() [73e4b976]
- def get_all_objects_for_this_type(self, **kwargs): """ Return all objects of this type for the keyword arguments given. """ return self.model_class()._base_manager.filter(**kwargs) [9008e94d]
- def get_by_natural_key(self, app_label, model): try: ct = self._cache[self.db][(app_label, model)] except KeyError: ct = self.get(app_label=app_label, model=model) self._add_to_cache(self.db, ct) return ct [d8fbcb77]
- def get_for_id(self, id): """ Lookup a ContentType by ID. Use the same shared cache as get_for_model (though ContentTypes are not created on-the-fly by get_by_id). """ try: ct = self._cache[self.db][id] except KeyError: # This could raise a DoesNotExist; that's correct behavior and will # make sure that only correct ctypes get stored in the cache dict. ct = self.get(pk=id) self._add_to_cache(self.db, ct) return ct [8a7843c0]
- def model_class(self): """Return the (optional) model class for this type of content.""" try: return apps.get_model(self.app_label, self.model) except LookupError: return None [47b6050d]

## Beyond the budget

8 more facts did not fit in the budget: [77f17650] [5d02c31d] [9b202a7c] [91f40cf0] [752b768a] [9333582c] [f148a1ba] [3fec5467]
