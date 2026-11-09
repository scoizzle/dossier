# django/conf/locale/de_CH/formats

- Subject: django/conf/locale/de_CH/formats (id `50a31bcb-e2f5-4336-8cbe-06595b07df2b`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 318 tokens
- Facts shown: 3 facts
- Conflicts: 0
- Gaps: 0

## Facts

- # Swiss number formatting can vary based on context (e.g. Fr. 23.50 vs 22,5 m). # Django does not support context-specific formatting and uses generic # separators. DECIMAL_SEPARATOR = "," THOUSAND_SEPARATOR = "\xa0" # non-breaking space NUMBER_GROUPING = 3 [1103e5eb1fe40673]
- # The *_INPUT_FORMATS strings use the Python strftime format syntax, # see https://docs.python.org/library/datetime.html#strftime-strptime-behavior DATE_INPUT_FORMATS = [ "%d.%m.%Y", # '25.10.2006' "%d.%m.%y", # '25.10.06' # "%d. %B %Y", # '25. October 2006' # "%d. %b. %Y", # '25. Oct. 2006' ] DATETIME_INPUT_FORMATS = [ "%d.%m.%Y %H:%M:%S", # '25.10.2006 14:30:59' "%d.%m.%Y %H:%M:%S.%f", # '25.10.2006 14:30:59.000200' "%d.%m.%Y %H:%M", # '25.10.2006 14:30' ] [ca387e97]
- # This file is distributed under the same license as the Django package. # # The *_FORMAT strings use the Django date format syntax, # see https://docs.djangoproject.com/en/dev/ref/templates/builtins/#date DATE_FORMAT = "j. F Y" TIME_FORMAT = "H:i" DATETIME_FORMAT = "j. F Y H:i" YEAR_MONTH_FORMAT = "F Y" MONTH_DAY_FORMAT = "j. F" SHORT_DATE_FORMAT = "d.m.Y" SHORT_DATETIME_FORMAT = "d.m.Y H:i" FIRST_DAY_OF_WEEK = 1 # Monday [a96a0d9d0fbf8016-2]
