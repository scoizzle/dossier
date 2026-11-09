# django/views/generic/dates

- Subject: django/views/generic/dates (id `3af6c06d-dfbd-4095-915a-baf703cfe361`)
- Kind: subject
- Budget: 1200 tokens
- Used: 895 tokens
- Facts shown: 14 of 144
- Conflicts: 0
- Gaps: 0

## Facts

- # Convert datetimes to dates in the current time zone. if generic_view.uses_datetime_field: if settings.USE_TZ: result = timezone.localtime(result) result = result.date() [db523cea]
- # Filter down a queryset from self.queryset using the date from the # URL. This'll get passed as the queryset to DetailView.get_object, # which'll handle the 404 lookup_kwargs = self._make_single_date_lookup(date) qs = qs.filter(**lookup_kwargs) [c496639d]
- # Filter out objects in the future if appropriate. if not allow_future: # Fortunately, to match the implementation of allow_future, # we need __lte, which doesn't conflict with __lt above. if generic_view.uses_datetime_field: now = timezone.now() else: now = timezone_today() lookup["%s__lte" % date_field] = now [2f700243]
- # Return the first day of the period. return get_current(result) [88f34b0b]
- # Snag the first object from the queryset; if it doesn't exist that # means there's no next/previous link available. try: result = getattr(qs[0], date_field) except IndexError: return None [a72743a4]
- # Use a custom queryset if provided qs = self.get_queryset() if queryset is None else queryset [903bf3ff]
- * If allow_empty and allow_future are both true, this is easy: just return the naive result (just the next/previous day/week/month, regardless of object existence.) [c5c25d73]
- * If allow_empty is false and allow_future is false, return the next date that contains a valid object. If that date is in the future, or if there are no next objects, return None. """ date_field = generic_view.get_date_field() allow_empty = generic_view.get_allow_empty() allow_future = generic_view.get_allow_future() [ee3c9213]
- * If allow_empty is false and allow_future is true, return the next date *that contains a valid object*, even if it's in the future. If there are no next objects, return None. [90c193f5]
- * If allow_empty is true, allow_future is false, and the naive result isn't in the future, then return it; otherwise return None. [5a68d655]
- If the date field is a DateTimeField, we can't just filter on date_field=date because that doesn't take the time into account. """ date_field = self.get_date_field() if self.uses_datetime_field: since = self._make_date_lookup_arg(date) until = self._make_date_lookup_arg(date + datetime.timedelta(days=1)) return { "%s__gte" % date_field: since, "%s__lt" % date_field: until, } else: # Skip self._make_date_lookup_arg, it's a no-op in this branch. return {date_field: date} [6d6b5b39]
- The first day according to the week format is 0 and the last day is 6. """ week_format = self.get_week_format() if week_format in {"%W", "%V"}: # week starts on Monday return date.weekday() elif week_format == "%U": # week starts on Sunday return (date.weekday() + 1) % 7 else: raise ValueError("unknown week format: %s" % week_format) [2dea1600]
- The interval is defined by start date <= item date < next start date. """ if date.month == 12: try: return date.replace(year=date.year + 1, month=1, day=1) except ValueError: raise Http404(_("Date out of range")) else: return date.replace(month=date.month + 1, day=1) [ce7d536d]
- if not date_list: qs = qs.none() [0f4f1083]

## Beyond the budget

102 more facts did not fit in the budget: [4679b277] [8eef0903] [c425e7c0] [8fcfa87f] [20d16e32] [0794bea3] [60f96f93] [32211246] [021f6c54] [51940ac6] [d0bb9967] [202d5daf] [33f4cbb9] [a6953ed3] [6f97693605250e35] [342aebda] [ccf0b360] [af214cd1] [7804895f] [ef676304] [e71a211c] [c62ca5b3] [e7730f95] [4c104852] [f7068da7] [a3136c10] [7cc8e174] [317617b2] [24167601] [09852496] [9a5f7294] [72fcfeb6] [d4655f33703909eb] [e00924a9] [5c5338b9] [c17e3779] [fee8756d] [27d95cc8] [9ae0b51b] [e016c07b] [562598f3] [04def20c] [20ac228a] [57a72176] [d1149c9e] [38835de1] [4c9ec6ff] [9481c4ec] [ec1d1271] [a38ad67d] [2efe5369] [0d45dcfc] [7f78584d] [fa197f12] [20d4b9cc] [f680c60a] [0aa581fa] [5e63a2ce] [621055d7] [7c078592] [ea03e9e3] [6fffa4d7] [f8db0d2f] [34d3cff2] [b138cb61] [6664c4d6] [0adccb32] [3a88bfe3] [b1179a27] [bd7e5648] [0b740a2ee9b891ef] [5abacf64] [9f3fae10] [aaca4d84] [c9c63d57] [0a8b63f2] [32287265] [06336cec] [1be0f230] [36000496] [849f0f23] [ac320c82] [1a344c5b] [d84a2c05] [d6334be4] [4a1a3588] [b073a293] [372ea16d] [2ba6254b] [6335d3cc] [48aad985] [0b63b299] [a50e69cc] [a3687444] [587cb09d] [c2e4a478] [f3d113a6] [d6e30fc9] [5dbb597c] [55f89470] [070a6739] [d152a5ac4c0db78d-6]
