# Fact 452eb6e2

Store id: e467f808-d927-4e89-851f-eebb1ce80446

## Text

```text
def _expression_refs_exclude(cls, model, expression, exclude)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class_method`, `decorator:classmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:48.7734980+00:00`

## Data

```json
{
  "end_line": 66,
  "entity_kind": "class_method",
  "parent": "BaseConstraint",
  "start_line": 52,
  "symbol": "BaseConstraint._expression_refs_exclude"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":52,"selector":"L52-L66","symbol":"BaseConstraint._expression_refs_exclude"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::BaseConstraint._expression_refs_exclude](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 66,
    "entity_kind": "class_method",
    "parent": "BaseConstraint",
    "start_line": 52,
    "symbol": "BaseConstraint._expression_refs_exclude"
  },
  "id": "e467f808-d927-4e89-851f-eebb1ce80446",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.7734980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 52,
        "selector": "L52-L66",
        "symbol": "BaseConstraint._expression_refs_exclude"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "f807e14c-cbc4-4d68-82c0-5507a114afec",
  "subject_name": "django/db/models/constraints::BaseConstraint._expression_refs_exclude",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _expression_refs_exclude(cls, model, expression, exclude)"
}
```
