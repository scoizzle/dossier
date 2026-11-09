# Fact d0a747fd

Store id: cf4871ab-4dab-418e-bb91-c1cb9b35b605

## Text

```text
def deconstruct(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:40.7178940+00:00`

## Data

```json
{
  "end_line": 257,
  "entity_kind": "method",
  "parent": "CheckConstraint",
  "start_line": 254,
  "symbol": "CheckConstraint.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":254,"selector":"L254-L257","symbol":"CheckConstraint.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::CheckConstraint.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 257,
    "entity_kind": "method",
    "parent": "CheckConstraint",
    "start_line": 254,
    "symbol": "CheckConstraint.deconstruct"
  },
  "id": "cf4871ab-4dab-418e-bb91-c1cb9b35b605",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.7178940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 254,
        "selector": "L254-L257",
        "symbol": "CheckConstraint.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "b24c883a-6b42-41b2-a7d4-2d656e0fda62",
  "subject_name": "django/db/models/constraints::CheckConstraint.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
