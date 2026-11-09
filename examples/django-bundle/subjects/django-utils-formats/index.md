# django/utils/formats

- Subject: django/utils/formats (id `9a8a0bd9-0979-4bb4-a9bc-23f16b6f5ede`)
- Kind: subject
- Budget: 1200 tokens
- Used: 887 tokens
- Facts shown: 9 of 31
- Conflicts: 0
- Gaps: 0

## Facts

- # The requested format_type has not been cached yet. Try to find it in any # of the format_modules for the given lang if l10n is enabled. If it's not # there or if l10n is disabled, fall back to the project settings. val = None if use_l10n: for module in get_format_modules(lang): val = getattr(module, format_type, None) if val is not None: break if val is None: if format_type not in FORMAT_SETTINGS: return format_type val = getattr(settings, format_type) elif format_type in ISO_INPUT_FORMATS: # If a list of input formats from one of the format_modules was # retrieved, make sure the ISO_INPUT_FORMATS are in this list. val = list(val) for iso_input in ISO_INPUT_FORMATS.get(format_type, ()): if iso_input not in val: val.append(iso_input) _format_cache[cache_key] = val return val [673fce65]
- - %C → %02C - %F → %010F - %G → %04G - %Y → %04Y [ec13b096]
- For years < 1000 specifiers %C, %F, %G, and %Y don't work as expected for strftime provided by glibc on Linux as they don't pad the year or century with leading zeros. Support for specifying the padding explicitly is available, however, which can be used to fix this issue. [f81020f8]
- FreeBSD, macOS, and Windows do not support explicitly specifying the padding, but return four digit years (with leading zeros) as expected. [4bc96598]
- If use_l10n is provided and is not None, it forces the value to be localized (or not), otherwise it's always localized. """ if isinstance(value, str): # Handle strings first for performance reasons. return value elif isinstance(value, bool): # Make sure booleans don't get treated as numbers return str(value) elif isinstance(value, (decimal.Decimal, float, int)): if use_l10n is False: return str(value) return number_format(value, use_l10n=use_l10n) elif isinstance(value, datetime.datetime): return date_format(value, "DATETIME_FORMAT", use_l10n=use_l10n) elif isinstance(value, datetime.date): return date_format(value, use_l10n=use_l10n) elif isinstance(value, datetime.time): return time_format(value, use_l10n=use_l10n) return value [44995189]
- If use_l10n is provided and is not None, it forces the value to be localized (or not), otherwise it's always localized. """ if use_l10n is None: use_l10n = True if use_l10n and lang is None: lang = get_language() format_type = str(format_type) # format_type may be lazy. cache_key = (format_type, lang) try: return _format_cache[cache_key] except KeyError: pass [1e59f0f8]
- If use_l10n is provided and is not None, it forces the value to be localized (or not), otherwise it's always localized. """ if use_l10n is None: use_l10n = True lang = get_language() if use_l10n else None return numberformat.format( value, get_format("DECIMAL_SEPARATOR", lang, use_l10n=use_l10n), decimal_pos, get_format("NUMBER_GROUPING", lang, use_l10n=use_l10n), get_format("THOUSAND_SEPARATOR", lang, use_l10n=use_l10n), force_grouping=force_grouping, use_l10n=use_l10n, ) [758a88a5]
- If use_l10n is provided and is not None, it forces the value to be localized (or not), otherwise it's always localized. """ return dateformat.time_format( value, get_format(format or "TIME_FORMAT", use_l10n=use_l10n) ) [7051ae1c]
- This function checks whether the %Y produces a correctly padded string and, if not, makes the following substitutions: [d78f131e]

## Beyond the budget

22 more facts did not fit in the budget: [37609893] [60f151cb] [4f134b2c] [212e7f60] [87b1562f] [64bfafea] [88b13305] [ded2f11d] [bb100d2e] [25712ac4] [55d0beef] [bdd3fa97] [2cb2b699] [f483232e] [a6b5c3b6] [5ca170a1] [98d81092] [644d610c] [18eedf61] [2510f0f8] [def7b697] [863967bf]
