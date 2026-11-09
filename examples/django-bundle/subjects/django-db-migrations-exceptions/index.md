# django/db/migrations/exceptions

- Subject: django/db/migrations/exceptions (id `9ef62541-318a-463d-bb55-f4aa8758c369`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 470 tokens
- Facts shown: 19 facts
- Conflicts: 0
- Gaps: 0

## Facts

- def __init__(self, message, node, origin=None): self.message = message self.origin = origin self.node = node [541b43d9]
- def __repr__(self): return "NodeNotFoundError(%r)" % (self.node,) [ced2d69a]
- def __str__(self): return self.message [77d4a9c2]
- pass [7655780f0d17b825-42]
- pass [7655780f0d17b825-43]
- pass [7655780f0d17b825-44]
- pass [7655780f0d17b825-45]
- pass [7655780f0d17b825-46]
- pass [7655780f0d17b825-47]
- class AmbiguityError(Exception): """More than one migration matches a name prefix.""" [c6298a53]
- class BadMigrationError(Exception): """There's a bad migration (unreadable/bad format/etc.).""" [df91645f]
- class CircularDependencyError(Exception): """There's an impossible-to-resolve circular dependency.""" [28654889]
- class InconsistentMigrationHistory(Exception): """An applied migration has some of its dependencies not applied.""" [d117d8d9]
- class InvalidBasesError(ValueError): """A model's base classes can't be resolved.""" [1284c762]
- class InvalidMigrationPlan(ValueError): pass [d42bc9e2]
- class IrreversibleError(RuntimeError): """An irreversible migration is about to be reversed.""" [a75401c1]
- class MigrationSchemaMissing(DatabaseError): pass [6272c25e]
- class NodeNotFoundError(LookupError): """An attempt on a node is made that is not available in the graph.""" [750833a0]
- from django.db import DatabaseError [6bb4a243]
