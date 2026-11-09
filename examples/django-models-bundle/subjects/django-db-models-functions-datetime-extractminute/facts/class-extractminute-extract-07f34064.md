# Fact 07f34064

Store id: ac952138-2005-4ea0-9386-ea265f8851a2

## Text

```text
class ExtractMinute(Extract)
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
- posted_at: `2026-11-09T22:39:46.1530690+00:00`

## Data

```json
{
  "end_line": 176,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 175,
  "symbol": "ExtractMinute"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":175,"selector":"L175-L176","symbol":"ExtractMinute"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::ExtractMinute](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 176,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 175,
    "symbol": "ExtractMinute"
  },
  "id": "ac952138-2005-4ea0-9386-ea265f8851a2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.1530690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 175,
        "selector": "L175-L176",
        "symbol": "ExtractMinute"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "b61a29ef-e7bb-405a-89e8-0563cc40cb68",
  "subject_name": "django/db/models/functions/datetime::ExtractMinute",
  "tags": [
    "entity:class"
  ],
  "text": "class ExtractMinute(Extract)"
}
```
