# django/contrib/sessions/base_session

- Subject: django/contrib/sessions/base_session (id `274ccd91-877e-48ea-893f-948fef2ddcf2`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 426 tokens
- Facts shown: 10 of 10
- Conflicts: 0
- Gaps: 0

## Facts

- @classmethod def get_session_store_class(cls): raise NotImplementedError [00c73b4a]
- class Meta: abstract = True verbose_name = _("session") verbose_name_plural = _("sessions") [765dcf55]
- def __str__(self): return self.session_key [431ab25c]
- def get_decoded(self): session_store_class = self.get_session_store_class() return session_store_class().decode(self.session_data) [19c43935]
- def save(self, session_key, session_dict, expire_date): s = self.model(session_key, self.encode(session_dict), expire_date) if session_dict: s.save() else: s.delete() # Clear sessions with no data. return s [1dd1887c]
- objects = BaseSessionManager() [1936771c]
- """ This module allows importing AbstractBaseSession even when django.contrib.sessions is not in INSTALLED_APPS. """ [58750aef]
- class AbstractBaseSession(models.Model): session_key = models.CharField(_("session key"), max_length=40, primary_key=True) session_data = models.TextField(_("session data")) expire_date = models.DateTimeField(_("expire date"), db_index=True) [cf84882a]
- class BaseSessionManager(models.Manager): def encode(self, session_dict): """ Return the given session dictionary serialized and encoded as a string. """ session_store_class = self.model.get_session_store_class() return session_store_class().encode(session_dict) [ddee97a6]
- from django.db import models from django.utils.translation import gettext_lazy as _ [805036e7]
