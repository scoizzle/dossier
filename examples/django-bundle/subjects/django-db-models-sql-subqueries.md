# django/db/models/sql/subqueries

- Subject: django/db/models/sql/subqueries (id `5d143c40-f439-478d-95eb-23afca5176f4`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 14 of 25
- Conflicts: 0
- Gaps: 0

## Facts

- More than one physical query may be executed if there are a lot of values in pk_list. """ # number of objects deleted num_deleted = 0 field = self.get_meta().pk for offset in range(0, len(pk_list), GET_ITERATOR_CHUNK_SIZE): self.clear_where() self.add_filter( f"{field.attname}__in", pk_list[offset : offset + GET_ITERATOR_CHUNK_SIZE], ) num_deleted += self.do_query( self.get_meta().db_table, self.where, using=using ) return num_deleted [8a623e33]
- Update are coalesced so that only one update query per ancestor is run. """ self.related_updates.setdefault(model, []).append((field, None, value)) [31dc0951]
- compiler = "SQLAggregateCompiler" [807d7ab7]
- compiler = "SQLDeleteCompiler" [b9a3625f]
- compiler = "SQLUpdateCompiler" [ddc45f30]
- def __init__( self, *args, on_conflict=None, update_fields=None, unique_fields=None, **kwargs ): super().__init__(*args, **kwargs) self.fields = [] self.objs = [] self.on_conflict = on_conflict self.update_fields = update_fields or [] self.unique_fields = unique_fields or [] [a747bf7d]
- def __init__(self, *args, **kwargs): super().__init__(*args, **kwargs) self._setup_query() [a18a7ce9]
- def __init__(self, model, inner_query): self.inner_query = inner_query super().__init__(model) [ee3e12ab]
- def _setup_query(self): """ Run on initialization and at the end of chaining. Any attributes that would normally be set in __init__() should go here instead. """ self.values = [] self.related_ids = None self.related_updates = {} [8ca1968b]
- def add_related_update(self, model, field, value): """ Add (name, value) to an update query for an ancestor model. [43c4574e]
- def add_update_fields(self, values_seq): """ Append a sequence of (field, model, value) triples to the internal list that will be used to generate the UPDATE query. Might be more usefully called add_update_targets() to hint at the extra information here. """ for field, model, val in values_seq: # Omit generated fields. if field.generated: continue if hasattr(val, "resolve_expression"): # Resolve expressions here so that annotations are no longer # needed val = val.resolve_expression(self, allow_joins=False, for_save=True) self.values.append((field, model, val)) [4e754d48]
- def add_update_values(self, values): """ Convert a dictionary of field name to value mappings into an update query. This is the entry point for the public update() method on querysets. """ values_seq = [] for name, val in values.items(): field = self.get_meta().get_field(name) model = field.model._meta.concrete_model if field.name == "pk" and model._meta.is_composite_pk: raise FieldError( "Composite primary key fields must be updated individually." ) if not field.concrete: raise FieldError( "Cannot update model field %r (only concrete fields are permitted)." % field ) if model is not self.get_meta().concrete_model: self.add_related_update(model, field, val) continue values_seq.append((field, model, val)) return self.add_update_fields(values_seq) [96fc2dab]
- def clone(self): obj = super().clone() obj.related_updates = self.related_updates.copy() return obj [946bbd6e]
- """ Query subclasses which provide extra functionality beyond simple data retrieval. """ [f7453741]

## Beyond the budget

11 more facts did not fit in the budget: [0e837a48] [737d3c8f] [6209c872] [318f17ff] [f88288d8] [49a6c20d] [512413f0] [17573ca5] [caa181c5] [6c8897f0] [0c31bef3]
