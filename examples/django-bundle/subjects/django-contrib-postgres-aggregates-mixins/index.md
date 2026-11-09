# django/contrib/postgres/aggregates/mixins

- Subject: django/contrib/postgres/aggregates/mixins (id `195dd63e-5aec-4050-832c-3069f1086419`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 162 tokens
- Facts shown: 4 facts
- Conflicts: 0
- Gaps: 0

## Facts

- def __init_subclass__(cls, /, *args, **kwargs): warnings.warn( "OrderableAggMixin is deprecated. Use Aggregate and allow_order_by " "instead.", category=RemovedInDjango2028Warning, stacklevel=1, ) super().__init_subclass__(*args, **kwargs) [5173196f]
- # RemovedInDjango2028Warning. class OrderableAggMixin: allow_order_by = True [2d041984]
- # RemovedInDjango2028Warning: When the deprecation ends, remove completely. import warnings [f709b404]
- from django.utils.deprecation import RemovedInDjango2028Warning [5da61119]
