# django/contrib/humanize/templatetags/humanize

- Subject: django/contrib/humanize/templatetags/humanize (id `dddda98c-5575-4e1f-aeb9-4e171bb023b7`)
- Kind: subject
- Budget: 1200 tokens
- Used: 871 tokens
- Facts shown: 8 of 15
- Conflicts: 0
- Gaps: 0

## Facts

- now = datetime.now(UTC if is_aware(value) else None) if value < now: delta = now - value if delta.days != 0: return cls.time_strings["past-day"] % { "delta": defaultfilters.timesince( value, now, time_strings=cls.past_substrings ), } elif delta.seconds == 0: return cls.time_strings["now"] elif delta.seconds < 60: return cls.time_strings["past-second"] % {"count": delta.seconds} elif delta.seconds // 60 < 60: count = delta.seconds // 60 return cls.time_strings["past-minute"] % {"count": count} else: count = delta.seconds // 60 // 60 return cls.time_strings["past-hour"] % {"count": count} else: delta = value - now if delta.days != 0: return cls.time_strings["future-day"] % { "delta": defaultfilters.timeuntil( value, now, time_strings=cls.future_substrings ), } elif delta.seconds == 0: return cls.time_strings["now"] elif delta.seconds < 60: return cls.time_strings["future-second"] % {"count": delta.seconds} elif delta.seconds // 60 < 60: count = delta.seconds // 60 return cls.time_strings["future-minute"] % {"count": count} else: count = delta.seconds // 60 // 60 return cls.time_strings["future-hour"] % {"count": count} [38730529]
- @classmethod def string_for(cls, value): if not isinstance(value, date): # datetime is a subclass of date return value [3a660713]
- abs_value = abs(value) if abs_value < 1000000: return value [eefd4b99]
- for exponent, converter in intword_converters: large_number = 10**exponent if abs_value < large_number * 1000: new_value = value / large_number rounded_value = round_away_from_one(new_value) return converter(abs(rounded_value)) % { "value": defaultfilters.floatformat(new_value, 1), } return value [a7ee5adc]
- # A tuple of standard large number to their converters intword_converters = ( (6, lambda number: ngettext("%(value)s million", "%(value)s million", number)), (9, lambda number: ngettext("%(value)s billion", "%(value)s billion", number)), (12, lambda number: ngettext("%(value)s trillion", "%(value)s trillion", number)), ( 15, lambda number: ngettext( "%(value)s quadrillion", "%(value)s quadrillion", number ), ), ( 18, lambda number: ngettext( "%(value)s quintillion", "%(value)s quintillion", number ), ), ( 21, lambda number: ngettext("%(value)s sextillion", "%(value)s sextillion", number), ), ( 24, lambda number: ngettext("%(value)s septillion", "%(value)s septillion", number), ), (27, lambda number: ngettext("%(value)s octillion", "%(value)s octillion", number)), (30, lambda number: ngettext("%(value)s nonillion", "%(value)s nonillion", number)), (33, lambda number: ngettext("%(value)s decillion", "%(value)s decillion", number)), (100, lambda number: ngettext("%(value)s googol", "%(value)s googol", number)), ) [b7df33a7]
- # This filter doesn't require expects_localtime=True because it deals properly # with both naive and aware datetimes. Therefore avoid the cost of conversion. @register.filter def naturaltime(value): """ For date and time values show how many seconds, minutes, or hours ago compared to current timestamp return representing string. """ return NaturalTimeFormatter.string_for(value) [3dd65fe0]
- import re from datetime import UTC, date, datetime from decimal import Decimal, InvalidOperation [500152db]
- register = template.Library() [8e0cd5cc07f83b92-6]

## Beyond the budget

7 more facts did not fit in the budget: [aa36177c] [59c2adbe] [5c92f040] [a3e650ab] [f685dbc2] [85ba23cc] [fa778ae1]
