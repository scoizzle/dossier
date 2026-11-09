# django/templatetags/tz

- Subject: django/templatetags/tz (id `c99550e6-784f-40ae-9977-07bfc9c50df5`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1505 tokens
- Facts shown: 36 of 36
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [c435b328] def render(self, context): old_setting = context.use_tz context.use_tz = self.use_tz output = self.nodelist.render(context) context.use_tz = old_setting return output
- [cca39d74] def render(self, context): with timezone.override(self.tz.resolve(context)): output = self.nodelist.render(context) return output
- [92852089] result = timezone.localtime(value, tz)
- [75d8b3b4] # HACK: datetime instances cannot be assigned new attributes. Define a subclass # in order to define new attributes in do_timezone(). class datetimeobject(datetime): pass
- [3feed2be] # Template tags
- [bf6cf77c] @register.filter def localtime(value): """ Convert a datetime to local time in the active time zone.
- [85486dce] @register.filter def utc(value): """ Convert a datetime to UTC. """ return do_timezone(value, UTC)
- [ca88a96e] @register.filter("timezone") def do_timezone(value, arg): """ Convert a datetime to local time in a given time zone.
- [85c6eae3] @register.tag("get_current_timezone") def get_current_timezone_tag(parser, token): """ Store the name of the current time zone in the context.
- [6653228f] @register.tag("localtime") def localtime_tag(parser, token): """ Force or prevent conversion of datetime objects to local time, regardless of the value of ``settings.USE_TZ``.
- [d75bbe86] @register.tag("timezone") def timezone_tag(parser, token): """ Enable a given time zone just for this block.
- [35720d72] class GetCurrentTimezoneNode(Node): """ Template node class used by ``get_current_timezone_tag``. """
- [6c2a8a10] class LocalTimeNode(Node): """ Template node class used by ``localtime_tag``. """
- [48d67217] class TimezoneNode(Node): """ Template node class used by ``timezone_tag``. """
- [e0e6a270] from django.template import Library, Node, TemplateSyntaxError from django.utils import timezone
- [c2d965fc] import zoneinfo from datetime import UTC, datetime, tzinfo
- [c8c0ccd629deb6b1-9] register = Library()
