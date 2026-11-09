# Fact e5ac1547

Store id: 387a9d61-fe02-4f7c-8314-41a909ca30ae

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
- posted_at: `2026-11-09T22:39:46.2185290+00:00`

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
  "id": "387a9d61-fe02-4f7c-8314-41a909ca30ae",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.2185290+00:00"
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
  "subject_id": "1087e2f2-8f1d-455a-93a0-6dc7f542898a",
  "subject_name": "django/db/models/functions/datetime::TruncSecond",
  "tags": [
    "entity:class"
  ],
  "text": "class TruncSecond(TruncBase)"
}
```
