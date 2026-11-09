# django/db/models/options

- Subject: django/db/models/options (id `76c65042-43b8-4340-8e73-95bfd2375e7f`)
- Kind: subject
- Budget: 1200 tokens
- Used: 889 tokens
- Facts shown: 12 of 102
- Conflicts: 0
- Gaps: 0

## Facts

- if ( "%s.%s" % (swapped_label, swapped_object.lower()) != self.label_lower ): return swapped_for return None [d769a033]
- manager = copy.copy(manager) manager.model = self.model seen_managers.add(manager.name) managers.append((depth, manager.creation_counter, manager)) [8df4c64e]
- # Any leftover attributes must be invalid. if meta_attrs != {}: raise TypeError( "'class Meta' got invalid attribute(s): %s" % ",".join(meta_attrs) ) else: self.verbose_name_plural = format_lazy("{}s", self.verbose_name) del self.meta [ae8f3863]
- # order_with_respect_to and ordering are mutually exclusive. self._ordering_clash = bool(self.ordering and self.order_with_respect_to) [0c9dc37a]
- # verbose_name_plural is a special case because it uses a 's' # by default. if self.verbose_name_plural is None: self.verbose_name_plural = format_lazy("{}s", self.verbose_name) [615d280b]
- self.ordering = ("_order",) if not any( isinstance(field, OrderWrt) for field in model._meta.local_fields ): model.add_to_class("_order", OrderWrt()) else: self.order_with_respect_to = None [7d6ca628]
- self.unique_together = normalize_together(self.unique_together) # App label/class name interpolation for names of constraints and # indexes. if not self.abstract: self.constraints = self._format_names(self.constraints) self.indexes = self._format_names(self.indexes) [74f40446]
- # A custom app registry to use, if you're making a separate model set. self.apps = self.default_apps [4aacd12c]
- # Creates a cache key composed of all arguments cache_key = (forward, reverse, include_parents, include_hidden, topmost_call) [1e813b68]
- # For legacy reasons, the fields property should only contain forward # fields that are not private or with a m2m cardinality. Therefore we # pass these three filters as filters to the generator. # The third filter is a longwinded way of checking f.related_model - we # don't use that property directly because related_model is a cached # property, and all the models may not have been loaded yet; we don't # want to cache the string reference to the related_model. def is_not_an_m2m_field(f): return not (f.is_relation and f.many_to_many) [461d2526]
- # If the db_table wasn't provided, use the app_label + model_name. if not self.db_table: self.db_table = "%s_%s" % (self.app_label, self.model_name) self.db_table = truncate_name( self.db_table, connection.ops.max_name_length() ) [f9cbdf4b]
- # If the field being added is a relation to another known field, # expire the cache on this field and the forward cache on the field # being referenced, because there will be new relationships in the # cache. Otherwise, expire the cache of references *to* this field. # The mechanism for getting at the related model is slightly odd - # ideally, we'd just ask for field.related_model. However, # related_model is a cached property, and all the models haven't been # loaded yet, so we need to make sure we don't cache a string # reference. if ( field.is_relation and hasattr(field.remote_field, "model") and field.remote_field.model ): try: field.remote_field.model._meta._expire_cache(forward=False) except AttributeError: pass self._expire_cache() else: self._expire_cache(reverse=False) [1e39055b]

## Beyond the budget

87 more facts did not fit in the budget: [bfce8b13] [77236ac7] [0b45afff] [93d98286] [26c36f97] [70226687] [ad17ab6f] [7a7ea5fc] [d6b0499b] [8e62b04c] [7c9ee49b] [837796ac] [975c79fc] [1e4e5f50] [4460342c] [d2030b97] [47a968d6] [a8396264] [09875859] [fbcab7b0] [74d61f3a] [dd056e42] [fbe65d4c] [fdf87db7] [2c9ba691] [6c678730] [3149997f] [98032e8c] [93659450] [62961247] [daccac95] [43e187d8] [06391254] [792b918d] [d0cdd93a] [f5f7e5e2] [99369f96] [0f359ac5] [1d451869] [94467d01] [aa957a43] [a120714d] [f5677e36] [c289fdec] [5ee59610] [f6d7bdc8] [6f3d9d1f] [c10a1733] [42002930] [5b74c615] [525a260a] [84dea4f4] [0792eac8] [fbd12d03] [899a3fd7] [d7bfda1f] [52740615] [329442c5] [a1a2f5c4] [694d4e8e] [ab7fe950] [11796997] [3e042830] [c00ef705] [f67be867] [d5427664] [e998f52b] [7a3d1056] [18cddcd4] [adca507f] [b9784ec7] [4c3e3467] [1165176b] [bb1534e7] [25c63487] [a22ff47f] [089ec45b] [f327d8da] [006c342c] [1710c6a7] [54bbaf78] [a659cc4f] [0e44a100] [3dbf0e8a] [0f841727] [f9dc854d] [550f093f]
