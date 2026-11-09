# Fact 0eb0c30b

Store id: e4976dcc-a02a-4c8c-a85c-24d866deacd0

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
- posted_at: `2026-11-09T22:39:45.1041030+00:00`

## Data

```json
{
  "end_line": 95,
  "entity_kind": "method",
  "parent": "RelatedIn",
  "start_line": 86,
  "symbol": "RelatedIn.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":86,"selector":"L86-L95","symbol":"RelatedIn.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_lookups::RelatedIn.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 95,
    "entity_kind": "method",
    "parent": "RelatedIn",
    "start_line": 86,
    "symbol": "RelatedIn.as_sql"
  },
  "id": "e4976dcc-a02a-4c8c-a85c-24d866deacd0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.1041030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 86,
        "selector": "L86-L95",
        "symbol": "RelatedIn.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "72e78b38-5fd5-4870-ab8c-26c91b31d74c",
  "subject_name": "django/db/models/fields/related_lookups::RelatedIn.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
