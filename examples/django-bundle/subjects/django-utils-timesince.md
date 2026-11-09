# django/utils/timesince

- Subject: django/utils/timesince (id `223d5289-8cda-4ab9-ab14-adb05e63c91b`)
- Kind: subject
- Budget: 1200 tokens
- Used: 890 tokens
- Facts shown: 13 of 22
- Conflicts: 0
- Gaps: 0

## Facts

- # Calculate the remaining time. # Create a "pivot" datetime shifted from d by years and months, then use # that to determine the other parts. if years or months: pivot_year = d.year + years pivot_month = d.month + months if pivot_month > 12: pivot_month -= 12 pivot_year += 1 pivot = datetime.datetime( pivot_year, pivot_month, min(MONTHS_DAYS[pivot_month - 1], d.day), d.hour, d.minute, d.second, tzinfo=d.tzinfo, ) else: pivot = d remaining_time = (now - pivot).total_seconds() partials = [years, months] for chunk in TIME_CHUNKS: count = int(remaining_time // chunk) partials.append(count) remaining_time -= chunk * count [377760a8]
- # Compared datetimes must be in the same time zone. if not now: now = datetime.datetime.now(d.tzinfo if is_aware(d) else None) elif is_aware(now) and is_aware(d): now = now.astimezone(d.tzinfo) [1f5ddd2e]
- # Find the first non-zero part (if any) and then build the result, until # depth. i = 0 for i, value in enumerate(partials): if value != 0: break else: return avoid_wrapping(time_strings["minute"] % {"num": 0}) [afee5484]
- # Get years and months. total_months = (now.year - d.year) * 12 + (now.month - d.month) if d.day > now.day or (d.day == now.day and d.time() > now.time()): total_months -= 1 years, months = divmod(total_months, 12) [766c657d]
- # Ignore microseconds. since = delta.days * 24 * 60 * 60 + delta.seconds if since <= 0: # d is in the future compared to now, stop processing. return avoid_wrapping(time_strings["minute"] % {"num": 0}) [f3234a6b]
- Originally adapted from https://web.archive.org/web/20060617175230/http://blog.natbat.co.uk/archive/2003/Jun/14/time_since Modified to improve results for years and months. """ if time_strings is None: time_strings = TIME_STRINGS if depth <= 0: raise ValueError("depth must be greater than 0.") # Convert datetime.date to datetime.datetime for comparison. if not isinstance(d, datetime.datetime): d = datetime.datetime(d.year, d.month, d.day) if now and not isinstance(now, datetime.datetime): now = datetime.datetime(now.year, now.month, now.day) [8b1f29a7]
- The algorithm takes into account the varying duration of years and months. There is exactly "1 year, 1 month" between 2013/02/10 and 2014/03/10, but also between 2007/08/10 and 2008/09/10 despite the delta being 393 days in the former case and 397 in the latter. [43626d94]
- Units used are years, months, weeks, days, hours, and minutes. Seconds and microseconds are ignored. [be9dcd43]
- Up to `depth` adjacent units will be displayed. For example, "2 weeks, 3 days" and "1 year, 3 months" are possible outputs, but "2 weeks, 3 hours" and "1 year, 5 days" are not. [b884117f]
- `depth` is an optional integer to control the number of adjacent time units returned. [f200195f]
- `time_strings` is an optional dict of strings to replace the default TIME_STRINGS dict. [ed793f7d]
- if reversed: d, now = now, d delta = now - d [7c80a63b]
- result = [] current_depth = 0 while i < len(TIME_STRINGS_KEYS) and current_depth < depth: value = partials[i] if value == 0: break name = TIME_STRINGS_KEYS[i] result.append(avoid_wrapping(time_strings[name] % {"num": value})) current_depth += 1 i += 1 [108b7dcc]

## Beyond the budget

9 more facts did not fit in the budget: [e103e671] [877e54d7] [297d7f57] [472ee09a] [237bcae8] [b6c33a08] [bc265fe7] [6338cb35] [d152a5ac4c0db78d-5]
