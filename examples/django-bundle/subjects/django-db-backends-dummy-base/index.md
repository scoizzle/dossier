# django/db/backends/dummy/base

- Subject: django/db/backends/dummy/base (id `5ca6db4b-a827-468d-8f9c-fbececef92cb`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 636 tokens
- Facts shown: 12 of 12
- Conflicts: 0
- Gaps: 0

## Facts

- def is_usable(self): return True [105dcdc39af5d768]
- """ Dummy database backend for Django. [bc0b08a6]
- Django uses this if the database ENGINE setting is empty (None or empty string). [1c0e0c56]
- Each of these API functions, except connection.close(), raise ImproperlyConfigured. """ [40595e1d]
- class DatabaseClient(BaseDatabaseClient): runshell = complain [3d3008f7]
- class DatabaseCreation(BaseDatabaseCreation): create_test_db = ignore destroy_test_db = ignore serialize_db_to_string = ignore [9c289307]
- class DatabaseIntrospection(BaseDatabaseIntrospection): get_table_list = complain get_table_description = complain get_relations = complain get_indexes = complain [6a459d59]
- class DatabaseOperations(BaseDatabaseOperations): quote_name = complain [b72e5fe0]
- class DatabaseWrapper(BaseDatabaseWrapper): operators = {} # Override the base class implementations with null # implementations. Anything that tries to actually # do something raises complain; anything that tries # to rollback or undo something raises ignore. _cursor = complain ensure_connection = complain _commit = complain _rollback = ignore _close = ignore _savepoint = ignore _savepoint_commit = complain _savepoint_rollback = ignore _set_autocommit = complain # Classes instantiated in __init__(). client_class = DatabaseClient creation_class = DatabaseCreation features_class = DummyDatabaseFeatures introspection_class = DatabaseIntrospection ops_class = DatabaseOperations [ccebe885]
- def complain(*args, **kwargs): raise ImproperlyConfigured( "settings.DATABASES is improperly configured. " "Please supply the ENGINE value. Check " "settings documentation for more details." ) [c6a23448]
- def ignore(*args, **kwargs): pass [686e88d4]
- from django.core.exceptions import ImproperlyConfigured from django.db.backends.base.base import BaseDatabaseWrapper from django.db.backends.base.client import BaseDatabaseClient from django.db.backends.base.creation import BaseDatabaseCreation from django.db.backends.base.introspection import BaseDatabaseIntrospection from django.db.backends.base.operations import BaseDatabaseOperations from django.db.backends.dummy.features import DummyDatabaseFeatures [32d3b826]
