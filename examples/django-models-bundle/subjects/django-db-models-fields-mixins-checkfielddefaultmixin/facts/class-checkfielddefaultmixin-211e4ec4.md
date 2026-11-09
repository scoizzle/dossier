# Fact 211e4ec4

Store id: 7fe30f5d-2064-4bb3-812d-ebf55a0316cd

## Text

```text
class CheckFieldDefaultMixin
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
- posted_at: `2026-11-09T23:31:58.2344910+00:00`

## Data

```json
{
  "end_line": 65,
  "entity_kind": "class",
  "parent": "mixins",
  "start_line": 37,
  "symbol": "CheckFieldDefaultMixin"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/mixins.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":37,"selector":"L37-L65","symbol":"CheckFieldDefaultMixin"}`

## Referenced by

None.

## Subject

[django/db/models/fields/mixins::CheckFieldDefaultMixin](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 65,
    "entity_kind": "class",
    "parent": "mixins",
    "start_line": 37,
    "symbol": "CheckFieldDefaultMixin"
  },
  "id": "7fe30f5d-2064-4bb3-812d-ebf55a0316cd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.2344910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 37,
        "selector": "L37-L65",
        "symbol": "CheckFieldDefaultMixin"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/mixins.py"
    }
  ],
  "status": "live",
  "subject_id": "f40871a9-4be7-44ab-81aa-ed0e0189065f",
  "subject_name": "django/db/models/fields/mixins::CheckFieldDefaultMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class CheckFieldDefaultMixin"
}
```
