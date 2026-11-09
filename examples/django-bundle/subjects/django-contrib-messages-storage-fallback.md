# django/contrib/messages/storage/fallback

- Subject: django/contrib/messages/storage/fallback (id `d354131c-c012-47be-8b97-41262513a38f`)
- Kind: subject
- Budget: 1200 tokens
- Used: 490 tokens
- Facts shown: 7 of 7
- Conflicts: 0
- Gaps: 0

## Facts

- For each storage backend, any messages not stored are passed on to the next backend. """ for storage in self.storages: if messages: messages = storage._store(messages, response, remove_oldest=False) # Even if there are no more messages, continue iterating to ensure # storages which contained messages are flushed. elif storage in self._used_storages: storage._store([], response) self._used_storages.remove(storage) return messages [7b1598fb]
- def __init__(self, *args, **kwargs): super().__init__(*args, **kwargs) self.storages = [ storage_class(*args, **kwargs) for storage_class in self.storage_classes ] self._used_storages = set() [390f5350]
- def _get(self, *args, **kwargs): """ Get a single list of messages from all storage backends. """ all_messages = [] for storage in self.storages: messages, all_retrieved = storage._get() # If the backend hasn't been used, no more retrieval is necessary. if messages is None: break if messages: self._used_storages.add(storage) all_messages.extend(messages) # If this storage class contained all the messages, no further # retrieval is necessary if all_retrieved: break return all_messages, all_retrieved [97a4f18e]
- def _store(self, messages, response, *args, **kwargs): """ Store the messages and return any unstored messages after trying all backends. [28683d41]
- storage_classes = (CookieStorage, SessionStorage) [48097f38]
- class FallbackStorage(BaseStorage): """ Try to store all messages in the first backend. Store any unstored messages in each subsequent backend. """ [7eef7f1a]
- from django.contrib.messages.storage.base import BaseStorage from django.contrib.messages.storage.cookie import CookieStorage from django.contrib.messages.storage.session import SessionStorage [78556fd9]
