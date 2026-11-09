# django/db/backends/oracle/functions

- Subject: django/db/backends/oracle/functions (id `c75f05d8-0b76-478a-8c66-b8f77dc3ec72`)
- Kind: subject
- Budget: 1200 tokens
- Used: 230 tokens
- Facts shown: 5 of 5
- Conflicts: 0
- Gaps: 0

## Facts

- def __init__(self, expression, *, output_field=None, **extra): super().__init__( expression, output_field=output_field or DecimalField(), **extra ) [abedcef9]
- def __init__(self, expression, *, output_field=None, **extra): super().__init__( expression, output_field=output_field or DurationField(), **extra ) [bf7331b2]
- class IntervalToSeconds(Func): function = "" template = """ EXTRACT(day from %(expressions)s) * 86400 + EXTRACT(hour from %(expressions)s) * 3600 + EXTRACT(minute from %(expressions)s) * 60 + EXTRACT(second from %(expressions)s) """ [fcd5ca18]
- class SecondsToInterval(Func): function = "NUMTODSINTERVAL" template = "%(function)s(%(expressions)s, 'SECOND')" [8c7a7989]
- from django.db.models import DecimalField, DurationField, Func [da6a361a]
