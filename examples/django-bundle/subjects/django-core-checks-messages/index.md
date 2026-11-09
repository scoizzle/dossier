# django/core/checks/messages

- Subject: django/core/checks/messages (id `7f12730b-51cc-4a02-8f33-e4ae0c162553`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 601 tokens
- Facts shown: 14 facts
- Conflicts: 0
- Gaps: 0

## Facts

- if self.obj is None: obj = "?" elif isinstance(self.obj, models.base.ModelBase): # We need to hardcode ModelBase and Field cases because its __str__ # method doesn't return "applabel.modellabel" and cannot be # changed. obj = self.obj._meta.label else: obj = str(self.obj) id = "(%s) " % self.id if self.id else "" hint = "\n\tHINT: %s" % self.hint if self.hint else "" return "%s: %s%s%s" % (obj, id, self.msg, hint) [a20da0a3]
- return self.id in settings.SILENCED_SYSTEM_CHECKS [98745318]
- def __eq__(self, other): return isinstance(other, self.__class__) and all( getattr(self, attr) == getattr(other, attr) for attr in ["level", "msg", "hint", "obj", "id"] ) [8aec0e49]
- def __repr__(self): return "<%s: level=%r, msg=%r, hint=%r, obj=%r, id=%r>" % ( self.__class__.__name__, self.level, self.msg, self.hint, self.obj, self.id, ) [9e7fd9c9]
- def __str__(self): from django.db import models [8ddbe148]
- def is_serious(self, level=ERROR): return self.level >= level [d1bffdf9]
- def is_silenced(self): from django.conf import settings [a207aec2]
- # Levels DEBUG = 10 INFO = 20 WARNING = 30 ERROR = 40 CRITICAL = 50 [94b6ded9]
- class CheckMessage: def __init__(self, level, msg, hint=None, obj=None, id=None): if not isinstance(level, int): raise TypeError("The first argument should be level.") self.level = level self.msg = msg self.hint = hint self.obj = obj self.id = id [2563ad31]
- class Critical(CheckMessage): def __init__(self, *args, **kwargs): super().__init__(CRITICAL, *args, **kwargs) [2d0b2c13]
- class Debug(CheckMessage): def __init__(self, *args, **kwargs): super().__init__(DEBUG, *args, **kwargs) [28eeee3c]
- class Error(CheckMessage): def __init__(self, *args, **kwargs): super().__init__(ERROR, *args, **kwargs) [445bfa19]
- class Info(CheckMessage): def __init__(self, *args, **kwargs): super().__init__(INFO, *args, **kwargs) [0f8d7727]
- class Warning(CheckMessage): def __init__(self, *args, **kwargs): super().__init__(WARNING, *args, **kwargs) [cb09d013]
