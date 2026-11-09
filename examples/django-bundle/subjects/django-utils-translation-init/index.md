# django/utils/translation/__init__

- Subject: django/utils/translation/__init__ (id `ac513f55-b11c-4a7c-b2d4-6d02f48b3331`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2377 tokens
- Facts shown: 51 of 51
- Conflicts: 0
- Gaps: 0

## Highlights

- autoreload_started.connect( watch_for_translation_changes, dispatch_uid="translation_file_changed" ) file_changed.connect( translation_file_changed, dispatch_uid="translation_file_changed" ) else: from django.utils.translation import trans_null as trans setattr(self, real_name, getattr(trans, real_name)) return getattr(trans, real_name) [167cc45a]
- def __mod__(self, rhs): if isinstance(rhs, dict) and number: number_value = self._get_number_value(rhs) else: number_value = rhs translated = self._translate(number_value) try: translated %= rhs except TypeError: # String doesn't contain a placeholder for the number. pass return translated [e08dd224]
- def _get_number_value(self, values): try: return values[number] except KeyError: raise KeyError( "Your dictionary lacks key '%s'. Please provide " "it, because it is required to determine whether " "string is singular or plural." % number ) [64ce1520]
- def _translate(self, number_value): kwargs["number"] = number_value return func(**kwargs) [16c30611]
- def format(self, *args, **kwargs): number_value = ( self._get_number_value(kwargs) if kwargs and number else args[0] ) return self._translate(number_value).format(*args, **kwargs) [409d94e1]
- class NumberAwareString(resultclass): def __bool__(self): return bool(kwargs["singular"]) [625b05e7]
- if settings.USE_I18N: from django.utils.translation import trans_real as trans from django.utils.translation.reloader import ( translation_file_changed, watch_for_translation_changes, ) [56b8fc80]
- proxy = lazy(lambda **kwargs: NumberAwareString(), NumberAwareString)(**kwargs) proxy.__reduce__ = lambda: ( _lazy_number_unpickle, (func, resultclass, number, original_kwargs), ) return proxy [d68d0884]
- Note that storing the function with setattr will have a noticeable performance effect, as access to the function goes the normal path, instead of using __getattr__. """ [7a7e2cb2]
- def __enter__(self): self.old_language = get_language() if self.language is not None: activate(self.language) else: deactivate_all() [475445b4]
- def __exit__(self, exc_type, exc_value, traceback): if self.old_language is None: deactivate_all() elif self.deactivate: deactivate() else: activate(self.old_language) [cbf9e098]
- def __getattr__(self, real_name): from django.conf import settings [76fae93a]
- if info: info["name_translated"] = gettext_lazy(info["name"]) return info [fb45fded]
- return templatize(src, **kwargs) [53d62cd4]
- try: lang_info = LANG_INFO[lang_code] if "fallback" in lang_info and "name" not in lang_info: info = get_language_info(lang_info["fallback"][0]) else: info = lang_info except KeyError: if "-" not in lang_code: raise KeyError("Unknown language code %s." % lang_code) generic_lang_code = lang_code.split("-")[0] try: info = LANG_INFO[generic_lang_code] except KeyError: raise KeyError( "Unknown language code %s and %s." % (lang_code, generic_lang_code) ) [898715f2]
- """ Internationalization support. """ [6e3e8ee1]
- # The Trans class is no more needed, so remove it from the namespace. del Trans [f68e9dd5]

## All facts

- [d57999f7] # Here be dragons, so a short explanation of the logic won't hurt: # We are trying to solve two problems: (1) access settings, in particular # settings.USE_I18N, as late as possible, so that modules can be imported # without having to first configure Django, and (2) if some other code creates # a reference to one of these functions, don't break that reference when we # replace the functions with their real counterparts (once we do access the # settings).
- [34e95d69] __all__ = [ "activate", "deactivate", "override", "deactivate_all", "get_language", "get_language_from_request", "get_language_info", "get_language_bidi", "check_for_language", "to_language", "to_locale", "templatize", "gettext", "gettext_lazy", "gettext_noop", "ngettext", "ngettext_lazy", "pgettext", "pgettext_lazy", "npgettext", "npgettext_lazy", ]
- [28a266a8] _trans = Trans()
- [907c4448] class Trans: """ The purpose of this class is to store the actual translation function upon receiving the first call to that function. After this is done, changes to USE_I18N will have no effect to which function is served upon request. If your tests rely on changing USE_I18N, you can delete all the functions from _trans.__dict__.
- [24c222b8] class TranslatorCommentWarning(SyntaxWarning): pass
- [3ce2bb6f] class override(ContextDecorator): def __init__(self, language, deactivate=False): self.language = language self.deactivate = deactivate
- [6cf26c8f] def _lazy_number_unpickle(func, resultclass, number, kwargs): return lazy_number(func, resultclass, number=number, **kwargs)
- [cf595928] def activate(language): return _trans.activate(language)
- [990599a9] def check_for_language(lang_code): return _trans.check_for_language(lang_code)
- [3bfc67ab] def deactivate(): return _trans.deactivate()
- [7450c466] def deactivate_all(): return _trans.deactivate_all()
- [8d3143cd] def get_language(): return _trans.get_language()
- [5220a967] def get_language_bidi(): return _trans.get_language_bidi()
- [88654af8] def get_language_from_path(path): return _trans.get_language_from_path(path)
- [318eb999] def get_language_from_request(request, check_path=False): return _trans.get_language_from_request(request, check_path)
- [811b735e] def get_language_info(lang_code): from django.conf.locale import LANG_INFO
- [982c0b43] def get_supported_language_variant(lang_code, *, strict=False): return _trans.get_supported_language_variant(lang_code, strict)
- [49ba3302] def gettext(message): return _trans.gettext(message)
- [b44a8a59] def gettext_noop(message): return _trans.gettext_noop(message)
- [659ca9e6] def lazy_number(func, resultclass, number=None, **kwargs): if isinstance(number, int): kwargs["number"] = number proxy = lazy(func, resultclass)(**kwargs) else: original_kwargs = kwargs.copy()
- [57c079df] def ngettext(singular, plural, number): return _trans.ngettext(singular, plural, number)
- [a94f4129] def ngettext_lazy(singular, plural, number=None): return lazy_number(ngettext, str, singular=singular, plural=plural, number=number)
- [3068bede] def npgettext(context, singular, plural, number): return _trans.npgettext(context, singular, plural, number)
- [5c633cd7] def npgettext_lazy(context, singular, plural, number=None): return lazy_number( npgettext, str, context=context, singular=singular, plural=plural, number=number )
- [c8c8c7a0] def pgettext(context, message): return _trans.pgettext(context, message)
- [c91b9988] def round_away_from_one(value): return int(Decimal(value - 1).quantize(Decimal("0"), rounding=ROUND_UP)) + 1
- [51ee87ca] def templatize(src, **kwargs): from .template import templatize
- [e42e0f42] def to_language(locale): """Turn a locale name (en_US) into a language name (en-us).""" p = locale.find("_") if p >= 0: return locale[:p].lower() + "-" + locale[p + 1 :].lower() else: return locale.lower()
- [ff5f3aed] def to_locale(language): """Turn a language name (en-us) into a locale name (en_US).""" lang, _, country = language.lower().partition("-") if not country: return language[:3].lower() + language[3:] # A language with > 2 characters after the dash only has its first # character after the dash capitalized; e.g. sr-latn becomes sr_Latn. # A language with 2 characters after the dash has both characters # capitalized; e.g. en-us becomes en_US. country, _, tail = country.partition("-") country = country.title() if len(country) > 2 else country.upper() if tail: country += "-" + tail return lang + "_" + country
- [ca4e77d9] def trim_whitespace(s): return trim_whitespace_re.sub(" ", s.strip())
- [dbe3e0c0] from contextlib import ContextDecorator from decimal import ROUND_UP, Decimal
- [3c3370f6] from django.utils.autoreload import autoreload_started, file_changed from django.utils.functional import lazy from django.utils.regex_helper import _lazy_re_compile
- [7b65d492] gettext_lazy = lazy(gettext, str) pgettext_lazy = lazy(pgettext, str)
- [594a01d9] trim_whitespace_re = _lazy_re_compile(r"\s*\n\s*")
