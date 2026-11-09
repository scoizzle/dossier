# django/db/backends/ddl_references

- Subject: django/db/backends/ddl_references (id `05f29b58-45ee-4674-974b-378d5de84de5`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 20 of 50
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

22 more facts did not fit in the budget: [5f126d05] [9bd12450] [6f12f08c] [c956c3fe] [f23e0fe6] [8e2f2343] [f994a5f2] [f681d29a] [861dc062] [90782d33] [ef1009a4] [e9280cb6] [5a779899] [5fdd0a3a] [fd3922c1] [b0345815] [02fa136a] [bf941a3e] [15a2fea6] [b6e76545] [6048c026] [ed4edd1d59c7513d]
