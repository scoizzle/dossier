# Fact dc6593a4

Store id: fea413f7-af5e-48a6-98cf-a2d547c134e8

## Text

```text
def __rxor__(self, other)
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
- posted_at: `2026-11-09T23:31:55.7535450+00:00`

## Data

```json
{
  "end_line": 164,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 161,
  "symbol": "Combinable.__rxor__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":161,"selector":"L161-L164","symbol":"Combinable.__rxor__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__rxor__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 164,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 161,
    "symbol": "Combinable.__rxor__"
  },
  "id": "fea413f7-af5e-48a6-98cf-a2d547c134e8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7535450+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 161,
        "selector": "L161-L164",
        "symbol": "Combinable.__rxor__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "55621000-c7b8-431a-82b0-512987d90aeb",
  "subject_name": "django/db/models/expressions::Combinable.__rxor__",
  "tags": [
    "entity:method"
  ],
  "text": "def __rxor__(self, other)"
}
```
