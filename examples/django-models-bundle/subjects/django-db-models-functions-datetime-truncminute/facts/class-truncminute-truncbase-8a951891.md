# Fact 8a951891

Store id: e5cfaf5b-f23c-476d-83c8-44e7eee42810

## Text

```text
class TruncMinute(TruncBase)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:01.3028140+00:00`

## Data

```json
{
  "end_line": 412,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 411,
  "symbol": "TruncMinute"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":411,"selector":"L411-L412","symbol":"TruncMinute"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::TruncMinute](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 412,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 411,
    "symbol": "TruncMinute"
  },
  "id": "e5cfaf5b-f23c-476d-83c8-44e7eee42810",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.3028140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 411,
        "selector": "L411-L412",
        "symbol": "TruncMinute"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "1ee4f9c0-3fdc-41e9-a62c-cff2f1e06e7c",
  "subject_name": "django/db/models/functions/datetime::TruncMinute",
  "tags": [
    "entity:class"
  ],
  "text": "class TruncMinute(TruncBase)"
}
```
