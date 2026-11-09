# django/contrib/postgres/indexes

- Subject: django/contrib/postgres/indexes (id `3bbba49f-d9ac-4340-a5d6-119241eb7070`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 13 of 37
- Conflicts: 0
- Gaps: 0

## Facts

- def __init__( self, *expressions, autosummarize=None, pages_per_range=None, **kwargs ): if pages_per_range is not None and pages_per_range <= 0: raise ValueError("pages_per_range must be None or a positive integer") self.autosummarize = autosummarize self.pages_per_range = pages_per_range super().__init__(*expressions, **kwargs) [317048f5]
- def __init__( self, *expressions, fastupdate=None, gin_pending_list_limit=None, **kwargs ): self.fastupdate = fastupdate self.gin_pending_list_limit = gin_pending_list_limit super().__init__(*expressions, **kwargs) [4da4f7a6]
- def __init__(self, *expressions, buffering=None, fillfactor=None, **kwargs): self.buffering = buffering self.fillfactor = fillfactor super().__init__(*expressions, **kwargs) [f70c893d]
- def __init__(self, *expressions, fillfactor=None, deduplicate_items=None, **kwargs): self.fillfactor = fillfactor self.deduplicate_items = deduplicate_items super().__init__(*expressions, **kwargs) [13dd7364]
- def __init__(self, *expressions, length=None, columns=(), **kwargs): super().__init__(*expressions, **kwargs) if len(self.fields) > 32: raise ValueError("Bloom indexes support a maximum of 32 fields.") if not isinstance(columns, (list, tuple)): raise ValueError("BloomIndex.columns must be a list or tuple.") if len(columns) > len(self.fields): raise ValueError("BloomIndex.columns cannot have more values than fields.") if not all(0 < col <= 4095 for col in columns): raise ValueError( "BloomIndex.columns must contain integers from 1 to 4095.", ) if length is not None and not 0 < length <= 4096: raise ValueError( "BloomIndex.length must be None or an integer from 1 to 4096.", ) self.length = length self.columns = columns [799b32f7]
- def __init__(self, expression, name): super().__init__(expression, name=name) [96d71192]
- def check_supported(self, schema_editor): pass [3219a3e7]
- def create_sql(self, model, schema_editor, using="", **kwargs): self.check_supported(schema_editor) statement = super().create_sql( model, schema_editor, using=" USING %s" % (using or self.suffix), **kwargs ) with_params = self.get_with_params() if with_params: statement.parts["extra"] = " WITH (%s)%s" % ( ", ".join(with_params), statement.parts["extra"], ) return statement [b1fbf2d3]
- def deconstruct(self): path, args, kwargs = super().deconstruct() if self.autosummarize is not None: kwargs["autosummarize"] = self.autosummarize if self.pages_per_range is not None: kwargs["pages_per_range"] = self.pages_per_range return path, args, kwargs [27e3ec5b]
- def deconstruct(self): path, args, kwargs = super().deconstruct() if self.buffering is not None: kwargs["buffering"] = self.buffering if self.fillfactor is not None: kwargs["fillfactor"] = self.fillfactor return path, args, kwargs [94893f55]
- def deconstruct(self): path, args, kwargs = super().deconstruct() if self.fastupdate is not None: kwargs["fastupdate"] = self.fastupdate if self.gin_pending_list_limit is not None: kwargs["gin_pending_list_limit"] = self.gin_pending_list_limit return path, args, kwargs [da6ea248]
- def get_with_params(self): return [] [895fc3c5]
- __all__ = [ "BloomIndex", "BrinIndex", "BTreeIndex", "GinIndex", "GistIndex", "HashIndex", "SpGistIndex", ] [e4f3adc4]

## Beyond the budget

18 more facts did not fit in the budget: [b1a36e43] [0fc09ab7] [e07899ac] [ee3381b2] [33efcc1d63e52517] [9c09baaa] [9ada9d58] [92527b76] [e328aa25] [0006c8a6] [3b66c5aa] [d37d181b] [3af2890a] [b7a4925d] [8695d2e1] [83f8ecc3] [ab2bac21886a7863] [25666096]
