# django/conf/locale/eo/formats

- Subject: django/conf/locale/eo/formats (id `e74ae06e-2ff7-4395-a8d9-7ed3f95e683a`)
- Kind: subject
- Budget: 1200 tokens
- Used: 423 tokens
- Facts shown: 2 of 2
- Conflicts: 0
- Gaps: 0

## Facts

- # The *_INPUT_FORMATS strings use the Python strftime format syntax, # see https://docs.python.org/library/datetime.html#strftime-strptime-behavior DATE_INPUT_FORMATS = [ "%Y-%m-%d", # '1887-07-26' "%y-%m-%d", # '87-07-26' "%Y %m %d", # '1887 07 26' "%Y.%m.%d", # '1887.07.26' "%d-a de %b %Y", # '26-a de jul 1887' "%d %b %Y", # '26 jul 1887' "%d-a de %B %Y", # '26-a de julio 1887' "%d %B %Y", # '26 julio 1887' "%d %m %Y", # '26 07 1887' "%d/%m/%Y", # '26/07/1887' ] TIME_INPUT_FORMATS = [ "%H:%M:%S", # '18:59:00' "%H:%M", # '18:59' ] DATETIME_INPUT_FORMATS = [ "%Y-%m-%d %H:%M:%S", # '1887-07-26 18:59:00' "%Y-%m-%d %H:%M", # '1887-07-26 18:59' "%Y.%m.%d %H:%M:%S", # '1887.07.26 18:59:00' "%Y.%m.%d %H:%M", # '1887.07.26 18:59' "%d/%m/%Y %H:%M:%S", # '26/07/1887 18:59:00' "%d/%m/%Y %H:%M", # '26/07/1887 18:59' "%y-%m-%d %H:%M:%S", # '87-07-26 18:59:00' "%y-%m-%d %H:%M", # '87-07-26 18:59' ] DECIMAL_SEPARATOR = "," THOUSAND_SEPARATOR = "\xa0" # non-breaking space NUMBER_GROUPING = 3 [92b90ded]
- # This file is distributed under the same license as the Django package. # # The *_FORMAT strings use the Django date format syntax, # see https://docs.djangoproject.com/en/dev/ref/templates/builtins/#date DATE_FORMAT = r"j\-\a \d\e F Y" # '26-a de julio 1887' TIME_FORMAT = "H:i" # '18:59' DATETIME_FORMAT = r"j\-\a \d\e F Y\, \j\e H:i" # '26-a de julio 1887, je 18:59' YEAR_MONTH_FORMAT = r"F \d\e Y" # 'julio de 1887' MONTH_DAY_FORMAT = r"j\-\a \d\e F" # '26-a de julio' SHORT_DATE_FORMAT = "Y-m-d" # '1887-07-26' SHORT_DATETIME_FORMAT = "Y-m-d H:i" # '1887-07-26 18:59' FIRST_DAY_OF_WEEK = 1 # Monday (lundo) [4e81aeb6]
