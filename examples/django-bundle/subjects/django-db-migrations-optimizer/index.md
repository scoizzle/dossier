# django/db/migrations/optimizer

- Subject: django/db/migrations/optimizer (id `d2455ad1-8c45-4459-a5a4-0fb1a11d47dd`)
- Kind: subject
- Budget: 1200 tokens
- Used: 681 tokens
- Facts shown: 6 of 6
- Conflicts: 0
- Gaps: 0

## Facts

- The inner loop is run until the starting list is the same as the result list, and then the result is returned. This means that operation optimization must be stable and always return an equal or shorter list. """ # Internal tracking variable for test assertions about # of loops if app_label is None: raise TypeError("app_label must be a str.") self._iterations = 0 while True: result = self.optimize_inner(operations, app_label) self._iterations += 1 if result == operations: return result operations = result [eab5275a]
- Unfortunately, due to the scope of the optimization (two combinable operations might be separated by several hundred others), this can't be done as a peephole optimization with checks/output implemented on the Operations themselves; instead, the optimizer looks at each individual operation and scans forwards in the list to see if there are any matches, stopping at boundaries - operations which can't be optimized over (RunSQL, operations on the same field/model, etc.) [de7f4744]
- For example, a CreateModel and an AddField can be optimized into a new CreateModel, and CreateModel and DeleteModel can be optimized into nothing. """ [91b2819d]
- def optimize(self, operations, app_label): """ Main optimization entry point. Pass in a list of Operation instances, get out a new list of Operation instances. [bba35b78]
- def optimize_inner(self, operations, app_label): """Inner optimization loop.""" new_operations = [] for i, operation in enumerate(operations): right = True # Should we reduce on the right or on the left. # Compare it to each operation after it for j, other in enumerate(operations[i + 1 :]): result = operation.reduce(other, app_label) if isinstance(result, list): in_between = operations[i + 1 : i + j + 1] if right: new_operations.extend(in_between) new_operations.extend(result) elif all(op.reduce(other, app_label) is True for op in in_between): # Perform a left reduction if all of the in-between # operations can optimize through other. new_operations.extend(result) new_operations.extend(in_between) else: # Otherwise keep trying. new_operations.append(operation) break new_operations.extend(operations[i + j + 2 :]) return new_operations elif not result: # Can't perform a right reduction. right = False else: new_operations.append(operation) return new_operations [74d4635e]
- class MigrationOptimizer: """ Power the optimization process, where you provide a list of Operations and you are returned a list of equal or shorter length - operations are merged into one if possible. [bf9b707d]
