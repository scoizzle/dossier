# django/contrib/postgres/functions

- Subject: django/contrib/postgres/functions (id `a2e4d8ad-d7c4-4a72-9873-f6d9fb0175dc`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 90 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- class RandomUUID(Func): template = "GEN_RANDOM_UUID()" output_field = UUIDField() [1b000508]
- class TransactionNow(Func): template = "CURRENT_TIMESTAMP" output_field = DateTimeField() [5b9c6db6]
- from django.db.models import DateTimeField, Func, UUIDField [c5419e1a]
