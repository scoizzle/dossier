# django/db/backends/postgresql/compiler

- Subject: django/db/backends/postgresql/compiler (id `491aa6c7-0b46-4d2f-8895-b4f0f9207d96`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 564 tokens
- Facts shown: 5 facts
- Conflicts: 0
- Gaps: 0

## Facts

- def __str__(self): return "UNNEST(%s)" % ", ".join(self) [29c9122c]
- __all__ = [ "SQLAggregateCompiler", "SQLCompiler", "SQLDeleteCompiler", "SQLInsertCompiler", "SQLUpdateCompiler", ] [067883fba4ae7b68-2]
- class InsertUnnest(list): """ Sentinel value to signal DatabaseOperations.bulk_insert_sql() that the UNNEST strategy should be used for the bulk insert. """ [99984223]
- class SQLInsertCompiler(BaseSQLInsertCompiler): def assemble_as_sql(self, fields, value_rows): # Specialize bulk-insertion of literal values through UNNEST to # reduce the time spent planning the query. if ( # The optimization is not worth doing if there is a single # row as it will result in the same number of placeholders. len(value_rows) <= 1 # Lack of fields denote the usage of the DEFAULT keyword # for the insertion of empty rows. or any(field is None for field in fields) # Field.get_placeholder_sql takes value as an argument, so the # resulting placeholder might be dependent on the value. # in UNNEST requires a single placeholder to "fit all values" in # the array. or any(hasattr(field, "get_placeholder_sql") for field in fields) # Fields that don't use standard internal types might not be # unnest'able (e.g. array and geometry types are known to be # problematic). or any( (field.target_field if field.is_relation else field).get_internal_type() not in self.connection.data_types for field in fields ) # Compilable cannot be combined in an array of literal values. or any(any(hasattr(value, "as_sql") for value in row) for row in value_rows) ): return super().assemble_as_sql(fields, value_rows) # Manually remove parameters from `db_type` to ensure no data # truncation takes place (e.g. varchar[] instead of varchar(50)[]). db_types = [field.db_type(self.connection).split("(")[0] for field in fields] return InsertUnnest(["(%%s)::%s[]" % db_type for db_type in db_types]), [ list(map(list, zip(*value_rows))) ] [2204788e]
- from django.db.models.sql.compiler import ( # isort:skip SQLAggregateCompiler, SQLCompiler, SQLDeleteCompiler, SQLInsertCompiler as BaseSQLInsertCompiler, SQLUpdateCompiler, ) [a8057d02]
