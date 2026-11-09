# django/db/backends/base/base

- Subject: django/db/backends/base/base (id `c8c3aaf3-44a9-4870-a5cc-2c8ee7729d80`)
- Kind: subject
- Budget: 1200 tokens
- Used: 894 tokens
- Facts shown: 13 of 112
- Conflicts: 0
- Gaps: 0

## Facts

- # If an exception other than DataError or IntegrityError occurred # since the last commit / rollback, check if the connection works. if self.errors_occurred: if self.is_usable(): self.errors_occurred = False self.health_check_done = True else: self.close() return [a17b9650]
- if self.close_at is not None and time.monotonic() >= self.close_at: self.close() return [1537c046]
- # A list of no-argument functions to run when the transaction commits. # Each entry is an (sids, func, robust) tuple, where sids is a set of # the active savepoint IDs when this function was registered and robust # specifies whether it's allowed for the function to fail. self.run_on_commit = [] [e76dcfd2]
- # A stack of wrappers to be invoked around execute()/executemany() # calls. Each entry is a function taking five arguments: execute, sql, # params, many, and context. It's the function's responsibility to # call execute(sql, params, many, context). self.execute_wrappers = [] [847fceaa]
- # Connection termination related attributes. self.close_at = None self.closed_in_transaction = False self.errors_occurred = False self.health_check_enabled = False self.health_check_done = False [6d2607c3]
- # Don't call validate_no_atomic_block() to avoid making it difficult # to get rid of a connection in an invalid state. The next connect() # will reset the transaction state anyway. if self.closed_in_transaction or self.connection is None: return try: self._close() finally: if self.in_atomic_block: self.closed_in_transaction = True self.needs_rollback = True else: self.connection = None [afa6700d]
- # Remove any callbacks registered while this savepoint was active. self.run_on_commit = [ (sids, func, robust) for (sids, func, robust) in self.run_on_commit if sid not in sids ] [7512de34]
- # Should we run the on-commit hooks the next time set_autocommit(True) # is called? self.run_commit_hooks_on_set_autocommit_on = False [9f464585]
- # Thread-safety related attributes. self._thread_sharing_lock = threading.Lock() self._thread_sharing_count = 0 self._thread_ident = _thread.get_ident() [bb20b641]
- # Transaction related attributes. # Tracks if the connection is in autocommit mode. Per PEP 249, by # default, it isn't. self.autocommit = False # Tracks if the connection is in a transaction managed by 'atomic'. self.in_atomic_block = False # Increment to generate unique savepoint ids. self.savepoint_state = 0 # List of savepoints created by 'atomic'. self.savepoint_ids = [] # Stack of active 'atomic' blocks. self.atomic_blocks = [] # Tracks if the outermost 'atomic' block should commit on exit, # ie. if autocommit was active on entry. self.commit_on_exit = True # Tracks if the transaction should be rolled back to the next # available savepoint because of an exception in an inner block. self.needs_rollback = False self.rollback_exc = None [6b6c0add]
- Actual implementations should take care not to raise exceptions as that may prevent Django from recycling unusable connections. """ raise NotImplementedError( "subclasses of BaseDatabaseWrapper may require an is_usable() method" ) [23ba8955]
- This method may assume that self.connection is not None. [db1485a4]
- return sid [2e534ed9]

## Beyond the budget

96 more facts did not fit in the budget: [669746c2] [9718833f] [721f4d48] [69c94e90] [ca9e0565] [a7951b5f] [1008cd25] [31bb91db] [ca82c125] [5e6f91f1] [c994821e] [92accd86] [5015598f] [420d75bd] [b22ff4d3] [75c20cdf] [216b0580] [d7c938ea] [860c3e79] [c691668d] [692bfef3] [4a0ad3bd] [821def69] [057c8651] [aacabaa1] [972b62b8] [bbd3135b] [923816bc] [03b23c06] [a34154aa] [5ba5f2ce] [c740f888] [181badca] [600ec60f] [ef78bb53] [49fac474] [8054f553] [72037ca7] [79eca931] [2fa65b20] [165331c2] [69b97db4] [7865dfd3] [d0a02521] [df198505] [2b7ee766] [7702d0c8] [206d834f] [61ebfce6] [d74e169f] [af365431] [6e733661] [4dcf4c2b] [037b322b] [55e19e56] [d9001922] [8171897f] [404dd9cd] [451be9d2] [bc4aa26d] [89bb6f13] [1d78391c] [6ba40130] [3cbe0cd2] [b4c4e6cb] [59580c95] [499593f1] [767f3655] [634d86f1] [6c434ab8] [2d0c54d4] [05970a34] [89da472d] [7bda22d5] [630b0cc2] [96577b33] [1b136df4] [925b1d30] [61cb6f0a] [8658f1bb] [c42a4521] [833e704b] [146849d5] [b3332230] [d76e53a0] [f6b60615] [bf8a3db8] [4c22cb8c] [6da700ff] [690bc46b] [5d3f51be] [1fda33ff] [0376a32e] [a37fd389] [a1a94543] [8409d930]
