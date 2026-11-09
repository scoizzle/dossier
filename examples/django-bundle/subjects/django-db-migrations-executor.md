# django/db/migrations/executor

- Subject: django/db/migrations/executor (id `f9d0fed9-bfe1-4827-ae86-3497e8c53915`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 9 of 31
- Conflicts: 0
- Gaps: 0

## Facts

- # Handle implicit many-to-many tables created by AddField. if field.many_to_many: through_db_table = field.remote_field.through._meta.db_table if fold_identifier_case: through_db_table = through_db_table.casefold() if through_db_table not in existing_table_names: return False, project_state else: found_add_field_migration = True continue with self.connection.cursor() as cursor: columns = self.connection.introspection.get_table_description( cursor, table ) for column in columns: field_column = field.column column_name = column.name if fold_identifier_case: column_name = column_name.casefold() field_column = field_column.casefold() if column_name == field_column: found_add_field_migration = True break else: return False, project_state # If we get this far and we found at least one CreateModel or AddField # migration, the migration is considered implicitly applied. return (found_create_model_migration or found_add_field_migration), after_state [56466667]
- table = model._meta.db_table field = model._meta.get_field(operation.name) [010e4077]
- # Generate the post migration state by starting from the state before # the last migration is unapplied and mutating it to include all the # remaining applied migrations. last_unapplied_migration = plan[-1][0] state = states[last_unapplied_migration] # Avoid mutating state with apps rendered as it's an expensive # operation. del state.apps for index, (migration, _) in enumerate(full_plan): if migration == last_unapplied_migration: for migration, _ in full_plan[index:]: if migration in applied_migrations: migration.mutate_state(state, preserve=False) break [95917042]
- Django first needs to create all project states before a migration is (un)applied and in a second step run all the database operations. """ # The django_migrations table must be present to record applied # migrations, but don't create it if there are no migrations to apply. if plan == []: if not self.recorder.has_table(): return self._create_project_state(with_applied_migrations=False) else: self.recorder.ensure_schema() [4d9f1aa2]
- Do this unconditionally on every migrate, rather than just when migrations are applied or unapplied, to correctly handle the case when a new squash migration is pushed to a deployment that already had all its replaced migrations applied. In this case no new migration will be applied, but the applied state of the squashed migration must be maintained. """ applied = self.recorder.applied_migrations() for key, migration in self.loader.replacements.items(): if key not in applied and self.loader.all_replaced_applied(key, applied): self.recorder.record_applied(*key) [f9fb2ffe]
- all_forwards = all(not backwards for mig, backwards in plan) all_backwards = all(backwards for mig, backwards in plan) [a1cc4b30]
- def should_skip_detecting_model(migration, model): """ No need to detect tables for proxy models, unmanaged models, or models that can't be migrated on the current database. """ return ( model._meta.proxy or not model._meta.managed or not router.allow_migrate( self.connection.alias, migration.app_label, model_name=model._meta.model_name, ) ) [06a64cc7]
- for migration, _ in plan: self.unapply_migration(states[migration], migration, fake=fake) applied_migrations.remove(migration) [6dcd44d4]
- return state [3917ade03a7beb2d]

## Beyond the budget

22 more facts did not fit in the budget: [51d53957] [7cde36fb] [ba10ee9a] [6544e97d] [ded430f6] [3917ade03a7beb2d-2] [3917ade03a7beb2d-3] [b8eb8984] [96e8a124] [364aac72] [bf835c30] [6060ded9] [1991335b] [b15c5ae2] [321023b4] [805fe49d] [69879208] [e7be579c] [008b7768] [83fb3a84] [f26aa273] [31877a82]
