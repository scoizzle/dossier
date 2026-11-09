# Fact b50d77a5

Store id: c6bfa50e-f9bc-43aa-88ec-a2b84f36ecfb

## Text

```text
def resolve_expression(self, *args, **kwargs)
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
- posted_at: `2026-11-09T22:39:49.7294230+00:00`

## Data

```json
{
  "end_line": 2327,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 2324,
  "symbol": "QuerySet.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2324,"selector":"L2324-L2327","symbol":"QuerySet.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2327,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 2324,
    "symbol": "QuerySet.resolve_expression"
  },
  "id": "c6bfa50e-f9bc-43aa-88ec-a2b84f36ecfb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.7294230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2324,
        "selector": "L2324-L2327",
        "symbol": "QuerySet.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "3a1fc71e-2a90-4d34-a50a-fda776186852",
  "subject_name": "django/db/models/query::QuerySet.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression(self, *args, **kwargs)"
}
```
