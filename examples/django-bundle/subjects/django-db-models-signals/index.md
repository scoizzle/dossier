# django/db/models/signals

- Subject: django/db/models/signals (id `4c0e9f0f-617a-4506-a268-16d2d77542e7`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 483 tokens
- Facts shown: 13 of 13
- Conflicts: 0
- Gaps: 0

## Facts

- # This partial takes a single optional argument named "sender". partial_method = partial(method, receiver, **kwargs) if isinstance(sender, str): apps = apps or Options.default_apps apps.lazy_model_operation(partial_method, make_model_tuple(sender)) else: return partial_method(sender) [b348d1e6]
- def _lazy_method(self, method, apps, receiver, sender, **kwargs): from django.db.models.options import Options [b833ba7c]
- def connect(self, receiver, sender=None, weak=True, dispatch_uid=None, apps=None): self._lazy_method( super().connect, apps, receiver, sender, weak=weak, dispatch_uid=dispatch_uid, ) [a243864e]
- def disconnect(self, receiver=None, sender=None, dispatch_uid=None, apps=None): return self._lazy_method( super().disconnect, apps, receiver, sender, dispatch_uid=dispatch_uid ) [2c7ef8ac]
- class ModelSignal(Signal): """ Signal subclass that allows the sender to be lazily specified as a string of the `app_label.ModelName` form. """ [ac3e27b2]
- class_prepared = Signal() [0b691e00]
- from django.db.models.utils import make_model_tuple from django.dispatch import Signal [f8760b63]
- from functools import partial [200ae996befcd23a-2]
- m2m_changed = ModelSignal(use_caching=True) [84756468]
- pre_delete = ModelSignal(use_caching=True) post_delete = ModelSignal(use_caching=True) [f00aae87]
- pre_init = ModelSignal(use_caching=True) post_init = ModelSignal(use_caching=True) [b98ca52b]
- pre_migrate = Signal() post_migrate = Signal() [45dfb19e]
- pre_save = ModelSignal(use_caching=True) post_save = ModelSignal(use_caching=True) [c783bb98]
