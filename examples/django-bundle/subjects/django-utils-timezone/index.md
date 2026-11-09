# django/utils/timezone

- Subject: django/utils/timezone (id `3a2372a9-ad23-41b9-99be-35681bb49903`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2009 tokens
- Facts shown: 44 of 47
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [b9d5ea9a] # Templates
- [db75c3c6] # These functions don't change os.environ['TZ'] and call time.tzset() # because it isn't thread safe.
- [c1727d7f] # This function exists for consistency with get_current_timezone_name def get_default_timezone_name(): """Return the name of the default time zone.""" return _get_timezone_name(get_default_timezone())
- [516499eb] # Timezone selection functions.
- [3fb924a0] # Utilities
- [f450f0fd] __all__ = [ "get_fixed_timezone", "get_default_timezone", "get_default_timezone_name", "get_current_timezone", "get_current_timezone_name", "activate", "deactivate", "override", "localtime", "localdate", "now", "is_aware", "is_naive", "make_aware", "make_naive", ]
- [14346bd2] _active = Local()
- [67490afb] class override(ContextDecorator): """ Temporarily set the time zone for the current thread.
- [94a96221] def _datetime_ambiguous_or_imaginary(dt, tz): return tz.utcoffset(dt.replace(fold=not dt.fold)) != tz.utcoffset(dt)
- [f5dbb836] def _get_timezone_name(timezone): """ Return the offset for fixed offset timezones, or the name of timezone if not set. """ return timezone.tzname(None) or str(timezone)
- [41831d1f] def activate(timezone): """ Set the time zone for the current thread.
- [0c6cb9a7] def deactivate(): """ Unset the time zone for the current thread.
- [c7f9e1f2] def get_current_timezone(): """Return the currently active time zone as a tzinfo instance.""" return getattr(_active, "value", get_default_timezone())
- [9464bdab] def get_current_timezone_name(): """Return the name of the currently active time zone.""" return _get_timezone_name(get_current_timezone())
- [409251bf] def get_fixed_timezone(offset): """Return a tzinfo instance with a fixed offset from UTC.""" if isinstance(offset, timedelta): offset = offset.total_seconds() // 60 sign = "-" if offset < 0 else "+" hhmm = "%02d%02d" % divmod(abs(offset), 60) name = sign + hhmm return timezone(timedelta(minutes=offset), name)
- [e65a90af] def is_aware(value): """ Determine if a given datetime.datetime is aware.
- [dd7feee3] def is_naive(value): """ Determine if a given datetime.datetime is naive.
- [fb784352] def localdate(value=None, timezone=None): """ Convert an aware datetime to local time and return the value's date.
- [ef88a0ab] def localtime(value=None, timezone=None): """ Convert an aware datetime.datetime to local time.
- [44cfa1bd] def make_aware(value, timezone=None): """Make a naive datetime.datetime in a given time zone aware.""" if timezone is None: timezone = get_current_timezone() # Check that we won't overwrite the timezone of an aware datetime. if is_aware(value): raise ValueError("make_aware expects a naive datetime, got %s" % value) # This may be wrong around DST changes! return value.replace(tzinfo=timezone)
- [de70a200] def make_naive(value, timezone=None): """Make an aware datetime.datetime naive in a given time zone.""" if timezone is None: timezone = get_current_timezone() # Emulate the behavior of astimezone() on Python < 3.6. if is_naive(value): raise ValueError("make_naive() cannot be applied to a naive datetime") return value.astimezone(timezone).replace(tzinfo=None)
- [955bdbb6] def now(): """ Return an aware or naive datetime.datetime, depending on settings.USE_TZ. """ return datetime.now(tz=UTC if settings.USE_TZ else None)
- [0f6e816d] def template_localtime(value, use_tz=None): """ Check if value is a datetime and converts it to local time if necessary.
- [6beab4e4549a99b7-6] from asgiref.local import Local
- [60c1cf40f51b59b8-3] from django.conf import settings
- [de58d8d9] import functools import zoneinfo from contextlib import ContextDecorator from datetime import UTC, datetime, timedelta, timezone, tzinfo
