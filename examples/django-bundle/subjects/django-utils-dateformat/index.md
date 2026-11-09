# django/utils/dateformat

- Subject: django/utils/dateformat (id `11310f00-a7eb-48cb-bf0b-f75b1c629cb3`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2650 tokens
- Facts shown: 58 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- # `offset` is a datetime.timedelta. For negative values (to the west of # UTC) only days can be negative (days=-1) and seconds are always # positive. # e.g.: UTC-1 -> timedelta(days=-1, seconds=82800, microseconds=0) # Positive offsets have days=0 return offset.days * 86400 + offset.seconds [f3f034f3]
- If timezone information is not available, return an empty string. """ if not self.timezone: return "" [c354b8c3]
- If timezone information is not available, return an empty string. """ if self.timezone is None: return "" [ffd12749e3e456a1]
- If timezone information is not available, return an empty string. """ if self.timezone is None: return "" [ffd12749e3e456a1-2]
- If timezone information is not available, return an empty string. """ if self.timezone is None: return "" [ffd12749e3e456a1-3]
- if isinstance(obj, datetime): # Timezone is only supported when formatting datetime objects, not # date objects (timezone information not appropriate), or time # objects (against established django policy). if is_naive(obj): timezone = get_default_timezone() else: timezone = obj.tzinfo if not _datetime_ambiguous_or_imaginary(obj, timezone): self.timezone = timezone [6b1168b1]
- offset = self.timezone.utcoffset(self.data) [a1b18946]
- offset = self.timezone.utcoffset(self.data) seconds = offset.days * 86400 + offset.seconds sign = "-" if seconds < 0 else "+" seconds = abs(seconds) return "%s%02d%02d" % (sign, seconds // 3600, (seconds // 60) % 60) [b995ecc1]
- return str(self.timezone.tzname(self.data)) [843fa5d8]
- try: if getattr(self.data, "tzinfo", None): return self.data.tzname() or "" except NotImplementedError: pass return "" [492b3649]
- def A(self): "'AM' or 'PM'" if self.data.hour > 11: return _("PM") return _("AM") [f6a34029]
- def D(self): "Day of the week, textual, 3 letters; e.g. 'Fri'" return WEEKDAYS_ABBR[self.data.weekday()] [a6eee400]
- def E(self): """ Alternative month names as required by some locales. Proprietary extension. """ return MONTHS_ALT[self.data.month] [6ee5ebc1]
- def F(self): "Month, textual, long; e.g. 'January'" return MONTHS[self.data.month] [215ef89c]
- def G(self): "Hour, 24-hour format without leading zeros; i.e. '0' to '23'" return self.data.hour [63e05b37]
- def H(self): "Hour, 24-hour format; i.e. '00' to '23'" return "%02d" % self.data.hour [545ec3ec]
- def I(self): # NOQA: E743, E741 "'1' if daylight saving time, '0' otherwise." if self.timezone is None: return "" return "1" if self.timezone.dst(self.data) else "0" [46c50cc9]
- def L(self): "Boolean for whether it is a leap year; i.e. True or False" return calendar.isleap(self.data.year) [66ccbbbd]
- def M(self): "Month, textual, 3 letters; e.g. 'Jan'" return MONTHS_3[self.data.month].title() [3af3a4a0]
- def N(self): "Month abbreviation in Associated Press style. Proprietary extension." return MONTHS_AP[self.data.month] [7a4a68a8]
- def O(self): # NOQA: E743, E741 """ Difference to Greenwich time in hours; e.g. '+0200', '-0430'. [a2043cc5]

## All facts

- [41571ad5] def P(self): """ Time, in 12-hour hours, minutes and 'a.m.'/'p.m.', with minutes left off if they're zero and the strings 'midnight' and 'noon' if appropriate. Examples: '1 a.m.', '1:30 p.m.', 'midnight', 'noon', '12:30 p.m.' Proprietary extension. """ if self.data.minute == 0 and self.data.hour == 0: return _("midnight") if self.data.minute == 0 and self.data.hour == 12: return _("noon") return "%s %s" % (self.f(), self.a())
- [a3cd9bbd] def S(self): """ English ordinal suffix for the day of the month, 2 characters; i.e. 'st', 'nd', 'rd' or 'th'. """ if self.data.day in (11, 12, 13): # Special case return "th" last = self.data.day % 10 if last == 1: return "st" if last == 2: return "nd" if last == 3: return "rd" return "th"
- [e8912055] def T(self): """ Time zone of this machine; e.g. 'EST' or 'MDT'.
- [26847da2] def U(self): "Seconds since the Unix epoch (January 1 1970 00:00:00 GMT)" value = self.data if not isinstance(value, datetime): value = datetime.combine(value, time.min) return int(value.timestamp())
- [cfd01c7e] def W(self): "ISO-8601 week number of year, weeks starting on Monday" return self.data.isocalendar().week
- [aeb53353] def Y(self): """Year, 4 digits with leading zeros; e.g. '1999'.""" return "%04d" % self.data.year
- [b0727815] def Z(self): """ Time zone offset in seconds (i.e. '-43200' to '43200'). The offset for timezones west of UTC is always negative, and for those east of UTC is always positive.
- [ad801f7a] def a(self): "'a.m.' or 'p.m.'" if self.data.hour > 11: return _("p.m.") return _("a.m.")
- [57e87522] def c(self): """ ISO 8601 Format Example : '2008-01-02T10:30:00.000123' """ return self.data.isoformat()
- [e8f72d59] def d(self): "Day of the month, 2 digits with leading zeros; i.e. '01' to '31'" return "%02d" % self.data.day
- [8a75cb60] def e(self): """ Timezone name.
- [3cb1d0b8] def f(self): """ Time, in 12-hour hours and minutes, with minutes left off if they're zero. Examples: '1', '1:30', '2:05', '2' Proprietary extension. """ hour = self.data.hour % 12 or 12 minute = self.data.minute return "%d:%02d" % (hour, minute) if minute else hour
- [c66ae224] def g(self): "Hour, 12-hour format without leading zeros; i.e. '1' to '12'" return self.data.hour % 12 or 12
- [86e108b7] def h(self): "Hour, 12-hour format; i.e. '01' to '12'" return "%02d" % (self.data.hour % 12 or 12)
- [cbda17a6] def i(self): "Minutes; i.e. '00' to '59'" return "%02d" % self.data.minute
- [6dc90882] def j(self): "Day of the month without leading zeros; i.e. '1' to '31'" return self.data.day
- [2b3862c9] def l(self): # NOQA: E743, E741 "Day of the week, textual, long; e.g. 'Friday'" return WEEKDAYS[self.data.weekday()]
- [2767cb13] def m(self): "Month; i.e. '01' to '12'" return "%02d" % self.data.month
- [4956b6c1] def n(self): "Month without leading zeros; i.e. '1' to '12'" return self.data.month
- [3e5e0a0c] def o(self): "ISO 8601 year number matching the ISO week number (W)" return self.data.isocalendar().year
- [2e3dfc70] def r(self): "RFC 5322 formatted date; e.g. 'Thu, 21 Dec 2000 16:01:07 +0200'" value = self.data if not isinstance(value, datetime): # Assume midnight in default timezone if datetime.date provided. default_timezone = get_default_timezone() value = datetime.combine(value, time.min).replace(tzinfo=default_timezone) elif is_naive(value): value = make_aware(value, timezone=self.timezone) return format_datetime_rfc5322(value)
- [96d0e255] def s(self): "Seconds; i.e. '00' to '59'" return "%02d" % self.data.second
- [99031f29] def t(self): "Number of days in the given month; i.e. '28' to '31'" return calendar.monthrange(self.data.year, self.data.month)[1]
- [53ae1ed2] def u(self): "Microseconds; i.e. '000000' to '999999'" return "%06d" % self.data.microsecond
- [6011e5a5] def w(self): "Day of the week, numeric, i.e. '0' (Sunday) to '6' (Saturday)" return (self.data.weekday() + 1) % 7
- [c70f7511] def y(self): """Year, 2 digits with leading zeros; e.g. '99'.""" return "%02d" % (self.data.year % 100)
- [87681504] def z(self): """Day of the year, i.e. 1 to 366.""" return self.data.timetuple().tm_yday
- [f53183f4] """ PHP date() style date formatting See https://www.php.net/date for format strings
- [b0e327d0] Usage: >>> from datetime import datetime >>> d = datetime.now() >>> df = DateFormat(d) >>> print(df.format('jS F Y H:i')) 7th October 2003 11:39 >>> """
- [e81ad0dd] class DateFormat(TimeFormat): def b(self): "Month, textual, 3 letters, lowercase; e.g. 'jan'" return MONTHS_3[self.data.month]
- [9c72eae9] class Formatter: def format(self, formatstr): pieces = [] for i, piece in enumerate(re_formatchars.split(str(formatstr))): if i % 2: if type(self.data) is date and hasattr(TimeFormat, piece): raise TypeError( "The format for date objects may not contain " "time-related format specifiers (found '%s')." % piece ) pieces.append(str(getattr(self, piece)())) elif piece: pieces.append(re_escaped.sub(r"\1", piece)) return "".join(pieces)
- [474c17dc] class TimeFormat(Formatter): def __init__(self, obj): self.data = obj self.timezone = None
- [1f1c7ebd] def format(value, format_string): "Convenience function" df = DateFormat(value) return df.format(format_string)
- [cbc7cfdc] def time_format(value, format_string): "Convenience function" tf = TimeFormat(value) return tf.format(format_string)
- [7bb756c9] from django.utils.dates import ( MONTHS, MONTHS_3, MONTHS_ALT, MONTHS_AP, WEEKDAYS, WEEKDAYS_ABBR, ) from django.utils.regex_helper import _lazy_re_compile from django.utils.timezone import ( _datetime_ambiguous_or_imaginary, get_default_timezone, is_naive, make_aware, ) from django.utils.translation import gettext as _
- [0aada4c4] import calendar from datetime import date, datetime, time from email.utils import format_datetime as format_datetime_rfc5322
- [685e7494] re_formatchars = _lazy_re_compile(r"(?<!\\)([aAbcdDeEfFgGhHiIjlLmMnNoOPrsStTUuwWyYzZ])") re_escaped = _lazy_re_compile(r"\\(.)")
