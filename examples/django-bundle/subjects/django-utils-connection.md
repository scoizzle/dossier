# django/utils/connection

- Subject: django/utils/connection (id `c587ad95-8862-4a5c-b7f4-b7c989773e5c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 757 tokens
- Facts shown: 21 of 21
- Conflicts: 0
- Gaps: 0

## Facts

- @cached_property def settings(self): self._settings = self.configure_settings(self._settings) return self._settings [a83925cf]
- def __contains__(self, key): return key in self._connections[self._alias] [518a0df7]
- def __delattr__(self, name): return delattr(self._connections[self._alias], name) [ebe770b1]
- def __delitem__(self, key): delattr(self._connections, key) [66884fa9]
- def __eq__(self, other): return self._connections[self._alias] == other [3b86284a]
- def __getattr__(self, item): return getattr(self._connections[self._alias], item) [5041fde6]
- def __getitem__(self, alias): try: return getattr(self._connections, alias) except AttributeError: if alias not in self.settings: raise self.exception_class(f"The connection '{alias}' doesn't exist.") conn = self.create_connection(alias) setattr(self._connections, alias, conn) return conn [a31b65b6]
- def __init__(self, connections, alias): self.__dict__["_connections"] = connections self.__dict__["_alias"] = alias [9a69c6ca]
- def __init__(self, settings=None): self._settings = settings self._connections = Local(self.thread_critical) [2d07e475]
- def __iter__(self): return iter(self.settings) [c4d417f15a0d4f27-2]
- def __setattr__(self, name, value): return setattr(self._connections[self._alias], name, value) [031292f6]
- def __setitem__(self, key, value): setattr(self._connections, key, value) [f007d658]
- def all(self, initialized_only=False): return [ self[alias] for alias in self # If initialized_only is True, return only initialized connections. if not initialized_only or hasattr(self._connections, alias) ] [5d04db03]
- def close_all(self): for conn in self.all(initialized_only=True): conn.close() [36dd0442]
- def configure_settings(self, settings): if settings is None: settings = getattr(django_settings, self.settings_name) return settings [34b60606]
- def create_connection(self, alias): raise NotImplementedError("Subclasses must implement create_connection().") [fb914a29]
- class BaseConnectionHandler: settings_name = None exception_class = ConnectionDoesNotExist thread_critical = False [502117f4]
- class ConnectionDoesNotExist(Exception): pass [78d0aeb1]
- class ConnectionProxy: """Proxy for accessing a connection object's attributes.""" [ce796828]
- from asgiref.local import Local [6beab4e4549a99b7-5]
- from django.conf import settings as django_settings from django.utils.functional import cached_property [64eb787f]
