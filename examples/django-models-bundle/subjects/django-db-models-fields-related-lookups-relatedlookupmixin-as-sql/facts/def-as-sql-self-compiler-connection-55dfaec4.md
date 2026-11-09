# Fact 55dfaec4

Store id: 9c5db369-3ae7-4bc7-b9f4-1580643e3a47

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
- posted_at: `2026-11-09T23:44:52.2560660+00:00`

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
  "id": "9c5db369-3ae7-4bc7-b9f4-1580643e3a47",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.2560660+00:00"
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
  "subject_id": "cc4c23b1-09fd-45b6-a4ac-a7f9814fc11c",
  "subject_name": "django/db/models/fields/related_lookups::RelatedLookupMixin.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
