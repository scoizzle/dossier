# django/contrib/gis/db/backends/utils

- Subject: django/contrib/gis/db/backends/utils (id `f2607512-c90e-4d83-8466-efdee587fca1`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 230 tokens
- Facts shown: 6 facts
- Conflicts: 0
- Gaps: 0

## Facts

- @property def default_template(self): if self.func: return "%(func)s(%(lhs)s, %(rhs)s)" else: return "%(lhs)s %(op)s %(rhs)s" [31d0985e]
- def __init__(self, op=None, func=None): self.op = op self.func = func [abe4dde1]
- def as_sql(self, connection, lookup, template_params, sql_params): sql_template = self.sql_template or lookup.sql_template or self.default_template template_params.update({"op": self.op, "func": self.func}) return sql_template % template_params, sql_params [7f48003a]
- sql_template = None [41dd4e7c]
- """ A collection of utility routines and classes used by the spatial backends. """ [a2364e5d]
- class SpatialOperator: """ Class encapsulating the behavior specific to a GIS operation (used by lookups). """ [3b018e05]
