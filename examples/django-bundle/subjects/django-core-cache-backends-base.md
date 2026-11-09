# django/core/cache/backends/base

- Subject: django/core/cache/backends/base (id `6cdddfad-b0f5-47be-841c-20016130b9e1`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 17 of 67
- Conflicts: 0
- Gaps: 0

## Facts

- If timeout is given, use that timeout for the key; otherwise use the default cache timeout. [d7fc2efb]
- On backends that support it, return a list of keys that failed insertion, or an empty list if all keys were inserted successfully. """ for key, value in data.items(): self.set(key, value, timeout=timeout, version=version) return [] [14c172ef]
- Return True if the value was stored, False otherwise. """ raise NotImplementedError( "subclasses of BaseCache must provide an add() method" ) [aa6d0147]
- Return a dict mapping each key in keys to its value. If the given key is missing, it will be missing from the response dict. """ d = {} for k in keys: val = self.get(k, self._missing_key, version=version) if val is not self._missing_key: d[k] = val return d [7106e35a]
- Return the value of the key stored or retrieved. """ val = self.get(key, self._missing_key, version=version) if val is self._missing_key: if callable(default): default = default() self.add(key, default, timeout=timeout, version=version) # Fetch the value again to avoid a race condition if another caller # added a value between the first get() and the add() above. return self.get(key, default, version=version) return val [20c74bc1]
- await self.aset(key, value, version=version + delta) await self.adelete(key, version=version) return version + delta [3eec6a98]
- cull_frequency = params.get("cull_frequency", options.get("CULL_FREQUENCY", 3)) try: self._cull_frequency = int(cull_frequency) except (ValueError, TypeError): self._cull_frequency = 3 [50c6e586]
- options = params.get("OPTIONS", {}) max_entries = params.get("max_entries", options.get("MAX_ENTRIES", 300)) try: self._max_entries = int(max_entries) except (ValueError, TypeError): self._max_entries = 300 [ac7ba986]
- return self.key_func(key, self.key_prefix, version) [a119f8ef]
- self.key_prefix = params.get("KEY_PREFIX", "") self.version = params.get("VERSION", 1) self.key_func = get_key_func(params.get("KEY_FUNCTION")) [ee4972f8]
- self.set(key, value, version=version + delta) self.delete(key, version=version) return version + delta [df21444f]
- value = await self.aget(key, self._missing_key, version=version) if value is self._missing_key: raise ValueError("Key '%s' not found" % key) [9c423c03]
- value = self.get(key, self._missing_key, version=version) if value is self._missing_key: raise ValueError("Key '%s' not found" % key) [733c648d]
- Construct the key used by all other methods. By default, prepend the `key_prefix`. KEY_FUNCTION can be used to specify an alternate function with custom key making behavior. """ return "%s:%s:%s" % (key_prefix, version, key) [728b5b0a]
- Default to ``default_key_func``. """ if key_func is not None: if callable(key_func): return key_func else: return import_string(key_func) return default_key_func [ff567797]
- async def aadd(self, key, value, timeout=DEFAULT_TIMEOUT, version=None): return await sync_to_async(self.add, thread_sensitive=True)( key, value, timeout, version ) [f924b766]
- async def aclear(self): return await sync_to_async(self.clear, thread_sensitive=True)() [6ed7ffaa]

## Beyond the budget

49 more facts did not fit in the budget: [1551d2ab] [7b8ccbdc] [118fc4f0] [05349bfd] [4f84d02c] [e4c96dc4] [d47cf720] [94b0a0a8] [aefbdf0b] [1fe8ee0f] [a538693b] [21859a87] [f126c8f3] [45b4f00c] [96fdef8c] [6b4abe0a] [c60b587d] [53a840af] [a4380efb] [b49663f8] [d874332c] [9cf9df7a] [e7a86584] [bec2076e] [db28139b] [dc0848fb] [f84613d8] [35afd210] [08bf6425] [fe077274] [867d4220] [893cfe16] [2619c7b5] [ceec9a8f] [c80df34b] [22631de0] [70ecae0c] [0c20bdb5] [b247c078] [7095757b] [9248dd68] [ed977118] [a8b9f5fe] [ee79d0cc] [e55d9508] [770890ad88958a4c-8] [1125e2a4] [62c426f1] [106367d9]
