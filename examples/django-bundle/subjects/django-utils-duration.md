# django/utils/duration

- Subject: django/utils/duration (id `05cf67b1-0744-4d3d-a9fa-898a7d1f9cf5`)
- Kind: subject
- Budget: 1200 tokens
- Used: 388 tokens
- Facts shown: 11 of 11
- Conflicts: 0
- Gaps: 0

## Facts

- days, hours, minutes, seconds, microseconds = _get_duration_components(duration) ms = ".{:06d}".format(microseconds) if microseconds else "" return "{}P{}DT{:02d}H{:02d}M{:02d}{}S".format( sign, days, hours, minutes, seconds, ms ) [1564ad9f]
- hours = minutes // 60 minutes %= 60 [126162a8]
- minutes = seconds // 60 seconds %= 60 [34fd6fc8]
- return days, hours, minutes, seconds, microseconds [8bfc1148]
- return string [34f97cd7]
- string = "{:02d}:{:02d}:{:02d}".format(hours, minutes, seconds) if days: string = "{} ".format(days) + string if microseconds: string += ".{:06d}".format(microseconds) [229bfb7c]
- def _get_duration_components(duration): days = duration.days seconds = duration.seconds microseconds = duration.microseconds [2227c767]
- def duration_iso_string(duration): if duration < datetime.timedelta(0): sign = "-" duration *= -1 else: sign = "" [3781804c]
- def duration_microseconds(delta): return (24 * 60 * 60 * delta.days + delta.seconds) * 1000000 + delta.microseconds [6838b9be]
- def duration_string(duration): """Version of str(timedelta) which is not English specific.""" days, hours, minutes, seconds, microseconds = _get_duration_components(duration) [761cc075]
- import datetime [d152a5ac4c0db78d-4]
