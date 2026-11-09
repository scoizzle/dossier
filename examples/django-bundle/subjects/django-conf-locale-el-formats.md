# django/conf/locale/el/formats

- Subject: django/conf/locale/el/formats (id `75aa7e63-f68a-4dc8-ae14-8cba58195f92`)
- Kind: subject
- Budget: 1200 tokens
- Used: 316 tokens
- Facts shown: 2 of 2
- Conflicts: 0
- Gaps: 0

## Facts

- # The *_INPUT_FORMATS strings use the Python strftime format syntax, # see https://docs.python.org/library/datetime.html#strftime-strptime-behavior DATE_INPUT_FORMATS = [ "%d/%m/%Y", # '25/10/2006' "%d/%m/%y", # '25/10/06' "%Y-%m-%d", # '2006-10-25' ] DATETIME_INPUT_FORMATS = [ "%d/%m/%Y %H:%M:%S", # '25/10/2006 14:30:59' "%d/%m/%Y %H:%M:%S.%f", # '25/10/2006 14:30:59.000200' "%d/%m/%Y %H:%M", # '25/10/2006 14:30' "%d/%m/%y %H:%M:%S", # '25/10/06 14:30:59' "%d/%m/%y %H:%M:%S.%f", # '25/10/06 14:30:59.000200' "%d/%m/%y %H:%M", # '25/10/06 14:30' "%Y-%m-%d %H:%M:%S", # '2006-10-25 14:30:59' "%Y-%m-%d %H:%M:%S.%f", # '2006-10-25 14:30:59.000200' "%Y-%m-%d %H:%M", # '2006-10-25 14:30' ] DECIMAL_SEPARATOR = "," THOUSAND_SEPARATOR = "." NUMBER_GROUPING = 3 [92b68b3c]
- # This file is distributed under the same license as the Django package. # # The *_FORMAT strings use the Django date format syntax, # see https://docs.djangoproject.com/en/dev/ref/templates/builtins/#date DATE_FORMAT = "d/m/Y" TIME_FORMAT = "P" DATETIME_FORMAT = "d/m/Y P" YEAR_MONTH_FORMAT = "F Y" MONTH_DAY_FORMAT = "j F" SHORT_DATE_FORMAT = "d/m/Y" SHORT_DATETIME_FORMAT = "d/m/Y P" FIRST_DAY_OF_WEEK = 0 # Sunday [f66fca2b]
