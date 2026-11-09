# django/db/migrations/operations/special

- Subject: django/db/migrations/operations/special (id `887c529a-9f14-4bba-8efa-a70c298c9835`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1964 tokens
- Facts shown: 31 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- @property def reversible(self): return self.reverse_code is not None [0b6ac66c]
- @property def reversible(self): return self.reverse_sql is not None [ba2a5413]
- @staticmethod def noop(apps, schema_editor): return None [20011f57]
- Also accept a list of operations that represent the state change effected by this SQL change, in case it's custom column/table creation/deletion. """ [9ce6ac3a]
- category = OperationCategory.MIXED serialization_expand_args = ["database_operations", "state_operations"] [7d477fc6]
- category = OperationCategory.PYTHON reduces_to_sql = False [7d4a101b]
- category = OperationCategory.SQL noop = "" [1dd69de2]
- def __init__( self, code, reverse_code=None, atomic=None, hints=None, elidable=False ): self.atomic = atomic # Forwards code if not callable(code): raise ValueError("RunPython must be supplied with a callable") self.code = code # Reverse code if reverse_code is None: self.reverse_code = None else: if not callable(reverse_code): raise ValueError("RunPython must be supplied with callable arguments") self.reverse_code = reverse_code self.hints = hints or {} self.elidable = elidable [97859e3c]
- def __init__( self, sql, reverse_sql=None, state_operations=None, hints=None, elidable=False ): self.sql = sql self.reverse_sql = reverse_sql self.state_operations = state_operations or [] self.hints = hints or {} self.elidable = elidable [c071436e]
- def __init__(self, database_operations=None, state_operations=None): self.database_operations = database_operations or [] self.state_operations = state_operations or [] [09289b64]
- def _run_sql(self, schema_editor, sqls): if isinstance(sqls, (list, tuple)): for sql in sqls: params = None if isinstance(sql, (list, tuple)): elements = len(sql) if elements == 2: sql, params = sql else: raise ValueError("Expected a 2-tuple but got %d" % elements) schema_editor.execute(sql, params=params) elif sqls != RunSQL.noop: statements = schema_editor.connection.ops.prepare_sql_script(sqls) for statement in statements: schema_editor.execute(statement, params=None) [2c820e7e]
- def database_backwards(self, app_label, schema_editor, from_state, to_state): # We calculate state separately in here since our state functions # aren't useful to_states = {} for dbop in self.database_operations: to_states[dbop] = to_state to_state = to_state.clone() dbop.state_forwards(app_label, to_state) # to_state now has the states of all the database_operations applied # which is the from_state for the backwards migration of the last # operation. for database_operation in reversed(self.database_operations): from_state = to_state to_state = to_states[database_operation] database_operation.database_backwards( app_label, schema_editor, from_state, to_state ) [6045524e]
- def database_backwards(self, app_label, schema_editor, from_state, to_state): if self.reverse_code is None: raise NotImplementedError("You cannot reverse this operation") if router.allow_migrate( schema_editor.connection.alias, app_label, **self.hints ): self.reverse_code(from_state.apps, schema_editor) [718d4f30]
- def describe(self): return "Custom state/database change combination" [24eca916]

## All facts

- [7ca536d1] def database_backwards(self, app_label, schema_editor, from_state, to_state): if self.reverse_sql is None: raise NotImplementedError("You cannot reverse this operation") if router.allow_migrate( schema_editor.connection.alias, app_label, **self.hints ): self._run_sql(schema_editor, self.reverse_sql)
- [95e10629] def database_forwards(self, app_label, schema_editor, from_state, to_state): # RunPython has access to all models. Ensure that all models are # reloaded in case any are delayed. from_state.clear_delayed_apps_cache() if router.allow_migrate( schema_editor.connection.alias, app_label, **self.hints ): # We now execute the Python code in a context that contains a # 'models' object, representing the versioned models as an app # registry. We could try to override the global cache, but then # people will still use direct imports, so we go with a # documentation approach instead. self.code(from_state.apps, schema_editor)
- [e914f19f] def database_forwards(self, app_label, schema_editor, from_state, to_state): # We calculate state separately in here since our state functions # aren't useful for database_operation in self.database_operations: to_state = from_state.clone() database_operation.state_forwards(app_label, to_state) database_operation.database_forwards( app_label, schema_editor, from_state, to_state ) from_state = to_state
- [d8260372] def database_forwards(self, app_label, schema_editor, from_state, to_state): if router.allow_migrate( schema_editor.connection.alias, app_label, **self.hints ): self._run_sql(schema_editor, self.sql)
- [ddcdecf1] def deconstruct(self): kwargs = { "code": self.code, } if self.reverse_code is not None: kwargs["reverse_code"] = self.reverse_code if self.atomic is not None: kwargs["atomic"] = self.atomic if self.hints: kwargs["hints"] = self.hints if self.elidable: kwargs["elidable"] = self.elidable return (self.__class__.__qualname__, [], kwargs)
- [c20fa8e0] def deconstruct(self): kwargs = { "sql": self.sql, } if self.reverse_sql is not None: kwargs["reverse_sql"] = self.reverse_sql if self.state_operations: kwargs["state_operations"] = self.state_operations if self.hints: kwargs["hints"] = self.hints if self.elidable: kwargs["elidable"] = self.elidable return (self.__class__.__qualname__, [], kwargs)
- [e9229390] def deconstruct(self): kwargs = {} if self.database_operations: kwargs["database_operations"] = self.database_operations if self.state_operations: kwargs["state_operations"] = self.state_operations return (self.__class__.__qualname__, [], kwargs)
- [697fc519] def describe(self): return "Raw Python operation"
- [f86b4d01] def describe(self): return "Raw SQL operation"
- [45cc1569] def state_forwards(self, app_label, state): # RunPython objects have no state effect. To add some, combine this # with SeparateDatabaseAndState. pass
- [bf67145ce4fffac3] def state_forwards(self, app_label, state): for state_operation in self.state_operations: state_operation.state_forwards(app_label, state)
- [bf67145ce4fffac3-2] def state_forwards(self, app_label, state): for state_operation in self.state_operations: state_operation.state_forwards(app_label, state)
- [ac0c71b7] class RunPython(Operation): """ Run Python code in a context suitable for doing versioned ORM operations. """
- [d2a74363] class RunSQL(Operation): """ Run some raw SQL. A reverse SQL statement may be provided.
- [f9aabd04] class SeparateDatabaseAndState(Operation): """ Take two lists of operations - ones that will be used for the database, and ones that will be used for the state change. This allows operations that don't support state change to have it applied, or have operations that affect the state or not the database, or so on. """
- [3aab3890e152ab07-2] from .base import Operation, OperationCategory
- [7b327ae1] from django.db import router
