# django/contrib/gis/geos/mutable_list

- Subject: django/contrib/gis/geos/mutable_list (id `d628de84-fac0-4991-8461-debaa0f30948`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2584 tokens
- Facts shown: 59 of 61
- Conflicts: 0
- Gaps: 0

## Highlights

- if i < origLen: if i < start or i >= stop: yield self._get_single_internal(i) [b5a3ae86]
- # CAREFUL: index.step and step are not the same! # step will never be None if index.step is None: self._assign_simple_slice(start, stop, valueList) else: self._assign_extended_slice(start, stop, step, valueList) [f90bd29b]
- # calculate new length and dimensions origLen = len(self) if isinstance(index, int): index = self._checkindex(index) indexRange = [index] else: indexRange = range(*index.indices(origLen)) [50241f99]
- # we're not changing the length of the sequence newLen = len(self) newVals = dict(zip(indexList, valueList)) [fd22d757]
- NOTE: items may be a generator which calls _get_single_internal. Therefore, it is necessary to cache the values in a temporary: temp = list(items) before clobbering the original storage. [52ffadea]
- def newItems(): for i in range(newLen): if i in newVals: yield newVals[i] else: yield self._get_single_internal(i) [6eebb1fa]
- def newItems(): for i in range(origLen + 1): if i == start: yield from valueList [5a67b636]
- for i, val in zip(indexList, valueList): self._set_single(i, val) [63f4634c]
- if not hasattr(self, "_set_single"): self._set_single = self._set_single_rebuild self._assign_extended_slice = self._assign_extended_slice_rebuild [d9f17366]
- newLen = origLen - len(indexRange) newItems = ( self._get_single_internal(i) for i in range(origLen) if i not in indexRange ) [3510e72d]
- origLen = len(self) start, stop, step = index.indices(origLen) [0c3535e2]
- self._check_allowed(valueList) [b4b77687]
- self._rebuild(newLen, newItems()) [5f75a573b6b295dc]
- self._set_list(newLen, newItems) [a257ca83]
- super().__init__(*args, **kwargs) [a84ca41e6642a566-2]
- # ## Mutating ## def append(self, val): "Standard list append method" self[len(self) :] = [val] [29cd34dd]
- # ### Private routines ### def _rebuild(self, newLen, newItems): if newLen and newLen < self._minlength: raise ValueError("Must have at least %d items" % self._minlength) if self._maxlength is not None and newLen > self._maxlength: raise ValueError("Cannot have more than %d items" % self._maxlength) [1b1f0dad]
- # ### Public list interface Methods ### # ## Non-mutating ## def count(self, val): "Standard list count method" count = 0 for i in self: if val == i: count += 1 return count [d9fd998a]
- # ### Python initialization and special list interface methods ### [a7e2aa89]
- # ### Special methods for arithmetic operations ### def __add__(self, other): "add another list-like object" return self.__class__([*self, *other]) [3552331c]
- _minlength = 0 _maxlength = None [594ce221]
- def __delitem__(self, index): "Delete the item(s) at the specified index/slice." if not isinstance(index, (int, slice)): raise TypeError("%s is not a legal index" % index) [9b5028ed]
- def __iadd__(self, other): "add another list-like object to self" self.extend(other) return self [51725cf4]

## All facts

- [27b6be0c] def __eq__(self, other): olen = len(other) for i in range(olen): try: c = self[i] == other[i] except IndexError: # self must be shorter return False if not c: return False return len(self) == olen
- [5d766a8c] def __getitem__(self, index): "Get the item(s) at the specified index/slice." if isinstance(index, slice): return [ self._get_single_external(i) for i in range(*index.indices(len(self))) ] else: index = self._checkindex(index) return self._get_single_external(index)
- [093c4a47] def __imul__(self, n): "multiply" if n <= 0: del self[:] else: cache = list(self) for i in range(n - 1): self.extend(cache) return self
- [1ab5dd2c] def __init__(self, *args, **kwargs): if not hasattr(self, "_get_single_internal"): self._get_single_internal = self._get_single_external
- [df0b6565] def __lt__(self, other): olen = len(other) for i in range(olen): try: c = self[i] < other[i] except IndexError: # self must be shorter return True if c: return c elif other[i] < self[i]: return False return len(self) < olen
- [2c68f101] def __mul__(self, n): "multiply" return self.__class__(list(self) * n)
- [80a3aa4e] def __radd__(self, other): "add to another list-like object" return other.__class__([*other, *self])
- [6ebf080c] def __rmul__(self, n): "multiply" return self.__class__(list(self) * n)
- [b39e2006] def __setitem__(self, index, val): "Set the item(s) at the specified index/slice." if isinstance(index, slice): self._set_slice(index, val) else: index = self._checkindex(index) self._check_allowed((val,)) self._set_single(index, val)
- [8369c826] def _assign_extended_slice(self, start, stop, step, valueList): "Assign an extended slice by re-assigning individual items" indexList = range(start, stop, step) # extended slice, only allow assigning slice of same size if len(valueList) != len(indexList): raise ValueError( "attempt to assign sequence of size %d " "to extended slice of size %d" % (len(valueList), len(indexList)) )
- [64bd7411] def _assign_extended_slice_rebuild(self, start, stop, step, valueList): "Assign an extended slice by rebuilding entire list" indexList = range(start, stop, step) # extended slice, only allow assigning slice of same size if len(valueList) != len(indexList): raise ValueError( "attempt to assign sequence of size %d " "to extended slice of size %d" % (len(valueList), len(indexList)) )
- [fcaba495] def _assign_simple_slice(self, start, stop, valueList): "Assign a simple slice; Can assign slice of any length" origLen = len(self) stop = max(start, stop) newLen = origLen - stop + start + len(valueList)
- [3601f7bf] def _check_allowed(self, items): if hasattr(self, "_allowed"): if False in [isinstance(val, self._allowed) for val in items]: raise TypeError("Invalid type encountered in the arguments.")
- [2e0684fb] def _checkindex(self, index): length = len(self) if 0 <= index < length: return index if -length <= index < 0: return index + length raise IndexError("invalid index: %s" % index)
- [af6449ec] def _set_single_rebuild(self, index, value): self._set_slice(slice(index, index + 1, 1), [value])
- [884a7b3f] def _set_slice(self, index, values): "Assign values to a slice of the object" try: valueList = list(values) except TypeError: raise TypeError("can only assign an iterable to a slice")
- [e3872208] def extend(self, vals): "Standard list extend method" self[len(self) :] = vals
- [60e8f7d4] def index(self, val): "Standard list index method" for i in range(0, len(self)): if self[i] == val: return i raise ValueError("%s not found in object" % val)
- [50f84872] def insert(self, index, val): "Standard list insert method" if not isinstance(index, int): raise TypeError("%s is not a legal index" % index) self[index:index] = [val]
- [91df77f1] def pop(self, index=-1): "Standard list pop method" result = self[index] del self[index] return result
- [dd155ed5] def remove(self, val): "Standard list remove method" del self[self.index(val)]
- [51ccd99d] def reverse(self): "Standard list reverse method" self[:] = self[-1::-1]
- [57e65f80] def sort(self, key=None, reverse=False): "Standard list sort method" self[:] = sorted(self, key=key, reverse=reverse)
- [cfce8765] function __len__(self): Return the length
- [d7c43d82] function _get_single_external(self, i): Return single item with index i for general use. The index i will always satisfy 0 <= i < len(self).
- [4b956a5f] function _get_single_internal(self, i): Same as above, but for use within the class [Optional] Note that if _get_single_internal and _get_single_internal return different types of objects, _set_list must distinguish between the two and handle each appropriately.
- [550296f5] function _set_list(self, length, items): Recreate the entire object.
- [49b5068e] function _set_single(self, i, value): Set the single item at index i to value [Optional] If left undefined, all mutations will result in rebuilding the object using _set_list.
- [0faa5ab5] int _maxlength: The maximum legal length [Optional]
- [a4bed630] int _minlength: The minimum legal length [Optional]
- [4c556bbd] type or tuple _allowed: A type or tuple of allowed item types [Optional] """
- [93280271] # Copyright (c) 2008-2009 Aryeh Leib Taurog, all rights reserved. # Released under the New BSD license. """ This module contains a base type which provides list-style mutations without specific data storage methods.
- [349d3f4b] @total_ordering class ListMixin: """ A base class which provides complete list interface. Derived classes must call ListMixin's __init__() function and implement the following:
- [9fc76a7f] Author: Aryeh Leib Taurog. """
- [336ddf6d] See also http://static.aryehleib.com/oldsite/MutableLists.html
- [363dc81b4a0151df] from functools import total_ordering
