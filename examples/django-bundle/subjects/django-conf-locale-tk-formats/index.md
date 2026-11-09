# django/conf/locale/tk/formats

- Subject: django/conf/locale/tk/formats (id `8d5c5201-7f69-404a-8eae-51696762d2c1`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 297 tokens
- Facts shown: 2 facts
- Conflicts: 0
- Gaps: 0

## Facts

- # The *_INPUT_FORMATS strings use the Python strftime format syntax, # see https://docs.python.org/library/datetime.html#strftime-strptime-behavior DATE_INPUT_FORMATS = [ "%d.%m.%Y", # '25.10.2006' "%d.%m.%y", # '25.10.06' ] DATETIME_INPUT_FORMATS = [ "%d.%m.%Y %H:%M:%S", # '25.10.2006 14:30:59' "%d.%m.%Y %H:%M:%S.%f", # '25.10.2006 14:30:59.000200' "%d.%m.%Y %H:%M", # '25.10.2006 14:30' "%d.%m.%Y", # '25.10.2006' "%d.%m.%y %H:%M:%S", # '25.10.06 14:30:59' "%d.%m.%y %H:%M:%S.%f", # '25.10.06 14:30:59.000200' "%d.%m.%y %H:%M", # '25.10.06 14:30' "%d.%m.%y", # '25.10.06' ] DECIMAL_SEPARATOR = "," THOUSAND_SEPARATOR = "\xa0" # non-breaking space NUMBER_GROUPING = 3 [98c835c7d505b9d9-2]
- # This file is distributed under the same license as the Django package. # # The *_FORMAT strings use the Django date format syntax, # see https://docs.djangoproject.com/en/dev/ref/templates/builtins/#date DATE_FORMAT = "j E Y г." TIME_FORMAT = "G:i" DATETIME_FORMAT = "j E Y г. G:i" YEAR_MONTH_FORMAT = "F Y г." MONTH_DAY_FORMAT = "j F" SHORT_DATE_FORMAT = "d.m.Y" SHORT_DATETIME_FORMAT = "d.m.Y H:i" FIRST_DAY_OF_WEEK = 1 # Monday [a3c3ea7c0ef67500-3]
