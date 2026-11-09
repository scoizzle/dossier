# django/contrib/contenttypes/prefetch

- Subject: django/contrib/contenttypes/prefetch (id `b6238f76-ee0d-49da-b63f-cba4c41d205c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 293 tokens
- Facts shown: 4 of 4
- Conflicts: 0
- Gaps: 0

## Facts

- def __getstate__(self): obj_dict = self.__dict__.copy() obj_dict["querysets"] = [] for queryset in self.querysets: if queryset is not None: queryset = queryset._chain() # Prevent the QuerySet from being evaluated queryset._result_cache = [] queryset._prefetch_done = True obj_dict["querysets"].append(queryset) return obj_dict [3bcf7950]
- def get_current_querysets(self, level): if self.get_current_prefetch_to(level) == self.prefetch_to: return self.querysets return None [c3024e93]
- class GenericPrefetch(Prefetch): def __init__(self, lookup, querysets, to_attr=None): for queryset in querysets: if queryset is not None and ( isinstance(queryset, RawQuerySet) or ( hasattr(queryset, "_iterable_class") and not issubclass(queryset._iterable_class, ModelIterable) ) ): raise ValueError( "Prefetch querysets cannot use raw(), values(), and values_list()." ) self.querysets = querysets super().__init__(lookup, to_attr=to_attr) [e6ea1fd1]
- from django.db.models import Prefetch from django.db.models.query import ModelIterable, RawQuerySet [a8b9c8f7]
