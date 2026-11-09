# django/contrib/messages/storage/base

- Subject: django/contrib/messages/storage/base (id `92634255-7439-4283-a95e-de059a3e685e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 894 tokens
- Facts shown: 17 of 34
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

17 more facts did not fit in the budget: [7e9de70c] [df753d03] [5e0a32e7] [3491638f] [7a3e8008] [e1ea7d2b] [3cea4511] [cd65932d] [49d25f66] [8a5d3204] [8ba8f1bd] [40d2f2f4] [081e0272] [01b73348] [467d0f29] [b473f106] [f0a8ce4d]
