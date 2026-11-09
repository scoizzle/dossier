# django/utils/dateparse

- Subject: django/utils/dateparse (id `154c89b3-fe13-4046-bec7-4606fdb6d39d`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 11 of 21
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

9 more facts did not fit in the budget: [c1d1c6a6] [12df6db8] [c96689e3] [26d983ff] [b6292ee2] [e9f06b7f] [2ad69ee2] [c266861b] [a8ab4a1c]
