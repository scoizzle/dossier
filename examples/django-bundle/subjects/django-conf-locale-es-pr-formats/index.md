# django/conf/locale/es_PR/formats

- Subject: django/conf/locale/es_PR/formats (id `d9c5fe53-5ea5-4d94-ab55-ab2b14e6346e`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 192 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- # This file is distributed under the same license as the Django package. # DATE_FORMAT = r"j \d\e F \d\e Y" TIME_FORMAT = "H:i" DATETIME_FORMAT = r"j \d\e F \d\e Y \a \l\a\s H:i" YEAR_MONTH_FORMAT = r"F \d\e Y" MONTH_DAY_FORMAT = r"j \d\e F" SHORT_DATE_FORMAT = "d/m/Y" SHORT_DATETIME_FORMAT = "d/m/Y H:i" FIRST_DAY_OF_WEEK = 0 # Sunday [0177deac]
- DATE_INPUT_FORMATS = [ "%d/%m/%Y", # '31/12/2009' "%d/%m/%y", # '31/12/09' ] DATETIME_INPUT_FORMATS = [ "%d/%m/%Y %H:%M:%S", "%d/%m/%Y %H:%M:%S.%f", "%d/%m/%Y %H:%M", "%d/%m/%y %H:%M:%S", "%d/%m/%y %H:%M:%S.%f", "%d/%m/%y %H:%M", ] [70e0e2c1]
- DECIMAL_SEPARATOR = "." THOUSAND_SEPARATOR = "," NUMBER_GROUPING = 3 [e96a7beb16daff4e]
