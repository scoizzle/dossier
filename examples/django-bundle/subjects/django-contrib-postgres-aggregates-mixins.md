# django/contrib/postgres/aggregates/mixins

- Subject: django/contrib/postgres/aggregates/mixins (id `0f100d08-dee0-4496-946f-219341c16749`)
- Kind: subject
- Budget: 1200 tokens
- Used: 162 tokens
- Facts shown: 4 of 4
- Conflicts: 0
- Gaps: 0

## Facts

- def __init_subclass__(cls, /, *args, **kwargs): warnings.warn( "OrderableAggMixin is deprecated. Use Aggregate and allow_order_by " "instead.", category=RemovedInDjango2028Warning, stacklevel=1, ) super().__init_subclass__(*args, **kwargs) [5173196f]
- # RemovedInDjango2028Warning. class OrderableAggMixin: allow_order_by = True [2d041984]
- # RemovedInDjango2028Warning: When the deprecation ends, remove completely. import warnings [f709b404]
- from django.utils.deprecation import RemovedInDjango2028Warning [5da61119]
