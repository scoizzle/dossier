# django/db/models/functions/window

- Subject: django/db/models/functions/window (id `2393f70c-b109-478d-840b-99c904284708`)
- Kind: subject
- Budget: 1200 tokens
- Used: 744 tokens
- Facts shown: 18 of 19
- Conflicts: 0
- Gaps: 0

## Facts

- def __init__(self, expression, nth=1, **extra): if expression is None: raise ValueError( "%s requires a non-null source expression." % self.__class__.__name__ ) if nth is None or nth <= 0: raise ValueError( "%s requires a positive integer as for nth." % self.__class__.__name__ ) super().__init__(expression, nth, **extra) [7af2cfea]
- def __init__(self, expression, offset=1, default=None, **extra): if expression is None: raise ValueError( "%s requires a non-null source expression." % self.__class__.__name__ ) if offset is None or offset <= 0: raise ValueError( "%s requires a positive integer for the offset." % self.__class__.__name__ ) args = (expression, offset) if default is not None: args += (default,) super().__init__(*args, **extra) [bcb7d725]
- def __init__(self, num_buckets=1, **extra): if num_buckets <= 0: raise ValueError("num_buckets must be greater than 0.") super().__init__(num_buckets, **extra) [f5327c29]
- def _resolve_output_field(self): sources = self.get_source_expressions() return sources[0].output_field [c722ba755cb416b3]
- __all__ = [ "CumeDist", "DenseRank", "FirstValue", "Lag", "LastValue", "Lead", "NthValue", "Ntile", "PercentRank", "Rank", "RowNumber", ] [a630915a]
- class CumeDist(Func): function = "CUME_DIST" output_field = FloatField() window_compatible = True [5a97f062]
- class DenseRank(Func): function = "DENSE_RANK" output_field = IntegerField() window_compatible = True [70155ac3]
- class FirstValue(Func): arity = 1 function = "FIRST_VALUE" window_compatible = True [378a6522]
- class Lag(LagLeadFunction): function = "LAG" [a988d53e]
- class LagLeadFunction(Func): window_compatible = True [a906bde5]
- class LastValue(Func): arity = 1 function = "LAST_VALUE" window_compatible = True [ecc19adb]
- class Lead(LagLeadFunction): function = "LEAD" [3822770c]
- class NthValue(Func): function = "NTH_VALUE" window_compatible = True [c135ea24]
- class Ntile(Func): function = "NTILE" output_field = IntegerField() window_compatible = True [47e76df3]
- class PercentRank(Func): function = "PERCENT_RANK" output_field = FloatField() window_compatible = True [31c96d1e]
- class Rank(Func): function = "RANK" output_field = IntegerField() window_compatible = True [b4cc2b73]
- class RowNumber(Func): function = "ROW_NUMBER" output_field = IntegerField() window_compatible = True [8356c4d3]
- from django.db.models.expressions import Func from django.db.models.fields import FloatField, IntegerField [90823d9b]
