# django/utils/timezone

- Subject: django/utils/timezone (id `2f88e435-be85-45f4-a90d-3bf74e683160`)
- Kind: subject
- Budget: 1200 tokens
- Used: 895 tokens
- Facts shown: 18 of 47
- Conflicts: 0
- Gaps: 0

## Facts

- Assuming value.tzinfo is either None or a proper datetime.tzinfo, value.utcoffset() implements the appropriate logic. """ return value.utcoffset() is None [a40b5b34]
- Django will then use the time zone defined by settings.TIME_ZONE. """ if hasattr(_active, "value"): del _active.value [211a7d45]
- If use_tz is provided and is not None, that will force the value to be converted (or not), overriding the value of settings.USE_TZ. [a7222255]
- Local time is defined by the current time zone, unless another time zone is specified. """ if value is None: value = now() if timezone is None: timezone = get_current_timezone() # Emulate the behavior of astimezone() on Python < 3.6. if is_naive(value): raise ValueError("localtime() cannot be applied to a naive datetime") return value.astimezone(timezone) [6d99bbb2]
- Local time is defined by the current time zone, unless another time zone is specified. """ return localtime(value, timezone).date() [6af78a23]
- Only aware datetimes are allowed. When value is omitted, it defaults to now(). [c9caba1f89b63088]
- The ``timezone`` argument must be an instance of a ``tzinfo`` subclass, a time zone name, or ``None``. If it is ``None``, Django enables the default time zone. """ [afda694c]
- The ``timezone`` argument must be an instance of a tzinfo subclass or a time zone name. """ if isinstance(timezone, tzinfo): _active.value = timezone elif isinstance(timezone, str): _active.value = zoneinfo.ZoneInfo(timezone) else: raise ValueError("Invalid timezone: %r" % timezone) [2c4bc0aa]
- The concept is defined in Python's docs: https://docs.python.org/library/datetime.html#datetime.tzinfo [c6c73f98a7c394b1]
- This function is designed for use by the template engine. """ should_convert = ( isinstance(value, datetime) and (settings.USE_TZ if use_tz is None else use_tz) and not is_naive(value) and getattr(value, "convert_to_local_time", True) ) return localtime(value) if should_convert else value [ee5aa424]
- This is a context manager that uses django.utils.timezone.activate() to set the timezone on entry and restores the previously active timezone on exit. [74e04492]
- This is the time zone defined by settings.TIME_ZONE. """ return zoneinfo.ZoneInfo(settings.TIME_ZONE) [47ed077d]
- def __enter__(self): self.old_timezone = getattr(_active, "value", None) if self.timezone is None: deactivate() else: activate(self.timezone) [422fdc93]
- def __exit__(self, exc_type, exc_value, traceback): if self.old_timezone is None: deactivate() else: _active.value = self.old_timezone [b9698db0]
- def __init__(self, timezone): self.timezone = timezone [4fcb8ada]
- """ Timezone-related classes and functions. """ [9a9b8e14]
- # By design, these four functions don't perform any checks on their arguments. # The caller should ensure that they don't receive an invalid value like None. [a0e7abf8]
- # In order to avoid accessing settings at compile time, # wrap the logic in a function and cache the result. @functools.lru_cache def get_default_timezone(): """ Return the default time zone as a tzinfo instance. [0bb34e17]

## Beyond the budget

26 more facts did not fit in the budget: [b9d5ea9a] [db75c3c6] [c1727d7f] [516499eb] [3fb924a0] [f450f0fd] [14346bd2] [67490afb] [94a96221] [f5dbb836] [41831d1f] [0c6cb9a7] [c7f9e1f2] [9464bdab] [409251bf] [e65a90af] [dd7feee3] [fb784352] [ef88a0ab] [44cfa1bd] [de70a200] [955bdbb6] [0f6e816d] [6beab4e4549a99b7-6] [60c1cf40f51b59b8-3] [de58d8d9]
