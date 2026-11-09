# django/contrib/auth/context_processors

- Subject: django/contrib/auth/context_processors (id `0633d82e-fd81-46b1-b575-cfacc341c3a5`)
- Kind: subject
- Budget: 1200 tokens
- Used: 559 tokens
- Facts shown: 15 of 15
- Conflicts: 0
- Gaps: 0

## Facts

- user = AnonymousUser() [69db2069]
- If there is no 'user' attribute in the request, use AnonymousUser (from django.contrib.auth). """ if hasattr(request, "user"): user = request.user else: from django.contrib.auth.models import AnonymousUser [56017f52]
- def __bool__(self): return self.user.has_module_perms(self.app_label) [e2a4cdb0]
- def __contains__(self, perm_name): """ Lookup by "someapp" or "someapp.someperm" in perms. """ if "." not in perm_name: # The name refers to module. return bool(self[perm_name]) app_label, perm_name = perm_name.split(".", 1) return self[app_label][perm_name] [5fc7f1f6]
- def __getitem__(self, app_label): return PermLookupDict(self.user, app_label) [02c7aec4]
- def __getitem__(self, perm_name): return self.user.has_perm("%s.%s" % (self.app_label, perm_name)) [8b6886bb]
- def __iter__(self): # I am large, I contain multitudes. raise TypeError("PermWrapper is not iterable.") [cd36df34]
- def __iter__(self): # To fix 'item in perms.someapp' and __getitem__ interaction we need to # define __iter__. See #18979 for details. raise TypeError("PermLookupDict is not iterable.") [2bdcaa2b]
- def __repr__(self): return f"{self.__class__.__qualname__}({self.user!r})" [6dceeab9]
- def __repr__(self): return str(self.user.get_all_permissions()) [73e8721b]
- return { "user": user, "perms": PermWrapper(user), } [203179e2]
- # PermWrapper and PermLookupDict proxy the permissions system into objects that # the template system can understand. [14a71363]
- class PermLookupDict: def __init__(self, user, app_label): self.user, self.app_label = user, app_label [4ebe2a2f]
- class PermWrapper: def __init__(self, user): self.user = user [ae733b17]
- def auth(request): """ Return context variables required by apps that use Django's authentication system. [9a378c4d]
