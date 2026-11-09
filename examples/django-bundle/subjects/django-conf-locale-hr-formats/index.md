# django/conf/locale/hr/formats

- Subject: django/conf/locale/hr/formats (id `e70f2bdb-1ebc-4995-b2df-d3b3d4974bb5`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 437 tokens
- Facts shown: 3 facts
- Conflicts: 0
- Gaps: 0

## Facts

- # The *_INPUT_FORMATS strings use the Python strftime format syntax, # see https://docs.python.org/library/datetime.html#strftime-strptime-behavior # Kept ISO formats as they are in first position DATE_INPUT_FORMATS = [ "%Y-%m-%d", # '2006-10-25' "%d.%m.%Y.", # '25.10.2006.' "%d.%m.%y.", # '25.10.06.' "%d. %m. %Y.", # '25. 10. 2006.' "%d. %m. %y.", # '25. 10. 06.' ] DATETIME_INPUT_FORMATS = [ "%Y-%m-%d %H:%M:%S", # '2006-10-25 14:30:59' "%Y-%m-%d %H:%M:%S.%f", # '2006-10-25 14:30:59.000200' "%Y-%m-%d %H:%M", # '2006-10-25 14:30' "%d.%m.%Y. %H:%M:%S", # '25.10.2006. 14:30:59' "%d.%m.%Y. %H:%M:%S.%f", # '25.10.2006. 14:30:59.000200' "%d.%m.%Y. %H:%M", # '25.10.2006. 14:30' "%d.%m.%y. %H:%M:%S", # '25.10.06. 14:30:59' "%d.%m.%y. %H:%M:%S.%f", # '25.10.06. 14:30:59.000200' "%d.%m.%y. %H:%M", # '25.10.06. 14:30' "%d. %m. %Y. %H:%M:%S", # '25. 10. 2006. 14:30:59' "%d. %m. %Y. %H:%M:%S.%f", # '25. 10. 2006. 14:30:59.000200' "%d. %m. %Y. %H:%M", # '25. 10. 2006. 14:30' "%d. %m. %y. %H:%M:%S", # '25. 10. 06. 14:30:59' "%d. %m. %y. %H:%M:%S.%f", # '25. 10. 06. 14:30:59.000200' "%d. %m. %y. %H:%M", # '25. 10. 06. 14:30' ] [61ea1f9f]
- # This file is distributed under the same license as the Django package. # # The *_FORMAT strings use the Django date format syntax, # see https://docs.djangoproject.com/en/dev/ref/templates/builtins/#date DATE_FORMAT = "j. E Y." TIME_FORMAT = "H:i" DATETIME_FORMAT = "j. E Y. H:i" YEAR_MONTH_FORMAT = "F Y." MONTH_DAY_FORMAT = "j. F" SHORT_DATE_FORMAT = "j.m.Y." SHORT_DATETIME_FORMAT = "j.m.Y. H:i" FIRST_DAY_OF_WEEK = 1 [37d4f992]
- DECIMAL_SEPARATOR = "," THOUSAND_SEPARATOR = "." NUMBER_GROUPING = 3 [95de59b49d598aec]
