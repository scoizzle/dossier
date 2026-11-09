# Fact 8a723004

Store id: 403031e8-f5c4-42b8-aa93-56824b59ea1e

## Text

```text
def convert_value(self, value, expression, connection)
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
- posted_at: `2026-11-09T23:32:01.2634770+00:00`

## Data

```json
{
  "end_line": 345,
  "entity_kind": "method",
  "parent": "TruncBase",
  "start_line": 344,
  "symbol": "TruncBase.convert_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":344,"selector":"L344-L345","symbol":"TruncBase.convert_value"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::TruncBase.convert_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 345,
    "entity_kind": "method",
    "parent": "TruncBase",
    "start_line": 344,
    "symbol": "TruncBase.convert_value"
  },
  "id": "403031e8-f5c4-42b8-aa93-56824b59ea1e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.2634770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 344,
        "selector": "L344-L345",
        "symbol": "TruncBase.convert_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "e38a36c6-981f-4d6b-94ba-280d02b052fd",
  "subject_name": "django/db/models/functions/datetime::TruncBase.convert_value",
  "tags": [
    "entity:method"
  ],
  "text": "def convert_value(self, value, expression, connection)"
}
```
