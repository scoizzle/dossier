# Fact 452eb6e2

Store id: ef8838f4-3702-40f9-80fe-080ec74efcad

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
- posted_at: `2026-11-09T23:31:54.1475700+00:00`

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
  "id": "ef8838f4-3702-40f9-80fe-080ec74efcad",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.1475700+00:00"
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
  "subject_id": "8a757d10-1348-4f65-83e6-15587224deb1",
  "subject_name": "django/db/models/constraints::BaseConstraint._expression_refs_exclude",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _expression_refs_exclude(cls, model, expression, exclude)"
}
```
