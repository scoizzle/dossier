# django/contrib/messages/test

- Subject: django/contrib/messages/test (id `1c8da2a4-cdd5-4638-b6a6-fbbf81424edd`)
- Kind: subject
- Budget: 1200 tokens
- Used: 130 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- # Make unittest ignore frames in this module when reporting failures. __unittest = True [a66b34ca8afbcd43-2]
- class MessagesTestMixin: def assertMessages(self, response, expected_messages, *, ordered=True): request_messages = list(get_messages(response.wsgi_request)) assertion = self.assertEqual if ordered else self.assertCountEqual assertion(request_messages, expected_messages) [6fe55f9e]
- from .api import get_messages [70b21a2f]
