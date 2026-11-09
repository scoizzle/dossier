# django/contrib/postgres/serializers

- Subject: django/contrib/postgres/serializers (id `ed97676e-750a-4edf-bc70-d6ab3c839018`)
- Kind: subject
- Budget: 1200 tokens
- Used: 118 tokens
- Facts shown: 2 of 2
- Conflicts: 0
- Gaps: 0

## Facts

- class RangeSerializer(BaseSerializer): def serialize(self): module = self.value.__class__.__module__ # Ranges are implemented in psycopg2._range but the public import # location is psycopg2.extras. module = "psycopg2.extras" if module == "psycopg2._range" else module return "%s.%r" % (module, self.value), {"import %s" % module} [801b7ab3]
- from django.db.migrations.serializer import BaseSerializer [7309e684]
