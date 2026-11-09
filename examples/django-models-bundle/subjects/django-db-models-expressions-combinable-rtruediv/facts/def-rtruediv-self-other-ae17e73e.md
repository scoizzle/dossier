# Fact ae17e73e

Store id: 836b737e-31fb-4f2c-9e8a-1a47df17c95d

## Text

```text
def __rtruediv__(self, other)
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
- posted_at: `2026-11-09T23:44:49.2553930+00:00`

## Data

```json
{
  "end_line": 143,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 142,
  "symbol": "Combinable.__rtruediv__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":142,"selector":"L142-L143","symbol":"Combinable.__rtruediv__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__rtruediv__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 143,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 142,
    "symbol": "Combinable.__rtruediv__"
  },
  "id": "836b737e-31fb-4f2c-9e8a-1a47df17c95d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.2553930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 142,
        "selector": "L142-L143",
        "symbol": "Combinable.__rtruediv__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "f2a2a85c-15c1-45d5-8836-31dc37add46c",
  "subject_name": "django/db/models/expressions::Combinable.__rtruediv__",
  "tags": [
    "entity:method"
  ],
  "text": "def __rtruediv__(self, other)"
}
```
