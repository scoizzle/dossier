# django/contrib/postgres/aggregates/general

- Subject: django/contrib/postgres/aggregates/general (id `6c4f23a9-4b7f-49d2-af2e-04ad3e234ab2`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 835 tokens
- Facts shown: 16 facts
- Conflicts: 0
- Gaps: 0

## Facts

- delimiter = Value(delimiter) [85ae1c6a]
- super().__init__(expression, delimiter, **extra) [b64d08c7]
- warnings.warn( "The PostgreSQL specific StringAgg function is deprecated. Use " "django.db.models.aggregates.StringAgg instead.", category=RemovedInDjango2028Warning, stacklevel=2, ) [f95fc21c]
- @property def output_field(self): return ArrayField(self.source_expressions[0].output_field) [11d5e6fa]
- def __init__(self, expression, delimiter, **extra): if isinstance(delimiter, str): warnings.warn( "delimiter: str will be resolved as a field reference instead " "of a string literal on Django 2028. Pass " f"`delimiter=Value({delimiter!r})` to preserve the previous behavior.", category=RemovedInDjango2028Warning, stacklevel=2, ) [8af6487e]
- # RemovedInDjango2028Warning: When the deprecation ends, remove completely. class StringAgg(_StringAgg): [9078ec86]
- __all__ = [ "ArrayAgg", "BitAnd", # RemovedInDjango2028Warning "BitOr", # RemovedInDjango2028Warning "BitXor", # RemovedInDjango2028Warning "BoolAnd", "BoolOr", "JSONBAgg", "StringAgg", # RemovedInDjango2028Warning. ] [003b7f42]
- class ArrayAgg(Aggregate): function = "ARRAY_AGG" allow_distinct = True allow_order_by = True [504a25e7]
- class BitAnd(_BitAnd): def __init__(self, expression, **extra): warnings.warn( "The PostgreSQL-specific BitAnd function is deprecated. Use " "django.db.models.aggregates.BitAnd instead.", category=RemovedInDjango2028Warning, stacklevel=2, ) super().__init__(expression, **extra) [847d77a5]
- class BitOr(_BitOr): def __init__(self, expression, **extra): warnings.warn( "The PostgreSQL-specific BitOr function is deprecated. Use " "django.db.models.aggregates.BitOr instead.", category=RemovedInDjango2028Warning, stacklevel=2, ) super().__init__(expression, **extra) [ef1a5cc6]
- class BitXor(_BitXor): def __init__(self, expression, **extra): warnings.warn( "The PostgreSQL-specific BitXor function is deprecated. Use " "django.db.models.aggregates.BitXor instead.", category=RemovedInDjango2028Warning, stacklevel=2, ) super().__init__(expression, **extra) [822958a5]
- class BoolAnd(Aggregate): function = "BOOL_AND" output_field = BooleanField() [810e8da3]
- class BoolOr(Aggregate): function = "BOOL_OR" output_field = BooleanField() [1469dd5b]
- class JSONBAgg(Aggregate): function = "JSONB_AGG" allow_distinct = True allow_order_by = True output_field = JSONField() [50331243]
- from django.contrib.postgres.fields import ArrayField from django.db.models import Aggregate from django.db.models import BitAnd as _BitAnd from django.db.models import BitOr as _BitOr from django.db.models import BitXor as _BitXor from django.db.models import BooleanField, JSONField from django.db.models import StringAgg as _StringAgg from django.db.models import Value from django.utils.deprecation import RemovedInDjango2028Warning [18d35f52]
- import warnings [a7aa58d143dc3945-2]
