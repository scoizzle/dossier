# django/utils/functional

- Subject: django/utils/functional (id `72b29099-c788-4851-abd7-7ebd69885e6e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 23 of 81
- Conflicts: 0
- Gaps: 0

## Facts

- # Builds a wrapper around some method. Pass method_name to # avoid issues due to late binding. def __wrapper__(self, *args, __method_name=method_name, **kw): # Automatically triggers the evaluation of a lazy value and # applies the given method of the result type. result = func(*self._args, **self._kw) return getattr(result, __method_name)(*args, **kw) [e7788f08]
- setattr(__proxy__, method_name, __wrapper__) [3114e6d9]
- # Explicitly wrap methods which are defined on object and hence would # not have been overloaded by the loop over resultclasses below. [9d88b3ae]
- # Explicitly wrap methods which are required for certain operations on # int/str objects to function correctly. [87559b68]
- >>> partition(lambda x: x > 3, range(5)) [0, 1, 2, 3], [4] """ results = ([], []) for item in values: results[predicate(item)].append(item) return results [aa56aed1]
- @wraps(func) def wrapper(*args, **kwargs): if any( isinstance(arg, Promise) for arg in itertools.chain(args, kwargs.values()) ): return lazy_func(*args, **kwargs) return func(*args, **kwargs) [c9f3081a]
- If copies are made of the resulting SimpleLazyObject, which can happen in various circumstances within Django, then you must ensure that the callable can be safely run more than once and will return the same value. """ self.__dict__["_setupfunc"] = func super().__init__() [451f6c30]
- def __add__(self, other): return self.__cast() + other [5ab53d69]
- def __cast(self): return func(*self._args, **self._kw) [f51aa4be]
- def __deepcopy__(self, memo): # Instances of this class are effectively immutable. It's just a # collection of functions. So we don't need to do anything # complicated for copying. memo[id(self)] = self return self [3ec4d045]
- def __eq__(self, other): if isinstance(other, Promise): other = other.__cast() return self.__cast() == other [ceae74d0]
- def __format__(self, format_spec): return format(self.__cast(), format_spec) [e81fe0d8]
- def __ge__(self, other): if isinstance(other, Promise): other = other.__cast() return self.__cast() >= other [dcda073e]
- def __gt__(self, other): if isinstance(other, Promise): other = other.__cast() return self.__cast() > other [48121cf7]
- def __hash__(self): return hash(self.__cast()) [e43f0a6d]
- def __init__(self, args, kw): self._args = args self._kw = kw [268595bf]
- def __le__(self, other): if isinstance(other, Promise): other = other.__cast() return self.__cast() <= other [c19d2ecc]
- def __lt__(self, other): if isinstance(other, Promise): other = other.__cast() return self.__cast() < other [81ebbd7f]
- def __mod__(self, other): return self.__cast() % other [5f1b8b86]
- def __mul__(self, other): return self.__cast() * other [deaea66f]
- def __ne__(self, other): if isinstance(other, Promise): other = other.__cast() return self.__cast() != other [1efb28cc]
- def __radd__(self, other): return other + self.__cast() [d799c68c]
- return wrapper [656124d6f08b58d6-6]

## Beyond the budget

56 more facts did not fit in the budget: [fd72de6c] [812dc3e9] [2c197473] [4bf78232] [880ab074] [312179e9] [cee56491] [aaaa34fa] [2b21055f] [d3e937ef] [2a3cfcbf] [04e858a4] [ff640394] [56bd8119] [44e6cdf3] [046cedff] [26fd53a7] [47d9e570] [b01711b4] [1ef77acc] [f932cdd7] [10e50e42] [339e22aa] [692837e1] [cb0fdc4b] [736b4e55] [ea463202] [b06d7516] [d4ad95ae] [fc664078] [fac97fc8] [5cb5d6b1] [dd4dd5fa] [9f6ef6e3] [73d91e72] [7042f6ac] [0ebc79b9] [e4b86bc1] [7655780f0d17b825-55] [926a5715] [021b5df2d691cbd2-6] [f08d7c87] [40511bec] [dc41959a] [09c6a3b8] [a2f24652] [97309afc] [c3c272b7] [e9415fc8] [d51128d1] [26171939] [12c8c2b9] [2df47848] [327352c2] [ec36a740] [b82d6ee8]
