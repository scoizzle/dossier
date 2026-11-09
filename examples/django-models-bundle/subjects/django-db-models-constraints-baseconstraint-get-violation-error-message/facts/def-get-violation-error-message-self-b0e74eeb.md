# Fact b0e74eeb

Store id: ef9ebcae-da61-49a2-a836-29ca586f6ad8

## Text

```text
def get_violation_error_message(self)
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
- posted_at: `2026-11-09T22:39:40.7023180+00:00`

## Data

```json
{
  "end_line": 72,
  "entity_kind": "method",
  "parent": "BaseConstraint",
  "start_line": 71,
  "symbol": "BaseConstraint.get_violation_error_message"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":71,"selector":"L71-L72","symbol":"BaseConstraint.get_violation_error_message"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::BaseConstraint.get_violation_error_message](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 72,
    "entity_kind": "method",
    "parent": "BaseConstraint",
    "start_line": 71,
    "symbol": "BaseConstraint.get_violation_error_message"
  },
  "id": "ef9ebcae-da61-49a2-a836-29ca586f6ad8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.7023180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 71,
        "selector": "L71-L72",
        "symbol": "BaseConstraint.get_violation_error_message"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "a6ac91f9-bf77-448a-8507-5eae5049e7df",
  "subject_name": "django/db/models/constraints::BaseConstraint.get_violation_error_message",
  "tags": [
    "entity:method"
  ],
  "text": "def get_violation_error_message(self)"
}
```
