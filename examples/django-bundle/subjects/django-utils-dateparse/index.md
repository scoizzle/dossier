# django/utils/dateparse

- Subject: django/utils/dateparse (id `5d65ca9f-5b88-480d-bc71-14cc42299f3d`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1399 tokens
- Facts shown: 21 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- Also supports ISO 8601 representation (excluding years and months) and PostgreSQL's day-time interval format. """ match = ( standard_duration_re.match(value) or iso8601_duration_re.match(value) or postgres_interval_re.match(value) ) if match: kw = match.groupdict() sign = -1 if kw.pop("sign", "+") == "-" else 1 if kw.get("microseconds"): kw["microseconds"] = kw["microseconds"].ljust(6, "0") kw = {k: float(v.replace(",", ".")) for k, v in kw.items() if v is not None} days = datetime.timedelta(kw.pop("days", 0.0) or 0.0) if match.re == iso8601_duration_re: days *= sign return days + sign * datetime.timedelta(**kw) [69a64ee9]
- Raise ValueError if the input is well formatted but not a valid date. Return None if the input isn't well formatted. """ try: return datetime.date.fromisoformat(value) except ValueError: if match := date_re.match(value): kw = {k: int(v) for k, v in match.groupdict().items()} return datetime.date(**kw) [9fbdbaf8]
- Raise ValueError if the input is well formatted but not a valid datetime. Return None if the input isn't well formatted. """ try: return datetime.datetime.fromisoformat(value) except ValueError: if match := datetime_re.match(value): kw = match.groupdict() kw["microsecond"] = kw["microsecond"] and kw["microsecond"].ljust(6, "0") tzinfo = kw.pop("tzinfo") if tzinfo == "Z": tzinfo = datetime.UTC elif tzinfo is not None: offset_mins = int(tzinfo[-2:]) if len(tzinfo) > 3 else 0 offset = 60 * int(tzinfo[1:3]) + offset_mins if tzinfo[0] == "-": offset = -offset tzinfo = get_fixed_timezone(offset) kw = {k: int(v) for k, v in kw.items() if v is not None} return datetime.datetime(**kw, tzinfo=tzinfo) [e1318c50]
- Raise ValueError if the input is well formatted but not a valid time. Return None if the input isn't well formatted, in particular if it contains an offset. """ try: # The fromisoformat() method takes time zone info into account and # returns a time with a tzinfo component, if possible. However, there # are no circumstances where aware datetime.time objects make sense, so # remove the time zone offset. return datetime.time.fromisoformat(value).replace(tzinfo=None) except ValueError: if match := time_re.match(value): kw = match.groupdict() kw["microsecond"] = kw["microsecond"] and kw["microsecond"].ljust(6, "0") kw = {k: int(v) for k, v in kw.items() if v is not None} return datetime.time(**kw) [1a431542]
- The preferred format for durations in Django is '%d %H:%M:%S.%f'. [a026cfe2]
- This function doesn't support time zone offsets. [ace9c71d]
- This function supports time zone offsets. When the input contains one, the output uses a timezone with a fixed offset from UTC. [2c44a0ac]
- """Functions to parse datetime objects.""" [94fc148c]
- # Support PostgreSQL's day-time interval format, e.g. "3 days 04:05:06". The # year-month and mixed intervals cannot be converted to a timedelta and thus # aren't accepted. postgres_interval_re = _lazy_re_compile( r"^" r"(?:(?P<days>-?\d+) (days? ?))?" r"(?:(?P<sign>[-+])?" r"(?P<hours>\d+):" r"(?P<minutes>\d\d):" r"(?P<seconds>\d\d)" r"(?:\.(?P<microseconds>\d{1,6}))?" r")?$" ) [f55d449f]
- date_re = _lazy_re_compile(r"(?P<year>\d{4})-(?P<month>\d{1,2})-(?P<day>\d{1,2})$") [66604c1c]
- import datetime [d152a5ac4c0db78d-3]

## All facts

- [c1d1c6a6] # Support the sections of ISO 8601 date representation that are accepted by # timedelta iso8601_duration_re = _lazy_re_compile( r"^(?P<sign>[-+]?)" r"P" r"(?:(?P<weeks>\d+([.,]\d+)?)W)?" r"(?:(?P<days>\d+([.,]\d+)?)D)?" r"(?:T" r"(?:(?P<hours>\d+([.,]\d+)?)H)?" r"(?:(?P<minutes>\d+([.,]\d+)?)M)?" r"(?:(?P<seconds>\d+([.,]\d+)?)S)?" r")?" r"$" )
- [12df6db8] # We're using regular expressions rather than time.strptime because: # - They provide both validation and parsing. # - They're more flexible for datetimes. # - The date/datetime/time constructors produce friendlier error messages.
- [c96689e3] datetime_re = _lazy_re_compile( r"(?P<year>\d{4})-(?P<month>\d{1,2})-(?P<day>\d{1,2})" r"[T ](?P<hour>\d{1,2}):(?P<minute>\d{1,2})" r"(?::(?P<second>\d{1,2})(?:[.,](?P<microsecond>\d{1,6})\d{0,6})?)?" r"\s*(?P<tzinfo>Z|[+-]\d{2}(?::?\d{2})?)?$" )
- [26d983ff] def parse_date(value): """Parse a string and return a datetime.date.
- [af5a25e0] def parse_datetime(value): """Parse a string and return a datetime.datetime.
- [b6292ee2] def parse_duration(value): """Parse a duration string and return a datetime.timedelta.
- [e9f06b7f] def parse_time(value): """Parse a string and return a datetime.time.
- [2ad69ee2] from django.utils.regex_helper import _lazy_re_compile from django.utils.timezone import get_fixed_timezone
- [c266861b] standard_duration_re = _lazy_re_compile( r"^" r"(?:(?P<days>-?\d+) (days?, )?)?" r"(?P<sign>-?)" r"((?:(?P<hours>\d+):)(?=\d+:\d+))?" r"(?:(?P<minutes>\d+):)?" r"(?P<seconds>\d+)" r"(?:[.,](?P<microseconds>\d{1,6})\d{0,6})?" r"$" )
- [a8ab4a1c] time_re = _lazy_re_compile( r"(?P<hour>\d{1,2}):(?P<minute>\d{1,2})" r"(?::(?P<second>\d{1,2})(?:[.,](?P<microsecond>\d{1,6})\d{0,6})?)?$" )
