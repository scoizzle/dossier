# django/core/checks/registry

- Subject: django/core/checks/registry (id `3fcd6444-f055-4ae1-b5d5-88c869e0eb52`)
- Kind: subject
- Budget: 1200 tokens
- Used: 894 tokens
- Facts shown: 17 of 18
- Conflicts: 0
- Gaps: 0

## Facts

- registry = CheckRegistry() @registry.register('mytag', 'anothertag') def my_check(app_configs, **kwargs): # ... perform checks and collect `errors` ... return errors # or registry.register(my_check, 'mytag', 'anothertag') """ [5324991f]
- Example:: [24ca13eabf54f502]
- def inner(check): if not func_accepts_kwargs(check): raise TypeError( "Check functions must accept keyword arguments (**kwargs)." ) check.tags = tags checks = ( self.deployment_checks if kwargs.get("deploy") else self.registered_checks ) checks.add(check) return check [52feaa0b]
- for check in checks: new_errors = check(app_configs=app_configs, databases=databases) if not isinstance(new_errors, Iterable): raise TypeError( "The function %r did not return a list. All functions " "registered with the checks registry must return a list." % check, ) errors.extend(new_errors) return errors [d31358c4]
- if callable(check): return inner(check) else: if check: tags += (check,) return inner [0233c8b7]
- if databases is None: databases = list(connections) [25e87dc3]
- if tags is not None: checks = [check for check in checks if not set(check.tags).isdisjoint(tags)] elif not databases: # By default, 'database'-tagged checks are not run if an alias # is not explicitly specified as they do more than mere static # code analysis. checks = [check for check in checks if Tags.database not in check.tags] [a66ce19a]
- admin = "admin" async_support = "async_support" caches = "caches" commands = "commands" compatibility = "compatibility" database = "database" files = "files" gis = "gis" mail = "mail" models = "models" security = "security" signals = "signals" sites = "sites" staticfiles = "staticfiles" templates = "templates" translation = "translation" urls = "urls" [82e9054b]
- def get_checks(self, include_deployment_checks=False): checks = list(self.registered_checks) if include_deployment_checks: checks.extend(self.deployment_checks) return checks [b635159a]
- def register(self, check=None, *tags, **kwargs): """ Can be used as a function or a decorator. Register given function `f` labeled with given `tags`. The function should receive **kwargs and return list of Errors and Warnings. [b41343fe]
- def run_checks( self, app_configs=None, tags=None, include_deployment_checks=False, databases=None, ): """ Run all registered checks and return list of Errors and Warnings. """ errors = [] checks = self.get_checks(include_deployment_checks) [330d988b]
- def tag_exists(self, tag, include_deployment_checks=False): return tag in self.tags_available(include_deployment_checks) [f96baa2b]
- def tags_available(self, deployment_checks=False): return set( chain.from_iterable( check.tags for check in self.get_checks(deployment_checks) ) ) [d5b490e9]
- class CheckRegistry: def __init__(self): self.registered_checks = set() self.deployment_checks = set() [52e564cc]
- class Tags: """ Built-in tags for internal checks. """ [0e5f9553]
- from collections.abc import Iterable from itertools import chain [061bb1c8]
- from django.db import connections from django.utils.inspect import func_accepts_kwargs [0f8ccfa9]

## Beyond the budget

1 more facts did not fit in the budget: [c3f766e2]
