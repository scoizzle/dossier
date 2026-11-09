# django/contrib/messages/middleware

- Subject: django/contrib/messages/middleware (id `82521d10-e6fb-4a98-ad5e-adec99bac66c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 265 tokens
- Facts shown: 5 of 5
- Conflicts: 0
- Gaps: 0

## Facts

- Raise ValueError if not all messages could be stored and DEBUG is True. """ # A higher middleware layer may return a request which does not contain # messages storage, so make no assumption that it will be there. if hasattr(request, "_messages"): unstored_messages = request._messages.update(response) if unstored_messages and settings.DEBUG: raise ValueError("Not all temporary messages could be stored.") return response [2614e8f0]
- def process_request(self, request): request._messages = default_storage(request) [c4da780e]
- def process_response(self, request, response): """ Update the storage backend (i.e., save the messages). [3255e544]
- class MessageMiddleware(MiddlewareMixin): """ Middleware that handles temporary messages. """ [f8b485e4]
- from django.conf import settings from django.contrib.messages.storage import default_storage from django.utils.deprecation import MiddlewareMixin [5b065ea1]
