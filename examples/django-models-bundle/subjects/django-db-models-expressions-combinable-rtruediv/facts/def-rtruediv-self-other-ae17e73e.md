# Fact ae17e73e

Store id: a85636c8-a337-4acd-8b98-cf58d441ffc9

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
- posted_at: `2026-11-09T23:31:55.7475610+00:00`

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
  "id": "a85636c8-a337-4acd-8b98-cf58d441ffc9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7475610+00:00"
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
  "subject_id": "729412c4-07bb-4303-b960-63b3605b50c6",
  "subject_name": "django/db/models/expressions::Combinable.__rtruediv__",
  "tags": [
    "entity:method"
  ],
  "text": "def __rtruediv__(self, other)"
}
```
