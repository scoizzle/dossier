# django/db/models/fields/related_lookups

- Subject: django/db/models/fields/related_lookups (id `4114eadc-87f5-4e9f-9a93-ebc31c67007d`)
- Kind: subject
- Budget: 1200 tokens
- Used: 888 tokens
- Facts shown: 9 of 17
- Conflicts: 0
- Gaps: 0

## Facts

- if isinstance(self.lhs, ColPairs): if ( isinstance(self.rhs, Query) and not self.rhs.has_select_fields and self.lhs.output_field.related_model is self.rhs.model ): self.rhs.set_values([f.name for f in self.lhs.sources]) else: if self.rhs_is_direct_value(): # If we get here, we are dealing with single-column relations. self.rhs = [get_normalized_value(val, self.lhs)[0] for val in self.rhs] # We need to run the related field's get_prep_value(). Consider # case ForeignKey to IntegerField given value 'abc'. The # ForeignKey itself doesn't have validation for non-integers, # so we must run validation using the target field. if hasattr(self.lhs.output_field, "path_infos"): # Run the target field's get_prep_value. We can safely # assume there is only one as we don't get to the direct # value branch otherwise. target_field = self.lhs.output_field.path_infos[-1].target_fields[ -1 ] self.rhs = [target_field.get_prep_value(v) for v in self.rhs] elif not getattr(self.rhs, "has_select_fields", True) and not getattr( self.lhs.field.target_field, "primary_key", False ): if ( getattr(self.lhs.output_field, "primary_key", False) and self.lhs.output_field.model == self.rhs.model ): # A case like # Restaurant.objects.filter(place__in=restaurant_qs), where # place is a OneToOneField and the primary key of # Restaurant. target_field = self.lhs.field.name else: target_field = self.lhs.field.target_field.name self.rhs.set_values([target_field]) return super().get_prep_lookup() [3059d10c]
- return super().as_sql(compiler, connection) [02837cac2ac6ca25]
- return super().get_prep_lookup() [d8558783]
- def as_sql(self, compiler, connection): if isinstance(self.lhs, ColPairs): if not self.rhs_is_direct_value(): raise ValueError( f"'{self.lookup_name}' doesn't support multi-column subqueries." ) self.rhs = get_normalized_value(self.rhs, self.lhs) lookup_class = tuple_lookups[self.lookup_name] lookup = lookup_class(self.lhs, self.rhs) return compiler.compile(lookup) [f698060a]
- def as_sql(self, compiler, connection): if isinstance(self.lhs, ColPairs): if self.rhs_is_direct_value(): values = [get_normalized_value(value, self.lhs) for value in self.rhs] lookup = TupleIn(self.lhs, values) else: lookup = TupleIn(self.lhs, self.rhs) return compiler.compile(lookup) [a26c4231]
- if isinstance(value, Model): if not value._is_pk_set(): raise ValueError("Model instances passed to related filters must be saved.") value_list = [] sources = composite.unnest(lhs.output_field.path_infos[-1].target_fields) for source in sources: while not isinstance(value, source.model) and source.remote_field: source = source.remote_field.model._meta.get_field( source.remote_field.field_name ) try: value_list.append(getattr(value, source.attname)) except AttributeError: # A case like # Restaurant.objects.filter(place=restaurant_instance), where # place is a OneToOneField and the primary key of Restaurant. pk = value.pk return pk if isinstance(pk, tuple) else (pk,) return tuple(value_list) if not isinstance(value, tuple): return (value,) return value [b66c625e]
- class RelatedExact(RelatedLookupMixin, Exact): pass [ef1d7458]
- class RelatedGreaterThan(RelatedLookupMixin, GreaterThan): pass [75e4dd3f]
- class RelatedGreaterThanOrEqual(RelatedLookupMixin, GreaterThanOrEqual): pass [79b246dd]

## Beyond the budget

7 more facts did not fit in the budget: [aec20406] [fd4f91b7] [b919042a] [648914ad] [4bc2d995] [b0ff78d0] [08873b1d]
