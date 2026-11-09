# Fact 749bd1ba

Store id: f097c9f2-9d1f-4876-bfc6-e2f258a8012a

## Text

```text
def __sub__(self, other)
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
- posted_at: `2026-11-09T22:39:41.4732600+00:00`

## Data

```json
{
  "end_line": 83,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 82,
  "symbol": "Combinable.__sub__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":82,"selector":"L82-L83","symbol":"Combinable.__sub__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__sub__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 83,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 82,
    "symbol": "Combinable.__sub__"
  },
  "id": "f097c9f2-9d1f-4876-bfc6-e2f258a8012a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.4732600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 82,
        "selector": "L82-L83",
        "symbol": "Combinable.__sub__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "a0355d9d-af8a-46bf-8108-de58b04d8ba4",
  "subject_name": "django/db/models/expressions::Combinable.__sub__",
  "tags": [
    "entity:method"
  ],
  "text": "def __sub__(self, other)"
}
```
