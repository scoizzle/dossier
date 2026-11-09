# django/contrib/sites/models

- Subject: django/contrib/sites/models (id `e0758bca-141d-4f2c-ad9c-a40072924b9c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 884 tokens
- Facts shown: 18 of 19
- Conflicts: 0
- Gaps: 0

## Facts

- if getattr(settings, "SITE_ID", ""): site_id = settings.SITE_ID return self._get_site_by_id(site_id) elif request: return self._get_site_by_request(request) [24e0cf00]
- raise ImproperlyConfigured( 'You\'re using the Django "sites framework" without having ' "set the SITE_ID setting. Create a site in your database and " "set the SITE_ID setting or pass a request to " "Site.objects.get_current() to fix this error." ) [40a5b8aa]
- class Meta: db_table = "django_site" verbose_name = _("site") verbose_name_plural = _("sites") ordering = ["domain"] [401f785e]
- def __str__(self): return self.domain [286dc73dcd691d5f]
- def _get_site_by_id(self, site_id): if site_id not in SITE_CACHE: site = self.get(pk=site_id) SITE_CACHE[site_id] = site return SITE_CACHE[site_id] [6a4dddb9]
- def _get_site_by_request(self, request): host = request.get_host() try: # First attempt to look up the site by host with or without port. if host not in SITE_CACHE: SITE_CACHE[host] = self.get(domain__iexact=host) return SITE_CACHE[host] except Site.DoesNotExist: # Fallback to looking up site after stripping port from the host. domain, port = split_domain_port(host) if domain not in SITE_CACHE: SITE_CACHE[domain] = self.get(domain__iexact=domain) return SITE_CACHE[domain] [0c7312b8]
- def clear_cache(self): """Clear the ``Site`` object cache.""" global SITE_CACHE SITE_CACHE = {} [a7f3f37f]
- def get_by_natural_key(self, domain): return self.get(domain=domain) [814be9bd]
- def get_current(self, request=None): """ Return the current Site based on the SITE_ID in the project's settings. If SITE_ID isn't defined, return the site with domain matching request.get_host(). The ``Site`` object is cached the first time it's retrieved from the database. """ from django.conf import settings [b95ce12c]
- def natural_key(self): return (self.domain,) [b8b6592c]
- objects = SiteManager() [13c8cf3a]
- SITE_CACHE = {} [b1307e08]
- class Site(models.Model): domain = models.CharField( _("domain name"), max_length=100, validators=[_simple_domain_name_validator], unique=True, ) name = models.CharField(_("display name"), max_length=50) [7b7c9f4d]
- class SiteManager(models.Manager): use_in_migrations = True [add8bf27]
- def _simple_domain_name_validator(value): """ Validate that the given value contains no whitespaces to prevent common typos. """ checks = ((s in value) for s in string.whitespace) if any(checks): raise ValidationError( _("The domain name cannot contain any spaces or tabs."), code="invalid", ) [2b599175]
- def clear_site_cache(sender, **kwargs): """ Clear the cache (if primed) each time a site is saved or deleted. """ instance = kwargs["instance"] using = kwargs["using"] try: del SITE_CACHE[instance.pk] except KeyError: pass try: del SITE_CACHE[Site.objects.using(using).get(pk=instance.pk).domain] except (KeyError, Site.DoesNotExist): pass [44ced911]
- import string [bd9eab00941d6afe]
- pre_save.connect(clear_site_cache, sender=Site) pre_delete.connect(clear_site_cache, sender=Site) [674ad4b7]

## Beyond the budget

1 more facts did not fit in the budget: [d949e335]
