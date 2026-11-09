# django/utils/datastructures

- Subject: django/utils/datastructures (id `56c50016-48f4-442c-be62-6d73e7582b87`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 16 of 63
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

47 more facts did not fit in the budget: [603a4ad7] [7fb33395] [271919ff] [36c4012b] [6f5d771d] [b9d0e29c] [90e98e94] [2d9c5528] [6fb07c59] [aa031b7a] [0d3ce6ec] [5320d273] [f567e1e6] [5ad9f347] [1897bd99] [0b7b7911] [17cc278f] [6a3679bf] [ff74d127] [bf7ffbc1] [186e0aaf] [71328f1a] [12147bd0] [aeb0b3c9] [b1b000ec] [56ab7020] [14359910] [a4a3a7f7] [c8bc77af] [d30232fb] [5ced996d] [ac84d88f] [f371662d] [2b53c88f] [dba163af] [901cfc97] [ab350cd9] [26e67372] [2ef360c5] [0aad66ad] [b0af2bc5] [81f2ef63] [91111cad] [37758d48] [fde1134b] [e2baf77b] [1d684a25]
