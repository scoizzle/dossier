# docs/ref/class-based-views/mixins-date-based

- Subject: docs/ref/class-based-views/mixins-date-based (id `068bbf6d-acdf-48df-bfca-e132cde9e265`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 19 of 112
- Conflicts: 0
- Gaps: 0

## Facts

- In this situation, if you have implemented per-user time zone selection, the same URL may show a different set of objects, depending on the end user's time zone. To avoid this, you should use a ``DateField`` as the ``date_field`` attribute. [a05a8c36]
- * The value of the :attr:`DayMixin.day` attribute. * The value of the ``day`` argument captured in the URL pattern. * The value of the ``day`` ``GET`` query argument. [e81d65b8]
- * The value of the :attr:`MonthMixin.month` attribute. * The value of the ``month`` argument captured in the URL pattern. * The value of the ``month`` ``GET`` query argument. [033af4c3]
- * The value of the :attr:`WeekMixin.week` attribute. * The value of the ``week`` argument captured in the URL pattern * The value of the ``week`` ``GET`` query argument. [6e69ec70]
- * The value of the :attr:`YearMixin.year` attribute. * The value of the ``year`` argument captured in the URL pattern. * The value of the ``year`` ``GET`` query argument. [1f9e766b]
- **Optional** A string defining the aggregation period for ``date_list``. It must be one of ``'year'`` (default), ``'month'``, or ``'day'``. [a019b104]
- **Optional** The value for the day, as a string. By default, set to ``None``, which means the day will be determined using other means. [3cb78f5f]
- .. warning:: [c54b54cb0805732a-11]
- A boolean specifying whether to display the page if no objects are available. If this is ``True`` and no objects are available, the view will display an empty page instead of raising a 404. [13eb8358]
- A boolean specifying whether to include "future" objects on this page, where "future" means objects in which the field specified in ``date_field`` is greater than the current date/time. By default, this is ``False``. [4702f11d]
- Determine whether to include "future" objects on this page, where "future" means objects in which the field specified in ``date_field`` is greater than the current date/time. Returns :attr:`~DateMixin.allow_future` by default. [0e7e4372]
- Raises a 404 if no valid day specification can be found. [da3c65ad]
- Raises a 404 if no valid month specification can be found. [eaf46326]
- Raises a 404 if no valid week specification can be found. [e8e749b9]
- Raises a 404 if no valid year specification can be found. [d5f70183]
- Returns a 3-tuple containing (``date_list``, ``object_list``, ``extra_context``). [11558494]
- Returns a date object containing the first day of the month after the date provided. This function can also return ``None`` or raise an :class:`~django.http.Http404` exception, depending on the values of :attr:`~BaseDateListView.allow_empty` and :attr:`~DateMixin.allow_future`. [963d684f]
- Returns a date object containing the previous valid day. This function can also return ``None`` or raise an :class:`~django.http.Http404` exception, depending on the values of :attr:`~BaseDateListView.allow_empty` and :attr:`~DateMixin.allow_future`. [145519d3]
- Returns the day for which this view will display data, as a string. Tries the following sources, in order: [98454f80]

## Beyond the budget

78 more facts did not fit in the budget: [9e8b8188] [02d6bc8e] [9b9110d4] [5147bf3d] [ab7d287a] [e52917bb] [d3db864f] [ed608513] [75438356] [bd815fec] [ac37cc27] [9b1d9037] [01fa32a4] [9629ed42] [4ee73b0b] [292d40c4] [984a23ca] [83eda2cf63eef8ea] [83eda2cf63eef8ea-2] [83eda2cf63eef8ea-3] [83eda2cf63eef8ea-4] [83eda2cf63eef8ea-5] [83eda2cf63eef8ea-6] [77f7bed952734363] [e7b6c80190b0dbd9] [7b775eb7] [2765e60e] [b8bb49a1] [1149e08c] [5ef307c2] [1cab55ad] [ef774139] [174a0115] [b59c156c] [93b5c25e] [eb54d4ab] [a4e68e27] [620fe5f1] [cce0e102] [44ffb697] [ac323331] [14a01744] [7d455677] [1e3850b1] [a4eb91b3] [6a34911f] [a3fb3184] [c058f21e] [9804991b] [2031efcd] [261dacaf] [7bfdd666] [981600d6] [5ec4a928] [108aa9b1] [a7217553] [f8df0166] [2db3cc59] [673dfbb9] [065c8eb2] [eaa7b735] [4230afd9] [4ce5c9da] [8b492c29] [db1a35fd] [286592d5] [2b07dafd] [c51c6bcd] [8b63a262] [f2271ab6] [942ae6c11625c81c-27] [70b2d8b4] [7a8e9186] [7c5ba0b0] [378e40ee] [a8e28f39] [bdaf7511] [e05c3f49]
