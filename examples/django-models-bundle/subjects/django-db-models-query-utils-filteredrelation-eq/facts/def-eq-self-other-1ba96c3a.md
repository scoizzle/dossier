# Fact 1ba96c3a

Store id: 9e74a8a4-4983-4e1a-bd70-ea3717468d4c

## Text

```text
def __eq__(self, other)
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
- posted_at: `2026-11-09T23:32:05.2073390+00:00`

## Data

```json
{
  "end_line": 543,
  "entity_kind": "method",
  "parent": "FilteredRelation",
  "start_line": 536,
  "symbol": "FilteredRelation.__eq__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":536,"selector":"L536-L543","symbol":"FilteredRelation.__eq__"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::FilteredRelation.__eq__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 543,
    "entity_kind": "method",
    "parent": "FilteredRelation",
    "start_line": 536,
    "symbol": "FilteredRelation.__eq__"
  },
  "id": "9e74a8a4-4983-4e1a-bd70-ea3717468d4c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.2073390+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 536,
        "selector": "L536-L543",
        "symbol": "FilteredRelation.__eq__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "deb6ace5-4fe4-45e8-aa03-e890323b590d",
  "subject_name": "django/db/models/query_utils::FilteredRelation.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```
