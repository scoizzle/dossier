# django/contrib/messages/api

- Subject: django/contrib/messages/api (id `eaeadb26-91fa-4362-ac14-31b270c30281`)
- Kind: subject
- Budget: 1200 tokens
- Used: 559 tokens
- Facts shown: 10 of 14
- Conflicts: 0
- Gaps: 0

## Facts

- If set to ``None``, use the default level (see the get_level() function). """ if not hasattr(request, "_messages"): return False request._messages.level = level return True [c040bad8]
- The default level is the ``MESSAGE_LEVEL`` setting. If this is not found, use the ``INFO`` level. """ storage = getattr(request, "_messages", default_storage(request)) return storage.level [27eae7db]
- __all__ = ( "add_message", "get_messages", "get_level", "set_level", "debug", "info", "success", "warning", "error", "MessageFailure", ) [28025ca5]
- class MessageFailure(Exception): pass [4d873ac7]
- def add_message(request, level, message, extra_tags="", fail_silently=False): """ Attempt to add a message to the request using the 'messages' app. """ try: messages = request._messages except AttributeError: if not hasattr(request, "META"): raise TypeError( "add_message() argument must be an HttpRequest object, not " "'%s'." % request.__class__.__name__ ) if not fail_silently: raise MessageFailure( "You cannot add messages without installing " "django.contrib.messages.middleware.MessageMiddleware" ) else: return messages.add(level, message, extra_tags) [9ac1e56c]
- def debug(request, message, extra_tags="", fail_silently=False): """Add a message with the ``DEBUG`` level.""" add_message( request, constants.DEBUG, message, extra_tags=extra_tags, fail_silently=fail_silently, ) [8317de6c]
- def get_level(request): """ Return the minimum level of messages to be recorded. [34d521d0]
- def get_messages(request): """ Return the message storage on the request if it exists, otherwise return an empty list. """ return getattr(request, "_messages", []) [b6c76eee]
- def set_level(request, level): """ Set the minimum level of messages to be recorded, and return ``True`` if the level was recorded successfully. [5b5f344c]
- from django.contrib.messages import constants from django.contrib.messages.storage import default_storage [f2c1463b]
