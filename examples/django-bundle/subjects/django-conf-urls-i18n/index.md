# django/conf/urls/i18n

- Subject: django/conf/urls/i18n (id `f1f0c6fd-fa2a-4836-87fd-35980f4cfddf`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 307 tokens
- Facts shown: 5 of 5
- Conflicts: 0
- Gaps: 0

## Facts

- @functools.cache def is_language_prefix_patterns_used(urlconf): """ Return a tuple of two booleans: ( `True` if i18n_patterns() (LocalePrefixPattern) is used in the URLconf, `True` if the default language should be prefixed ) """ for url_pattern in get_resolver(urlconf).url_patterns: if isinstance(url_pattern.pattern, LocalePrefixPattern): return True, url_pattern.pattern.prefix_default_language return False, False [93e994d8]
- def i18n_patterns(*urls, prefix_default_language=True): """ Add the language code prefix to every URL pattern within this function. This may only be used in the root URLconf, not in an included URLconf. """ if not settings.USE_I18N: return list(urls) return [ URLResolver( LocalePrefixPattern(prefix_default_language=prefix_default_language), list(urls), ) ] [77f9fb7a]
- from django.conf import settings from django.urls import LocalePrefixPattern, URLResolver, get_resolver, path from django.views.i18n import set_language [63ff18f3]
- import functools [54adcbf441065810]
- urlpatterns = [ path("setlang/", set_language, name="set_language"), ] [bf9c3c38]
