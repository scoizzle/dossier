# django/conf/locale/zh_Hant/formats

- Subject: django/conf/locale/zh_Hant/formats (id `7dfb2f31-9d60-48e9-a7c8-80ddf9826039`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 402 tokens
- Facts shown: 5 facts
- Conflicts: 0
- Gaps: 0

## Facts

- # The *_INPUT_FORMATS strings use the Python strftime format syntax, # see https://docs.python.org/library/datetime.html#strftime-strptime-behavior DATE_INPUT_FORMATS = [ "%Y/%m/%d", # '2016/09/05' "%Y-%m-%d", # '2016-09-05' "%Y年%n月%j日", # '2016年9月5日' ] [b93a5e1818df79e9-2]
- # This file is distributed under the same license as the Django package. # # The *_FORMAT strings use the Django date format syntax, # see https://docs.djangoproject.com/en/dev/ref/templates/builtins/#date DATE_FORMAT = "Y年n月j日" # 2016年9月5日 TIME_FORMAT = "H:i" # 20:45 DATETIME_FORMAT = "Y年n月j日 H:i" # 2016年9月5日 20:45 YEAR_MONTH_FORMAT = "Y年n月" # 2016年9月 MONTH_DAY_FORMAT = "m月j日" # 9月5日 SHORT_DATE_FORMAT = "Y年n月j日" # 2016年9月5日 SHORT_DATETIME_FORMAT = "Y年n月j日 H:i" # 2016年9月5日 20:45 FIRST_DAY_OF_WEEK = 1 # 星期一 (Monday) [dbbcf8eea39b7e71-2]
- DATETIME_INPUT_FORMATS = [ "%Y/%m/%d %H:%M", # '2016/09/05 20:45' "%Y-%m-%d %H:%M", # '2016-09-05 20:45' "%Y年%n月%j日 %H:%M", # '2016年9月5日 14:45' "%Y/%m/%d %H:%M:%S", # '2016/09/05 20:45:29' "%Y-%m-%d %H:%M:%S", # '2016-09-05 20:45:29' "%Y年%n月%j日 %H:%M:%S", # '2016年9月5日 20:45:29' "%Y/%m/%d %H:%M:%S.%f", # '2016/09/05 20:45:29.000200' "%Y-%m-%d %H:%M:%S.%f", # '2016-09-05 20:45:29.000200' "%Y年%n月%j日 %H:%n:%S.%f", # '2016年9月5日 20:45:29.000200' ] [3a4258edaacfbbc9-2]
- DECIMAL_SEPARATOR = "." THOUSAND_SEPARATOR = "" NUMBER_GROUPING = 4 [18d550103eece3dd-2]
- TIME_INPUT_FORMATS = [ "%H:%M", # '20:45' "%H:%M:%S", # '20:45:29' "%H:%M:%S.%f", # '20:45:29.000200' ] [bbff399260dc4664-2]
