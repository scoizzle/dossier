# django/contrib/contenttypes/models

- Subject: django/contrib/contenttypes/models (id `3131da00-62ea-4d1b-89d6-f17a423760ef`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1587 tokens
- Facts shown: 22 facts
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [77f17650] def get_for_model(self, model, for_concrete_model=True): """ Return the ContentType object for a given model, creating the ContentType if necessary. Lookups are cached so that subsequent lookups for the same model don't hit the database. """ opts = self._get_opts(model, for_concrete_model) try: return self._get_from_cache(opts) except KeyError: pass
- [5d02c31d] def get_for_models(self, *models, for_concrete_models=True): """ Given *models, return a dictionary mapping {model: content_type}. """ results = {} # Models that aren't already in the cache grouped by app labels. needed_models = defaultdict(set) # Mapping of opts to the list of models requiring it. needed_opts = defaultdict(list) for model in models: opts = self._get_opts(model, for_concrete_models) try: ct = self._get_from_cache(opts) except KeyError: needed_models[opts.app_label].add(opts.model_name) needed_opts[(opts.app_label, opts.model_name)].append(model) else: results[model] = ct if needed_opts: # Lookup required content types from the DB. condition = Q( *( Q(("app_label", app_label), ("model__in", models)) for app_label, models in needed_models.items() ), _connector=Q.OR, ) cts = self.filter(condition) for ct in cts: opts_models = needed_opts.pop((ct.app_label, ct.model), []) for model in opts_models: results[model] = ct self._add_to_cache(self.db, ct) # Create content types that weren't in the cache or DB. for (app_label, model_name), opts_models in needed_opts.items(): ct = self.create(app_label=app_label, model=model_name) self._add_to_cache(self.db, ct) for model in opts_models: results[model] = ct return results
- [9b202a7c] def get_object_for_this_type(self, using=None, **kwargs): """ Return an object of this type for the keyword arguments given. Basically, this is a proxy around this object_type's get_object() model method. The ObjectNotExist exception, if thrown, will not be caught, so code that calls this method should catch it. """ return self.model_class()._base_manager.using(using).get(**kwargs)
- [91f40cf0] def natural_key(self): return (self.app_label, self.model)
- [752b768a] class ContentType(models.Model): app_label = models.CharField(max_length=100) model = models.CharField(_("python model class name"), max_length=100) objects = ContentTypeManager()
- [9333582c] class ContentTypeManager(models.Manager): use_in_migrations = True
- [f148a1ba] from collections import defaultdict
- [3fec5467] from django.apps import apps from django.db import models from django.db.models import Q from django.utils.translation import gettext_lazy as _
