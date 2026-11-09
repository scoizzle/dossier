# Fact 63d7fb9d

Store id: 9fadb28c-8f9b-4886-bf96-f0004efd0227

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T23:31:54.1999660+00:00`

## Data

```json
{
  "end_line": 242,
  "entity_kind": "method",
  "parent": "CheckConstraint",
  "start_line": 226,
  "symbol": "CheckConstraint.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":226,"selector":"L226-L242","symbol":"CheckConstraint.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::CheckConstraint.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 242,
    "entity_kind": "method",
    "parent": "CheckConstraint",
    "start_line": 226,
    "symbol": "CheckConstraint.__repr__"
  },
  "id": "9fadb28c-8f9b-4886-bf96-f0004efd0227",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.1999660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 226,
        "selector": "L226-L242",
        "symbol": "CheckConstraint.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "b388360e-e5b4-4986-92aa-82f7593d0b3a",
  "subject_name": "django/db/models/constraints::CheckConstraint.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
