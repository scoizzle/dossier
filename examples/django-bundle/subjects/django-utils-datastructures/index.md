# django/utils/datastructures

- Subject: django/utils/datastructures (id `d6ed4b26-2e6c-46d5-99cf-996ddd6d7e38`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2821 tokens
- Facts shown: 63 of 63
- Conflicts: 0
- Gaps: 0

## Highlights

- >>> a = ImmutableList(range(5), warning="You cannot mutate this.") >>> a[3] = '4' Traceback (most recent call last): ... AttributeError: You cannot mutate this. """ [aa918ba8]
- >>> ci_map = CaseInsensitiveMapping({'name': 'Jane'}) >>> ci_map['Name'] Jane >>> ci_map['NAME'] Jane >>> ci_map['name'] Jane >>> ci_map # original case preserved {'name': 'Jane'} """ [696e05a0]
- Used internally to manipulate values list. If force_list is True, return a new copy of values. """ try: values = super().__getitem__(key) except KeyError: if default is None: return [] return default else: if force_list: values = list(values) if values is not None else None return values [e8a8283c]
- # All list mutation functions complain. __delitem__ = complain __delslice__ = complain __iadd__ = complain __imul__ = complain __setitem__ = complain __setslice__ = complain append = complain extend = complain insert = complain pop = complain remove = complain sort = complain reverse = complain [d6603a11]
- >>> d = MultiValueDict( ... {'name': ['Adrian', 'Simon'], 'position': ['Developer']} ... ) >>> d['name'] 'Simon' >>> d.getlist('name') ['Adrian', 'Simon'] >>> d.getlist('doesnotexist') [] >>> d.getlist('doesnotexist', ['Adrian', 'Simon']) ['Adrian', 'Simon'] >>> d.get('lastname', 'nonexistent') 'nonexistent' >>> d.setlist('lastname', ['Holovaty', 'Willison']) [a87346e9]
- @staticmethod def _unpack_items(data): # Explicitly test for dict first as the common case for performance, # avoiding abc's __instancecheck__ and _abc_instancecheck for the # general Mapping case. if isinstance(data, (dict, Mapping)): yield from data.items() return for i, elem in enumerate(data): if len(elem) != 2: raise ValueError( "dictionary update sequence element #{} has length {}; " "2 is required.".format(i, len(elem)) ) if not isinstance(elem[0], str): raise ValueError( "Element key %r invalid, only strings are allowed" % elem[0] ) yield elem [93cd5a1c]
- Example:: [24ca13eabf54f502-3]
- Example:: [24ca13eabf54f502-4]
- The value at ``deferred_key`` must itself be a dict. Accessing ``DeferredSubDict(parent_dict, deferred_key)[key]`` retrieves ``parent_dict[deferred_key][key]`` at access time, so updates to the parent dict are reflected. """ [182b310c]
- This class exists to solve the irritating problem raised by cgi.parse_qs, which returns a list for every key, even though most web forms submit single name-value pairs. """ [101dd694]
- Used by the SQL construction code to ensure that values are correctly quoted before being used. """ [6d4ddec1]
- def __bool__(self): return bool(self.dict) [a3e15597]
- def __contains__(self, item): return item in self.dict [a240dff9]
- def __copy__(self): return self.__class__([(k, v[:]) for k, v in self.lists()]) [1e6bf307]
- def __deepcopy__(self, memo): result = self.__class__() memo[id(self)] = result for key, value in dict.items(self): dict.__setitem__( result, copy.deepcopy(key, memo), copy.deepcopy(value, memo) ) return result [aaf86fdb]
- def __eq__(self, other): return isinstance(other, Mapping) and { k.lower(): v for k, v in self.items() } == {k.lower(): v for k, v in other.items()} [8e2db277]

## All facts

- [603a4ad7] def __getitem__(self, key): """ Retrieve the real value after stripping the prefix string (if present). If the prefix is present, pass the value through self.func before returning, otherwise return the raw value. """ use_func = key.startswith(self.prefix) key = key.removeprefix(self.prefix) value = super().__getitem__(key) if use_func: return self.func(value) return value
- [7fb33395] def __getitem__(self, key): """ Return the last data value for this key, or [] if it's an empty list; raise KeyError if not found. """ try: list_ = super().__getitem__(key) except KeyError: raise MultiValueDictKeyError(key) try: return list_[-1] except IndexError: return []
- [271919ff] def __getitem__(self, key): return self._store[key.lower()][1]
- [36c4012b] def __getitem__(self, key): return self.parent_dict[self.deferred_key][key]
- [6f5d771d] def __getstate__(self): return {**self.__dict__, "_data": {k: self._getlist(k) for k in self}}
- [b9d0e29c] def __init__(self, data): self._store = {k.lower(): (k, v) for k, v in self._unpack_items(data)}
- [90e98e94] def __init__(self, data, func, prefix): super().__init__(data) self.func = func self.prefix = prefix
- [2d9c5528] def __init__(self, iterable=None): self.dict = dict.fromkeys(iterable or ())
- [6fb07c59] def __init__(self, key_to_list_mapping=()): super().__init__(key_to_list_mapping)
- [aa031b7a] def __init__(self, parent_dict, deferred_key): self.parent_dict = parent_dict self.deferred_key = deferred_key
- [0d3ce6ec] def __iter__(self): return (original_key for original_key, value in self._store.values())
- [5320d273] def __iter__(self): return iter(self.dict)
- [f567e1e6] def __len__(self): return len(self._store)
- [5ad9f347] def __len__(self): return len(self.dict)
- [1897bd99] def __new__(cls, *args, warning="ImmutableList object is immutable.", **kwargs): self = tuple.__new__(cls, *args, **kwargs) self.warning = warning return self
- [0b7b7911] def __repr__(self): data = repr(list(self.dict)) if self.dict else "" return f"{self.__class__.__qualname__}({data})"
- [17cc278f] def __repr__(self): return "<%s: %s>" % (self.__class__.__name__, super().__repr__())
- [6a3679bf] def __repr__(self): return repr({key: value for key, value in self._store.values()})
- [ff74d127] def __reversed__(self): return reversed(self.dict)
- [bf7ffbc1] def __setitem__(self, key, value): super().__setitem__(key, [value])
- [186e0aaf] def __setstate__(self, obj_dict): data = obj_dict.pop("_data", {}) for k, v in data.items(): self.setlist(k, v) self.__dict__.update(obj_dict)
- [71328f1a] def _getlist(self, key, default=None, force_list=False): """ Return a list of values for the key.
- [12147bd0] def add(self, item): self.dict[item] = None
- [aeb0b3c9] def appendlist(self, key, value): """Append an item to the internal list associated with key.""" self.setlistdefault(key).append(value)
- [b1b000ec] def complain(self, *args, **kwargs): raise AttributeError(self.warning)
- [56ab7020] def copy(self): """Return a shallow copy of this object.""" return copy.copy(self)
- [14359910] def copy(self): return self
- [a4a3a7f7] def dict(self): """Return current object as a dict with singular values.""" return {key: self[key] for key in self}
- [c8bc77af] def discard(self, item): try: self.remove(item) except KeyError: pass
- [d30232fb] def get(self, key, default=None): """ Return the last data value for the passed key. If key doesn't exist or value is an empty list, return `default`. """ try: val = self[key] except KeyError: return default if val == []: return default return val
- [5ced996d] def getlist(self, key, default=None): """ Return the list of values for the key. If key doesn't exist, return a default value. """ return self._getlist(key, default, force_list=True)
- [ac84d88f] def items(self): """ Yield (key, value) pairs, where value is the last item in the list associated with the key. """ for key in self: yield key, self[key]
- [f371662d] def lists(self): """Yield (key, list) pairs.""" return iter(super().items())
- [2b53c88f] def remove(self, item): del self.dict[item]
- [dba163af] def setdefault(self, key, default=None): if key not in self: self[key] = default # Do not return default here because __setitem__() may store # another value -- QueryDict.__setitem__() does. Look it up. return self[key]
- [901cfc97] def setlist(self, key, list_): super().__setitem__(key, list_)
- [ab350cd9] def setlistdefault(self, key, default_list=None): if key not in self: if default_list is None: default_list = [] self.setlist(key, default_list) # Do not return default_list here because setlist() may store # another value -- QueryDict.setlist() does. Look it up. return self._getlist(key)
- [26e67372] def update(self, *args, **kwargs): """Extend rather than replace existing key lists.""" if len(args) > 1: raise TypeError("update expected at most 1 argument, got %d" % len(args)) if args: arg = args[0] if isinstance(arg, MultiValueDict): for key, value_list in arg.lists(): self.setlistdefault(key).extend(value_list) else: if isinstance(arg, Mapping): arg = arg.items() for key, value in arg: self.setlistdefault(key).append(value) for key, value in kwargs.items(): self.setlistdefault(key).append(value)
- [2ef360c5] def values(self): """Yield the last value on every key list.""" for key in self: yield self[key]
- [0aad66ad] class CaseInsensitiveMapping(Mapping): """ Mapping allowing case-insensitive key lookups. Original case of keys is preserved for iteration and string representation.
- [b0af2bc5] class DeferredSubDict: """ Wrap a dict, allowing deferred access to a sub-dict under a given key.
- [81f2ef63] class DictWrapper(dict): """ Wrap accesses to a dictionary so that certain values (those starting with the specified prefix) are passed through a function before being returned. The prefix is removed before looking up the real value.
- [91111cad] class ImmutableList(tuple): """ A tuple-like object that raises useful errors when it is asked to mutate.
- [37758d48] class MultiValueDict(dict): """ A subclass of dictionary customized to handle multiple values for the same key.
- [fde1134b] class MultiValueDictKeyError(KeyError): pass
- [e2baf77b] class OrderedSet: """ A set which keeps the ordering of the inserted items. """
- [1d684a25] import copy from collections.abc import Mapping
