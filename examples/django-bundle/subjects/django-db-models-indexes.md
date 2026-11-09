# django/db/models/indexes

- Subject: django/db/models/indexes (id `db4b7937-2d02-4970-854c-d03acc0a52e9`)
- Kind: subject
- Budget: 1200 tokens
- Used: 889 tokens
- Facts shown: 9 of 23
- Conflicts: 0
- Gaps: 0

## Facts

- The name is divided into 3 parts - table name (12 chars), field name (8 chars) and unique hash + suffix (10 chars). Each part is made to fit its size by truncating the excess length. """ _, table_name = split_identifier(model._meta.db_table) column_names = [ model._meta.get_field(field_name).column for field_name, order in self.fields_orders ] column_names_with_order = [ (("-%s" if order else "%s") % column_name) for column_name, (field_name, order) in zip( column_names, self.fields_orders ) ] # The length of the parts of the name is based on the default max # length of 30 characters. hash_data = [table_name, *column_names_with_order, self.suffix] self.name = "%s_%s_%s" % ( table_name[:11], column_names[0][:7], "%s_%s" % (names_digest(*hash_data, length=6), self.suffix), ) if len(self.name) > self.max_name_length: raise ValueError( "Index too long for multiple database support. Is self.suffix " "longer than 3 characters?" ) if self.name[0] == "_" or self.name[0].isdigit(): self.name = "D%s" % self.name[1:] [5b018e76]
- if wrappers: # Order wrappers and set their expressions. wrappers = sorted( wrappers, key=lambda w: self.wrapper_classes.index(type(w)), ) wrappers = [wrapper.copy() for wrapper in wrappers] for i, wrapper in enumerate(wrappers[:-1]): wrapper.set_source_expressions([wrappers[i + 1]]) # Set the root expression on the deepest wrapper. wrappers[-1].set_source_expressions([root_expression]) self.set_source_expressions([wrappers[0]]) else: # Use the root expression, if there are no wrappers. self.set_source_expressions([root_expression]) return super().resolve_expression( query, allow_joins, reuse, summarize, for_save ) [20dfc049]
- @classmethod def register_wrappers(cls, *wrapper_classes): cls.wrapper_classes = wrapper_classes [88a303df]
- @property def contains_expressions(self): return bool(self.expressions) [cdf2a666e0d49cf8-2]
- def __eq__(self, other): if self.__class__ == other.__class__: return self.deconstruct() == other.deconstruct() return NotImplemented [62854eda]
- def __repr__(self): return "<%s:%s%s%s%s%s%s%s>" % ( self.__class__.__qualname__, "" if not self.fields else " fields=%s" % repr(self.fields), "" if not self.expressions else " expressions=%s" % repr(self.expressions), "" if not self.name else " name=%s" % repr(self.name), ( "" if self.db_tablespace is None else " db_tablespace=%s" % repr(self.db_tablespace) ), "" if self.condition is None else " condition=%s" % self.condition, "" if not self.include else " include=%s" % repr(self.include), "" if not self.opclasses else " opclasses=%s" % repr(self.opclasses), ) [77030374]
- def _get_condition_sql(self, model, schema_editor): if self.condition is None: return None query = Query(model=model, alias_cols=False) where = query.build_where(self.condition) compiler = query.get_compiler(connection=schema_editor.connection) sql, params = where.as_sql(compiler, schema_editor.connection) return sql % tuple(schema_editor.quote_value(p) for p in params) [c0cd83891e226f46-2]
- def as_sqlite(self, compiler, connection, **extra_context): # Casting to numeric is unnecessary. return self.as_sql(compiler, connection, **extra_context) [0bbe3faa56654519-2]
- def clone(self): """Create a copy of this Index.""" _, args, kwargs = self.deconstruct() return self.__class__(*args, **kwargs) [b0efaa51]

## Beyond the budget

14 more facts did not fit in the budget: [8982f257] [bebdf16f] [5ccae90c] [b792444d] [53300a53] [166045fe] [87d3d2d9] [ef786c78] [ffd95a92] [aa205021] [da1e1723] [67946857] [f8c47b28] [91c09431be7a5272-2]
