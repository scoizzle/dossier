# Fact 96ae5316

Store id: fc17b8dc-373d-48fd-8a7a-54f64dbb538c

## Text

```text
class TruncBase(TimezoneMixin, Transform)
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
- posted_at: `2026-11-09T22:39:46.1727830+00:00`

## Data

```json
{
  "end_line": 345,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 244,
  "symbol": "TruncBase"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":244,"selector":"L244-L345","symbol":"TruncBase"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::TruncBase](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 345,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 244,
    "symbol": "TruncBase"
  },
  "id": "fc17b8dc-373d-48fd-8a7a-54f64dbb538c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.1727830+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 244,
        "selector": "L244-L345",
        "symbol": "TruncBase"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "27c23625-aacc-461e-bc7f-c011be5d177e",
  "subject_name": "django/db/models/functions/datetime::TruncBase",
  "tags": [
    "entity:class"
  ],
  "text": "class TruncBase(TimezoneMixin, Transform)"
}
```
