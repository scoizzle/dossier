# django/conf/locale/th/formats

- Subject: django/conf/locale/th/formats (id `b17210fb-4d67-4b33-9a2b-274bc2ee7db5`)
- Kind: subject
- Budget: 1200 tokens
- Used: 273 tokens
- Facts shown: 2 of 2
- Conflicts: 0
- Gaps: 0

## Facts

- # The *_INPUT_FORMATS strings use the Python strftime format syntax, # see https://docs.python.org/library/datetime.html#strftime-strptime-behavior DATE_INPUT_FORMATS = [ "%d/%m/%Y", # 25/10/2006 "%d %b %Y", # 25 ต.ค. 2006 "%d %B %Y", # 25 ตุลาคม 2006 ] TIME_INPUT_FORMATS = [ "%H:%M:%S", # 14:30:59 "%H:%M:%S.%f", # 14:30:59.000200 "%H:%M", # 14:30 ] DATETIME_INPUT_FORMATS = [ "%d/%m/%Y %H:%M:%S", # 25/10/2006 14:30:59 "%d/%m/%Y %H:%M:%S.%f", # 25/10/2006 14:30:59.000200 "%d/%m/%Y %H:%M", # 25/10/2006 14:30 ] DECIMAL_SEPARATOR = "." THOUSAND_SEPARATOR = "," NUMBER_GROUPING = 3 [5850befd]
- # This file is distributed under the same license as the Django package. # # The *_FORMAT strings use the Django date format syntax, # see https://docs.djangoproject.com/en/dev/ref/templates/builtins/#date DATE_FORMAT = "j F Y" TIME_FORMAT = "G:i" DATETIME_FORMAT = "j F Y, G:i" YEAR_MONTH_FORMAT = "F Y" MONTH_DAY_FORMAT = "j F" SHORT_DATE_FORMAT = "j M Y" SHORT_DATETIME_FORMAT = "j M Y, G:i" FIRST_DAY_OF_WEEK = 0 # Sunday [d36fc5b0]
