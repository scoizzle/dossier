# django/db/models/fetch_modes

- Subject: django/db/models/fetch_modes (id `8bd87533-9a5d-49ee-84a4-62093ce5e680`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 441 tokens
- Facts shown: 17 facts
- Conflicts: 0
- Gaps: 0

## Facts

- def __reduce__(self): return "FETCH_ONE" [878a32ba]
- def __reduce__(self): return "FETCH_PEERS" [d5d5258c]
- def __reduce__(self): return "FETCH_RAISE" [67715918]
- def fetch(self, fetcher, instance): fetcher.fetch_one(instance) [ff169134]
- def fetch(self, fetcher, instance): instances = [ peer for peer_weakref in instance._state.peers if (peer := peer_weakref()) is not None ] if len(instances) > 1: fetcher.fetch_many(instances) else: fetcher.fetch_one(instance) [e2c8a41f]
- def fetch(self, fetcher, instance): klass = instance.__class__.__qualname__ field_name = fetcher.field.name raise FieldFetchBlocked(f"Fetching of {klass}.{field_name} blocked.") from None [15a975b1]
- def fetch(self, fetcher, instance): raise NotImplementedError("Subclasses must implement this method.") [d64c4c3f]
- track_peers = False [d5102273]
- track_peers = True [32711e4c]
- FETCH_ONE = FetchOne() [ecba3818]
- FETCH_PEERS = FetchPeers() [b9de02c5]
- FETCH_RAISE = FetchRaise() [d34ff9d9]
- class FetchMode: __slots__ = () [bfb47925]
- class FetchOne(FetchMode): __slots__ = () [d7230d59]
- class FetchPeers(FetchMode): __slots__ = () [e85f8182]
- class FetchRaise(FetchMode): __slots__ = () [f07775a3]
- from django.core.exceptions import FieldFetchBlocked [6f2b04fc]
