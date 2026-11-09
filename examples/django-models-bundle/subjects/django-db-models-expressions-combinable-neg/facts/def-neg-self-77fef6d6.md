# Fact 77fef6d6

Store id: e74cc1ac-490e-4296-853a-8b9feffc4549

## Text

```text
def __neg__(self)
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
- posted_at: `2026-11-09T23:44:49.2407430+00:00`

## Data

```json
{
  "end_line": 77,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 76,
  "symbol": "Combinable.__neg__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":76,"selector":"L76-L77","symbol":"Combinable.__neg__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__neg__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 77,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 76,
    "symbol": "Combinable.__neg__"
  },
  "id": "e74cc1ac-490e-4296-853a-8b9feffc4549",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.2407430+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 76,
        "selector": "L76-L77",
        "symbol": "Combinable.__neg__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "0cf2de02-cf43-4562-a92b-6a0b5b202a29",
  "subject_name": "django/db/models/expressions::Combinable.__neg__",
  "tags": [
    "entity:method"
  ],
  "text": "def __neg__(self)"
}
```
