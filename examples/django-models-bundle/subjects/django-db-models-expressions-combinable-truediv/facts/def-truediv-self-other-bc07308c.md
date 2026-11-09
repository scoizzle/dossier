# Fact bc07308c

Store id: 20473127-daa4-4318-8c0c-412ca5455ad9

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
- posted_at: `2026-11-09T22:39:41.4748920+00:00`

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
  "id": "20473127-daa4-4318-8c0c-412ca5455ad9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.4748920+00:00"
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
  "subject_id": "8d22c80b-b19f-4e40-8c6b-2574bedefbeb",
  "subject_name": "django/db/models/expressions::Combinable.__truediv__",
  "tags": [
    "entity:method"
  ],
  "text": "def __truediv__(self, other)"
}
```
