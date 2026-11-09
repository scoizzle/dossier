# Fact 8a723004

Store id: 21a92184-df6b-49f7-8c97-a41b547e1609

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
- posted_at: `2026-11-09T23:44:53.3878190+00:00`

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
  "id": "21a92184-df6b-49f7-8c97-a41b547e1609",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.3878190+00:00"
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
  "subject_id": "aad8ad9b-6131-47a3-8f6e-27839832b104",
  "subject_name": "django/db/models/functions/datetime::TruncBase.convert_value",
  "tags": [
    "entity:method"
  ],
  "text": "def convert_value(self, value, expression, connection)"
}
```
