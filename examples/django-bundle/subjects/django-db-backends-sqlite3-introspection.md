# django/db/backends/sqlite3/introspection

- Subject: django/db/backends/sqlite3/introspection (id `62c09111-a679-4dff-af25-089abccbc793`)
- Kind: subject
- Budget: 1200 tokens
- Used: 890 tokens
- Facts shown: 6 of 22
- Conflicts: 0
- Gaps: 0

## Facts

- # Get the index info cursor.execute( "PRAGMA index_list(%s)" % self.connection.ops.quote_name(table_name) ) for row in cursor.fetchall(): # Discard last 2 columns. number, index, unique = row[:3] cursor.execute( "SELECT sql FROM sqlite_master WHERE type='index' AND name=%s", [index], ) # There's at most one row. (sql,) = cursor.fetchone() or (None,) # Inline constraints are already detected in # _parse_table_constraints(). The reasons to avoid fetching inline # constraints from `PRAGMA index_list` are: # - Inline constraints can have a different name and information # than what `PRAGMA index_list` gives. # - Not all inline constraints may appear in `PRAGMA index_list`. if not sql: # An inline constraint continue # Get the index info for that index cursor.execute( "PRAGMA index_info(%s)" % self.connection.ops.quote_name(index) ) for index_rank, column_rank, column in cursor.fetchall(): if index not in constraints: constraints[index] = { "columns": [], "primary_key": False, "unique": bool(unique), "foreign_key": None, "check": False, "index": True, } constraints[index]["columns"].append(column) # Add type and column orders for indexes if constraints[index]["index"]: # SQLite doesn't support any index type other than b-tree constraints[index]["type"] = Index.suffix orders = self._get_index_columns_orders(sql) if orders is not None: constraints[index]["orders"] = orders # Get the PK pk_columns = self.get_primary_key_columns(cursor, table_name) if pk_columns: # SQLite doesn't actually give a name to the PK constraint, # so we invent one. This is fine, as the SQLite backend never # deletes PK constraints by name, as you can't delete constraints # in SQLite; we remake the table with a new PK instead. constraints["__primary__"] = { "columns": pk_columns, "primary_key": True, "unique": False, # It's not actually a unique constraint. "foreign_key": None, "check": False, "index": False, } relations = enumerate(self.get_relations(cursor, table_name).items()) constraints.update( { f"fk_{index}": { "columns": [column_name], "primary_key": False, "unique": False, "foreign_key": (ref_table_name, ref_column_name), "check": False, "index": False, } for index, ( column_name, (ref_column_name, ref_table_name, _), ) in relations } ) return constraints [9336cfd1]
- sql = row[0] columns = str(sqlparse.parse(sql)[0][-1]).strip("()").split(", ") collations = {} for column in columns: tokens = column[1:].split() column_name = tokens[0].strip('"') for index, token in enumerate(tokens): if token == "COLLATE": collation = tokens[index + 1] break else: collation = None collations[column_name] = collation return collations [6ce30249]
- def __getitem__(self, key): key = key.lower().split("(", 1)[0].strip() return self.base_data_types_reverse[key] [28e768d8]
- def _get_column_collations(self, cursor, table_name): row = cursor.execute( """ SELECT sql FROM sqlite_master WHERE type = 'table' AND name = %s """, [table_name], ).fetchone() if not row: return {} [d9833960]
- def _get_index_columns_orders(self, sql): tokens = sqlparse.parse(sql)[0] for token in tokens: if isinstance(token, sqlparse.sql.Parenthesis): columns = str(token).strip("()").split(", ") return ["DESC" if info.endswith("DESC") else "ASC" for info in columns] return None [ee6f5f5d]
- FieldInfo = namedtuple( "FieldInfo", [*BaseFieldInfo._fields, "pk", "has_json_constraint"] ) [d5c8e4e3]

## Beyond the budget

16 more facts did not fit in the budget: [2a266f45] [c49f18ae] [558d0d1f] [dc694e5a] [45dfb9a9] [53474645] [fd7e3b0f] [545ce087] [29b45d2b] [1a2339da] [2a640a76] [8c0ef233] [84593368] [b946acd58351fb6c-5] [afedaa63] [b960959c]
