# django/db/__init__

- Subject: django/db/__init__ (id `8a8eb110-9fc4-47f0-bfb2-e6fc06bc24fd`)
- Kind: subject
- Budget: 1200 tokens
- Used: 440 tokens
- Facts shown: 9 of 9
- Conflicts: 0
- Gaps: 0

## Facts

- # For backwards compatibility. Prefer connections['default'] instead. connection = ConnectionProxy(connections, DEFAULT_DB_ALIAS) [f7f8aaa2]
- # Register an event to reset saved queries when a Django request is started. def reset_queries(**kwargs): for conn in connections.all(initialized_only=True): conn.queries_log.clear() [49271640]
- # Register an event to reset transaction state and close connections past # their lifetime. def close_old_connections(**kwargs): for conn in connections.all(initialized_only=True): conn.close_if_unusable_or_obsolete() [cd028d31]
- __all__ = [ "close_old_connections", "connection", "connections", "reset_queries", "router", "DatabaseError", "IntegrityError", "InternalError", "ProgrammingError", "DataError", "NotSupportedError", "Error", "InterfaceError", "OperationalError", "DEFAULT_DB_ALIAS", "DJANGO_VERSION_PICKLE_KEY", ] [1ec6b060]
- connections = ConnectionHandler() [6382b8b2]
- from django.core import signals from django.db.utils import ( DEFAULT_DB_ALIAS, DJANGO_VERSION_PICKLE_KEY, ConnectionHandler, ConnectionRouter, DatabaseError, DataError, Error, IntegrityError, InterfaceError, InternalError, NotSupportedError, OperationalError, ProgrammingError, ) from django.utils.connection import ConnectionProxy [bac56054]
- router = ConnectionRouter() [5422967a]
- signals.request_started.connect(close_old_connections) signals.request_finished.connect(close_old_connections) [88c1e4e3]
- signals.request_started.connect(reset_queries) [630373ae]
