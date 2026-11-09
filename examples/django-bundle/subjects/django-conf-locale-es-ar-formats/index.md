# django/conf/locale/es_AR/formats

- Subject: django/conf/locale/es_AR/formats (id `44c1f5e4-5172-49e1-baf7-927e75354d8d`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 246 tokens
- Facts shown: 2 of 2
- Conflicts: 0
- Gaps: 0

## Facts

- # The *_INPUT_FORMATS strings use the Python strftime format syntax, # see https://docs.python.org/library/datetime.html#strftime-strptime-behavior DATE_INPUT_FORMATS = [ "%d/%m/%Y", # '31/12/2009' "%d/%m/%y", # '31/12/09' ] DATETIME_INPUT_FORMATS = [ "%d/%m/%Y %H:%M:%S", "%d/%m/%Y %H:%M:%S.%f", "%d/%m/%Y %H:%M", "%d/%m/%y %H:%M:%S", "%d/%m/%y %H:%M:%S.%f", "%d/%m/%y %H:%M", ] DECIMAL_SEPARATOR = "," THOUSAND_SEPARATOR = "." NUMBER_GROUPING = 3 [8d2af614b94599f0-2]
- # This file is distributed under the same license as the Django package. # # The *_FORMAT strings use the Django date format syntax, # see https://docs.djangoproject.com/en/dev/ref/templates/builtins/#date DATE_FORMAT = r"j N Y" TIME_FORMAT = r"H:i" DATETIME_FORMAT = r"j N Y H:i" YEAR_MONTH_FORMAT = r"F Y" MONTH_DAY_FORMAT = r"j \d\e F" SHORT_DATE_FORMAT = r"d/m/Y" SHORT_DATETIME_FORMAT = r"d/m/Y H:i" FIRST_DAY_OF_WEEK = 0 # 0: Sunday, 1: Monday [e5aac41b]
