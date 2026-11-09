# django/conf/locale/fr_CA/formats

- Subject: django/conf/locale/fr_CA/formats (id `6984f45e-2661-4212-9bf1-4b097a9a7797`)
- Kind: subject
- Budget: 1200 tokens
- Used: 304 tokens
- Facts shown: 2 of 2
- Conflicts: 0
- Gaps: 0

## Facts

- # The *_INPUT_FORMATS strings use the Python strftime format syntax, # see https://docs.python.org/library/datetime.html#strftime-strptime-behavior DATE_INPUT_FORMATS = [ "%Y-%m-%d", # '2006-05-15' "%y-%m-%d", # '06-05-15' ] DATETIME_INPUT_FORMATS = [ "%Y-%m-%d %H:%M:%S", # '2006-05-15 14:30:57' "%y-%m-%d %H:%M:%S", # '06-05-15 14:30:57' "%Y-%m-%d %H:%M:%S.%f", # '2006-05-15 14:30:57.000200' "%y-%m-%d %H:%M:%S.%f", # '06-05-15 14:30:57.000200' "%Y-%m-%d %H:%M", # '2006-05-15 14:30' "%y-%m-%d %H:%M", # '06-05-15 14:30' ] DECIMAL_SEPARATOR = "," THOUSAND_SEPARATOR = "\xa0" # non-breaking space NUMBER_GROUPING = 3 [cac7fba3]
- # This file is distributed under the same license as the Django package. # # The *_FORMAT strings use the Django date format syntax, # see https://docs.djangoproject.com/en/dev/ref/templates/builtins/#date DATE_FORMAT = "j F Y" # 31 janvier 2024 TIME_FORMAT = "H\xa0\\h\xa0i" # 13 h 40 DATETIME_FORMAT = "j F Y, H\xa0\\h\xa0i" # 31 janvier 2024, 13 h 40 YEAR_MONTH_FORMAT = "F Y" MONTH_DAY_FORMAT = "j F" SHORT_DATE_FORMAT = "Y-m-d" SHORT_DATETIME_FORMAT = "Y-m-d H\xa0\\h\xa0i" FIRST_DAY_OF_WEEK = 0 # Dimanche [a44a212b]
