# Fact a335d4f0

Store id: d2aef152-5534-48e5-966d-6055fdb18c69

## Text

```text
class TruncHour(TruncBase)
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
- posted_at: `2026-11-09T23:32:01.3002420+00:00`

## Data

```json
{
  "end_line": 408,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 407,
  "symbol": "TruncHour"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":407,"selector":"L407-L408","symbol":"TruncHour"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::TruncHour](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 408,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 407,
    "symbol": "TruncHour"
  },
  "id": "d2aef152-5534-48e5-966d-6055fdb18c69",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.3002420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 407,
        "selector": "L407-L408",
        "symbol": "TruncHour"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "7285adb2-658a-4312-81ca-c76e13dfef52",
  "subject_name": "django/db/models/functions/datetime::TruncHour",
  "tags": [
    "entity:class"
  ],
  "text": "class TruncHour(TruncBase)"
}
```
