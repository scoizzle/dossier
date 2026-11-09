# django/db/backends/ddl_references

- Subject: django/db/backends/ddl_references (id `b3d72571-b3e3-44a6-bf9f-df37481f8259`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1894 tokens
- Facts shown: 42 of 50
- Conflicts: 0
- Gaps: 0

## Highlights

- return ", ".join( col_str(column, idx) for idx, column in enumerate(self.columns) ) [1799c23cfa03ba85]
- Allows keeping a reference to a statement without interpolating identifiers that might have to be adjusted if they're referencing a table or column that is removed """ [9d50c7ba]
- def __init__( self, from_table, from_columns, to_table, to_columns, suffix_template, create_fk_name, ): self.to_reference = TableColumns(to_table, to_columns) self.suffix_template = suffix_template self.create_fk_name = create_fk_name super().__init__( from_table, from_columns, ) [0160e85d]
- def __init__(self, table, columns): self.table = table self.columns = columns [f68ba5b0]
- def __init__(self, table, columns, quote_name, col_suffixes=()): self.quote_name = quote_name self.col_suffixes = col_suffixes super().__init__(table, columns) [8d6670a5]
- def __init__(self, table, columns, suffix, create_index_name): self.suffix = suffix self.create_index_name = create_index_name super().__init__(table, columns) [672cb3c7]
- def __init__(self, table, quote_name): self.table = table self.quote_name = quote_name [ce0dfb89]
- def __init__(self, template, **parts): self.template = template self.parts = parts [83a39a8c]
- def __repr__(self): return "<%s %r>" % (self.__class__.__name__, str(self)) [1cc8c46c]
- def __str__(self): def col_str(column, idx): # Index.__init__() guarantees that self.opclasses is the same # length as self.columns. col = "{} {}".format(self.quote_name(column), self.opclasses[idx]) try: suffix = self.col_suffixes[idx] if suffix: col = "{} {}".format(col, suffix) except IndexError: pass return col [72450b9d]
- def __str__(self): def col_str(column, idx): col = self.quote_name(column) try: suffix = self.col_suffixes[idx] if suffix: col = "{} {}".format(col, suffix) except IndexError: pass return col [7771635a]
- def __str__(self): raise NotImplementedError( "Subclasses must define how they should be converted to string." ) [76663495]
- def __str__(self): return self.create_index_name(self.table, self.columns, self.suffix) [d7f6e35e]
- def __str__(self): return self.quote_name(self.table) [407708e7]
- def __str__(self): return self.template % self.parts [687154a9]
- def __str__(self): sql, params = self.compiler.compile(self.expressions) params = map(self.quote_value, params) return sql % tuple(params) [dfdd62ed]
- def __str__(self): suffix = self.suffix_template % { "to_table": self.to_reference.table, "to_column": self.to_reference.columns[0], } return self.create_fk_name(self.table, self.columns, suffix) [6eeeb0ad]
- def references_column(self, table, column): """ Return whether or not this instance references the specified column. """ return False [0122729c]
- def references_column(self, table, column): return any( hasattr(part, "references_column") and part.references_column(table, column) for part in self.parts.values() ) [9d6dca82]
- def references_column(self, table, column): return self.table == table and column in self.columns [cfc9ff76]

## All facts

- [5f126d05] def references_column(self, table, column): return super().references_column( table, column ) or self.to_reference.references_column(table, column)
- [9bd12450] def references_index(self, table, index): return self.references_table(table) and str(self) == index
- [6f12f08c] def references_table(self, table): return self.table == table
- [c956c3fe] def rename_column_references(self, table, old_column, new_column): """ Rename all references to the old_column to the new_column. """ pass
- [f23e0fe6] def rename_column_references(self, table, old_column, new_column): for part in self.parts.values(): if hasattr(part, "rename_column_references"): part.rename_column_references(table, old_column, new_column)
- [8e2f2343] def rename_column_references(self, table, old_column, new_column): if self.table != table: return expressions = deepcopy(self.expressions) self.columns = [] for col in self.compiler.query._gen_cols([expressions]): if col.target.column == old_column: col.target.column = new_column self.columns.append(col.target.column) self.expressions = expressions
- [f994a5f2] def rename_column_references(self, table, old_column, new_column): if self.table == table: for index, column in enumerate(self.columns): if column == old_column: self.columns[index] = new_column
- [f681d29a] def rename_column_references(self, table, old_column, new_column): super().rename_column_references(table, old_column, new_column) self.to_reference.rename_column_references(table, old_column, new_column)
- [861dc062] def rename_table_references(self, old_table, new_table): """ Rename all references to the old_name to the new_table. """ pass
- [90782d33] def rename_table_references(self, old_table, new_table): if self.table != old_table: return self.expressions = self.expressions.relabeled_clone({old_table: new_table}) super().rename_table_references(old_table, new_table)
- [ef1009a4] def rename_table_references(self, old_table, new_table): if self.table == old_table: self.table = new_table
- [e9280cb6] """ Helpers to manipulate deferred DDL statements that might need to be adjusted or discarded when executing a migration. """
- [5a779899] class Columns(TableColumns): """Hold a reference to one or many columns."""
- [5fdd0a3a] class Expressions(TableColumns): def __init__(self, table, expressions, compiler, quote_value): self.compiler = compiler self.expressions = expressions self.quote_value = quote_value columns = [ col.target.column for col in self.compiler.query._gen_cols([self.expressions]) ] super().__init__(table, columns)
- [fd3922c1] class ForeignKeyName(TableColumns): """Hold a reference to a foreign key name."""
- [b0345815] class IndexColumns(Columns): def __init__(self, table, columns, quote_name, col_suffixes=(), opclasses=()): self.opclasses = opclasses super().__init__(table, columns, quote_name, col_suffixes)
- [02fa136a] class IndexName(TableColumns): """Hold a reference to an index name."""
- [bf941a3e] class Reference: """Base class that defines the reference interface."""
- [15a2fea6] class Statement(Reference): """ Statement template and formatting parameters container.
- [b6e76545] class Table(Reference): """Hold a reference to a table."""
- [6048c026] class TableColumns(Table): """Base class for references to multiple columns of a table."""
- [ed4edd1d59c7513d] from copy import deepcopy
