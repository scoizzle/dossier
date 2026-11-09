# Fact 60142114

Store id: a15a5e28-8793-4828-9475-d126d82c9de8

## Text

```text
def slice_expression(self, expression, start, length)
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
- posted_at: `2026-11-09T22:39:42.6513760+00:00`

## Data

```json
{
  "end_line": 2598,
  "entity_kind": "method",
  "parent": "TextField",
  "start_line": 2595,
  "symbol": "TextField.slice_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2595,"selector":"L2595-L2598","symbol":"TextField.slice_expression"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TextField.slice_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2598,
    "entity_kind": "method",
    "parent": "TextField",
    "start_line": 2595,
    "symbol": "TextField.slice_expression"
  },
  "id": "a15a5e28-8793-4828-9475-d126d82c9de8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6513760+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2595,
        "selector": "L2595-L2598",
        "symbol": "TextField.slice_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "0c75e17f-a673-453a-b09e-c7eb479274d6",
  "subject_name": "django/db/models/fields/__init__::TextField.slice_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def slice_expression(self, expression, start, length)"
}
```
