# Fact 03074e7a

Store id: e423ed87-f6f7-4bcb-8b00-42c3f7bcecca

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
- posted_at: `2026-11-09T22:39:46.2025600+00:00`

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
  "id": "e423ed87-f6f7-4bcb-8b00-42c3f7bcecca",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.2025600+00:00"
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
  "subject_id": "df16cc89-1a00-46b7-9693-3317e10b8171",
  "subject_name": "django/db/models/functions/datetime::TruncDate",
  "tags": [
    "entity:class"
  ],
  "text": "class TruncDate(TruncBase)"
}
```
