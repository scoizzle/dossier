# django/conf/locale/ro/formats

- Subject: django/conf/locale/ro/formats (id `0f92822a-11a0-4ef5-ba5f-c5170dd8e6d3`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 242 tokens
- Facts shown: 2 facts
- Conflicts: 0
- Gaps: 0

## Facts

- # The *_INPUT_FORMATS strings use the Python strftime format syntax, # see https://docs.python.org/library/datetime.html#strftime-strptime-behavior DATE_INPUT_FORMATS = [ "%d.%m.%Y", "%d.%b.%Y", "%d %B %Y", "%A, %d %B %Y", ] TIME_INPUT_FORMATS = [ "%H:%M", "%H:%M:%S", "%H:%M:%S.%f", ] DATETIME_INPUT_FORMATS = [ "%d.%m.%Y, %H:%M", "%d.%m.%Y, %H:%M:%S", "%d.%B.%Y, %H:%M", "%d.%B.%Y, %H:%M:%S", ] DECIMAL_SEPARATOR = "," THOUSAND_SEPARATOR = "." NUMBER_GROUPING = 3 [6f9c370c]
- # This file is distributed under the same license as the Django package. # # The *_FORMAT strings use the Django date format syntax, # see https://docs.djangoproject.com/en/dev/ref/templates/builtins/#date DATE_FORMAT = "j F Y" TIME_FORMAT = "H:i" DATETIME_FORMAT = "j F Y, H:i" YEAR_MONTH_FORMAT = "F Y" MONTH_DAY_FORMAT = "j F" SHORT_DATE_FORMAT = "d.m.Y" SHORT_DATETIME_FORMAT = "d.m.Y, H:i" FIRST_DAY_OF_WEEK = 1 [4ec8f3ce]
