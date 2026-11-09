# django/conf/locale/sk/formats

- Subject: django/conf/locale/sk/formats (id `b65fa81a-0802-4ab9-a56e-109d92250ece`)
- Kind: subject
- Budget: 1200 tokens
- Used: 273 tokens
- Facts shown: 2 of 2
- Conflicts: 0
- Gaps: 0

## Facts

- # The *_INPUT_FORMATS strings use the Python strftime format syntax, # see https://docs.python.org/library/datetime.html#strftime-strptime-behavior DATE_INPUT_FORMATS = [ "%d.%m.%Y", # '25.10.2006' "%d.%m.%y", # '25.10.06' "%y-%m-%d", # '06-10-25' # "%d. %B %Y", # '25. October 2006' # "%d. %b. %Y", # '25. Oct. 2006' ] DATETIME_INPUT_FORMATS = [ "%d.%m.%Y %H:%M:%S", # '25.10.2006 14:30:59' "%d.%m.%Y %H:%M:%S.%f", # '25.10.2006 14:30:59.000200' "%d.%m.%Y %H:%M", # '25.10.2006 14:30' ] DECIMAL_SEPARATOR = "," THOUSAND_SEPARATOR = "\xa0" # non-breaking space NUMBER_GROUPING = 3 [1a4dfff5]
- # This file is distributed under the same license as the Django package. # # The *_FORMAT strings use the Django date format syntax, # see https://docs.djangoproject.com/en/dev/ref/templates/builtins/#date DATE_FORMAT = "j. F Y" TIME_FORMAT = "G:i" DATETIME_FORMAT = "j. F Y G:i" YEAR_MONTH_FORMAT = "F Y" MONTH_DAY_FORMAT = "j. F" SHORT_DATE_FORMAT = "d.m.Y" SHORT_DATETIME_FORMAT = "d.m.Y G:i" FIRST_DAY_OF_WEEK = 1 # Monday [bf880254]
