# Fact 03074e7a

Store id: 7b843cc5-d874-4c37-8531-2411f85afb1c

## Text

```text
class TruncDate(TruncBase)
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
- posted_at: `2026-11-09T23:44:53.4047060+00:00`

## Data

```json
{
  "end_line": 392,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 383,
  "symbol": "TruncDate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":383,"selector":"L383-L392","symbol":"TruncDate"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::TruncDate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 392,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 383,
    "symbol": "TruncDate"
  },
  "id": "7b843cc5-d874-4c37-8531-2411f85afb1c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.4047060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 383,
        "selector": "L383-L392",
        "symbol": "TruncDate"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "458260f4-9339-41fc-8b38-944291cec169",
  "subject_name": "django/db/models/functions/datetime::TruncDate",
  "tags": [
    "entity:class"
  ],
  "text": "class TruncDate(TruncBase)"
}
```
