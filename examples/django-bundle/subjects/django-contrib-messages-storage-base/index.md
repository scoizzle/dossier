# django/contrib/messages/storage/base

- Subject: django/contrib/messages/storage/base (id `1d6ff17c-899f-4581-9fd0-af956043b83e`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1606 tokens
- Facts shown: 34 of 34
- Conflicts: 0
- Gaps: 0

## Highlights

- **This method must be implemented by a subclass.** [b76f10f5]
- **This method must be implemented by a subclass.** """ raise NotImplementedError( "subclasses of BaseStorage must provide a _store() method" ) [61f71eba]
- If it is possible to tell if the backend was not used (as opposed to just containing no messages) then ``None`` should be returned in place of ``messages``. """ raise NotImplementedError( "subclasses of BaseStorage must provide a _get() method" ) [de954239]
- If set to ``None``, the default level will be used (see the ``_get_level`` method). """ if value is None and hasattr(self, "_level"): del self._level else: self._level = int(value) [66299de1]
- If the backend has yet to be iterated, store previously stored messages again. Otherwise, only store messages added after the last iteration. """ self._prepare_messages(self._queued_messages) if self.used: return self._store(self._queued_messages, response) elif self.added_new: messages = self._loaded_messages + self._queued_messages return self._store(messages, response) [44be241b]
- One type of object must be able to be stored, ``Message``. [5e8fe71b]
- The default level is the ``MESSAGE_LEVEL`` setting. If this is not found, the ``INFO`` level is used. """ if not hasattr(self, "_level"): self._level = getattr(settings, "MESSAGE_LEVEL", constants.INFO) return self._level [e8fd498c]
- The message is only queued if it contained something and its level is not less than the recording level (``self.level``). """ if not message: return # Check that the message level is not less than the recording level. level = int(level) if level < self.level: return # Add the message. self.added_new = True message = Message(level, message, extra_tags=extra_tags) self._queued_messages.append(message) [78d11daf]
- @property def _loaded_messages(self): """ Return a list of loaded messages, retrieving them first if they have not been loaded yet. """ if not hasattr(self, "_loaded_data"): messages, all_retrieved = self._get() self._loaded_data = messages or [] return self._loaded_data [c6f5ac68]
- @property def level_tag(self): return LEVEL_TAGS.get(self.level, "") [a3228fff]
- @property def tags(self): return " ".join(tag for tag in [self.extra_tags, self.level_tag] if tag) [87fb45be]
- This is not a complete class; to be a usable storage backend, it must be subclassed and the two methods ``_get`` and ``_store`` overridden. """ [95ab15b0]
- def __contains__(self, item): return item in self._loaded_messages or item in self._queued_messages [2c5b91e2]
- def __eq__(self, other): if not isinstance(other, Message): return NotImplemented return self.level == other.level and self.message == other.message [7c6aea2e]
- def __init__(self, level, message, extra_tags=None): self.level = int(level) self.message = message self.extra_tags = extra_tags [a1dcded2]
- def __init__(self, request, *args, **kwargs): self.request = request self._queued_messages = [] self.used = False self.added_new = False super().__init__(*args, **kwargs) [ab28c51e]
- def __str__(self): return str(self.message) [287ba134]

## All facts

- [7e9de70c] def __iter__(self): self.used = True if self._queued_messages: self._loaded_messages.extend(self._queued_messages) self._queued_messages = [] return iter(self._loaded_messages)
- [df753d03] def __len__(self): return len(self._loaded_messages) + len(self._queued_messages)
- [5e0a32e7] def __repr__(self): extra_tags = f", extra_tags={self.extra_tags!r}" if self.extra_tags else "" return f"Message(level={self.level}, message={self.message!r}{extra_tags})"
- [3491638f] def __repr__(self): return f"<{self.__class__.__qualname__}: request={self.request!r}>"
- [7a3e8008] def _get(self, *args, **kwargs): """ Retrieve a list of stored messages. Return a tuple of the messages and a flag indicating whether or not all the messages originally intended to be stored in this storage were, in fact, stored and retrieved; e.g., ``(messages, all_retrieved)``.
- [e1ea7d2b] def _get_level(self): """ Return the minimum recorded level.
- [3cea4511] def _prepare(self): """ Prepare the message for serialization by forcing the ``message`` and ``extra_tags`` to str in case they are lazy translations. """ self.message = str(self.message) self.extra_tags = str(self.extra_tags) if self.extra_tags is not None else None
- [cd65932d] def _prepare_messages(self, messages): """ Prepare a list of messages for storage. """ for message in messages: message._prepare()
- [49d25f66] def _set_level(self, value=None): """ Set a custom minimum recorded level.
- [8a5d3204] def _store(self, messages, response, *args, **kwargs): """ Store a list of messages and return a list of any messages which could not be stored.
- [8ba8f1bd] def add(self, level, message, extra_tags=""): """ Queue a message to be stored.
- [40d2f2f4] def update(self, response): """ Store all unread messages.
- [081e0272] level = property(_get_level, _set_level, _set_level)
- [01b73348] LEVEL_TAGS = SimpleLazyObject(utils.get_level_tags)
- [467d0f29] class BaseStorage: """ This is the base backend for temporary message storage.
- [b473f106] class Message: """ Represent an actual message that can be stored in any of the supported storage classes (typically session- or cookie-based) and rendered in a view or template. """
- [f0a8ce4d] from django.conf import settings from django.contrib.messages import constants, utils from django.utils.functional import SimpleLazyObject
