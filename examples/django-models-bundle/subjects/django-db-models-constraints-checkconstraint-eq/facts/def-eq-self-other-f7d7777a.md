# Fact f7d7777a

Store id: c914e0c2-b048-4a8a-abd9-0b6e82a27c0b

## Text

```text
def __eq__(self, other)
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
- posted_at: `2026-11-09T23:44:48.7820950+00:00`

## Data

```json
{
  "end_line": 252,
  "entity_kind": "method",
  "parent": "CheckConstraint",
  "start_line": 244,
  "symbol": "CheckConstraint.__eq__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":244,"selector":"L244-L252","symbol":"CheckConstraint.__eq__"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::CheckConstraint.__eq__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 252,
    "entity_kind": "method",
    "parent": "CheckConstraint",
    "start_line": 244,
    "symbol": "CheckConstraint.__eq__"
  },
  "id": "c914e0c2-b048-4a8a-abd9-0b6e82a27c0b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.7820950+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 244,
        "selector": "L244-L252",
        "symbol": "CheckConstraint.__eq__"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "13f8e481-dd9f-43b5-a03b-f2312d1c8e83",
  "subject_name": "django/db/models/constraints::CheckConstraint.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```
