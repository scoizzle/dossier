# Fact bc07308c

Store id: 5eb78d51-52a7-47b9-82a3-51c3ffc06b1d

## Text

```text
def __truediv__(self, other)
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
- posted_at: `2026-11-09T23:44:49.2436390+00:00`

## Data

```json
{
  "end_line": 89,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 88,
  "symbol": "Combinable.__truediv__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":88,"selector":"L88-L89","symbol":"Combinable.__truediv__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__truediv__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 89,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 88,
    "symbol": "Combinable.__truediv__"
  },
  "id": "5eb78d51-52a7-47b9-82a3-51c3ffc06b1d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.2436390+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 88,
        "selector": "L88-L89",
        "symbol": "Combinable.__truediv__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "95a727af-db2f-402d-8cce-1e7dcaefcb3f",
  "subject_name": "django/db/models/expressions::Combinable.__truediv__",
  "tags": [
    "entity:method"
  ],
  "text": "def __truediv__(self, other)"
}
```
