# django/conf/locale/nl/formats

- Subject: django/conf/locale/nl/formats (id `1d4b15db-4939-416f-8830-d69a7cb1abc0`)
- Kind: subject
- Budget: 1200 tokens
- Used: 766 tokens
- Facts shown: 1 of 2
- Conflicts: 0
- Gaps: 0

## Facts

- # The *_INPUT_FORMATS strings use the Python strftime format syntax, # see https://docs.python.org/library/datetime.html#strftime-strptime-behavior DATE_INPUT_FORMATS = [ "%d-%m-%Y", # '20-01-2009' "%d-%m-%y", # '20-01-09' "%d/%m/%Y", # '20/01/2009' "%d/%m/%y", # '20/01/09' "%Y/%m/%d", # '2009/01/20' # "%d %b %Y", # '20 jan 2009' # "%d %b %y", # '20 jan 09' # "%d %B %Y", # '20 januari 2009' # "%d %B %y", # '20 januari 09' ] # Kept ISO formats as one is in first position TIME_INPUT_FORMATS = [ "%H:%M:%S", # '15:23:35' "%H:%M:%S.%f", # '15:23:35.000200' "%H.%M:%S", # '15.23:35' "%H.%M:%S.%f", # '15.23:35.000200' "%H.%M", # '15.23' "%H:%M", # '15:23' ] DATETIME_INPUT_FORMATS = [ # With time in %H:%M:%S : "%d-%m-%Y %H:%M:%S", # '20-01-2009 15:23:35' "%d-%m-%y %H:%M:%S", # '20-01-09 15:23:35' "%Y-%m-%d %H:%M:%S", # '2009-01-20 15:23:35' "%d/%m/%Y %H:%M:%S", # '20/01/2009 15:23:35' "%d/%m/%y %H:%M:%S", # '20/01/09 15:23:35' "%Y/%m/%d %H:%M:%S", # '2009/01/20 15:23:35' # "%d %b %Y %H:%M:%S", # '20 jan 2009 15:23:35' # "%d %b %y %H:%M:%S", # '20 jan 09 15:23:35' # "%d %B %Y %H:%M:%S", # '20 januari 2009 15:23:35' # "%d %B %y %H:%M:%S", # '20 januari 2009 15:23:35' # With time in %H:%M:%S.%f : "%d-%m-%Y %H:%M:%S.%f", # '20-01-2009 15:23:35.000200' "%d-%m-%y %H:%M:%S.%f", # '20-01-09 15:23:35.000200' "%Y-%m-%d %H:%M:%S.%f", # '2009-01-20 15:23:35.000200' "%d/%m/%Y %H:%M:%S.%f", # '20/01/2009 15:23:35.000200' "%d/%m/%y %H:%M:%S.%f", # '20/01/09 15:23:35.000200' "%Y/%m/%d %H:%M:%S.%f", # '2009/01/20 15:23:35.000200' # With time in %H.%M:%S : "%d-%m-%Y %H.%M:%S", # '20-01-2009 15.23:35' "%d-%m-%y %H.%M:%S", # '20-01-09 15.23:35' "%d/%m/%Y %H.%M:%S", # '20/01/2009 15.23:35' "%d/%m/%y %H.%M:%S", # '20/01/09 15.23:35' # "%d %b %Y %H.%M:%S", # '20 jan 2009 15.23:35' # "%d %b %y %H.%M:%S", # '20 jan 09 15.23:35' # "%d %B %Y %H.%M:%S", # '20 januari 2009 15.23:35' # "%d %B %y %H.%M:%S", # '20 januari 2009 15.23:35' # With time in %H.%M:%S.%f : "%d-%m-%Y %H.%M:%S.%f", # '20-01-2009 15.23:35.000200' "%d-%m-%y %H.%M:%S.%f", # '20-01-09 15.23:35.000200' "%d/%m/%Y %H.%M:%S.%f", # '20/01/2009 15.23:35.000200' "%d/%m/%y %H.%M:%S.%f", # '20/01/09 15.23:35.000200' # With time in %H:%M : "%d-%m-%Y %H:%M", # '20-01-2009 15:23' "%d-%m-%y %H:%M", # '20-01-09 15:23' "%Y-%m-%d %H:%M", # '2009-01-20 15:23' "%d/%m/%Y %H:%M", # '20/01/2009 15:23' "%d/%m/%y %H:%M", # '20/01/09 15:23' "%Y/%m/%d %H:%M", # '2009/01/20 15:23' # "%d %b %Y %H:%M", # '20 jan 2009 15:23' # "%d %b %y %H:%M", # '20 jan 09 15:23' # "%d %B %Y %H:%M", # '20 januari 2009 15:23' # "%d %B %y %H:%M", # '20 januari 2009 15:23' # With time in %H.%M : "%d-%m-%Y %H.%M", # '20-01-2009 15.23' "%d-%m-%y %H.%M", # '20-01-09 15.23' "%d/%m/%Y %H.%M", # '20/01/2009 15.23' "%d/%m/%y %H.%M", # '20/01/09 15.23' # "%d %b %Y %H.%M", # '20 jan 2009 15.23' # "%d %b %y %H.%M", # '20 jan 09 15.23' # "%d %B %Y %H.%M", # '20 januari 2009 15.23' # "%d %B %y %H.%M", # '20 januari 2009 15.23' ] DECIMAL_SEPARATOR = "," THOUSAND_SEPARATOR = "." NUMBER_GROUPING = 3 [d381db85]

## Beyond the budget

1 more facts did not fit in the budget: [dbb02331]
