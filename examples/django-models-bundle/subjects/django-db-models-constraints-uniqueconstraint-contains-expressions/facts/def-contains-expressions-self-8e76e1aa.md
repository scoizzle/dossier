# Fact 8e76e1aa

Store id: d2d92947-f088-45c8-9139-4114703bf4e2

## Text

```text
def contains_expressions(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:40.7245890+00:00`

## Data

```json
{
  "end_line": 342,
  "entity_kind": "method",
  "parent": "UniqueConstraint",
  "start_line": 340,
  "symbol": "UniqueConstraint.contains_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":340,"selector":"L340-L342","symbol":"UniqueConstraint.contains_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::UniqueConstraint.contains_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 342,
    "entity_kind": "method",
    "parent": "UniqueConstraint",
    "start_line": 340,
    "symbol": "UniqueConstraint.contains_expressions"
  },
  "id": "d2d92947-f088-45c8-9139-4114703bf4e2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.7245890+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 340,
        "selector": "L340-L342",
        "symbol": "UniqueConstraint.contains_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "1361e1f2-9b2d-4d75-931a-c6e63ec3c082",
  "subject_name": "django/db/models/constraints::UniqueConstraint.contains_expressions",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def contains_expressions(self)"
}
```
