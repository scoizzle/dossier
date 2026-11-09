# Fact 68102043

Store id: 66c2d7cc-825d-46c2-a94d-68851eec7648

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
- posted_at: `2026-11-09T22:39:40.6987060+00:00`

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
  "id": "66c2d7cc-825d-46c2-a94d-68851eec7648",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.6987060+00:00"
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
  "subject_id": "bf803b34-4718-4d32-8cfa-ee989465034c",
  "subject_name": "django/db/models/constraints::BaseConstraint.contains_expressions",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def contains_expressions(self)"
}
```
