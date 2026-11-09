# django/db/models/fields/proxy

- Subject: django/db/models/fields/proxy (id `e70c0d04-ebab-47c6-8c35-707db6f8de34`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 160 tokens
- Facts shown: 4 facts
- Conflicts: 0
- Gaps: 0

## Facts

- def __init__(self, *args, **kwargs): kwargs["name"] = "_order" kwargs["editable"] = False super().__init__(*args, **kwargs) [7fc28670]
- """ Field-like classes that aren't really fields. It's easier to use objects that have the same attributes as fields sometimes (avoids a lot of special casing). """ [809ddb26]
- class OrderWrt(fields.IntegerField): """ A proxy for the _order database field that is used when Meta.order_with_respect_to is specified. """ [344b11ff]
- from django.db.models import fields [1e570368]
