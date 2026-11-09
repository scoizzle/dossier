# Fact 8a723004

Store id: a522e20e-7cc1-4dd9-9678-0298528d5462

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
- posted_at: `2026-11-09T22:39:46.1824700+00:00`

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
  "id": "a522e20e-7cc1-4dd9-9678-0298528d5462",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.1824700+00:00"
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
  "subject_id": "7fd533c4-b130-450b-973d-04eab428e6d0",
  "subject_name": "django/db/models/functions/datetime::TruncBase.convert_value",
  "tags": [
    "entity:method"
  ],
  "text": "def convert_value(self, value, expression, connection)"
}
```
