# django/db/migrations/operations/base

- Subject: django/db/migrations/operations/base (id `64325fa3-eb2d-4a2b-b4c0-1a5fdab4d083`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 19 of 31
- Conflicts: 0
- Gaps: 0

## Facts

- This is a thin wrapper around router.allow_migrate_model() that preemptively rejects any proxy, swapped out, or unmanaged model. """ if not model._meta.can_migrate(connection_alias): return False [0637f716]
- Used for optimization. If in doubt, return True. """ return self.references_model(model_name, app_label) [2f435873]
- Used for optimization. If in doubt, return True; returning a false positive will merely make the optimizer a little less efficient, while returning a false negative may result in an unusable optimized migration. """ return True [e98c270a]
- return router.allow_migrate_model(connection_alias, model) [a4822ab9]
- # Can this migration be represented as SQL? (things like RunPython cannot) reduces_to_sql = True [7266230e]
- # If this migration can be run in reverse. # Some operations are impossible to reverse, like deleting data. reversible = True [48d60091]
- # Should this operation be considered safe to elide and optimize across? elidable = False [6abfa569]
- # Should this operation be forced as atomic even on backends with no # DDL transaction support (i.e., does it have no DDL, like RunPython) atomic = False [810ebb50]
- @property def migration_name_fragment(self): """ A filename part suitable for automatically naming a migration containing this operation, or None if not applicable. """ return None [b821726c]
- Due to the way this class deals with deconstruction, it should be considered immutable. """ [4b1d0cbb]
- It's responsible for both mutating the in-memory model state (see db/migrations/state.py) to represent what it performs, as well as actually performing it against a live database. [a73888e1]
- Note that some operations won't modify memory state at all (e.g. data copying operations), and some will need their modifications to be optionally specified by the user (e.g. custom Python code snippets) [836e41de]
- category = None [be529e97]
- def __new__(cls, *args, **kwargs): # We capture the arguments to make returning them trivial self = object.__new__(cls) self._constructor_args = (args, kwargs) return self [9bc14cf0]
- def __replace__(self, /, **changes): args = [ changes.pop(name, value) for name, value in zip( get_func_args(self.__class__), self._constructor_args[0], ) ] return self.__class__(*args, **(self._constructor_args[1] | changes)) [71147eae]
- def __repr__(self): return "<%s %s%s>" % ( self.__class__.__name__, ", ".join(map(repr, self._constructor_args[0])), ",".join(" %s=%r" % x for x in self._constructor_args[1].items()), ) [5cef4f4b]
- def allow_migrate_model(self, connection_alias, model): """ Return whether or not a model may be migrated. [50640e31]
- def database_backwards(self, app_label, schema_editor, from_state, to_state): """ Perform the mutation on the database schema in the reverse direction - e.g. if this were CreateModel, it would in fact drop the model's table. """ raise NotImplementedError( "subclasses of Operation must provide a database_backwards() method" ) [fa4201cf]
- serialization_expand_args = [] [cd48e722]

## Beyond the budget

11 more facts did not fit in the budget: [55e641fe] [b13b4159] [04ea80d7] [6d28e516] [dbb64c0c] [c8795a83] [2e9daf96] [0af88c83] [acbda3ea] [6e0458f0] [bd5b3e25]
