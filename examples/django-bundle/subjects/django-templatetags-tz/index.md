# django/templatetags/tz

- Subject: django/templatetags/tz (id `b0c993a8-546d-4b93-af4d-aa2f6e854d92`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 19 of 36
- Conflicts: 0
- Gaps: 0

## Facts

- {% get_current_timezone as TIME_ZONE %} [44d6b9a1]
- {% localtime off %}{{ value_in_utc }}{% endlocaltime %} """ bits = token.split_contents() if len(bits) == 1: use_tz = True elif len(bits) > 2 or bits[1] not in ("on", "off"): raise TemplateSyntaxError("%r argument should be 'on' or 'off'" % bits[0]) else: use_tz = bits[1] == "on" nodelist = parser.parse(("endlocaltime",)) parser.delete_first_token() return LocalTimeNode(nodelist, use_tz) [1191360c]
- {% timezone "Europe/Paris" %} It is {{ now }} in Paris. {% endtimezone %} """ bits = token.split_contents() if len(bits) != 2: raise TemplateSyntaxError("'%s' takes one argument (timezone)" % bits[0]) tz = parser.compile_filter(bits[1]) nodelist = parser.parse(("endtimezone",)) parser.delete_first_token() return TimezoneNode(nodelist, tz) [192ab124]
- # HACK: the convert_to_local_time flag will prevent # automatic conversion of the value to local time. result = datetimeobject( result.year, result.month, result.day, result.hour, result.minute, result.second, result.microsecond, result.tzinfo, ) result.convert_to_local_time = False return result [69ede6a6]
- # Obtain a timezone-aware datetime try: if timezone.is_naive(value): default_timezone = timezone.get_default_timezone() value = timezone.make_aware(value, default_timezone) # Filters must never raise exceptions, so catch everything. except Exception: return "" [98155d30]
- # Obtain a tzinfo instance if isinstance(arg, tzinfo): tz = arg elif isinstance(arg, str): try: tz = zoneinfo.ZoneInfo(arg) except zoneinfo.ZoneInfoNotFoundError: return "" else: return "" [66e0b174]
- Naive datetimes are assumed to be in local time in the default time zone. """ if not isinstance(value, datetime): return "" [ab95c240]
- Sample usage:: [2a5c6dd4ec548fdd-6]
- Sample usage:: [2a5c6dd4ec548fdd-7]
- The ``timezone`` argument must be an instance of a ``tzinfo`` subclass, a time zone name, or ``None``. If it is ``None``, the default time zone is used within the block. [b09f88b8]
- The argument must be an instance of a tzinfo subclass or a time zone name. [4df165e7]
- This only makes sense within a {% localtime off %} block. """ return do_timezone(value, timezone.get_current_timezone()) [10e62e45]
- This will fetch the currently active time zone and put its name into the ``TIME_ZONE`` context variable. """ # token.split_contents() isn't useful here because this tag doesn't accept # variable as arguments. args = token.contents.split() if len(args) != 3 or args[1] != "as": raise TemplateSyntaxError( "'get_current_timezone' requires 'as variable' (got %r)" % args ) return GetCurrentTimezoneNode(args[2]) [fd759f62]
- Usage:: [a898892ae0cdf6fe-19]
- def __init__(self, nodelist, tz): self.nodelist = nodelist self.tz = tz [282e1196]
- def __init__(self, nodelist, use_tz): self.nodelist = nodelist self.use_tz = use_tz [3047e1c0]
- def __init__(self, variable): self.variable = variable [8d93dd1d]
- def render(self, context): context[self.variable] = timezone.get_current_timezone_name() return "" [85b804d9]
- # Template filters [9280c249]

## Beyond the budget

17 more facts did not fit in the budget: [c435b328] [cca39d74] [92852089] [75d8b3b4] [3feed2be] [bf6cf77c] [85486dce] [ca88a96e] [85c6eae3] [6653228f] [d75bbe86] [35720d72] [6c2a8a10] [48d67217] [e0e6a270] [c2d965fc] [c8c0ccd629deb6b1-9]
