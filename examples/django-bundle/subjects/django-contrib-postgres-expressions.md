# django/contrib/postgres/expressions

- Subject: django/contrib/postgres/expressions (id `fe4637b3-0f99-4431-a7f2-4389743dc224`)
- Kind: subject
- Budget: 1200 tokens
- Used: 136 tokens
- Facts shown: 4 of 4
- Conflicts: 0
- Gaps: 0

## Facts

- @cached_property def output_field(self): return ArrayField(self.query.output_field) [a7bf7c6e]
- def __init__(self, queryset, **kwargs): super().__init__(queryset, **kwargs) [9b2b6dc1]
- class ArraySubquery(Subquery): template = "ARRAY(%(subquery)s)" [9376ae37]
- from django.contrib.postgres.fields import ArrayField from django.db.models import Subquery from django.utils.functional import cached_property [15f73cec]
