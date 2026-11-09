# Fact 196e2034

Store id: 861ab9bf-eaf2-4433-909c-f05b556c0e67

## Text

```text
class FetchMode
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
- posted_at: `2026-11-09T22:39:41.9682760+00:00`

## Data

```json
{
  "end_line": 10,
  "entity_kind": "class",
  "parent": "fetch_modes",
  "start_line": 4,
  "symbol": "FetchMode"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fetch_modes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":4,"selector":"L4-L10","symbol":"FetchMode"}`

## Referenced by

None.

## Subject

[django/db/models/fetch_modes::FetchMode](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 10,
    "entity_kind": "class",
    "parent": "fetch_modes",
    "start_line": 4,
    "symbol": "FetchMode"
  },
  "id": "861ab9bf-eaf2-4433-909c-f05b556c0e67",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.9682760+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 4,
        "selector": "L4-L10",
        "symbol": "FetchMode"
      },
      "rel": "derived_from",
      "target": "django/db/models/fetch_modes.py"
    }
  ],
  "status": "live",
  "subject_id": "7a84df25-8ee8-48f1-b895-90182a1c6ecf",
  "subject_name": "django/db/models/fetch_modes::FetchMode",
  "tags": [
    "entity:class"
  ],
  "text": "class FetchMode"
}
```
