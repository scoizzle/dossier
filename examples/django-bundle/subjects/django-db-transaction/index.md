# django/db/transaction

- Subject: django/db/transaction (id `6d6be783-405c-43ef-969a-315a1c58c267`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2991 tokens
- Facts shown: 48 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- elif exc_type is None and not connection.needs_rollback: if connection.in_atomic_block: # Release savepoint if there is one if sid is not None: try: connection.savepoint_commit(sid) except DatabaseError: try: connection.savepoint_rollback(sid) # The savepoint won't be reused. Release it to # minimize overhead for the database server. connection.savepoint_commit(sid) except Error: # If rolling back to a savepoint fails, mark # for rollback at a higher level and avoid # shadowing the original exception. connection.needs_rollback = True raise else: # Commit transaction try: connection.commit() except DatabaseError: try: connection.rollback() except Error: # An error during rollback means that something # went wrong with the connection. Drop it. connection.close() raise else: # This flag will be set to True again if there isn't a # savepoint allowing to perform the rollback at this level. connection.needs_rollback = False if connection.in_atomic_block: # Roll back to savepoint if there is one, mark for rollback # otherwise. if sid is None: connection.needs_rollback = True else: try: connection.savepoint_rollback(sid) # The savepoint won't be reused. Release it to # minimize overhead for the database server. connection.savepoint_commit(sid) except Error: # If rolling back to a savepoint fails, mark for # rollback at a higher level and avoid shadowing # the original exception. connection.needs_rollback = True else: # Roll back transaction try: connection.rollback() except Error: # An error during rollback means that something # went wrong with the connection. Drop it. connection.close() [778bf758]
- connection = get_connection(using) if connection.get_autocommit(): yield else: with transaction.atomic(using=using, savepoint=False): yield [c8526cb8]
- finally: # Outermost block exit when autocommit was enabled. if not connection.in_atomic_block: if connection.closed_in_transaction: connection.connection = None else: connection.set_autocommit(True) # Outermost block exit when autocommit was disabled. elif not connection.savepoint_ids and not connection.commit_on_exit: if connection.closed_in_transaction: connection.connection = None else: connection.in_atomic_block = False [ca9ad323]
- if ( self.durable and connection.atomic_blocks and not connection.atomic_blocks[-1]._from_testcase ): raise RuntimeError( "A durable atomic block cannot be nested within another " "atomic block." ) if not connection.in_atomic_block: # Reset state when entering an outermost atomic block. connection.commit_on_exit = True connection.needs_rollback = False if not connection.get_autocommit(): # Pretend we're already in an atomic block to bypass the code # that disables autocommit to enter a transaction, and make a # note to deal with this case in __exit__. connection.in_atomic_block = True connection.commit_on_exit = False [eef40554]
- if connection.in_atomic_block: # We're already in a transaction; create a savepoint, unless we # were told not to or we're already waiting for a rollback. The # second condition avoids creating useless savepoints and prevents # overwriting needs_rollback until the rollback is performed. if self.savepoint and not connection.needs_rollback: sid = connection.savepoint() connection.savepoint_ids.append(sid) else: connection.savepoint_ids.append(None) else: connection.set_autocommit( False, force_begin_transaction_with_broken_autocommit=True ) connection.in_atomic_block = True [b210551c]

## All facts

- [ec9142ba] if connection.in_atomic_block: connection.atomic_blocks.append(self)
- [55561368] if connection.in_atomic_block: connection.atomic_blocks.pop()
- [29da6881] if connection.savepoint_ids: sid = connection.savepoint_ids.pop() else: # Prematurely unset this flag to allow using commit or rollback. connection.in_atomic_block = False
- [905e9d4e] try: if connection.closed_in_transaction: # The database will perform a rollback by itself. # Wait until we exit the outermost block. pass
- [f002eab6] A stack of savepoint identifiers is maintained as an attribute of the connection. None denotes the absence of a savepoint.
- [34d7bd46] An atomic block can be tagged as durable. In this case, a RuntimeError is raised if it's nested within another atomic block. This guarantees that database changes in a durable block are committed to the database when the block exits without error.
- [869963ca] An instance can be used either as a decorator or as a context manager.
- [f1d3e200] It's equivalent to:
- [90ea28a0] It's possible to disable the creation of savepoints if the goal is to ensure that some code runs within a transaction without creating overhead.
- [738c729e] Since database connections are thread-local, this is thread-safe.
- [72c47d5c] This allows reentrancy even if the same AtomicWrapper is reused. For example, it's possible to define `oa = atomic('other')` and use `@oa` or `with oa:` multiple times.
- [cdec0692] This is a private API. """
- [b1ea25f4] When `rollback` is `False`, prevent such a rollback. Use this only after rolling back to a known-good state! Otherwise, you break the atomic block and data corruption may occur. """ return get_connection(using).set_rollback(rollback)
- [cff84c1e] When `rollback` is `True`, trigger a rollback when exiting the innermost enclosing atomic block that has `savepoint=True` (that's the default). Use this to force a rollback without raising an exception.
- [85aa285c] When it's used as a context manager, __enter__ creates a transaction or a savepoint, depending on whether a transaction is already in progress, and __exit__ commits the transaction or releases the savepoint on normal exit, and rolls back the transaction or to the savepoint on exceptions.
- [5d4c31f4] When it's used as a decorator, __call__ wraps the execution of the decorated function in the instance itself, used as a context manager.
- [8e8e6a5c] but it uses low-level utilities to avoid performance overhead. """ try: yield except Exception as exc: connection = get_connection(using) if connection.in_atomic_block: connection.needs_rollback = True connection.rollback_exc = exc raise
- [f48e3bc5] def __enter__(self): connection = get_connection(self.using)
- [597cfbbf] def __exit__(self, exc_type, exc_value, traceback): connection = get_connection(self.using)
- [329dafb9] def __init__(self, using, savepoint, durable): self.using = using self.savepoint = savepoint self.durable = durable self._from_testcase = False
- [7655780f0d17b825-49] pass
- [f53a8ae2] ################################# # Decorators / context managers # #################################
- [3183709b] @contextmanager def mark_for_rollback_on_error(using=None): """ Internal low-level utility to mark a transaction as "needs rollback" when an exception is raised while not enforcing the enclosed block to be in a transaction. This is needed by Model.save() and friends to avoid starting a transaction when in autocommit mode and a single query is executed.
- [3488b3de] class Atomic(ContextDecorator): """ Guarantee the atomic execution of a given block.
- [f630a85a] class TransactionManagementError(ProgrammingError): """Transaction management is used improperly."""
- [20392263] def _non_atomic_requests(view, using): try: view._non_atomic_requests.add(using) except AttributeError: view._non_atomic_requests = {using} return view
- [18f970ee] def atomic(using=None, savepoint=True, durable=False): # Bare decorator: @atomic -- although the first argument is called # `using`, it's actually the function being decorated. if callable(using): return Atomic(DEFAULT_DB_ALIAS, savepoint, durable)(using) # Decorator: @atomic(...) or context manager: with atomic(...): ... else: return Atomic(using, savepoint, durable)
- [db339ea0] def clean_savepoints(using=None): """ Reset the counter used to generate unique savepoint ids in this thread. """ get_connection(using).clean_savepoints()
- [55273ce0] def commit(using=None): """Commit a transaction.""" get_connection(using).commit()
- [d2da8c39] def get_autocommit(using=None): """Get the autocommit status of the connection.""" return get_connection(using).get_autocommit()
- [051af0ee] def get_connection(using=None): """ Get a database connection by name, or the default database connection if no name is provided. This is a private API. """ if using is None: using = DEFAULT_DB_ALIAS return connections[using]
- [1ce7d11a] def get_rollback(using=None): """Get the "needs rollback" flag -- for *advanced use* only.""" return get_connection(using).get_rollback()
- [5c8f63f5] def non_atomic_requests(using=None): if callable(using): return _non_atomic_requests(using, DEFAULT_DB_ALIAS) else: if using is None: using = DEFAULT_DB_ALIAS return lambda view: _non_atomic_requests(view, using)
- [fdac6fbd] def on_commit(func, using=None, robust=False): """ Register `func` to be called when the current transaction is committed. If the current transaction is rolled back, `func` will not be called. """ get_connection(using).on_commit(func, robust)
- [832d2adb] def rollback(using=None): """Roll back a transaction.""" get_connection(using).rollback()
- [56adb1ea] def savepoint(using=None): warnings.warn( "savepoint() is deprecated. Use savepoint_create() instead.", category=RemovedInDjango2028Warning, skip_file_prefixes=django_file_prefixes(), ) return savepoint_create(using=using)
- [2216a9f2] def savepoint_commit(sid, using=None): """ Commit the most recent savepoint (if one exists). Do nothing if savepoints are not supported. """ get_connection(using).savepoint_commit(sid)
- [1cd4fd7f] def savepoint_create(using=None): """ Create a savepoint (if supported and required by the backend) inside the current transaction. Return an identifier for the savepoint that will be used for the subsequent rollback or commit. """ return get_connection(using).savepoint()
- [edbce7e3] def savepoint_rollback(sid, using=None): """ Roll back the most recent savepoint (if one exists). Do nothing if savepoints are not supported. """ get_connection(using).savepoint_rollback(sid)
- [e4c44b39] def set_autocommit(autocommit, using=None): """Set the autocommit status of the connection.""" return get_connection(using).set_autocommit(autocommit)
- [30973345] def set_rollback(rollback, using=None): """ Set or unset the "needs rollback" flag -- for *advanced use* only.
- [76c69559] from django.db import ( DEFAULT_DB_ALIAS, DatabaseError, Error, ProgrammingError, connections, ) from django.utils.deprecation import RemovedInDjango2028Warning, django_file_prefixes
- [428c1799] import warnings from contextlib import ContextDecorator, contextmanager
