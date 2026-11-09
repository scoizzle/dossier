# Fact e5ac1547

Store id: 34db2f49-6482-41f6-8ec5-72fe4f0a52d0

## Text

```text
class TruncSecond(TruncBase)
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
- posted_at: `2026-11-09T23:44:53.4182170+00:00`

## Data

```json
{
  "end_line": 416,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 415,
  "symbol": "TruncSecond"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":415,"selector":"L415-L416","symbol":"TruncSecond"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::TruncSecond](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 416,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 415,
    "symbol": "TruncSecond"
  },
  "id": "34db2f49-6482-41f6-8ec5-72fe4f0a52d0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.4182170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 415,
        "selector": "L415-L416",
        "symbol": "TruncSecond"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "4ce3f8a5-53f8-4336-bd94-cd2a86ca5be8",
  "subject_name": "django/db/models/functions/datetime::TruncSecond",
  "tags": [
    "entity:class"
  ],
  "text": "class TruncSecond(TruncBase)"
}
```
