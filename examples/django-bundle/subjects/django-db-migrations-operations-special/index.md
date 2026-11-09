# django/db/migrations/operations/special

- Subject: django/db/migrations/operations/special (id `6a37896b-0685-4883-8264-f7021cb90f6b`)
- Kind: subject
- Budget: 1200 tokens
- Used: 890 tokens
- Facts shown: 14 of 31
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

15 more facts did not fit in the budget: [95e10629] [e914f19f] [d8260372] [ddcdecf1] [c20fa8e0] [e9229390] [697fc519] [f86b4d01] [45cc1569] [bf67145ce4fffac3] [ac0c71b7] [d2a74363] [f9aabd04] [3aab3890e152ab07-2] [7b327ae1]
