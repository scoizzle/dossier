# Fact d352ba21

Store id: c41e8334-fd10-456a-b9fc-7ff82cbcf0f3

## Text

```text
class ExtractDay(Extract)
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
- posted_at: `2026-11-09T23:32:01.2059620+00:00`

## Data

```json
{
  "end_line": 139,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 138,
  "symbol": "ExtractDay"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":138,"selector":"L138-L139","symbol":"ExtractDay"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::ExtractDay](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 139,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 138,
    "symbol": "ExtractDay"
  },
  "id": "c41e8334-fd10-456a-b9fc-7ff82cbcf0f3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.2059620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 138,
        "selector": "L138-L139",
        "symbol": "ExtractDay"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "f8b1d35e-8ae5-482b-a6be-79658003b736",
  "subject_name": "django/db/models/functions/datetime::ExtractDay",
  "tags": [
    "entity:class"
  ],
  "text": "class ExtractDay(Extract)"
}
```
