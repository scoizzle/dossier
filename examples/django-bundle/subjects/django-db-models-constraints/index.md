# django/db/models/constraints

- Subject: django/db/models/constraints (id `9d90a711-8a0b-43a0-85cf-ec996f9d8007`)
- Kind: subject
- Budget: 1200 tokens
- Used: 888 tokens
- Facts shown: 11 of 42
- Conflicts: 0
- Gaps: 0

## Facts

- errors = [] fields = set() for field_name, *lookups in references: # pk is an alias that won't be found by opts.get_field(). if field_name != "pk" or isinstance(model._meta.pk, CompositePrimaryKey): fields.add(field_name) if not lookups: # If it has no lookups it cannot result in a JOIN. continue try: if field_name == "pk": field = model._meta.pk else: field = model._meta.get_field(field_name) if not field.is_relation or field.many_to_many or field.one_to_many: continue except FieldDoesNotExist: continue # JOIN must happen at the first lookup. first_lookup = lookups[0] if ( hasattr(field, "get_transform") and hasattr(field, "get_lookup") and field.get_transform(first_lookup) is None and field.get_lookup(first_lookup) is None ): errors.append( checks.Error( "'constraints' refers to the joined field '%s'." % LOOKUP_SEP.join([field_name, *lookups]), obj=model, id="models.E041", ) ) errors.extend(model._check_local_fields(fields, "constraints")) return errors [5a0244bb]
- # A similar format was proposed for Python 3.10. def __repr__(self): return f"{self.__class__.__qualname__}.{self._name_}" [d4f2b40e79af3ae1]
- @classmethod def _expression_refs_exclude(cls, model, expression, exclude): get_field = model._meta.get_field for field_name, *__ in model._get_expr_references(expression): if field_name == "pk": field = model._meta.pk else: field = get_field(field_name) if field_name in exclude or field.name in exclude: return True if field.generated and cls._expression_refs_exclude( model, field.expression, exclude ): return True return False [57fa8785]
- @property def contains_expressions(self): return False [db2b599d]
- @property def contains_expressions(self): return bool(self.expressions) [cdf2a666e0d49cf8]
- def __eq__(self, other): if isinstance(other, CheckConstraint): return ( self.name == other.name and self.condition == other.condition and self.violation_error_code == other.violation_error_code and self.violation_error_message == other.violation_error_message ) return super().__eq__(other) [90b63971]
- def __eq__(self, other): if isinstance(other, UniqueConstraint): return ( self.name == other.name and self.fields == other.fields and self.condition == other.condition and self.deferrable == other.deferrable and self.include == other.include and self.opclasses == other.opclasses and self.expressions == other.expressions and self.nulls_distinct is other.nulls_distinct and self.violation_error_code == other.violation_error_code and self.violation_error_message == other.violation_error_message ) return super().__eq__(other) [daf0507f]
- def __init__( self, *, name, violation_error_code=None, violation_error_message=None ): self.name = name if violation_error_code is not None: self.violation_error_code = violation_error_code if violation_error_message is not None: self.violation_error_message = violation_error_message else: self.violation_error_message = self.default_violation_error_message [53d29e5e]
- def _check_references(self, model, references): from django.db.models.fields.composite import CompositePrimaryKey [fd536cc4]
- def check(self, model, connection): return [] [27f63d04]
- def clone(self): _, args, kwargs = self.deconstruct() return self.__class__(*args, **kwargs) [abe79cbf]

## Beyond the budget

26 more facts did not fit in the budget: [ce36f9e9] [4cf52e0b] [a48ce518] [2bf6b91b] [162d91cd] [860274d9] [12fa71ef] [8dbd4078] [773922ee] [1022f933] [449cda74] [c373350e] [b18542c3] [ee6e9457] [7781a3de] [9ce69485] [65ddaaf6] [b3e9052b] [da0e97d8] [229ffbc9] [befe5333] [da2c8236] [1e5261d6] [aba7fd66] [74b47d2c] [64e0caba]
