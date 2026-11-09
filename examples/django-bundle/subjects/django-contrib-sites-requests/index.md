# django/contrib/sites/requests

- Subject: django/contrib/sites/requests (id `86e5cbed-65b6-41e5-b031-a3bf1739887e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 204 tokens
- Facts shown: 6 of 6
- Conflicts: 0
- Gaps: 0

## Facts

- The save() and delete() methods raise NotImplementedError. """ [ee258bf1]
- def __init__(self, request): self.domain = self.name = request.get_host() [f25f6a97]
- def __str__(self): return self.domain [286dc73dcd691d5f-2]
- def delete(self): raise NotImplementedError("RequestSite cannot be deleted.") [2e0d4c01]
- def save(self, force_insert=False, force_update=False): raise NotImplementedError("RequestSite cannot be saved.") [54f8c691]
- class RequestSite: """ A class that shares the primary interface of Site (i.e., it has ``domain`` and ``name`` attributes) but gets its data from an HttpRequest object rather than from a database. [4755139c]
