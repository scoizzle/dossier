# Fact ea52a3d6

Store id: 8d9b8a40-3027-4c95-9aa8-e75307c6855e

## Text

```text
def deconstruct(self)
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
- posted_at: `2026-11-09T23:44:54.6854110+00:00`

## Data

```json
{
  "end_line": 243,
  "entity_kind": "method",
  "parent": "Index",
  "start_line": 229,
  "symbol": "Index.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/indexes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":229,"selector":"L229-L243","symbol":"Index.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/indexes::Index.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 243,
    "entity_kind": "method",
    "parent": "Index",
    "start_line": 229,
    "symbol": "Index.deconstruct"
  },
  "id": "8d9b8a40-3027-4c95-9aa8-e75307c6855e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.6854110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 229,
        "selector": "L229-L243",
        "symbol": "Index.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/indexes.py"
    }
  ],
  "status": "live",
  "subject_id": "0a74083c-7c32-4eda-bba3-97267128ca58",
  "subject_name": "django/db/models/indexes::Index.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
