# django/contrib/gis/geos/mutable_list

- Subject: django/contrib/gis/geos/mutable_list (id `9a33ddf2-3ecc-42f6-819e-218d79486a6f`)
- Kind: subject
- Budget: 1200 tokens
- Used: 892 tokens
- Facts shown: 23 of 61
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

36 more facts did not fit in the budget: [27b6be0c] [5d766a8c] [093c4a47] [1ab5dd2c] [df0b6565] [2c68f101] [80a3aa4e] [6ebf080c] [b39e2006] [8369c826] [64bd7411] [fcaba495] [3601f7bf] [2e0684fb] [af6449ec] [884a7b3f] [e3872208] [60e8f7d4] [50f84872] [91df77f1] [dd155ed5] [51ccd99d] [57e65f80] [cfce8765] [d7c43d82] [4b956a5f] [550296f5] [49b5068e] [0faa5ab5] [a4bed630] [4c556bbd] [93280271] [349d3f4b] [9fc76a7f] [336ddf6d] [363dc81b4a0151df]
