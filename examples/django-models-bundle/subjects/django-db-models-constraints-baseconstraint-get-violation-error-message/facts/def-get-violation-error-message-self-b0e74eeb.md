# Fact b0e74eeb

Store id: 682e231d-0e7b-4acb-bf78-3943863ab188

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
- posted_at: `2026-11-09T23:44:48.7746040+00:00`

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
  "id": "682e231d-0e7b-4acb-bf78-3943863ab188",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.7746040+00:00"
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
  "subject_id": "eb9f92ba-aaec-4efa-942a-0e7ff1e2fffc",
  "subject_name": "django/db/models/constraints::BaseConstraint.get_violation_error_message",
  "tags": [
    "entity:method"
  ],
  "text": "def get_violation_error_message(self)"
}
```
