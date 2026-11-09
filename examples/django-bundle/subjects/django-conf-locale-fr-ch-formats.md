# django/conf/locale/fr_CH/formats

- Subject: django/conf/locale/fr_CH/formats (id `dcb8e661-64ec-44f4-b7a9-383cbb069481`)
- Kind: subject
- Budget: 1200 tokens
- Used: 349 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- # Swiss number formatting can vary based on context (e.g. Fr. 23.50 vs 22,5 m). # Django does not support context-specific formatting and uses generic # separators. DECIMAL_SEPARATOR = "," THOUSAND_SEPARATOR = "\xa0" # non-breaking space NUMBER_GROUPING = 3 [1103e5eb1fe40673-2]
- # The *_INPUT_FORMATS strings use the Python strftime format syntax, # see https://docs.python.org/library/datetime.html#strftime-strptime-behavior DATE_INPUT_FORMATS = [ "%d.%m.%Y", # '25.10.2006' "%d.%m.%y", # '25.10.06' "%d/%m/%Y", # '25/10/2006' "%d/%m/%y", # '25/10/06' ] DATETIME_INPUT_FORMATS = [ "%d.%m.%Y %H:%M:%S", # '25.10.2006 14:30:59' "%d.%m.%Y %H:%M:%S.%f", # '25.10.2006 14:30:59.000200' "%d.%m.%Y %H:%M", # '25.10.2006 14:30' "%d/%m/%Y %H:%M:%S", # '25/10/2006 14:30:59' "%d/%m/%Y %H:%M:%S.%f", # '25/10/2006 14:30:59.000200' "%d/%m/%Y %H:%M", # '25/10/2006 14:30' ] [eb519936]
- # This file is distributed under the same license as the Django package. # # The *_FORMAT strings use the Django date format syntax, # see https://docs.djangoproject.com/en/dev/ref/templates/builtins/#date DATE_FORMAT = "j F Y" TIME_FORMAT = "H:i" DATETIME_FORMAT = "j F Y H:i" YEAR_MONTH_FORMAT = "F Y" MONTH_DAY_FORMAT = "j F" SHORT_DATE_FORMAT = "d.m.Y" SHORT_DATETIME_FORMAT = "d.m.Y H:i" FIRST_DAY_OF_WEEK = 1 # Monday [de851d5cd7a38949-2]
