# Fact 63d7fb9d

Store id: 9bec78f0-0ec5-4a9d-84ce-6588101dd733

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
- posted_at: `2026-11-09T23:44:48.7815160+00:00`

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
  "id": "9bec78f0-0ec5-4a9d-84ce-6588101dd733",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.7815160+00:00"
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
  "subject_id": "9c4ca96d-c9a2-4f0d-bca7-720d9dd17d99",
  "subject_name": "django/db/models/constraints::CheckConstraint.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
