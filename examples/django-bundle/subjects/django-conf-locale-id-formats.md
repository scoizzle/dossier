# django/conf/locale/id/formats

- Subject: django/conf/locale/id/formats (id `05f611c1-6c0c-4449-950c-e053284de85e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 436 tokens
- Facts shown: 5 of 5
- Conflicts: 0
- Gaps: 0

## Facts

- # The *_INPUT_FORMATS strings use the Python strftime format syntax, # see https://docs.python.org/library/datetime.html#strftime-strptime-behavior DATE_INPUT_FORMATS = [ "%d-%m-%Y", # '25-10-2009' "%d/%m/%Y", # '25/10/2009' "%d-%m-%y", # '25-10-09' "%d/%m/%y", # '25/10/09' "%d %b %Y", # '25 Oct 2006', "%d %B %Y", # '25 October 2006' "%m/%d/%y", # '10/25/06' "%m/%d/%Y", # '10/25/2009' ] [ce43b0b6]
- # This file is distributed under the same license as the Django package. # # The *_FORMAT strings use the Django date format syntax, # see https://docs.djangoproject.com/en/dev/ref/templates/builtins/#date DATE_FORMAT = "j N Y" DATETIME_FORMAT = "j N Y, G.i" TIME_FORMAT = "G.i" YEAR_MONTH_FORMAT = "F Y" MONTH_DAY_FORMAT = "j F" SHORT_DATE_FORMAT = "d-m-Y" SHORT_DATETIME_FORMAT = "d-m-Y G.i" FIRST_DAY_OF_WEEK = 1 # Monday [5b064bfc]
- DATETIME_INPUT_FORMATS = [ "%d-%m-%Y %H.%M.%S", # '25-10-2009 14.30.59' "%d-%m-%Y %H.%M.%S.%f", # '25-10-2009 14.30.59.000200' "%d-%m-%Y %H.%M", # '25-10-2009 14.30' "%d-%m-%y %H.%M.%S", # '25-10-09' 14.30.59' "%d-%m-%y %H.%M.%S.%f", # '25-10-09' 14.30.59.000200' "%d-%m-%y %H.%M", # '25-10-09' 14.30' "%m/%d/%y %H.%M.%S", # '10/25/06 14.30.59' "%m/%d/%y %H.%M.%S.%f", # '10/25/06 14.30.59.000200' "%m/%d/%y %H.%M", # '10/25/06 14.30' "%m/%d/%Y %H.%M.%S", # '25/10/2009 14.30.59' "%m/%d/%Y %H.%M.%S.%f", # '25/10/2009 14.30.59.000200' "%m/%d/%Y %H.%M", # '25/10/2009 14.30' ] [8a0c284b]
- DECIMAL_SEPARATOR = "," THOUSAND_SEPARATOR = "." NUMBER_GROUPING = 3 [95de59b49d598aec-2]
- TIME_INPUT_FORMATS = [ "%H.%M.%S", # '14.30.59' "%H.%M", # '14.30' ] [b3733edc]
