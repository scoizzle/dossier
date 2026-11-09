# django/contrib/postgres/lookups

- Subject: django/contrib/postgres/lookups (id `873c684e-25ca-4960-8407-2bee274746c7`)
- Kind: subject
- Budget: 1200 tokens
- Used: 622 tokens
- Facts shown: 17 of 17
- Conflicts: 0
- Gaps: 0

## Facts

- if isinstance(self.rhs, Query): self.rhs = ArraySubquery(self.rhs) return super().get_prep_lookup() [e9ba8390]
- def get_prep_lookup(self): from .expressions import ArraySubquery [b63636d8]
- def get_prep_lookup(self): return [str(item) for item in self.rhs] [278896c9d72511e0]
- def process_lhs(self, qn, connection): if not isinstance(self.lhs.output_field, SearchVectorField): config = getattr(self.rhs, "config", None) self.lhs = SearchVector(self.lhs, config=config) lhs, lhs_params = super().process_lhs(qn, connection) return lhs, lhs_params [0c83eae0]
- class ContainedBy(PostgresOperatorLookup): lookup_name = "contained_by" postgres_operator = "<@" [abaf95e2]
- class DataContains(PostgresOperatorLookup): lookup_name = "contains" postgres_operator = "@>" [127a1257]
- class HasAnyKeys(HasKeys): lookup_name = "has_any_keys" postgres_operator = "?|" [f0518c5e]
- class HasKey(PostgresOperatorLookup): lookup_name = "has_key" postgres_operator = "?" prepare_rhs = False [254e1108]
- class HasKeys(PostgresOperatorLookup): lookup_name = "has_keys" postgres_operator = "?&" [f33c23be]
- class Overlap(PostgresOperatorLookup): lookup_name = "overlap" postgres_operator = "&&" [b7026ab3]
- class SearchLookup(SearchVectorExact): lookup_name = "search" [e6b82d94]
- class TrigramSimilar(PostgresOperatorLookup): lookup_name = "trigram_similar" postgres_operator = "%%" [0614f56d]
- class TrigramStrictWordSimilar(PostgresOperatorLookup): lookup_name = "trigram_strict_word_similar" postgres_operator = "%%>>" [ff8a3fc2]
- class TrigramWordSimilar(PostgresOperatorLookup): lookup_name = "trigram_word_similar" postgres_operator = "%%>" [f7ea6506]
- class Unaccent(Transform): bilateral = True lookup_name = "unaccent" function = "UNACCENT" [5f233873]
- from .search import SearchVector, SearchVectorExact, SearchVectorField [547fa002]
- from django.db.models import Transform from django.db.models.lookups import PostgresOperatorLookup from django.db.models.sql.query import Query [57aa505d]
