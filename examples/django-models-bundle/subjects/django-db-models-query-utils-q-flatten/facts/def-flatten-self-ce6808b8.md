# Fact ce6808b8

Store id: ec41eaf9-8e81-407a-8d50-db4cfa8bec8b

## Text

```text
def flatten(self)
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
- posted_at: `2026-11-09T23:32:05.0796410+00:00`

## Data

```json
{
  "end_line": 169,
  "entity_kind": "method",
  "parent": "Q",
  "start_line": 156,
  "symbol": "Q.flatten"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":156,"selector":"L156-L169","symbol":"Q.flatten"}`

## Items

```json
[
  {
    "text": "Recursively yield this Q object and all subexpressions, in depth-first order.",
    "locator": {
      "line": 157
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q.flatten](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 169,
    "entity_kind": "method",
    "parent": "Q",
    "start_line": 156,
    "symbol": "Q.flatten"
  },
  "id": "ec41eaf9-8e81-407a-8d50-db4cfa8bec8b",
  "items": [
    {
      "locator": {
        "line": 157
      },
      "text": "Recursively yield this Q object and all subexpressions, in depth-first order."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.0796410+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 156,
        "selector": "L156-L169",
        "symbol": "Q.flatten"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "6eab433e-dadc-44d5-9f61-32a6a6f5954d",
  "subject_name": "django/db/models/query_utils::Q.flatten",
  "tags": [
    "entity:method"
  ],
  "text": "def flatten(self)"
}
```
