# django/contrib/admin/filters

- Subject: django/contrib/admin/filters (id `06139bb0-b019-4776-8beb-08be5b06c71c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 10 of 67
- Conflicts: 0
- Gaps: 0

## Facts

- `changelist` is the ChangeList to be displayed. """ raise NotImplementedError( "subclasses of ListFilter must provide a choices() method" ) [663c702a]
- if isinstance(field, models.DateTimeField): today = now.replace(hour=0, minute=0, second=0, microsecond=0) else: # field is a models.DateField today = now.date() tomorrow = today + datetime.timedelta(days=1) if today.month == 12: next_month = today.replace(year=today.year + 1, month=1, day=1) else: next_month = today.replace(month=today.month + 1, day=1) next_year = today.replace(year=today.year + 1, month=1, day=1) [6ea527ab]
- lookup_condition = self.get_lookup_condition() if self.lookup_val == "1": return queryset.filter(lookup_condition) return queryset.exclude(lookup_condition) [e5720138]
- now = timezone.now() # When time zone support is enabled, convert "now" to the user's time # zone so Django's definition of "Today" matches what the user expects. if timezone.is_aware(now): now = timezone.localtime(now) [3ffd45b4]
- self.lookup_kwarg_since = "%s__gte" % field_path self.lookup_kwarg_until = "%s__lt" % field_path self.links = ( (_("Any date"), {}), ( _("Today"), { self.lookup_kwarg_since: today, self.lookup_kwarg_until: tomorrow, }, ), ( _("Past 7 days"), { self.lookup_kwarg_since: today - datetime.timedelta(days=7), self.lookup_kwarg_until: tomorrow, }, ), ( _("This month"), { self.lookup_kwarg_since: today.replace(day=1), self.lookup_kwarg_until: next_month, }, ), ( _("This year"), { self.lookup_kwarg_since: today.replace(month=1, day=1), self.lookup_kwarg_until: next_year, }, ), ) if field.null: self.lookup_kwarg_isnull = "%s__isnull" % field_path self.links += ( (_("No date"), {self.field_generic + "isnull": True}), (_("Has date"), {self.field_generic + "isnull": False}), ) super().__init__(field, request, params, model, model_admin, field_path) [19029780]
- @classmethod def create(cls, field, request, params, model, model_admin, field_path): for test, list_filter_class in cls._field_list_filters: if test(field): return list_filter_class( field, request, params, model, model_admin, field_path=field_path ) [e012d61d]
- @classmethod def register(cls, test, list_filter_class, take_priority=False): if take_priority: # This is to allow overriding the default filters for certain types # of fields with some custom filters. The first found in the list # is used in priority. cls._field_list_filters.insert( cls._take_priority_index, (test, list_filter_class) ) cls._take_priority_index += 1 else: cls._field_list_filters.append((test, list_filter_class)) [c16ce0aa]
- @property def include_empty_choice(self): """ Return True if a "(None)" choice should be included, which filters out everything except empty relationships. """ return self.field.null or (self.field.is_relation and self.field.many_to_many) [e49c48b6]
- def __init__(self, field, request, params, model, model_admin, field_path): self.field = field self.field_path = field_path self.title = getattr(field, "verbose_name", field_path) super().__init__(request, params, model, model_admin) for p in self.expected_parameters(): if p in params: value = params.pop(p) self.used_parameters[p] = prepare_lookup_value( p, value, self.list_separator ) [107c76a7]
- def expected_parameters(self): return [self.parameter_name] [e6b66e56]

## Beyond the budget

52 more facts did not fit in the budget: [48508343] [900c0655] [adc3b17e] [3ad471c7] [02e32d7f] [cee7db88] [88921ee4] [063562ac] [82595bf2] [39f232c1] [153bd9c4] [d990d9f3] [0b3696e70ba50c51] [ebaef722] [bcba7ab6] [231fdb0c] [c6d5bc0c] [99b0497b] [0535114b] [bc1514cf] [97e531fe] [78eefb73] [10eda4ee] [4af228fb] [de77fd94] [67a96eda] [533035f7] [6a3cf26d] [812ec076] [ede5eb0b] [bd9385e8] [acc0d653] [886357aa] [51a81eb5] [be2d7daf] [8b21ab82] [517b7b62] [8243cc74] [234531b0] [de98a56c] [399b3957] [aa01ca83] [879f16de] [1b82a321] [1d3590c8] [224e066f] [fbbae044] [508f2b1b] [45667c1a] [fa1aa336] [c8855b22] [d152a5ac4c0db78d]
