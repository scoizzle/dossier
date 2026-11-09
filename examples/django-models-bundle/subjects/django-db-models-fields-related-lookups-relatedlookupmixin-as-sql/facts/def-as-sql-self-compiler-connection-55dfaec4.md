# Fact 55dfaec4

Store id: 54584e0a-4588-44bb-9e97-a8bfbb63e7f0

## Text

```text
def as_sql(self, compiler, connection)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:59.9895740+00:00`

## Data

```json
{
  "end_line": 128,
  "entity_kind": "method",
  "parent": "RelatedLookupMixin",
  "start_line": 117,
  "symbol": "RelatedLookupMixin.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":117,"selector":"L117-L128","symbol":"RelatedLookupMixin.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_lookups::RelatedLookupMixin.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 128,
    "entity_kind": "method",
    "parent": "RelatedLookupMixin",
    "start_line": 117,
    "symbol": "RelatedLookupMixin.as_sql"
  },
  "id": "54584e0a-4588-44bb-9e97-a8bfbb63e7f0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.9895740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 117,
        "selector": "L117-L128",
        "symbol": "RelatedLookupMixin.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "e2d7c083-ca88-43fa-a317-1061eee06494",
  "subject_name": "django/db/models/fields/related_lookups::RelatedLookupMixin.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
