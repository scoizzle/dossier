# django/contrib/sessions/backends/db

- Subject: django/contrib/sessions/backends/db (id `35247673-06b1-462f-87a1-89b39d0c1030`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 15 of 25
- Conflicts: 0
- Gaps: 0

## Facts

- await sync_transaction() except IntegrityError: if must_create: raise CreateError raise except DatabaseError: if not must_create: raise UpdateError raise [da288410]
- return Session [a8c6c797]
- @cached_property def model(self): return self.get_model_class() [76365821]
- @classmethod async def aclear_expired(cls): await cls.get_model_class().objects.filter( expire_date__lt=timezone.now() ).adelete() [7cc8fdfd]
- @classmethod def clear_expired(cls): cls.get_model_class().objects.filter(expire_date__lt=timezone.now()).delete() [9c59d085]
- @classmethod def get_model_class(cls): # Avoids a circular import and allows importing SessionStore when # django.contrib.sessions is not in INSTALLED_APPS. from django.contrib.sessions.models import Session [4efcc8d2]
- async def _aget_session_from_db(self): try: return await self.model.objects.aget( session_key=self.session_key, expire_date__gt=timezone.now() ) except (self.model.DoesNotExist, SuspiciousOperation) as e: if isinstance(e, SuspiciousOperation): logger = logging.getLogger("django.security.%s" % e.__class__.__name__) logger.warning(str(e)) self._session_key = None [b1963383]
- async def acreate(self): while True: self._session_key = await self._aget_new_session_key() try: # Save immediately to ensure we have a unique entry in the # database. await self.asave(must_create=True) except CreateError: # Key wasn't unique. Try again. continue self.modified = True return [8267120b]
- async def acreate_model_instance(self, data): """See create_model_instance().""" return self.model( session_key=await self._aget_or_create_session_key(), session_data=self.encode(data), expire_date=await self.aget_expiry_date(), ) [9bf92805]
- async def adelete(self, session_key=None): if session_key is None: if self.session_key is None: return session_key = self.session_key try: obj = await self.model.objects.aget(session_key=session_key) await obj.adelete() except self.model.DoesNotExist: pass [80ffbdbd]
- async def aexists(self, session_key): return await self.model.objects.filter(session_key=session_key).aexists() [25c18d5a]
- async def aload(self): s = await self._aget_session_from_db() return self.decode(s.session_data) if s else {} [585c4254]
- async def asave(self, must_create=False): """See save().""" if self.session_key is None: return await self.acreate() data = await self._aget_session(no_load=must_create) obj = await self.acreate_model_instance(data) using = router.db_for_write(self.model, instance=obj) try: # This code MUST run in a transaction, so it requires # @sync_to_async wrapping until transaction.atomic() supports # async. @sync_to_async def sync_transaction(): with transaction.atomic(using=using): obj.save( force_insert=must_create, force_update=not must_create, using=using, ) [0ceb347a]
- def __init__(self, session_key=None): super().__init__(session_key) [680783a9]
- def create(self): while True: self._session_key = self._get_new_session_key() try: # Save immediately to ensure we have a unique entry in the # database. self.save(must_create=True) except CreateError: # Key wasn't unique. Try again. continue self.modified = True return [607d2ac7]

## Beyond the budget

9 more facts did not fit in the budget: [ce8d5d30] [83b9ecc1] [8b9dc5b8] [32e9ffd0] [eb3385c0] [4894ad97] [770890ad88958a4c-6] [25d79940] [47bc951ed6a0e3cc-4]
