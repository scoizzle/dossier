# django/utils/translation/trans_null

- Subject: django/utils/translation/trans_null (id `f13b8f45-78d7-4f94-b7a2-e14419e15c7e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 475 tokens
- Facts shown: 17 of 17
- Conflicts: 0
- Gaps: 0

## Facts

- # These are versions of the functions in django.utils.translation.trans_real # that don't actually do anything. This is purely for performance, so that # settings.USE_I18N = False can use this module rather than trans_real.py. [976d0749]
- deactivate_all = deactivate [fd49e99a]
- def activate(x): return None [8a03cc14]
- def check_for_language(x): return True [3d9c3db5]
- def deactivate(): return None [5f6b3f5a]
- def get_language(): return settings.LANGUAGE_CODE [d0cfdf78]
- def get_language_bidi(): return settings.LANGUAGE_CODE in settings.LANGUAGES_BIDI [28f0b7ae]
- def get_language_from_path(request): return None [0f98a391]
- def get_language_from_request(request, check_path=False): return settings.LANGUAGE_CODE [6c71e0bf]
- def get_supported_language_variant(lang_code, strict=False): if lang_code and lang_code.lower() == settings.LANGUAGE_CODE.lower(): return lang_code else: raise LookupError(lang_code) [dd0af147]
- def gettext(message): return message [ba417d97]
- def ngettext(singular, plural, number): if number == 1: return singular return plural [3f982e04]
- def npgettext(context, singular, plural, number): return ngettext(singular, plural, number) [07eded3e]
- def pgettext(context, message): return gettext(message) [7a98620e]
- from django.conf import settings [60c1cf40f51b59b8-4]
- gettext_noop = gettext_lazy = _ = gettext [b00aaa22]
- ngettext_lazy = ngettext [73fd91ed]
