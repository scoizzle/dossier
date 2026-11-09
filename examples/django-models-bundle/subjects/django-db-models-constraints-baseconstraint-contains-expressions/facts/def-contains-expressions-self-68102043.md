# Fact 68102043

Store id: b104d4f6-51f8-4301-ab8e-a13e8799fc12

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
- posted_at: `2026-11-09T23:31:54.1386610+00:00`

## Data

```json
{
  "end_line": 41,
  "entity_kind": "method",
  "parent": "BaseConstraint",
  "start_line": 39,
  "symbol": "BaseConstraint.contains_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":39,"selector":"L39-L41","symbol":"BaseConstraint.contains_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::BaseConstraint.contains_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 41,
    "entity_kind": "method",
    "parent": "BaseConstraint",
    "start_line": 39,
    "symbol": "BaseConstraint.contains_expressions"
  },
  "id": "b104d4f6-51f8-4301-ab8e-a13e8799fc12",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.1386610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 39,
        "selector": "L39-L41",
        "symbol": "BaseConstraint.contains_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "66edfb75-d8ff-4ae2-8ae0-f8dde90ffff6",
  "subject_name": "django/db/models/constraints::BaseConstraint.contains_expressions",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def contains_expressions(self)"
}
```
