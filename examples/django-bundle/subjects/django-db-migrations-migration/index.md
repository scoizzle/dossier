# django/db/migrations/migration

- Subject: django/db/migrations/migration (id `3ef86544-97e4-4342-97e7-3cb3f4b084d2`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 6 of 33
- Conflicts: 0
- Gaps: 0

## Facts

- # Phase 2 for operation, to_state, from_state in to_run: if collect_sql: schema_editor.collected_sql.append("--") schema_editor.collected_sql.append("-- %s" % operation.describe()) schema_editor.collected_sql.append("--") if not operation.reduces_to_sql: schema_editor.collected_sql.append( "-- THIS OPERATION CANNOT BE WRITTEN AS SQL" ) continue collected_sql_before = len(schema_editor.collected_sql) atomic_operation = operation.atomic or ( self.atomic and operation.atomic is not False ) if not schema_editor.atomic_migration and atomic_operation: # Force a transaction on a non-transactional-DDL backend or an # atomic operation inside a non-atomic migration. with atomic(schema_editor.connection.alias): operation.database_backwards( self.app_label, schema_editor, from_state, to_state ) else: # Normal behavior operation.database_backwards( self.app_label, schema_editor, from_state, to_state ) if collect_sql and collected_sql_before == len(schema_editor.collected_sql): schema_editor.collected_sql.append("-- (no-op)") return project_state [8cd5281f]
- 1. The intermediate states from right before the first until right after the last operation inside this migration are preserved. 2. The operations are applied in reverse order using the states recorded in step 1. """ # Construct all the intermediate states we need for a reverse migration to_run = [] new_state = project_state # Phase 1 for operation in self.operations: # If it's irreversible, error out if not operation.reversible: raise IrreversibleError( "Operation %s in %s is not reversible" % (operation, self) ) # Preserve new state from previous run to not tamper the same state # over all operations new_state = new_state.clone() old_state = new_state.clone() operation.state_forwards(self.app_label, new_state) to_run.insert(0, (operation, old_state, new_state)) [a96dd915]
- Return the resulting project state for efficient reuse by following Migrations. """ for operation in self.operations: # If this operation cannot be represented as SQL, place a comment # there instead if collect_sql: schema_editor.collected_sql.append("--") schema_editor.collected_sql.append("-- %s" % operation.describe()) schema_editor.collected_sql.append("--") if not operation.reduces_to_sql: schema_editor.collected_sql.append( "-- THIS OPERATION CANNOT BE WRITTEN AS SQL" ) continue collected_sql_before = len(schema_editor.collected_sql) # Save the state before the operation has run old_state = project_state.clone() operation.state_forwards(self.app_label, project_state) # Run the operation atomic_operation = operation.atomic or ( self.atomic and operation.atomic is not False ) if not schema_editor.atomic_migration and atomic_operation: # Force a transaction on a non-transactional-DDL backend or an # atomic operation inside a non-atomic migration. with atomic(schema_editor.connection.alias): operation.database_forwards( self.app_label, schema_editor, old_state, project_state ) else: # Normal behavior operation.database_forwards( self.app_label, schema_editor, old_state, project_state ) if collect_sql and collected_sql_before == len(schema_editor.collected_sql): schema_editor.collected_sql.append("-- (no-op)") return project_state [47e2b617]
- The backwards migration process consists of two phases: [efd024b5]
- for operation in self.operations: operation.state_forwards(self.app_label, new_state) return new_state [a615d5b5]
- import re [dae3b101b4aa9562-7]

## Beyond the budget

26 more facts did not fit in the budget: [99a8a1b6] [0a8a5134] [744ee570] [88b4648b] [74a36b0d] [3dca1cd6] [e4cdb54c] [fef381cd] [ed72e82c] [776ba290] [52836954] [b55d5118] [34248c8d] [04db3c09] [9750b484] [df1e4faf] [25fa0f80] [1c03a2c2] [53fd8021] [a6502d34] [66082f26] [537c624f] [3989241f] [e74c5c73] [2b553a3c] [af80e75c]
