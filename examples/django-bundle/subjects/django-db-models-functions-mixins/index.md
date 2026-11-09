# django/db/models/functions/mixins

- Subject: django/db/models/functions/mixins (id `78fd3bd1-dbdd-4df6-bb92-2e750211dda4`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 538 tokens
- Facts shown: 7 facts
- Conflicts: 0
- Gaps: 0

## Facts

- return compiler.compile( SecondsToInterval( self.__class__(IntervalToSeconds(expression), **options) ) ) return super().as_sql(compiler, connection, **extra_context) [1de2bafb]
- def as_oracle(self, compiler, connection, **extra_context): if ( self.output_field.get_internal_type() == "DurationField" and not connection.features.supports_aggregation_over_interval_types ): expression = self.get_source_expressions()[0] options = self._get_repr_options() from django.db.backends.oracle.functions import ( IntervalToSeconds, SecondsToInterval, ) [2c4a2b37]
- class FixDecimalInputMixin: def as_postgresql(self, compiler, connection, **extra_context): # Cast FloatField to DecimalField as PostgreSQL doesn't support the # following function signatures: # - LOG(double, double) # - MOD(double, double) output_field = DecimalField(decimal_places=sys.float_info.dig, max_digits=1000) clone = self.copy() clone.set_source_expressions( [ ( Cast(expression, output_field) if isinstance(expression.output_field, FloatField) else expression ) for expression in self.get_source_expressions() ] ) return clone.as_sql(compiler, connection, **extra_context) [dfa98a6c]
- class FixDurationInputMixin: def as_mysql(self, compiler, connection, **extra_context): sql, params = super().as_sql(compiler, connection, **extra_context) if self.output_field.get_internal_type() == "DurationField": sql = "CAST(%s AS SIGNED)" % sql return sql, params [feaddf03]
- class NumericOutputFieldMixin: def _resolve_output_field(self): source_fields = self.get_source_fields() if any(isinstance(s, DecimalField) for s in source_fields): return DecimalField() if any(isinstance(s, IntegerField) for s in source_fields): return FloatField() return super()._resolve_output_field() if source_fields else FloatField() [ef98f3e5]
- from django.db.models.fields import DecimalField, FloatField, IntegerField from django.db.models.functions import Cast [febd29de]
- import sys [6b0cb2be5ea1bc3c-7]
