# django/db/backends/sqlite3/schema

- Subject: django/db/backends/sqlite3/schema (id `7caeb52a-a9f5-43ba-9b25-76e652ae6436`)
- Kind: subject
- Budget: 1200 tokens
- Used: 881 tokens
- Facts shown: 9 of 38
- Conflicts: 0
- Gaps: 0

## Facts

- value = sqlite3.adapt(value) except ImportError: pass except sqlite3.ProgrammingError: pass # Manual emulation of SQLite parameter quoting if isinstance(value, bool): return str(int(value)) elif isinstance(value, (Decimal, float, int)): return str(value) elif isinstance(value, str): return "'%s'" % value.replace("'", "''") elif value is None: return "NULL" elif isinstance(value, (bytes, bytearray, memoryview)): # Bytes are only allowed for BLOB fields, encoded as string # literals containing hexadecimal data and preceded by a single "X" # character. return "X'%s'" % value.hex() else: raise ValueError( "Cannot quote parameter value %r of type %s" % (value, type(value)) ) [c2faf342]
- # Construct a model with a renamed table name. body_copy = copy.deepcopy(body) meta_contents = { "app_label": model._meta.app_label, "db_table": "new__%s" % strip_quotes(model._meta.db_table), "unique_together": unique_together, "indexes": indexes, "constraints": constraints, "apps": apps, } meta = type("Meta", (), meta_contents) body_copy["Meta"] = meta body_copy["__module__"] = model.__module__ new_model = type("New%s" % model._meta.object_name, model.__bases__, body_copy) [806efa37]
- # Construct a new model with the new fields to allow self referential # primary key to resolve to. This model won't ever be materialized as a # table and solely exists for foreign key reference resolution # purposes. This wouldn't be required if the schema editor was # operating on model states instead of rendered models. meta_contents = { "app_label": model._meta.app_label, "db_table": model._meta.db_table, "unique_together": unique_together, "indexes": indexes, "constraints": constraints, "apps": apps, } meta = type("Meta", (), meta_contents) body_copy["Meta"] = meta body_copy["__module__"] = model.__module__ type(model._meta.object_name, model.__bases__, body_copy) [7963dc4e]
- # Copy data from the old table into the new table self.execute( "INSERT INTO %s (%s) SELECT %s FROM %s" % ( self.quote_name(new_model._meta.db_table), ", ".join(self.quote_name(x) for x in mapping), ", ".join(mapping.values()), self.quote_name(model._meta.db_table), ) ) [fccfe5c2]
- # Create a new table with the updated schema. self.create_model(new_model) [042d6228]
- # Delete the old table to make way for the new self.delete_model(model, handle_autom2m=False) [82021a07]
- # Make a new through table self.create_model(new_field.remote_field.through) # Copy the data across self.execute( "INSERT INTO %s (%s) SELECT %s FROM %s" % ( self.quote_name(new_field.remote_field.through._meta.db_table), ", ".join( [ "id", new_field.m2m_column_name(), new_field.m2m_reverse_name(), ] ), ", ".join( [ "id", old_field.m2m_column_name(), old_field.m2m_reverse_name(), ] ), self.quote_name(old_field.remote_field.through._meta.db_table), ) ) # Delete the old through table self.delete_model(old_field.remote_field.through) [ec1481ae]
- # Provide isolated instances of the fields to the new model body so # that the existing model's internals aren't interfered with when # the dummy model is constructed. body_copy = copy.deepcopy(body) [66394163]
- # Rename the new table to make way for the old self.alter_db_table( new_model, new_model._meta.db_table, model._meta.db_table, ) [ba9eb170]

## Beyond the budget

28 more facts did not fit in the budget: [023b6f14] [162c3743] [0291e387] [658e13dd] [e5d2cc9e] [b6abe447] [279f9fa3] [d983a3b2] [99216b8e] [f96cde47] [70f05184] [12468012] [c32d1792] [2b0aff31] [5539dd38] [38088801] [cbb8b91b] [3fe2cb4c] [32133b38] [930ca2b0] [6a4d002a] [bd022bd9] [512d1078ba2dee30-2] [be2fb077] [3a274324] [0c39b6ae] [cb3fd787] [9d4561bb]
