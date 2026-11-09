# django/db/backends/base/introspection

- Subject: django/db/backends/base/introspection (id `6692af10-39fc-4bf4-8fcd-440d0bfe8680`)
- Kind: subject
- Budget: 1200 tokens
- Used: 895 tokens
- Facts shown: 16 of 30
- Conflicts: 0
- Gaps: 0

## Facts

- For Oracle, the column data_type on its own is insufficient to distinguish between a FloatField and IntegerField, for example. """ return self.data_types_reverse[data_type] [366826a0]
- If only_existing is True, include only the tables in the database. """ tables = set() for model in self.get_migratable_models(): if not model._meta.managed: continue tables.add(model._meta.db_table) tables.update( f.m2m_db_table() for f in model._meta.local_many_to_many if f.remote_field.through._meta.managed ) tables = list(tables) if only_existing: existing_tables = set(self.table_names(include_views=include_views)) tables = [ t for t in tables if self.identifier_converter(t) in existing_tables ] return tables [30ec353a]
- Return a dict mapping constraint names to their attributes, where attributes is a dict with keys: * columns: List of columns this covers * primary_key: True if primary key, False otherwise * unique: True if this is a unique constraint, False otherwise * foreign_key: (table, column) of target, or None * check: True if check constraint, False otherwise * index: True if index, False otherwise. * orders: The order (ASC/DESC) defined for the columns of indexes * type: The type of the index (btree, hash, etc.) [522822a5]
- Some backends may return special constraint names that don't exist if they don't name constraints of a certain type (e.g. SQLite) """ raise NotImplementedError( "subclasses of BaseDatabaseIntrospection may require a get_constraints() " "method" ) [8bdc0dc2]
- The default identifier converter is for case sensitive comparison. """ return name [3136885e]
- def get_names(cursor): return sorted( ti.name for ti in self.get_table_list(cursor) if include_views or ti.type == "t" ) [ed56cb0e]
- if cursor is None: with self.connection.cursor() as cursor: return get_names(cursor) return get_names(cursor) [6873d77a]
- return ( model for app_config in apps.get_app_configs() for model in router.get_migratable_models(app_config, self.connection.alias) if model._meta.can_migrate(self.connection) ) [c028c039]
- data_types_reverse = {} on_delete_types = { "CASCADE": DB_CASCADE, "NO ACTION": DO_NOTHING, "SET DEFAULT": DB_SET_DEFAULT, "SET NULL": DB_SET_NULL, # DB_RESTRICT - "RESTRICT" is not supported. } [fa95c3fa]
- def __del__(self): del self.connection [aedcdc0442006877-4]
- def __init__(self, connection): self.connection = connection [f0a7ddc935b65180-3]
- def django_table_names(self, only_existing=False, include_views=True): """ Return a list of all table names that have associated Django models and are in INSTALLED_APPS. [e0af4abc]
- def get_constraints(self, cursor, table_name): """ Retrieve any constraints or keys (unique, pk, fk, check, index) across one or more columns. [a39776ad]
- def get_field_type(self, data_type, description): """ Hook for a database backend to use the cursor description to match a Django field type to a database column. [af640cc0]
- def get_migratable_models(self): from django.apps import apps from django.db import router [a140153f]
- def identifier_converter(self, name): """ Apply a conversion to the identifier for the purposes of comparison. [66e85f57]

## Beyond the budget

14 more facts did not fit in the budget: [7be13823] [f1e1a31a] [07cfca64] [006b54fa] [f239dd1d] [922054d7] [8652e62b] [40aea63b] [e73e310f] [3cec3035] [28e97e7c] [a90d2965] [b946acd58351fb6c] [2bf4e6e3]
