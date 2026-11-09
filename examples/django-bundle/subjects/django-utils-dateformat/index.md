# django/utils/dateformat

- Subject: django/utils/dateformat (id `8e545d83-f0dc-457c-8d6a-d02ea5a05b56`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 19 of 58
- Conflicts: 0
- Gaps: 0

## Facts

- # `offset` is a datetime.timedelta. For negative values (to the west of # UTC) only days can be negative (days=-1) and seconds are always # positive. # e.g.: UTC-1 -> timedelta(days=-1, seconds=82800, microseconds=0) # Positive offsets have days=0 return offset.days * 86400 + offset.seconds [f3f034f3]
- If timezone information is not available, return an empty string. """ if not self.timezone: return "" [c354b8c3]
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
- def P(self): """ Time, in 12-hour hours, minutes and 'a.m.'/'p.m.', with minutes left off if they're zero and the strings 'midnight' and 'noon' if appropriate. Examples: '1 a.m.', '1:30 p.m.', 'midnight', 'noon', '12:30 p.m.' Proprietary extension. """ if self.data.minute == 0 and self.data.hour == 0: return _("midnight") if self.data.minute == 0 and self.data.hour == 12: return _("noon") return "%s %s" % (self.f(), self.a()) [41571ad5]

## Beyond the budget

36 more facts did not fit in the budget: [a3cd9bbd] [e8912055] [26847da2] [cfd01c7e] [aeb53353] [b0727815] [ad801f7a] [57e87522] [e8f72d59] [8a75cb60] [3cb1d0b8] [c66ae224] [86e108b7] [cbda17a6] [6dc90882] [2b3862c9] [2767cb13] [4956b6c1] [3e5e0a0c] [2e3dfc70] [96d0e255] [99031f29] [53ae1ed2] [6011e5a5] [c70f7511] [87681504] [f53183f4] [b0e327d0] [e81ad0dd] [9c72eae9] [474c17dc] [1f1c7ebd] [cbc7cfdc] [7bb756c9] [0aada4c4] [685e7494]
