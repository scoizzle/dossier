# django/conf/locale/hu/formats

- Subject: django/conf/locale/hu/formats (id `0a7d3176-f9e2-4eee-817d-e8e20c94e86a`)
- Kind: subject
- Budget: 1200 tokens
- Used: 263 tokens
- Facts shown: 2 of 2
- Conflicts: 0
- Gaps: 0

## Facts

- # The *_INPUT_FORMATS strings use the Python strftime format syntax, # see https://docs.python.org/library/datetime.html#strftime-strptime-behavior DATE_INPUT_FORMATS = [ "%Y.%m.%d.", # '2006.10.25.' ] TIME_INPUT_FORMATS = [ "%H:%M:%S", # '14:30:59' "%H:%M", # '14:30' ] DATETIME_INPUT_FORMATS = [ "%Y.%m.%d. %H:%M:%S", # '2006.10.25. 14:30:59' "%Y.%m.%d. %H:%M:%S.%f", # '2006.10.25. 14:30:59.000200' "%Y.%m.%d. %H:%M", # '2006.10.25. 14:30' ] DECIMAL_SEPARATOR = "," THOUSAND_SEPARATOR = " " # Non-breaking space NUMBER_GROUPING = 3 [17c0191f]
- # This file is distributed under the same license as the Django package. # # The *_FORMAT strings use the Django date format syntax, # see https://docs.djangoproject.com/en/dev/ref/templates/builtins/#date DATE_FORMAT = "Y. F j." TIME_FORMAT = "H:i" DATETIME_FORMAT = "Y. F j. H:i" YEAR_MONTH_FORMAT = "Y. F" MONTH_DAY_FORMAT = "F j." SHORT_DATE_FORMAT = "Y.m.d." SHORT_DATETIME_FORMAT = "Y.m.d. H:i" FIRST_DAY_OF_WEEK = 1 # Monday [75c9cdf6]
