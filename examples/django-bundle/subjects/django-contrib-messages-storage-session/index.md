# django/contrib/messages/storage/session

- Subject: django/contrib/messages/storage/session (id `c1544fbf-4330-47eb-91d2-0c34ae71534c`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 453 tokens
- Facts shown: 9 facts
- Conflicts: 0
- Gaps: 0

## Facts

- def __init__(self, request, *args, **kwargs): if not hasattr(request, "session"): raise ImproperlyConfigured( "The session-based temporary message storage requires session " "middleware to be installed, and come before the message " "middleware in the MIDDLEWARE list." ) super().__init__(request, *args, **kwargs) [1961827c]
- def _get(self, *args, **kwargs): """ Retrieve a list of messages from the request's session. This storage always stores everything it is given, so return True for the all_retrieved flag. """ return ( self.deserialize_messages(self.request.session.get(self.session_key)), True, ) [cbf9e23e]
- def _store(self, messages, response, *args, **kwargs): """ Store a list of messages to the request's session. """ if messages: self.request.session[self.session_key] = self.serialize_messages(messages) else: self.request.session.pop(self.session_key, None) return [] [cf7aa0e8]
- def deserialize_messages(self, data): if data and isinstance(data, str): return json.loads(data, cls=MessageDecoder) return data [67f814b2]
- def serialize_messages(self, messages): encoder = MessageEncoder() return encoder.encode(messages) [afebcf83]
- session_key = "_messages" [2cfe6a60]
- class SessionStorage(BaseStorage): """ Store messages in the session (that is, django.contrib.sessions). """ [bbf8bf97]
- from django.contrib.messages.storage.base import BaseStorage from django.contrib.messages.storage.cookie import MessageDecoder, MessageEncoder from django.core.exceptions import ImproperlyConfigured [4cd2a49a]
- import json [5766bf5bad9de4d2-6]
