# django/db/models/fields/mixins

- Subject: django/db/models/fields/mixins (id `7bcaeaf9-7389-4ddb-b71b-39ba016b3fe0`)
- Kind: subject
- Budget: 1200 tokens
- Used: 485 tokens
- Facts shown: 12 of 12
- Conflicts: 0
- Gaps: 0

## Facts

- @cached_property def cache_name(self): raise NotImplementedError [995d54fc]
- Subclasses must set self.cache_name to a unique entry for the cache - typically the field’s name. """ [9b4cb9c9]
- def _check_default(self): if ( self.has_default() and self.default is not None and not callable(self.default) ): return [ checks.Warning( "%s default should be a callable instead of an instance " "so that it's not shared between all field instances." % (self.__class__.__name__,), hint=( "Use a callable instead, e.g., use `%s` instead of " "`%s`." % self._default_hint ), obj=self, id="fields.E010", ) ] else: return [] [546c4b27]
- def check(self, **kwargs): errors = super().check(**kwargs) errors.extend(self._check_default()) return errors [85d47d5b]
- def delete_cached_value(self, instance): del instance._state.fields_cache[self.cache_name] [82269cd0]
- def get_cached_value(self, instance, default=NOT_PROVIDED): try: return instance._state.fields_cache[self.cache_name] except KeyError: if default is NOT_PROVIDED: raise return default [8926a196]
- def is_cached(self, instance): return self.cache_name in instance._state.fields_cache [793b2579]
- def set_cached_value(self, instance, value): instance._state.fields_cache[self.cache_name] = value [aac007bf]
- NOT_PROVIDED = object() [76a3b812]
- class CheckFieldDefaultMixin: _default_hint = ("<valid default>", "<invalid default>") [89768990]
- class FieldCacheMixin: """ An API for working with the model's fields value cache. [86a69a5a]
- from django.core import checks from django.utils.functional import cached_property [4d25030f]
