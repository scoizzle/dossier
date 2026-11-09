# django/utils/translation/__init__

- Subject: django/utils/translation/__init__ (id `9fb04c3f-51c8-41ab-a644-c1bcbadf9194`)
- Kind: subject
- Budget: 1200 tokens
- Used: 887 tokens
- Facts shown: 17 of 51
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

34 more facts did not fit in the budget: [d57999f7] [34e95d69] [28a266a8] [907c4448] [24c222b8] [3ce2bb6f] [6cf26c8f] [cf595928] [990599a9] [3bfc67ab] [7450c466] [8d3143cd] [5220a967] [88654af8] [318eb999] [811b735e] [982c0b43] [49ba3302] [b44a8a59] [659ca9e6] [57c079df] [a94f4129] [3068bede] [5c633cd7] [c8c8c7a0] [c91b9988] [51ee87ca] [e42e0f42] [ff5f3aed] [ca4e77d9] [dbe3e0c0] [3c3370f6] [7b65d492] [594a01d9]
