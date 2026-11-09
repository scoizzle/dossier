# django/contrib/sites/managers

- Subject: django/contrib/sites/managers (id `dfb73ed3-35b0-4508-b790-53de6e2e0513`)
- Kind: subject
- Budget: 1200 tokens
- Used: 469 tokens
- Facts shown: 11 of 11
- Conflicts: 0
- Gaps: 0

## Facts

- if not field.many_to_many and not isinstance(field, (models.ForeignKey)): return [ checks.Error( "CurrentSiteManager cannot use '%s.%s' as it is not a foreign key " "or a many-to-many field." % (self.model._meta.object_name, field_name), obj=self, id="sites.E002", ) ] [52ef1000]
- if not self.__field_name: try: self.model._meta.get_field("site") except FieldDoesNotExist: self.__field_name = "sites" else: self.__field_name = "site" return self.__field_name [cc8abdd6]
- return [] [637c4c5c01c1a891]
- def __init__(self, field_name=None): super().__init__() self.__field_name = field_name [5361feb5]
- def _check_field_name(self): field_name = self._get_field_name() try: field = self.model._meta.get_field(field_name) except FieldDoesNotExist: return [ checks.Error( "CurrentSiteManager could not find a field named '%s'." % field_name, obj=self, id="sites.E001", ) ] [9bffaa76]
- def _get_field_name(self): """Return self.__field_name or 'site' or 'sites'.""" [6b5e00f5]
- def check(self, **kwargs): errors = super().check(**kwargs) errors.extend(self._check_field_name()) return errors [849d4031]
- def get_queryset(self): return ( super() .get_queryset() .filter(**{self._get_field_name() + "__id": settings.SITE_ID}) ) [ee4f1625]
- use_in_migrations = True [bee62305d24cd880-2]
- class CurrentSiteManager(models.Manager): "Use this to limit objects to those associated with the current site." [9e26dfb6]
- from django.conf import settings from django.core import checks from django.core.exceptions import FieldDoesNotExist from django.db import models [f212d034]
