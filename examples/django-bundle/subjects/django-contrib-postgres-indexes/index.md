# django/contrib/postgres/indexes

- Subject: django/contrib/postgres/indexes (id `83b1a310-e607-41e4-bb1d-a823caaef118`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2074 tokens
- Facts shown: 37 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- def __init__( self, *expressions, autosummarize=None, pages_per_range=None, **kwargs ): if pages_per_range is not None and pages_per_range <= 0: raise ValueError("pages_per_range must be None or a positive integer") self.autosummarize = autosummarize self.pages_per_range = pages_per_range super().__init__(*expressions, **kwargs) [317048f5]
- def __init__( self, *expressions, fastupdate=None, gin_pending_list_limit=None, **kwargs ): self.fastupdate = fastupdate self.gin_pending_list_limit = gin_pending_list_limit super().__init__(*expressions, **kwargs) [4da4f7a6]
- def __init__(self, *expressions, buffering=None, fillfactor=None, **kwargs): self.buffering = buffering self.fillfactor = fillfactor super().__init__(*expressions, **kwargs) [f70c893d]
- def __init__(self, *expressions, fillfactor=None, **kwargs): self.fillfactor = fillfactor super().__init__(*expressions, **kwargs) [8001f44a2f0d6f3d]
- def __init__(self, *expressions, fillfactor=None, **kwargs): self.fillfactor = fillfactor super().__init__(*expressions, **kwargs) [8001f44a2f0d6f3d-2]
- def __init__(self, *expressions, fillfactor=None, deduplicate_items=None, **kwargs): self.fillfactor = fillfactor self.deduplicate_items = deduplicate_items super().__init__(*expressions, **kwargs) [13dd7364]
- def __init__(self, *expressions, length=None, columns=(), **kwargs): super().__init__(*expressions, **kwargs) if len(self.fields) > 32: raise ValueError("Bloom indexes support a maximum of 32 fields.") if not isinstance(columns, (list, tuple)): raise ValueError("BloomIndex.columns must be a list or tuple.") if len(columns) > len(self.fields): raise ValueError("BloomIndex.columns cannot have more values than fields.") if not all(0 < col <= 4095 for col in columns): raise ValueError( "BloomIndex.columns must contain integers from 1 to 4095.", ) if length is not None and not 0 < length <= 4096: raise ValueError( "BloomIndex.length must be None or an integer from 1 to 4096.", ) self.length = length self.columns = columns [799b32f7]
- def __init__(self, expression, name): super().__init__(expression, name=name) [96d71192]
- def check_supported(self, schema_editor): pass [3219a3e7]
- def create_sql(self, model, schema_editor, using="", **kwargs): self.check_supported(schema_editor) statement = super().create_sql( model, schema_editor, using=" USING %s" % (using or self.suffix), **kwargs ) with_params = self.get_with_params() if with_params: statement.parts["extra"] = " WITH (%s)%s" % ( ", ".join(with_params), statement.parts["extra"], ) return statement [b1fbf2d3]
- def deconstruct(self): path, args, kwargs = super().deconstruct() if self.autosummarize is not None: kwargs["autosummarize"] = self.autosummarize if self.pages_per_range is not None: kwargs["pages_per_range"] = self.pages_per_range return path, args, kwargs [27e3ec5b]
- def deconstruct(self): path, args, kwargs = super().deconstruct() if self.buffering is not None: kwargs["buffering"] = self.buffering if self.fillfactor is not None: kwargs["fillfactor"] = self.fillfactor return path, args, kwargs [94893f55]
- def deconstruct(self): path, args, kwargs = super().deconstruct() if self.fillfactor is not None: kwargs["fillfactor"] = self.fillfactor return path, args, kwargs [42ffd9fda5cc4039]

## All facts

- [da6ea248] def deconstruct(self): path, args, kwargs = super().deconstruct() if self.fastupdate is not None: kwargs["fastupdate"] = self.fastupdate if self.gin_pending_list_limit is not None: kwargs["gin_pending_list_limit"] = self.gin_pending_list_limit return path, args, kwargs
- [b1a36e43] def deconstruct(self): path, args, kwargs = super().deconstruct() if self.fillfactor is not None: kwargs["fillfactor"] = self.fillfactor if self.deduplicate_items is not None: kwargs["deduplicate_items"] = self.deduplicate_items return path, args, kwargs
- [42ffd9fda5cc4039-2] def deconstruct(self): path, args, kwargs = super().deconstruct() if self.fillfactor is not None: kwargs["fillfactor"] = self.fillfactor return path, args, kwargs
- [0fc09ab7] def deconstruct(self): path, args, kwargs = super().deconstruct() if self.length is not None: kwargs["length"] = self.length if self.columns: kwargs["columns"] = self.columns return path, args, kwargs
- [895fc3c5] def get_with_params(self): return []
- [e07899ac] def get_with_params(self): with_params = [] if self.autosummarize is not None: with_params.append( "autosummarize = %s" % ("on" if self.autosummarize else "off") ) if self.pages_per_range is not None: with_params.append("pages_per_range = %d" % self.pages_per_range) return with_params
- [ee3381b2] def get_with_params(self): with_params = [] if self.buffering is not None: with_params.append("buffering = %s" % ("on" if self.buffering else "off")) if self.fillfactor is not None: with_params.append("fillfactor = %d" % self.fillfactor) return with_params
- [09e74107] def get_with_params(self): with_params = [] if self.fillfactor is not None: with_params.append("fillfactor = %d" % self.fillfactor) if self.deduplicate_items is not None: with_params.append( "deduplicate_items = %s" % ("on" if self.deduplicate_items else "off") ) return with_params
- [33efcc1d63e52517] def get_with_params(self): with_params = [] if self.fillfactor is not None: with_params.append("fillfactor = %d" % self.fillfactor) return with_params
- [33efcc1d63e52517-2] def get_with_params(self): with_params = [] if self.fillfactor is not None: with_params.append("fillfactor = %d" % self.fillfactor) return with_params
- [9c09baaa] def get_with_params(self): with_params = [] if self.gin_pending_list_limit is not None: with_params.append( "gin_pending_list_limit = %d" % self.gin_pending_list_limit ) if self.fastupdate is not None: with_params.append("fastupdate = %s" % ("on" if self.fastupdate else "off")) return with_params
- [9ada9d58] def get_with_params(self): with_params = [] if self.length is not None: with_params.append("length = %d" % self.length) if self.columns: with_params.extend( "col%d = %d" % (i, v) for i, v in enumerate(self.columns, start=1) ) return with_params
- [e4f3adc4] __all__ = [ "BloomIndex", "BrinIndex", "BTreeIndex", "GinIndex", "GistIndex", "HashIndex", "SpGistIndex", ]
- [92527b76] class BTreeIndex(PostgresIndex): suffix = "btree"
- [e328aa25] class BloomIndex(PostgresIndex): suffix = "bloom"
- [0006c8a6] class BrinIndex(PostgresIndex): suffix = "brin"
- [3b66c5aa] class GinIndex(PostgresIndex): suffix = "gin"
- [d37d181b] class GistIndex(PostgresIndex): suffix = "gist"
- [3af2890a] class HashIndex(PostgresIndex): suffix = "hash"
- [b7a4925d] class OpClass(Func): template = "%(expressions)s %(name)s" constraint_validation_compatible = False
- [8695d2e1] class PostgresIndex(CheckPostgresInstalledMixin, Index): @cached_property def max_name_length(self): # Allow an index name longer than 30 characters when the suffix is # longer than the usual 3 character limit. The 30 character limit for # cross-database compatibility isn't applicable to PostgreSQL-specific # indexes. return Index.max_name_length - len(Index.suffix) + len(self.suffix)
- [83f8ecc3] class SpGistIndex(PostgresIndex): suffix = "spgist"
- [ab2bac21886a7863] from .utils import CheckPostgresInstalledMixin
- [25666096] from django.db.models import Func, Index from django.utils.functional import cached_property
