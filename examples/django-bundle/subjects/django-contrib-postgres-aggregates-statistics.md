# django/contrib/postgres/aggregates/statistics

- Subject: django/contrib/postgres/aggregates/statistics (id `d138cf02-f4ef-4ed7-8047-73ba7e499323`)
- Kind: subject
- Budget: 1200 tokens
- Used: 490 tokens
- Facts shown: 15 of 15
- Conflicts: 0
- Gaps: 0

## Facts

- def __init__(self, y, x, output_field=None, filter=None, default=None): if not x or not y: raise ValueError("Both y and x must be provided.") super().__init__( y, x, output_field=output_field, filter=filter, default=default ) [4feb79b2]
- __all__ = [ "CovarPop", "Corr", "RegrAvgX", "RegrAvgY", "RegrCount", "RegrIntercept", "RegrR2", "RegrSlope", "RegrSXX", "RegrSXY", "RegrSYY", "StatAggregate", ] [2ab7b18e]
- class Corr(StatAggregate): function = "CORR" [ab8cf4ba]
- class CovarPop(StatAggregate): def __init__(self, y, x, sample=False, filter=None, default=None): self.function = "COVAR_SAMP" if sample else "COVAR_POP" super().__init__(y, x, filter=filter, default=default) [4096e633]
- class RegrAvgX(StatAggregate): function = "REGR_AVGX" [a514cf76]
- class RegrAvgY(StatAggregate): function = "REGR_AVGY" [da916756]
- class RegrCount(StatAggregate): function = "REGR_COUNT" output_field = IntegerField() empty_result_set_value = 0 [33f02003]
- class RegrIntercept(StatAggregate): function = "REGR_INTERCEPT" [24255812]
- class RegrR2(StatAggregate): function = "REGR_R2" [337e3a43]
- class RegrSXX(StatAggregate): function = "REGR_SXX" [d6e2e369]
- class RegrSXY(StatAggregate): function = "REGR_SXY" [92bcf87d]
- class RegrSYY(StatAggregate): function = "REGR_SYY" [a5a6fe2c]
- class RegrSlope(StatAggregate): function = "REGR_SLOPE" [4c2f4d61]
- class StatAggregate(Aggregate): output_field = FloatField() [a134c629]
- from django.db.models import Aggregate, FloatField, IntegerField [0b374e96]
