# Fact 361d09de

Store id: cb96b391-0201-4b51-a92e-33603cb0b2e1

## Text

```text
def _resolve_output_field(self)
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
- posted_at: `2026-11-09T23:44:49.6386250+00:00`

## Data

```json
{
  "end_line": 1842,
  "entity_kind": "method",
  "parent": "Subquery",
  "start_line": 1841,
  "symbol": "Subquery._resolve_output_field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1841,"selector":"L1841-L1842","symbol":"Subquery._resolve_output_field"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Subquery._resolve_output_field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1842,
    "entity_kind": "method",
    "parent": "Subquery",
    "start_line": 1841,
    "symbol": "Subquery._resolve_output_field"
  },
  "id": "cb96b391-0201-4b51-a92e-33603cb0b2e1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6386250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1841,
        "selector": "L1841-L1842",
        "symbol": "Subquery._resolve_output_field"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "42d5a115-002d-4bb6-be26-68f037c37ead",
  "subject_name": "django/db/models/expressions::Subquery._resolve_output_field",
  "tags": [
    "entity:method"
  ],
  "text": "def _resolve_output_field(self)"
}
```
